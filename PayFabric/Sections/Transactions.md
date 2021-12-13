Transactions
============

The PayFabric Transactions API is used for creating, and processing payment transactions. 'Customer' field is required to save wallet entry for later or future use. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Transaction
--------------------

* `POST /payment/api/transaction/create` will create and save a transaction to the PayFabric server based on the request JSON payload

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

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md#transaction).

`SetupId` is a per-account setting which can be found in [here](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile). The value from the "Name/Setup ID" field of gateway profile, should replace "PFP" in the transaction request example.

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

###### Response Header
If create transaction with the gateway whose SurchargeRate greater than 0, and populated a credit card on this transaction, then PayFabric will return the surcharge fields in Response Header like below screenshot.

![CreateUpdateTrxWithSurchargeResponseHeader](https://raw.githubusercontent.com/PayFabric/Portal/master/PayFabric/Sections/Screenshots/CreateUpdateTrxWithSurchargeResponseHeader.png "CreateUpdateTrxWithSurchargeResponseHeader") 

Update a Transaction
--------------------

* `POST /payment/api/transaction/update` will update a transaction with new information based on the request JSON payload

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

###### Response Header
If update transaction with the gateway whose SurchargeRate greater than 0, and populated a credit card on this transaction, then PayFabric will return the surcharge fields in Response Header like below screenshot.

![CreateUpdateTrxWithSurchargeResponseHeader](https://raw.githubusercontent.com/PayFabric/Portal/master/PayFabric/Sections/Screenshots/CreateUpdateTrxWithSurchargeResponseHeader.png "CreateUpdateTrxWithSurchargeResponseHeader") 

###### Related Reading
* [Update an eCheck Transaction](Process%20eCheck%20Transaction.md#update-a-echeck-transaction)

Process a Transaction
---------------------

* `GET /payment/api/transaction/process/{TransactionKey}?cvc={CVCValue}` will attempt to process the transaction with the payment gateway. `cvc` is optional.

###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "21.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "21.00",
    "OriginationID": "A41E0E04DA61",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "21.00",
    "TrxDate": "7/1/2021 10:48:05 PM",
    "TrxKey": "21070100732372",
    "WalletID": "a37150f5-c863-4ff4-aa19-033406cfa8b0"
}
</pre>

###### Related Reading
* [Process an eCheck Transaction](Process%20eCheck%20Transaction.md#process-a-echeck-transaction)

Create and Process a Transaction
--------------------------------

* `POST /payment/api/transaction/process?cvc={CVCValue}` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload. `cvc` is optional.

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


###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "21.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "21.00",
    "OriginationID": "A41E0E04DA61",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "21.00",
    "TrxDate": "7/1/2021 10:48:05 PM",
    "TrxKey": "21070100732372",
    "WalletID": "a37150f5-c863-4ff4-aa19-033406cfa8b0"
}
</pre>


Retrieve a Transaction
----------------------

* `GET /payment/api/transaction/{TransactionKey}` will return the specified transaction

###### Response
<pre>
{
    "Amount": "11.00",
    "AuthorizationType": "NotSet",
    "BatchNumber": "",
    "CCEntryIndicator": "Entered",
    "Card": {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "Billto": {
            "City": "WEST POINT",
            "Country": "United States of America",
            "Customer": "",
            "Email": "success+test1@simulator.amazonses.com; success+test2@simulator.amazonses.com",
            "ID": "00000000-0000-0000-0000-000000000000",
            "Line1": "1791 OG SKINNER DR STE D",
            "Line2": "db",
            "Line3": "db",
            "ModifiedOn": "1/1/0001 12:00:00 AM",
            "Phone": "7067730145",
            "State": "GA",
            "Zip": "10101"
        },
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "dddd",
            "LastName": "ddf",
            "MiddleName": "",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "",
        "CheckNumber": "",
        "Connector": "PayflowPro",
        "Customer": "Rena",
        "ExpDate": "0122",
        "GPAddressCode": "",
        "GatewayToken": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Identifier": "",
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": "",
        "LastUsedDate": "1/1/0001 12:00:00 AM",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "NewCustomerNumber": null,
        "StartDate": "",
        "Tender": "CreditCard",
        "UserDefine1": "",
        "UserDefine2": "",
        "UserDefine3": "",
        "UserDefine4": ""
    },
    "CardHolderAttendance": "",
    "CardType": "",
    "Currency": "USD",
    "Customer": "Rena",
    "Document": {
        "DefaultBillTo": null,
        "Head": [
            {
                "Name": "PO Number",
                "Value": "W2909897"
            },
            {
                "Name": "Tax Amount",
                "Value": "0.00000"
            },
            {
                "Name": "Freight Amount",
                "Value": "0.00000"
            },
            {
                "Name": "Handling Amount",
                "Value": "0.00000"
            },
            {
                "Name": "Discount Amount",
                "Value": "0.00000"
            },
            {
                "Name": "Order Date",
                "Value": "8/14/2017 12:00:00 AM"
            },
            {
                "Name": "Customer VAT Reg",
                "Value": null
            },
            {
                "Name": "Date Of Birth",
                "Value": ""
            },
            {
                "Name": "Ship-To-Zip",
                "Value": "31833-1900"
            },
            {
                "Name": "Ship-From-Zip",
                "Value": "44139"
            },
            {
                "Name": "Desc",
                "Value": ""
            },
            {
                "Name": "Desc1",
                "Value": ""
            },
            {
                "Name": "Desc2",
                "Value": ""
            },
            {
                "Name": "Desc3",
                "Value": ""
            },
            {
                "Name": "Desc4",
                "Value": ""
            },
            {
                "Name": "Comment1",
                "Value": ""
            },
            {
                "Name": "Comment3",
                "Value": ""
            }
        ],
        "Lines": [
            {
                "Columns": [
                    {
                        "Name": "ItemQuantity",
                        "Value": "4.00000"
                    },
                    {
                        "Name": "ItemDesc",
                        "Value": ""
                    },
                    {
                        "Name": "ItemProdCode",
                        "Value": "PA3520B01"
                    },
                    {
                        "Name": "ItemUPC",
                        "Value": "PA3520B01"
                    },
                    {
                        "Name": "ItemCommodityCode",
                        "Value": "PA3520B01"
                    },
                    {
                        "Name": "ItemUOM",
                        "Value": ""
                    },
                    {
                        "Name": "ItemAmount",
                        "Value": "151.04000"
                    },
                    {
                        "Name": "ItemTaxAmount",
                        "Value": "0.00000"
                    },
                    {
                        "Name": "ItemDiscount",
                        "Value": "0.00000"
                    },
                    {
                        "Name": "ItemCost",
                        "Value": ""
                    }
                ],
                "UserDefined": []
            }
        ],
        "UserDefined": [
            {
                "Name": "ERPDocumentNumber",
                "Value": "STDORD0262835"
            },
            {
                "Name": "IsForScribe",
                "Value": "1"
            },
            {
                "Name": "ERPDocType",
                "Value": "2"
            },
            {
                "Name": "ERPSourceOfDocument",
                "Value": "1"
            },
            {
                "Name": "ERPBatchSource",
                "Value": "Sales Entry"
            },
            {
                "Name": "AppID",
                "Value": "CCA"
            }
        ]
    },
    "ECheckSetupId": "",
    "EntryClass": "",
    "EntryMode": "API",
    "Key": "19121600966949",
    "MSO_EngineGUID": "e2e7b828-9f1e-447a-86d1-d15fbb844eb9",
    "ModifiedOn": "12/16/2019 5:43:31 PM",
    "OrigTrxAmount": "11.00",
    "PayDate": "",
    "ReferenceKey": null,
    "ReferenceTrxs": [],
    "ReqAuthCode": "",
    "SetupId": "PayFlowProCredit",
    "Shipto": {
        "City": "WEST POINT",
        "Country": "United States of America",
        "Customer": "",
        "Email": "success+test1@simulator.amazonses.com; success+test2@simulator.amazonses.com",
        "ID": "65145e9f-0b35-4c52-b800-920277ee7cd2",
        "Line1": "1791 OG SKINNER DR STE D",
        "Line2": "",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "Phone": "7067730145",
        "State": "GA",
        "Zip": "10101"
    },
    "SurchargeAmount": "",
    "SurchargePercentage": null,
    "Tender": "CreditCard",
    "TransactionState": "Settled",
    "TrxInitiation": "Customer",
    "TrxResponse": {
        "AVSAddressResponse": "Y",
        "AVSZipResponse": "Y",
        "AuthCode": "010101",
        "CVV2Response": "Y",
        "CardType": "",
        "ExpectedSettledTime": "2019-12-17T03:00:00.0000000Z",
        "FinalAmount": "11.00",
        "IAVSAddressResponse": "N",
        "Message": "Approved",
        "OrigTrxAmount": "11.00",
        "OriginationID": "A10EAE78E672",
        "PayFabricErrorCode": null,
        "RespTrxTag": "",
        "ResultCode": "0",
        "SettledTime": "2020-07-28T00:00:00.0000000Z",
        "Status": "Approved",
        "SurchargeAmount": "0",
        "SurchargePercentage": "0",
        "TAXml": "",
        "TerminalID": "",
        "TerminalResultCode": "",
        "TrxAmount": "11.00",
        "TrxDate": "12/16/2019 5:43:31 PM",
        "TrxKey": "19121600966949",
        "WalletID": null
    },
    "TrxSchedule": "Unscheduled",
    "TrxUserDefine1": "PFR",
    "TrxUserDefine2": "",
    "TrxUserDefine3": "",
    "TrxUserDefine4": "",
    "Type": "Sale"
}
</pre>


Retrieve Transactions
---------------------

* `GET /payment/api/transaction/get?fromdate=10-13-2015` will return the transactions created after the specified date.

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
|status|This parameter is used to filter transaction result against processed transaction's status, the possible values are: `approved`, `failure`, and `denied`. Returned result will include all transaction status if application does not submit this parameter.|
|excludeunprocess|When the value is `true`, the result will filter out the unprocess transaction. Default value is `false`. |
|pagesize|This parameter is to set specific page size, maximum value is 15.|
|enddate|This parameter is to set a specific 'date to' to filter transactions, The format: mm/dd/yyyy. |

###### Response
<pre>
{
    "Paging": {
        "Current": "1",
        "Size": "2",
        "TotalPages": "2307",
        "TotalRecords": "4614"
    },
    "Records": [
        {
            "Amount": "1.60",
            "AuthorizationType": "",
            "BatchNumber": "",
            "CCEntryIndicator": "",
            "Card": {
                "Aba": "",
                "Account": "XXXXXXXXXXXX1111",
                "AccountType": "",
                "Billto": {
                    "City": "SPCA",
                    "Country": "SPUS",
                    "Customer": "",
                    "Email": "success+shipto@simulator.amazonses.com",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "SPLINE1",
                    "Line2": "SPLINE12",
                    "Line3": "SPLINE13",
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "Phone": "999999999",
                    "State": "SPCA",
                    "Zip": "SP123456"
                },
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "DefaultFN",
                    "LastName": "DefaultLN",
                    "MiddleName": "",
                    "SSN": ""
                },
                "CardName": "Visa",
                "CardType": "",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "ExpDate": "1230",
                "GPAddressCode": null,
                "GatewayToken": null,
                "ID": "00000000-0000-0000-0000-000000000000",
                "Identifier": null,
                "IsDefaultCard": false,
                "IsLocked": false,
                "IsSaveCard": false,
                "IssueNumber": null,
                "LastUsedDate": "1/1/0001 12:00:00 AM",
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "NewCustomerNumber": null,
                "StartDate": null,
                "Tender": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null
            },
            "CardHolderAttendance": "",
            "CardType": "",
            "Currency": "USD",
            "Customer": "AARONFIT0001",
            "Document": {
                "DefaultBillTo": null,
                "Head": [],
                "Lines": [],
                "UserDefined": []
            },
            "ECheckSetupId": "",
            "EntryClass": "",
            "EntryMode": "API",
            "Key": "18110500693851",
            "MSO_EngineGUID": "e2e7b828-9f1e-447a-86d1-d15fbb844eb9",
            "ModifiedOn": "11/5/2018 12:38:56 AM",
            "OrigTrxAmount": "1.60",
            "PayDate": "",
            "ReferenceKey": null,
            "ReferenceTrxs": null,
            "ReqAuthCode": "",
            "SetupId": "PayFlowProCredit",
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
            "SurchargeAmount": "",
            "SurchargePercentage": null,
            "Tender": "CreditCard",
            "TransactionState": "Settled",
            "TrxInitiation": "",
            "TrxResponse": {
                "AVSAddressResponse": "X",
                "AVSZipResponse": "X",
                "AuthCode": "010101",
                "CVV2Response": "",
                "CardType": "",
                "ExpectedSettledTime": "2018-04-16T02:00:00.0000000Z",
                "FinalAmount": "1.60",
                "IAVSAddressResponse": "N",
                "Message": "Approved",
                "OrigTrxAmount": "1.60",
                "OriginationID": "A50E0A0BF007",
                "PayFabricErrorCode": null,
                "RespTrxTag": null,
                "ResultCode": "0",
                "SettledTime": "2020-07-28T00:00:00.0000000Z",
                "Status": "Approved",
                "SurchargeAmount": "0",
                "SurchargePercentage": "0",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "1.60",
                "TrxDate": "4/15/2018 1:00:00 AM",
                "TrxKey": "18110500693851",
                "WalletID": null
            },
            "TrxSchedule": "",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Sale"
        },
        {
            "Amount": "1.35",
            "AuthorizationType": "",
            "BatchNumber": "",
            "CCEntryIndicator": "",
            "Card": {
                "Aba": "XXXXX0730",
                "Account": "XXXXXXX1111",
                "AccountType": "",
                "Billto": {
                    "City": "CA",
                    "Country": "US",
                    "Customer": "",
                    "Email": "success+test@simulator.amazonses.com",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "LINE1",
                    "Line2": "LINE12",
                    "Line3": "LINE13",
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "Phone": "123456789",
                    "State": "CA",
                    "Zip": "123456"
                },
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "FN",
                    "LastName": "LN",
                    "MiddleName": "",
                    "SSN": ""
                },
                "CardName": "ECheck",
                "CardType": "",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "ExpDate": "",
                "GPAddressCode": null,
                "GatewayToken": null,
                "ID": "00000000-0000-0000-0000-000000000000",
                "Identifier": null,
                "IsDefaultCard": false,
                "IsLocked": false,
                "IsSaveCard": false,
                "IssueNumber": null,
                "LastUsedDate": "1/1/0001 12:00:00 AM",
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "NewCustomerNumber": null,
                "StartDate": null,
                "Tender": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null
            },
            "CardHolderAttendance": "",
            "CardType": "",
            "Currency": "USD",
            "Customer": "AARONFIT0001",
            "Document": {
                "DefaultBillTo": null,
                "Head": [
                    {
                        "Name": "InvoiceNumber",
                        "Value": "1105004557"
                    },
                    {
                        "Name": "PONumber",
                        "Value": "PO00001"
                    },
                    {
                        "Name": "ShipFromZip",
                        "Value": "222222222"
                    },
                    {
                        "Name": "VATTaxAmount",
                        "Value": "1.00"
                    }
                ],
                "Lines": [
                    {
                        "Columns": [
                            {
                                "Name": "ItemQuantity",
                                "Value": "2"
                            },
                            {
                                "Name": "ItemDesc",
                                "Value": "ItemDesc"
                            },
                            {
                                "Name": "ItemCost",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemProdCode",
                                "Value": "A100"
                            },
                            {
                                "Name": "ItemUOM",
                                "Value": "Each"
                            },
                            {
                                "Name": "ItemSKU",
                                "Value": "A100"
                            },
                            {
                                "Name": "ItemAmount",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemTaxAmount",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemDiscount",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemFreightAmount",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemHandlingAmount",
                                "Value": "1"
                            }
                        ],
                        "UserDefined": [
                            {
                                "Name": "UserDefinedLine1",
                                "Value": "UserDefine1"
                            },
                            {
                                "Name": "UserDefinedLine2",
                                "Value": "UserDefine2"
                            },
                            {
                                "Name": "UserDefinedLine1",
                                "Value": "UserDefine3"
                            },
                            {
                                "Name": "UserDefinedLine2",
                                "Value": "UserDefine4"
                            }
                        ]
                    }
                ],
                "UserDefined": []
            },
            "ECheckSetupId": "",
            "EntryClass": "",
            "EntryMode": "API",
            "Key": "18110500694637",
            "MSO_EngineGUID": "1c0b32c2-1508-4ab5-96c9-57b782933db6",
            "ModifiedOn": "11/5/2018 12:46:00 AM",
            "OrigTrxAmount": "1.35",
            "PayDate": "",
            "ReferenceKey": null,
            "ReferenceTrxs": null,
            "ReqAuthCode": "",
            "SetupId": "USASOAPECheck",
            "Shipto": {
                "City": "SPCA",
                "Country": "SPUS",
                "Customer": "",
                "Email": "success+shipto@simulator.amazonses.com",
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "SPLINE1",
                "Line2": "SPLINE12",
                "Line3": "SPLINE13",
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "Phone": "999999999",
                "State": "SPCA",
                "Zip": "SP123456"
            },
            "SurchargeAmount": "",
            "SurchargePercentage": null,
            "Tender": "ECheck",
            "TransactionState": "Settled",
            "TrxInitiation": "",
            "TrxResponse": {
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "AuthCode": "TM93EA",
                "CVV2Response": "",
                "CardType": "",
                "ExpectedSettledTime": "2018-04-15T08:30:00.0000000Z",
                "FinalAmount": "1.35",
                "IAVSAddressResponse": "",
                "Message": "",
                "OrigTrxAmount": "1.35",
                "OriginationID": "3099046187",
                "PayFabricErrorCode": null,
                "RespTrxTag": null,
                "ResultCode": "Approved, A",
                "SettledTime": "2020-07-28T01:30:00.0000000Z",
                "Status": "Approved",
                "SurchargeAmount": "0",
                "SurchargePercentage": "0",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "1.35",
                "TrxDate": "4/15/2018 1:00:00 AM",
                "TrxKey": "18110500694637",
                "WalletID": null
            },
            "TrxSchedule": "",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Sale"
        }
    ]
}
</pre>


