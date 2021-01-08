using System.Text;
using Newtonsoft.Json;

namespace com.stansassets.web
{
    public abstract class JsonWebRequest<T> : IWebRequest<T> where T : WebResult, new()
    {
        [JsonIgnore]
        public abstract string Url { get; }
        
        [JsonIgnore]
        public abstract WebRequestMethod Method { get; }

        [JsonIgnore]
        public byte[] Body
        {
            get
            {
                var json = JsonConvert.SerializeObject(this);
                return Encoding.UTF8.GetBytes(json);
            }
        }
    }
}
