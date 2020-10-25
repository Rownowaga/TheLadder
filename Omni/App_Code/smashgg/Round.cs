using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Round
    {
        int id { get; set; }
        int bestOf { get; set; }
        int number { get; set; }
        DateTime startAt { get; set; }
    }
}