Currencies
============

The Currency API is used for viewing the information of a currency housed on the PayFabric Receivables Website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve a Currency
--------------------

* `GET /currency/{CurrencyCode}` will get the details for a currency on the PayFabric Receivables website based on the URL parameter

###### Request
<pre>
	GET /currency/USD
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
