PayFabric API Authentication
============================

Clients running in server-side programming environments can include an authorization field in the HTTP header of each request that is made to PayFabric. The authorization field includes a _Device ID_ and a _Device Password_. These are the credentials for this application. You can generate these credentials via the PayFabric web portal. These credentials will provide access to all the PayFabric APIs, so you should only use this authentication method in secure environments.


Device ID and Password
----------------------

```shell
curl -X GET \
  -H 'Authorization: deviceid|devicepassword' \
  https://sandbox.payfabric.com/v2/rest/api/address/1
```
