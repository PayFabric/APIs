/// <summary>
/// API Request to verify the user registration key on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="registrationKey">Registration key string to be retrieved</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="responses">Returned response object</param>
public void GetUsersByName(string URL, string registrationKey, Token token, ref RegistrationUser user)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/API/Accounts.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Accounts.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/users/registration/" + registrationKey);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			user = deserial.Deserialize<RegistrationUser>(response);
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