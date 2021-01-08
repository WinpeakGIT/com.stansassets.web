using System;

namespace com.stansassets.web
{
    public interface IWebService
    {
        string ServerUrl { get; }
        void Send<T>(IWebRequest<T> request, Action<T> onResult = null) where T : WebResult, new();
        void Send<T>(IUploadWebRequest<T> request, Action<T> onResult = null) where T : WebResult, new();
    }
}
