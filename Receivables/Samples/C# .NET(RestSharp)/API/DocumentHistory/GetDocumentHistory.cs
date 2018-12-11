/// <summary>
/// API Request to get document history on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="history">Returned document history object</param>
public void GetDocumentHistory(string URL, Token token, ref DocumentHistoryPagingResponse history)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/DocumentHistory.md#retrieve-document-history for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/DocumentHistory.md#DocumentHistoryPagingResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/documents/history?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			history = deserial.Deserialize<DocumentHistoryPagingResponse>(response);
		}
		catch
		{
			history = null;
		}
	}
	else
		history = null;
}
