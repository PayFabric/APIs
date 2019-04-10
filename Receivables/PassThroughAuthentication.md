PayFabric Receivables Pass-Through Authentication
============================

### Overview  
The PayFabric Receivables Pass-Through Authentication feature allows for users to be authenticated into the PayFabric Receivables Customer Portal without having to provide additional credentials. This procedure typically is used when the organization has an existing portal or application where the users would like to utilize the functionality of the PayFabric Receivables Customer Portal without requiring users to log in twice.  


### Usage  

##### Step 1: Obtain Credentials for the API Calls
From the PayFabric Receivables Management portal, navigate to the `Integration` section of the `General Settings` tab of the `Settings` page and take note the following values. These credentials will be used to authenticate with the API and should not be exposed within the integrating application. 

* `Portal Name`
* `Integration Key`
* `Integration Key Password`

##### Step 2: Generate the Authorization Code
The Authorization Code is the value the user will need in order to access the PayFabric Receivables Customer Portal. To generate the Authorization Code, use the following procedure:

1. Replace the variables in the below endpoint URL.

API Endpoint: `https://{PayFabric URL}/receivablesapi/{PortalName}/api/authorize?user_name={User Name}&client_id=ePay_Customer_Portal&response_type=code&customer_id={CustomerID}&scope=passthrough&redirect_uri=https://{PayFabric URL}/receivablesapi/{Portal Name}/api/authcode`

  * `{PayFabric URL}` - URL of the production or sandbox PayFabric environment. 
    * Production URL: `www.payfabric.com`
    * Sandbox URL: `sandbox.payfabric.com`
  * `{PortalName}` -  Use the `Portal Name` obtained from Step 1.  
  * `{User Name}` - Name of the user being passed 
  * `{CustomerID}` - Customer ID of the customer account the user should be viewing

2. Once the API Endpoint is prepared, make a POST API call to the API EndPoint with the Integration Key and Integration Key Password.

Example:  
```shell
curl -X POST \
  'https://sandbox.payfabric.com/receivablesapi/nodus/api/authorize?user_name=Passthrough_User&client_id=ePay_Customer_Portal&response_type=code&customer_id=CUSTOMER1234&scope=passthrough&redirect_uri=https://sandbox.payfabric.com/receivablesapi/MyPortalName/api/authcode' \
  -H 'Content-Type: application/json' \
  -d '{
    "integration_key": "PortalName_Abcd123",
    "integration_password": "ABCDEFGH1234567"
	}'
```
If the HTTP Status Code is 200 - OK, you will receive the following **string** response containing the Authorization Code.

<pre>
"12345678-1234-1234-1234-12345678abcd"
</pre>

##### Step 3: Direct the User to the Customer Portal
Replace the `{PayFabric URL}` and `{PortalName}`, and `{AuthCode}` values in the below URL with the respective values. 

`https://{PayFabric URL}/customerportal/{PortalName}/passthrough?accesscode={authCode}`

Example:  
```
https://sandbox.payfabric.com/customerportal/MyPortalName/passthrough?accesscode=12345678-1234-1234-1234-12345678abcd
```

Once the URL is prepared, direct the user to the URL to allow the user to pass through the authentication and land on the main page of the PayFabric Receivables Customer Portal as if the user logged in. 
