using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaddoubler.Models
{
    public class Values:RealmObject
    {
        public string EmailValue { get; set; }
        public double BudgetValue { get; set; }
        public double InterestRateValue { get; set; }
        public string EffectivenessValue { get; set; }
        public string GenderValue { get; set; }
        public string AgeValue { get; set; }
        public string LoanValue { get; set; }
        public string NotesValue { get; set; }
        public DateTimeOffset DateValue { get; set; }
        public string Name { get; set; }
    }
}
