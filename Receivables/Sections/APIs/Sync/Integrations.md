Integrations
============

The Integration API is used for updating, and viewing integration information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](../Sync/Token.md) on how to authenticate.

Update the Integration Document
--------------------

* `PATCH /integrations` will update a document on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
{
	"Documents": [{
		<b>"DocumentId": "APIPMT000000001"</b>,
		<b>"Status": "Success"</b>,
		"ErrorMessage": "",
		"DocumentType": "Payment"
	}]
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Integration.md#IntegrationPost).

###### Response
<pre>
	true
</pre>


Retrieve Integration Documents
--------------------

* `GET /integrations` will get the details for integrating documents on the PayFabric Receivables website based on the URL parameter

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Date | Search by the document date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FailedAttempts | Number of failed attempts integrating | [Numeric Range Filter](../QueryFilter.md#numeric-range-filter) |
| LastAttempt | Date of last attempt made integrating | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| Status | Status of the document integrating | [String Filter](../QueryFilter.md#string-filter) |
| Type | Type of the document integrating | [String Filter](../QueryFilter.md#string-filter) |

###### Request
<pre>
  GET /integrations?filter.pageSize=10&filter.pageIndex=1&filter.criteria.Status=Pending
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 2,
    "Result": [
        {
            "IntegrationId": "00000000-0000-0000-0000-000000000000",
            "Date": "2018-05-29T10:38:34.037",
            "DocumentId": "WEBPMT0000000020",
            "Status": "Pending",
            "Type": "Payment",
            "ErrorMessage": null,
            "FailedAttempts": 0,
            "LastAttempt": "0001-01-01T00:00:00",
			"CreatedBy": "Nodus0001"
        },
        {
            "IntegrationId": "00000000-0000-0000-0000-000000000000",
            "Date": "2018-05-29T10:00:42.66",
            "DocumentId": "WEBPMT0000000019",
            "Status": "Pending",
            "Type": "Payment",
            "ErrorMessage": null,
            "FailedAttempts": 0,
            "LastAttempt": "0001-01-01T00:00:00",
			"CreatedBy": "Nodus0001"
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Integration.md#IntegrationPagingResponse).


Retrieve Integration Payment Information
--------------------

* `GET /integrations/payments` will get the document information on the PayFabric Receivables website based on the URL parameters.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| TimeStamp | Search by the created on date within a specified interval | [String Filter](../QueryFilter.md#string-filter) |

###### Request
<pre>
	GET /integrations/payments?filter.pageSize=10&filter.pageIndex=0&filter.criteria.TimeStamp=201811200123654
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "AppliedAmount": 0,
            "Canceled": false,
            "Comment": "ABC",
            "Comment2": "",
            "DateDue": "0001-01-01T00:00:00",
            "FailedAttempts": 0,
            "LastAttempt": "0001-01-01T00:00:00",
            "LastMessage": null,
            "MasterType": "Regular",
			"ModifiedOn": "2020-01-01T00:00:00",
            "Name": "Nodus Technologies ",
            "Status": "Processed",
            "WalletEntryGuid": "4bc44ebe-118a-46d1-a526-882a0e5c2aac",
            "Transaction": {
                "TransactionKey": "180529171901",
                "DocumentId": "WEBPMT0000000020",
                "DocumentType": 9,
                "CustomerId": null,
                "Name": "Nodus Technologies ",
                "ConnectorSetupID": "PayFlowProCredit",
                "ConnectorSetupIDGuid": "1c21624c-5c95-4ea6-9d40-fb38f7f95893",
                "TrxType": "Sale",
                "TenderType": "CreditCard",
                "Status": "Approved",
                "TrxAmount": 2,
                "TrxOriginationID": "A90E0AC594E8",
                "TrxAuthCode": "010101",
                "TrxResultCode": "0",
                "TrxResponseMessage": "Approved",
                "TrxAVSAddressResponse": "",
                "TrxAVSZipResponse": "",
                "TrxCVV2Response": "Y",
                "CCName": "fw fwef",
                "CCNumber": "XXXXXXXXXXXX1111",
                "CCType": "Visa",
                "CCExpDate": "2018-12-31T00:00:00",
                "CCStartDate": null,
                "CCIssueNumber": "",
                "ECType": 0,
                "ECAccountNumber": "",
                "ECAbaNumber": "",
                "ECCheckNumber": "",
                "Address1": "",
                "Address2": "",
                "City": "",
                "State": "",
                "Zip": "",
                "Country": "",
                "CreatedOn": "2018-05-29T10:38:33.977",
                "Currency": "Z-US$"
            },
            "Amount": 2,
            "BalanceAmount": 0,
            "BatchNumber": "EPAY20180529",
            "PaymentMethod": "CreditCard",
            "CCNumber": "",
            "CheckNumber": "",
            "CreatedOn": "2018-05-29T00:00:00",
            "Currency": "Z-US$",
            "CustomerId": "Nodus0001",
            "Identity": "",
            "PaymentApplies": [
                {
                    "InvoiceId": "STDINV2006",
                    "Identity": "",
                    "PayAmount": 1,
                    "RowVersion": ""
                }
            ],
            "PaymentId": "WEBPMT0000000020",
            "PaymentType": "Payment",
            "Status": "Processed",
			"User": "Nodus0001"
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Payment.md#PaymentPagingResponse).
