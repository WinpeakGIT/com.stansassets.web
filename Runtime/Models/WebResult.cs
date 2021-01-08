using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Networking;

namespace com.stansassets.web
{
    public class WebResult
    {
        UnityWebRequest m_UnityWebRequest;

        public bool IsFailed => HasError;
        public bool IsSucceeded => !HasError;
        public string Error => m_UnityWebRequest.error;
        public bool HasError => m_UnityWebRequest.isNetworkError || m_UnityWebRequest.isHttpError;
        public long ResponseCode => m_UnityWebRequest.responseCode;

        public string RawText => m_UnityWebRequest.downloadHandler.text;
        public byte[] RawData => m_UnityWebRequest.downloadHandler.data;

        internal void SetUnityWebRequest(UnityWebRequest unityWebRequest)
        {
            Assert.IsTrue(unityWebRequest.isDone);
            m_UnityWebRequest = unityWebRequest;

            if (!HasError)
            {
                InitResultWithData(m_UnityWebRequest.downloadHandler);
            }
        }

        protected virtual void InitResultWithData(DownloadHandler downloadHandler)
        {
            var json = downloadHandler.text;
            Debug.Log("DownloadHandler: " + json);
            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, this);
            }
        }
    }
}
