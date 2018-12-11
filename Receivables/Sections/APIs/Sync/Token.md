PayFabric Receivables API Authentication
============================
Clients will always need to create a security token to authenticate with the PayFabric Receivables API. It is recommended to request a token for every API call to avoid any connection issue. However, the token will be valid for 100 days. All API calls made within that 100 day timeframe can use the same token. Once it hits the 100 day mark, it will become invalid and a new token will be needed.

##### Step 1: Create / Get the User to be Used for the API Calls
In the PayFabric Receivables Management Portal you will be able to create additional users

##### Step 2: Generate the Security Token
In the body add in the username and password created

```shell
curl -X POST \
  http://sandbox.payfabric.com/sync/nodus/api/token \
  -H 'Content-Type: application/x-www-form-urlencoded' \
  -d 'grant_type=password&client_id=ePay_Sync&username=nodus&password=password1'
```
If the HTTP Status Code is 200 - OK, you will receive the following **JSON** response:

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
  http://sandbox.payfabric.com/sync/nodus/api/customers \
  -H 'Authorization: Bearer AIGMzQN2jvAeFtbPt9J0zNNMWQ46Knl5jReIMXp7vAh0JHmbUBxXUrk-s_LwgFM4cLcnXVGYAtCTKlyUeCRQn2xcXIvSRBJSECu6STRrScuxTDJh0j7u_fZNo_f60xku0mqesN5GW14iSNDVHpic2dxAp_oXsMnq977UxKS2dl-slvuRl5q7wdsRq_SZxQzb7JTS4C5MF_WgPFHN56UnKljpSTyyzgsh8qeIaE85tqZWv1KJaHsaBVxGFODY1YQjSwPeM3BVlTik5l2RPiv747fPVotZKcAZ8rGYomkEEjUwdgj3hjHvktORb41rzorXm__BDx-EOCnHD72F7e6nYzj690Jn148b4MHu0k7l1oyA-QssjTbNUlFWieA700C2ujR6bpZtVdP3zrDzudN7Nw' \
```
