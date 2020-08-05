PayFabric Receivables API Authentication for Impersonation
============================
Clients will create a security token by making an API call. The security token can then be used to authenticate with the PayFabric Receivables API. It is recommended to request a token for every API call to avoid any connection issue. However, the token will be valid for 10 minutes. All API calls made within that 10 minute timeframe can use the same token. Once it hits the 10 minute mark, it will become invalid and a new token will be needed.

##### Step 1: Obtain Credentials for the API Calls  
Obtain `Portal Name`, `Integration Key` and `Integration Key Password` under `Settings` > `General Settings` on the PayFabric Receivables Management Portal. These credentials will be used to authenticate with the Sync api.  

##### Step 2: Make an API Call to Generate the Security Token
API Endpoint: `https://{PayFabric URL}/customerportal/api/{PortalName}/api/token`  

Replace the following variables from the endpoint URL:

  * `{PayFabric URL}`:
    * Production: `www.payfabric.com`
    * Sandbox: `sandbox.payfabric.com`
  * `{PortalName}`:  Use the `Portal Name` obtain from Step 1.  

Make a Form Post API call to the endpoint with the following parameters:

  * `grant_type=password` - This is used to specify the authentication type
  * `client_id=ePay_Customer_Portal` - This is used to specify the type of user to be authenticated
  * `username={username}` - Replace `{username}` with the Integration Key
  * `password={password}` - Replace `{password}` with the Integration Password
  * `customer_id={customer_id}` - Replace `{customer_id}` with the customer to impersonate
  * `impersonate_user={impersonate_user}` - Replace `{impersonate_user}` with a username to be used for the user (Ex: use the same as customer_id)

```shell
curl -X POST \
  http://sandbox.payfabric.com/customerportal/api/nodus/api/token \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -d 'grant_type=password&client_id=ePay_Customer_Portal&username=Nodus0001&password=password1&customer_id=aaronfit0001&impersonate_user=aaronfit0001'
```
If the HTTP Status Code is 200 - OK, you will receive the following JSON response:

<pre>
{
  "access_token": "jTylQbHrEe1e79yAPoL5iaP7Nqh9CXK9pwdRdOjOJkNG7Cpl2F03AfI6ftmGxZ5DSeAyT5J6Opx7Y1jexDV0cJroVkQh35kzUOATZlem2tyNIN24qeDLscMuKp2X1JaPOCiSGNkgkDmhb00kSr27vBqG-nYXvHniAoE2QKttPyHIXHv3umHOPNiWSzLB2oQq9KpiwQt9L7UHF4QVVdkMLFTkW3UMEBp6J7nJ0MT6uMI2j4End4WbhACKBhlGp2qBN4RuvPclZG1FKaPS1AohrYFDlt-Te0qQsNO6G9ssVPwl4btdSwGRg28KDwzeGAdlXiUATn_5gUodSCOQ70E8s21XMF3Xq2NZgDXM-xdy-045zDL6C_U-0plG2FzqtndGCuz4C-xgIG7ENsKzo460s0owITGK8omWS5XhR_of9I3FzZ4xpbPGlLVlpM_4Rvdg_pW_2w",
  "token_type": "bearer",
  "expires_in": 899,
  "refresh_token": "c241f45a48314560beef46e0f836c0a6"
}
</pre>

##### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```shell
curl -X GET \
  http://sandbox.payfabric.com/customerportal/api/nodus/api/customers \
  -H 'Authorization: Bearer AIGMzQN2jvAeFtbPt9J0zNNMWQ46Knl5jReIMXp7vAh0JHmbUBxXUrk-s_LwgFM4cLcnXVGYAtCTKlyUeCRQn2xcXIvSRBJSECu6STRrScuxTDJh0j7u_fZNo_f60xku0mqesN5GW14iSNDVHpic2dxAp_oXsMnq977UxKS2dl-slvuRl5q7wdsRq_SZxQzb7JTS4C5MF_WgPFHN56UnKljpSTyyzgsh8qeIaE85tqZWv1KJaHsaBVxGFODY1YQjSwPeM3BVlTik5l2RPiv747fPVotZKcAZ8rGYomkEEjUwdgj3hjHvktORb41rzorXm__BDx-EOCnHD72F7e6nYzj690Jn148b4MHu0k7l1oyA-QssjTbNUlFWieA700C2ujR6bpZtVdP3zrDzudN7Nw' \
```
