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
| BalanceAmount | Balance amount | [Numeric Range Filter](../QueryFilter.md#numeric-range-filter) |
| CreatedOn | Search by the created on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| Currency | Payment currency code | [String](../QueryFilter.md#string) |
| CustomerId | Customer number | [String Filter](../QueryFilter.md#string-filter) |
| DateDue | Search by the date due within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| ModifiedOn | Search by the last modified on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| PaymentId | Payment number | [String Filter](../QueryFilter.md#string-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| Status | Payment status. Valid options are ``Scheduled``, ``Processed``, ``Failed``, ``Voided``, ``InProgress``, ``Incomplete``, and ``Authorized`` | [String](../QueryFilter.md#string) |
| Type | Payment type. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | [String](../QueryFilter.md#string) |
| User | Search by the user who made the payment | [String Filter](../QueryFilter.md#string-filter) |

###### Request
```http 
GET /payments?filter.pageSize=10&filter.pageIndex=0&filter.criteria.CustomerId.EqualsTo=Nodus0001 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Payment.md#PaymentPagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "PaymentId": "WEBPMT0000000020",
            "CustomerId": "Nodus0001",
            "Name": "Nodus Technologies",
            "PaymentType": "Payment",
            "PaymentMethod": "CreditCard",
            "DateDue": "2017-12-12T00:00:00.0000000Z",
            "Amount": 2.0,
            "BalanceAmount": 1.0,
            "CreatedOn": "2017-04-12T00:00:00.0000000Z",
            "Reference": "",
            "Comment": "",
            "Status": "Processed",
            "PaymentApplies": [
                {
                    "DocumentType": 1,
                    "Identity": "STDINV999999",
                    "InvoiceId": "SSTDINV999999",
                    "PayAmount": 1.0,
                    "RowVersion": "",
                    "InvoiceType": "STDINV",
                    "DiscountAmount": 0.0
                }
            ],
            "Transaction": {
                "TransactionKey": "18081200180094",
                "DocumentId": "WEBPMT0000000020",
                "DocumentType": 9,
                "CustomerId": null,
                "Name": "Nodus Technologies",
                "ConnectorSetupID": "EVO",
                "ConnectorSetupIDGuid": "e1f70916-c2c1-4b9b-bcfd-d1479a159790",
                "TrxType": "Sale",
                "TenderType": "CreditCard",
                "Status": "Approved",
                "TrxAmount": 2.00,
                "TrxOriginationID": "A10EABE89CD1",
                "TrxAuthCode": "010101",
                "TrxResultCode": "0",
                "TrxResponseMessage": "Approved",
                "TrxAVSAddressResponse": "X",
                "TrxAVSZipResponse": "X",
                "TrxCVV2Response": "",
                "CCName": "Test Test",
                "CCNumber": "1111",
                "CardType": "",
                "CCType": "Visa",
                "CCExpDate": "2025-01-31T00:00:00.0000000Z",
                "CCStartDate": null,
                "CCIssueNumber": "",
                "ECType": 0,
                "ECAccountNumber": "",
                "ECAbaNumber": "",
                "ECCheckNumber": "",
                "Address1": "1234 Street",
                "Address2": "",
                "City": "Los Angeles",
                "State": "CA",
                "Zip": "12345",
                "Country": "US",
                "CreatedOn": "2018-05-02T00:00:00.0000000Z",
                "Currency": "USD",
                "SurchargeAmount": 0.00,
                "SurchargePercentage": 0.0
            },
            "Comment2": null,
            "AppliedAmount": 0.0,
            "FailedAttempts": 0,
            "LastAttempt": null,
            "LastMessage": null,
            "MasterType": null,
            "ModifiedOn": "2022-05-05T16:40:51.0400000Z",
            "WalletEntryGuid": "00000000-0000-0000-0000-000000000000",
            "Canceled": false,
            "BatchNumber": "EPAY20180529",
            "CCNumber": "1111",
            "CheckNumber": "",
            "Identity": "WEBPMT0000000020",
            "Currency": "USD",
            "User": "Nodus0001"
        }
    ]
}
```


Create or Update a Payment
--------------------

* `POST /payments` will create or update a payment on the PayFabric Receivables website based on the JSON request payload. If updating a payment, make sure to send all values again, otherwise, they will be overwritten.

###### Request
For more information on available fields please see our [object reference](../../Objects/Payment.md#PaymentPost)
```json
{
	"CustomerId": "Nodus0001",
	"PaymentId": "APIPMT000000001"
}
```


###### Response
```text
true
```


Retrieve a Payment
--------------------

* `GET /payments/byId?id={id}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```htpp
GET /payments/byId?id=WEBPMT0000000020
```

###### Response
For more information and descriptions on response fields please see our [object reference](../../Objects/Payment.md#PaymentResponse)
```json
{
    "PaymentId": "WEBPMT0000000020",
    "CustomerId": "Nodus0001",
    "Name": "Nodus Technologies",
    "PaymentType": "Payment",
    "PaymentMethod": "CreditCard",
    "DateDue": "2017-12-12T00:00:00.0000000Z",
    "Amount": 2.0,
    "BalanceAmount": 1.0,
    "CreatedOn": "2017-04-12T00:00:00.0000000Z",
    "Reference": "",
    "Comment": "",
    "Status": "Processed",
    "PaymentApplies": [
        {
            "DocumentType": 1,
            "Identity": "STDINV999999",
            "InvoiceId": "SSTDINV999999",
            "PayAmount": 1.0,
            "RowVersion": "",
            "InvoiceType": "STDINV",
            "DiscountAmount": 0.0
        }
    ],
    "Transaction": {
        "TransactionKey": "18081200180094",
        "DocumentId": "WEBPMT0000000020",
        "DocumentType": 9,
        "CustomerId": null,
        "Name": "Nodus Technologies",
        "ConnectorSetupID": "EVO",
        "ConnectorSetupIDGuid": "e1f70916-c2c1-4b9b-bcfd-d1479a159790",
        "TrxType": "Sale",
        "TenderType": "CreditCard",
        "Status": "Approved",
        "TrxAmount": 2.00,
        "TrxOriginationID": "A10EABE89CD1",
        "TrxAuthCode": "010101",
        "TrxResultCode": "0",
        "TrxResponseMessage": "Approved",
        "TrxAVSAddressResponse": "X",
        "TrxAVSZipResponse": "X",
        "TrxCVV2Response": "",
        "CCName": "Test Test",
        "CCNumber": "1111",
        "CardType": "",
        "CCType": "Visa",
        "CCExpDate": "2025-01-31T00:00:00.0000000Z",
        "CCStartDate": null,
        "CCIssueNumber": "",
        "ECType": 0,
        "ECAccountNumber": "",
        "ECAbaNumber": "",
        "ECCheckNumber": "",
        "Address1": "1234 Street",
        "Address2": "",
        "City": "Los Angeles",
        "State": "CA",
        "Zip": "12345",
        "Country": "US",
        "CreatedOn": "2018-05-02T00:00:00.0000000Z",
        "Currency": "USD",
        "SurchargeAmount": 0.00,
        "SurchargePercentage": 0.0
    },
    "Comment2": null,
    "AppliedAmount": 0.0,
    "FailedAttempts": 0,
    "LastAttempt": null,
    "LastMessage": null,
    "MasterType": null,
    "ModifiedOn": "2022-05-05T16:40:51.0400000Z",
    "WalletEntryGuid": "00000000-0000-0000-0000-000000000000",
    "Canceled": false,
    "BatchNumber": "EPAY20180529",
    "CCNumber": "1111",
    "CheckNumber": "",
    "Identity": "WEBPMT0000000020",
    "Currency": "USD",
    "User": "Nodus0001"
}
```

Retrieve an Application Record
--------------------

* `GET /applications?applicationId={applicationId}` will get the payment application information on the PayFabric Receivables website based on the URL parameters.

###### Request
```htpp
GET /applications?applicationId=WEBPMT0000000020
```

###### Response
For more information and descriptions on response fields please see our [object reference](../../Objects/Application.md#ApplicationResponse)
```json
{
    "ApplicationId": "Application002",
    "CustomerId": "Nodus0001",
    "Amount": 2.0,
    "CreatedOn": "2021-05-11T00:00:00.0000000Z",
    "ModifiedOn": "2021-05-11T00:00:00.0000000Z",
    "AppliedCredits": [
        {
            "Identity": "CRDT00000000006",
            "PaymentId": "CRDT00000000006",
            "ApplyAmount": 2.0,
            "Type": "CreditMemo",
            "InvoiceApply": [
                {
                    "InvoiceId": "STDINV999999",
                    "Identity": "STDINV999999",
                    "InvoiceType": "STDINV",
                    "Amount": 2.0,
                    "TotalAppliedAmount": 0.0,
                    "DiscountAmount": 0.0
                }
            ]
        }
    ]
}
```


Void a Payment
--------------------

* `PATCH /payments/void?id={id}` will void the payment

###### Request
```http
PATCH /payments/void?id=APIPMT000000001 HTTP/1.1
```

###### Response
```text
true
```

Create/Send a Payment Request
--------------------

* `POST /payments/request` will create or send a payment request to the specified customer and emails for the listed invoices based on the information provided in the body.

###### Request
For more information on available fields please see our [object reference](../../Objects/PaymentRequest.md#PaymentRequestDto)
```json
{
	"CustomerId": "Nodus0001",
	"Invoices": [
        "INV00001"
    ]
}
```

###### Response
```json
{
    "Message": null,
    "Result": true,
    "PaymentRequestURL": "https://sandbox.payfabric.com/customerportal/nodus/ExpressPay?accessCode=fcbd6fa32a9b437aaa4dc9cb31ca48dc",
    "AccessCode": "fcbd6fa32a9b437aaa4dc9cb31ca48dc"
}
```
