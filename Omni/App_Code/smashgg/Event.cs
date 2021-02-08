using Newtonsoft.Json.Linq;
using Omni.App_Code.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Event
    {
        int id { get; set; }
        int checkInBuffer { get; set; }
        int checkInDuration { get; set; }
        bool checkInEnabled { get; set; }
        DateTime createdAt { get; set; }
        DateTime deckSubmissionDeadline { get; set; }
        int entrantSizeMax { get; set; }
        int entrantSizeMin { get; set; }
        int entrants { get; set; }
        bool hasDecks { get; set; }
        bool hasTasks { get; set; }
        SmashggImage[] images { get; set; }
        bool isOnline { get; set; }
        string matchRulesMarkdown { get; set; }
        string name { get; set; }
        int numEntrants { get; set; }
        PhaseGroup[] phaseGroups { get; set; }
        Phase[] phases { get; set; }
        object prizingInfo { get; set; }
        object publishing { get; set; }
        string rulesMarkdown { get; set; }
        int rulesetId { get; set; }
        Set[] sets { get; set; }
        string slug { get; set; }
        Standing standing { get; set; }
        DateTime startAt { get; set; }
        ActivityState state { get; set; }
        Stations stations { get; set; }
        DateTime teamManagementDeadline { get; set; }
        bool teamNameAllowed { get; set; }
        int type { get; set; }
        DateTime updatedAt { get; set; }
        bool useEventSeeds { get; set; }
        Videogame videogame { get; set; }
        Wave[] waves { get; set; }

        public Event(JToken v)
        {
            //Ints
            this.id = SmashggConversion.ToInt((string)v["id"]);
            this.checkInBuffer = SmashggConversion.ToInt((string)v["checkInBuffer"]);
            this.checkInDuration = SmashggConversion.ToInt((string)v["checkInDuration"]);
            this.entrantSizeMax = SmashggConversion.ToInt((string)v["entrantSizeMax"]);
            this.entrantSizeMin = SmashggConversion.ToInt((string)v["entrantSizeMin"]);
            this.numEntrants = SmashggConversion.ToInt((string)v["numEntrants"]);
            this.rulesetId = SmashggConversion.ToInt((string)v["rulesetId"]);



            //Bools
            this.checkInEnabled = bool.Parse((string)v["checkInEnabled"]);
            this.hasDecks = bool.Parse((string)v["hasDecks"]);
            this.hasTasks = bool.Parse((string)v["hasTasks"]);
            this.isOnline = bool.Parse((string)v["isOnline"]);
            this.useEventSeeds = (string)v["useEventSeeds"] == null ? false : bool.Parse((string)v["useEventSeeds"]);

            //Strings
            this.name = (string)v["name"];
            this.matchRulesMarkdown = (string)v["matchRulesMarkdown"];
            this.rulesMarkdown = (string)v["rulesMarkdown"];
            this.slug = (string)v["slug"];
            


            //DateTime
            this.createdAt = SmashggConversion.UnixTimeStampToDateTime((string)v["createdAt"]);
            this.deckSubmissionDeadline = SmashggConversion.UnixTimeStampToDateTime((string)v["deckSubmissionDeadline"]);
            this.startAt = SmashggConversion.UnixTimeStampToDateTime((string)v["startAt"]);
            this.teamManagementDeadline = SmashggConversion.UnixTimeStampToDateTime((string)v["teamManagementDeadline"]);

            //JOSN
            this.prizingInfo = v["prizingInfo"];
            this.publishing = v["publishing"];

            //Objects
            this.images = SmashggImage.ParseImages(v["images"]);

        }

        public static Event[] ParseEvents(JToken v)
        {
            int count = v.Children().Count();
            Event[] events = new Event[count];
            for (int i = 0; i < count; i++)
                events[i] = new Event(v[i]);

            return events;
        }

    }
}