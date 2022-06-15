Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used for returning customer created wallet records, creating new wallet records, locking, updating, and deleting existing wallet records.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.


Create a Credit Card
--------------------

* `POST /payment/api/wallet/create` will create a new credit card with the following JSON payload:

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
  <b>"Customer": "JOHNDOE0001"</b>,
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

Please note that **bold** fields are required fields, and all others are optional.  For more information and descriptions on available fields please see our [object reference](Objects.md#card).

###### Response
<pre>
{
  "Message": null,
  "Result": "ccfbf703-0fff-4e28-845e-3c5c5092f857"
}
</pre>

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md).

Create an eCheck
----------------

* `POST /payment/api/wallet/create` will create a new eCheck with the following JSON payload:

###### Request
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

###### Response
<pre>
{
  "Message": null,
  "Result": "6ae8448f-de67-4f71-89f9-07bb77621cc7"
}
</pre>

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md#create-a-credit-card--echeck).

Update a Credit Card / eCheck
-----------------------------

* `POST /payment/api/wallet/update` will update a credit card or eCheck with new information based on the request JSON payload

###### Request
<pre>
{
  "ID" : "4ea31dda-4efb-4ed5-8f35-dbcc6b16017d"
}
</pre>

Please note that the **ID** field is the only required field for an update.  Only the fields that need updating should be included, see the **Create Credit Card / eCheck** endpoint for more information.  When updating a Wallet entry, do **not** include the **Account** field.  PayFabric is unable to update the account/card number. To update an account/card number, delete the old Wallet entry and create a new one. 

**Update Customer Number/ID**

To update the Customer ID/Number against an existing credit card/eCheck record, include **NewCustomerNumber** field into the request body and populate it with a new Customer Number/ID. This will replace the existing Customer ID/Number. 

###### Response
<pre>
{
  "Result": "True"
}
</pre>

**Note**: We highly recommend using PayFabric hosted wallet page for create/update credit card/eCheck wallet entry. It is a secure page that can be embedded into your application. Please click [here](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md#update-a-credit-card--echeck).

Retrieve a Credit Card / eCheck
-------------------------------

* `GET /payment/api/wallet/get/ccb4edfd-c9b3-4964-9ecc-5b143a60650d` will return the specified credit card or eCheck

Credit card and account numbers are returned in a masked format. PayFabric never returns credit card or account numbers in plaintext.

###### Response
<pre>
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
</pre>


Retrieve Credit Cards / eChecks
-------------------------------

* `GET /payment/api/wallet/getByCustomer?customer=test&tender=CreditCard&fromLastUsedDate={FROMLASTUSEDDATE}&toLastUsedDate={TOLASTUSEDDATE}` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_), which also supports special characters under Customer ID/Number. 

Credit card and account numbers are returned in a masked format. PayFabric never returns credit card or account numbers in plaintext.

| Query String       | DataType|Definition| Required?|
| :-----------    |:---------| :---------| :---------|
| customer    | String | PayFabric will retrieve  wallets belong to the Customer.  | Required|
| tender   | String | PayFabric will retrieve  wallets tender type equals the specified tender. |Optional|
| fromLastUsedDate          | String | PayFabric will retrieve wallets which last used date later than the specified date, you can pass like "2022-05-01", and it is in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). |Optional|  
| toLastUsedDate         | String | PayFabric will retrieve wallets which last used date earlier than the specified date, you can pass like "2022-05-21", and it is in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). | Optional| 

###### Response
<pre>
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
</pre>

Retrieve Credit Cards / eChecks (Query with Paging)
-----------------------------------------------

* `GET /payment/api/wallet/get?customer={CUSTOMER_NO}&tender={TENDER_TYPE}&fromdate={FROMDATE}&fromLastUsedDate={FROMLASTUSEDDATE}&toLastUsedDate={TOLASTUSEDDATE}&pageSize={PAGESIZE}&page={PAGE}` will return the credit cards or eChecks for a customer depending on the tender type (_CreditCard_, _ECheck_), which were modified after the specified date, and display records depending on the page number.

| Query String       | DataType|Definition| Required?|
| :-----------    |:---------| :---------| :---------|
| customer    | String | PayFabric will retrieve  wallets belong to the Customer.  | Optional|
| tender   | String | PayFabric will retrieve  wallets tender type equals the specified tender. |Optional|
| fromDate | String | PayFabric will retrieve wallets which modified date later than the specified date, you can pass like "2022-05-01", and it will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). |Required|  
| fromLastUsedDate          | String | PayFabric will retrieve wallets which last used date later than the specified date, you can pass like "2022-05-01", and it will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). |Optional|  
| toLastUsedDate         | String | PayFabric will retrieve wallets which last used date earlier than the specified date, you can pass like "2022-05-21", and it will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). | Optional| 
| pagesize    | String | Specify the page size.  | Optional|
| page   | String | Specify the page you want to get. |Optional|


Credit card and ECheck account numbers are returned in a masked format. PayFabric never returns credit card number or ECheck account numbers in plaintext.

###### Response
<pre>
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
</pre>


Lock Credit Card / eCheck
-------------------------

* `GET /payment/api/wallet/lock/cbb571ea-e834-41c4-8a20-7d55bb7ae190?lockreason=Customer+being+audited` will lock the credit card or eCheck from being used with a specified reason

###### Response
<pre>{
  "Result": "True"
}</pre>


Unlock Credit Card / eCheck
---------------------------

* `GET /payment/api/wallet/unlock/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will unlock the credit card or eCheck from being used

###### Response
<pre>{
  "Result": "True"
}</pre>


Remove Credit Card / eCheck
---------------------------

* `GET /payment/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190` will remove the credit card or eCheck

###### Response
<pre>{
  "Result": "True"
}</pre>

Retrieve expired wallet
-------------------------

* `GET /payment/api/expiredwallet/get?customer={CUSTOMER_NO}&startDate={STARTDATE}&endDate={ENDDATE}&pageSize={PAGESIZE}&page={PAGE}` will return the expired credit cards for a customer, whose Expiration date is in the specified date, and display records depending on the page number, each page size is 15 records.

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
      "Customer": "JOHNDOE0001",
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
</pre>
