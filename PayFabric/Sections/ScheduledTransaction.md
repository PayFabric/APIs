Transactions Inquiry
=================

The PayFabric transaction inquiry APIs are used for inquiry PayFabric transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer to the [Transaction Object](/PayFabric/Sections/Objects.md#transaction) for details.

Search for Future Dated Transactions
-------------------------------------
* `GET /payment/3.1/api/Transaction/Scheduled?page=1&pagesize=5&fromDate=6-27-2021&toDate=7-1-2021` Get a list of transactions that are scheduled between 2 dates. The max from-date and to-date range is 90 days.

###### Response
<pre>
[
    {
        "Card": {
            "Billto": {
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "2099 State college",
                "Line2": "",
                "Line3": "",
                "State": "ca",
                "City": "Anaheim",
                "Country": "United States",
                "Zip": "92806",
                "Email": "sample@email.com",
                "Phone": "",
                "Customer": ""
            },
            "ID": "00000000-0000-0000-0000-000000000000",
            "Customer": "Rena Test MIT1712",
            "Tender": "CreditCard",
            "Account": "XXXXXXXXXXXX1111",
            "CardName": "Visa",
            "ExpDate": "1123",
            "CheckNumber": "",
            "AccountType": "",
            "Aba": "",
            "Connector": "EVO",
            "GatewayToken": "",
            "Identifier": "",
            "IssueNumber": "",
            "GPAddressCode": "",
            "UserDefine1": "",
            "UserDefine2": "",
            "UserDefine3": "",
            "UserDefine4": "",
            "CardHolder": {
                "FirstName": "1",
                "MiddleName": "",
                "LastName": "11",
                "DriverLicense": "",
                "SSN": ""
            },
            "IsSaveCard": false,
            "IsDefaultCard": false,
            "IsLocked": false,
            "LastUsedDate": "5/25/2022 8:26:10 AM",
            "CardType": "",
            "LastUsedDateUTC": "2022-05-25T05:26:10.826Z",
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
        "Key": "22052301042948",
        "ReferenceKey": null,
        "Customer": "Rena Test MIT1712",
        "BatchNumber": "",
        "SetupId": "EVO",
        "ECheckSetupId": "EVOACH",
        "GiftCardSetupId": "",
        "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
        "Tender": "CreditCard",
        "Type": "Sale",
        "Currency": "USD",
        "Amount": "10.00",
        "ReqAuthCode": "",
        "PayDate": "5/31/2022 12:00:00 AM",
        "PayDateUTC": "2022-05-30T21:00:00.000Z",
        "TrxUserDefine1": "",
        "TrxUserDefine2": "",
        "TrxUserDefine3": "",
        "TrxUserDefine4": "",
        "TrxResponse": {
            "TrxKey": "22052301042948",
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
            "TrxDateUTC": null,
            "TAXml": "",
            "TerminalID": "",
            "TerminalResultCode": "",
            "TrxAmount": "10.00",
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.00",
            "OrigTrxAmount": "10.00",
            "CardType": "",
            "FinalAmount": "10.00",
            "ExpectedSettledTime": null,
            "ExpectedSettledTimeUTC": null,
            "SettledTime": null,
            "SettledTimeUTC": null,
            "WalletID": null,
            "RemainingBalance": null
        },
        "Document": {
            "Head": [
                {
                    "Name": "CustomerCode",
                    "Value": "Rena Test MIT1712"
                },
                {
                    "Name": "InvoiceNumber",
                    "Value": ""
                }
            ],
            "Lines": [
                {
                    "Columns": [],
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
        "ModifiedOn": "5/25/2022 8:26:10 AM",
        "ModifiedOnUTC": "2022-05-25T05:26:10.826Z",
        "ReferenceTrxs": [],
        "TrxInitiation": "Customer",
        "TrxSchedule": "ScheduledInstallment",
        "AuthorizationType": "NotSet",
        "CCEntryIndicator": "Entered",
        "CardHolderAttendance": "ECommerce",
        "SurchargePercentage": "0.0",
        "SurchargeAmount": "0.00",
        "CardType": "",
        "OrigTrxAmount": "10.00",
        "EntryClass": "CCD",
        "TransactionState": "",
        "EntryMode": "ModernVT",
        "TransationStateHistory": []
    },
    {
        "Card": {
            "Billto": {
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
            "ID": "00000000-0000-0000-0000-000000000000",
            "Customer": "",
            "Tender": "CreditCard",
            "Account": "XXXXXXXXXXXX1111",
            "CardName": "Visa",
            "ExpDate": "0123",
            "CheckNumber": "",
            "AccountType": "",
            "Aba": "",
            "Connector": "EVO",
            "GatewayToken": "",
            "Identifier": "",
            "IssueNumber": "",
            "GPAddressCode": "",
            "UserDefine1": "",
            "UserDefine2": "",
            "UserDefine3": "",
            "UserDefine4": "",
            "CardHolder": {
                "FirstName": "123 tes",
                "MiddleName": "",
                "LastName": "dd",
                "DriverLicense": "",
                "SSN": ""
            },
            "IsSaveCard": false,
            "IsDefaultCard": false,
            "IsLocked": false,
            "LastUsedDate": "5/26/2022 2:24:22 PM",
            "CardType": "Credit",
            "LastUsedDateUTC": "2022-05-26T11:24:22.273Z",
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
        "Key": "22052601049281",
        "ReferenceKey": null,
        "Customer": "",
        "BatchNumber": "",
        "SetupId": "EVO",
        "ECheckSetupId": "",
        "GiftCardSetupId": "",
        "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
        "Tender": "CreditCard",
        "Type": "Credit",
        "Currency": "USD",
        "Amount": "100.00",
        "ReqAuthCode": "",
        "PayDate": "5/30/2022 12:00:00 AM",
        "PayDateUTC": "2022-05-29T21:00:00.000Z",
        "TrxUserDefine1": "",
        "TrxUserDefine2": "",
        "TrxUserDefine3": "",
        "TrxUserDefine4": "",
        "TrxResponse": {
            "TrxKey": "22052601049281",
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
            "TrxDateUTC": null,
            "TAXml": "",
            "TerminalID": "",
            "TerminalResultCode": "",
            "TrxAmount": "100.00",
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.00",
            "OrigTrxAmount": "100.00",
            "CardType": "Credit",
            "FinalAmount": "100.00",
            "ExpectedSettledTime": null,
            "ExpectedSettledTimeUTC": null,
            "SettledTime": null,
            "SettledTimeUTC": null,
            "WalletID": null,
            "RemainingBalance": null
        },
        "Document": {
            "Head": [
                {
                    "Name": "InvoiceNumber",
                    "Value": ""
                }
            ],
            "Lines": [
                {
                    "Columns": [],
                    "UserDefined": []
                }
            ],
            "UserDefined": [],
            "DefaultBillTo": null
        },
        "ModifiedOn": "5/26/2022 2:24:22 PM",
        "ModifiedOnUTC": "2022-05-26T11:24:22.273Z",
        "ReferenceTrxs": [],
        "TrxInitiation": "Merchant",
        "TrxSchedule": "Unscheduled",
        "AuthorizationType": "NotSet",
        "CCEntryIndicator": "Entered",
        "CardHolderAttendance": "ECommerce",
        "SurchargePercentage": "0.0",
        "SurchargeAmount": "0.00",
        "CardType": "Credit",
        "OrigTrxAmount": "100.00",
        "EntryClass": "",
        "TransactionState": "",
        "EntryMode": "",
        "TransationStateHistory": []
    }
]
</pre>


Search Transactions with filters
-------------------------------------
* `GET /payment/3.1/api/transaction/Transactions?pageSize=13&pageidx=1&fromAmount=0&toAmount=2&CustomerNo=24023905&EntryMode=API&Status=Approved&Tender=CreditCard&fromDate=2023-9-7&toDate=2023-10-24&TransactionState=Settled&Type=Sale&gatewayname=EvoSnapNoSurcharge&firstname=defaultfn&lastname=defaultln&AccountNo=8456` Get a list of transactions based on the specified filters. The max from-date and to-date range is 6 months.

###### Response
<pre>
{
    "Records": [
        {
            "TrxResponse": {
                "FraudScore": null,
                "IncriminatingText": "",
                "ExoneratingText": "",
                "TrxKey": "23090601350379",
                "Status": "Approved",
                "OriginationID": "4CD7624288234C6CAF9FE821DBC20D39",
                "RespTrxTag": null,
                "AuthCode": "821Y5H",
                "ResultCode": "1",
                "Message": "APPROVED",
                "CVV2Response": "NotSet",
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "IAVSAddressResponse": "",
                "PayFabricErrorCode": null,
                "TrxDate": "9/7/2023 8:08:10 AM",
                "TrxDateUTC": "2023-09-07T00:08:10.511Z",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "3.12",
                "SurchargeAmount": "0.12",
                "SurchargePercentage": "4.00",
                "OrigTrxAmount": "3.00",
                "CardType": "Credit",
                "FinalAmount": "3.12",
                "ExpectedSettledTime": "9/7/2023 3:30:00 PM",
                "ExpectedSettledTimeUTC": "2023-09-07T07:30:00.000",
                "SettledTime": "9/7/2023 7:30:00 PM",
                "SettledTimeUTC": "2023-09-07T11:30:00.000",
                "WalletID": null,
                "RemainingBalance": null
            },
            "Card": {
                "Billto": {
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
                "ID": "95c41aa3-e0cd-4bd8-960c-29546b8cb8b9",
                "Customer": "",
                "Tender": null,
                "Account": "XXXXXXXXXXXX1111",
                "CardName": "Visa",
                "ExpDate": "1225",
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
                    "FirstName": "11",
                    "MiddleName": "",
                    "LastName": "1",
                    "DriverLicense": "",
                    "SSN": ""
                },
                "IsSaveCard": false,
                "IsDefaultCard": false,
                "IsLocked": false,
                "LastUsedDate": "9/7/2023 8:08:10 AM",
                "CardType": "Credit",
                "LastUsedDateUTC": "2023-09-07T00:08:10.586Z",
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
            "CardHolderAccountInfo": null,
            "Key": "23090601350379",
            "ReferenceKey": null,
            "Customer": "aa",
            "BatchNumber": "",
            "SetupId": "EVO",
            "ECheckSetupId": "",
            "GiftCardSetupId": "",
            "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
            "Tender": "CreditCard",
            "Type": "Sale",
            "Currency": "USD",
            "Amount": "3.12",
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
                        "Value": "Visa INV001"
                    },
                    {
                        "Name": "PONumber",
                        "Value": "Visa PO123"
                    },                   
                    {
                        "Name": "TaxAmount",
                        "Value": "10"
                    },
                    {
                        "Name": "DutyAmount",
                        "Value": "1"
                    },
                    {
                        "Name": "FreightAmount",
                        "Value": "2"
                    },
                    {
                        "Name": "DiscountAmount",
                        "Value": "3"
                    },
                    {
                        "Name": "ShipFromZip",
                        "Value": "4"
                    },
                    {
                        "Name": "HandlingAmount",
                        "Value": "5"
                    }
                   
                ],
                "Lines": [
                    {
                        "Columns": [
                            {
                                "Name": "ItemQuantity",
                                "Value": "10"
                            },
                            {
                                "Name": "ItemUPC",
                                "Value": "VisaUPC"
                            },
                            {
                                "Name": "ItemDesc",
                                "Value": "VisaDESC"
                            },
                            {
                                "Name": "ItemUOM",
                                "Value": "SET"
                            },
                            {
                                "Name": "ItemCost",
                                "Value": "11"
                            },
                            {
                                "Name": "ItemProdCode",
                                "Value": "VISAItemNumber"
                            },
                            {
                                "Name": "ItemDiscount",
                                "Value": "1.1"
                            },
                            {
                                "Name": "ItemTaxAmount",
                                "Value": "1.2"
                            },
                            {
                                "Name": "ItemCommodityCode",
                                "Value": "VICD"
                            },
                            {
                                "Name": "ItemTaxRate",
                                "Value": "1.3"
                            },
                            {
                                "Name": "ItemInvoiceNumber",
                                "Value": "VisaIINV001"
                            },
                            {
                                "Name": "ItemAmount",
                                "Value": "110"
                            }
                        ],
                        "UserDefined": []
                    }
                ],
                "UserDefined": [],
                "DefaultBillTo": null
            },
            "ModifiedOn": "9/7/2023 8:08:10 AM",
            "ModifiedOnUTC": "2023-09-07T00:08:10.586Z",
            "ReferenceTrxs": [],
            "TrxInitiation": "Customer",
            "TrxSchedule": "Unscheduled",
            "AuthorizationType": "NotSet",
            "CCEntryIndicator": "Stored",
            "CardHolderAttendance": "NotSet",
            "SurchargePercentage": "4.00",
            "SurchargeAmount": "0.12",
            "CardType": "Credit",
            "OrigTrxAmount": "3.00",
            "EntryClass": "",
            "TransactionState": "Settled",
            "EntryMode": "LegacyVT",
            "TransationStateHistory": [
                {
                    "CommittedStateTime": "9/7/2023 8:08:11 AM",
                    "CommittedStateTimeUTC": "2023-09-07T00:08:11.000Z",
                    "TransactionState": "Pending Settlement",
                    "Amount": "3.12"
                },
                {
                    "CommittedStateTime": "9/7/2023 7:30:00 PM",
                    "CommittedStateTimeUTC": "2023-09-07T11:30:00.000Z",
                    "TransactionState": "Settled",
                    "Amount": "3.12"
                }
            ]
        },
        ...
    
    ],
    "Paging": {
        "Size": "13",
        "Current": "1",
        "TotalRecords": "160",
        "TotalPages": "13"
    }
}
</pre>
