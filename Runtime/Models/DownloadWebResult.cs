using UnityEngine;
using UnityEngine.Networking;

namespace com.stansassets.web
{
    public class DownloadWebResult : WebResult
    {
        protected override void InitResultWithData(DownloadHandler downloadHandler)
        {
            var json = downloadHandler.text;
            Debug.Log("DownloadHandler bytes received: " + RawData.Length);
        }
    }
}
