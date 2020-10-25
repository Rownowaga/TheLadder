using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Address
    {
        int id { get; set; }
        string city { get; set; }
        string country { get; set; }
        int countryId { get; set; }
        string state { get; set; }
        int stateId { get; set; }
    }
}