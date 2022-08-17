## Payment Receipt
The payment receipt object represents a receipt of a payment in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AdditionalFee | Decimal | Total additional fee amount | 19, 2 |
| Amount | Decimal | Total payment amount | 19, 2 |
| BalanceAmount | Decimal | Amount remaining to be applied | 19, 2 |
| BatchNumber | String | Batch number associated to the payment | 25 |
| CCNumber | String | Credit card number | 16 |
| CheckNumber | String | Check number used | 20 |
| Company | [Object](CompanyProfile.md) | Company information |
| CreatedOn | DateTime | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| CreditDistributions | Array of [Object](ApplyCredit.md) | Credits used in processing |
| CreditAmount | Decimal | Total credit amount | 19, 2 |
| Currency | [Object](Currency.md) | Currency information |
| Customer | [Object](Customer.md) | Customer information |
| CustomerId | String | Customer ID specified by the client | 25 |
| Identity | String | Unique identifier for the payment | 50 |
| Notes | String | Additional notes for the payment | 20 |
| PaymentApplies | [Object](PaymentApply.md) | Invoice(s) the payment is applied to |
| PaymentId | String | Payment number | 25 |
| PaymentMethod | String | Payment method used with the payment. Valid options are ``Unknown``, ``CreditCard``, ``ECheck``, ``Check``, and ``Cash`` | 25 |
| PaymentStatus | String | Status of the payment. Valid options are ``Scheduled``, ``Processed``, ``Failed``, and ``Voided`` | 10 |
| PaymentType | String | Payment type of the transaction. Valid options are ``Unknown``, ``FinanceCharge``, ``CreditMemo``, ``Return``, and ``Payment`` | 20 |
| PrepaymentAmount | Decimal | Additional prepayment amount | 19, 2 |
| Surcharges | Array of [Object](PaymentApply.md#paymentapplyresponse) | List of surcharges |
| Transaction | [Object](Transaction.md) | Transaction details associated to the payment | 
