Query Transactions With filters
=================

The PayFabric transaction inquiry APIs are used for inquiry PayFabric transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer to the [Transaction Object](/PayFabric/Sections/Objects.md#transaction) for details.

Search for Future Dated Transactions
-------------------------------------
* `GET /payment/3.1/api/Transaction/Transactions?pageSize=13&pageidx=1` Get a list of transactions. The max from-date and to-date range is 6 months.

###### Response
<pre>
  {
    "Records": [
        {
            "TrxResponse": {
                "TrxKey": "23051501320858",
                "Status": "Approved",
                "OriginationID": "A20E3AC23123",
                "RespTrxTag": null,
                "AuthCode": "010101",
                "ResultCode": "0",
                "Message": "Approved",
                "CVV2Response": "",
                "AVSAddressResponse": "Y",
                "AVSZipResponse": "Y",
                "IAVSAddressResponse": "N",
                "PayFabricErrorCode": null,
                "TrxDate": "5/16/2023 1:40:55 AM",
                "TrxDateUTC": "2023-05-16T05:40:55.164Z",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "5.52",
                "SurchargeAmount": "0.00",
                "SurchargePercentage": "0.00",
                "OrigTrxAmount": "5.52",
                "CardType": "Credit",
                "FinalAmount": "5.52",
                "ExpectedSettledTime": "5/16/2023 11:00:00 PM",
                "ExpectedSettledTimeUTC": "2023-05-17T03:00:00.000",
                "SettledTime": "5/16/2023 11:00:00 PM",
                "SettledTimeUTC": "2023-05-17T03:00:00.000",
                "WalletID": null,
                "RemainingBalance": null
            },
            "Card": {
                "Billto": {
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "123 TEST LINE1 update",
                    "Line2": "123 TEST LINE2 update",
                    "Line3": "123 Test LINE3 update",
                    "State": "USA",
                    "City": "CN",
                    "Country": "USA",
                    "Zip": "111111",
                    "Email": "test@sample.com",
                    "Phone": "",
                    "Customer": ""
                },
                "ID": "fd9ce092-027c-42f1-ad47-419a7618aeec",
                "Customer": "",
                "Tender": null,
                "Account": "XXXXXXXXXXXX1111",
                "CardName": "Visa",
                "ExpDate": "1123",
                "CheckNumber": "",
                "AccountType": "",
                "Aba": "",
                "Connector": null,
                "GatewayToken": null,
                "CVC": null,
                "Identifier": null,
                "IssueNumber": null,
                "GPAddressCode": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null,
                "CardHolder": {
                    "FirstName": "FN230516134052",
                    "MiddleName": "M",
                    "LastName": "LN230516134052",
                    "DriverLicense": "",
                    "SSN": ""
                },
                "IsSaveCard": false,
                "IsDefaultCard": false,
                "IsLocked": false,
                "LastUsedDate": "5/16/2023 1:40:55 AM",
                "CardType": "Credit",
                "LastUsedDateUTC": "2023-05-16T05:40:55.176Z",
                "EncryptedToken": null
            },
            "Shipto": {
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
                "Customer": ""
            },
            "Key": "23051501320858",
            "ReferenceKey": null,
            "Customer": "API230516134046",
            "BatchNumber": "",
            "SetupId": "PayFlowProCredit",
            "ECheckSetupId": "",
            "GiftCardSetupId": "",
            "MSO_EngineGUID": "e2e7b828-9f1e-447a-86d1-d15fbb844eb9",
            "Tender": "CreditCard",
            "Type": "Sale",
            "Currency": "USD",
            "Amount": "5.52",
            "ReqAuthCode": "",
            "PayDate": "",
            "PayDateUTC": "",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Document": {
                "Head": [                   
                    {
                        "Name": "InvoiceNumber",
                        "Value": "1"
                    },                    
                    {
                        "Name": "DutyAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "FreightAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "TaxExempt",
                        "Value": "1"
                    },
                     {
                        "Name": "TaxAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "DutyAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "FreightAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "TaxExempt",
                        "Value": "1"
                    }                   
                ],
                "Lines": [
                    {
                        "Columns": [
                            {
                                "Name": "ItemQuantity",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemUPC",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemDesc",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemUOM",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemCost",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemDiscount",
                                "Value": "1"
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
                                "Name": "ItemCommodityCode",
                                "Value": "1"
                            },
                            {
                                "Name": "ItemTaxRate",
                                "Value": "1"
                            }
                        ],
                        "UserDefined": []
                    }
                ],
                "UserDefined": [
                    {
                        "Name": "ThirdPartyBatch",
                        "Value": null
                    }
                ],
                "DefaultBillTo": null
            },
            "ModifiedOn": "5/16/2023 1:40:55 AM",
            "ModifiedOnUTC": "2023-05-16T05:40:55.176Z",
            "ReferenceTrxs": [],
            "TrxInitiation": "Customer",
            "TrxSchedule": "Unscheduled",
            "AuthorizationType": "NotSet",
            "CCEntryIndicator": "Stored",
            "CardHolderAttendance": "NotSet",
            "SurchargePercentage": "0.00",
            "SurchargeAmount": "0.00",
            "CardType": "Credit",
            "OrigTrxAmount": "5.52",
            "EntryClass": "",
            "TransactionState": "Settled",
            "EntryMode": "API",
            "TransationStateHistory": [
                {
                    "CommittedStateTime": "5/16/2023 1:40:55 AM",
                    "CommittedStateTimeUTC": "2023-05-16T05:40:55.000Z",
                    "TransactionState": "Pending Settlement",
                    "Amount": "5.52"
                },
                {
                    "CommittedStateTime": "5/16/2023 11:00:00 PM",
                    "CommittedStateTimeUTC": "2023-05-17T03:00:00.000Z",
                    "TransactionState": "Settled",
                    "Amount": "5.52"
                }
            ]
        }
        ...

    ],
    "Paging": {
        "Size": "13",
        "Current": "1",
        "TotalRecords": "32312",
        "TotalPages": "2486"
    }
}
</pre>

**Available Queries**
| Query  | Data Type| Definition|
| :-----------|:---------| :---------| 
| pageSize         | Int | Specifies the returned page size. The default and Maximum is 15. |
|pageIdx|Int|Specifies the returned page index. Default to 1.|
|fromAmount|Decimal||



