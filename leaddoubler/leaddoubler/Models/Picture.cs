using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace leaddoubler.Models
{
   public class Picture:BaseInputField
    {
        [JsonProperty("prefix")]
        public string Prefix { get; protected set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; protected set; }
    }
}
