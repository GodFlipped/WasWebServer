namespace WasWebServerCore.Controllers.Sds.ReportModel
{
    public class PeakOverviewDto
    {

        public string Time { get; set; }

        public string Induct { get; set; }

        public int Success { get; set; }

        public int Failed { get; set; }
    }
}
