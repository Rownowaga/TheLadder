using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Progression
    {
        int id { get; set; }
        int originOrder { get; set; }
        Phase originPhase { get; set; }
        PhaseGroup originPhaseGroup { get; set; }
        int originPlacement { get; set; }

    }
}