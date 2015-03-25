#Overview
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com/v2/rest/api``
1. Sandbox Server: ``https://sandbox.payfabric.com/v2/rest/api``

Check out the [Quick Start Guide](https://github.com/PayFabric/Portal/wiki) to learn how to register for a PayFabric account, configure your account, and get started with the PayFabric REST API.

#Authentication
PayFabric clients have two ways to authenticate. 

Clients running in server-side programming environments can include an authorization field in the 
HTTP header of each request that is made to PayFabric. The authorization includes a _Device ID_ and 
a _Device Password_. These are the credentials for this application. You can generate these credentials
via the PayFabric web portal. These credentials give you complete access to the PayFabric API, so you 
should only use this authentication method in secure environments.

For clients running on consumer devices (e.g. smartphones) PayFabric highly recommends the use of 
_Security Tokens_. Security tokens are one-time use authorization credentials.

```c#
var url =  "http://www.payfabric.com/v2/rest/api/token/create";
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
PayFabric uses HTTP response codes to indicate the status of requests. Below is a description of the 
meanings of the most common response codes that you will encounter. In general, status codes in 
the range of 200 to 299 indicate success. 400 to 499 indicate that the client has made a mistake.
500 and beyond indicate that PayFabric experienced an error. 

| Code        | Description | 
| ------------- | :------------- | 
| 200 OK | Request Successful | 
| 400 Bad Request | The request is missing required information. Verify that you are accessing the correct URL (including all query string parameters). If sending a JSON payload, check that you have provided all required elements, and make sure that there are no typos in your element names (JSON elements are case-sensitive!) |
| 401 Unauthorized | The authentication string provided by the client (either Device ID / Device Password, or Security Token) is invalid. |  
| 404 Not Found | The requested resource could not be located. Check for typos in your resource URI. |  
| 412 Precondition Failed | Missing fields or mandatory parameters. See description of status code 400. |  
| 500 Internal Server Error| PayFabric server encountered an error. |

Some programming languages such as .NET throw run-time exceptions when an HTTP response returns a status code other than 200. You can use these exceptions to programmatically recover or at least exit gracefully from errors. Below is an example in C# of catching exceptions.
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
PayFabric sends and receives payloads as structured [JSON Objects](https://github.com/PayFabric/APIs/wiki/API-Object-V2). 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

## Transactions
* [Create a New Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-a-transaction)
* [Update a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#update-a-transaction)
* [Process a Transaction by Transaction Key](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#submit-a-transaction-to-payment-gateway-by-transaction-key)
* [Process a Transaction by Transaction Object](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-and-submit-a-transaction-by-transaction-object)
* [Retrieve a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-a-transaction)
* [Capture a Pre-Authorized Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#capture-a-pre-authorized-transaction)
* [Cancel a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#cancel-a-transaction)
* [Refund a Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#refund-a-customer)

## Wallets / Credit Cards / Echecks
* [Add a Card into Wallet](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-a-credit-card)
* [Update an Existing Card](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#update-an-existing-card)
* [Remove a Card](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#delete-a-card)
* [Retrieve Cards by Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-cards-by-customer)

## Payment Gateways
* [Retrieve All Gateway Account Profiles](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-all-payment-gateways)
* [Retrieve a Gateway Account Profile By Id](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-a-payment-gateway-by-id)

## Addresses
* [Retrieve Shipping addresses by Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-shipping-addresses-by-customer)
* [Retrieve Shipping address by Id](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-shipping-address-by-id)

#Hosted Payment Page

* [Embed PayFabric Hosted Payment Page into your application](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#embed-payfabric-hosted-payment-page-into-your-application)
* [Configurations](https://github.com/PayFabric/Portal/wiki#advanced-settings)
* [Build your own page with CSS code](https://github.com/PayFabric/Themes)
