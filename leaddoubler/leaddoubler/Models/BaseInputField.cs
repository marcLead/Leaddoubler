using Newtonsoft.Json;
using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaddoubler.Models
{
   public class BaseInputField:INotifyPropertyChanged
    {      
        [JsonProperty("label")]
        public string Label { get; protected set; }

        [JsonProperty("type")]
        public string Type { get; protected set; }

        [JsonProperty("logicId")]
        public string LogicId { get; protected set; }

        [JsonProperty("index")]
        public int Index { get; protected set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
