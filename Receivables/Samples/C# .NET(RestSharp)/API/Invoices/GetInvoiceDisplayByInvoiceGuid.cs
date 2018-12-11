/// <summary>
/// API Request to get all selected outstanding invoices on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="invoiceGuid">Invoice object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="invoice">Returned invoice object</param>
public void GetInvoiceDisplay(string URL, Guid invoiceGuid, Token token, ref HTML invoice)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/Invoices.md#retrieve-invoice-html-to-be-displayed-by-identity for more details about request and response.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/invoices/display/" + invoiceGuid);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			invoice = ConvertToHTML(response);
		}
		catch
		{
			invoice = null;
		}
	}
	else
		invoice = null;
}
