namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeQuery.
    /// </summary>
    public class AlarmEventAddQuery : SortQuery
    {
        /// <summary>
        /// Id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 对象
        /// </summary>
        public string Object { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Grade { get; set; }
    }
}