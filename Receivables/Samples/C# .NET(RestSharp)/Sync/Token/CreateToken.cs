/// <summary>
/// API Request to create the token value to be used with other API requests
/// </summary>
/// <param name="username">Username of the user</param>
/// <param name="password">Password of the user</param>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">Returned PayFabric Receivables token object</param>
public void CreateToken(string username, string password, string URL, ref Token token)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/sync/Token.md for more details about request and response.
	// ------------------------------------------------------	
	
	try
	{
		var client = new RestClient(URL + "API/Token");
		var request = new RestRequest(Method.POST);
		request.AddHeader("content-type", "application/x-www-form-urlencoded");
		request.AddParameter("application/x-www-form-urlencoded", "grant_type=password&client_id=ePay_Sync&username=" + username + "&password=" + password, ParameterType.RequestBody);
		IRestResponse response = client.Execute(request);
		response.Content = response.Content.Remove(0, 1);

		if (response.StatusCode == System.Net.HttpStatusCode.OK)
		{
			try
			{
				JsonDeserializer deserial = new JsonDeserializer();
				token = deserial.Deserialize<Token>(response);
			}
			catch
			{
				token = null;
			}
		}
		else
			token = null;
	}
	catch
	{
		token = null;
	}
}