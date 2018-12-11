/// <summary>
/// API Request to export document history on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="responses">Returned response object</param>
public void ExportDocumentHistory(string URL, Token token, ref csvResponse responses)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/DocumentHistory.md#export-document-history for more details about request and response.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/documents/history/exports?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.POST);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	request.AddParameter("application/json", json, ParameterType.RequestBody);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			responses = ConvertToCSV(response);
		}
		catch
		{
			responses = null;
		}
	}
	else
	{
		responses = null;
	}
}
