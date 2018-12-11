## Invoice
There are three Invoice objects that represent an invoice in the PayFabric Receivables website, InvoicePost, InvoiceResponse and InvoicePagingResponse. 


## InvoicePost
This object is used when creating a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount\* | Decimal | Total invoice amount in the functional currency  | decimal(19,5) |
| BalanceDue | Decimal | Total balance due in the functional currency | decimal(19,5) |
| BatchNumber | String | Batch number | nvarchar(50) |
| BillingAddress | [Object](Address.md#AddressPost) | Billing address object | 
| Comments | String | Additional comments | nvarchar(500) |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId\* | String | Customer ID specified by the client | nvarchar(50) |
| CustomerName | String | Customer name specified by the client | nvarchar(100) |
| Discount | Decimal | Total discount in the functional currency | decimal(19,5) |
| DocumentType | String | Document type identifier | nvarchar(50) |
| DueDate | DateTime | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| ExtensionData | String | Additional invoice information | nvarchar(max) |
| Freight | Decimal | Total freight amount | decimal(19,5) |
| Identity | String | Additional unique identifer | nvarchar(50) |
| InvoiceGuid | Guid | Unique identifer of the invoice | uniqueidentifier | 
| InvoiceId\* | String | Invoice number | nvarchar(50) |
| InvoiceItems | [Object](InvoiceItem.md) | Invoice line item object |
| InvoiceType | String | Invoice type | nvarchar(50) |
| MiscCost | Decimal | Total miscellaneous amount | decimal(19,5) |
| PaymentTerms | String | Payment terms | nvarchar(50) |
| PONumber | String | Purchase order number | nvarchar(50) |
| PostingDate | DateTime | Date that the invoice was posted. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| SalesPerson | String | Associated salesperson | nvarchar(max) |
| SendNewInvoiceEmail | String | Indicates if the new invoice email should be sent. Valid options are ``Yes`` and ``No`` |
| ShippingAddress | [Object](Address.md#AddressPost) | Shipping address object |
| ShippingMethod | String | Shipping method | nvarchar(50) |
| Site | String | Site / warehouse items ship from | nvarchar(max) |
| Tax | Decimal | Total tax amount | decimal(19,5) |
| TermDiscounts | [Object](TermDiscount.md) | Term discounts |
| TrackingNumber | String | Tracking number for shipping | char(50) |
\*Required

## InvoiceResponse
This object is used when getting an invoice on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total invoice amount in the functional currency  | decimal(19,5) |
| BalanceDue | Decimal | Total balance due in the functional currency | decimal(19,5) |
| BatchNumber | String | Batch number | nvarchar(25) |
| Currency | [Object](Currency.md#CurrencyPost) | Currency information |
| CustomerId | String | Customer ID specified by the client | nvarchar(25) |
| CustomerName | String | Customer name specified by the client | nvarchar(25) |
| DiscountAmount | Decimal | Total discount in the functional currency | decimal(19,5) |
| DiscountDate | DateTime | Date the discount expires. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| DocumentType | String | Document type identifier | nvarchar(50) |
| DueOn | DateTime | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| ExtensionData | String | Additional invoice information | nvarchar(max) |
| Identity | String | Additional unique identifer | nvarchar(50) |
| InvoiceGuid | Guid | Unique identifer of the invoice | uniqueidentifier | 
| InvoiceId | String | Invoice number | nvarchar(50) |
| InvoiceType | String | Invoice type | nvarchar(50) |
| ParentCustomerId | String | Parent customer number | nvarchar(25) |
| ParentCustomerName | String | Parent customer name | nvarchar(25) |
| PONumber | String | Purchase order number | nvarchar(50) |
| PostingDate | DateTime | Date that the invoice was posted. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| Status | String | Status of the invoice. Valid options are ``Outstanding``, ``PastDue``, and ``Paid`` | nvarchar(50) |
| RowVersion | Timestamp | Timestamp of when the row was updated | Timestamp |

## InvoicePagingResponse
This object is used when getting invoice information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Index | Int | Page number of results  | int |
| Total | Int | Total number of results | int |
| Result | [Object](Invoice.md#InvoiceResponse) | Invoice response details |