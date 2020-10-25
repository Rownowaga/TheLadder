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
        string[] images { get; set; }
        bool isOnline { get; set; }
        string matchRulesMarkdown { get; set; }
        string name { get; set; }
        int numEntrants { get; set; }
        PhaseGroup[] phaseGroups { get; set; }
        Phase[] phases { get; set; }
        string prizingInfo { get; set; }
        string publishing { get; set; }
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

    }
}