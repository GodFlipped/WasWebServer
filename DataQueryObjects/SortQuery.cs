// -----------------------------------------------------------------------
// <copyright file="SortQuery.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace WasWebServerCore.DataQueryObjects
{
    /// <summary>
    /// SortDto
    /// </summary>
    public class SortQuery
    {
        /// <summary>
        /// OrderField
        /// </summary>
        /// <value>
        /// 变量名
        /// </value>
        public string OrderField { get; set; }

        /// <summary>
        /// Sortord
        /// </summary>
        /// <value>
        /// "Desc" 倒序
        ///   空 正序
        /// </value>
        public string Sortord { get; set; }
    }
}