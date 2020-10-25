
namespace Omni.App_Code.smashgg
{
    public class GameSelection
    {
        int id { get; set; }
        Entrant entrant { get; set; }
        int orderNum { get; set; }
        Participants participant { get; set; }
        GameSelectionType selectionType { get; set; }
        int selectionValue { get; set; }
    }
}