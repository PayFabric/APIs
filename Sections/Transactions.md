Transactions
============

The PayFabric Transactions API is used for creating, and processing payment transactions. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Transaction
--------------------

* `POST /rest/api/transaction/create` will create and save a transaction to the PayFabric server based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Currency": "USD"</b>,
  <b>"Customer": "John Doe Ltd"</b>,
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

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields, click [here](Objects#transaction).

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/Portal/tree/v2/Sections/Transaction%20Types.md)

###### Response
<pre>
{
  "Key": "151013003794"
}
</pre>


Update a Transaction
--------------------

* `POST /rest/api/transaction/update` will update a transaction with new information based on the request JSON payload

###### Request
<pre>
{
    "Key": "151013003793"
}
</pre>

Please note that the **Key** field is the only required field for an update. Only the fields that need updating should be included, see the **Create a Transaction** endpoint for more information.

###### Response
<pre>
{
  "Result": "True"
}
</pre>

Add a Payment Method
--------------------

Adding a payment method can also be done during [Create a Transaction](#create-a-transaction), [Update a Transaction](#update-a-transaction) and [Create and Process a Transaction](#create-and-process-a-transaction) API calls.  

* `POST /rest/api/transaction/update` will update a transaction with a new payment method or an existing tokenized payment method based on the request JSON payload, a payment method is required before attempting to process a transaction through the API, if processing the transaction through the use of the hosted page adding a payment method is not required

###### Request for New Credit Card
<pre>
{
    "Key": "151013003793",
    <b>"Card":</b> {
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
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  }
}
</pre>

###### Request for New eCheck
<pre>
{
    "Key": "151013003793",
    <b>"Card":</b> {
    <b>"CheckNumber": "4111111111111111"</b>,
    <b>"AccountType": "Checking"</b>,
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
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  }
}
</pre>

###### Request for Existing Payment Method
<pre>
{
    "Key": "151013003793",
    "Card": {
      "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"
    }
}
</pre>

Please note that the **Key** field is the only required field for an update. For more information and descriptions on available fields, click [here](Objects#card).

###### Related Reading
* [How to Retrieve Tokenized Payment Methods](Wallets.md#retrieve-credit-cards--echecks)

###### Response
<pre>
{
  "Result": "True"
}
</pre>


Process a Transaction
---------------------

* `GET /rest/api/transaction/process/151007010914?cvc=111` will attempt to process the transaction with the payment gateway

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


Create and Process a Transaction
--------------------------------

* `POST /rest/api/transaction/process?cvc=111` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Card":</b> {
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
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  },
  <b>"Currency": "USD"</b>,
  <b>"Customer": "John Doe Ltd"</b>,
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

Please note that **bold** fields are required fields, and all others are optional, for more information on available payment *Card* options please see the [Wallet documentation](/Wallets.md). For more information and descriptions on available fields, click [here](Objects#transaction).

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/Portal/tree/v2/Sections/Transaction%20Types.md)

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

* `GET /rest/api/transaction/151013003792` will return the specified transaction

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
    "Customer": "John Doe Ltd",
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
  "Customer": "John Doe Ltd",
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

* `GET /rest/api/transaction/get?fromdate=10-13-2015` will return the transactions created after the specified date

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
      "Customer": "John Doe Ltd",
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
      "Customer": "John Doe Ltd",
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


Referenced Transaction(s): Void, Capture (Ship) or Credit
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Credit. They all use the transaction Key from the original transaction to process the new transaction.

* `GET /rest/api/reference/151013003792?trxtype=SHIP` will attempt to execute and finalize (capture) a pre-authorized transaction, also known as BOOK transactions.
* `GET /rest/api/reference/151013003792?trxtype=VOID` will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.
* `GET /rest/api/reference/151013003792?trxtype=CREDIT` will attempt to credit a transaction that has already been submitted to a payment gateway and has been settled from the bank. PayFabric attempts to submit a CREDIT transaction for the same exact amount as the original SALE transaction.

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


Refund a Customer
-----------------

To refund a customer, you just submit a credit to the customer that is owed the refund. The amount of the transaction should match the amount that is due to the customer. To perform a credit transaction, you just create a transaction object, set the `Type` field to `Credit`, and then use [Create and Process a Transaction](#create-and-process-a-transaction) to execute the transaction.

* `POST /rest/api/transaction/process?cvc=111`

###### Request
<pre>
{
    "SetupId": "PFP",
    <b>"Type": "Credit"</b>,
    "Customer": "John Doe Ltd",
    "Amount": 19.99,
    "Currency": "USD",
    "Card": {
        "Account": "4111111111111111",
        "ExpDate": "0918",
        "CardHolder" : {
            "FirstName": "John",
            "LastName": "Doe"
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
