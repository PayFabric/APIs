## Apply Credit
The apply credit object represents the application of a credit to an invoice and associated payment in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CreditApplies | [Object](PaymentApply.md) | Invoice(s) the credit is applied to |
| Identity | String | Unique identifier for the payment | nvarchar(50) |
| PaymentId | String | Payment number | nvarchar(25) |