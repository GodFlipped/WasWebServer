using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class InductChartQuery
    {
        /// <summary>
        /// PicBase64Info
        /// </summary>
        public string PicBase64Info { get; set; }


        /// <summary>
        /// 导入台
        /// </summary>
        public string InductId { get; set; }

        /// <summary>
        /// Connect
        /// </summary>
        public string ConnectId { get; set; }

        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime CreateTimeEnd { get; set; }
    }
}
