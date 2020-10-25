using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class StandingContainer
    {
        Tournament tournament { get; set; }
        Event events { get; set; }
        PhaseGroup phaseGroup { get; set; }
        Set set { get; set; }
    }
}