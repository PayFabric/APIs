## Payment Receipt
The payment receipt object represents a receipt of a payment in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AdditionalFee | Decimal | Total additional fee amount | decimal(19,2) |
| Amount | Decimal | Total payment amount | decimal(19,2) |
| BalanceAmount | Decimal | Amount remaining to be applied | decimal(19,2) |
| BatchNumber | String | Batch number associated to the payment | nvarchar(25) |
| CCNumber | String | Credit card number | nvarchar(16) |
| CheckNumber | String | Check number used | nvarchar(20) |
| Company | [Object](CompanyProfile.md) | Company information |
| CreatedOn | DateTime | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| CreditAmount | Decimal | Total credit amount | decimal(19,2) |
| Currency | [Object](Currency.md) | Currency information |
| Customer | [Object](Customer.md) | Customer information |
| CustomerId | String | Customer ID specified by the client | nvarchar(25) |
| Identity | String | Unique identifier for the payment | nvarchar(50) |
| IsVoid | Boolean | Indicates if the payment is voided | bit |
| Notes | String | Additional notes for the payment | nvarchar(20) |
| PaymentApplies | [Object](PaymentApply.md) | Invoice(s) the payment is applied to |
| PaymentId | String | Payment number | nvarchar(25) |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | nvarchar(25) |
| PaymentStatus | String | Status of the payment. Valid options are ``Scheduled``, ``Processed``, ``Failed``, and ``Voided`` | nvarchar(10) |
| PaymentType | String | Payment type of the transaction. Valid options are ``Unknown``, ``FinanceCharge``, ``CreditMemo``, ``Return``, and ``Payment`` | nvarchar(20) |
| PrepaymentAmount | Decimal | Additional prepayment amount | decimal(19,2) |
| Transaction | [Object](ProcessPayment.md#ProcessPaymentResponse) | Transaction details associated to the payment | 
