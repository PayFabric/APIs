Batch
=================

The PayFabric Batch APIs are used for managing PayFabric batch transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer the [Batch Object](/PayFabric/Sections/3.1JSONObjects.md#batch) for details.

Get Current Batches
-------------------
* `GET /payment/3.1/api/Transaction/Batch` Get the current active batches that have pending transactions.
###### Response 
<pre>
[
    {
        "BatchId": "20210704",
        "Summary": {
            "Count": 2,
            "Approved": 0,
            "Declined": 0,
            "Failed": 0,
            "Open": 2,
            "CaptureReady": 0,
            "NetAmount": 0.04
        },
        "Transactions": [
            {
                "Key": "21070450001582",
                "ReferenceKey": null,
                "Customer": "AA",
                "BatchNumber": "20210704",
                "SetupId": "EVO",
                "ECheckSetupId": "",
                "MSO_EngineGUID": "f4539566-8f8c-4cc7-a695-7e6491de8bf2",
                "Tender": "CreditCard",
                "Type": "Sale",
                "Currency": "USD",
                "Amount": "0.02",
                "ReqAuthCode": "",
                "PayDate": "",
                "TrxUserDefine1": "",
                "TrxUserDefine2": "",
                "TrxUserDefine3": "",
                "TrxUserDefine4": "",
                "Card": {
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Customer": "AA",
                    "NewCustomerNumber": null,
                    "Tender": "CreditCard",
                    "Account": "XXXXXXXXXXXX1111",
                    "CardName": "Visa",
                    "ExpDate": "1222",
                    "CheckNumber": "",
                    "AccountType": "",
                    "Aba": "",
                    "Connector": "EVO",
                    "GatewayToken": "",
                    "Identifier": "",
                    "IssueNumber": "",
                    "StartDate": "",
                    "GPAddressCode": "",
                    "UserDefine1": "",
                    "UserDefine2": "",
                    "UserDefine3": "",
                    "UserDefine4": "",
                    "CardHolder": {
                        "FirstName": "Rena",
                        "MiddleName": "",
                        "LastName": "u",
                        "DriverLicense": "",
                        "SSN": ""
                    },
                    "Billto": {
                        "Customer": "",
                        "ID": "00000000-0000-0000-0000-000000000000",
                        "Line1": "",
                        "Line2": "",
                        "Line3": "",
                        "State": "",
                        "City": "",
                        "Country": "",
                        "Zip": "4444444",
                        "Email": "",
                        "Phone": "",
                        "ModifiedOn": "1/1/0001 12:00:00 AM"
                    },
                    "IsSaveCard": false,
                    "IsDefaultCard": false,
                    "IsLocked": false,
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "LastUsedDate": "1/1/0001 12:00:00 AM",
                    "CardType": ""
                },
                "Shipto": {
                    "Customer": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "",
                    "Line2": "",
                    "Line3": "",
                    "State": "",
                    "City": "",
                    "Country": "",
                    "Zip": "",
                    "Email": "",
                    "Phone": "",
                    "ModifiedOn": "1/1/0001 12:00:00 AM"
                },
                "TrxResponse": {
                    "TrxKey": "21070450001582",
                    "Status": "UnProcess",
                    "OriginationID": "",
                    "RespTrxTag": "",
                    "AuthCode": "",
                    "ResultCode": "",
                    "Message": "",
                    "CVV2Response": "",
                    "AVSAddressResponse": "",
                    "AVSZipResponse": "",
                    "IAVSAddressResponse": "",
                    "PayFabricErrorCode": null,
                    "TrxDate": null,
                    "TAXml": "",
                    "TerminalID": "",
                    "TerminalResultCode": "",
                    "TrxAmount": "0.02",
                    "SurchargeAmount": "0.00",
                    "SurchargePercentage": "0.00",
                    "OrigTrxAmount": "0.02",
                    "CardType": "",
                    "FinalAmount": "0.02",
                    "ExpectedSettledTime": null,
                    "SettledTime": null,
                    "WalletID": null
                },
                "Document": {
                    "Head": [
                        {
                            "Name": "CustomerCode",
                            "Value": "AA"
                        },
                        {
                            "Name": "TaxAmount",
                            "Value": "3"
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
                                    "Name": "ItemCost",
                                    "Value": "0.02"
                                },
                                {
                                    "Name": "ItemDesc",
                                    "Value": "4"
                                },
                                {
                                    "Name": "ItemProdCode",
                                    "Value": "4"
                                },
                                {
                                    "Name": "ItemQuantity",
                                    "Value": "4"
                                },
                                {
                                    "Name": "ItemAmount",
                                    "Value": "0.02"
                                }
                            ],
                            "UserDefined": []
                        }
                    ],
                    "UserDefined": [],
                    "DefaultBillTo": null
                },
                "ModifiedOn": "7/4/2021 6:37:49 PM",
                "ReferenceTrxs": [],
                "TrxInitiation": "Customer",
                "TrxSchedule": "Scheduled",
                "AuthorizationType": "NotSet",
                "CCEntryIndicator": "Entered",
                "CardHolderAttendance": "",
                "SurchargePercentage": "0.0",
                "SurchargeAmount": "0.00",
                "CardType": "",
                "OrigTrxAmount": "0.02",
                "EntryClass": "",
                "TransactionState": "",
                "EntryMode": "ModernVT"
            },
            {
                "Key": "21070450001581",
                "ReferenceKey": null,
                "Customer": "AA",
                "BatchNumber": "20210704",
                "SetupId": "EVO",
                "ECheckSetupId": "",
                "MSO_EngineGUID": "f4539566-8f8c-4cc7-a695-7e6491de8bf2",
                "Tender": "CreditCard",
                "Type": "Sale",
                "Currency": "USD",
                "Amount": "0.02",
                "ReqAuthCode": "",
                "PayDate": "",
                "TrxUserDefine1": "",
                "TrxUserDefine2": "",
                "TrxUserDefine3": "",
                "TrxUserDefine4": "",
                "Card": {
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Customer": "AA",
                    "NewCustomerNumber": null,
                    "Tender": "CreditCard",
                    "Account": "XXXXXXXXXXXX1111",
                    "CardName": "Visa",
                    "ExpDate": "1222",
                    "CheckNumber": "",
                    "AccountType": "",
                    "Aba": "",
                    "Connector": "EVO",
                    "GatewayToken": "",
                    "Identifier": "",
                    "IssueNumber": "",
                    "StartDate": "",
                    "GPAddressCode": "",
                    "UserDefine1": "",
                    "UserDefine2": "",
                    "UserDefine3": "",
                    "UserDefine4": "",
                    "CardHolder": {
                        "FirstName": "Rena",
                        "MiddleName": "",
                        "LastName": "u",
                        "DriverLicense": "",
                        "SSN": ""
                    },
                    "Billto": {
                        "Customer": "",
                        "ID": "00000000-0000-0000-0000-000000000000",
                        "Line1": "",
                        "Line2": "",
                        "Line3": "",
                        "State": "",
                        "City": "",
                        "Country": "",
                        "Zip": "1234",
                        "Email": "",
                        "Phone": "",
                        "ModifiedOn": "1/1/0001 12:00:00 AM"
                    },
                    "IsSaveCard": false,
                    "IsDefaultCard": false,
                    "IsLocked": false,
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "LastUsedDate": "1/1/0001 12:00:00 AM",
                    "CardType": ""
                },
                "Shipto": {
                    "Customer": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "",
                    "Line2": "",
                    "Line3": "",
                    "State": "",
                    "City": "",
                    "Country": "",
                    "Zip": "",
                    "Email": "",
                    "Phone": "",
                    "ModifiedOn": "1/1/0001 12:00:00 AM"
                },
                "TrxResponse": {
                    "TrxKey": "21070450001581",
                    "Status": "UnProcess",
                    "OriginationID": "",
                    "RespTrxTag": "",
                    "AuthCode": "",
                    "ResultCode": "",
                    "Message": "",
                    "CVV2Response": "",
                    "AVSAddressResponse": "",
                    "AVSZipResponse": "",
                    "IAVSAddressResponse": "",
                    "PayFabricErrorCode": null,
                    "TrxDate": null,
                    "TAXml": "",
                    "TerminalID": "",
                    "TerminalResultCode": "",
                    "TrxAmount": "0.02",
                    "SurchargeAmount": "0.00",
                    "SurchargePercentage": "0.00",
                    "OrigTrxAmount": "0.02",
                    "CardType": "",
                    "FinalAmount": "0.02",
                    "ExpectedSettledTime": null,
                    "SettledTime": null,
                    "WalletID": null
                },
                "Document": {
                    "Head": [
                        {
                            "Name": "CustomerCode",
                            "Value": "AA"
                        },
                        {
                            "Name": "TaxAmount",
                            "Value": "3"
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
                                    "Name": "ItemCost",
                                    "Value": "0.02"
                                },
                                {
                                    "Name": "ItemDesc",
                                    "Value": "3"
                                },
                                {
                                    "Name": "ItemProdCode",
                                    "Value": "3"
                                },
                                {
                                    "Name": "ItemQuantity",
                                    "Value": "3"
                                },
                                {
                                    "Name": "ItemAmount",
                                    "Value": "0.02"
                                }
                            ],
                            "UserDefined": []
                        }
                    ],
                    "UserDefined": [],
                    "DefaultBillTo": null
                },
                "ModifiedOn": "7/4/2021 6:36:29 PM",
                "ReferenceTrxs": [],
                "TrxInitiation": "Customer",
                "TrxSchedule": "Scheduled",
                "AuthorizationType": "NotSet",
                "CCEntryIndicator": "Entered",
                "CardHolderAttendance": "",
                "SurchargePercentage": "0.0",
                "SurchargeAmount": "0.00",
                "CardType": "",
                "OrigTrxAmount": "0.02",
                "EntryClass": "",
                "TransactionState": "",
                "EntryMode": "ModernVT"
            }
        ]
    }
]
</pre>
Process Batch
-------------------
* `POST /payment/3.1/api/Transaction/Batch/Process` Start processing a collection of batches, telling all transactions within the batch to start submitting for authorizations or captures. But for processing the ready for capture transactions, then you have to call this API again.
###### Request
{
    "BatchId": ["20210704"]
}

