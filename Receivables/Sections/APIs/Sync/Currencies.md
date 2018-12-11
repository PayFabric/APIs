Currency
============

The Currency API is used for creating, updating, deleting and viewing available currencies. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create a Currency
--------------------

* `POST /currencies` will create and save a currency to the PayFabric Receivables website based on the JSON request payload

###### Request
<pre>
{
	<b>"Name": "USD"</b>,
	<b>"CurrencyCode": "USD"</b>,
	"LongName": "USD Currency",
	"IsFuncCurrency": false,
	"Symbol": "$"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Currency.md#CurrencyPost).

###### Response
<pre>
	true
</pre>


Retrieve a currency by currency code
--------------------

* `GET /currencies/{CurrencyCode}` will get the details for a currency on the PayFabric Receivables website based on the URL parameter

###### Request
<pre>
	GET /currencies/USD
</pre>

###### Response
<pre>
{
	"CurrencyGuid": "faea05ff-d6e8-4f54-b345-efc8978b2199",
	"CCSetupId": "PayFlowProCredit",
	"ECSetupId": "PaymentechECheck",
	"IsUsingECheck": true,
	"IsUsingCreditCard": true,
	"IsValid": true,
	"Name": "USD",
	"CurrencyCode": "USD",
	"Symbol": "$",
	"LongName": "US Dollars",
	"IsFuncCurrency": true
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Currency.md#CurrencyResponse).


Delete a Currency
--------------------

* `DELETE /currencies/{CurrencyCode}` will delete a currency on the PayFabric Receivables website based on the URL parameter

###### Request
<pre>
	DELETE /currencies/USD
</pre>

###### Response
<pre>
	true
</pre>
