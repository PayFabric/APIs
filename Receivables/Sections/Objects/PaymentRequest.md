## Payment Request
There are two payment request objects that represent the payment being requested to be paid.

## PaymentRequestDto
This object is used when creating a payment request to be sent to the customer.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :---------| :--------- | :--------- |
| CopyEmail | Array of Strings | N | CC'd recipients to be used in e-mail notification | 1000 |
| CustomerId | String | Y | Customer ID specified by the client | 50 |
| Email | String | N | Recipient to be used in the e-mail notification, must be a single valid email address. Required if the EmailTemplate is populated | 255 |
| EmailTemplate | String | N | Email template to be used when sending the request | 255 |
| Invoices | Array of Strings | N | List of invoice identities to be paid. Required if PrepaymentAmount is zero and PrepaymentEdit is false |  |
| PrepaymentAmount | Decimal | N | Amount of a prepayment to include.  Required if no invoices are provided in Invoices and PrepaymentEdit is false | 16,2 |
| PrepaymentEdit | Boolean | N | Allow the Prepayment amount to be modified by the recipient. Required if no invoices are provided in Invoices and PrepaymentAmount is zero |  |
| TransactionType | String | N | Type of transaction to be associated. Valid values are `Sale`, or `Authorization` | 15 |

## PaymentRequestResponse
This object is used when in the response data after creating a payment request to be sent to the customer.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccessCode | String | Payment Link access code | 50 |
| Message | String | Error message | 255 |
| PaymentRequestURL | String | Full payment request url including the access code | 2000 |
| Result | Boolean | Result of the request |  |
