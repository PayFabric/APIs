Payments
============

The Payment API is used for creating, updating, and viewing payment information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve Payments by query parameters
--------------------

* `GET /payments` will get the payment information on the PayFabric Receivables website based on the URL parameters.

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
| CreatedOn | Search by the created on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| Currency | Payment currency code | [String](../QueryFilter.md#string) |
| CustomerId | Customer number | [String Filter](../QueryFilter.md#string-filter) |
| DateDue | Search by the date due within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| PaymentId | Payment number | [String Filter](../QueryFilter.md#string-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| Status | Payment status. Valid options are ``All``, ``Scheduled``, ``Processed``, ``Failed``, and ``Voided`` | [String](../QueryFilter.md#string) |
| Type | Payment type. Valid options are ``FinanceCharge``, ``CreditMemo``, ``Return``, and ``Payment`` | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /payments?filter.pageSize=10&filter.pageIndex=0&filter.criteria.CustomerId.EqualsTo=Nodus0001
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
          "AppliedToInvoice": false,
          "InvoiceId": "string",
          "Identity": "string",
          "PayAmount": 0,
          "DocumentType": 0,
          "RowVersion": "string"
        }
            ],
            "IsVoid": false,
            "PaymentId": "WEBPMT0000000020",
            "PaymentType": "Payment",
            "Notes": null
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Payment.md#PaymentPagingResponse).


Create or Update a Payment
--------------------

* `POST /payments` will create or update a payment on the PayFabric Receivables website based on the JSON request payload. If updating a payment, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
	"Amount": "1.00",
	"BalanceAmount": "1.00",
	"BatchNumber": "API20171031",
	"CCNumber": "XXXXXXXXXXXX1111",
	"CheckNumber": null,
	"CreatedOn": "10/31/2017 2:33:20 PM",
	"Currency": "USD",
	<b>"CustomerId": "Nodus0001"</b>,
	"Identity": "",
	 "PaymentApplies": [
        {
          "AppliedToInvoice": false,
          "InvoiceId": "string",
          "Identity": "string",
          "PayAmount": 0,
          "DocumentType": 0,
          "RowVersion": "string"
        }],
	"IsVoid": false,
	"Notes": "",
	<b>"PaymentId": "APIPMT000000001"</b>,
	"PaymentMethod": "CreditCard",
	"PaymentType": "Payment"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Payment.md#PaymentPost).

###### Response
<pre>
	true
</pre>


Retrieve a Payment
--------------------

* `GET /payments/{id}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
<pre>
	GET /payments/APIPMT000000001
</pre>

###### Response
<pre>
{
    "AppliedAmount": 0,
    "Canceled": false,
    "Comment": "",
    "Comment2": "",
    "DateDue": "0001-01-01T00:00:00",
    "FailedAttempts": 0,
    "LastAttempt": "0001-01-01T00:00:00",
    "LastMessage": null,
    "MasterType": "Back Office",
    "Name": "Nodus Technologies ",
    "Status": "Processed",
    "WalletEntryGuid": "00000000-0000-0000-0000-000000000000",
    "Transaction": null,
    "Amount": 1,
    "BalanceAmount": 1,
    "BatchNumber": "API20171031",
    "PaymentMethod": "CreditCard",
    "CCNumber": "XXXXXXXXXXXX1111",
    "CheckNumber": "",
    "CreatedOn": "2017-10-31T14:33:20",
    "Currency": "USD",
    "CustomerId": "Nodus0001",
    "Identity": "",
     "PaymentApplies": [
        {
          "AppliedToInvoice": false,
          "InvoiceId": "string",
          "Identity": "string",
          "PayAmount": 0,
          "DocumentType": 0,
          "RowVersion": "string"
        }
    ],
    "IsVoid": false,
    "PaymentId": "APIPMT000000001",
    "PaymentType": "Payment",
    "Notes": null
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Payment.md#PaymentResponse).


Update an existing payment and void it
--------------------

* `PATCH /payments/{id}/void` will update the payment and void it

###### Request
<pre>
	PATCH /payments/APIPMT000000001/void
</pre>

###### Response
<pre>
	true
</pre>
