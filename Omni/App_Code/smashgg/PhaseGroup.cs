using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class PhaseGroup
    {
        int id { get; set; }
        BracketType bracketType { get; set; }
        string displayIdentifier { get; set; }
        DateTimeKind firstRoundTime { get; set; }
        int numRounds { get; set; }
        Phase phase { get; set; }
        Progression progressionsOut { get; set; }
        Round[] rounds { get; set; }
        string seedMap { get; set; }
        Seed[] seeds { get; set; }
        DateTime startAt { get; set; }
        int state { get; set; }
        string tieBreakOrder { get; set; }
        Wave wave { get; set; }
    }
}