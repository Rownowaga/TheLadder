using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Omni.App_Code.helpers;

namespace Omni.App_Code.smashgg
{
    public class Tournament
    {
        public string addrState { get; set; }
        public int id { get; set; }
        public User[] admins { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime createdAt { get; set; }
        public string currency { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime endDat { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime eventRegistrationClosesAt { get; set; }
        public Event[] events { get; set; }
        public bool hasOnlineEvents { get; set; }
        public string hashtag { get; set; }
        public string[] images { get; set; }
        public bool isOnline { get; set; }
        public float lat { get; set; }
        public TournamentLinks links { get; set; }
        public float lng { get; set; }
        public string mapsPlaceId { get; set; }
        public string name { get; set; }
        public int numAttendess { get; set; }
        public User owner { get; set; }
        public Participants[] participants { get; set; }
        public string postalCode { get; set; }
        public string primaryContact { get; set; }
        public string primaryContactType { get; set; }
        public object publishing { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime registrationClosesAt { get; set; }
        public string rules { get; set; }
        public string shortSlug { get; set; }
        public string slug { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime startAt { get; set; }
        public int state { get; set; }
        public Stations[] stations { get; set; }
        public StreamQueueInfo streamQueue { get; set; }
        public Streams[] streams { get; set; }
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime teamCreationClosesAt { get; set; }
        public string timezone { get; set; }
        public int tournamentType { get; set; }

        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime updatedAt { get; set; }
        public string url { get; set; }
        public string venueAddress { get; set; }
        public string venueName { get; set; }
        public Wave[] waves { get; set; }

        public Tournament(string response)
        {
            JObject obj = JObject.Parse(response);
            JObject tournament = JObject.Parse(obj["data"]["tournament"].ToString());

            //Ints
            this.id = Conversion.ToInt((string)tournament["id"]);
            this.numAttendess = Conversion.ToInt((string)tournament["numAttendess"]);
            this.tournamentType = Conversion.ToInt((string)tournament["tournamentType"]);
            this.state = Conversion.ToInt((string)tournament["state"]);

            //Strings
            this.name = (string)tournament["name"];
            this.addrState = (string)tournament["addrState"];
            this.city = (string)tournament["city"];
            this.countryCode = (string)tournament["countryCode"];
            this.currency = (string)tournament["currency"];
            this.hashtag = (string)tournament["hashtag"];
            this.mapsPlaceId = (string)tournament["mapsPlaceId"];
            this.postalCode = (string)tournament["postalCode"];
            this.primaryContact = (string)tournament["primaryContact"];
            this.primaryContactType = (string)tournament["primaryContactType"];
            this.venueName = (string)tournament["venueName"];
            this.venueAddress = (string)tournament["venueAddress"];
            this.rules = (string)tournament["rules"];
            this.shortSlug = (string)tournament["shortSlug"];
            this.slug = (string)tournament["slug"];
            this.url = (string)tournament["url"];

            //DateTime
            this.createdAt = Conversion.UnixTimeStampToDateTime((string)tournament["createdAt"]);
            this.eventRegistrationClosesAt = Conversion.UnixTimeStampToDateTime((string)tournament["eventRegistrationClosesAt"]);
            this.registrationClosesAt = Conversion.UnixTimeStampToDateTime((string)tournament["registrationClosesAt"]);
            this.startAt = Conversion.UnixTimeStampToDateTime((string)tournament["startAt"]);
            this.endDat = Conversion.UnixTimeStampToDateTime((string)tournament["endDat"]);
            this.updatedAt = Conversion.UnixTimeStampToDateTime((string)tournament["updatedAt"]);
            this.teamCreationClosesAt = Conversion.UnixTimeStampToDateTime((string)tournament["teamCreationClosesAt"]);

            //Floats
            this.lat = Conversion.ToFloat((string)tournament["lat"]);
            this.lng = Conversion.ToFloat((string)tournament["lng"]);

            //Bools
            this.hasOnlineEvents = bool.Parse((string)tournament["hasOnlineEvents"]);
            this.isOnline = bool.Parse((string)tournament["isOnline"]);

            //JSON
            this.publishing = tournament["publishing"];

            //Objects
            this.streams = Streams.ParseStreams(tournament["streams"]);
            Console.Write("");
            //this.events = tournament["events"].ToString();
            //this.images = tournament[""].ToString();
            //this.links = (string)tournament["links"];
            //this.owner = tournament[""];
            //this.participants = tournament[""].ToString();
            //this.stations = tournament[""].ToString();
            //this.streamQueue = tournament[""].ToString();

            //this.timezone = tournament[""].ToString();
            //this.url = tournament[""].ToString();
            //this.waves = tournament[""].ToString();
        }
    }
}