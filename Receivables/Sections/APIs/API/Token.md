PayFabric Receivables API Authentication
============================
Clients will create a security token by making an API call. The security token can then be used to authenticate with the PayFabric Receivables API. It is recommended to request a token for every API call to avoid any connection issue. However, the token will be valid for 10 minutes. All API calls made within that 10 minute timeframe can use the same token. Once it hits the 10 minute mark, it will become invalid and a new token will be needed.

#### Step 1: Create / Get the User to be Used for the API Calls
In the PayFabric Receivables Management Portal you will be able to create additional users that can be used for testing purposes. Otherwise, this requires the customer user's actual username and password. If the need to call the Customer Portal APIs without using the customer user's actual username and password is necessary, please see the [Token Impersonate Guide](TokenImpersonate.md)

#### Step 2: Make an API Call to Generate the Security Token
API Endpoint: `https://{PayFabric URL}/customerportal/api/{PortalName}/api/token`  

Replace the following variables from the endpoint URL:

  * `{PayFabric URL}`:
    * Production: `www.payfabric.com`
    * Sandbox: `sandbox.payfabric.com`
  * `{PortalName}`:  Use the `Portal Name` obtain from Step 1.  

Make a Form Post API call to the endpoint with the following parameters:

  * `grant_type=password` - This is used to specify the authentication type
  * `username={username}` - Replace `{username}` with the user's username
  * `password={password}` - Replace `{password}` with the user's password

```shell
curl --location --request POST 'https://sandbox.payfabric.com/customerportal/api/nodus/api/token' `
--header 'Content-Type: application/x-www-form-urlencoded' `
--data-urlencode 'grant_type=password' `
--data-urlencode 'username=Nodus0001_User' `
--data-urlencode 'password=ABCDEFGH1234567' `
```
If the HTTP Status Code is 200 - OK, you will receive the following JSON response:

```json
{
    "access_token": "d6cVt15i-O7uG1EO5lXqO1MHmgpE7dL791caYVAuPWioSlLj4Jct5u6oFteRl7rkqVt8ZBsQSyMITyNqQFKQs9YB0aokEUn2F5wqyCtxyVwcyCxbW9PxJVKSMzo1T2CVjYbVqQAU_ws3BcIEdCxCmolufKU0Gm9KLCHWQMAhP5Yv9ns0LlJLNyD1dDSpYVQ3A7zOwQNq05HNR3UesQKK5fNb3aek8qe6Qdm61_jLsIdtxp35do5txe82sKhtlx6KUQubuw_a1dUm_Ncvk0IeHzGq8st",
    "token_type": "bearer",
    "expires_in": 901,
    "refresh_token": "df011c2b8c174fec98cc32599988f549"
}
```

#### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```ps1
curl --location --request GET 'https://sandbox.payfabric.com/customerportal/api/nodus/api/customers/current' `
--header 'Authorization: Bearer d6cVt15i-O7uG1EO5lXqO1MHmgpE7dL791caYVAuPWioSlLj4Jct5u6oFteRl7rkqVt8ZBsQSyMITyNqQFKQs9YB0aokEUn2F5wqyCtxyVwcyCxbW9PxJVKSMzo1T2CVjYbVqQAU_ws3BcIEdCxCmolufKU0Gm9KLCHWQMAhP5Yv9ns0LlJLNyD1dDSpYVQ3A7zOwQNq05HNR3UesQKK5fNb3aek8qe6Qdm61_jLsIdtxp35do5txe82sKhtlx6KUQubuw_a1dUm_Ncvk0IeHzGq8st'
```