###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified batch number does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Delete Batch
-------------------
* `DELETE /payment/3.1/api/Transaction/Batch` Delete the specific open batch.
###### Request
<pre>
{
    "BatchId": ["202107043","202107044"]
}
</pre>
###### Response
A successful `DELETE` will result in a HTTP 204 No Content Response.

A failed `DELETE` may result in a HTTP 400 Bad Request Response if the specified batch number does not exist or the batch is already processed or the Device ID used for the Security Token does not match or post failed.

A failed `DELETE` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Search by Batch Number
-------------------
* `GET /payment/3.1/api/Transaction/Batch/{BatchID}` Get transactions for a particular batch id.

###### Response
<pre>
{
    "BatchId": "202107041",
    "Summary": {
        "Count": 1,
        "Approved": 0,
        "Declined": 0,
        "Failed": 1,
        "Open": 0,
        "CaptureReady": 0,
        "NetAmount": 3.00
    },
    "Transactions": [
        {
            "Key": "21071250001944",
            "ReferenceKey": null,
            "Customer": "",
            "BatchNumber": "202107041",
            "SetupId": "EVO",
            "ECheckSetupId": "",
            "MSO_EngineGUID": "f4539566-8f8c-4cc7-a695-7e6491de8bf2",
            "Tender": "CreditCard",
            "Type": "Sale",
            "Currency": "USD",
            "Amount": "3.00",
            "ReqAuthCode": "",
            "PayDate": "",
            "TrxUserDefine1": "",
            "TrxUserDefine2": "",
            "TrxUserDefine3": "",
            "TrxUserDefine4": "",
            "Card": {
                "ID": "00000000-0000-0000-0000-000000000000",
                "Customer": "",
                "NewCustomerNumber": null,
                "Tender": "CreditCard",
                "Account": "XXXXXXXXXXXX1111",
                "CardName": "Visa",
                "ExpDate": "1222",
                "CheckNumber": "",
                "AccountType": "",
                "Aba": "",
                "Connector": "EVO",
                "GatewayToken": "",
                "Identifier": "",
                "IssueNumber": "",
                "StartDate": "",
                "GPAddressCode": "",
                "UserDefine1": "",
                "UserDefine2": "",
                "UserDefine3": "",
                "UserDefine4": "",
                "CardHolder": {
                    "FirstName": "Rena",
                    "MiddleName": "",
                    "LastName": "u",
                    "DriverLicense": "",
                    "SSN": ""
                },
                "Billto": {
                    "Customer": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "98765 Crossway Park Dr",
                    "Line2": "",
                    "Line3": "",
                    "State": "",
                    "City": "ca",
                    "Country": "",
                    "Zip": "55304-9840",
                    "Email": "rena.wu@nodus.com",
                    "Phone": "13125550102",
                    "ModifiedOn": "1/1/0001 12:00:00 AM"
                },
                "IsSaveCard": false,
                "IsDefaultCard": false,
                "IsLocked": false,
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "LastUsedDate": "1/1/0001 12:00:00 AM",
                "CardType": "Credit"
            },
            "Shipto": {
                "Customer": "",
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "",
                "Line2": "",
                "Line3": "",
                "State": "",
                "City": "",
                "Country": "",
                "Zip": "",
                "Email": "",
                "Phone": "",
                "ModifiedOn": "1/1/0001 12:00:00 AM"
            },
            "TrxResponse": {
                "TrxKey": "21071250001944",
                "Status": "Failure",
                "OriginationID": "",
                "RespTrxTag": "",
                "AuthCode": "",
                "ResultCode": "",
                "Message": "Transaction fails: ServiceId is required.",
                "CVV2Response": "",
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "IAVSAddressResponse": "",
                "PayFabricErrorCode": null,
                "TrxDate": "7/12/2021 6:07:00 AM",
                "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"4\"><NeededData><Transaction><Type>1</Type><Status>Failure</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Failure</Status><Category>FailureData</Category><Fields><Field id=\"TrxField_F1\"><Name>Connection</Name><Desc>ServiceId is required.</Desc><Value>ServiceId is required.</Value></Field></Fields></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Failure</Status><Category>ResponseData</Category><Fields /></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>4</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>1222</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Rena</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>u</Value></Field><Field id=\"TrxField_D8\"><Name>Address1</Name><Desc>Address 1</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>98765 Crossway Park Dr</Value></Field><Field id=\"TrxField_D11\"><Name>City</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ca</Value></Field><Field id=\"TrxField_D13\"><Name>Zip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>55304-9840</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>3.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D42\"><Name>TaxAmount</Name><Desc>Tax Amount</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>3</Type><Value>3</Value></Field><Field id=\"TrxField_D57\"><Name>EMail</Name><Desc>EMail</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>success+test@simulator.amazonses.com</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D78\"><Name>Phone</Name><Desc>Phone Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>13125550102</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>10.121.34.91</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Customer</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>21071250001944</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D66\" index=\"1\"><Name>ItemCost</Name><Value>3.00</Value></Field><Field id=\"TRXFIELD_D64\" index=\"1\"><Name>ItemDesc</Name><Value>3</Value></Field><Field id=\"TRXFIELD_D67\" index=\"1\"><Name>ItemProdCode</Name><Value>3</Value></Field><Field id=\"TRXFIELD_D62\" index=\"1\"><Name>ItemQuantity</Name><Value>3</Value></Field><Field id=\"TRXFIELD_D69\" index=\"1\"><Name>ItemAmount</Name><Value>3.00</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>Rena u </Value></Field><Field id=\"TRXFIELD_D55\"><Name>AccountStreet</Name><Value>98765 Crossway Park Dr </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>21071250001944</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>f4539566-8f8c-4cc7-a695-7e6491de8bf2</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Scheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2021-07-12 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 6:07:00 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "3.00",
                "SurchargeAmount": "0.00",
                "SurchargePercentage": "0.00",
                "OrigTrxAmount": "3.00",
                "CardType": "Credit",
                "FinalAmount": "3.00",
                "ExpectedSettledTime": null,
                "SettledTime": null,
                "WalletID": null
            },
            "Document": {
                "Head": [
                    {
                        "Name": "TaxAmount",
                        "Value": "3"
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
                                "Name": "ItemCost",
                                "Value": "3.00"
                            },
                            {
                                "Name": "ItemDesc",
                                "Value": "3"
                            },
                            {
                                "Name": "ItemProdCode",
                                "Value": "3"
                            },
                            {
                                "Name": "ItemQuantity",
                                "Value": "3"
                            },
                            {
                                "Name": "ItemAmount",
                                "Value": "3.00"
                            }
                        ],
                        "UserDefined": []
                    }
                ],
                "UserDefined": [],
                "DefaultBillTo": null
            },
            "ModifiedOn": "7/12/2021 6:07:00 AM",
            "ReferenceTrxs": [],
            "TrxInitiation": "Customer",
            "TrxSchedule": "Scheduled",
            "AuthorizationType": "NotSet",
            "CCEntryIndicator": "Entered",
            "CardHolderAttendance": "NotSet",
            "SurchargePercentage": "0.0",
            "SurchargeAmount": "0.00",
            "CardType": "Credit",
            "OrigTrxAmount": "3.00",
            "EntryClass": "",
            "TransactionState": "",
            "EntryMode": "API"
        }
    ]
}
</pre>
