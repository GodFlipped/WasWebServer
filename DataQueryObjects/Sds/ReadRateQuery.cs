using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    public class ReadRateQuery
    {
        public string PicBase64Info { get; set; }
        /// <summary>
        /// 时间间隔
        /// </summary>
        public string Interval { get; set; }

        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime CreateTimeEnd { get; set; }

        public string Exector { get; set; }


        public string CameraNo { get; set; }
    }
}
