Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used for returning customer created wallet records, creating new wallet records, locking, updating, and deleting existing wallet records.  Please note that all requests require API authentication, see our [guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Authentication.md) on how to authenticate.

Get Credit Card / eCheck
------------------------

* `GET /rest/api/wallet/get/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will return the specified credit card or eCheck

<pre>
{
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

Get Credit Cards or eChecks
--------------------------

* `GET /rest/api/wallet/get/John+Doe+Ltd?tender=CreditCard` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_)

<pre>[
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
]</pre>

Get Credit Cards or eChecks (Query with Paging)
-----------------------------------------------

* `GET /rest/api/wallet/get?customer=John+Doe+Ltd&tender=CreditCard&fromdate=01-01-2015&page=1` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_) after the specified date

<pre>{
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
}</pre>

Lock Credit Card / eCheck
-------------------------

* `GET /rest/api/wallet/lock/cbb571ea-e834-41c4-8a20-7d55bb7ae190?lockreason=Customer+being+audited` will lock the credit card or eCheck from being used with a specified reason

<pre>{
	"Result": "True"
}</pre>

Unlock Credit Card / eCheck
---------------------------

* `GET /rest/api/wallet/unlock/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will unlock the credit card or eCheck from being used

<pre>{
  "Result": "True"
}</pre>

Delete Credit Card / eCheck
---------------------------

* `GET /rest/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will delete the credit card or eCheck

<pre>{
	"Result": "True"
}</pre>

Create Credit Card
------------------

* `POST /rest/api/wallet/create` will create a new credit card with the following JSON payload:

<pre>{
	<b>"Account"</b>: "XXXXXXXXXXXX1115",
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
		<b>"FirstName"</b>: "John",
		<b>"LastName"</b>: "Doe",
		"MiddleName": "",
		"SSN": ""
	},
	<b>"Customer"</b>: "John Doe Ltd",
	<b>"ExpDate"</b>: "0918",
	"GPAddressCode": "",
	"GatewayToken": "",
	"Identifier": "",
	"IsDefaultCard": false,
	"IssueNumber": "",
	<b>"Tender"</b>: "CreditCard",
	"UserDefine1": "",
	"UserDefine2": "",
	"UserDefine3": "",
	"UserDefine4": ""
}</pre>

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields please see our [wiki page](https://github.com/PayFabric/APIs/wiki/API-Object-V2#card).

<pre>{
  "Message": null,
  "Result": "ccfbf703-0fff-4e28-845e-3c5c5092f857"
}</pre>

Create eCheck
-------------

* `POST /rest/api/wallet/create` will create a new eCheck with the following JSON payload:

<pre>{
	<b>"Account"</b>: "1111111111111111",
	<b>"Aba"</b>: "123",
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
		<b>"FirstName"</b>: "John",
		<b>"LastName"</b>: "Doe",
		"MiddleName": "",
		"SSN": ""
	},
	<b>"Customer"</b>: "John Doe Ltd",
	"GPAddressCode": "",
	"GatewayToken": "",
	"Identifier": "",
	"IsDefaultCard": false,
	"IssueNumber": "",
	<b>"Tender"</b>: "ECheck",
	"UserDefine1": "",
	"UserDefine2": "",
	"UserDefine3": "",
	"UserDefine4": ""
}</pre>

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields please see our [wiki page](https://github.com/PayFabric/APIs/wiki/API-Object-V2#card).

<pre>{
  "Message": null,
  "Result": "6ae8448f-de67-4f71-89f9-07bb77621cc7"
}</pre>

Update Credit Card / eCheck
---------------------------

* `POST /rest/api/wallet/update` will update a credit card or eCheck with new information based on the request JSON payload

<pre>{
	"ID" : "4ea31dda-4efb-4ed5-8f35-dbcc6b16017d"
}</pre>

Please note that the **ID** field is the only required field for an update.  Only the fields that need updating should be included, see the **Create Credit Card / eCheck** endpoint for more information.

<pre>{
  "Result": "True"
}</pre>
