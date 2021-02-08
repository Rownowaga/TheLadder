using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Omni.App_Code.smashgg
{
    public class TournamentLinks
    {
        string facebook { get; set; }
        string discord { get; set; }

        public TournamentLinks(JToken value)
        {
            this.facebook = (string)value["facebook"];
            this.discord = (string)value["discord"];
        }
    }
}