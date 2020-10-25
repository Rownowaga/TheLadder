using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

namespace Omni.App_Code.smashgg
{
    public class User
    {
        int id { get; set; }
        string bio { get; set; }
        string birthday { get; set; }
        string genderPronoun { get; set; }
        string[] imges { get; set; }
        string facebook { get; set; }
        Address location { get; set; }
        string name { get; set; }
        Player player { get; set; }
        string slug { get; set; }
        public User(JToken user)
        {
        
        }
    }
}