/// <summary>
/// API Request to get a specific payment from PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="paymentId">Payment object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="payment">Returned payment object</param>
public void GetPayment(string URL, string paymentId, Token token, ref PaymentResponse payment)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/sync/Payments.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Payment.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/payments/" + paymentId);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			paymentList = deserial.Deserialize<PaymentResponse>(response);
		}
		catch
		{
			paymentList = null;
		}
	}
	else
		paymentList = null;
}