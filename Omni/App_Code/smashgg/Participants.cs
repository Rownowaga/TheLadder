using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Participants
    {
        int id { get; set; }
        bool checkedIn { get; set; }
        DateTime checkedInat { get; set; }
        string connectedAccounts { get; set; }
        ContactInfo contactInfo { get; set; }
        string email { get; set; }
        Entrant[] entrants { get; set; }
        Event[] events { get; set; }
        string gamerTag { get; set; }
        string images { get; set; }
        Player player { get; set; }
        string prefix { get; set; }
        User user { get; set; }
        bool verified { get; set; }
    }
}