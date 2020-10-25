using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Game
    {
        int id { get; set; }
        int orderNum { get; set; }
        GameSelection[] selections { get; set; }
        Stage stage { get; set; }
        int state { get; set; }
        int winnerId { get; set; }
    }
}