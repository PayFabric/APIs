/// <summary>
/// API Request to get the customer on PayFabric Receivables
/// </summary>
/// <param name="URL">URL of the PayFabric Receivables site</param>
/// <param name="customerId">Customer Object to get</param>
/// <param name="token">PayFabric Receivables token object</param>
/// <param name="customer">Returned customer object</param>
public void GetCustomer(string URL, Token token, ref Customer customer)
{
	// Sample request and response
	// ------------------------------------------------------
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/APIs/API/Customers.md for more details about request and response.
	// Go to https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/Cloud%20API%20Guide/Sections/Objects/Customer.md for more details about the object.
	// ------------------------------------------------------
	
	var client = new RestClient(URL + "API/customers/current");
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