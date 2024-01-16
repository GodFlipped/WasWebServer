using System.Collections.Generic;

namespace WasWebServerCore.Controllers.Sds.ReportModel
{
    public class InductOverviewDto
    {
        public string FirstTime { get; set; }


        public long Total { get; set; }

        public List<InductCount> InductRate { get; set; }

        public long LossCount { get; set; }

        public double LossRate { get; set; }

        public double IdleTime { get; set; }
    }

    public class InductCount
    {
        public int Time { get; set; }

        public int Count { get; set; }
    }
}
