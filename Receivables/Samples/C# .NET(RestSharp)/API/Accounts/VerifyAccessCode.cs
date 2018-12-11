/// <summary>
/// API Request to verify the user registration key on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="registrationKey">Registration key string to be retrieved</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="responses">Returned response object</param>
public void VerifyAccessCode(string URL, string registrationKey, Token token, ref RegistrationUser user)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/Accounts.md#verify-access-code for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/AccessCode.md#AccessCodeResponse for more details about the object.
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
