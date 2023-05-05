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
| Invoices | Array of Strings | Y | List of invoice identities to be paid |  |


## PaymentRequestResponse
This object is used when in the response data after creating a payment request to be sent to the customer.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccessCode | String | Payment Link access code | 50 |
| Message | String | Error message | 255 |
| PaymentRequestURL | String | Full payment request url including the access code | 2000 |
| Result | Boolean | Result of the request |  |
