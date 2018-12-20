using leaddoubler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leaddoubler.Services
{
    interface IGetDataFromJsonService
    {
        AllElements GetDataFromLocalJson();
    }
}
