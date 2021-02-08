using System;
using System.Text;
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
    links
    {
      facebook
      discord
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
		images
    {
      id
      height
      ratio
      width
      type
      url
    }
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
    events
    {
      id
			checkInBuffer
      checkInDuration
      checkInEnabled
      createdAt
      deckSubmissionDeadline
      entrantSizeMax
      entrantSizeMin
      entrants
      {
        nodes
        {
          name
        }
      }
      hasDecks
      hasTasks
      images
      {
        id
        height
        ratio
        type
        url
        width
      }
      isOnline
      matchRulesMarkdown
      name
      numEntrants
      phaseGroups
      {
        id
      }
      phases
      {
        id
      }
      prizingInfo
      publishing
      rulesMarkdown
      rulesetId
      sets
      {
        nodes
        {
          id
        }
      }
      slug
      startAt
      state
      stations
      {
        nodes
        {
          id
        }
      }
      teamManagementDeadline
      teamNameAllowed
      type
      updatedAt
      useEventSeeds
      videogame
      {
        id
      }
      waves
      {
        id
      }
    }
	}
	}";

			RequestData request = new RequestData(); //Variable builder
			request.addKey("slug", "smashlan-d-106"); //My take on weakly typed object building
			var response = GraphQL.makeRequest(query, request.toJSON());
            Tournament tournament = new Tournament(response);
            //JObject x = JObject.Parse(response);

            Console.WriteLine(tournament.id);
		}
    }

}