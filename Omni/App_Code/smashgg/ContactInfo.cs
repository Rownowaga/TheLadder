using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class ContactInfo
    {
        int id { get; set; }
        string city { get; set; }
        string country { get; set; }
        int countryId { get; set; }
        string name { get; set; }
        string nameFirst { get; set; }
        string nameLast { get; set; }
        string state { get; set; }
        int stateId { get; set; }

        string zipcode { get; set; }

    }
}