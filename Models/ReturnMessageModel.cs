namespace WasWebServer.Models
{
    public class ResponseResult<T>
    {
        public T data { get; set; }
        public bool state { get; set; }
        public string message { get; set; }
    }
}