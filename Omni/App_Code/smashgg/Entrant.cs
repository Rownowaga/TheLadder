namespace Omni.App_Code.smashgg
{
    public class Entrant
    {
        int id { get; set; }
        Event events { get; set; }
        bool isDisqualified { get; set; }
        string name { get; set; }
        Participants[] participants { get; set; }
        Seed seed { get; set; }
        int skill { get; set; }
        Standing standing { get; set; }
        Streams[] streams{ get; set; }
    }
}