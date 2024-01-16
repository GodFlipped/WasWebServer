using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;

namespace WasWebServerNew.Infrastructure.OPC
{

    public enum ExitCode : int
    {
        Ok = 0,
        ErrorCreateApplication = 0x11,
        ErrorDiscoverEndpoints = 0x12,
        ErrorCreateSession = 0x13,
        ErrorBrowseNamespace = 0x14,
        ErrorCreateSubscription = 0x15,
        ErrorMonitoredItem = 0x16,
        ErrorAddSubscription = 0x17,
        ErrorRunning = 0x18,
        ErrorNoKeepAlive = 0x30,
        ErrorInvalidCommandLine = 0x100
    };

    public class OpcUaClient
    {
        const int ReconnectPeriod = 10;
        Session session;
        SessionReconnectHandler reconnectHandler;
        string endpointURL;
        int clientRunTime = Timeout.Infinite;
        static bool autoAccept = false;
        static ExitCode exitCode;

        public OpcUaClient(string _endpointURL, bool _autoAccept, int _stopTimeout)
        {
            endpointURL = _endpointURL;
            autoAccept = _autoAccept;
            clientRunTime = _stopTimeout <= 0 ? Timeout.Infinite : _stopTimeout * 1000;

            createConnectAsync().Wait();
            
        }


        public Tuple<bool,NodeId> GetNodeIdByDisPlayName(string tagName,NodeId refNode = null)
        {
           
                try
                {
                    ReferenceDescriptionCollection references;

                    if (refNode != null)
                    {
                        references = session.FetchReferences(refNode);
                    }
                    else
                    {
                        references = session.FetchReferences(ObjectIds.ObjectsFolder);
                    }

                    var rd = references.Where(n => n.DisplayName.Text == tagName).FirstOrDefault();
                    var nodeId = ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris);
                    return new Tuple<bool, NodeId> (true,nodeId);
                }catch(Exception e)
                {
                    return new Tuple<bool, NodeId>(false, null);
                }

          
            
        }

        public Tuple<bool,object> GetValues(NodeId nodeId)
        {
            if (session.Connected)
            {
                try
                {
                    return new Tuple<bool, object>(true, session.ReadValue(nodeId).Value); ;
                }
                catch(Exception e)
                {
                    return new Tuple<bool, object>(false, e.Message);
                }
            }
            else
            {
                return new Tuple<bool, object>(false,"not Connect");
            }
            
        }

        public async Task createConnectAsync()
        {
            ApplicationInstance application = new ApplicationInstance
            {
                ApplicationName = "",
                ApplicationType = ApplicationType.Client
            };
            ApplicationConfiguration config = await application.LoadApplicationConfiguration(
                AppDomain.CurrentDomain.BaseDirectory +
                @"\Infrastructure\OPC\Opc.Ua.Client.Config.xml", false);
             bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
            if (!haveAppCertificate)
            {
                throw new Exception("Application instance certificate invalid!");
            }

            if (haveAppCertificate)
            {
                config.ApplicationUri = X509Utils.GetApplicationUriFromCertificate(config.SecurityConfiguration.ApplicationCertificate.Certificate);
                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    autoAccept = true;
                }
                config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }
            exitCode = ExitCode.ErrorDiscoverEndpoints;
            var selectedEndpoint = CoreClientUtils.SelectEndpoint(endpointURL, haveAppCertificate, 15000);
                selectedEndpoint.SecurityPolicyUri.Substring(selectedEndpoint.SecurityPolicyUri.LastIndexOf('#') + 1);

            exitCode = ExitCode.ErrorCreateSession;
            var endpointConfiguration = EndpointConfiguration.Create(config);
            var endpoint = new ConfiguredEndpoint(null, selectedEndpoint, endpointConfiguration);
            session = await Session.Create(config, endpoint, false, "OPC UA Client", 60000, new UserIdentity(new AnonymousIdentityToken()), null);
            session.KeepAlive += Client_KeepAlive;

        }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
            {
                e.Accept = autoAccept;

            }
        }
        private void Client_KeepAlive(Session sender, KeepAliveEventArgs e)
        {
            if (e.Status != null && ServiceResult.IsNotGood(e.Status))
            {
               

                if (reconnectHandler == null)
                {
                    
                    reconnectHandler = new SessionReconnectHandler();
                    reconnectHandler.BeginReconnect(sender, ReconnectPeriod * 1000, Client_ReconnectComplete);
                }
            }
        }

        private void Client_ReconnectComplete(object sender, EventArgs e)
        {

            if (!Object.ReferenceEquals(sender, reconnectHandler))
            {
                return;
            }

            session = reconnectHandler.Session;
            reconnectHandler.Dispose();
            reconnectHandler = null;

        }


        public static ExitCode ExitCode { get => exitCode; }


    }
    
}

