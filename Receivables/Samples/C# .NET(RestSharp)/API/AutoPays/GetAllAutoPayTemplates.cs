/// <summary>
/// API Request to get all autopay templates on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="autopayTemplates">Returned list of autopay template objects</param>
public void GetAllAutoPayTemplates(string URL, Token token, ref List<AutoPayTemplate> autopayTemplates)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/AutoPays.md#retrieve-all-autopay-templates for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/AutoPayTemplate.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/autopaytemplates");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			autopayTemplates = deserial.Deserialize<List<AutoPayTemplate>>(response);
		}
		catch
		{
			autopayTemplates = null;
		}
	}
	else
		autopayTemplates = null;
}
