/// <summary>
/// API Request to get document history currencies on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="currencies">Returned currencies object</param>
public void GetDocumentHistoryCurrency(string URL, Token token, ref CurrencyResponse currencies)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/DocumentHistory.md#retrieve-document-history-currencies for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/Currency.md#CurrencyResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/documents/history/currencies");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			currencies = deserial.Deserialize<CurrencyResponse>(response);
		}
		catch
		{
			currencies = null;
		}
	}
	else
		currencies = null;
}
