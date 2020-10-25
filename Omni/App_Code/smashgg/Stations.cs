using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.smashgg
{
    public class Stations
    {
        int id { get; set; }
        bool canAutoAssign { get; set; }
        string clusterNumber { get; set; }
        int clusterPrefix { get; set; }
        bool enabled { get; set; }
        int identifier { get; set; }
        int numSetups { get; set; }
        int number { get; set; }
        string prefix { get; set; }
        string queue { get; set; }
        int queueDepth { get; set; }
        int state { get; set; }
        DateTime updatedAt { get; set; }
    }
}