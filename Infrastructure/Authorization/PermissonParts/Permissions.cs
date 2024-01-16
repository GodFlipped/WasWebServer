// -----------------------------------------------------------------------
// <copyright file="Permissions.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>   Values that represent permissions. </summary>
    public enum Permissions
    {
        NotSet = 0,

        /// <summary>
        /// BarcodeFilter.
        /// </summary>
        [Display(Prompt = "Barcode", GroupName = " BarcodeFilter", Name = "GetBarcodeFilters", Description = "GetBarcodeFilters")]
        BarcodeFilter_GetBarcodeFilters = 0x110101,

        [Display(Prompt = "Barcode", GroupName = " BarcodeFilter", Name = "AddBarcodeFilters", Description = "AddBarcodeFilters")]
        BarcodeFilter_AddBarcodeFilters = 0x110102,

        [Display(Prompt = "Barcode", GroupName = " BarcodeFilter", Name = "UpdateBarcodeFilters", Description = "UpdateBarcodeFilters")]
        BarcodeFilter_UpdateBarcodeFilters = 0x110103,

        [Display(Prompt = "Barcode", GroupName = " BarcodeFilter", Name = "DeleteBarcodeFilters", Description = "DeleteBarcodeFilters")]
        BarcodeFilter_DeleteBarcodeFilters = 0x110104,

        [Display(Prompt = "Barcode", GroupName = " BarcodeFilter", Name = "ExportToExcel", Description = "ExportToExcel")]
        BarcodeFilter_ExportToExcels = 0x110105,


        /// <summary>
        /// BarcodePriority.
        /// </summary>
        [Display(Prompt = "Barcode", GroupName = "BarcodePriority", Name = "GetBarcodePrioritys", Description = "GetBarcodePrioritys")]
        BarcodePriority_GetBarcodePrioritys = 0x110201,


        [Display(Prompt = "Barcode", GroupName = "BarcodePriority", Name = "AddBarcodePrioritys", Description = "AddBarcodePrioritys")]
        BarcodePriority_AddBarcodePrioritys = 0x110202,

        [Display(Prompt = "Barcode", GroupName = "BarcodePriority", Name = "UpdateBarcodePrioritys", Description = "UpdateBarcodePrioritys")]
        BarcodePriority_UpdateBarcodePrioritys = 0x110203,


        [Display(Prompt = "Barcode", GroupName = "BarcodePriority", Name = "DeleteBarcodePrioritys", Description = "DeleteBarcodePrioritys")]
        BarcodePriority_DeleteBarcodePrioritys = 0x110204,


        [Display(Prompt = "Barcode", GroupName = "BarcodePriority", Name = "ExportToExcel", Description = "ExportToExcel")]
        BarcodePriority_ExportToExcel = 0x110205,

        /// <summary>
        /// AlarmEventRecord.
        /// </summary>
        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventRecord", Name = "GetAlarmEventRecords", Description = "GetAlarmEventRecords")]
        AlarmEventRecord_GetAlarmEventRecords = 0x120101,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventRecord", Name = "AddAlarmEventRecords", Description = "AddAlarmEventRecords")]
        AlarmEventRecord_AddAlarmEventRecords = 0x120102,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventRecord", Name = "UpdateAlarmEventRecords", Description = "UpdateAlarmEventRecords")]
        AlarmEventRecord_UpdateAlarmEventRecords = 0x120103,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventRecord", Name = "DeleteAlarmEventRecords", Description = "DeleteAlarmEventRecords")]
        AlarmEventRecord_DeleteAlarmEventRecords = 0x120104,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventRecord", Name = "ExportToExcel", Description = "ExportToExcel")]
        AlarmEventRecord_ExportToExcel = 0x120105,

        /// <summary>
        /// AlarmEventType.
        /// </summary>
        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "GetAlarmEventTypes", Description = "GetAlarmEventTypes")]
        AlarmEventType_GetAlarmEventTypes = 0x120201,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "AddAlarmEventTypes", Description = "AddAlarmEventTypes")]
        AlarmEventType_AddAlarmEventTypes = 0x120202,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "UpdateAlarmEventTypes", Description = "UpdateAlarmEventTypes")]
        AlarmEventType_UpdateAlarmEventTypes = 0x120203,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "DeleteAlarmEventTypes", Description = "DeleteAlarmEventTypes")]
        AlarmEventType_DeleteAlarmEventTypes = 0x120204,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "ExportToExcel", Description = "ExportToExcel")]
        AlarmEventType_ExportToExcel = 0x120205,

        [Display(Prompt = "AlarmEvent", GroupName = "AlarmEventType", Name = "GetDialogAlarmEventTypes", Description = "GetDialogAlarmEventTypes")]
        AlarmEventType_GetDialogAlarmEventTypes = 0x120206,

        /// <summary>
        /// PhysicalSorter.
        /// </summary>
        [Display(Prompt = "Sorter", GroupName = "PhysicalSorter", Name = "GetPhysicalSorters", Description = "GetGetPhysicalSorters")]
        PhysicalSorter_GetPhysicalSorters = 0x130101,

        [Display(Prompt = "Sorter", GroupName = "PhysicalSorter", Name = "AddPhysicalSorters", Description = "AddPhysicalSorters")]
        PhysicalSorter_AddPhysicalSorters = 0x130102,

        [Display(Prompt = "Sorter", GroupName = "PhysicalSorter", Name = "UpdatePhysicalSorters", Description = "UpdatePhysicalSorters")]
        PhysicalSorter_UpdatePhysicalSorters = 0x130103,

        [Display(Prompt = "Sorter", GroupName = "PhysicalSorter", Name = "DeletePhysicalSorters", Description = "DeletePhysicalSorters")]
        PhysicalSorter_DeletePhysicalSorters = 0x130104,

        [Display(Prompt = "Sorter", GroupName = "PhysicalSorter", Name = "ExportToExcel", Description = "ExportToExcel")]
        PhysicalSorter_ExportToExcel = 0x130105,



        /// <summary>
        /// LogicalSorter.
        /// </summary>
        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "GetLogicalSorters", Description = "GetLogicalSorters")]
        LogicalSorter_GetLogicalSorters = 0x130201,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "AddLogicalSorters", Description = "AddLogicalSorters")]
        LogicalSorter_AddLogicalSorters = 0x130202,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "UpdateLogicalSorters", Description = "UpdateLogicalSorters")]
        LogicalSorter_UpdateLogicalSorters = 0x130203,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "DeleteLogicalSorters", Description = "DeleteLogicalSorters")]
        LogicalSorter_DeleteLogicalSorters = 0x130204,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "ExportToExcel", Description = "ExportToExcel")]
        LogicalSorter_ExportToExcel = 0x130205,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "GetLogicalSortersById", Description = "GetLogicalSortersById")]
        LogicalSorter_GetById = 0x130206,

        [Display(Prompt = "Sorter", GroupName = "LogicalSorter", Name = "GetChute", Description = "GetChute")]
        LogicalSorter_GetChute = 0x130207,


        /// <summary>
        /// Induct.
        /// </summary>
        [Display(Prompt = "Sorter", GroupName = "Induct", Name = "GetInducts", Description = "GetInducts")]
        Induct_GetInducts = 0x130301,

        [Display(Prompt = "Sorter", GroupName = "Induct", Name = "AddInducts", Description = "AddInducts")]
        Induct_AddInducts = 0x130302,

        [Display(Prompt = "Sorter", GroupName = "Induct", Name = "UpdateInducts", Description = "UpdateInducts")]
        Induct_UpdateInducts = 0x130303,

        [Display(Prompt = "Sorter", GroupName = "Induct", Name = "DeleteInducts", Description = "DeleteInducts")]
        Induct_DeleteInducts = 0x130304,

        [Display(Prompt = "Sorter", GroupName = "Induct", Name = "ExportToExcel", Description = "ExportToExcel")]
        Induct_ExportToExcel = 0x130305,




        /// <summary>
        /// Scanner.
        /// </summary>
        [Display(Prompt = "Sorter", GroupName = "Scanner", Name = "GetScanners", Description = "GetScanners")]
        Scanner_GetScanners = 0x130401,

        [Display(Prompt = "Sorter", GroupName = "Scanner", Name = "AddScanners", Description = "AddScanners")]
        Scanner_AddScanners = 0x130402,

        [Display(Prompt = "Sorter", GroupName = "Scanner", Name = "UpdateScanners", Description = "UpdateScanners")]
        Scanner_UpdateScanners = 0x130403,

        [Display(Prompt = "Sorter", GroupName = "DisplayMScanneressage", Name = "DeleteScanners", Description = "DeleteScanners")]
        Scanner_DeleteScanners = 0x130404,

        [Display(Prompt = "Sorter", GroupName = "Scanner", Name = "ExportToExcel", Description = "ExportToExcel")]
        Scanner_ExportToExcel = 0x130405,

        /// <summary>
        /// Shute.
        /// </summary>
        [Display(Prompt = "Shute", GroupName = "Shute", Name = "GetShutes", Description = "GetShutes")]
        Shute_GetShutes = 0x140101,

        [Display(Prompt = "Shute", GroupName = "Shute", Name = "AddShutes", Description = "AddShutes")]
        Shute_AddShutes = 0x140102,

        [Display(Prompt = "Shute", GroupName = "Shute", Name = "UpdateShutes", Description = "UpdateShutes")]
        Shute_UpdateShutes = 0x140103,

        [Display(Prompt = "Shute", GroupName = "Shute", Name = "DeleteShutes", Description = "DeleteShutes")]
        Shute_DeleteShutes = 0x140104,

        [Display(Prompt = "Shute", GroupName = "Shute", Name = "ExportToExcel", Description = "ExportToExcel")]
        Shute_ExportToExcel = 0x140105,

        /// <summary>
        /// SecondaryShute.
        /// </summary>
        [Display(Prompt = "SecondaryShute", GroupName = "SecondaryShute", Name = "GetSecondaryShutes", Description = "GetSecondaryShutes")]
        SecondaryShute_GetSecondaryShutes = 0x140301,

        [Display(Prompt = "SecondaryShute", GroupName = "SecondaryShute", Name = "AddSecondaryShutes", Description = "AddSecondaryShutes")]
        SecondaryShute_AddSecondaryShutes = 0x140302,

        [Display(Prompt = "SecondaryShute", GroupName = "SecondaryShute", Name = "UpdateSecondaryShutes", Description = "UpdateSecondaryShutes")]
        SecondaryShute_UpdateSecondaryShutes = 0x140303,

        [Display(Prompt = "SecondaryShute", GroupName = "SecondaryShute", Name = "DeleteSecondaryShutes", Description = "DeleteSecondaryShutes")]
        SecondaryShute_DeleteSecondaryShutes = 0x140304,

        [Display(Prompt = "SecondaryShute", GroupName = "SecondaryShute", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryShute_ExportToExcel = 0x140305,

        /// <summary>
        /// ShuteStatus.
        /// </summary>
        [Display(Prompt = "Shute", GroupName = "ShuteStatus", Name = "GetShuteStatus", Description = "GetShuteStatus")]
        ShuteStatus_GetShuteStatuss = 0x140201,

        [Display(Prompt = "Shute", GroupName = "ShuteStatus", Name = "AddShuteStatus", Description = "AddShuteStatus")]
        ShuteStatus_AddShuteStatuss = 0x140202,

        [Display(Prompt = "Shute", GroupName = "ShuteStatus", Name = "UpdateShuteStatus", Description = "UpdateShuteStatus")]
        ShuteStatus_UpdateShuteStatuss = 0x140203,

        [Display(Prompt = "Shute", GroupName = "ShuteStatus", Name = "DeleteShuteStatus", Description = "DeleteShuteStatus")]
        ShuteStatus_DeleteShuteStatuss = 0x140204,

        [Display(Prompt = "Shute", GroupName = "ShuteStatus", Name = "ExportToExcel", Description = "ExportToExcel")]
        ShuteStatus_ExportToExcel = 0x140205,

        /// <summary>
        /// ShuteGraph.
        /// </summary>
        [Display(Prompt = "Shute", GroupName = "ShuteGraph", Name = "GetShuteName", Description = "GetShuteGraph")]
        ShuteGraph_GetShuteName = 0x140501,

        [Display(Prompt = "Shute", GroupName = "ShuteGraph", Name = "GetShuteStatus", Description = "AddShuteGraph")]
        ShuteGraph_GetShuteStatus = 0x140502,

        [Display(Prompt = "Shute", GroupName = "ShuteGraph", Name = "GetShuteStatusByStatus", Description = "UpdateShuteGraph")]
        ShuteGraph_GetShuteStatusByStatus = 0x140503,


        /// <summary>
        /// SecondaryShuteStatus.
        /// </summary>
        [Display(Prompt = "Shute", GroupName = "SecondaryShuteStatus", Name = "GetSecondaryShuteStatus", Description = "GetSecondaryShuteStatus")]
        SecondaryShuteStatus_GetSecondaryShuteStatuss = 0x140401,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteStatus", Name = "AddSecondaryShuteStatus", Description = "AddSecondaryShuteStatus")]
        SecondaryShuteStatus_AddSecondaryShuteStatuss = 0x140402,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteStatus", Name = "UpdateSecondaryShuteStatus", Description = "UpdateSecondaryShuteStatus")]
        SecondaryShuteStatus_UpdateSecondaryShuteStatuss = 0x140403,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteStatus", Name = "DeleteSecondaryShuteStatus", Description = "DeleteSecondaryShuteStatus")]
        SecondaryShuteStatus_DeleteSecondaryShuteStatuss = 0x140404,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteStatus", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryShuteStatus_ExportToExcel = 0x140405,

        /// <summary>
        /// ShuteGraph.
        /// </summary>
        [Display(Prompt = "Shute", GroupName = "SecondaryShuteGraph", Name = "GetShuteName", Description = "GetShuteName")]
        SecondaryShuteGraph_GetShuteName = 0x140601,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteGraph", Name = "GetShuteStatus", Description = "GetShuteStatus")]
        SecondaryShuteGraph_GetShuteStatus = 0x140602,

        [Display(Prompt = "Shute", GroupName = "SecondaryShuteGraph", Name = "GetShuteStatusByStatus", Description = "GetShuteStatusByStatus")]
        SecondaryShuteGraph_GetShuteStatusByStatus = 0x140603,


        /// <summary>
        /// SorterPlan.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "GetSorterPlans", Description = "GetSorterPlans")]
        SorterPlan_GetSorterPlans = 0x150101,

        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "AddSorterPlans", Description = "AddSorterPlans")]
        SorterPlan_AddSorterPlans = 0x150102,

        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "UpdateSorterPlans", Description = "UpdateSorterPlans")]
        SorterPlan_UpdateSorterPlans = 0x150103,

        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "DeleteSorterPlans", Description = "DeleteSorterPlans")]
        SorterPlan_DeleteSorterPlans = 0x150104,

        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "ExportToExcel", Description = "ExportToExcel")]
        SorterPlan_ExportToExcel = 0x150105,

        [Display(Prompt = "SorterPlan", GroupName = "SorterPlan", Name = "GetRoutingInformations", Description = "GetRoutingInformations")]
        SorterPlan_GetRoutingInformations = 0x150106,

        /// <summary>
        /// Routing.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "Routing", Name = "GetRoutings", Description = "GetRoutings")]
        Routing_GetRoutings = 0x150201,

        [Display(Prompt = "SorterPlan", GroupName = "Routing", Name = "AddRoutings", Description = "AddRoutings")]
        Routing_AddRoutings = 0x150202,

        [Display(Prompt = "SorterPlan", GroupName = "Routing", Name = "UpdateRoutings", Description = "UpdateRoutings")]
        Routing_UpdateRoutings = 0x150203,

        [Display(Prompt = "SorterPlan", GroupName = "Routing", Name = "DeleteRoutings", Description = "DeleteRoutings")]
        Routing_DeleteRoutings = 0x150204,

        [Display(Prompt = "SorterPlan", GroupName = "Routing", Name = "ExportToExcel", Description = "ExportToExcel")]
        Routing_ExportToExcel = 0x150205,

        /// <summary>
        /// SecondaryRouting.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "SecondaryRouting", Name = "GetSecondaryRoutings", Description = "GetSecondaryRoutings")]
        SecondaryRouting_GetSecondaryRoutings = 0x150501,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryRouting", Name = "AddSecondaryRoutings", Description = "AddSecondaryRoutings")]
        SecondaryRouting_AddSecondaryRoutings = 0x150502,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryRouting", Name = "UpdateSecondaryRoutings", Description = "UpdateSecondaryRoutings")]
        SecondaryRouting_UpdateSecondaryRoutings = 0x150503,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryRouting", Name = "DeleteSecondaryRoutings", Description = "DeleteSecondaryRoutings")]
        SecondaryRouting_DeleteSecondaryRoutings = 0x150504,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryRouting", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryRouting_ExportToExcel = 0x150505,


        /// <summary>
        /// LogicalDestination.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "LogicalDestination", Name = "GetLogicalDestinations", Description = "GetLogicalDestinations")]
        LogicalDestination_GetLogicalDestinations = 0x150301,

        [Display(Prompt = "SorterPlan", GroupName = "LogicalDestination", Name = "AddLogicalDestinations", Description = "AddLogicalDestinations")]
        LogicalDestination_AddLogicalDestinations = 0x150302,

        [Display(Prompt = "SorterPlan", GroupName = "LogicalDestination", Name = "UpdateLogicalDestinations", Description = "UpdateLogicalDestinations")]
        LogicalDestination_UpdateLogicalDestinations = 0x150303,

        [Display(Prompt = "SorterPlan", GroupName = "LogicalDestination", Name = "DeleteLogicalDestinations", Description = "DeleteLogicalDestinations")]
        LogicalDestination_DeleteLogicalDestinations = 0x150304,

        [Display(Prompt = "SorterPlan", GroupName = "LogicalDestination", Name = "ExportToExcel", Description = "ExportToExcel")]
        LogicalDestination_ExportToExcel = 0x150305,

        /// <summary>
        /// SecondaryLogicalDes.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "SecondaryLogicalDes", Name = "GetSecondaryLogicalDess", Description = "GetSecondaryLogicalDess")]
        SecondaryLogicalDes_GetSecondaryLogicalDess = 0x150601,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryLogicalDes", Name = "AddSecondaryLogicalDess", Description = "AddSecondaryLogicalDess")]
        SecondaryLogicalDes_AddSecondaryLogicalDess = 0x150602,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryLogicalDes", Name = "UpdateSecondaryLogicalDess", Description = "UpdateSecondaryLogicalDess")]
        SecondaryLogicalDes_UpdateSecondaryLogicalDess = 0x150603,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryLogicalDes", Name = "DeleteSecondaryLogicalDess", Description = "DeleteSecondaryLogicalDess")]
        SecondaryLogicalDes_DeleteSecondaryLogicalDess = 0x150604,

        [Display(Prompt = "SorterPlan", GroupName = "SecondaryLogicalDes", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryLogicalDes_ExportToExcel = 0x150605,

        /// <summary>
        /// SecondarySorterPlan.
        /// </summary>
        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "GetSecondarySorterPlans", Description = "GetSecondarySorterPlans")]
        SorterPlan_GetSecondarySorterPlans = 0x150401,

        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "AddSecondarySorterPlans", Description = "AddSecondarySorterPlans")]
        SorterPlan_AddSecondarySorterPlans = 0x150402,

        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "UpdateSecondarySorterPlans", Description = "UpdateSecondarySorterPlans")]
        SorterPlan_UpdateSecondarySorterPlans = 0x150403,

        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "DeleteSecondarySorterPlans", Description = "DeleteSecondarySorterPlans")]
        SorterPlan_DeleteSecondarySorterPlans = 0x150404,

        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondarySorterPlan_ExportToExcel = 0x150405,

        [Display(Prompt = "SorterPlan", GroupName = "SecondarySorterPlan", Name = "GetRoutingInformations", Description = "GetRoutingInformations")]
        SecondarySorterPlan_GetRoutingInformations = 0x150406,


        /// <summary>
        /// SorterParameter.
        /// </summary>
        [Display(Prompt = "SorterParameter", GroupName = "SorterParameter", Name = "GetSorterParameters", Description = "GetSorterParameters")]
        SorterParameter_GetSorterParameters = 0x160101,

        [Display(Prompt = "SorterParameter", GroupName = "SorterParameter", Name = "AddSorterParameters", Description = "AddSorterParameters")]
        SorterParameter_AddSorterParameters = 0x160102,

        [Display(Prompt = "SorterParameter", GroupName = "SorterParameter", Name = "UpdateSorterParameters", Description = "UpdateSorterParameters")]
        SorterParameter_UpdateSorterParameters = 0x160103,

        [Display(Prompt = "SorterParameter", GroupName = "SorterParameter", Name = "DeleteSorterParameters", Description = "DeleteSorterParameters")]
        SorterParameter_DeleteSorterParameters = 0x160104,

        [Display(Prompt = "SorterParameter", GroupName = "SorterParameter", Name = "ExportToExcel", Description = "ExportToExcel")]
        SorterParameter_ExportToExcel = 0x160105,

        /// <summary>
        ///PackageInfo.
        /// </summary>
        [Display(Prompt = "Package", GroupName = "PackageInfo", Name = "GetPackageInfos", Description = "GetPackageInfos")]
        PackageInfo_GetPackageInfos = 0x170101,

        [Display(Prompt = "Package", GroupName = "PackageInfo", Name = "AddPackageInfos", Description = "AddPackageInfos")]
        PackageInfo_AddPackageInfos = 0x170102,

        [Display(Prompt = "Package", GroupName = "PackageInfo", Name = "UpdatePackageInfos", Description = "UpdatePackageInfos")]
        PackageInfo_UpdatePackageInfos = 0x170103,

        [Display(Prompt = "Package", GroupName = "PackageInfo", Name = "DeletePackageInfos", Description = "DeletePackageInfos")]
        PackageInfo_DeletePackageInfos = 0x170104,

        [Display(Prompt = "Package", GroupName = "PackageInfo", Name = "ExportToExcel", Description = "ExportToExcel")]
        PackageInfo_ExportToExcel = 0x170105,

        /// <summary>
        ///SecondaryPackageInfo.
        /// </summary>
        [Display(Prompt = "Package", GroupName = "SecondaryPackageInfo", Name = "GetSecondaryPackageInfos", Description = "GetSecondaryPackageInfos")]
        SecondaryPackageInfo_GetSecondaryPackageInfos = 0x170301,

        [Display(Prompt = "Package", GroupName = "SecondaryPackageInfo", Name = "AddSecondaryPackageInfos", Description = "AddSecondaryPackageInfos")]
        SecondaryPackageInfo_AddSecondaryPackageInfos = 0x170302,

        [Display(Prompt = "Package", GroupName = "SecondaryPackageInfo", Name = "UpdateSecondaryPackageInfos", Description = "UpdateSecondaryPackageInfos")]
        SecondaryPackageInfo_UpdateSecondaryPackageInfos = 0x170303,

        [Display(Prompt = "Package", GroupName = "SecondaryPackageInfo", Name = "DeleteSecondaryPackageInfos", Description = "DeleteSecondaryPackageInfos")]
        SecondaryPackageInfo_DeleteSecondaryPackageInfos = 0x170304,

        [Display(Prompt = "Package", GroupName = "SecondaryPackageInfo", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryPackageInfo_ExportToExcel = 0x170305,

        /// <summary>
        ///SortingPackage.
        /// </summary>
        [Display(Prompt = "Package", GroupName = "SortingPackage", Name = "GetSortingPackages", Description = "GetSortingPackages")]
        SortingPackage_GetSortingPackages = 0x170201,

        [Display(Prompt = "Package", GroupName = "SortingPackage", Name = "AddSortingPackages", Description = "AddSortingPackages")]
        SortingPackage_AddSortingPackages = 0x170202,

        [Display(Prompt = "Package", GroupName = "SortingPackage", Name = "UpdateSortingPackages", Description = "UpdateSortingPackages")]
        SortingPackage_UpdateSortingPackages = 0x170203,

        [Display(Prompt = "Package", GroupName = "SortingPackage", Name = "DeleteSortingPackages", Description = "DeleteSortingPackages")]
        SortingPackage_DeleteSortingPackages = 0x170204,

        [Display(Prompt = "Package", GroupName = "SortingPackage", Name = "ExportToExcel", Description = "ExportToExcel")]
        SortingPackage_ExportToExcel = 0x170205,

        /// <summary>
        /// MessageDictionary.
        /// </summary>
        [Display(Prompt = "Message", GroupName = "MessageDictionary", Name = "GetMessageDictionarys", Description = "GetMessageDictionarys")]
        MessageDictionary_GetMessageDictionarys = 0x180101,

        [Display(Prompt = "Message", GroupName = "MessageDictionary", Name = "AddMessageDictionarys", Description = "AddMessageDictionarys")]
        MessageDictionary_AddMessageDictionarys = 0x180102,

        [Display(Prompt = "Message", GroupName = "MessageDictionary", Name = "UpdateMessageDictionarys", Description = "UpdateMessageDictionarys")]
        MessageDictionary_UpdateMessageDictionarys = 0x180103,

        [Display(Prompt = "Message", GroupName = "MessageDictionary", Name = "DeleteMessageDictionarys", Description = "DeleteMessageDictionarys")]
        MessageDictionary_DeleteMessageDictionarys = 0x180104,

        [Display(Prompt = "Message", GroupName = "MessageDictionary", Name = "ExportToExcel", Description = "ExportToExcel")]
        MessageDictionary_ExportToExcel = 0x180105,


        /// <summary>
        /// DrSubWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "DrSubWorkTask", Name = "GetDrSubWorkTasks", Description = "GetDrSubWorkTasks")]
        DrSubWorkTask_GetDrSubWorkTasks = 0x190101,

        [Display(Prompt = "WorkTask", GroupName = "DrSubWorkTask", Name = "AddDrSubWorkTasks", Description = "AddDrSubWorkTasks")]
        DrSubWorkTask_AddDrSubWorkTasks = 0x190102,

        [Display(Prompt = "WorkTask", GroupName = "DrSubWorkTask", Name = "UpdateDrSubWorkTasks", Description = "UpdateDrSubWorkTasks")]
        DrSubWorkTask_UpdateDrSubWorkTasks = 0x190103,

        [Display(Prompt = "WorkTask", GroupName = "DrSubWorkTask", Name = "DeleteDrSubWorkTasks", Description = "DeleteDrSubWorkTasks")]
        DrSubWorkTask_DeleteDrSubWorkTasks = 0x190104,

        [Display(Prompt = "WorkTask", GroupName = "DrSubWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        DrSubWorkTask_ExportToExcel = 0x190105,

        /// <summary>
        /// DeSubWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "DeSubWorkTask", Name = "GetDeSubWorkTasks", Description = "GetDeSubWorkTasks")]
        DeSubWorkTask_GetDeSubWorkTasks = 0x190201,

        [Display(Prompt = "WorkTask", GroupName = "DeSubWorkTask", Name = "AddDeSubWorkTasks", Description = "AddDeSubWorkTasks")]
        DeSubWorkTask_AddDeSubWorkTasks = 0x190202,

        [Display(Prompt = "WorkTask", GroupName = "DeSubWorkTask", Name = "UpdateDeSubWorkTasks", Description = "UpdateDeSubWorkTasks")]
        DeSubWorkTask_UpdateDeSubWorkTasks = 0x190203,

        [Display(Prompt = "WorkTask", GroupName = "DeSubWorkTask", Name = "DeleteDeSubWorkTasks", Description = "DeleteDeSubWorkTasks")]
        DeSubWorkTask_DeleteDeSubWorkTasks = 0x190204,

        [Display(Prompt = "WorkTask", GroupName = "DeSubWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        DeSubWorkTask_ExportToExcel = 0x190205,

        /// <summary>
        /// SorterMessageWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "SorterMessageWorkTask", Name = "GetSorterMessageWorkTasks", Description = "GetSorterMessageWorkTasks")]
        SorterMessageWorkTask_GetSorterMessageWorkTasks = 0x190301,

        [Display(Prompt = "WorkTask", GroupName = "SorterMessageWorkTask", Name = "AddSorterMessageWorkTasks", Description = "AddSorterMessageWorkTasks")]
        SorterMessageWorkTask_AddSorterMessageWorkTasks = 0x190302,

        [Display(Prompt = "WorkTask", GroupName = "SorterMessageWorkTask", Name = "UpdateSorterMessageWorkTasks", Description = "UpdateSorterMessageWorkTasks")]
        SorterMessageWorkTask_UpdateSorterMessageWorkTasks = 0x190303,

        [Display(Prompt = "WorkTask", GroupName = "SorterMessageWorkTask", Name = "DeleteSorterMessageWorkTasks", Description = "DeleteSorterMessageWorkTasks")]
        SorterMessageWorkTask_DeleteSorterMessageWorkTasks = 0x190304,

        [Display(Prompt = "WorkTask", GroupName = "SorterMessageWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        SorterMessageWorkTask_ExportToExcel = 0x190305,

        /// <summary>
        /// PackageWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "PackageWorkTask", Name = "GetPackageWorkTasks", Description = "GetPackageWorkTasks")]
        PackageWorkTask_GetPackageWorkTasks = 0x190401,

        [Display(Prompt = "WorkTask", GroupName = "PackageWorkTask", Name = "AddPackageWorkTasks", Description = "AddPackageWorkTasks")]
        PackageWorkTask_AddPackageWorkTasks = 0x190402,

        [Display(Prompt = "WorkTask", GroupName = "PackageWorkTask", Name = "UpdatePackageWorkTasks", Description = "UpdatePackageWorkTasks")]
        PackageWorkTask_UpdatePackageWorkTasks = 0x190403,

        [Display(Prompt = "WorkTask", GroupName = "PackageWorkTask", Name = "DeletePackageWorkTasks", Description = "DeletePackageWorkTasks")]
        PackageWorkTask_DeletePackageWorkTasks = 0x190404,

        [Display(Prompt = "WorkTask", GroupName = "PackageWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        PackageWorkTask_ExportToExcel = 0x190405,

        /// <summary>
        /// OvSubWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "OvSubWorkTask", Name = "GetOvSubWorkTasks", Description = "GetOvSubWorkTasks")]
        OvSubWorkTask_GetOvSubWorkTasks = 0x190501,

        [Display(Prompt = "WorkTask", GroupName = "OvSubWorkTask", Name = "AddOvSubWorkTasks", Description = "AddOvSubWorkTasks")]
        OvSubWorkTask_AddOvSubWorkTasks = 0x190502,

        [Display(Prompt = "WorkTask", GroupName = "OvSubWorkTask", Name = "UpdateOvSubWorkTasks", Description = "UpdateOvSubWorkTasks")]
        OvSubWorkTask_UpdateOvSubWorkTasks = 0x190503,

        [Display(Prompt = "WorkTask", GroupName = "OvSubWorkTask", Name = "DeleteOvSubWorkTasks", Description = "DeleteOvSubWorkTasks")]
        OvSubWorkTask_DeleteOvSubWorkTasks = 0x190504,

        [Display(Prompt = "WorkTask", GroupName = "OvSubWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        OvSubWorkTask_ExportToExcel = 0x190505,

        /// <summary>
        /// ExecuteWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "ExecuteWorkTask", Name = "GetExecuteWorkTasks", Description = "GetExecuteWorkTasks")]
        ExecuteWorkTask_GetExecuteWorkTasks = 0x190601,

        [Display(Prompt = "WorkTask", GroupName = "ExecuteWorkTask", Name = "AddExecuteWorkTasks", Description = "AddExecuteWorkTasks")]
        ExecuteWorkTask_AddExecuteWorkTasks = 0x190602,

        [Display(Prompt = "WorkTask", GroupName = "ExecuteWorkTask", Name = "UpdateExecuteWorkTasks", Description = "UpdateExecuteWorkTasks")]
        ExecuteWorkTask_UpdateExecuteWorkTasks = 0x190603,

        [Display(Prompt = "WorkTask", GroupName = "ExecuteWorkTask", Name = "DeleteExecuteWorkTasks", Description = "DeleteExecuteWorkTasks")]
        ExecuteWorkTask_DeleteExecuteWorkTasks = 0x190604,

        [Display(Prompt = "WorkTask", GroupName = "ExecuteWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        ExecuteWorkTask_ExportToExcel = 0x190605,

        /// <summary>
        /// SorterSubWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "SorterSubWorkTask", Name = "GetSorterSubWorkTasks", Description = "GetSorterSubWorkTasks")]
        SorterSubWorkTask_GetSorterSubWorkTasks = 0x190701,

        [Display(Prompt = "WorkTask", GroupName = "SorterSubWorkTask", Name = "AddSorterSubWorkTasks", Description = "AddSorterSubWorkTasks")]
        SorterSubWorkTask_AddSorterSubWorkTasks = 0x190702,

        [Display(Prompt = "WorkTask", GroupName = "SorterSubWorkTask", Name = "UpdateSorterSubWorkTasks", Description = "UpdateSorterSubWorkTasks")]
        SorterSubWorkTask_UpdateSorterSubWorkTasks = 0x190703,

        [Display(Prompt = "WorkTask", GroupName = "SorterSubWorkTask", Name = "DeleteSorterSubWorkTasks", Description = "DeleteSorterSubWorkTasks")]
        SorterSubWorkTask_DeleteSorterSubWorkTasks = 0x190704,

        [Display(Prompt = "WorkTask", GroupName = "SorterSubWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        SorterSubWorkTask_ExportToExcel = 0x190705,

        /// <summary>
        /// SecondaryPackageWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "SecondaryPackageWorkTask", Name = "GetSecondaryPackageWorkTasks", Description = "GetSecondaryPackageWorkTasks")]
        SecondaryPackageWorkTask_GetSecondaryPackageWorkTasks = 0x190801,

        [Display(Prompt = "WorkTask", GroupName = "SecondaryPackageWorkTask", Name = "AddSecondaryPackageWorkTasks", Description = "AddSecondaryPackageWorkTasks")]
        SecondaryPackageWorkTask_AddSecondaryPackageWorkTasks = 0x190802,

        [Display(Prompt = "WorkTask", GroupName = "SecondaryPackageWorkTask", Name = "UpdateSecondaryPackageWorkTasks", Description = "UpdateSecondaryPackageWorkTasks")]
        SecondaryPackageWorkTask_UpdateSecondaryPackageWorkTasks = 0x190803,

        [Display(Prompt = "WorkTask", GroupName = "SecondaryPackageWorkTask", Name = "DeleteSecondaryPackageWorkTasks", Description = "DeleteSecondaryPackageWorkTasks")]
        SecondaryPackageWorkTask_DeleteSecondaryPackageWorkTasks = 0x190804,

        [Display(Prompt = "WorkTask", GroupName = "SecondaryPackageWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        SecondaryPackageWorkTask_ExportToExcel = 0x190805,

        /// <summary>
        /// InterfaceWorkTask.
        /// </summary>
        [Display(Prompt = "WorkTask", GroupName = "InterfaceWorkTask", Name = "GetInterfaceWorkTasks", Description = "GetInterfaceWorkTasks")]
        InterfaceWorkTask_GetInterfaceWorkTasks = 0x190901,

        [Display(Prompt = "WorkTask", GroupName = "InterfaceWorkTask", Name = "AddInterfaceWorkTasks", Description = "AddInterfaceWorkTasks")]
        InterfaceWorkTask_AddInterfaceWorkTasks = 0x190902,

        [Display(Prompt = "WorkTask", GroupName = "InterfaceWorkTask", Name = "UpdateInterfaceWorkTasks", Description = "UpdateInterfaceWorkTasks")]
        InterfaceWorkTask_UpdateInterfaceWorkTasks = 0x190903,

        [Display(Prompt = "WorkTask", GroupName = "InterfaceWorkTask", Name = "DeleteInterfaceWorkTasks", Description = "DeleteInterfaceWorkTasks")]
        InterfaceWorkTask_DeleteInterfaceWorkTasks = 0x190904,

        [Display(Prompt = "WorkTask", GroupName = "InterfaceWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        InterfaceWorkTask_ExportToExcel = 0x190905,


        /// <summary>
        /// CompleteWorkTask.
        /// </summary>
        [Display(Prompt = "Complete", GroupName = "CompleteWorkTask", Name = "GetCompleteWorkTasks", Description = "GetCompleteWorkTasks")]
        CompleteWorkTask_GetCompleteWorkTasks = 0x1A0501,

        [Display(Prompt = "Complete", GroupName = "CompleteWorkTask", Name = "AddCompleteWorkTasks", Description = "AddCompleteWorkTasks")]
        CompleteWorkTask_AddCompleteWorkTasks = 0x1A0502,

        [Display(Prompt = "Complete", GroupName = "CompleteWorkTask", Name = "UpdateCompleteWorkTasks", Description = "UpdateCompleteWorkTasks")]
        CompleteWorkTask_UpdateCompleteWorkTasks = 0x1A0503,

        [Display(Prompt = "Complete", GroupName = "CompleteWorkTask", Name = "DeleteCompleteWorkTasks", Description = "DeleteCompleteWorkTasks")]
        CompleteWorkTask_DeleteCompleteWorkTasks = 0x1A0504,

        [Display(Prompt = "Complete", GroupName = "CompleteWorkTask", Name = "ExportToExcel", Description = "ExportToExcel")]
        CompleteWorkTask_ExportToExcel = 0x1A0505,


        /// <summary>
        /// Executor.
        /// </summary>
        [Display(Prompt = "Executor", GroupName = "Executor", Name = "GetExecutors", Description = "GetExecutors")]
        Executor_GetExecutors = 0x1B0101,

        [Display(Prompt = "Executor", GroupName = "Executor", Name = "AddExecutors", Description = "AddExecutors")]
        Executor_AddExecutors = 0x1B0102,

        [Display(Prompt = "Executor", GroupName = "Executor", Name = "UpdateExecutors", Description = "UpdateExecutors")]
        Executor_UpdateExecutors = 0x1B0103,

        [Display(Prompt = "Executor", GroupName = "Executor", Name = "DeleteExecutors", Description = "DeleteExecutors")]
        Executor_DeleteExecutors = 0x1B0104,

        [Display(Prompt = "Executor", GroupName = "Executor", Name = "ExportToExcel", Description = "ExportToExcel")]
        Executor_ExportToExcel = 0x1B0105,




        /// <summary>
        ///    SystemParameterController.
        /// </summary>
        [Display(Prompt = "SystemParameter", GroupName = "SystemParameter", Name = "GetSystemParameters", Description = "GetSystemParameters")]
        SystemParameter_GetSystemParameters = 0x1C0101,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameter", Name = "AddSystemParameters", Description = "AddSystemParameters")]
        SystemParameter_AddSystemParameters = 0x1C0102,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameter", Name = "UpdateSystemParameters", Description = "UpdateSystemParameters")]
        SystemParameter_UpdateSystemParameters = 0x1C0103,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameter", Name = "DeleteSystemParameters", Description = "DeleteSystemParameters")]
        SystemParameter_DeleteSystemParameters = 0x1C0104,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameter", Name = "ExportToExcel", Description = "ExportToExcel")]
        SystemParameter_ExportToExcel = 0x1C0105,


        /// <summary>
        ///    SystemParameterTemplateController.
        /// </summary>
        [Display(Prompt = "SystemParameter", GroupName = "SystemParameterTemplate", Name = "GetSystemParameterTemplates", Description = "GetSystemParameterTemplates")]
        SystemParameterTemplate_GetSystemParameterTemplates = 0x1C0201,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameterTemplate", Name = "AddSystemParameterTemplates", Description = "AddSystemParameterTemplates")]
        SystemParameterTemplate_AddSystemParameterTemplates = 0x1C0202,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameterTemplate", Name = "UpdateSystemParameterTemplates", Description = "UpdateSystemParameterTemplates")]
        SystemParameterTemplate_UpdateSystemParameterTemplates = 0x1C0203,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameterTemplate", Name = "DeleteSystemParameterTemplates", Description = "DeleteSystemParameterTemplates")]
        SystemParameterTemplate_DeleteSystemParameterTemplates = 0x1C0204,

        [Display(Prompt = "SystemParameter", GroupName = "SystemParameterTemplate", Name = "ExportToExcel", Description = "ExportToExcel")]
        SystemParameterTemplate_ExportToExcel = 0x1C0205,

        /// <summary>
        ///    SystemSequenceController.
        /// </summary>
        [Display(Prompt = "SystemParameter", GroupName = "SystemSequence", Name = "GetSystemSequences", Description = "GetSystemSequences")]
        SystemSequence_GetSystemSequences = 0x1C0301,

        [Display(Prompt = "SystemParameter", GroupName = "SystemSequence", Name = "AddSystemSequences", Description = "AddSystemSequences")]
        SystemSequence_AddSystemSequences = 0x1C0302,

        [Display(Prompt = "SystemParameter", GroupName = "SystemSequence", Name = "UpdateSystemSequences", Description = "UpdateSystemSequences")]
        SystemSequence_UpdateSystemSequences = 0x1C0303,

        [Display(Prompt = "SystemParameter", GroupName = "SystemSequence", Name = "DeleteSystemSequences", Description = "DeleteSystemSequences")]
        SystemSequence_DeleteSystemSequences = 0x1C0304,

        [Display(Prompt = "SystemParameter", GroupName = "SystemSequence", Name = "ExportToExcel", Description = "ExportToExcel")]
        SystemSequence_ExportToExcel = 0x1C0305,


        /// <summary>
        /// ReadRateByDay.
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "ReadRateByDay", Name = "GetReadRateByDays", Description = "GetReadRateByDays")]
        ReadRateByDay_GetReadRateByDays = 0x1D0101,

        [Display(Prompt = "ChartReport", GroupName = "ReadRateByDay ", Name = "ExportToExcel", Description = "ExportToExcel")]
        ReadRateByDay_ExportToExcel = 0x1D0105,

        /// <summary>
        /// SortingByHours.
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingByHour", Name = "GetSortingByHours", Description = "GetSortingByHours")]
        SortingByHour_GetSortingByHours = 0x1D0201,

        [Display(Prompt = "ChartReport", GroupName = "SortingByHour", Name = "ExportToExcel", Description = "ExportToExcel")]
        SortingByHour_ExportToExcel = 0x1D0205,

        /// <summary>
        /// SortingByChute.
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingByChute", Name = "GetSortingByChutes", Description = "GetSortingByChutes")]
        SortingByChute_GetSortingByChutes = 0x1D0301,

        [Display(Prompt = "ChartReport", GroupName = "SortingByChute ", Name = "ExportToExcel", Description = "ExportToExcel")]
        SortingByChute_ExportToExcel = 0x1D0305,

        /// <summary>
        /// excption.
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortExcption", Name = "GetExcption", Description = "GetExcption")]
        SortingExcption_GetExcption = 0x1D0401,

        [Display(Prompt = "ChartReport", GroupName = "SortingExcption ", Name = "ExportToExcel", Description = "ExportToExcel")]
        SortingExcption_ExportToExcel = 0x1D0405,

        /// <summary>
        /// sort by induct
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingByInduct", Name = "GetSortingByInduct", Description = "GetSortingByInduct")]
        SortingByInduct_GetSortingByInduct = 0x1D0501,

        [Display(Prompt = "ChartReport", GroupName = "SortingByInduct ", Name = "GetSortingByInduct", Description = "GetSortingByInduct")]
        SortingByInduct_ExportExcle = 0x1D0505,

        /// <summary>
        /// induct failed
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "InductFailed", Name = "GetFailedInduct", Description = "GetFailedInduct")]
        InductFailed_GetInductFailed = 0x1D0601,

        [Display(Prompt = "ChartReport", GroupName = "InductFailed ", Name = "InductFailedExport", Description = "InductFailedExport")]
        InductFailed_ExportExcle = 0x1D0605,

        /// <summary>
        ///  failedByInduct
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "FailedByInduct", Name = "FailedByInduct", Description = "FailedByInduct")]
        FailedByInduct_GetValue = 0x1D0701,

        [Display(Prompt = "ChartReport", GroupName = "FailedByInduct ", Name = "FailedByInductExport", Description = "FailedByInductExport")]
        FailedByInduct_ExportExcle = 0x1D0705,

        /// <summary>
        ///  SortingErrorInfo
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingErrorInfo", Name = "SortingErrorInfo", Description = "SortingErrorInfo")]
        SortingErrorInfo_GetValue = 0x1D0801,

        [Display(Prompt = "ChartReport", GroupName = "SortingErrorInfo ", Name = "SortingErrorInfoExport", Description = "SortingErrorInfoExport")]
        SortingErrorInfo_ExportExcle = 0x1D0805,

        /// <summary>
        ///  SortingByDay
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingByDay", Name = "SortingByDay", Description = "SortingByDay")]
        SortingByDay_GetValue = 0x1D0901,

        [Display(Prompt = "ChartReport", GroupName = "SortingByDay ", Name = "SortingByDayExport", Description = "SortingByDayExport")]
        SortingByDay_ExportExcle = 0x1D0905,

        /// <summary>
        ///  SortingByTaskType
        /// </summary>
        [Display(Prompt = "ChartReport", GroupName = "SortingByTaskType", Name = "SortingByTaskType", Description = "SortingByTaskType")]
        SortingByTaskType_GetValue = 0x1D0A01,

        [Display(Prompt = "ChartReport", GroupName = "SortingByTaskType ", Name = "SortingByTaskTypeExport", Description = "SortingByTaskTypeExport")]
        SortingByTaskType_ExportExcle = 0x1D0A05,



        ///    ProductionInboundsReport
        /// </summary>
        /*[Display(Prompt = "Report", GroupName = "ProductionInboundReport", Name = "GetProductionInbounds", Description = "GetProductionInbounds")]
        ProductionInboundReport_GetProductionInbounds = 0x1E0101,

        [Display(Prompt = "Report", GroupName = "ProductionInboundReport", Name = "GetDialogInventoryItems", Description = "GetDialogInventoryItems")]
        ProductionInboundReport_GetDialogInventoryItems = 0x1E0102,*/

        [Display(Prompt = "Report", GroupName = "GetByShute", Name = "GetByShuteGetValue", Description = "GetByShuteGetValue")]
        SortByShuteReportGetValue = 0x1E0101,

        [Display(Prompt = "Report", GroupName = "GetByShute", Name = "ExportToExcel", Description = "ExportToExcel")]
        SortByShuteReportExportToExcel = 0x1E0105,

        ///    PalletizedContainer.
        /// </summary>
        /*[Display(Prompt = "Report", GroupName = "ContainerInboundNumReport", Name = "GetContainerInbound", Description = "GetContainerInbound")]
        ContainerInboundNumReport_GetContainerInbound = 0x1E0201,*/

        [Display(Prompt = "Report", GroupName = "GetByInduct", Name = "GetByInductGetValue", Description = "GetByInductGetValue")]
        SortByInductGetValue = 0x1E0201,

        [Display(Prompt = "Report", GroupName = "GetByInduct", Name = "GetByInductExport", Description = "GetByInductExport")]
        SortByInductExport = 0x1E0205,


        [Display(Prompt = "Report", GroupName = "Overview", Name = "OverviewGetValue", Description = "OverviewGetValue")]
        OverviewGetValue = 0x1E0301,

        [Display(Prompt = "Report", GroupName = "OverView", Name = "OverviewGetValue2", Description = "OverviewGetValue2")]
        OverviewGetValue2 = 0x1E0302,

        [Display(Prompt = "Report", GroupName = "PeakOverview", Name = "PeakOverviewGetValue", Description = "PeakOverviewGetValue")]
        PeakOverviewGetValue = 0x1E0401,

        [Display(Prompt = "Report", GroupName = "PeakOverView", Name = "PeakOverviewGetValue2", Description = "PeakOverviewGetValue2")]
        PeakOverviewGetValue2 = 0x1E0402,


        ///  ReportInventoriesBySkuReport
        ///   /// </summary>
        //[Display(Prompt = "Report", GroupName = "InventoriesBySkuReport", Name = "GetInventoriesBySkuReport", Description = "GetInventoriesBySkuReport")]
        //InventoriesBySkuReport_GetPalletizedContainers = 0x1E0301,

        //[Display(Prompt = "Report", GroupName = "InventoriesBySkuReport", Name = "ExportToExcel", Description = "ExportToExcel")]
        //InventoriesBySkuReport_ExportToExcel = 0x1E0302,


        ///  ReportInboundFlowReport
        ///   /// </summary>
        [Display(Prompt = "Report", GroupName = "InboundFlowReport", Name = "GetInboundFlowReport", Description = "GetInboundFlowReport")]
        InboundFlowReport_GetInboundFlowReport = 0x1E0401,

        [Display(Prompt = "Report", GroupName = "InboundFlowReport", Name = "ExportToExcel", Description = "ExportToExcel")]
        InboundFlowReport_ExportToExcel = 0x1E0402,


        
        [Display(Prompt = "Report", GroupName = "GenerateReport", Name = "GenerateReport", Description = "GetGenerateReport")]
        GenerateReport_GetGenerateReport = 0x1E0501,

        [Display(Prompt = "Report", GroupName = "GenerateReport", Name = "GenerateReport2", Description = "GetGenerateReport2")]
        GenerateReport_GetGenerateReport2 = 0x1E0502,

        
        [Display(Prompt = "Report", GroupName = "BatchReport", Name = "BatchReport", Description = "BatchReport_GetPage")]
        BatchReportGetValue = 0x1E0601,

        [Display(Prompt = "Report", GroupName = "BatchReport", Name = "BatchReport", Description = "BatchReport_Export")]
        BatchReportExport = 0x1E0602,

        ///   LocationRateReport
        ///   /// </summary>
        [Display(Prompt = "Report", GroupName = "LocationRateReport", Name = "GetLocationRateReport", Description = "GetLocationRateReport")]
        LocationRateReport_GetLocationRateReport = 0x1E0801,


        /// <summary>
        ///  InventoryLocationBySkuReport.
        /// </summary>
        [Display(Prompt = "Report", GroupName = "InventoryLocationBySkuReport", Name = "GetInventoriesLocation", Description = "GetInventoriesLocation")]
        InventoryLocationBySkuReport_GetInventoriesLocation = 0x1E0701,


        [Display(Prompt = "Report", GroupName = "InventoryLocationBySkuReport", Name = "ExportToExcel", Description = "ExportToExcel")]
        InventoryLocationBySkuReport_ExportToExcel = 0x1E0702,


        ///   InventoriesAgeBySkuReport
        ///   /// </summary>
        [Display(Prompt = "Report", GroupName = "InventoriesAgeBySkuReport", Name = "GetInventoriesAgeBySkuReport", Description = "GetInventoriesAgeBySkuReport")]
        InventoriesAgeBySkuReport_GetInventoriesAgeBySkuReport = 0x1E0901,

        ///   InboundByDepartmentReport
        ///   /// </summary>
        [Display(Prompt = "Report", GroupName = "InboundByDepartmentReport", Name = "GetInboundByDepartmentReport", Description = "GetInboundByDepartmentReport")]
        InboundByDepartmentReport_GetInboundByDepartmentReport = 0x1E0A01,

        ///   LocationItemReport
        ///   /// </summary>
        [Display(Prompt = "Report", GroupName = "LocationItemReport", Name = "GetLocationItemReport", Description = "GetLocationItemReport")]
        LocationItemReport_GetLocationItemReport = 0x1E0B01,

        /// <summary>
        ///  SystemTracing.
        /// </summary>
        [Display(Prompt = "SystemTracing", GroupName = "OperatorTracing", Name = "GetOperatorTracings", Description = "GetOperatorTracings")]
        SystemTracing_GetOperatorTracings = 0x1F0101,

        [Display(Prompt = "SystemTracing", GroupName = "OperatorTracing", Name = "AddOperatorTracings", Description = "AddOperatorTracings")]
        SystemTracing_AddOperatorTracings = 0x1F0102,

        [Display(Prompt = "SystemTracing", GroupName = "OperatorTracing", Name = "UpdateOperatorTracings", Description = "UpdateOperatorTracings")]
        SystemTracing_UpdateOperatorTracings = 0x1F0103,

        [Display(Prompt = "SystemTracing", GroupName = "OperatorTracing", Name = "DeleteOperatorTracings", Description = "DeleteOperatorTracings")]
        SystemTracing_DeleteOperatorTracings = 0x1F0104,

        [Display(Prompt = "SystemTracing", GroupName = "OperatorTracing ", Name = "ExportToExcel", Description = "ExportToExcel")]
        SystemTracing_ExportToExcel = 0x1F0105,
        /// <summary>
        ///  DashBoard.
        /// </summary>
        [Display(Prompt = "DashBoard", GroupName = "InductDashBoard", Name = "GetInductDashBoards", Description = "GetInductDashBoards")]
        InductDashBoard_GetInductDashBoards = 0x200101,

        [Display(Prompt = "DashBoard", GroupName = "InductDashBoard ", Name = "ExportToExcel", Description = "ExportToExcel")]
        InductDashBoard_ExportToExcel = 0x200105,

        [Display(Prompt = "Report", GroupName = "CircleCount", Name = "GetCircleCount", Description = "GetCircleCount")]
        CircleCount_Get = 0x210101

    }
}
