/// <summary>
/// API Request to delete the payment method specified on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="walletId">WalletId object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="paymentMethods">Returned payment method object</param>
public void GetPaymentMethodById(string URL, string walletId, Token token, ref Response responses)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/PaymentMethods.md#delete-a-payment-method for more details about request and response.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/paymentmethods/" + walletId);
	var request = new RestRequest(Method.DELETE);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			responses = deserial.Deserialize<PaymentMethodResponse>(response);
		}
		catch
		{
			responses = null;
		}
	}
	else
		responses = null;
}
