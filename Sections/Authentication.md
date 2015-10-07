PayFabric API Authentication
============================
Clients wishing to utilize PayFabric have two ways to authenticate.

Clients running in server-side programming environments can include an authorization field in the HTTP header of each request that is made to PayFabric. The authorization field includes a _Device ID_ and a _Device Password_. These are the credentials for this application. You can generate these credentials via the PayFabric web portal. These credentials will provide access to all the PayFabric APIs, so you should only use this authentication method in secure environments.

For clients running on consumer devices (e.g. smartphones) PayFabric highly recommends the use of _Security Tokens_. Security tokens are one-time use authorization credentials. Below is a **cURL** example of creating a token:

```curl
curl -X GET \
  -H 'Authorization: deviceid|devicepassword' \
  https://sandbox.payfabric.com/v2/rest/api/token/create
```
If the HTTP Status Code is 200 - OK you will receive the following **JSON** response:
```JSON
{
  "Token": "4ts3gxu3o5an"
}
```
This token value must be supplied in a custom "authorization" header of the next HTTP web request. Once this token has been applied to a HTTP web request it will be revoked by PayFabric once it has completed the authentication process, any further requests will be required to generate a new token.
