using Newtonsoft.Json;
using System.Collections.Generic;

namespace Aria2cNet.Client.Models
{
    [JsonObject]
    public class SystemMulticallMathod
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public List<object> Params { get; set; }
    }
}