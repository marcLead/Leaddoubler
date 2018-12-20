using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace leaddoubler.Models
{
    public class Age:BaseInputField
    {
        [JsonProperty("showIfLogicId")]
        public string ShowIfLogicId { get; protected set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; protected set; }

        [JsonProperty("items")]
        public List<string> Items { get; protected set; }

        [JsonProperty("required")]
        public string Required { get; protected set; }

        [JsonProperty("showIfValue")]
        public string ShowIfValue { get; protected set; }

        private string _value = String.Empty;

        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }
    }
}
