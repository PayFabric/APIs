## Payment
There are four Payment objects that represent a payment in the PayFabric Receivables website, PaymentPost, PaymentPatch, PaymentResponse, and PaymentPagingResponse. 


## PaymentPost
This object is used when creating a payment on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Amount | Decimal | N | Total payment amount  | 19, 5 |
| BalanceAmount | Decimal | N | Total balance amount | 19, 5 |
| BatchNumber | String | N | Batch number | 50 |
| CCNumber | String | N | Credit card number | 25 |
| CheckNumber | String | N | Check number used | 25 |
| CreatedOn | String | N | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| Currency | String | N | Currency code | 10 |
| CustomerId | String | Y | Customer ID specified by the client | 50 |
| Identity | String | N | Unique identifier for the payment | 50 |
| PaymentApplies | [Array of Objects](PaymentApply.md#PaymentApplyPost) | N | Application of the payment to invoices |
| PaymentId | String | Y | Payment number | 25 |
| PaymentMethod | String | N | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | 25 |
| PaymentType | String | N | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | 25 |
| Status | String | N | Payment status. Valid options are ``Processed``, ``Voided``, and ``InProgress`` | 10 |
| User | String | N | User who made the payment | 50 |


## PaymentPatch
This object is used when updating an existing payment on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :---------  | :--------- | :--------- |
| Amount | Decimal | N | Total payment amount  | 19, 5 |
| BalanceAmount | Decimal | N | Total balance amount | 19, 5 |
| BatchNumber | String | N | Batch number | 50 |
| CCNumber | String | N | Credit card number | 25 |
| CheckNumber | String | N | Check number used | 25 |
| CreatedOn | String | N | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| CustomerId | String | Y | Customer ID specified by the client | 50 |
| Identity | String | Y | Unique identifier for the payment | 50 |
| PaymentApplies | [Array of Objects](PaymentApply.md#paymentapplypost) | N | Application of the payment to invoices |
| Notes | String | N | Additional notes for the payment | 500 |
| PaymentId | String | Y | Payment number | 25 |
| PaymentMethod | String | N | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | 25 |
| PaymentType | String | N | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | 25 |
| User | String | N | User who made the payment | 50 |
| Reference | String | N | Payment reference | 100 |

## PaymentResponse
This object is used when getting a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total payment amount  | 19, 5 |
| AppliedAmount | Decimal | Payment amount applied to invoices | 19, 5 |
| BalanceAmount | Decimal | Total balance amount | 19, 5 |
| BatchNumber | String | Batch number | 50 |
| Canceled | Boolean | Indicates if the payment is canceled |  |
| CCNumber | String | Credit card number | 25 |
| CheckNumber | String | Check number used | 25 |
| Comment | String | Comment field | 500 |
| Comment2 | String | Additional Comment field | 30 |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| Currency | String | Currency code | 10 |
| CustomerId | String | Customer ID specified by the client | 50 |
| DateDue | String | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| FailedAttempts | int | Number of attempts the payment failed submitting to the back office |  |
| Identity | String | Unique identifier for the payment | 50 |
| PaymentApplies | [Array of Objects](PaymentApply.md#PaymentApplyResponse) | Application of the payment to invoices |
| LastAttempt | String | Timestamp indicating when the last time this document attempted to submit to the back office |  |
| LastMessage | String | Message for the payment when it last attempted to submit to the back office | 4000 |
| MasterType | String | Master type of the payment | 20 |
| ModifiedOn |  | Last date the payment was modified |  |
| Name | String | Customer name | 100 |
| PaymentId | String | Payment number | 25 |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | 25 |
| PaymentType | String | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | 25 |
| Reference | String | Payment reference | 100 |
| Status | String | Status of the payment. Valid options are ``Scheduled``, ``Processed``, ``Failed``, and ``Voided`` | 10 |
| Transaction | [Object](Transaction.md) | Transaction details associated to the payment | 
| User | String | User who made the payment | 50 |
| WalletEntryGuid | Guid | Unique identifier of the wallet associated to the payment |  |

## PaymentPagingResponse
This object is used when getting payment information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |  |
| Total | Int | Total number of results |  |
| Result | [Array of Objects](Payment.md#PaymentResponse) | Payment response details |
