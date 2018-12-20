using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace leaddoubler.Models
{
   public class Gender:BaseInputField
    {
        [JsonProperty("items")]
        public List<string> Items { get; protected set; }

        [JsonProperty("required")]
        public string Required { get; protected set; }

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
