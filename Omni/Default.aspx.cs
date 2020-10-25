using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Omni.App_Code;
using Omni.App_Code.smashgg;

namespace Omni
{
    public partial class Default : System.Web.UI.Page
    {

		//Button click on webpage
        protected void Unnamed_Click(object sender, EventArgs e)
        {
			//Will make a query builder class eventually
            string query = @"query TournamentQuery($slug: String) {
		tournament(slug: $slug){
			id
			addrState
    	city
      countryCode
    	createdAt
    	currency
    	admins {
    	  id
    	}
    endAt
    eventRegistrationClosesAt
    hasOfflineEvents
    hasOnlineEvents
    hashtag
    isOnline
    isRegistrationOpen
    lat
    
    lng
    mapsPlaceId
    name
    numAttendees
    postalCode
    primaryContact
    primaryContactType
    publishing
    registrationClosesAt
    rules
    slug
    startAt
    state
    teamCreationClosesAt
    timezone
    tournamentType
    updatedAt
    venueAddress
    venueName
    streams
    {
      id
			enabled
      followerCount
      isOnline
      numSetups
      parentStreamId
      streamGame
      streamId
      streamLogo
      streamName
      streamSource
      streamStatus
      streamType
      streamTypeId
    }
	}
	}";

			RequestData request = new RequestData(); //Variable builder
			request.addKey("slug", "smashlan-d-106"); //My take on weakly typed object building
			var response = GraphQL.makeRequest(query, request.toJSON());
            //Tournament tournament = new Tournament(response);
            JObject x = JObject.Parse(response);
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.NullValueHandling = NullValueHandling.Ignore;
            Tournament tournament = JsonConvert.DeserializeObject<Tournament>(x["data"]["tournament"].ToString(), jss);
            Console.WriteLine(tournament.id);
		}
    }

}