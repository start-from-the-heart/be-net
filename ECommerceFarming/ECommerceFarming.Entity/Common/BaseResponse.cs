namespace ECommerceFarming.Entity.Common
{
    public class BaseResponse<T>
    {
        public T? Body { get; set; }

        public int StatusCode { get; set; }

        public string? Message { get; set; }

        public BaseResponse()
        {
        }

        public BaseResponse(T? body, int statusCode, string? message)
        {
            Body = body;
            StatusCode = statusCode;
            Message = message;
        }
    }
}