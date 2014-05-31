#Overview
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints which are useful for developers.

1. Live Server:    ``https://www.payfabric.com/rest/v1/api``
1. Sandbox Server: ``https://sandbox.payfabric.com/rest/v1/api``
1. API Help: ``https://www.payfabric.com/rest/v1/api/help``

Before you programming with APIs, you need a PayFabric account, as well as simple configurations. [Quick Start](https://github.com/PayFabric/Portal/wiki) can go through for you.

#Authentication

3rd party applications have 2 ways to authenticate themselves. They are _Device Id/Password_ and _Security Token_. Both way, the developers have to submit one of them along with HTTP request for each call. The device id and device password authentication works for a server side programming environment, because malicious users are not able to intercept them. However, for a client side programming, we highly recommend to use the security token. Security token is only one-time use, so that it's more secure. Below is the sample code to exchange security token from PayFabric. 

```c#
var url =  "http://www.payfabric.com/rest/v1/api/token/create";
HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
httpWebRequest.ContentType = "application/json; charset=utf-8";
httpWebRequest.Headers["authorization"] = "5DE0B1D9-213C-4B05-80CA-D8A125977E20|6ytesddd*7";
HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
Stream responseStream = httpWebResponse.GetResponseStream();
StreamReader streamReader = new StreamReader(responseStream);
string result = streamReader.ReadToEnd();
streamReader.Close();
responseStream.Close();
httpWebRequest.Abort();
httpWebResponse.Close();
```
If everything goes fine, you can get a response as json format like this
```c#
{
    "Token": "4ts3gxu3o5an"
}
```
Next, you parse this json text, extract the token string, and put this token string into other call's custom "authorization" header. One thing you have to be noticed is the token is valid to use once. PayFabric will revoke a security token once the token arrives and completes the authentication process.

#Handling Exceptions
It is for sure you will encounter exceptions occasionally. The HTTP request to PayFabric API may return following status codes depending on certain situations.

| Code        | Description| 
| -------------|:-------------| 
| 200 OK| Everything goes fine | 
| 400 Bad Request | Normally, this is because you requested a wrong URL |
| 401 Unauthorized| Your authentication string (either device id/password or security token is wrong)|  
| 412 Precondition Failed| Missing fields or mandatory parameters|  
| 500 Internal Server Error| Oops, this is our fault and we're going to fix it |

Some programming languages such as .NET are going to throw run-time exception when receive response codes other than 200. In this case the developers may want to catch these exceptions so that application will exit gracefully. Below is the .NET sample code for exception handling, 
```c#
try
{
   // Do Something
}
catch (WebException ex)
{
  using (StreamReader reader = new StreamReader(ex.Response.GetResponseStream()))
  {
    string errorMsg = reader.ReadToEnd();
    Console.WriteLine("Error Message: " + errorMsg);
  }
}
Catch (Exception ex)
{
   // Error Handling
}
```

# Payment APIs


> Before drilling down to each API, you may want to get familiar with all the [JSON Objects](https://github.com/PayFabric/APIs/wiki) we are heavily using as payload of request and response. 


* [Create a New Transaction](https://github.com/PayFabric/APIs/wiki#create-a-new-transaction)
* [Update a Transaction](https://github.com/PayFabric/APIs/wiki#update-a-transaction)
* [Process a Transaction by Transaction Key](https://github.com/PayFabric/APIs/wiki#process-a-transaction-by-transaction-key)
* [Process a Transaction by Transaction Object](https://github.com/PayFabric/APIs/wiki#process-a-transaction-by-transaction-object)
* [Retrieve a Transaction](https://github.com/PayFabric/APIs/wiki#retrieve-a-transaction)
* [Add a Card into Wallet](https://github.com/PayFabric/APIs/wiki#add-a-card-into-wallet)
* [Update an Existing Card](https://github.com/PayFabric/APIs/wiki#update-an-existing-card)
* [Remove a Card](https://github.com/PayFabric/APIs/wiki#remove-a-card)
* [Retrieve Cards by Customer](https://github.com/PayFabric/APIs/wiki#retrieve-cards-by-customer)

# Misc APIs
* [Retrieve All Gateway Account Profiles](https://github.com/PayFabric/APIs/wiki#retrieve-all-gateway-account-profiles)
* [Retrieve a Gateway Account Profile By Id](https://github.com/PayFabric/APIs/wiki#retrieve-a-gateway-account-profile-by-id)
* [Retrieve Shipping addresses by Customer](https://github.com/PayFabric/APIs/wiki#retrieve-shipping-addresses-by-customer)
* [Retrieve Shipping address by Id](https://github.com/PayFabric/APIs/wiki#retrieve-shipping-address-by-id)
