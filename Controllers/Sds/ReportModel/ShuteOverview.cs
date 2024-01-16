using System.Collections.Generic;

namespace WasWebServerCore.Controllers.Sds.ReportModel
{
    public class ShuteOverview
    {
        public int OneMore { get; set; }

        public int TwoMore { get; set; }

        public int ThreeMore { get; set; }

        public int Nomal { get; set; }

        public int LoopBack { get; set; }

        public List<string> BlockedShutes { get; set; }

        public int Nc { get; set; }
        public string Alert { get; set; }
    }
}
