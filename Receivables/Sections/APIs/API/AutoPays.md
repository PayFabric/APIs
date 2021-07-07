AutoPays
============

The AutoPay API is used for all information related to an AutoPay or AutoPay template on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve all AutoPay templates
--------------------

* `GET /autopaytemplates` will retrieve all autopay templates.

###### Request
<pre>
	GET /autopaytemplates
</pre>

###### Response
<pre>
[
  {
    "Currency": "",
    "Description": "Pay outstanding balance on a monthly basis",
    "AmountOption": "Outstanding",
    "FixedAmountOption": "None",
    "FixedAmount": 0.0,
    "Frequency": "Monthly",
	"InvoiceTypeOption": "SelectedInvoices",
	"InvoiceTypes": [ "STDINV" ],
    "Start": "UserChoice",
    "StartDay": null,
	"ApplyCredits": true,
    "CurrencyOption": "CustomerCurrency",
    "AutoPayTemplateGuid": "5edab5e7-892d-ea11-a2b7-b0c09018d6d4",
    "Name": "Monthly AutoPay"
  }
]
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AutoPayTemplate.md).


Retrieve a specific AutoPay template
--------------------

* `GET /autopaytemplate?id={autopayTemplateGuid}` will retrieve the specific autopay template.

###### Request
<pre>
	GET /autopaytemplate?id=5edab5e7-892d-ea11-a2b7-b0c09018d6d4
</pre>

###### Response
<pre>
{
  "Currency": "",
  "Description": "Pay outstanding balance on a monthly basis",
  "AmountOption": "Outstanding",
  "FixedAmountOption": "None",
  "FixedAmount": 0.0,
  "Frequency": "Monthly",
  "InvoiceTypeOption": "SelectedInvoices",
  "InvoiceTypes": [ "STDINV" ],
  "Start": "UserChoice",
  "StartDay": null,
  "ApplyCredits": true,
  "CurrencyOption": "CustomerCurrency",
  "AutoPayTemplateGuid": "5edab5e7-892d-ea11-a2b7-b0c09018d6d4",
  "Name": "Monthly AutoPay"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AutoPayTemplate.md).


Retrieve the current customer's AutoPay
--------------------

* `GET /autopay` will retrieve the autopay for the currently logged in customer.

###### Request
<pre>
	GET /autopay
</pre>

###### Response
<pre>
{
  "AmountOption": "Outstanding",
  "CustomerId": "AARONFIT0001",
  "Currency": "Z-US$",
  "Description": "Pay outstanding balance on a monthly basis",
  "FixedAmount": 0.0,
  "InvoiceTypes": [ "STDINV" ],
  "PaymentDay": 0,
  "Frequency": "Daily",
  "ApplyCredits": true,
  "NextPaymentDate": "2020-01-04T18:01:38.8100000Z",
  "PaymentMethod": "4098a646-b0d1-47b7-98c8-ccd7ce15e901"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AutoPay.md).


Save an AutoPay
--------------------

* `POST /autopay` will save the AutoPay to the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	POST /autopay
</pre>

<pre>
{
    "AmountOption": "Outstanding",
    "CustomerID": "AARONFIT0001",
    "Currency": "Z-US$",
    "Description": "Pay any outstanding invoices each week beginning on the 15th",
    "FixedAmount": 0,
    "Frequency": "Monthly",
	"InvoiceTypes": [ "STDINV" ],
	"ApplyCredits": true,
    "NextPaymentDate": "2019-07-15T21:17:37.0300000Z",
    "PaymentMethod": "015eb504-46c3-4574-907c-e9f30589c90d"
}
</pre>

###### Response
<pre>
true
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AutoPay.md).


Update an AutoPay
--------------------

* `PATCH /autopay` will update the AutoPay to the PayFabric Receivables website based on the JSON request payload. You only need to send what needs to be changed.

###### Request
<pre>
	PATCH /autopay
</pre>

<pre>
{
    "AmountOption": "Outstanding",
    "CustomerID": "AARONFIT0001",
    "Currency": "Z-US$",
    "Description": "Pay any outstanding invoices each week beginning on the 15th",
    "FixedAmount": 0,
    "Frequency": "Monthly",
	"InvoiceTypes": [ "STDINV" ],
	"ApplyCredits": true,
    "NextPaymentDate": "2019-07-15T21:17:37.0300000Z",
    "PaymentMethod": "015eb504-46c3-4574-907c-e9f30589c90d"
}
</pre>

###### Response
<pre>
true
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AutoPay.md).


Delete an AutoPay
--------------------

* `DELETE /autopay` will delete the AutoPay associated to the currently logged in customer.

###### Request
<pre>
	DELETE /autopay
</pre>

###### Response
<pre>
true
</pre>
