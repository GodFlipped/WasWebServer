using System;

namespace WasWebServer.Models
{
    public static class Public
    {
        private static int _squenceNo;
        public static string GetIdBySeqNoAndKey(string key) => key + Guid.NewGuid().ToString("N");


        public static int GetSequenceNo()
        {
            if (_squenceNo >= 99999)
            {
                _squenceNo = 1;
            }
            else
            {
                _squenceNo = _squenceNo + 1;
            }

            return _squenceNo;
        }

        public static string GetBelt(string physicalSortter)
        {
            switch (physicalSortter)
            {
                case  "0":
                    return "Z";
                case  "1" :
                    return "GB";
                case "2":
                    return "GA";
                case "3":
                    return "ZD";
                case "4":
                    return "ZC";
                case "5":
                    return "ZB";
                case "6":
                    return "ZA";
            }
            return physicalSortter;
        }
        public static string GetPhysicalSortter(string belt)
        {
            belt = belt?.Trim().ToUpper();

            switch (belt)
            {
                case "GB":
                    return "1";
                case "GA":
                    return "2";
                case "ZD":
                    return "3";
                case "ZC":
                    return "4";
                case "ZB":
                    return "5";
                case "ZA":
                    return "6";
                case "Z":
                    return "0";
            }
            return belt;
        }
        public static string GetIdBySequenceNo()
        {
            var sequenceNo = GetSequenceNo();
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + sequenceNo.ToString("d5");
        }

        public static string ToAnnotation(string value)
        {
            switch (value)
            {
                case "ND":
                    return "正常卸载";
                case "UP":
                    return "未知邮件";
                case "ID":
                    return "无分拣计划";
                case "NR":
                    return "无读";
                case "MB":
                    return "多条码";
                case "DE":
                    return "无信息";
                case "MT":
                    return "系统超时";
                case "MJ":
                    return "MES拒绝";
                case "MR":
                    return "最大循环圈数";
                case "VO":
                    return "VCS补码操作超时";
                case "VQ":
                    return "VCS排队超时";
                case "VJ":
                    return "VCS补码拒绝";
                case "CF":
                    return "小车故障";
                case "DF":
                    return "滑槽满";
                case "DD":
                    return "卸载口禁用";
                case "BF":
                    return "满袋";
                case "BC":
                    return "按钮按下导致挡板关闭";
                case "BR":
                    return "按钮按下导致挡板打开";
                case "BE":
                    return "挡板故障";
                case "DJ":
                    return "卸载口堵塞";
                case "PF":
                    return "Profinet故障";
                case "SP":
                    return "速度未达到";
                case "CD":
                    return "小车禁用";
                case "OF":
                    return "卸载验证失败";
                default:
                    return value;
            }
        }
        public  static string SolveSortResultSorter(int sortResultSorter)
        {
            var reason = "";
            if (sortResultSorter == 1)
            {
                reason = "未接收到主机命令";
            }
            if ((sortResultSorter & (1 << 1)) != 0)
            {
                //reason = "无读";
                reason = "包裹不明";
            }
            if ((sortResultSorter & (1 << 2)) != 0)
            {
                reason = "无效滑槽";
            }
            if ((sortResultSorter & (1 << 3)) != 0)
            {
                reason = "堵塞";
            }
            if ((sortResultSorter & (1 << 4)) != 0)
            {
                reason = "超时";
            }
            if ((sortResultSorter & (1 << 5)) != 0)
            {
                reason = "滑槽满";
            }
            if ((sortResultSorter & (1 << 6)) != 0)
            {
                reason = "跟踪窗口重叠";
            }
            if ((sortResultSorter & (1 << 7)) != 0)
            {
                reason = "主机命令接受延迟";
            }
            if ((sortResultSorter & (1 << 8)) != 0)
            {
                reason = "包裹相隔太近";
            }
            if ((sortResultSorter & (1 << 9)) != 0)
            {
                reason = "包裹丢失";
            }
            if ((sortResultSorter & (1 << 10)) != 0)
            {
                reason = "分拣失败";
            }
            if ((sortResultSorter & (1 << 11)) != 0)
            {
                reason = "包裹太长";
            }
            if ((sortResultSorter & (1 << 12)) != 0)
            {
                reason = "长度检测失败";
            }
            if ((sortResultSorter & (1 << 13)) != 0)
            {
                reason = "分拣命令被覆盖";
            }
            if ((sortResultSorter & (1 << 14)) != 0)
            {
                reason = "包裹ID不明确";
            }
            return reason;
        }

