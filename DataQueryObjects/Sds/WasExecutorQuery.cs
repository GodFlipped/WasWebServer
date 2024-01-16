using System;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// WasExecutorQuery.
    /// </summary>
    public class WasExecutorQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 执行者.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string ExecuteOperator { get; set; }

        /// <summary>
        /// 连接.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Connection { get; set; }


        /// <summary>
        /// 创建者
        /// </summary>
        /// /// <summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// 创建时间开始
        /// </summary>
        public DateTime? CreateTimeStart { get; set; }
        /// <summary>
        /// 创建时间结束
        /// </summary>
        public DateTime? CreateTimeEnd { get; set; }
        /// <summary>
        /// 更新者
        /// </summary>
        public string UpdateBy { get; set; }
        /// <summary>
        /// 更新时间开始
        /// </summary>
        public DateTime? UpdateTimeStart { get; set; }
        /// <summary>
        /// 更新时间结束
        /// </summary>
        public DateTime? UpdateTimeEnd { get; set; }
    }
}