using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Standing
    {
        StandingContainer container { get; set; }
        int id { get; set; }
        Entrant entrant { get; set; }
        bool isFinal { get; set; }
        string metadata { get; set; }
        int placement { get; set; }
        Player player { get; set; }
        StandingStats stats { get; set; }
    }
}