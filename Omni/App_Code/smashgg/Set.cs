using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Set
    {
        int id { get; set; }
        DateTime completedAt { get; set; }
        DateTime createdAt { get; set; }
        string displayScore { get; set; }
        Event events { get; set; }
        string fullRoundText { get; set; }
        Game game { get; set; }
        Game[] games {get; set; }
        bool hasPlaceholder { get; set; }
        int identifier { get; set; }
        int IPlacement { get; set; }
        PhaseGroup phaseGroup { get; set; }
        int round { get; set; }
        int setGamesType { get; set; }
        DateTime startedAt { get; set; }
        int state { get; set; }
        Stations station { get; set; }
        Streams stream { get; set; }
        int totalGames { get; set; }
        string vodUrl { get; set; }
        int wPlacement { get; set; }
        int winnerId { get; set; }
    }
}