using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace leaddoubler.Models
{
    public class Factor:BaseInputField
    {
        [JsonProperty("defaultValue")]
        public string DefaultValue { get; protected set; }
    }
}
