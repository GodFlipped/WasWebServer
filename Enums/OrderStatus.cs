namespace WasWebServer.Enums
{
    public enum QualityCheckStatus
    {
        UnChecked = 10,
        WaitingChecked = 15,
        Checked = 20
    }
}


namespace WasWebServer.Enums
{
    public enum QualityStatus
    {
        Unquality = 10,
        Waiting = 15,
        Quality = 20
    }
}


namespace WasWebServer.Enums
{
    public enum OrderStatus
    {
        Default = 0,
        Create = 10, //创建
        Ready = 15, //就绪
        PreReceiving = 16, //预收货
        PreReceived = 17, //已收货 
        Release = 20, //释放 
        Active = 22, //激活  
        Doing = 25, //执行中
        Picked = 30, //已拣选
        Packed = 40, //已包装
        Sorted = 50, //已分拣
        Output = 60, //已出库
        Assembcomplete = 70, //集货完成
        Loadtrack = 80, //已装车
        Shipping = 90, //已发车
        Customercomfirm = 100, //客户已确认
        Completed = 110, //已完成
        Updateinterface = 111, //已上传接口
        Cancelled = 120, //取消
        Fault = 121, //失败
        Terminated = 130
    }
}

namespace WasWebServer.Enums
{
    public enum WorkTaskStatus
    {
        Default = 0,
        Create = 10,
        Ready = 15,
        Release = 20,
        Booking = 22,
        Active = 25,
        Running = 30,
        Suspended = 35,
        Done = 38,
        Completed = 40,//已完成
        Cancelled = 45,//取消
        Terminated = 50,
        Faulted = 55,//失败
        Timeout = 60,
        Resume = 65,
        Over = 70
    }

    public enum WorkTaskType
    {
        Default = 0,
        Storage = 201,
        Retrival = 202,
        Transport = 203,
        Sorting = 300,
        Complement = 301,
        Mes = 302,
        Pda = 303,
        Picking = 304,
        Bag = 401,
        Shipment = 402
    }

    public enum WorkTaskTriggerMode
    {
        Default = 0,
        Immediately = 10,
        Interval = 20,
        Time = 30,
        Event = 40
    }

    public enum SorterMessageType
    {
        Default = 0,
        InductSuccess = 10,
        InductFailure = 20,
        UnknowPackage = 30,
        PreCreatePackage = 40,
        CreatePackage = 50,
        CancelPackage = 60,
        Complement = 70,
        BoardOpen = 80,
        DesClear = 90
    }
}







