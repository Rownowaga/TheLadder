using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Player
    {
        int id { get; set; }
        int gamerTag { get; set; }
        int prefix { get; set; }
        PlayerRank[] rankings { get; set; }
        User user { get; set; }
    }
}