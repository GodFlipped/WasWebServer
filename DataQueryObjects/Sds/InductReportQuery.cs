using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class InductReportQuery
    {
        /// <summary>
        /// ScsServer
        /// </summary>
        public string Connect { get; set; }
        /// <summary>
        /// InductNo
        /// </summary>
        public string Induct { get; set; }
        /// <summary>
        /// date
        /// </summary>
        public DateTime Date { get; set; }
    }
}
