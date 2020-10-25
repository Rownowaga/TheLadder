using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code.helpers
{
    public static class Conversion
    {
        public static DateTime UnixTimeStampToDateTime(string unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 13, 0, 0, 0, 0, System.DateTimeKind.Utc);
            if (unixTimeStamp != null)
            {
                Double ts = Double.Parse(unixTimeStamp);
                dtDateTime = dtDateTime.AddSeconds(ts).ToLocalTime();
            }
            return dtDateTime;
        }
        public static int ToInt(string v)
        {
            int a = 0;
            int.TryParse(v, out a);
            return a;
        }
        public static float ToFloat(string v)
        {
            float a = 0;
            float.TryParse(v, out a);
            return a;
        }
    }
}