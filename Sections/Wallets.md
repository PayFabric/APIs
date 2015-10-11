Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used for returning customer created wallet records, creating new wallet records, locking, updating, and deleting existing wallet records.  Please note that all requests require API authentication, see our [guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Authentication.md) on how to authenticate.

Get Credit Card / eCheck
------------------------

* `GET /rest/api/wallet/get/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will return the specified credit card or eCheck

```json
{
  "Aba": "",
  "Account": "XXXXXXXXXXXX1115",
  "AccountType": "",
  "Billto": {
    "City": "Auckland",
    "Country": "New Zealand",
    "Customer": "",
    "Email": "",
    "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
    "Line1": "1 Chieftain Rise",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "1/1/0001 12:00:00 AM",
    "Phone": "",
    "State": "",
    "Zip": "2105"
  },
  "CardHolder": {
    "DriverLicense": "",
    "FirstName": "Shaun",
    "LastName": "Sharples",
    "MiddleName": "",
    "SSN": ""
  },
  "CardName": "Visa",
  "CheckNumber": null,
  "Connector": "",
  "Customer": "AARONFIT0001",
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
```

Get Credit Cards or eChecks
--------------------------

* `GET /rest/api/wallet/get/CUST0001?tender=CreditCard` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_)

```json
[
  {
    "Aba": "",
    "Account": "XXXXXXXXXXXX1115",
    "AccountType": "",
    "Billto": {
      "City": "Auckland",
      "Country": "New Zealand",
      "Customer": "",
      "Email": "",
      "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
      "Line1": "1 Chieftain Rise",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "1/1/0001 12:00:00 AM",
      "Phone": "",
      "State": "",
      "Zip": "2105"
    },
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "Shaun",
      "LastName": "Sharples",
      "MiddleName": "",
      "SSN": ""
    },
    "CardName": "Visa",
    "CheckNumber": null,
    "Connector": "",
    "Customer": "AARONFIT0001",
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
    "Account": "XXXXXXXXXXXX1114",
    "AccountType": "",
    "Billto": {
      "City": "Auckland",
      "Country": "New Zealand",
      "Customer": "",
      "Email": "",
      "ID": "940b7e6a-a135-4b54-97c9-e79698bdc31b",
      "Line1": "1 Chieftain Rise",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "1/1/0001 12:00:00 AM",
      "Phone": "",
      "State": "",
      "Zip": "2105"
    },
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "Shaun",
      "LastName": "Sharples",
      "MiddleName": "",
      "SSN": ""
    },
    "CardName": "Visa",
    "CheckNumber": null,
    "Connector": "",
    "Customer": "AARONFIT0001",
    "ExpDate": "0918",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "88ecfcb3-5936-400e-aefb-91c8258f633a",
    "Identifier": "",
    "IsDefaultCard": false,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "ModifiedOn": "10/1/2015 3:09:16 PM",
    "StartDate": "",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  }
]
```

Get Credit Cards or eChecks (Query with Paging)
-----------------------------------------------

* `GET /rest/api/wallet/get?customer=AARONFIT0001&tender=CreditCard&fromdate=01-01-2015&page=1` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_) after the specified date

```json
{
  "Paging": {
    "Current": "1",
    "Size": "15",
    "TotalPages": "1",
    "TotalRecords": "5"
  },
  "Records": 
  [
    {
      "Aba": "",
      "Account": "XXXXXXXXXXXX1115",
      "AccountType": "",
      "Billto": {
        "City": "Auckland",
        "Country": "New Zealand",
        "Customer": "",
        "Email": "",
        "ID": "4ca94c49-9724-492e-b20e-b11d53a8166b",
        "Line1": "1 Chieftain Rise",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "",
        "State": "",
        "Zip": "2105"
      },
      "CardHolder": {
        "DriverLicense": "",
        "FirstName": "Shaun",
        "LastName": "Sharples",
        "MiddleName": "",
        "SSN": ""
      },
      "CardName": "Visa",
      "CheckNumber": null,
      "Connector": "",
      "Customer": "AARONFIT0001",
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
      "Account": "XXXXXXXXXXXX1114",
      "AccountType": "",
      "Billto": {
        "City": "Auckland",
        "Country": "New Zealand",
        "Customer": "",
        "Email": "",
        "ID": "940b7e6a-a135-4b54-97c9-e79698bdc31b",
        "Line1": "1 Chieftain Rise",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "",
        "State": "",
        "Zip": "2105"
      },
      "CardHolder": {
        "DriverLicense": "",
        "FirstName": "Shaun",
        "LastName": "Sharples",
        "MiddleName": "",
        "SSN": ""
      },
      "CardName": "Visa",
      "CheckNumber": null,
      "Connector": "",
      "Customer": "AARONFIT0001",
      "ExpDate": "0918",
      "GPAddressCode": "",
      "GatewayToken": "",
      "ID": "88ecfcb3-5936-400e-aefb-91c8258f633a",
      "Identifier": "",
      "IsDefaultCard": false,
      "IsLocked": false,
      "IsSaveCard": false,
      "IssueNumber": "",
      "ModifiedOn": "10/1/2015 3:09:16 PM",
      "StartDate": "",
      "Tender": "CreditCard",
      "UserDefine1": "",
      "UserDefine2": "",
      "UserDefine3": "",
      "UserDefine4": ""
    }
  ]
}
```

Get Expired Credit Cards (Query with Paging)
--------------------------------------------

* ``

```json
```

Lock Credit Card / eCheck
-------------------------

* ``

```json
```

Unlock Credit Card / eCheck
---------------------------

* ``

```json
```

Delete Credit Card / eCheck
---------------------------

* ``

```json
```

Create Credit Card / eCheck
---------------------------

* ``

```json
```

Update Credit Card / eCheck
---------------------------

* ``

```json
```
