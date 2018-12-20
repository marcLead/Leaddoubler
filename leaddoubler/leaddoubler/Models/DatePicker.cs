using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace leaddoubler.Models
{
   public class DatePicker:BaseInputField
    {
        [JsonProperty("dateFormat")]
        public string DateFormat { get; protected set; }

        private DateTimeOffset _value = DateTime.Now;

        public DateTimeOffset Value
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
