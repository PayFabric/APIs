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
        "Key": "21071250001950",
        "ReferenceKey": null,
        "Customer": "AARONFIT0001",
        "BatchNumber": "",
        "SetupId": "EVO",
        "ECheckSetupId": "",
        "MSO_EngineGUID": "f4539566-8f8c-4cc7-a695-7e6491de8bf2",
        "Tender": "CreditCard",
        "Type": "Sale",
        "Currency": "USD",
        "Amount": "5.00",
        "ReqAuthCode": "",
        "PayDate": "07/14/2021",
        "TrxUserDefine1": "",
        "TrxUserDefine2": "",
        "TrxUserDefine3": "",
        "TrxUserDefine4": "",
        "Card": {
            "ID": "444a4ce1-b851-4f3f-85a9-87b55116fd63",
            "Customer": "AARONFIT0001",
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
                "ID": "11f1cdcf-06ff-431d-b9db-54749a1261ab",
                "Line1": "d",
                "Line2": "",
                "Line3": "",
                "State": "",
                "City": "Anaheim",
                "Country": "",
                "Zip": "55304-9840",
                "Email": "sample@email.com",
                "Phone": "13125550102",
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
            "TrxKey": "21071250001950",
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
            "TrxAmount": "5.00",
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.00",
            "OrigTrxAmount": "5.00",
            "CardType": "",
            "FinalAmount": "5.00",
            "ExpectedSettledTime": null,
            "SettledTime": null,
            "WalletID": null
        },
        "Document": {
            "Head": [
                {
                    "Name": "CustomerCode",
                    "Value": "AARONFIT0001"
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
                            "Value": "5.00"
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
                            "Value": "5.00"
                        }
                    ],
                    "UserDefined": []
                }
            ],
            "UserDefined": [],
            "DefaultBillTo": null
        },
        "ModifiedOn": "7/12/2021 6:21:47 AM",
        "ReferenceTrxs": [],
        "TrxInitiation": "Customer",
        "TrxSchedule": "Scheduled",
        "AuthorizationType": "NotSet",
        "CCEntryIndicator": "Stored",
        "CardHolderAttendance": "NotSet",
        "SurchargePercentage": "0.0",
        "SurchargeAmount": "0.00",
        "CardType": "",
        "OrigTrxAmount": "5.00",
        "EntryClass": "",
        "TransactionState": "",
        "EntryMode": "ModernVT"
    }
]
</pre>