Referenced Transaction(s): Capture (Ship), Void or Refund (Credit)
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Refund (Credit). They all use the transaction Key from the original transaction to process the new transaction.

#### Capture (Ship)

* `GET /payment/api/reference/{TransactionKey}?trxtype=Capture` will attempt to execute and finalize (capture) an authorization transaction, also known as Book transactions.
* `POST /payment/api/transaction/process` will attempt to execute and finalize (capture) a pre-authorized transaction with specific amount, if `Amount` is not provided in request body, it will capture with authorized amount. if `Amount` is provoided in request body, it could be able to capture an authorization transaction multiple times, which depends on what gateway been used. (Note: Following gateways support multiple captures, Authorize.Net, USAePay & Payeezy (aka First Data GGE4).)

###### Request
<pre>
{
  "Amount": "1",
  "Type": "Capture",
  "ReferenceKey": "151013003792",
   "Document": {
    "Head": [ 
        {
                <b>"Name":"CaptureComplete",</b>
               <b> "Value":false</b>
        }
     ],   
  }
}
</pre>
<b>Note:</b> CaptureComplete = true means this is the last capture transaction, no capture allowed for the original authorization transaction; CaptureComplete = false means this is not the last capture transaction, it allows to do multiple captures for the original authorization transaction. CaptureComplete will be set to true if pass invalid value or don't pass any value. For **EVO gateway profile**, If over capture or transactions include tip amount or incremental amount, CaptureComplete will be set to true automatically whatever the input value is. This logic is not applied with other gateways' transactions other than EVO.

