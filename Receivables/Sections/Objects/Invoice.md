## Invoice
There are four Invoice objects that represent an invoice in the PayFabric Receivables website, InvoicePost, InvoiceIntegrationResponse, InvoiceResponse and InvoicePagingResponse. 


## InvoicePost
This object is used when creating or updating an invoice record on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Y | Total invoice amount in the functional currency  | 19, 5 |
| BalanceDue | Decimal | Y | Total balance due in the functional currency | 19, 5 |
| BatchNumber | String | N | Batch number | 50 |
| BillingAddress | [Object](Address.md#AddressPost) | N | Billing address object | 
| Comments | String | N | Additional comments | 500 |
| CopyEmail | Array of Strings | N | CC'd recipients to be used in e-mail notifications regarding an individual invoice | 1000 |
| Currency | String | N | Currency code | 10 |
| CustomerId | String | Y | Customer ID specified by the client | 50 |
| Discount | Decimal | N | Total discount in the functional currency | 19, 5 |
| DocumentType | String | N | Document type identifier | 50 |
| Email | String | N | Recipient to be used in e-mail notifications regarding an individual invoice, must be a single valid email address | 255 |
| DueDate | DateTime | N | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| ExtensionData | String | N | Additional invoice information | 4000 |
| Freight | Decimal | N | Total freight amount | 19, 5 |
| Identity | String | N | Additional unique identifier | 50 |
| InvoiceId | String | Y | Invoice number | 50 |
| InvoiceItems | [Array of Objects](InvoiceItem.md#InvoiceItemPost) | N | Invoice line item object |  |
| InvoiceType | String | N | Invoice type | 50 |
| MiscCost | Decimal | N | Total miscellaneous amount | 19, 5 |
| PaymentDiscountApplied | Decimal | N | Applied payment terms discount amount | 19, 5 |
| PaymentTerms | String | N | Payment terms | 50 |
| PONumber | String | N | Purchase order number | 50 |
| PostingDate | DateTime | N | Date that the invoice was posted. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| SalesPerson | String | N | Associated salesperson | 50 |
| SendNewInvoiceEmail | String | N | Indicates if the new invoice email should be sent. Valid options are ``Yes`` and ``No`` | 3 |
| ShippingAddress | [Object](Address.md#AddressPost) | N | Shipping address object |  |
| ShippingMethod | String | N | Shipping method | 50 |
| Site | String | N | Site / warehouse items ship from | 4000 |
| Status | String | N | Status of the invoice. Valid options are ``Incomplete``, ``Pending``, and ``Complete`` |  |
| SubTotal | Decimal | N | Subtotal of the invoice | 19, 5 |
| Tax | Decimal | N | Total tax amount | 19, 5 |
| TaxGroup | String | N | Tax group to be applied | 50 |
| TermDiscounts | [Array of Objects](TermDiscount.md) | N | Term discounts |  |
| TrackingNumber | String | N | Tracking number for shipping | 50 |

## InvoiceIntegrationResponse
This object is used when retrieving an invoice using the PayFabric Receivables Sync APIs.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total invoice amount in the functional currency  | 19, 5 |
| BalanceDue | Decimal | Total balance due in the functional currency | 19, 5 |
| BatchNumber | String | Batch number | 50 |
| BillingAddress | [Object](Address.md#AddressResponse) | Billing address object |
| Comments | String | Additional comments | 500 |
| CopyEmail | Array of Strings | CC'd recipients to be used in e-mail notifications regarding an individual invoice | 1000 |
| Currency | String | Currency code | 10 |
| CustomerBillingAddressId | String | Billing Address ID | 50 |
| CustomerId | String | Customer ID specified by the client | 50 |
| CustomerShippingAddressId | String | Shipping Address ID | 50 |
| Discount | Decimal | Total discount in the functional currency | 19, 5 |
| DocumentType | String | Document type identifier | 50 |
| Email | String | Recipient to be used in e-mail notifications regarding an individual invoice, must be a single valid email address | 255 |
| DueDate | DateTime | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| ExtensionData | String | Additional invoice information | 4000 |
| Freight | Decimal | Total freight amount | 19, 5 |
| Identity | String | Additional unique identifier | 50 |
| InvoiceId | String | Invoice number | 50 |
| InvoiceItems | [Array of Objects](InvoiceItem.md#InvoiceItemResponse) | Invoice line item object |  |
| InvoiceType | String | Invoice type | 50 |
| MiscCost | Decimal | Total miscellaneous amount | 19, 5 |
| PaymentDiscountApplied | Decimal | Applied payment terms discount amount | 19, 5 |
| PaymentTerms | String | Payment terms | 50 |
| PONumber | String | Purchase order number | 50 |
| PostingDate | DateTime | Date that the invoice was posted. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| SalesPerson | String | Associated salesperson | 4000 |
| ShippingAddress | [Object](Address.md#AddressResponse) | Shipping address object |  |
| ShippingMethod | String | Shipping method | 50 |
| Site | String | Site / warehouse items ship from | 4000 |
| SubTotal | Decimal | Subtotal of the invoice | 19, 5 |
| Tax | Decimal | Total tax amount | 19, 5 |
| TaxGroup | String | Tax group to be applied | 50 |
| TermDiscounts | [Array of Objects](TermDiscount.md) | Term discounts |  |
| TrackingNumber | String | Tracking number for shipping | 50 |

## InvoiceResponse
This object is used when retrieving an invoice using the PayFabric Receivables Website APIs.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total invoice amount in the functional currency  | 19, 5 |
| BalanceDue | Decimal | Total balance due in the functional currency | 19, 5 |
| BatchNumber | String | Batch number | 50 |
| CopyEmail | Array of Strings | CC'd recipients to be used in e-mail notifications regarding an individual invoice | 1000 |
| Currency | [Object](Currency.md#currencyresponse) | Currency object |  |
| CustomerId | String | Customer ID specified by the client | 50 |
| DiscountAmount | Decimal | Total discount in the functional currency | 19, 5 |
| DiscountDate | DateTime | Discount date |  |
| DocumentType | String | Document type identifier | 50 |
| Email | String | Recipient to be used in e-mail notifications regarding an individual invoice, must be a single valid email address | 255 |
| DueDate | DateTime | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| ExtensionData | String | Additional invoice information | 4000 |
| Identity | String | Additional unique identifier | 50 |
| InvoiceId | String | Invoice number | 50 |
| InvoiceGuid | Guid | Invoice unique identifier |  |
| InvoiceType | String | Invoice type | 50 |
| PONumber | String | Purchase order number | 50 |
| PostingDate | DateTime | Date that the invoice was posted. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| RowVersion | String | Version number of the invoice |  |


## InvoicePagingResponse
This object is used when getting invoice information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |
| Total | Int | Total number of results |
| Result | [Array of Objects](Invoice.md#InvoiceResponse) | Invoice response details |
