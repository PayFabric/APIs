﻿Transactions
============

The PayFabric Transactions API is used for creating, and processing payment transactions. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Transaction
--------------------

* `POST /transaction/create` will create and save a transaction to the PayFabric server based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001",
  "Document": {
    "Head": [],
    "Lines": [],
    "UserDefined": [
            {
                "Name": "DisableEmailReceipt", 
                "Value": "true"
            }
    ]
  },
  "PayDate": "",
  "ReferenceKey": null,
  "ReferenceTrxs": [],
  "ReqAuthCode": "",
  <b>"SetupId": "PFP"</b>,
  "Shipto": {
    "City": "",
    "Country": "",
    "Customer": "",
    "Email": "",
    "Line1": "",
    "Line2": "",
    "Line3": "",
    "Phone": "",
    "State": "",
    "Zip": ""
  },
  "TrxUserDefine1": "",
  "TrxUserDefine2": "",
  "TrxUserDefine3": "",
  "TrxUserDefine4": "",
  <b>"Type": "Sale"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md#transaction).

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transaction%20Types.md)
* [Create an eCheck Transaction](Process%20eCheck%20Transaction.md#create-a-echeck-transaction)

###### Response
<pre>
{
  "Key": "151013003794"
}
</pre>


Update a Transaction
--------------------

* `POST /transaction/update` will update a transaction with new information based on the request JSON payload

###### Request
<pre>
{
    "Key": "151013003793",
    "Card":{
  "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"
  }
}
</pre>

Please note that the **Key** field is the only required field for an update. Only the fields that need updating should be included, see the **Create a Transaction** endpoint for more information.

###### Response
<pre>
{
  "Result": "True"
}
</pre>

###### Related Reading
* [Update an eCheck Transaction](Process%20eCheck%20Transaction.md#update-a-echeck-transaction)

Process a Transaction
---------------------

* `GET /transaction/process/151007010914?cvc=111` will attempt to process the transaction with the payment gateway. `cvc` is optional.

###### Response
<pre>
{
  "AVSAddressResponse": null,
  "AVSZipResponse": null,
  "AuthCode": "010101",
  "CVV2Response": "Y",
  "IAVSAddressResponse": "N",
  "Message": "Approved",
  "OriginationID": "A70E7F9644C2",
  "PayFabricErrorCode": null,
  "RespTrxTag": null,
  "ResultCode": "0",
  "Status": "Approved",
  "TAXml": "",
  "TrxDate": "10/13/2015 8:41:44 AM",
  "TrxKey": "151007010914"
}
</pre>

###### Related Reading
* [Process an eCheck Transaction](Process%20eCheck%20Transaction.md#process-a-echeck-transaction)

Create and Process a Transaction
--------------------------------

* `POST /transaction/process?cvc=111` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload. `cvc` is optional.

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Card":</b> {
  <b>"ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"</b>
  },
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001",
  "Document": {
    "Head": [],
    "Lines": [],
    "UserDefined": []
  },
  "PayDate": "",
  "ReferenceKey": null,
  "ReferenceTrxs": [],
  "ReqAuthCode": "",
  <b>"SetupId": "PFP"</b>,
  "Shipto": {
    "City": "",
    "Country": "",
    "Customer": "",
    "Email": "",
    "Line1": "",
    "Line2": "",
    "Line3": "",
    "Phone": "",
    "State": "",
    "Zip": ""
  },
  "TrxUserDefine1": "",
  "TrxUserDefine2": "",
  "TrxUserDefine3": "",
  "TrxUserDefine4": "",
  <b>"Type": "Sale"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md). 

PayFabric support to create wallet either from [API](Wallets.md) or [Hosted Wallet Page](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md), we highly recommand use hosted wallet page to create wallet for security, and get the wallet ID through [Wallet Retrieve](Wallets.md#retrieve-credit-cards--echecks) API call.

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transaction%20Types.md)
* [Create and Process an eCheck Transaction](Process%20eCheck%20Transaction.md#create-and-process-a-echeck-transaction)
* [How to Disable Email Receipt] Provide 3rd party calling application the ability to disable PayFabric's email receipt to go out automatically for the corresponding transaction using the Document's UserDefined field (see the name-value pair option below). 
Name: DisableEmailReceipt 
Value: True/False, default option is False.

If True, this will disable the email receipt to go out for the corresponding transaction*.
If False, this will enable the email receipt to go out for the corresponding transaction*.
* This still depends on the prerequisite that email receipt is enabled on PayFabric service portal.

###### Response
<pre>
{
  "AVSAddressResponse": null,
  "AVSZipResponse": null,
  "AuthCode": "010101",
  "CVV2Response": "Y",
  "IAVSAddressResponse": "N",
  "Message": "Approved",
  "OriginationID": "A70E7F9644C1",
  "PayFabricErrorCode": null,
  "RespTrxTag": null,
  "ResultCode": "0",
  "Status": "Approved",
  "TAXml": "",
  "TrxDate": "10/13/2015 8:41:44 AM",
  "TrxKey": "151013003795"
}
</pre>


Retrieve a Transaction
----------------------

* `GET /transaction/{TransactionKey}` will return the specified transaction

###### Response
<pre>
{
  "Amount": "29.99",
  "BatchNumber": "20151013",
  "Card": {
    "Aba": "",
    "Account": "XXXXXXXXXXXX1111",
    "AccountType": "",
    "Billto": {
      "City": "Aneheim",
      "Country": "USA",
      "Customer": "",
      "Email": "John.Doe@payfabric.com",
      "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8",
      "Line1": "123 PayFabric way",
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
    "CheckNumber": "",
    "Connector": "PayflowPro",
    "Customer": "JOHNDOE0001",
    "ExpDate": "0918",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "ccfbf703-0fff-4e28-845e-3c5c5092f857",
    "Identifier": "",
    "IsDefaultCard": false,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "ModifiedOn": "1/1/0001 12:00:00 AM",
    "StartDate": "",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  },
  "Currency": "USD",
  "Customer": "JOHNDOE0001",
  "Document": {
    "Head": [
      {
        "Name": "Invoice Number",
        "Value": null
      }
    ],
    "Lines": [],
    "UserDefined": [
      {
        "Name": "ThirdPartyBatch",
        "Value": null
      }
    ]
  },
  "Key": "151013003792",
  "MSO_EngineGUID": "079c5da2-df91-4ad6-9ba2-a52300fef06a",
  "ModifiedOn": "10/13/2015 8:31:02 AM",
  "PayDate": "",
  "ReferenceKey": null,
  "ReferenceTrxs": [],
  "ReqAuthCode": "",
  "SetupId": "PFP",
  "Shipto": {
    "City": "",
    "Country": "",
    "Customer": "",
    "Email": "",
    "ID": "00000000-0000-0000-0000-000000000000",
    "Line1": "",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "1/1/0001 12:00:00 AM",
    "Phone": "",
    "State": "",
    "Zip": ""
  },
  "Tender": "CreditCard",
  "TrxResponse": {
    "AVSAddressResponse": "",
    "AVSZipResponse": "",
    "AuthCode": "",
    "CVV2Response": "",
    "IAVSAddressResponse": "",
    "Message": "",
    "OriginationID": "",
    "PayFabricErrorCode": null,
    "RespTrxTag": "",
    "ResultCode": "",
    "Status": "UnProcess",
    "TAXml": "",
    "TrxDate": null,
    "TrxKey": "151013003792"
  },
  "TrxUserDefine1": "",
  "TrxUserDefine2": "",
  "TrxUserDefine3": "",
  "TrxUserDefine4": "",
  "Type": "Sale"
}
</pre>


Retrieve Transactions
---------------------

* `GET /transaction/get?fromdate=10-13-2015` will return the transactions created after the specified date.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL and conneciton them with '&'.

>
| QueryString| Description | 
| :------------- | :------------- | 
|perdevice |When the value is `true`, the transaction will be filtered by device, which's device ID is used to authorize the request. Default value is `false`.|
|customer|This parameter is to filter the result by customer number, which is used to create/process transaction.|
|fromdate|This parameter is to set specific 'date from' to filter transactions. The format: mm/dd/yyyy.|
|page|This parameter is to set the result's page number, each page will return 15 records.|
|status|This parameter is used to filter transaction result against processed transaction's status, the possible values are: `approved`, `failure`, `declined`, `none` and `denied`. Returned result will include all transaction status if application does not submit this parameter.|
|excludeunprocess|When the value is `true`, the result will filter out the unprocess transaction. Default value is `false`. |

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
      "Amount": "29.99",
      "BatchNumber": "20151013",
      "Card": {
        "Aba": null,
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "Billto": {
          "City": "Aneheim",
          "Country": "USA",
          "Customer": "",
          "Email": "John.Doe@payfabric.com",
          "ID": "00000000-0000-0000-0000-000000000000",
          "Line1": "123 PayFabric way",
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
        "CheckNumber": "",
        "Connector": null,
        "Customer": "",
        "ExpDate": "0918",
        "GPAddressCode": null,
        "GatewayToken": null,
        "ID": "00000000-0000-0000-0000-000000000000",
        "Identifier": null,
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": null,
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "StartDate": null,
        "Tender": null,
        "UserDefine1": null,
        "UserDefine2": null,
        "UserDefine3": null,
        "UserDefine4": null
      },
      "Currency": "USD",
      "Customer": "JOHNDOE0001",
      "Document": {
        "Head": [
          {
            "Name": "Invoice Number",
            "Value": null
          }
        ],
        "Lines": [],
        "UserDefined": [
          {
            "Name": "ThirdPartyBatch",
            "Value": null
          }
        ]
      },
      "Key": "151013003792",
      "MSO_EngineGUID": "079c5da2-df91-4ad6-9ba2-a52300fef06a",
      "ModifiedOn": "10/13/2015 8:31:02 AM",
      "PayDate": "",
      "ReferenceKey": null,
      "ReferenceTrxs": null,
      "ReqAuthCode": "",
      "SetupId": null,
      "Shipto": {
        "City": "",
        "Country": "",
        "Customer": "",
        "Email": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Line1": "",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "",
        "State": "",
        "Zip": ""
      },
      "Tender": "CreditCard",
      "TrxResponse": {
        "AVSAddressResponse": "",
        "AVSZipResponse": "",
        "AuthCode": "",
        "CVV2Response": "",
        "IAVSAddressResponse": "",
        "Message": "",
        "OriginationID": "",
        "PayFabricErrorCode": null,
        "RespTrxTag": null,
        "ResultCode": "",
        "Status": "UnProcess",
        "TAXml": null,
        "TrxDate": null,
        "TrxKey": "151013003792"
      },
      "TrxUserDefine1": null,
      "TrxUserDefine2": null,
      "TrxUserDefine3": null,
      "TrxUserDefine4": null,
      "Type": "Sale"
    },
    {
      "Amount": "19.99",
      "BatchNumber": "20151013",
      "Card": {
        "Aba": null,
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "Billto": {
          "City": "Aneheim",
          "Country": "USA",
          "Customer": "",
          "Email": "John.Doe@payfabric.com",
          "ID": "00000000-0000-0000-0000-000000000000",
          "Line1": "123 PayFabric way",
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
        "CheckNumber": "",
        "Connector": null,
        "Customer": "",
        "ExpDate": "0918",
        "GPAddressCode": null,
        "GatewayToken": null,
        "ID": "00000000-0000-0000-0000-000000000000",
        "Identifier": null,
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": null,
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "StartDate": null,
        "Tender": null,
        "UserDefine1": null,
        "UserDefine2": null,
        "UserDefine3": null,
        "UserDefine4": null
      },
      "Currency": "USD",
      "Customer": "JOHNDOE0001",
      "Document": {
        "Head": [
          {
            "Name": "Invoice Number",
            "Value": null
          }
        ],
        "Lines": [],
        "UserDefined": [
          {
            "Name": "ThirdPartyBatch",
            "Value": null
          }
        ]
      },
      "Key": "151013003793",
      "MSO_EngineGUID": "079c5da2-df91-4ad6-9ba2-a52300fef06a",
      "ModifiedOn": "10/13/2015 8:31:46 AM",
      "PayDate": "",
      "ReferenceKey": null,
      "ReferenceTrxs": null,
      "ReqAuthCode": "",
      "SetupId": null,
      "Shipto": {
        "City": "",
        "Country": "",
        "Customer": "",
        "Email": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Line1": "",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "",
        "State": "",
        "Zip": ""
      },
      "Tender": "CreditCard",
      "TrxResponse": {
        "AVSAddressResponse": "",
        "AVSZipResponse": "",
        "AuthCode": "",
        "CVV2Response": "",
        "IAVSAddressResponse": "",
        "Message": "",
        "OriginationID": "",
        "PayFabricErrorCode": null,
        "RespTrxTag": null,
        "ResultCode": "",
        "Status": "UnProcess",
        "TAXml": null,
        "TrxDate": null,
        "TrxKey": "151013003793"
      },
      "TrxUserDefine1": null,
      "TrxUserDefine2": null,
      "TrxUserDefine3": null,
      "TrxUserDefine4": null,
      "Type": "Sale"
    }
  ]
}
</pre>


Referenced Transaction(s): Capture (Ship), Void or Credit
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Credit. They all use the transaction Key from the original transaction to process the new transaction.

#### Capture (Ship)

* `GET /reference/151013003792?trxtype=SHIP` will attempt to execute and finalize (capture) an authorization transaction, also known as Book transactions.
* `POST /transaction/process` will attempt to execute and finalize (capture) a pre-authorized transaction with specific amount, if `Amount` is not provided in request body, it will capture with authorized amount. if `Amount` is provoided in request body, it could be able to capture an authorization transaction multiple times, which depends on what gateway been used. (Note: Following gateways support multiple captures, Authorize.Net, USAePay & Payeezy(aka First Data GGE4).)

###### Request
<pre>
{
  "Amount": "1",
  "Type": "Ship",
  "ReferenceKey": "151013003792"
}
</pre>

* `GET /reference/151013003792?trxtype=VOID` or `POST /transaction/process` with following request will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.

###### Request
<pre>
{
  "Type": "Void",
  "ReferenceKey": "151013003792"
}
</pre>

* `GET /reference/151013003792?trxtype=CREDIT` or `POST /transaction/process` with following request will attempt to credit a transaction that has already been submitted to a payment gateway and has been settled from the bank. PayFabric attempts to submit a CREDIT transaction for the same exact amount as the original SALE transaction.

###### Request
<pre>
{
  "Type": "Credit",
  "ReferenceKey": "151013003792"
}
</pre>

Note: `ReferenceKey` is the initial processed transaction's `TrxKey`.

###### Response
<pre>
{
  "AVSAddressResponse": null,
  "AVSZipResponse": null,
  "AuthCode": "010101",
  "CVV2Response": "Y",
  "IAVSAddressResponse": "N",
  "Message": "Approved",
  "OriginationID": "A70E7F9644C2",
  "PayFabricErrorCode": null,
  "RespTrxTag": null,
  "ResultCode": "0",
  "Status": "Approved",
  "TAXml": "",
  "TrxDate": "10/13/2015 8:41:44 AM",
  "TrxKey": "151007010914"
}
</pre>

If `Amount` is not provided in request body for Credit/Refund transaction, it will processed with original transaction amount.

Refund a Customer
-----------------

To refund a customer, you just submit a credit to the customer that is owed the refund. The amount of the transaction should match the amount that is due to the customer. To perform a credit transaction, you just create a transaction object, set the `Type` field to `Credit`, and then use [Create and Process a Transaction](#create-and-process-a-transaction) to execute the transaction.

* `POST /transaction/process?cvc=111`

###### Request
<pre>
{
    "SetupId": "PFP",
    <b>"Type": "Credit"</b>,
    "Customer": "JOHNDOE0001",
    "Amount": 19.99,
    "Currency": "USD",
    "Card": {
        "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"
        }
    }
}
</pre>

###### Response
<pre>
{
  "AVSAddressResponse": null,
  "AVSZipResponse": null,
  "AuthCode": null,
  "CVV2Response": null,
  "IAVSAddressResponse": null,
  "Message": "Approved",
  "OriginationID": "A70E6C184BA5",
  "RespTrxTag": null,
  "ResultCode": "0",
  "Status": "Approved",
  "TrxDate": "5/31/2014 3:17:27 PM",
  "TrxKey": "140531067716"
}
</pre>
