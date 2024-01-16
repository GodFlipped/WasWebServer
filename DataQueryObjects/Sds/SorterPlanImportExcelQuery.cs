// -----------------------------------------------------------------------
// <copyright file="InboundImportExcelQuery.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
using System.Collections.Generic;
using WasWebServerCore.DataTransferObjects.SdsDto;

namespace WasWebServerCore.DataQueryObjects.Sds
{
    /// <summary>
    /// SubSkuImportExcelQuery.
    /// </summary>
    public class SorterPlanImportExcelQuery
    {
        /// <summary>
        /// Datas.
        /// </summary>
        public List<SorterPlanImportDto> datas { get; set; }
    }
}