using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Omni.App_Code;

namespace Omni
{
    public partial class Default : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            GraphQLRequest tourneyRequest = new GraphQLRequest(@"query TournamentsByowner($perPage: Int!, $ownerId: ID!) {
            tournaments(query: {
                perPage: $perPage
                filter: {
                    ownerId: $ownerId
                    }
                }) {
                    nodes {
                    id
                    addrState
                    city
                    countryCode
                    lat
                    lng
                    name
                    postalCode
                    slug
                    region
                    state
                    isOnline
                    }
                }
            }", "{\"ownerId\": 161429, \"perPage\": 4}");

            StringBuilder sb = new StringBuilder();
            tourneyRequest.response = await GQLHandler.MakeRequest(tourneyRequest);
            foreach (var obj in tourneyRequest.response.data.tournaments.nodes)
            {
                Tournament t = new Tournament(obj);
                sb.AppendLine("<div>");
                sb.AppendLine("<h2>"+t.name+"</h2>");
                sb.AppendLine("<br />" + t.isOnline);
                sb.AppendLine("<br />" + t.lat);
                sb.AppendLine("<br />" + t.lng);
                sb.AppendLine("<br />" + t.postalCode);
                sb.AppendLine("<br />" + t.region);
                sb.AppendLine("<br />" + t.slug);
                sb.AppendLine("</div>");
                sb.AppendLine("<hr />");
            }
            litResponse.Text = sb.ToString();
        }
    }
}