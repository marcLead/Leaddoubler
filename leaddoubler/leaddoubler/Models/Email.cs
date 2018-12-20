using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace leaddoubler.Models
{
    public class Email:BaseInputField
    {
        [JsonProperty("prefix")]
        public string Prefix { get; protected set; }

        [JsonProperty("maxChars")]
        public double MaxChars { get; protected set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; protected set; }

        [JsonProperty("required")]
        public string Required { get; protected set; }

        [JsonProperty("validation")]
        public string Validation { get; protected set; }

        [JsonProperty("minChars")]
        public double MinChars { get; protected set; }

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
