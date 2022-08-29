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
    "BatchNumber": "API20180525",
    "ExtensionData": "",
    "Identity": "STDINV999999",
    "DocumentType": "Invoice"
}
```
