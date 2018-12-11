/// <summary>
/// API Request to get the edit payment method url on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="walletId">WalletId object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="paymentMethods">Returned payment method object</param>
public void GetPaymentMethodsEditURL(string URL, string walletId, Token token, ref string walletUrl)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/PaymentMethods.md#retrieve-the-edit-wallet-url-for-payfabric-hosted-page for more details about request and response.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/paymentmethods/" + walletId);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			walletUrl = deserial.Deserialize<string>(response);
		}
		catch
		{
			walletUrl = null;
		}
	}
	else
		walletUrl = null;
}
