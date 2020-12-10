Transactions
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

`SetupId` is a per-account setting which can be found in the PayFabric website by clicking "Settings" in the left navigation, "Gateway Account Configuration", and finally "Gateway Profile" under the gateway you wish to use.  The value from the "Name/Setup ID" field, should replace "PFP" in the transaction request example.

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

###### Response Header
If update transaction with the gateway whose SurchargeRate greater than 0, and populated a credit card on this transaction, then PayFabric will return the surcharge fields in Response Header like below screenshot.

![CreateUpdateTrxWithSurchargeResponseHeader](https://raw.githubusercontent.com/PayFabric/Portal/master/PayFabric/Sections/Screenshots/CreateUpdateTrxWithSurchargeResponseHeader.png "CreateUpdateTrxWithSurchargeResponseHeader") 

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
    "AuthCode": "S39FGQ",
    "CVV2Response": "NotSet",
    "CardType": "Credit",
    "FinalAmount": "104.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "F6D5C44B7460414AB0954742A16E4FD5",
    "PayFabricErrorCode": null,
    "RespTrxTag": "8/5/2020 4:43:47 AM",
    "ResultCode": "1",
    "Status": "Approved",
    "SurchargeAmount": "4.00",
    "SurchargePercentage": "4.0",
    "TAXml":"",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "104.00",
    "TrxDate": "8/4/2020 10:43:47 PM",
    "TrxKey": "20080400045853"
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


###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": "S39FGQ",
    "CVV2Response": "NotSet",
    "CardType": "Credit",
    "FinalAmount": "104.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "F6D5C44B7460414AB0954742A16E4FD5",
    "PayFabricErrorCode": null,
    "RespTrxTag": "8/5/2020 4:43:47 AM",
    "ResultCode": "1",
    "Status": "Approved",
    "SurchargeAmount": "4.00",
    "SurchargePercentage": "4.0",
    "TAXml":"",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "104.00",
    "TrxDate": "8/4/2020 10:43:47 PM",
    "TrxKey": "20080400045853"
}
</pre>


Retrieve a Transaction
----------------------

* `GET /transaction/{TransactionKey}` will return the specified transaction

