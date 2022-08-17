## Process Payment
There are three process payment objects that represent the processing of a payment in the PayFabric Receivables website, InProgressPaymentPost, InProgressPaymentResponse and InProgressPaymentPatch. 


## InProgressPaymentPost
This object is used when creating a request to create an in-progress payment on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Comment | String | N | Comment of the payment | 500 |
| CurrencyCode | String | Y | Currency code | 10 |
| PaymentApplies | [Object](PaymentApply.md) | Y | Invoice(s) the payment is applied to | |
| Prepayment | decimal | Y | Additional prepayment amount | 19, 2 |

## InProgressPaymentResponse
This object is used when returning a response from a create in-progress payment request.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Identity | String | Payment identifier | 50 |
| TransactionKey | String | Transaction identifier | 50 |

## InProgressPaymentPatch
This object is used when getting a payment on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AdditionalFee | decimal | N | Additional fee amount | 19, 2 |
| CreditDistributions | [Object](ApplyCredit.md) | N | Credit(s) the invoice(s) are applied to |
| Comment | String | N | Comment of the payment | 500 |
| CurrencyCode | String | N (Y if Prepayment) | Currency code | 10 |
| PaymentIdentity | String | Y | Payment identifier | 50 |
| Prepayment | decimal | N | Additional prepayment amount | 19, 2 |
| ScheduledDate | Datetime | N | Indicates when the payment should process |
| WalletEntryGuid | Guid | N | Unique identifier of the wallet to be used to process |  |
| Reference | String | N | Payment reference | 100 |
