using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class ReportQuery 
    {
        /// <summary>
        /// PicBase64Info
        /// </summary>
        public string PicBase64Info { get; set; }
        /// <summary>
        /// 时间间隔
        /// </summary>
        public string Interval { get; set; }

        /// <summary>
        /// 格口号
        /// </summary>
        public string ShutId { get; set; }
        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime CreateTimeEnd { get; set; }
        /// <summary>
        /// 执行者
        /// </summary>
        public string Exector { get; set; }
        /// <summary>
        /// 相机
        /// </summary>
        public string CameraNo { get; set; }
    }
}