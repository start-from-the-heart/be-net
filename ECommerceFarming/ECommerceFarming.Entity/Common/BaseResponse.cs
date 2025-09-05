using System.Net;

namespace ECommerceFarming.Entity.Common
{
    public class BaseResponse<T>
    {
        public T? Body { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string? Message { get; set; }

        public BaseResponse()
        {
        }

        public BaseResponse(T? body, HttpStatusCode statusCode, string? message)
        {
            Body = body;
            StatusCode = statusCode;
            Message = message;
        }
    }
}