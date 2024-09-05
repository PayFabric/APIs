Invoices
============

The Invoice API is used for creating and updating invoice information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice
--------------------

* `POST /invoices` will create or update an invoice on the PayFabric Receivables website based on the JSON request payload. If the invoice already exists, the existing invoice will be updated and all values will be overwritten based on the JSON request payload. To only update certain parameters of an existing invoice use [Update an Invoice](#update-an-invoice)

###### Request
For more information on available fields please see our [object reference](../../Objects/Invoice.md#InvoicePost)
```json
{
	"Amount": "30.00",
	"BalanceDue": "30.00",
	"CustomerId": "Nodus0002",
	"InvoiceId": "STDINV999999"
}
```


###### Response
```text
true
```


Create or Update an Invoice with an Attachment
--------------------

* `POST /invoices/InvoiceWithAttachment` will create or update an invoice on the PayFabric Receivables website with the provided attachment. If the invoice already exists, the existing invoice will be updated and all values will be overwritten based on the JSON request payload. To only update certain parameters of an existing invoice use [Update an Invoice](#update-an-invoice). To only update the attachment of an existing invoice use [Update an Invoice Attachment](#update-an-invoice-attachment)
* `Content-Type: multipart/form-data` is required to send the attachment along with the other invoice data

###### Request
For more information on available fields please see our [object reference](../../Objects/Invoice.md#InvoicePost)

In the form-data add the following two key values:
* `Attachment` - This will contiain the actual pdf attachment to be uploaded
* `Invoice` - This will contain the json request of the actual invoice to be created
```json
{
	"Amount": "30.00",
	"BalanceDue": "30.00",
	"CustomerId": "Nodus0002",
	"InvoiceId": "STDINV999999"
}
```


###### Response
```text
true
```


Update an Invoice
--------------------

* `PATCH /invoices?identity={Invoice Identity}` will update an existing invoice on the PayFabric Receivables website based on the JSON request payload.

###### Request
```http
PATCH /invoices?identity=STDINV999999 HTTP/1.1
```
For more information on available fields please see our [object reference](../../Objects/Invoice.md#InvoicePost)
```json
{
	"Amount": "30.00"
}
```


###### Response
```
	true
```


Update an Invoice Attachment
--------------------

* `PATCH /invoices/attachments?identity={Invoice Identity}` will update an existing invoice on the PayFabric Receivables website based on the JSON request payload.
* `Content-Type: multipart/form-data` is required to send the attachment along with the other invoice data

###### Request
```http
PATCH /invoices/attachments?identity=STDINV999999 HTTP/1.1
```
In the form-data add the following key value:
* `Attachment` - This will contiain the actual pdf attachment to be uploaded


###### Response
```text
true
```


Retrieve an Invoice
--------------------

* `GET /invoices?identity={Invoice Identity}` will retrieve an invoice on the PayFabric Receivables website.

###### Request
```http
GET /invoices?identity=STDINV999999 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Invoice.md#InvoiceIntegrationResponse)
```json
{
    "InvoiceId": "STDINV999999",
    "CustomerId": "Nodus0002",
    "Amount": 30.00,
    "BalanceDue": 30.00,
    "Currency": "USD",
    "InvoiceType": "STDINV",
    "Email": "Nodus0001@nodus.com",
    "CopyEmail": [],
    "PONumber": "357R63",
    "DueDate": "2030-02-06T00:00:00.0000000Z",
    "PostingDate": "2020-01-07T00:00:00.0000000Z",
    "PaymentTerms": "",
    "Comments": "",
    "Discount": 0.0,
    "Freight": 0.0,
    "MiscCost": 0.0,
    "SubTotal": 30.00,
    "Tax": 0.00,
    "TaxGroup": "",
    "BillingAddress": {
        "AddressId": "PRIMARY2",
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "Name": "Nodus Technologies",
        "City": "Los Angeles",
        "State": "CA",
        "Zip": "12345",
        "Country": "USA",
        "AddressGuid": "832f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "isDefaultBilling": false,
        "IsDefaultShipping": false,
        "Email": "",
        "Fax": "",
        "Phone": ""
    },
    "ShippingAddress": null,
    "SalesPerson": "",
    "Site": "01-N",
    "ShippingMethod": "",
    "TermDiscounts": [],
    "TrackingNumber": "",
    "InvoiceItems": [
        {
            "ItemCode": "TEST",
            "Description": "TEST ITEM",
            "Sequence": 1,
            "UnitPrice": 30.00,
            "Markdown": 0.0,
            "Quantity": 1.0,
            "UnitOfMeasure": "Each",
            "TaxAmount": 0.00,
            "ExtendedPrice": 30.00,
            "CommodityCode": "TEST",
            "Site": "01-N",
            "ExtensionData": "",
            "InvoiceNumber": null,
            "NonInventory": null,
            "PriceLevel": "RETAIL",
            "ReqShipDate": "2017-03-17T00:00:00.0000000Z",
            "SalesPerson": "paul",
            "ShippingToAddress": null,
            "ShippingMethod": "",
            "Taxable": false,
            "Comment": "",
            "Taxes": []
        }
    ],
    "PaymentDiscountApplied": 0.0,
    "CustomerShippingAddressId": "PRIMARY5",
    "CustomerBillingAddressId": "PRIMARY5",
    "Status": "Outstanding",
    "BatchNumber": "API20180525",
    "ExtensionData": "",
    "Identity": "STDINV999999",
    "DocumentType": "Invoice"
}
```


Retrieve Invoices Report
--------------------

* `GET /reports/invoices` will retrieve the invoices report from PayFabric Receivables website based on the URL parameters

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
| Amount | Invoice amount | [Numeric Range Filter](../QueryFilter.md#numeric-range-filter) |
| BalanceDue | Balance due | [Numeric Range Filter](../QueryFilter.md#numeric-range-filter) |
| CurrencyCode | Customer's currency code | [String](../QueryFilter.md#string-filter) |
| CustomerId | Customer number | [String Filter](../QueryFilter.md#string-filter) |
| DueDate | Search by the due date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| Email | Customer's email address | [String](../QueryFilter.md#string-filter) |
| InvoicedToCustomerID | Invoice to customer number | [String](../QueryFilter.md#string-filter) |
| InvoiceId | InvoiceId | [String](../QueryFilter.md#string-filter) |
| InvoiceStatus | Invoice status | [String](../QueryFilter.md#string-filter) |
| InvoiceType | Invoice type | [String](../QueryFilter.md#string-filter) |
| PONumber | Invoice purchase order number | [String](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |

###### Request
```http
GET /reports/invoices?filter.pageSize=10&filter.pageIndex=0&filter.criteria.CustomerId.EqualsTo=Nodus0001 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Invoice.md#InvoiceReportPagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "Amount": 45.00,
            "AuthorizedPaymentAmount": 0.00,
            "BalanceDue": 45.00,
            "CopyEmail": [],
            "CurrencySymbol": "$",
            "Currency": "USD",
            "CustomerEmail": "Nodus0001@nodus.com",
            "CustomerGuid": "95ea82b1-5f02-ef11-a2f5-0050568f9b1b",
            "CustomerId": "Nodus0001",
            "CustomerName": "Nodus User 1",
            "CustomerTaxExempt": false,
            "DiscountDate": "1900-01-01T00:00:00.0000000",
            "DiscountAmount": 0.00,
            "DueDate": "2024-07-04T07:00:00.0000000Z",
            "Email": "Nodus0001@nodus.com",
            "ExtensionData": "",
            "Identity": "STDINV012038",
            "IncompletedPaymentAmount": 0.00,
            "InvoiceGuid": "f5208495-c422-ef11-a2f6-0050568f9b1b",
            "InvoiceId": "STDINV012038",
            "InvoiceStatus": "Outstanding",
            "InvoicedToCustomerID": "",
            "InvoicedToCustomerName": "",
            "InvoiceType": "Invoice",
            "PaymentTerms": "30D",
            "PONumber": "",
            "PostingDate": "2024-06-04T07:00:00.0000000Z",
            "ProcessedPaymentAmount": 0.00
        }
    ]
}
```