* `GET /payment/api/reference/{TransactionKey}?trxtype=VOID` or `POST /transaction/process` with following request will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.

###### Request
<pre>
{
  "Type": "Void",
  "ReferenceKey": "151013003792"
}
</pre>

* `GET /payment/api/reference/{TransactionKey}?trxtype=Refund` or `POST /transaction/process` with following request will attempt to credit a transaction that has already been submitted to a payment gateway and has been settled from the bank. PayFabric attempts to submit a CREDIT transaction for the same exact amount as the original SALE transaction.

###### Request
<pre>
{
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

or 

<pre>
{
  "Amount":"1",
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

Note: `ReferenceKey` is the initial processed transaction's `TrxKey`. If `Amount` is not provided in request body for Refund transaction, it will processed with original transaction amount. If `Amount` is provided, it will process partial refund with the specific amount.

###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "21.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "21.00",
    "OriginationID": "A41E0E04DA9E",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "21.00",
    "TrxDate": "7/1/2021 10:52:15 PM",
    "TrxKey": "21070100732374",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>

Refund a Customer
-----------------

To refund a customer, you just submit a credit to the customer that is owed the refund. The amount of the transaction should match the amount that is due to the customer. To perform a Refund transaction, you just create a transaction object, set the `Type` field to `Refund`, and then use [Create and Process a Transaction](#create-and-process-a-transaction) to execute the transaction.

* `POST /payment/api/transaction/process?cvc={CVCValue}`

###### Request
<pre>
{
    "SetupId": "EVO",
    <b>"Type": "Refund"</b>,
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
    "CardType": "Credit",
    "FinalAmount": "104.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "AD0D53935734451D86011AF6D0BDF46C",
    "PayFabricErrorCode": null,
    "RespTrxTag": "8/5/2020 5:00:23 AM",
    "ResultCode": "1",
    "Status": "Approved",
    "SurchargeAmount": "4.00",
    "SurchargePercentage": "4.0",
    "TAXml":"",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "104.00",
    "TrxDate": "8/4/2020 11:00:23 PM",
    "TrxKey": "20080400045866"
}
</pre>
