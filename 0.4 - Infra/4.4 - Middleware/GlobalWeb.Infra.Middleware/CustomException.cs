using System;

namespace GlobalWeb.Infra.Middleware
{
    public class CustomException : Exception
    {
        public CustomException(string message, int httpStatusCode, string title) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Title = title;
        }
        public int HttpStatusCode { get; private set; }
        public string Title { get; private set; }
    }
}
