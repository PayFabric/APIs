Currency
============

The Currency API is used for creating, updating, deleting and viewing available currencies. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create a Currency
--------------------

* `POST /currencies` will create and save a currency to the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Currency.md#CurrencyPost)
```json
{
	"Name": "USD",
	"CurrencyCode": "USD",
	"Longname": "US Dollar",
	"Symbol": "$"
}
```

###### Response
```text
true
```


Retrieve a currency by currency code
--------------------

* `GET /currencies/{CurrencyCode}` will get the details for a currency on the PayFabric Receivables website based on the URL parameter

###### Request
```http
GET /currencies/USD HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Currency.md#CurrencyResponse)
```json
{
	"CCSetupId": "PayFlowProCredit",
	"ECSetupId": "PaymentechECheck",
	"IsUsingECheck": true,
	"IsUsingCreditCard": true,
	"IsValid": true,
	"SurchargePercentage": 0.0,
	"CurrencyGuid": "faea05ff-d6e8-4f54-b345-efc8978b2199",
	"Name": "USD",
	"CurrencyCode": "USD",
	"Symbol": "$",
	"LongName": "US Dollars",
	"IsFuncCurrency": true
}
```


Delete a Currency
--------------------

* `DELETE /currencies/{CurrencyCode}` will delete a currency on the PayFabric Receivables website based on the URL parameter

###### Request
```http
DELETE /currencies/USD HTTP/1.1
```

###### Response
```text
true
```
