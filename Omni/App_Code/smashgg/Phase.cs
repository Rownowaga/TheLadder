
namespace Omni.App_Code.smashgg
{
    public class Phase
    {
        int id { get; set; }
        BracketType bracketType { get; set; }
        Event events { get; set; }
        int groupCount { get; set; }
        bool isExhibition { get; set; }
        string name { get; set; }
        int numSeeds { get; set; }
        PhaseGroup[] phaseGroups { get; set; }
        int phaseOrder { get; set; }
        Seed[] seeds { get; set; }
        Set[] sets { get; set; }
        ActivityState state { get; set; }
    }
}