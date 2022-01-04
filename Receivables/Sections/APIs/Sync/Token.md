PayFabric Receivables Sync API Authentication
============================
Clients will create a security token by making an API call. The security token can then be used to authenticate with the PayFabric Receivables Sync API. It is recommended to use the same API token for all Sync API calls for ease of use. However, the token will expire after 100 days and a new token will be needed.

##### Step 1: Obtain Credentials for the API Calls
Obtain `Portal Name`, `Integration Key` and `Integration Key Password` under `Settings` > `General Settings` on the PayFabric Receivables Management Portal. These credentials will be used to authenticate with the Sync api.  

##### Step 2: Make an API Call to Generate the Security Token
API Endpoint: `https://{PayFabric URL}/receivables/sync/api/{PortalName}/api/token`  

Replace the following variables from the endpoint URL:

  * `{PayFabric URL}`:
    * Production: `www.payfabric.com`
    * Sandbox: `sandbox.payfabric.com`
  * `{PortalName}`:  Use the `Portal Name` obtain from Step 1.  

Make a Form Post API call to the endpoint with the following parameters:

  * `grant_type=password` - This is used to specify the authentication type
  * `client_id=ePay_Sync` - This is used to specify the type of user to be authenticated
  * `username={username}` - Replace `{username}` with the `Integration Key` from the previous step
  * `password={password}` - Replace `{password}` with the `Integration Key Password` from the previous step

Example:  
```shell
curl -X POST \
  http://sandbox.payfabric.com/receivables/sync/api/nodus/api/token \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -d 'grant_type=password&client_id=ePay_Sync&username=nodus&password=password1'
```
If the HTTP Status Code is 200 - OK, you will receive the following JSON response:

<pre>
{
    "access_token": "ID8W9GrqnSSsZZz6yW0kvXEF3ZDSgyo8ew9CYKfGWQjuluftkZys8j2bBO4n-zF15zN9-ObwO4nrbFwnm96oTNomc4x1hiwxA1ZldOjCrBAM8hVxc7NWvQETw6dvl8NX-VP2l2FAQoiG9ybQ1pcG9lIX6Y_gZqcoqI9fTmZdHXb8BL8LyW_vkfJU9AA4Oz5CdO7dhgD-RwaL13tH88F1N1qhuan7rHSR6D3622k1H6MhrnDcBssrixM9IIy0otYDkd4N8mX5hRYsvYrSK3kVgQ",
    "token_type": "bearer",
    "expires_in": 8639999,
    "as:client_id": "ePay_Sync",
    "userName": "nodus",
    ".issued": "Wed, 30 May 2018 20:31:38 GMT",
    ".expires": "Fri, 07 Sep 2018 20:31:38 GMT"
}
</pre>

##### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```shell
curl -X GET \
  http://sandbox.payfabric.com/receivables/sync/api/nodus/api/currencies/USD \
  -H 'Authorization: Bearer AIGMzQN2jvAeFtbPt9J0zNNMWQ46Knl5jReIMXp7vAh0JHmbUBxXUrk-s_LwgFM4cLcnXVGYAtCTKlyUeCRQn2xcXIvSRBJSECu6STRrScuxTDJh0j7u_fZNo_f60xku0mqesN5GW14iSNDVHpic2dxAp_oXsMnq977UxKS2dl-slvuRl5q7wdsRq_SZxQzb7JTS4C5MF_WgPFHN56UnKljpSTyyzgsh8qeIaE85tqZWv1KJaHsaBVxGFODY1YQjSwPeM3BVlTik5l2RPiv747fPVotZKcAZ8rGYomkEEjUwdgj3hjHvktORb41rzorXm__BDx-EOCnHD72F7e6nYzj690Jn148b4MHu0k7l1oyA-QssjTbNUlFWieA700C2ujR6bpZtVdP3zrDzudN7Nw' \
```
