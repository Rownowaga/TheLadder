using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

using Omni.App_Code.helpers;

namespace Omni.App_Code.smashgg
{
    public class Streams
    {
        int id { get; set; }
        bool enabled { get; set; }
        int followerCount { get; set; }
        bool isOnline { get; set; }
        int numSetups { get; set; }
        int parentStreamId { get; set; }
        string streamGame { get; set; }
        string streamId { get; set; }
        string streamLogo { get; set; }
        string streamName { get; set; }
        string streamSource { get; set; }
        string streamStatus { get; set; }
        int streamType { get; set; }
        int streamTypeId { get; set; }

        public Streams(JToken v)
        {
            //Ints
            this.id = Conversion.ToInt((string)v["id"]);
            this.followerCount = Conversion.ToInt((string)v["followerCount"]);
            this.numSetups = Conversion.ToInt((string)v["numSetups"]);
            this.parentStreamId = Conversion.ToInt((string)v["parentStreamId"]);
            this.streamType = Conversion.ToInt((string)v["streamType"]);
            this.streamTypeId = Conversion.ToInt((string)v["streamTypeId"]);

            //Bools
            this.enabled = bool.Parse((string)v["enabled"]);
            this.isOnline = bool.Parse((string)v["isOnline"]);

            //Strings
            this.streamGame = (string)v["streamGame"];
            this.streamId = (string)v["streamId"];
            this.streamLogo = (string)v["streamLogo"];
            this.streamName = (string)v["streamName"];
            this.streamSource = (string)v["streamSource"];
            this.streamStatus = (string)v["streamStatus"];
        }

        public static Streams[] ParseStreams(JToken v)
        {
            int count = v.Children().Count();
            Streams[] streams = new Streams[count];
            for (int i = 0; i < count; i++)
                streams[i] = new Streams(v[i]);

            return streams;
        }
    }
}