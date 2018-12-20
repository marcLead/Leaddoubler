using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;

namespace leaddoubler.Models
{
   public class InterestRate:BaseInputField
    {
        [JsonProperty("showIfLogicId")]
        public string ShowIfLogicId { get; protected set; }

        [JsonProperty("min")]
        public double Min { get; protected set; }

        [JsonProperty("max")]
        public double Max { get; protected set; }

        [JsonProperty("defaultValue")]
        public double DefaultValue { get; protected set; }
        
        [JsonProperty("stepSize")]
        public double StepSize { get; protected set; }

        [JsonProperty("suffix")]
        public string Suffix { get; protected set; }

        [JsonProperty("showIfValue")]
        public string ShowIfValue { get; protected set; }

        private double _value= 10.5;

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
