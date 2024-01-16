using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class SorterExecuteWorkTask
    {
        public string Id { get; set; }
        public string Wave { get; set; }
        public string Shipment { get; set; }
        public string LogisticsBarcode { get; set; }
        public string ArticalBarcode { get; set; }
        public string LogicalDestination { get; set; }
        public int SortterTaskMode { get; set; }
        public string IndiaZn { get; set; }
        public string IndiaPdt { get; set; }
        public string IndiaCn { get; set; }
        public string IndiaClient { get; set; }
        public bool IndiaXraycs { get; set; }
        public string IndiaOrderId { get; set; }
        public string IndiaMot { get; set; }
        public bool IndiaAr { get; set; }
        public string IndiaRpdd { get; set; }
        public string IndiaNdc { get; set; }
        public bool IndiaIncomingTrip { get; set; }
        public string IndiaSt { get; set; }
        public bool IndiaXray { get; set; }
        public string IndiaRcn { get; set; }
        public bool IndiaExpected { get; set; }
        public string IndiaPdd { get; set; }
        public string KengicChute { get; set; }
        public int CurrentSerialNumber { get; set; }
        public int SumSerialNumber { get; set; }
        public string OperatorName { get; set; }
        public string ObjectToHandle { get; set; }
        public int WorkTaskType { get; set; }
        public int Status { get; set; }
        public string Comments { get; set; }
        public string Results { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
