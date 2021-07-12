Email Receipt
=================

The PayFabric Email Receipt APIs are used for configure the email receipt template and send receipt to specific email address.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Get Email Receipt Templates
---------------------------

* `GET /Transaction/EmailTemplate?transactionType=Capture&tender=Credit` will return the transaction email receipt template for specified tender and transaction type.

| Parameter  | Description|
| :-----------|:---------| 
| Tender | Accept value is 'Credit' and 'ECheck'. |
| TransactionType | When `Tender` is CreditCard, `TransactionType` can be 'Sale','Book','Capture','Refund','Force' or 'Void'. When `Tender` is ECheck, `TransactionType` can be 'Sale', 'Refund' or 'Void'|

###### Response
<pre>
{
    "Enabled": false,
    "BCC": [],
    "Subject": "Email receipt template name",
    "Content": "Email Receipt Template Content"
}  
</pre>

Update Email Receipt Template
-----------------------------
* `Patch /Transaction/EmailTemplate?transactionType=Sale&tender=Credit&updateAll=false` will update the transaction email receipt template for specified tender and transaction type.

###### Request
<pre>
{
    "Enabled": true,
    "BCC": ["haiyan.zhang@nodus.com"],
    "Subject": "Payment notification from PayFabric",
    "Content": "Email Receipt Template Content"
}
</pre>
| Parameter  | Description|
| :-----------|:---------| 
| Tender | Accept value is 'Credit' and 'ECheck'. |
| TransactionType | When `Tender` is CreditCard, `TransactionType` can be 'Sale','Book','Capture','Refund','Force' or 'Void'. When `Tender` is ECheck, `TransactionType` can be 'Sale', 'Refund' or 'Void'|
| UpdateAll|Bool, Indicates whether this update will apply to all email receipt templates.  |

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the tender and transaction type are not match or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Send a transaction receipt
---------------------------
* `POST /Transaction/21052350000948/EmailReceipt` will send the email receipt for specified transaction to specified email addresses.

###### Request
<pre>
{
    "To": ["emailaddress1","emailaddress2"],
    "Cc": ["emailaddress3","emailaddress4"],
    "Bcc": ["emailaddress5","emailaddress6"]
}
</pre>

<b>Note</b>
1. Use comma to seperate the multiple email addresses.
2. Even the email receipt is not enabled, this API still can send the email receipt.

###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified transaction is not approved or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.
