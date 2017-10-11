Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used for returning customer created wallet records, creating new wallet records, locking, updating, and deleting existing wallet records.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.


Create a Credit Card
--------------------

* `POST /rest/api/wallet/create` will create a new credit card with the following JSON payload:

###### Request
<pre>
{
  <b>"Account": "4111111111111111"</b>,
  "Billto": {
    "City": "Anaheim",
    "Country": "USA",
    "Email": "",
    "Line1": "123 PayFabric Way",
    "Line2": "",
    "Line3": "",
    "Phone": "(123)456-7890",
    "State": "CA",
    "Zip": "92806"
  },
  <b>"CardHolder"</b>: {
    "DriverLicense": "",
    <b>"FirstName": "John"</b>,
    <b>"LastName": "Doe"</b>,
    "MiddleName": "",
    "SSN": ""
  },
  <b>"Customer": "John Doe Ltd"</b>,
  <b>"ExpDate": "0918"</b>,
  "GPAddressCode": "",
  "GatewayToken": "",
  "Identifier": "",
  "IsDefaultCard": false,
  "IssueNumber": "",
  <b>"Tender": "CreditCard"</b>,
  "UserDefine1": "",
  "UserDefine2": "",
  "UserDefine3": "",
  "UserDefine4": ""
}
</pre>

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields, click [here](Objects#card).

###### Response
<pre>
{
  "Message": null,
  "Result": "ccfbf703-0fff-4e28-845e-3c5c5092f857"
}
</pre>

Create an eCheck
----------------

* `POST /rest/api/wallet/create` will create a new eCheck with the following JSON payload:

###### Request
<pre>
{
  <b>"Account": "1111111111111111"</b>,
  <b>"Aba": "123"</b>,
  "AccountType" : "",
  "Billto": {
    "City": "Anaheim",
    "Country": "USA",
    "Email": "",
    "Line1": "123 PayFabric Way",
    "Line2": "",
    "Line3": "",
    "Phone": "(123)456-7890",
    "State": "CA",
    "Zip": "92806"
  },
  <b>"CardHolder"</b>: {
    "DriverLicense": "",
    <b>"FirstName": "John"</b>,
    <b>"LastName": "Doe"</b>,
    "MiddleName": "",
    "SSN": ""
  },
  <b>"Customer": "John Doe Ltd"</b>,
  "GPAddressCode": "",
  "GatewayToken": "",
  "Identifier": "",
  "IsDefaultCard": false,
  "IssueNumber": "",
  <b>"Tender": "ECheck"</b>,
  "UserDefine1": "",
  "UserDefine2": "",
  "UserDefine3": "",
  "UserDefine4": ""
}
</pre>

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields, click [here](Objects#card).

###### Response
<pre>
{
  "Message": null,
  "Result": "6ae8448f-de67-4f71-89f9-07bb77621cc7"
}
</pre>

Update a Credit Card / eCheck
-----------------------------

* `POST /rest/api/wallet/update` will update a credit card or eCheck with new information based on the request JSON payload

###### Request
<pre>
{
  "ID" : "4ea31dda-4efb-4ed5-8f35-dbcc6b16017d"
}
</pre>

Please note that the **ID** field is the only required field for an update.  Only the fields that need updating should be included, see the **Create Credit Card / eCheck** endpoint for more information.  When updating a Wallet entry, do **not** include the **Account** field.  PayFabric is unable to update the account/card number. To update an account/card number, delete the old Wallet entry and create a new one.

###### Response
<pre>
{
  "Result": "True"
}
</pre>


Retrieve a Credit Card / eCheck
-------------------------------

* `GET /rest/api/wallet/get/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will return the specified credit card or eCheck

Credit card and account numbers are returned in a masked format. PayFabric never returns credit card or account numbers in plaintext.

###### Response
<pre>
{
  "Aba": "",
  "Account": "XXXXXXXXXXXX1115",
  "AccountType": "",
  "Billto": {
    "City": "Anaheim",
    "Country": "USA",
    "Customer": "",
    "Email": "",
    "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
    "Line1": "123 PayFabric Way",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "1/1/0001 12:00:00 AM",
    "Phone": "(123)456-7890",
    "State": "CA",
    "Zip": "92806"
  },
  "CardHolder": {
    "DriverLicense": "",
    "FirstName": "John",
    "LastName": "Doe",
    "MiddleName": "",
    "SSN": ""
  },
  "CardName": "Visa",
  "CheckNumber": null,
  "Connector": "",
  "Customer": "John Doe Ltd",
  "ExpDate": "0918",
  "GPAddressCode": "",
  "GatewayToken": "",
  "ID": "cbb571ea-e834-41c4-8a20-7d55bb7ae190",
  "Identifier": "",
  "IsDefaultCard": false,
  "IsLocked": false,
  "IsSaveCard": false,
  "IssueNumber": "",
  "ModifiedOn": "10/2/2015 3:40:41 PM",
  "StartDate": "",
  "Tender": "CreditCard",
  "UserDefine1": "",
  "UserDefine2": "",
  "UserDefine3": "",
  "UserDefine4": ""
}
</pre>


Retrieve Credit Cards / eChecks
-------------------------------

* `GET /rest/api/wallet/get/John+Doe+Ltd?tender=CreditCard` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_)

Credit card and account numbers are returned in a masked format. PayFabric never returns credit card or account numbers in plaintext.

###### Response
<pre>
[
  {
    "Aba": "",
    "Account": "XXXXXXXXXXXX1115",
    "AccountType": "",
    "Billto": {
      "City": "Anaheim",
      "Country": "USA",
      "Customer": "",
      "Email": "",
      "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "1/1/0001 12:00:00 AM",
      "Phone": "(123)456-7890",
      "State": "CA",
      "Zip": "92806"
    },
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "John",
      "LastName": "Doe",
      "MiddleName": "",
      "SSN": ""
    },
    "CardName": "Visa",
    "CheckNumber": null,
    "Connector": "",
    "Customer": "John Doe Ltd",
    "ExpDate": "0918",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "cbb571ea-e834-41c4-8a20-7d55bb7ae190",
    "Identifier": "",
    "IsDefaultCard": false,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "ModifiedOn": "10/2/2015 3:40:41 PM",
    "StartDate": "",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  },
  {
    "Aba": "",
    "Account": "XXXXXXXXXXXX1115",
    "AccountType": "",
    "Billto": {
      "City": "Anaheim",
      "Country": "USA",
      "Customer": "",
      "Email": "",
      "ID": "4ca94c49-9724-492e-b20e-b11d53a1111b",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "1/1/0001 12:00:00 AM",
      "Phone": "(123)456-7890",
      "State": "CA",
      "Zip": "92806"
    },
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "John",
      "LastName": "Doe",
      "MiddleName": "",
      "SSN": ""
    },
    "CardName": "Visa",
    "CheckNumber": null,
    "Connector": "",
    "Customer": "John Doe Ltd",
    "ExpDate": "0918",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "cbb571ea-e834-41c4-8a20-7d55bb711111",
    "Identifier": "",
    "IsDefaultCard": false,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "ModifiedOn": "10/2/2015 3:40:41 PM",
    "StartDate": "",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  }
]
</pre>

Retrieve Credit Cards / eChecks (Query with Paging)
-----------------------------------------------

* `GET /rest/api/wallet/get?customer=John+Doe+Ltd&tender=CreditCard&fromdate=01-01-2015&page=1` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_) after the specified date

Credit card and account numbers are returned in a masked format. PayFabric never returns credit card or account numbers in plaintext.

###### Response
<pre>
{
  "Paging": {
    "Current": "1",
    "Size": "15",
    "TotalPages": "1",
    "TotalRecords": "2"
  },
  "Records": 
  [
    {
      "Aba": "",
      "Account": "XXXXXXXXXXXX1115",
      "AccountType": "",
      "Billto": {
        "City": "Anaheim",
        "Country": "USA",
        "Customer": "",
        "Email": "",
        "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
        "Line1": "123 PayFabric Way",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "(123)456-7890",
        "State": "CA",
        "Zip": "92806"
      },
      "CardHolder": {
        "DriverLicense": "",
        "FirstName": "John",
        "LastName": "Doe",
        "MiddleName": "",
        "SSN": ""
      },
      "CardName": "Visa",
      "CheckNumber": null,
      "Connector": "",
      "Customer": "John Doe Ltd",
      "ExpDate": "0918",
      "GPAddressCode": "",
      "GatewayToken": "",
      "ID": "cbb571ea-e834-41c4-8a20-7d55bb7ae190",
      "Identifier": "",
      "IsDefaultCard": false,
      "IsLocked": false,
      "IsSaveCard": false,
      "IssueNumber": "",
      "ModifiedOn": "10/2/2015 3:40:41 PM",
      "StartDate": "",
      "Tender": "CreditCard",
      "UserDefine1": "",
      "UserDefine2": "",
      "UserDefine3": "",
      "UserDefine4": ""
    },
    {
      "Aba": "",
      "Account": "XXXXXXXXXXXX1115",
      "AccountType": "",
      "Billto": {
        "City": "Anaheim",
        "Country": "USA",
        "Customer": "",
        "Email": "",
        "ID": "4ca94c49-9724-492e-b20e-b11d53a1111b",
        "Line1": "123 PayFabric Way",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "(123)456-7890",
        "State": "CA",
        "Zip": "92806"
      },
      "CardHolder": {
        "DriverLicense": "",
        "FirstName": "John",
        "LastName": "Doe",
        "MiddleName": "",
        "SSN": ""
      },
      "CardName": "Visa",
      "CheckNumber": null,
      "Connector": "",
      "Customer": "John Doe Ltd",
      "ExpDate": "0918",
      "GPAddressCode": "",
      "GatewayToken": "",
      "ID": "cbb571ea-e834-41c4-8a20-7d55bb711111",
      "Identifier": "",
      "IsDefaultCard": false,
      "IsLocked": false,
      "IsSaveCard": false,
      "IssueNumber": "",
      "ModifiedOn": "10/2/2015 3:40:41 PM",
      "StartDate": "",
      "Tender": "CreditCard",
      "UserDefine1": "",
      "UserDefine2": "",
      "UserDefine3": "",
      "UserDefine4": ""
    }
  ]
}
</pre>


Lock Credit Card / eCheck
-------------------------

* `GET /rest/api/wallet/lock/cbb571ea-e834-41c4-8a20-7d55bb7ae190?lockreason=Customer+being+audited` will lock the credit card or eCheck from being used with a specified reason

###### Response
<pre>{
  "Result": "True"
}</pre>


Unlock Credit Card / eCheck
---------------------------

* `GET /rest/api/wallet/unlock/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will unlock the credit card or eCheck from being used

###### Response
<pre>{
  "Result": "True"
}</pre>


Remove Credit Card / eCheck
---------------------------

* `GET /rest/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will remove the credit card or eCheck

###### Response
<pre>{
  "Result": "True"
}</pre>
