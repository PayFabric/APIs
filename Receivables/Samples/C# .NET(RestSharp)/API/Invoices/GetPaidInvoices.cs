/// <summary>
/// API Request to get all paid invoices on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="invoices">Returned invoice object</param>
public void GetPaidInvoices(string URL, Token token, ref InvoicePagingResponse invoices)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/API/Invoices.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Invoices.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/invoices/paid?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			invoices = deserial.Deserialize<InvoicePagingResponse>(response);
		}
		catch
		{
			invoices = null;
		}
	}
	else
		invoices = null;
}