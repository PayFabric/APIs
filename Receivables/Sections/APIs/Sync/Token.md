PayFabric Receivables Sync API Authentication
============================
Clients will create a security token by making an API call. The security token can then be used to authenticate with the PayFabric Receivables Sync API. It is recommended to use the same API token for all Sync API calls for ease of use. However, the token will expire after 100 days and a new token will be needed.

#### Step 1: Obtain Credentials for the API Calls
From the PayFabric Receivables Management portal, navigate to the `Settings` page to get the below values. These credentials will be used to authenticate with the API and should not be exposed within the integrating application. 

* `Portal Name` - `Company` section > `Information` tab
* `Integration Key` - `Integration` section > `Security` tab
* `Integration Key Password` - `Integration` section > `Security` tab

#### Step 2: Make an API Call to Generate the Security Token
API Endpoint: `https://{PayFabric URL}/receivables/sync/api/{PortalName}/api/token`  

Replace the following variables from the endpoint URL:

  * `{PayFabric URL}`:
    * Production: `www.payfabric.com`
    * Sandbox: `sandbox.payfabric.com`
  * `{PortalName}`:  Use the `Portal Name` obtain from Step 1.  

Make a Form-UrlEncoded Post API call to the endpoint with the following parameters in the body:

  * `grant_type=password` - This is used to specify the authentication type
  * `username={username}` - Replace `{username}` with the `Integration Key` from the previous step
  * `password={password}` - Replace `{password}` with the `Integration Key Password` from the previous step

Example:  
```ps1
curl --location --request POST 'https://sandbox.payfabric.com/receivables/sync/api/nodus/api/token' `
--header 'Content-Type: application/x-www-form-urlencoded' `
--data-urlencode 'grant_type=password' `
--data-urlencode 'username=PortalName_Abcd123' `
--data-urlencode 'password=ABCDEFGH1234567'
```

If the HTTP Status Code is 200 - OK, you will receive the following JSON response:

```json
{
    "access_token": "d6cVt15i-O7uG1EO5lXqO1MHmgpE7dL791caYVAuPWioSlLj4Jct5u6oFteRl7rkqVt8ZBsQSyMITyNqQFKQs9YB0aokEUn2F5wqyCtxyVwcyCxbW9PxJVKSMzo1T2CVjYbVqQAU_ws3BcIEdCxCmolufKU0Gm9KLCHWQMAhP5Yv9ns0LlJLNyD1dDSpYVQ3A7zOwQNq05HNR3UesQKK5fNb3aek8qe6Qdm61_jLsIdtxp35do5txe82sKhtlx6KUQubuw_a1dUm_Ncvk0IeHzGq8st",
    "token_type": "bearer",
    "expires_in": 8553602,
    "refresh_token": null
}
```

#### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```ps1
curl --location --request GET "https://sandbox.payfabric.com/receivables/sync/api/nodus/api/currencies/USD" `
--header "Content-Type: application/json" `
--header "Authorization: Bearer d6cVt15i-O7uG1EO5lXqO1MHmgpE7dL791caYVAuPWioSlLj4Jct5u6oFteRl7rkqVt8ZBsQSyMITyNqQFKQs9YB0aokEUn2F5wqyCtxyVwcyCxbW9PxJVKSMzo1T2CVjYbVqQAU_ws3BcIEdCxCmolufKU0Gm9KLCHWQMAhP5Yv9ns0LlJLNyD1dDSpYVQ3A7zOwQNq05HNR3UesQKK5fNb3aek8qe6Qdm61_jLsIdtxp35do5txe82sKhtlx6KUQubuw_a1dUm_Ncvk0IeHzGq8st"
```
