﻿using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class SorterOvSubWorkTask
    {
        public string Id { get; set; }
        //public string ScannerBarcode { get; set; }
        public string LogicBarcode { get; set; }
        public string AtricleBarcode { get; set; }
        public string AtricleLength { get; set; }
        public string AtricleWidth { get; set; }
        public string AtricleHeight { get; set; }
        public string AtricleWeight { get; set; }
        
        public string AtricleVolume { get; set; }
       //public string NodeId { get; set; }
        public string Scanner { get; set; }
        //public DateTime? ScannerTime { get; set; }
        public string PhysicalSortter { get; set; }
        public string LogicalSortter { get; set; }
        public string CarrierId { get; set; }
        public string FinalCarrierId { get; set; }
        public string TrackingId { get; set; }
        public int CycleTimes { get; set; }
        public string RequestShuteNum { get; set; }
        public string RequestShuteCode { get; set; }
        public string RequestShuteAddr { get; set; }
        public string RequestShuteAddrX { get; set; }
        public string RequestShuteAddrY { get; set; }
        public string RequestShuteAddrZ { get; set; }
        //public string RequestShuteAddrL { get; set; }
        public string FinalShuteAddr { get; set; }
        public string SortResultSorter { get; set; }
        //public string SortingErrorInfo { get; set; }
       //public string ExpCode { get; set; }
       //public string ActiveBy { get; set; }
        public DateTime? ActiveTime { get; set; }
        public int SerialNumber { get; set; }
        public int ParallelNumber { get; set; }
        public string ExecuteWorkTaskId { get; set; }
        public string OperatorName { get; set; }
        public string ObjectToHandle { get; set; }
        public int WorkTaskType { get; set; }
        public int Status { get; set; }
        public int SourceStatus { get; set; }
        public int TriggerMode { get; set; }
        public DateTime? FaultTime { get; set; }
        public DateTime? TimeOutTime { get; set; }
        public DateTime? CompleteTime { get; set; }
        public string Comments { get; set; }
        public string Results { get; set; }
        public string Executor { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
