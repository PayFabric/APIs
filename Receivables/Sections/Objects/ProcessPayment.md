## Process Payment
There are three process payment objects that represent the processing of a payment in the PayFabric Receivables website, InProgressPaymentPost, InProgressPaymentResponse and InProgressPaymentPatch. 


## InProgressPaymentPost
This object is used when creating a request to create an in-progress payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Currency | String | Currency code | nvarchar(10) |
| CVV2 | String | CVV2 of the card being used | Not Saved |
| PaymentApplies | [Object](PaymentApply.md) | Invoice(s) the payment is applied to | |
| Prepayment | decimal | Additional prepayment amount | decimal(19,2) |

## InProgressPaymentResponse
This object is used when returning a response from a create in-progress payment request.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Identity | String | Payment identifier | nvarchar(50) |

## InProgressPaymentPatch
This object is used when getting a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AdditionalFee | decimal | Additional fee amount | decimal(19,2) |
| ApplyCredit | [Object](ApplyCredit.md) | Credit(s) the invoice(s) are applied to |
| Comment | String | Comment of the payment | nvarchar(500) |
| Currency | String | Currency code | nvarchar(10) |
| PaymentIdentity | String | Payment identifier | nvarchar(50) |
| Prepayment | decimal | Additional prepayment amount | decimal(19,2) |
| ScheduledDate | Datetime | Indicates when the payment should process |
| WalletEntryGuid | Guid | Unique identifier of the wallet to be used to process | uniqueidentifier |
