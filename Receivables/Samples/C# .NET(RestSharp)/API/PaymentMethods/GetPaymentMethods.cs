/// <summary>
/// API Request to get the payment methods with paging on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="paymentMethods">Returned payment method object</param>
public void GetPayments(string URL, Token token, ref PaymentMethodPagingResponse paymentMethods)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-paging for more details about request and response.
	// https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/PaymentMethod.md#paymentpagingresponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/paymentmethods/paging?filter.pageSize=10&filter.pageIndex=0");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentMethods = deserial.Deserialize<PaymentMethodPagingResponse>(response);
		}
		catch
		{
			paymentMethods = null;
		}
	}
	else
		paymentMethods = null;
}
