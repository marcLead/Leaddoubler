using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace leaddoubler.Models
{
    public class Effectiveness:BaseInputField
    {
        [JsonProperty("defaultValue")]
        public string DefaultValue { get; protected set; }

        [JsonProperty("items")]
        public List<string> Items { get; protected set; }

        private string _value = "Medium";

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
