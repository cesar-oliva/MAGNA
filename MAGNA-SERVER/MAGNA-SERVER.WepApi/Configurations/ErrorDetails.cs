namespace MAGNA_SERVER.WebApi.Config
{
    internal class ErrorDetails
    {
        public ErrorDetails()
        {

        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; internal set; }
    }
}
