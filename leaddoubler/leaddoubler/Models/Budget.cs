using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace leaddoubler.Models
{
   public class Budget:BaseInputField
    {
        [JsonProperty("minValue")]
        public double MinValue { get; protected set; }

        [JsonProperty("defaultValue")]
        public double DefaultValue { get; protected set; }

        [JsonProperty("maxValue")]
        public double MaxValue { get; protected set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; protected set; }

        [JsonProperty("suffix")]
        public string Suffix { get; protected set; }

        [JsonProperty("required")]
        public string Required { get; protected set; }

        private double _value=5000;
        public double Value
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
