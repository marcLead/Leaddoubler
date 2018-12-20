using leaddoubler.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leaddoubler.Services
{
    class GetDataFromJsonService : IGetDataFromJsonService
    {
        public AllElements GetDataFromLocalJson()
        {
            var input=JsonConvert.DeserializeObject<Input>(ReadJsonFile());
            AllElements allElements = new AllElements
            {
                Email=JsonConvert.DeserializeObject<Email>(JsonConvert.SerializeObject(input.InputFields[0])),
                Budget = JsonConvert.DeserializeObject<Budget>(JsonConvert.SerializeObject(input.InputFields[1])),
                InterestRate = JsonConvert.DeserializeObject<InterestRate>(JsonConvert.SerializeObject(input.InputFields[2])),
                Effectiveness = JsonConvert.DeserializeObject<Effectiveness>(JsonConvert.SerializeObject(input.InputFields[3])),
                InfoHeader = JsonConvert.DeserializeObject<InfoHeader>(JsonConvert.SerializeObject(input.InputFields[4])),
                Gender = JsonConvert.DeserializeObject<Gender>(JsonConvert.SerializeObject(input.InputFields[5])),
                Age = JsonConvert.DeserializeObject<Age>(JsonConvert.SerializeObject(input.InputFields[6])),
                Loan = JsonConvert.DeserializeObject<Loan>(JsonConvert.SerializeObject(input.InputFields[7])),
                Picture = JsonConvert.DeserializeObject<Picture>(JsonConvert.SerializeObject(input.InputFields[8])),
                Notes = JsonConvert.DeserializeObject<Notes>(JsonConvert.SerializeObject(input.InputFields[9])),
                Factor = JsonConvert.DeserializeObject<Factor>(JsonConvert.SerializeObject(input.InputFields[10])),
                DatePicker = JsonConvert.DeserializeObject<DatePicker>(JsonConvert.SerializeObject(input.InputFields[11]))
            };
            return allElements;
        }

        private string ReadJsonFile()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("leaddoubler.JSONdata.jsonData.json");
            string text = String.Empty;
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}
