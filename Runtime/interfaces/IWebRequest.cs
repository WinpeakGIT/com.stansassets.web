using System.Collections.Generic;
using UnityEngine.Networking;

namespace com.stansassets.web
{
    public interface IWebRequest<T> where T : WebResult, new()
    {
        string Url { get; }
        WebRequestMethod Method { get; }
        byte[] Body { get; }
    }
    
    public interface IUploadWebRequest<T> where T : WebResult, new()
    {
        string Url { get; }
        List<IMultipartFormSection> PostForm { get; }
    }
}
