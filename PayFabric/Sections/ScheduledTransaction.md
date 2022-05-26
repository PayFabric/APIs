Scheduled Transaction
=================

The PayFabric scheduled transaction APIs are used for managing PayFabric scheduled transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer the [Transaction Object](/PayFabric/Sections/3.1JSONObjects.md#transaction) for details.

Search for Future Dated Transactions
-------------------------------------
* `GET /payment/3.1/api/Transaction/Scheduled?page=1&pagesize=5&fromDate=6-27-2021&toDate=7-1-2021` Get a list of transactions that are scheduled between 2 dates. The max fromdate and todate range is 90 days.

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
                "Email": "test@nodus.com",
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
