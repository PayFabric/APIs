Settlement
=========

The PayFabric Settlment API is used for getting batch summary from EVO Snap gateway, merchant can get the batch details and reconciliation report via settlement APIs.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.Please refer the [Settlement Object](/PayFabric/Sections/3.1JSONObjects.md#Settlement) for details.

Get Batch Summary report by post date
---------------------------

* `GET /payment/3.1/api/Settlement?postDate={postDate}` will return the batch summary report for the specified post date.

###### Response
<pre>
[
    {
        "PostDate": "2021-01-12T00:00:00",
        "MerchantId": 1259000001092341,
        "MerchantDescription": "TOWN OF LOOKOUT MOUNTAIN",
        "BatchCount": 8,
        "BatchAmount": 95.00,
        "BatchId": 2467214,
        "FullMerchantId": "1259000001092341",
        "TerminalId": "00000003",
        "SettledCount": 29,
        "SettledAmount": 95.00,
        "NonSettledCount": 0,
        "NonSettledAmount": 0.00
    },
    {
        "PostDate": "2021-01-12T00:00:00",
        "MerchantId": 1259000001092341,
        "MerchantDescription": "TOWN OF LOOKOUT MOUNTAIN",
        "BatchCount": 7,
        "BatchAmount": 72.00,
        "BatchId": 2431226,
        "FullMerchantId": "1259000001092341",
        "TerminalId": "00000001",
        "SettledCount": 24,
        "SettledAmount": 72.00,
        "NonSettledCount": 0,
        "NonSettledAmount": 0.00
    }
]
</pre>

Get Batch Details
---------------------------

* `GET /payment/3.1/api/Settlement/{batchId}?page={page}` will return the batch details report in page for the specified batch ID.
 
###### Response
<pre>
{
    "Paging": {
        "Size": "25",
        "Current": "1",
        "TotalRecords": "24",
        "TotalPages": "1"
    },
    "Records": [
        {
            "Account": "2961",
            "SettleAmount": 3.00,
            "AuthCode": "005312",
            "CardName": "VISA",
            "AuthAmount": 3.00,
            "TrxDate": "2021-01-11T00:00:00",
            "RefNumber": "24760621012380000251517",
            "PostDate": "2021-01-12T00:00:00",
            "MerchantDescription": "TOWN OF LOOKOUT MOUNTAIN",
            "TerminalId": "00000001",
            "MerchantId": 1259000001092341,
            "SettleId": 110694360,
            "Downgrade": "",
            "ProcessingCodeId": 40,
            "ProcessingCodeDescription": "Purchase/Sale",
            "TransactionTypeId": 37,
            "TransactionTypeDesc": "Purchase/Sale",
            "TransactionId": "461011644204401",
            "RejectCodes": "",
            "FullMerchantId": "1259000001092341",
            "RejectReasonsShort": "",
            "RejectReasonsLong": "",
            "SettledStatus": "Settled",
            "PayFabricTransactionKey": null,
            "ReconciliationIssues": {
                "Message": "Multiple PayFabric Transactions match this settlement record.",
                "Details": [
                    "22112401199829",
                    "22112401199831"
                ]
            }
        },
               .
      	       .
	            
        {
            "Account": "8351",
            "SettleAmount": 3.00,
            "AuthCode": "H94416",
            "CardName": "VISA",
            "AuthAmount": 3.00,
            "TrxDate": "2021-01-11T00:00:00",
            "RefNumber": "24760621012380000251491",
            "PostDate": "2021-01-12T00:00:00",
            "MerchantDescription": "TOWN OF LOOKOUT MOUNTAIN",
            "TerminalId": "00000001",
            "MerchantId": 1259000001092341,
            "SettleId": 110695137,
            "Downgrade": "",
            "ProcessingCodeId": 40,
            "ProcessingCodeDescription": "Purchase/Sale",
            "TransactionTypeId": 37,
            "TransactionTypeDesc": "Purchase/Sale",
            "TransactionId": "381011564552729",
            "RejectCodes": "",
            "FullMerchantId": "1259000001092341",
            "RejectReasonsShort": "",
            "RejectReasonsLong": "",
            "SettledStatus": "Settled",
            "PayFabricTransactionKey": null,
            "ReconciliationIssues": {
                "Message": "PayFabric Transaction could not be found.",
                "Details": null
            }
        }
    ]
}
</pre>

Export Batch Details for a Specified Batch Id
-----------------------------------------------

* `POST /payment/3.1/api/settlement/{batchID}/export` will export the batch details report to specified file format and send it to specified recipients.

###### Request
<pre>
{
  "Recipients": [
    "email@sample.com",
    "email2@sample.com"
  ],
  "ExportType": "csv"
}
</pre>

###### Response
A successful Export will result in a HTTP 204 No Content Response. 

A failed Export may result in a HTTP 400 Bad Request Response if the specified batchID with wront format.

A failed Export may result in a HTTP 401 Unauthorized Response if the authorization is failed.
