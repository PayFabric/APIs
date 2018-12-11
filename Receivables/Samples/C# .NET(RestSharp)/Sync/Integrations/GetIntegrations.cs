/// <summary>
/// API Request to get what needs to be integrated from PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="integrations">Returned integration object</param>
public void GetIntegrations(string URL, Token token, ref IntegrationPagingResponse integrations)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/sync/Integrations.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Integrations.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "sync/API/integrations?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			integrations = deserial.Deserialize<IntegrationPagingResponse>(response);
		}
		catch
		{
			integrations = null;
		}
	}
	else
		integrations = null;
}