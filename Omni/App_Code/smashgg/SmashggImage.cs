using Newtonsoft.Json.Linq;
using Omni.App_Code.helpers;
using System.Linq;

namespace Omni.App_Code.smashgg
{
    public class SmashggImage
    {
        int id { get; set; }
        float height { get; set; }
        float ratio { get; set; }
        float width { get; set; }
        string type { get; set; }
        string url { get; set; }

        public SmashggImage(JToken v)
        {
            this.id = SmashggConversion.ToInt((string)v["id"]);
            this.height = SmashggConversion.ToFloat((string)v["height"]);
            this.ratio = SmashggConversion.ToFloat((string)v["ratio"]);
            this.width = SmashggConversion.ToFloat((string)v["width"]);
            this.type = (string)v["type"];
            this.url = (string)v["url"];
        }



        public static SmashggImage[] ParseImages(JToken v)
        {
            int count = v.Children().Count();
            SmashggImage[] images = new SmashggImage[count];
            for (int i = 0; i < count; i++)
                images[i] = new SmashggImage(v[i]);

            return images;
        }
    }
}