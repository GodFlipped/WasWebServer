using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    public class OverviewReportQuery
    {
        public DateTime Date { get; set; }

        /// <summary>
        /// ScsServer
        /// </summary>
        public string Connect { get; set; }
        /// <summary>
        /// InductNo
        /// </summary>
        public string Induct { get; set; }
    }
}
