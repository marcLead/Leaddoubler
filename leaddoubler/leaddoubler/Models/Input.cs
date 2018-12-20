using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace leaddoubler.Models
{
   public class Input
    {
        [JsonProperty("requestTime")]
        public string RequestTime { get; protected set; }

        [JsonProperty("inputFields")]
        public List<object> InputFields { get; protected set; }

        [JsonProperty("submitText")]
        public string SubmitText { get; protected set; }

        [JsonProperty("locale")]
        public string Locale { get; protected set; }
    }
}
