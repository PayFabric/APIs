/// <summary>
/// API Request to get the current user on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="userName">Username string to be retrieved</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="responses">Returned response object</param>
public void GetUsersByName(string URL, Token token, ref EPayUser user)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/Accounts.md#retrieve-the-current-user for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/AccountUser.md#AccountUserResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/currentuser");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			user = deserial.Deserialize<EPayUser>(response);
		}
		catch
		{
			user = null;
		}
	}
	else
	{
		user = null;
	}
}
