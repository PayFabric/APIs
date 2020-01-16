/// <summary>
/// API Request to get a specific autopay template on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="id">Unqiue identifier for the autopay template on the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="autopayTemplate">Returned autopay template object</param>
public void GetAllAutoPayTemplates(string URL, Guid id, Token token, ref AutoPayTemplate autopayTemplate)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/AutoPays.md#retrieve-a-specific-autopay-template for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/AutoPayTemplate.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/autopaytemplate?id=" + id);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			autopayTemplate = deserial.Deserialize<AutoPayTemplate>(response);
		}
		catch
		{
			autopayTemplate = null;
		}
	}
	else
		autopayTemplate = null;
}
