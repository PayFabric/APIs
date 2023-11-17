Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used to manage customer wallet records. Each credit card or bank account is saved as as wallet record, and its ownership tied to `Customer`.

Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Credit Card
--------------------

Create a new credit card wallet record.

### Endpoint
<kbd><kbd>POST</kbd> /payment/api/wallet/create</kbd>


### Example
###### Request
<kbd><kbd>POST</kbd> /payment/api/wallet/create</kbd>

###### Request Body
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
  <b>"Customer": "JOHNDOE0001"</b>,
  <b>"ExpDate": "0918"</b>,
  "TrxInitiation": "Merchant",
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

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields please see our [object reference](Objects.md#card).

###### Response
```JSON
{
  "Message": null,
  "Result": "ccfbf703-0fff-4e28-845e-3c5c5092f857"
}
```

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md).

Create an eCheck
----------------

Create a new eCheck wallet record.

### Endpoint
<kbd><kbd>POST</kbd> /payment/api/wallet/create</kbd>

### Example
###### Request
<kbd><kbd>POST</kbd> /payment/api/wallet/create</kbd>

###### Request Body
<pre>
{
  <b>"Account": "1234567890"</b>,
  <b>"Aba": "031200730"</b>,
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
  <b>"Customer": "JOHNDOE0001"</b>,
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

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields please see our [object reference](Objects.md#card).

Insted of returning validation failed error message while wallet is duplicated, PayFabric removed the credit card/eCheck duplicate validation for wallet creation, PayFabric will check the existence for the new wallet, if existing, return the existing wallet ID, assign it the new wallet object, then do the update wallet workflow. 

###### Response
```JSON
{
  "Message": null,
  "Result": "6ae8448f-de67-4f71-89f9-07bb77621cc7"
}
```

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md#create-a-credit-card--echeck).


Update a Credit Card / eCheck
-----------------------------

Update a wallet record with new information based on the request JSON payload.

### Endpoint
<kbd><kbd>POST</kbd> /payment/api/wallet/update</kbd>

### Example
###### Request
<kbd><kbd>POST</kbd> /payment/api/wallet/update</kbd>

###### Request Body
```JSON
{
  "ID" : "4ea31dda-4efb-4ed5-8f35-dbcc6b16017d"
}
```

Please note that the **ID** field is the only required field for an update.  Only the fields that need updating should be included, see the **Create Credit Card / eCheck** endpoint for more information.  When updating a Wallet entry, do **not** include the **Account** field.  PayFabric is unable to update the account/card number. To update an account/card number, delete the old Wallet entry and create a new one. 

**Update Customer Number/ID**

To update the Customer ID/Number against an existing credit card/eCheck record, include **NewCustomerNumber** field into the request body and populate it with a new Customer Number/ID. This will replace the existing Customer ID/Number. 

###### Response
```JSON
{
  "Result": "True"
}
```

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md#update-a-credit-card--echeck).


Retrieve a Credit Card / eCheck
-------------------------------

Return the detail for a specific credit card or eCheck wallet record.

Credit card numbers and account numbers are returned in a masked format. PayFabric never returns credit card number or account numbers in plain-text.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/get/<kbd>{Wallet_ID}</kbd></kbd>

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/get/ccb4edfd-c9b3-4964-9ecc-5b143a60650d</kbd></kbd>

###### Response
```JSON
{
    "Aba": "",
    "Account": "XXXXXXXXXXXX5100",
    "AccountType": "",
    "CardHolder": {
        "DriverLicense": "",
        "FirstName": "adsf",
        "LastName": "asdf",
        "MiddleName": "",
        "SSN": ""
    },
    "CardName": "MasterCard",
    "CardType": "Debit",
    "CheckNumber": null,
    "Connector": "PayflowPro",
    "Customer": "AARONFIT0001",
    "EncryptedToken": null,
    "ExpDate": "1225",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "72e39334-22cb-436f-abdb-3b5d25c927c4",
    "Identifier": "",
    "IsDefaultCard": false,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "LastUsedDate": "3/15/2021 3:59:31 PM",
    "LastUsedDateUTC": "2021-03-15T22:59:31.440Z",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": "",
    "Billto": {
        "City": "Indianapolis",
        "Country": "United States",
        "Customer": "",
        "Email": "sample@email.com",
        "ID": "a7132d83-4f44-459f-9568-c598ba521942",
        "Line1": "24259 P.O. Box 1391",
        "Line2": "2322121212",
        "Line3": "",
        "Phone": "14255550101",
        "State": "Indiana",
        "Zip": "94303"
    },
    "ModifiedOn": "10/20/2020 7:00:29 PM",
    "ModifiedOnUTC": "2020-10-21T02:00:29.946Z"
}
```


Retrieve Credit Cards / eChecks
-------------------------------

Return wallet records by `Customer`.  Supports special characters in `Customer` ID/Number.

Credit card numbers and account numbers are returned in a masked format. PayFabric never returns credit card numbers or account numbers in plain-text.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/getByCustomer?customer=<kbd>{CUSTOMER_NO}</kbd>&tender=<kbd>{TENDER_TYPE}</kbd>&fromLastUsedDate=<kbd>{FROM_LASTUSEDDATE}</kbd>&toLastUsedDate=<kbd>{TO_LASTUSEDDATE}</kbd></kbd>.

| Query String     | DataType | Definition | Required? |
| :--------------- | :------- | :--------- | :---------|
| customer         | String   | Retrieve wallets matching the `Customer`. | Required |
| tender           | String   | Can be <kbd>CreditCard</kbd> or <kbd>ECheck</kbd>. | Optional |
| fromLastUsedDate | String   | Retrieve wallets which its `LastUsedDate` is later than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and is based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Optional |  
| toLastUsedDate   | String   | Retrieve wallets which its `LastUsedDate` is earlier than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and is based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Optional | 

### Example
<kbd><kbd>GET</kbd> /payment/api/wallet/getByCustomer?customer=AARONFIT0001&tender=CreditCard&fromLastUsedDate=2022-05-01&toLastUsedDate=2022-05-31</kbd>.

###### Response
```JSON
[
    {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "as12",
            "LastName": "as12",
            "MiddleName": "",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "Credit",
        "CheckNumber": null,
        "Connector": "",
        "Customer": "AARONFIT0001",
        "EncryptedToken": null,
        "ExpDate": "0522",
        "GPAddressCode": "",
        "GatewayToken": "",
        "ID": "0b9cbe13-3c29-4a5f-a5dd-33b1f0f802ab",
        "Identifier": "",
        "IsDefaultCard": true,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": "",
        "LastUsedDate": "5/6/2022 6:28:39 PM",
        "LastUsedDateUTC": "2022-05-07T01:28:39.220Z",
        "Tender": "CreditCard",
        "UserDefine1": "",
        "UserDefine2": "",
        "UserDefine3": "",
        "UserDefine4": "",
        "Billto": {
            "City": "CA",
            "Country": "United States",
            "Customer": "",
            "Email": "sample@email.com",
            "ID": "5b0d85ca-e72d-4c17-838a-0c0eac384634",
            "Line1": "123 test",
            "Line2": "",
            "Line3": "",
            "Phone": "",
            "State": "CA",
            "Zip": "12345"
        },
        "ModifiedOn": "5/6/2022 6:28:39 PM",
        "ModifiedOnUTC": "2022-05-07T01:28:39.220Z"
    },
    {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "aaron",
            "LastName": "fit",
            "MiddleName": "",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "Credit",
        "CheckNumber": null,
        "Connector": "",
        "Customer": "AARONFIT0001",
        "EncryptedToken": null,
        "ExpDate": "0625",
        "GPAddressCode": "",
        "GatewayToken": "",
        "ID": "2175e2a5-71e2-483c-9b2d-4d7a11685a1a",
        "Identifier": "",
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": "",
        "LastUsedDate": "5/10/2022 10:50:50 PM",
        "LastUsedDateUTC": "2022-05-11T05:50:50.060Z",
        "Tender": "CreditCard",
        "UserDefine1": "",
        "UserDefine2": "",
        "UserDefine3": "",
        "UserDefine4": "",
        "Billto": {
            "City": "Redmond",
            "Country": "US",
            "Customer": "",
            "Email": "vicky@nodus.com",
            "ID": "15a47fcb-3ff7-4bfa-adad-7f057c693597",
            "Line1": "One Microsoft Way",
            "Line2": "",
            "Line3": "",
            "Phone": "42555501010000",
            "State": "WA",
            "Zip": "98052-6399"
        },
        "ModifiedOn": "5/10/2022 10:50:50 PM",
        "ModifiedOnUTC": "2022-05-11T05:50:50.060Z"
    }
]
```

Retrieve Credit Cards / eChecks (Query with Paging)
-----------------------------------------------

Return a paged list of wallet records based on wallet's `ModifiedOn` date.

Credit card and ECheck account numbers are returned in a masked format. PayFabric never returns credit card number or ECheck account numbers in plaintext.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/get?customer=<kbd>{CUSTOMER_NO}</kbd>&tender=<kbd>{TENDER_TYPE}</kbd>&fromdate=<kbd>{FROM_DATE}</kbd>&fromLastUsedDate=<kbd>{FROM_LASTUSEDDATE}</kbd>&toLastUsedDate=<kbd>{TO_LASTUSEDDATE}</kbd>&pageSize=<kbd>{PAGE_SIZE}</kbd>&page=<kbd>{PAGE}</kbd></kbd>

| Query String     | DataType | Definition | Required? |
| :--------------- | :------- | :--------- | :-------- |
| customer         | String   | Retrieve wallets matching the `Customer`. | Optional|
| tender           | String   | Can be <kbd>CreditCard</kbd> or <kbd>ECheck</kbd>. | Optional |
| fromDate         | String   | Retrieve wallets with `ModifiedOn` date later than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Required |
| fromLastUsedDate | String   | Retrieve wallets which its `LastUsedDate` is later than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Optional |  
| toLastUsedDate   | String   | Retrieve wallets which its `LastUsedDate` is earlier than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and based on 
| pagesize         | String   | Specify the page size.  | Optional |
| page             | String   | Specify the page you want to get. | Optional |

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/get?customer=AARONFIT0001&fromdate=2022-05-01&pageSize=15&page=1</kbd>

###### Response
```JSON
{
    "Paging": {
        "Current": "1",
        "Size": "15",
        "TotalPages": "1",
        "TotalRecords": "2"
    },
    "Records": [
        {
            "Aba": "XXXXX0730",
            "Account": "XX3333",
            "AccountType": "Checking",
            "CardHolder": {
                "DriverLicense": "XXXXX1321",
                "FirstName": "321",
                "LastName": "321321",
                "MiddleName": "",
                "SSN": "XXXXXXXX3132"
            },
            "CardName": "ECheck",
            "CardType": "",
            "CheckNumber": null,
            "Connector": "",
            "Customer": "AARONFIT0001",
            "EncryptedToken": null,
            "ExpDate": "",
            "GPAddressCode": "",
            "GatewayToken": "",
            "ID": "aaf2866d-68a2-456b-b2fe-2ca117d5233f",
            "Identifier": "",
            "IsDefaultCard": true,
            "IsLocked": true,
            "IsSaveCard": false,
            "IssueNumber": "",
            "LastUsedDate": "5/19/2022 7:03:54 AM",
            "LastUsedDateUTC": "2022-05-19T04:03:54.640Z",
            "Tender": "ECheck",
            "UserDefine1": "",
            "UserDefine2": "",
            "UserDefine3": "",
            "UserDefine4": "",
            "Billto": {
                "City": "Anaheim",
                "Country": "USA",
                "Customer": "",
                "Email": "success+bchksale1@simulator.amazonses.com;success+bchksale2@simulator.amazonses.com,success+bchksale3@simulator.amazonses.com",
                "ID": "99c3f605-fc07-4070-bdbd-315ad8fd7363",
                "Line1": "123 street",
                "Line2": "",
                "Line3": "",
                "Phone": "",
                "State": "CA",
                "Zip": "12345"
            },
            "ModifiedOn": "5/19/2022 7:03:54 AM",
            "ModifiedOnUTC": "2022-05-19T04:03:54.640Z"
        },
        {
            "Aba": "",
            "Account": "XXXXXXXXXXXX5454",
            "AccountType": "",
            "CardHolder": {
                "DriverLicense": "",
                "FirstName": "dd",
                "LastName": "dd",
                "MiddleName": "",
                "SSN": ""
            },
            "CardName": "MasterCard",
            "CardType": "Debit",
            "CheckNumber": null,
            "Connector": "EVO",
            "Customer": "AARONFIT0001",
            "EncryptedToken": null,
            "ExpDate": "1122",
            "GPAddressCode": "",
            "GatewayToken": "",
            "ID": "b80f2d9e-882c-4ea5-9289-720661cae59b",
            "Identifier": "",
            "IsDefaultCard": true,
            "IsLocked": false,
            "IsSaveCard": false,
            "IssueNumber": "",
            "LastUsedDate": "5/25/2022 8:55:45 AM",
            "LastUsedDateUTC": "2022-05-25T05:55:45.843Z",
            "Tender": "CreditCard",
            "UserDefine1": "",
            "UserDefine2": "",
            "UserDefine3": "",
            "UserDefine4": "",
            "Billto": {
                "City": "Anaheim",
                "Country": "USA",
                "Customer": "",
                "Email": "sample@email.com",
                "ID": "01d5db8d-8fec-49b7-88ca-28b192f100f1",
                "Line1": "123 test, 1, d, 1, d, 1, d",
                "Line2": "1",
                "Line3": "d",
                "Phone": "1234567890",
                "State": "CA",
                "Zip": "12455"
            },
            "ModifiedOn": "5/25/2022 8:55:45 AM",
            "ModifiedOnUTC": "2022-05-25T05:55:45.843Z"
        }
    ]
}
```


Lock Credit Card / eCheck
-------------------------

Used when there are multiple PayFabric Devices. A Device can lock a wallet record with a lock reason, so that when other Devices attempts to delete the wallet record, the operation will fail and returns error with the lock reason, such as:

<pre><samp>Unable to delete the wallet card. The wallet is locked by other device(s). Device Name: myDevice, Lock Reason: Tied to contract C101.</samp></pre>

The Device that locks the record will always be able to delete the record, and only other Devices are prohibited from deletion.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/lock/<kbd>{WALLET_ID}</kbd>?lockreason=<kbd>{URL_ENCODED_STRING}</kbd></kbd>

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/lock/cbb571ea-e834-41c4-8a20-7d55bb7ae190?lockreason=Tied+to+Contract+C101.</kbd> 

###### Response
```JSON
{
  "Result": "True"
}
```


Unlock Credit Card / eCheck
---------------------------

Unlocks a wallet record to allow deletion of the wallet record by other Devices.

<pre><samp>Unable to delete the wallet card. The wallet is locked by other device(s). Device Name: myDevice, Lock Reason: Tied to contract C101.</samp></pre>

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/unlock/<kbd>{WALLET_ID}</kbd></kbd>

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/lock/cbb571ea-e834-41c4-8a20-7d55bb7ae190</kbd> 

###### Response
```JSON
{
  "Result": "True"
}
```


Remove Credit Card / eCheck
---------------------------

Delete a wallet record.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/delete/<kbd>{WALLET_ID}</kbd></kbd>

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190</kbd>

###### Response
```JSON
{
  "Result": "True"
}
```


Retrieve expired wallet
-------------------------

Return a paged list of credit card wallet records which has its expiration date (`ExpDate`) within a specified date range.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/expiredwallet/get?customer=<kbd>{CUSTOMER_NO}</kbd>&startDate=<kbd>{START_DATE}</kbd>&endDate=<kbd>{END_DATE}</kbd>&pageSize=<kbd>{PAGE_SIZE}</kbd>&page=<kbd>{PAGE}</kbd></kbd>

* Date format is `YYYY-MM-DD` or `MM-DD-YYYY`.
* Default page size is 15 records.

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/expiredwallet/get?customer=JOHNDOE0001&startDate=2000-01-01&endDate=2018-09-01&page=1</kbd>

###### Response
```JSON
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
      "Customer": "JOHNDOE0001",
      "ExpDate": "1018",
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
      "Customer": "JOHNDOE0001",
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
```