###### Response
<pre>
{
    "Amount": "104.00",
    "AuthorizationType": "NotSet",
    "BatchNumber": "",
    "CCEntryIndicator": "Entered",
    "Card": {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "Billto": {
            "City": "1",
            "Country": "1",
            "Customer": "",
            "Email": "",
            "ID": "00000000-0000-0000-0000-000000000000",
            "Line1": "1",
            "Line2": "",
            "Line3": "",
            "ModifiedOn": "1/1/0001 12:00:00 AM",
            "Phone": "1",
            "State": "1",
            "Zip": "50000"
        },
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "1",
            "LastName": "1",
            "MiddleName": "",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "Credit",
        "CheckNumber": "",
        "Connector": "EVO",
        "Customer": "JOHNDOE0001",
        "ExpDate": "1122",
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
    "CardType": "Credit",
    "Currency": "USD",
    "Customer": "JOHNDOE0001",
    "Document": {
        "DefaultBillTo": null,
        "Head": [
            {
                "Name": "PONumber",
                "Value": "0"
            },
            {
                "Name": "ShipToZip",
                "Value": "0"
            },
            {
                "Name": "TaxAmount",
                "Value": "0"
            },
            {
                "Name": "DutyAmount",
                "Value": "0"
            },
            {
                "Name": "FreightAmount",
                "Value": "0"
            },
            {
                "Name": "CustomerCode",
                "Value": ""
            },
            {
                "Name": "DiscountAmount",
                "Value": "0"
            },
            {
                "Name": "ShipFromZip",
                "Value": "0"
            },
            {
                "Name": "CompanyName",
                "Value": "0"
            },
            {
                "Name": "ShipToCountry",
                "Value": "0"
            },
            {
                "Name": "HandlingAmount",
                "Value": "0"
            },
            {
                "Name": "TaxRate",
                "Value": "0"
            },
            {
                "Name": "TaxExemptNumber",
                "Value": "0"
            },
            {
                "Name": "InvoiceNumber",
                "Value": ""
            }
        ],
        "Lines": [
            {
                "Columns": [
                    {
                        "Name": "ItemQuantity",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemUPC",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemDesc",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemUOM",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemCost",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemProdCode",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemDiscount",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemTaxAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemCommodityCode",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemTaxRate",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemInvoiceNumber",
                        "Value": "0"
                    },
                    {
                        "Name": "ItemAmount",
                        "Value": "0"
                    }
                ],
                "UserDefined": []
            }
        ],
        "UserDefined": [
            {
                "Name": null,
                "Value": null
            }
        ]
    },
    "EntryClass": null,
    "Key": "20080400045853",
    "MSO_EngineGUID": "bb373958-aa49-40d5-b515-8e4d96836c88",
    "ModifiedOn": "8/4/2020 10:43:47 PM",
    "OrigTrxAmount": "100.00",
    "PayDate": "",
    "ReferenceKey": null,
    "ReferenceTrxs": [],
    "ReqAuthCode": "",
    "SetupId": "EVO",
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
    "SurchargeAmount": "4.00",
    "SurchargePercentage": "4.0",
    "Tender": "CreditCard",
    "TrxInitiation": "Customer",
    "TrxResponse": {
        "AVSAddressResponse": "",
        "AVSZipResponse": "",
        "AuthCode": "S39FGQ",
        "CVV2Response": "NotSet",
        "CardType": "Credit",
        "FinalAmount": "104.00",
        "IAVSAddressResponse": "",
        "Message": "APPROVED",
        "OrigTrxAmount": "100.00",
        "OriginationID": "F6D5C44B7460414AB0954742A16E4FD5",
        "PayFabricErrorCode": null,
        "RespTrxTag": "8/5/2020 4:43:47 AM",
        "ResultCode": "1",
        "Status": "Approved",
        "SurchargeAmount": "4.00",
        "SurchargePercentage": "4.00",  
        "TAXml":"",
        "TerminalID": "",
        "TerminalResultCode": "",
        "TrxAmount": "104.00",
        "TrxDate": "8/4/2020 10:43:47 PM",
        "TrxKey": "20080400045853"
    },
    "TrxSchedule": "Unscheduled",
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
|pagesize|This parameter is to set specific page size, maximum value is 15.|
|enddate|This parameter is to set a specific 'date to' to filter transactions, The format: mm/dd/yyyy. |

###### Response
<pre>
{
    "Paging": {
        "Current": "1",
        "Size": "15",
        "TotalPages": "1",
        "TotalRecords": "1"
    },
    "Records": [
        {
            "Amount": "104.00",
            "AuthorizationType": "NotSet",
            "BatchNumber": "",
            "CCEntryIndicator": "Entered",
            "Card": {
                "Aba": "",
                "Account": "XXXXXXXXXXXX1111",
                "AccountType": "",
                "Billto": {
                    "City": "1",
                    "Country": "1",
                    "Customer": "",
                    "Email": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "1",
                    "Line2": "",
                    "Line3": "",
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "Phone": "1",
                    "State": "1",
                    "Zip": "50000"
                },
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "1",
                    "LastName": "1",
                    "MiddleName": "",
                    "SSN": ""
                },
                "CardName": "Visa",
                "CardType": "Credit",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "ExpDate": "1122",
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
            "CardType": "Credit",
            "Currency": "USD",
            "Customer": "JOHNDOE0001",
            "Document": {
                "DefaultBillTo": null,
                "Head": [
                    {
                        "Name": "PONumber",
                        "Value": "0"
                    },
                    {
                        "Name": "ShipToZip",
                        "Value": "0"
                    },
                    {
                        "Name": "TaxAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "DutyAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "FreightAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "CustomerCode",
                        "Value": ""
                    },
                    {
                        "Name": "DiscountAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "ShipFromZip",
                        "Value": "0"
                    },
                    {
                        "Name": "CompanyName",
                        "Value": "0"
                    },
                    {
                        "Name": "ShipToCountry",
                        "Value": "0"
                    },
                    {
                        "Name": "HandlingAmount",
                        "Value": "0"
                    },
                    {
                        "Name": "TaxRate",
                        "Value": "0"
                    },
                    {
                        "Name": "TaxExemptNumber",
                        "Value": "0"
                    },
                    {
                        "Name": "InvoiceNumber",
                        "Value": ""
                    }
                ],
                "Lines": [
                    {
                        "Columns": [
                            {
                                "Name": "ItemQuantity",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemUPC",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemDesc",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemUOM",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemCost",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemProdCode",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemDiscount",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemTaxAmount",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemCommodityCode",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemTaxRate",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemInvoiceNumber",
                                "Value": "0"
                            },
                            {
                                "Name": "ItemAmount",
                                "Value": "0"
                            }
                        ],
                        "UserDefined": []
                    }
                ],
                "UserDefined": [
                    {
                        "Name": null,
                        "Value": null
                    }
                ]
            },
            "EntryClass": null,
            "Key": "20080400045853",
            "MSO_EngineGUID": "bb373958-aa49-40d5-b515-8e4d96836c88",
            "ModifiedOn": "8/4/2020 10:43:47 PM",
            "OrigTrxAmount": "100.00",
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
            "SurchargeAmount": "4.00",
            "SurchargePercentage": "4.0",
            "Tender": "CreditCard",
            "TrxInitiation": "Customer",
            "TrxResponse": {
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "AuthCode": "S39FGQ",
                "CVV2Response": "NotSet",
                "CardType": "Credit",
                "FinalAmount": "104.00",
                "IAVSAddressResponse": "",
                "Message": "APPROVED",
                "OrigTrxAmount": "100.00",
                "OriginationID": "F6D5C44B7460414AB0954742A16E4FD5",
                "PayFabricErrorCode": null,
                "RespTrxTag": null,
                "ResultCode": "1",
                "Status": "Approved",
                "SurchargeAmount": "4.00",
                "SurchargePercentage": "4.00",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "104.00",
                "TrxDate": "8/4/2020 10:43:47 PM",
                "TrxKey": "20080400045853"
            },
            "TrxSchedule": "Unscheduled",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Sale"
        }
    ]
}
</pre>


Referenced Transaction(s): Capture (Ship), Void or Credit (Refund)
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Credit (Refund). They all use the transaction Key from the original transaction to process the new transaction.

#### Capture (Ship)

* `GET /reference/151013003792?trxtype=Capture` will attempt to execute and finalize (capture) an authorization transaction, also known as Book transactions.
* `POST /transaction/process` will attempt to execute and finalize (capture) a pre-authorized transaction with specific amount, if `Amount` is not provided in request body, it will capture with authorized amount. if `Amount` is provoided in request body, it could be able to capture an authorization transaction multiple times, which depends on what gateway been used. (Note: Following gateways support multiple captures, Authorize.Net, USAePay & Payeezy(aka First Data GGE4).)

###### Request
<pre>
{
  "Amount": "1",
  "Type": "Capture",
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

* `GET /reference/151013003792?trxtype=Refund` or `POST /transaction/process` with following request will attempt to credit a transaction that has already been submitted to a payment gateway and has been settled from the bank. PayFabric attempts to submit a CREDIT transaction for the same exact amount as the original SALE transaction.

###### Request
<pre>
{
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

Note: `ReferenceKey` is the initial processed transaction's `TrxKey`.

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

If `Amount` is not provided in request body for Refund transaction, it will processed with original transaction amount.

Refund a Customer
-----------------

To refund a customer, you just submit a credit to the customer that is owed the refund. The amount of the transaction should match the amount that is due to the customer. To perform a Refund transaction, you just create a transaction object, set the `Type` field to `Refund`, and then use [Create and Process a Transaction](#create-and-process-a-transaction) to execute the transaction.

* `POST /transaction/process?cvc=111`

###### Request
<pre>
{
    "SetupId": "PFP",
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
