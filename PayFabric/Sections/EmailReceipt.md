Email Receipt
=================

The PayFabric Email Receipt APIs are used for configure the email receipt template and send receipt to specific email address.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Get Email Receipt Templates
---------------------------

* `GET /payment/3.1/api/Transaction/EmailTemplate?transactionType=Capture&tender=Credit` will return the transaction email receipt template for specified tender and transaction type.

| Parameter  | Description|
| :-----------|:---------| 
| Tender | Accept value is 'Credit' and 'Check'. |
| TransactionType | When `Tender` is Credit, `TransactionType` can be 'Sale','Book','Capture','Refund','Force' or 'Void'. When `Tender` is Check, `TransactionType` can be 'Sale', 'Refund' or 'Void'|

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
* `Patch /payment/3.1/api/Transaction/EmailTemplate?transactionType=Sale&tender=Credit&updateAll=false` will update the transaction email receipt template for specified tender and transaction type. <b>Note:</b>Use comma to separate the multiple email addresses.

###### Request
<pre>
{
    "Enabled": true,
    "BCC": ["success+test@simulator.amazonses.com"],
    "Subject": "Payment notification from PayFabric",
    "Content": "Email Receipt Template Content"
}
</pre>
| Parameter  | Description|
| :-----------|:---------| 
| Tender | Accept value is 'Credit' and 'Check'. |
| TransactionType | When `Tender` is Credit, `TransactionType` can be 'Sale','Book','Capture','Refund','Force' or 'Void'. When `Tender` is Check, `TransactionType` can be 'Sale', 'Refund' or 'Void'|
| UpdateAll|Bool, Indicates whether this update will apply to all email receipt templates.  |

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the tender and transaction type are not match or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Send a Transaction Receipt
---------------------------
* `POST /payment/3.1/api/Transaction/{TransactionKey}/EmailReceipt` will send the email receipt for specified transaction to specified email addresses.

###### Request
<pre>
{
    "To": ["sample1@email.com","sample2@email.com"],
    "Cc": ["sample3@email.com","sample4@email.com"],
    "Bcc": ["sample5@email.com","sample6@email.com"]
}
</pre>

<b>Note</b>
1. Use comma to seperate the multiple email addresses.
2. Even the email receipt is not enabled, this API still can send the email receipt.

###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified transaction is not approved or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is failed.
