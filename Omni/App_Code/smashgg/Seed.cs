using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Seed
    {
        int id { get; set; }
        string checkedInParticipants { get; set; }
        Entrant entrant { get; set; }
        int groupSeedNum { get; set; }
        bool isBye { get; set; }
        Phase phase { get; set; }
        PhaseGroup phaseGroup { get; set; }
        string placeholderName { get; set; }
        int placement { get; set; }
        Player[] players { get; set; }
        int progressionSeedId { get; set; }
        Progression progressionSource { get; set; }
        int seedNum { get; set; }
        Standing[] standings { get; set; }
    }
}