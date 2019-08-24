using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code
{
    public class Tournament
    {
        public string id { get; set; }
        public string addrState { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string name { get; set; }
        public string postalCode { get; set; }
        public string slug { get; set; }
        public string region { get; set; }
        public int activityState { get; set; }
        public bool isOnline { get; set; }

        public Tournament(dynamic tourneyData)
        {
            this.id = tourneyData.id;
            this.addrState = tourneyData.addrState;
            this.city = tourneyData.city;
            this.countryCode = tourneyData.countryCode;
            this.isOnline = tourneyData.isOnline;
            if (this.isOnline)
            {
                this.lat = float.NaN;
                this.lng = float.NaN;
                this.postalCode = string.Empty;
            }
            else
            {
                this.lat = tourneyData.lat;
                this.lng = tourneyData.lng;
                this.postalCode = tourneyData.postalCode;
            }
            this.name = tourneyData.name;
            this.slug = tourneyData.slug;
            this.region = tourneyData.region;
            this.activityState = tourneyData.state;
        }
    }
}