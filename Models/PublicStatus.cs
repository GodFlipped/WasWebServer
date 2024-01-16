namespace WasWebServer.Models
{
    public class PublicStatus
    {
        public static string GetOrderHeadsStatus(int belt)
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
                    return "Audit";//审核
                case 25:
                    return "Waved";//波次
                case 30:
                    return "Release";
                case 35:
                    return "Active";
                case 40:
                    return "Doing";//执行中
                case 45:
                    return "Suspended";
                case 80:
                    return "Completed";//已完成
                case 85:
                    return "Terminated";
                case 90:
                    return "Cancelled";//取消
                case 95:
                    return "Fault";//
                case 100:
                    return "Close";//已关闭
            }
            return belt.ToString();
        }

        public static string GetOrderLinesStatus(int belt)
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
                    return "Audit";//审核
                case 25:
                    return "Waved";//波次
                case 30:
                    return "Release";
                case 35:
                    return "Active";
                case 40:
                    return "Doing";//执行中
                case 45:
                    return "Suspended";
                case 80:
                    return "Completed";//已完成
                case 85:
                    return "Terminated";
                case 90:
                    return "Cancelled";//取消
                case 95:
                    return "Fault";//
                case 100:
                    return "Close";//已关闭
            }
            return belt.ToString();
        }

        public static string GetWorkTasksStatus(int belt)
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
                    return "Audit";//审核
                case 25:
                    return "Waved";//波次
                case 30:
                    return "Release";
                case 35:
                    return "Active";
                case 40:
                    return "Doing";//执行中
                case 45:
                    return "Suspended";
                case 80:
                    return "Completed";//已完成
                case 85:
                    return "Terminated";
                case 90:
                    return "Cancelled";//取消
                case 95:
                    return "Fault";//
                case 100:
                    return "Close";//已关闭
            }
            return belt.ToString();
        }


    }
}