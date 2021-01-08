using System;
using System.Collections;
using StansAssets.Foundation.Async;
using UnityEngine;
using UnityEngine.Networking;

namespace com.stansassets.web
{
    /// <summary>
    /// Nice tool for testing: https://webhook.site/
    /// </summary>
    public abstract class WebService : IWebService
    {
        public abstract string ServerUrl { get; }
        protected abstract int RequestsTimeout { get; }

        public void Send<T>(IWebRequest<T> request, Action<T> onResult = null) where T : WebResult, new()
        {
            var unityWebRequest = CreateUnityWebRequest(request);
            if (Application.isPlaying)
            {
                CoroutineUtility.Start(SendRequest(unityWebRequest, () =>
                {
                    var result = new T();
                    result.SetUnityWebRequest(unityWebRequest);
                    onResult?.Invoke(result);
                }));
            }
        }

        public void Send<T>(IUploadWebRequest<T> request, Action<T> onResult = null) where T : WebResult, new()
        {
            var unityWebRequest = CreateUnityWebRequest(request);
            CoroutineUtility.Start(SendRequest(unityWebRequest, () =>
            {
                var result = new T();
                result.SetUnityWebRequest(unityWebRequest);
                onResult?.Invoke(result);
            }));
        }

        protected virtual UnityWebRequest CreateUnityWebRequest<T>(IUploadWebRequest<T> request) where T : WebResult, new()
        {
            var requestUrl = $"{ServerUrl}/{request.Url}";
            var unityWebRequest = UnityWebRequest.Post(requestUrl, request.PostForm);

            Debug.Log($"{unityWebRequest.method}: {requestUrl}");
            return unityWebRequest;
        }

        protected virtual UnityWebRequest CreateUnityWebRequest<T>(IWebRequest<T> request) where T : WebResult, new()
        {
            var requestUrl = $"{ServerUrl}/{request.Url}";
            var unityWebRequest = new UnityWebRequest(requestUrl)
            {
                method = request.Method.ToString().ToUpper(),
                timeout = RequestsTimeout,
                downloadHandler = new DownloadHandlerBuffer()
            };

            if (request.Method != WebRequestMethod.Get) {
                unityWebRequest.uploadHandler = new UploadHandlerRaw(request.Body);
                unityWebRequest.SetRequestHeader("Content-type", @"application/json");
            }

            Debug.Log($"{unityWebRequest.method}: {requestUrl}");
            return unityWebRequest;
        }

        IEnumerator SendRequest(UnityWebRequest webRequest, Action onComplete)
        {
            yield return webRequest.SendWebRequest();
            onComplete.Invoke();
        }
    }
}
