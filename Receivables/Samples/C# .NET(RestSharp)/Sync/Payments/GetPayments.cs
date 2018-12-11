/// <summary>
/// API Request to get payments from PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="payments">Returned payment object</param>
public void GetPayments(string URL, Token token, ref PaymentPagingResponse payments)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/sync/Payments.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Payment.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/payments?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentList = deserial.Deserialize<PaymentPagingResponse>(response);
		}
		catch
		{
			paymentList = null;
		}
	}
	else
		paymentList = null;
}