        public static string GetStatus(int belt)
        {

            switch (belt)
            {
                case 0:
                    return "Default";
                case 10:
                    return "Create";//创建
                case 15:
                    return "Ready";//就绪
                case 16:
                    return "PreReceiving";//预收货
                case 17:
                    return "PreReceived";//已收货
                case 20:
                    return "Release";//释放
                case 22:
                    return "Active";//激活
                case 25:
                    return "Doing";//执行中
                case 30:
                    return "Picked";//已拣选
                case 40:
                    return "Packed";//已包装
                case 50:
                    return "Sorted";//已分拣
                case 60:
                    return "Output";//已出库
                case 70:
                    return "Assembcomplete";//集货完成
                case 80:
                    return "Loadtrack";//已装车
                case 90:
                    return "Shipping";//已发车
                case 100:
                    return "Customercomfirm";//客户已确认
                case 110:
                    return "Completed";//已完成
                case 111:
                    return "Updateinterface";//已上传接口
                case 120:
                    return "Cancelled";//取消
                case 121:
                    return "Fault";//失败
                case 130:
                    return "Terminated";
                case 85:
                    return "Terminated";
            }
            return belt.ToString();
        }



        public static string GetWorkTaskStatus(int belt)
        {

            switch (belt)
            {
                case 0:
                    return "Default";
                case 10:
                    return "Create";//创建
                case 15:
                    return "Ready";//就绪
                case 20:
                    return "Release";//释放
                case 22:
                    return "Booking";//
                case 25:
                    return "Active";//激活
                case 30:
                    return "Running";
                case 35:
                    return "Suspended";
                case 38:
                    return "Done";
                case 40:
                    return "Completed";//已完成
                case 45:
                    return "Cancelled";//取消
                case 50:
                    return "Terminated";
                case 55:
                    return "Faulted";//失败
                case 60:
                    return "Timeout";//
                case 65:
                    return "Resume";//
                case 70:
                    return "Over";//
            }
            return belt.ToString();
        }




    }
    public class SorterPlanData
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }

        public string PhysicalSortter { get; set; }
        public string SiteNo { get; set; }
        public string SorterMode { get; set; }

        public string CreateTime { get; set; }

        public string UpdateTime { get; set; }

        public string Name { get; set; }
    }
    public class PieData
    {
        public string name { get; set; }
        public int value { get; set; }

        public string sss { get; set; }
    }
    public class Output : Time
    {
        public string ResquestCode { get; set; }
        public string ReasonCode { get; set; }
        public string Reason { get; set; }
        public string Induct { get; set; }
        public string Shute { get; set; }
        public int Number { get; set; }
        public string Percent { get; set; }
        public string PhysicalSorter { get; set; }
        

    }
    public class Time
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string FaultTime { get; set; }
    }
    public class ScanData : Time
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public string Percent { get; set; }

    }

    public class ExcelModel
    {
        public string base64 { get; set; }
        public string startTime { get; set; }

        public string endTime { get; set; }
        public string paramater { get; set; }

        public string scanner { get; set; }
        public string phycialSorter { get; set; }
        public string sku { get; set; }
        public string skuName { get; set; }
        public string specification { get; set; }
        public string repositoryId { get; set; }
        public string custCode { get; set; }
        public string zoneNo { get; set; }
        public string cartonNum { get; set; }
        public string batch { get; set; }
        public string orderNo { get; set; }
        public string orderType { get; set; }
        public string status { get; set; }


    }

    public class ExportExcelBath
    {
        public string Id { get; set; }
    }

    public class ExportExcelPerson
    {
        public string Id { get; set; }
    }
    public class ExcelSorterPlan
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhysicalSortter { get; set; }
        public string LogicalDestination { get; set; }
        public string ParentId { get; set; }
        public string PhycialShute { get; set; }
        public  string BatchNo { get; set; }
        public string DestinationName { get; set; }
    }

    public class ExcelSku
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public string PrimarySkuId { get; set; }
        public int AbcRate { get; set; }
        public decimal MaxInventory { get; set; }
        public decimal MinInventory { get; set; }
        public bool EnableStatus { get; set; }
        public string Version { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal ValidLength { get; set; }
        public decimal ValidWidth { get; set; }
        public decimal ValidHeight { get; set; }
        public string Create_Operator { get; set; }
        public Nullable<System.DateTime> Create_OperatedTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string PackageUnit { get; set; }
        public string Specification { get; set; }
        public decimal FullQuantity { get; set; }
        public decimal BigFullQuantity { get; set; }
        public decimal SafetyQuantity { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }


    }


    public class ChuteFail : Time
    {
        public string PhysicalSorter { get; set; }
        public string PhycialShute { get; set; }
        public string Shute { get; set; }
        public string ReasonCode { get; set; }
        public string Reason { get; set; }
        public int Number { get; set; }
        public string Percent { get; set; }
        public string ObjectTohanle { get; set; }
        public string CreateTime { get; set; }

    }
    public class DeInfor
    {
        public string ObjectTohanle { get; set; }
        public string CreateTime { get; set; }

    }

    public class PackageInfor : Time
    {
        public string Shute { get; set; }

        public string Number { get; set; }
        public string PackageNo { get; set; }

        public string Speed { get; set; }

        public string PhysicalSorter { get; set; }

        public string  CreateTime { get; set; }

        public string ObjectTohanle { get; set; }

    }
    public class BarcodeFilter
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set;}
        public string RegularValue { get; set; }
        public string PhysicalSortter { get; set; }

    }

    public class TotalInfor
    {
        public string Date { get; set; }
        public string PhysicalSortter { get; set; }
        public string TotalOutPut { get; set; }
        public string SucceeOutPut { get; set; }
        public string Jam { get; set; }

        public string LaneFull { get; set; }
        public string RealNr { get; set; }
        public string De { get; set; }
        public string TimeOutNr { get; set; }
        public string Id { get; set; }
        public string TooClose { get; set; }
        public string Mr { get; set; }

        public string TooLong { get; set; }
        public string ExeceptionOutput { get; set; }
        public string GrRate { get; set; }
        public string SucessSortRate { get; set; }

        public string TrackingFail { get; set; }

        public string SortFailed { get; set; }

        public string TimeOut { get; set; }

    }

    public class BarcodePriority
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public string RegularValue { get; set; }
        public string PhysicalSortter { get; set; }
        public string LevelStatus { get; set; }

    }

    public class Detail
    {
        public string ObjectToHandle { get; set; }
        public string PhysicalSortter { get; set; }
        public string Shute { get; set; }
        public string SortTime { get; set; }
        public string Des { get; set; }
        public string PackageNo { get; set; }
    }

    public class Routing
    {
        public string Id { get; set; }
        public string SorterPlan { get; set; }
        public string LogicalDestination { get; set; }
        public string PhycialShute { get; set; }
        public string PhycialSorter { get; set; }
    }
    public class SystemSequence
    {
        public string Id { get; set; }
        public string Prefix { get; set; }
        public int Value { get; set; }
        public int MaxValue { get; set; }
        public int  MinValue { get; set; }
        public int IncreaseRate { get; set; } 
        public int ThresholdVlaue { get; set; }
        public bool IsActive { get; set; }
    }
    public class SystemParameter
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string PhysicalSortter { get; set; }
        public string Description { get; set; }
    }
    public class LogiclDestination
    {
        public string Id { get; set; }
        public string SorterPlan { get; set; }
        public string LogicalDestination { get; set; }
        public string Name { get; set; }
        public string PhycialSorter { get; set; }

        public string ParentId { get; set; }
    }
    public class PackageWork
    {
        public string Id { get; set; }
        public string PhycialSorter { get; set; }
        public string LogicalDestination { get; set; }
        public string Shute { get; set; }
        public string PackageNo { get; set; }
        public string PackageNumber { get; set; }
        public string CreateTime { get; set; }
    }
    public class NetWork
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public string Status { get; set; }
        public string Delay { get; set; }
    }

    public class SorterExecuteWorkTask
    {
        public string ObjectToHandle { get; set; }
        public string LogicalDestination { get; set; }

        public string CreateTime { get; set; }
    }

    public class Chute
    {
        public string PhycialSorter { get; set; }

        public string DeviceName1 { get; set; }

        public string PackageNo { get; set; }

        public string PackageNumber { get; set; }
        public string TheLastPackageNo { get; set; }

        public string TheLastPackageNumber { get; set; }
    }

    public class Person
    {
        public string BatchNo { get; set; }
        public string CurrentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string PhysicalSorter { get; set; }
        public string Shute { get; set; }
        public string PhysicalSorterShute { get; set; }
        public string Name { get; set; }
        public string JobNo { get; set; }
    }

    public class Batch
    {
        public string BatchNo { get; set; }
        public string Destination { get; set; }
        public string DriveTime { get; set; }
        public string CurrentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string RoutingCode { get; set; }
        public string PhysicalSorter { get; set; }
        public string Shute { get; set; }

        public string PhysicalSorterShute { get; set; }
    }

    public class OutputInventory : Time
    {

        public string CartonNum { get; set; }
        public string Sku { get; set; }
        public string SkuName { get; set; }
        public string SkuType { get; set; }
        public string PackageUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal BookingQuantity { get; set; }
        public string CustCode { get; set; }
        public string RepositoryId { get; set; }
        public string ZoneNo { get; set; }
        public string Batch { get; set; }
        public string Create_Operator { get; set; }
    }

    


    public class SkuByInventory : Time
    { 
        public string SkuCode { get; set; }
        public decimal MaxInventoryNum { get; set; }
    }


    public class OutputOrderLines : Time
    {
        public string Sku { get; set; }
        public string SkuName { get; set; }
        public string SkuType { get; set; }
        public string OrderNo { get; set; }
        public string OrderLineNo { get; set; }
        public string OrderLineNos { get; set; }
        public string Status { get; set; }
        public int Source { get; set; }
        public decimal Quantity { get; set; }
        public decimal BookQuantity { get; set; }
        public decimal FinishQuantity { get; set; }
        public string PackageUnit { get; set; }
        public string Batch { get; set; }
        public string DiyOwner { get; set; }
        public int OrderType { get; set; }
        public bool IsBigPackage { get; set; }
        public int OutboundZoneStrategy { get; set; }
        public string Create_Operator { get; set; }
    }


    public class OutputStocktaking : Time
    {
        public string Id { get; set; }
        public string Sku { get; set; }
        public string SkuName { get; set; }
        public string SkuType { get; set; }
        public string PackageUnit { get; set; }
        public string OrderHead { get; set; }
        public string OrderLine { get; set; }
        public string Status { get; set; }
        public string SourceStatus { get; set; }
        public decimal Quantity { get; set; }
        public decimal BookQuantity { get; set; }
        public decimal FinishQuantity { get; set; }
    }

    

    public class OutputSubSkus : Time
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public decimal MaxInventory { get; set; }
        public decimal MinInventory { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string PackageUnit { get; set; }
        public string Specification { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public string Create_Operator { get; set; }
        public decimal FullQuantity { get; set; }
        public decimal BigFullQuantity { get; set; }
        public decimal SafetyQuantity { get; set; }
    }



}