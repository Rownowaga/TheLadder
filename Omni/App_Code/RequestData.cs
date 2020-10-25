using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Omni.App_Code
{
    public class RequestData
    {
        private Hashtable varMap { get; set; }

        public RequestData()
        {
            varMap = new Hashtable();
        }

        /**
         * Adds the <key><value> pair to the HashTable
         * Returns the Scalar
         * */
        public int addKey(object key, object value)
        {
            varMap.Add(key, value);
            return varMap.Count;
        }

        public int removeKey(object key)
        {
            varMap.Remove(key);
            return varMap.Count;
        }

        public string toJSON()
        {
            return JsonConvert.SerializeObject(varMap);
        }
    }
}