using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omni.App_Code
{
    public class GraphQLRequest
    {
        public string query { get; set; }
        public string variables { get; set; }
        public string operationName { get; set; }
        public dynamic response { get; set; }
        public GraphQLRequest(string query, string variables, string operationName = "")
        {
            this.query = query;
            this.variables = variables;
            if (operationName == "")
                this.operationName = string.Empty;
            else
                this.operationName = operationName;
        }

        public GraphQLRequest()
        {

        }
    }
}