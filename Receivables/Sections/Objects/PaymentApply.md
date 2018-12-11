## Payment Apply
There are two payment apply objects that represent the application of a payment to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Payment](Payment.md)).


## PaymentApplyPost
This object is used when creating an application of a payment to an invoice on the ePay website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AppliedToInvoice | Boolean | Indicates if the payment is applied to the invoice | bit |
| Identity | Decimal | Invoice number identifier (Optional if using Invoice number) | decimal(19,2) |
| InvoiceId | String | Invoice number | nvarchar(30) |
| DocumentType | String | Document type | nvarchar(50) |
| PayAmount | Decimal | Payment amount applied to the invoice in the functional currency | decimal(19,2) |


## PaymentApplyResponse
This object is used when getting the application of a payment to an invoice on the ePay website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AppliedToInvoice | String | Invoice the payment is applied to | 
| Discount | Decimal | Discount amount | decimal(19,2) |
| Identity | Decimal | Invoice number identifier (Optional if using Invoice number) | decimal(19,2) |
| InvoiceId | String | Invoice number | nvarchar(30) |
| InvoiceType | String | Invoice type | nvarchar(50) |
| PayAmount | Decimal | Payment amount applied to the invoice in the functional currency | decimal(19,2) |
| ReApply | Boolean | Indicates if the application is reapplied | bit |