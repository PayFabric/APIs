/// <summary>
/// API Request to get the current customer's autopay on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="autopayTemplates">Returned autopay object</param>
public void GetAllAutoPayTemplates(string URL, Token token, ref AutoPay autopay)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/AutoPays.md#retrieve-the-current-customer's-autopay for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/AutoPay.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/autopay");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			autopay = deserial.Deserialize<AutoPay>(response);
		}
		catch
		{
			autopay = null;
		}
	}
	else
		autopay = null;
}
