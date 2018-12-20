using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaddoubler.Models
{
    public class AllElements
    {
        public Email Email { get; set; }
        public Budget Budget { get; set; }
        public InterestRate InterestRate { get; set; }
        public Effectiveness Effectiveness { get; set; }
        public InfoHeader InfoHeader { get; set; }
        public Gender Gender { get; set; }
        public Age Age { get; set; }
        public Loan Loan { get; set; }
        public Picture Picture { get; set; }
        public Notes Notes { get; set; }
        public Factor Factor { get; set; }
        public DatePicker DatePicker { get; set; }
    }
}
