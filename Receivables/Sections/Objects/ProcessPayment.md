## Process Payment
There are two process payment objects that represent the processing of a payment in the PayFabric Receivables website, ProcessPaymentPost and ProcessPaymentResponse. 


## ProcessPaymentPost
This object is used when creating a request to process a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AdditionalFee | Decimal | Total additional fee amount | decimal(19,2) |
| ApplyCredit | [Object](ApplyCredit.md#ApplyCreditRequest) | Application of any credits | decimal(19,2) |
| Comment | String | Comment of the payment | nvarchar(500) |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId | String | Customer ID specified by the client | nvarchar(50) |
| CVV2 | String | CVV2 of the card being used | Not Saved |
| PaymentApplies | [Object](PaymentApply.md) | Invoice(s) the payment is applied to |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | nvarchar(25) |
| Prepayment | decimal | Additional prepayment amount | decimal(19,2) |
| SaveWallet | Boolean | Indicates if the wallet should be saved |
| ScheduledDate | DateTime | Date of when the payment should be processed | datetime |
| WalletEntryGuid | Guid | Unique identifier of the wallet to be used to process | uniqueidentifier |

## ProcessPaymentResponse
This object is used when getting a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Address1 | String | Billing Address line 1 | nvarchar(200) |
| Address2 | String | Billing Address line 2 | nvarchar(200) |
| Amount | Decimal | Total payment amount in the functional currency  | decimal(19,2) |
| AuthCode | String | Auth code returned from the gateway | nvarchar(255) |
| City | String | Billing address city | nvarchar(100) |
| Country | String | Billing address country | nvarchar(100) |
| CreditCardExpDate | DateTime | Credit card expiration date | datetime |
| CreditCardName | String | Credit card holder name | nvarchar(200) |
| CreditCardNumber | String | Credit card number | nvarchar(25) |
| CreditCardType | String | Credit card type | nvarchar(25) |
| ECheckAbaNumber | String | ECheck ABA number | nvarchar(50) |
| ECheckAccountNumber | String | ECheck account number | nvarchar(50) |
| ECheckCheckNumber | String | ECheck check number | nvarchar(10) |
| ECheckType | int | ECheck type | int |
| EmailAddress | String | Email address | nvarchar(255) |
| EmailGuid | Guid | Email Guid | uniqueidentifier |
| PaymentId | String | Payment number | nvarchar(25) |
| State | String | Billing address state | nvarchar(100) |
| Zip | String | Billing address zip | nvarchar(20) |
