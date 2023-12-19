## Payment Apply
There are two payment apply objects that represent the application of a payment to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Payment](Payment.md)).


## PaymentApplyPost
This object is used when creating an application of a payment to an invoice on the Customer Portal.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :---------| :--------- | :--------- |
| DiscountAmount | Decimal | N | Discount amount applied to the invoice | 19, 5 |
| Identity | String | Y | Invoice number identifier (Optional if using Invoice number) | 50 |
| InvoiceId | String | Y | Invoice number | 50 |
| InvoiceType | String | N | Invoice type | 50 |
| PayAmount | Decimal | N | Payment amount applied to the invoice | 19, 5 |


## PaymentApplyResponse
This object is used when getting the application of a payment to an invoice on the Customer Portal.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DiscountAmount | Decimal | Discount amount applied to the invoice | 19, 5 |
| DocumentType | int | Document type |  |
| Identity | String | Invoice number identifier (Optional if using Invoice number) | 50 |
| InvoiceId | String | Invoice number | 50 |
| InvoiceType | String | Invoice type | 50 |
| PayAmount | Decimal | Payment amount applied to the invoice | 19, 5 |
| RowVersion | String | Version number of the invoice |  |
