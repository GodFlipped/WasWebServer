namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// LocationTypeAddQuery.
    /// </summary>
    public class SorterPlanAddQuery : SortQuery
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
        /// 场地代码
        /// </summary>
        public string SiteNo { get; set; }


        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// 分拣模式
        /// </summary>
        public string SorterMode { get; set; }
    }
}