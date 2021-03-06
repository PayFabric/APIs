## Payment
There are four Payment objects that represent a payment in the PayFabric Receivables website, PaymentPost, PaymentPatch, PaymentResponse, and PaymentPagingResponse. 


## PaymentPost
This object is used when creating a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total payment amount in the functional currency  | decimal(19,5) |
| BalanceAmount | Decimal | Total balance amount in the functional currency | decimal(19,5) |
| BatchNumber | String | Batch number | nvarchar(50) |
| CCNumber | String | Credit card number | nvarchar(25) |
| CheckNumber | String | Check number used | nvarchar(25) |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId\* | String | Customer ID specified by the client | nvarchar(50) |
| Identity | String | Unique identifier for the payment | nvarchar(50) |
| InvoiceApply | [Object](PaymentApply.md) | Application of the payment to invoices |
| Notes | String | Additional notes for the payment | nvarchar(500) |
| PaymentId\* | String | Payment number | nvarchar(25) |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | nvarchar(25) |
| PaymentType | String | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | nvarchar(25) |
| Status | String | Payment status. Valid options are ``Processed``, ``Voided``, and ``InProgress`` | varchar(10) |
| User | String | User who made the payment | nvarchar(50) |
| Reference | String | Payment reference | nvarchar(100) |
\*Required

## PaymentPatch
This object is used when updating an existing payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total payment amount in the functional currency  | decimal(19,5) |
| BalanceAmount | Decimal | Total balance amount in the functional currency | decimal(19,5) |
| BatchNumber | String | Batch number | nvarchar(50) |
| CCNumber | String | Credit card number | nvarchar(25) |
| CheckNumber | String | Check number used | nvarchar(25) |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| CustomerId\* | String | Customer ID specified by the client | nvarchar(50) |
| Identity | String | Unique identifier for the payment | nvarchar(50) |
| InvoiceApply | [Object](PaymentApply.md) | Application of the payment to invoices |
| Notes | String | Additional notes for the payment | nvarchar(500) |
| PaymentId\* | String | Payment number | nvarchar(25) |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | nvarchar(25) |
| PaymentType | String | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | nvarchar(25) |
| User | String | User who made the payment | nvarchar(50) |
| Reference | String | Payment reference | nvarchar(100) |

## PaymentResponse
This object is used when getting a payment on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total payment amount in the functional currency  | decimal(19,5) |
| AppliedAmount | Decimal | Payment amount applied to invoices | decimal(19,5) |
| BalanceAmount | Decimal | Total balance amount in the functional currency | decimal(19,5) |
| BatchNumber | String | Batch number | nvarchar(50) |
| Canceled | Boolean | Indicates if the payment is canceled | bit |
| CCNumber | String | Credit card number | nvarchar(25) |
| CheckNumber | String | Check number used | nvarchar(25) |
| Comment | String | Comment field | nvarchar(500) |
| Comment2 | String | Additional Comment field | nvarchar(30) |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId | String | Customer ID specified by the client | nvarchar(50) |
| DateDue | String | Timestamp indicating when this document is due. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| FailedAttempts | int | Number of attempts the payment failed submitting to the back office | int |
| Identity | String | Unique identifier for the payment | nvarchar(50) |
| InvoiceApply | [Object](PaymentApply.md) | Application of the payment to invoices |
| LastAttempt | String | Timestamp indicating when the last time this document attempted to submit to the back office | datetime |
| LastMessage | String | Message for the payment when it last attempted to submit to the back office | nvarchar(max) |
| MasterType | String | Master type of the payment | nvarchar(20) |
| ModifiedOn | DateTime | Last date the payment was modified | datetime |
| Name | String | Customer name | nvarchar(100) |
| PaymentId | String | Payment number | nvarchar(25) |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | nvarchar(25) |
| PaymentType | String | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | nvarchar(25) |
| Status | String | Status of the payment. Valid options are ``Scheduled``, ``Processed``, ``Failed``, and ``Voided`` | nvarchar(10) |
| User | String | User who made the payment | nvarchar(50) |
| WalletEntryGuid | Guid | Unique identifier of the wallet associated to the payment | uniqueidentifier |
| Reference | String | Payment reference | nvarchar(100) |
| Transaction | [Object](Transaction.md) | Transaction details associated to the payment | 

## PaymentPagingResponse
This object is used when getting payment information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Index | Int | Page number of results  | int |
| Total | Int | Total number of results | int |
| Result | [Object](Payment.md#PaymentResponse) | Payment response details |
