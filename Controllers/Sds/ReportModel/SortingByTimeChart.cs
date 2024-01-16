using System.Collections.Generic;

namespace WasWebServerCore.Controllers.Sds.ReportModel
{
    /// <summary>
    /// 时间图表
    /// </summary>
    public class SortingByTimeChart
    {
        /// <summary>
        /// 值
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        
    }

    public class MutiSortingByTimeChart
    {
        public string WorktaskType { get; set; }

        public List<SortingByTimeChart> SortingByTime { get; set; }
    }
}