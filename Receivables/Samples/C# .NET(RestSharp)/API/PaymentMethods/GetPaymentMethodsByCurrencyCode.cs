/// <summary>
/// API Request to get the payment methods associated to a currency on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="currencyCode">Currency code object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="paymentMethods">Returned payment method object</param>
public void GetPaymentMethodsByCurrencyCode(string URL, string currencyCode, Token token, ref PaymentMethodResponse paymentMethods)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-by-currency-code for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/PaymentMethod.md#PaymentMethodResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/paymentmethods?currencycode=" + currencyCode);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentMethods = deserial.Deserialize<PaymentMethodResponse>(response);
		}
		catch
		{
			paymentMethods = null;
		}
	}
	else
		paymentMethods = null;
}
