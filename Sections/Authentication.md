PayFabric API Authentication
============================

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
```json
{
  "Token": "4ts3gxu3o5an"
}
```
Next, you parse this json text, extract the token string, and put this token string into other call's custom "authorization" header. One thing you have to be noticed is the token is valid to use once. PayFabric will revoke a security token once the token arrives and completes the authentication process.
