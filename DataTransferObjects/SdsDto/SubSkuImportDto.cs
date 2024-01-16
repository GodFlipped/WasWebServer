using Kengic.Common.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasWebServerCore.DataTransferObjects.SdsDto
{
    /// <summary>
    ///     public class SorterPlanImportDto
    /// </summary>
    public class SorterPlanImportDto
    {
        public string DeviceId { get; set; }
        public string Ndc { get; set; }
        public string DestinationFullName { get; set; }
        public string SorterPlan { get; set; }
        public string Client { get; set; }
        public string Mot { get; set; }
        public string CutoffTimings { get; set; }
        public string BagIdentifier { get; set; }
        public string BagType { get; set; }
        public string SortCode { get; set; }
    }

}
