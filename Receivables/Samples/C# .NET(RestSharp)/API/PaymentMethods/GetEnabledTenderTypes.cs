/// <summary>
/// API Request to get the enabled tender types on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="walletId">WalletId object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="paymentMethods">Returned payment method object</param>
public void GetPaymentMethodById(string URL, string walletId, Token token, ref PaymentMethodResponse paymentMethod)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/API/PaymentMethods.md#retrieve-tendertype-enabling-on-wallet-page for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/PaymentMethod.md#PaymentMethodTenderTypeEnablingResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/paymentmethods/tendertypeenabling");
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentMethod = deserial.Deserialize<PaymentMethodResponse>(response);
		}
		catch
		{
			paymentMethod = null;
		}
	}
	else
		paymentMethod = null;
}
