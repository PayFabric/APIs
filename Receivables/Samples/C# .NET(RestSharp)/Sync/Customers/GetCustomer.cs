/// <summary>
/// API Request to get the customer on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="customerId">Customer Object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="customer">Returned customer object</param>
public void GetCustomer(string URL, string customerId, Token tokenList, ref Customer customer)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/APIs/Sync/Customers.md#retrieve-a-customer-by-customer-identifier for more details about request and response.
	// Go to https://github.com/PayFabric/APIs/blob/master/Receivables/Sections/Objects/Customer.md#CustomerResponse for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "sync/API/customers?id=" + customerId);
	var request = new RestRequest(Method.GET);
	request.AddHeader("content-type", "application/json");
	request.AddHeader("authorization", "Bearer " + token.access_token);
	IRestResponse response = client.Execute(request);

	if (response.StatusCode == System.Net.HttpStatusCode.OK)
	{
		try
		{
			JsonDeserializer deserial = new JsonDeserializer();
			customerList = deserial.Deserialize<Customer>(response);
		}
		catch
		{
			customerList = null;
		}
	}
	else
		customerList = null;
}
