PayFabric Receivables API Authentication
============================
Clients will create a security token by making an API call. The security token can then be used to authenticate with the PayFabric Receivables API. It is recommended to request a token for every API call to avoid any connection issue. However, the token will be valid for 10 minutes. All API calls made within that 10 minute timeframe can use the same token. Once it hits the 10 minute mark, it will become invalid and a new token will be needed.

##### Step 1: Create / Get the User to be Used for the API Calls
In the PayFabric Receivables Management Portal you will be able to create additional users

##### Step 2: Make an API Call to Generate the Security Token
API Endpoint: `https://{PayFabric URL}/receivablesapi/{PortalName}/api/token`  

Replace the following variables from the endpoint URL:

  * `{PayFabric URL}`:
    * Production: `www.payfabric.com`
    * Sandbox: `sandbox.payfabric.com`
  * `{PortalName}`:  Use the ‘Portal Name’ obtain from Step 1.  

Make a Form Post API call to the endpoint with the following parameters:

  * `grant_type=password` - This is used to specify the authentication type
  * `client_id=ePay_Customer_Portal` - This is used to specify the type of user to be authenticated
  * `username={username}` - Replace `{username}` with the `Integration Key` from the previous step
  * `password={password}` - Replace `{password}` with the `Integration Key Password` from the previous step

```shell
curl -X POST \
  http://sandbox.payfabric.com/receivablesapi/nodus/api/token \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -d 'grant_type=password&client_id=ePay_Customer_Portal&username=Nodus0001&password=password1'
```
If the HTTP Status Code is 200 - OK, you will receive the following JSON response:

<pre>
{
    "access_token": "AIGMzQN2jvAeFtbPt9J0zNNMWQ46Knl5jReIMXp7vAh0JHmbUBxXUrk-s_LwgFM4cLcnXVGYAtCTKlyUeCRQn2xcXIvSRBJSECu6STRrScuxTDJh0j7u_fZNo_f60xku0mqesN5GW14iSNDVHpic2dxAp_oXsMnq977UxKS2dl-slvuRl5q7wdsRq_SZxQzb7JTS4C5MF_WgPFHN56UnKljpSTyyzgsh8qeIaE85tqZWv1KJaHsaBVxGFODY1YQjSwPeM3BVlTik5l2RPiv747fPVotZKcAZ8rGYomkEEjUwdgj3hjHvktORb41rzorXm__BDx-EOCnHD72F7e6nYzj690Jn148b4MHu0k7l1oyA-QssjTbNUlFWieA700C2ujR6bpZtVdP3zrDzudN7Nw",
    "token_type": "bearer",
    "expires_in": 599,
    "refresh_token": "17bb8a223f814e5286ef2f9e67efb172",
    "as:client_id": "ePay_Customer_Portal",
    "userName": "Nodus0001",
    ".issued": "Wed, 30 May 2018 20:31:49 GMT",
    ".expires": "Wed, 30 May 2018 20:41:49 GMT"
}
</pre>

##### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```shell
curl -X GET \
  http://sandbox.payfabric.com/receivablesapi/nodus/api/customers \
  -H 'Authorization: Bearer AIGMzQN2jvAeFtbPt9J0zNNMWQ46Knl5jReIMXp7vAh0JHmbUBxXUrk-s_LwgFM4cLcnXVGYAtCTKlyUeCRQn2xcXIvSRBJSECu6STRrScuxTDJh0j7u_fZNo_f60xku0mqesN5GW14iSNDVHpic2dxAp_oXsMnq977UxKS2dl-slvuRl5q7wdsRq_SZxQzb7JTS4C5MF_WgPFHN56UnKljpSTyyzgsh8qeIaE85tqZWv1KJaHsaBVxGFODY1YQjSwPeM3BVlTik5l2RPiv747fPVotZKcAZ8rGYomkEEjUwdgj3hjHvktORb41rzorXm__BDx-EOCnHD72F7e6nYzj690Jn148b4MHu0k7l1oyA-QssjTbNUlFWieA700C2ujR6bpZtVdP3zrDzudN7Nw' \
```
