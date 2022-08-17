Currencies
============

The Currency API is used for viewing the information of a currency housed on the PayFabric Receivables Website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve a Currency
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
    "CCSetupId": "PFP",
    "ECSetupId": "PFP_ECheck",
    "IsUsingECheck": true,
    "IsUsingCreditCard": true,
    "IsValid": true,
    "SurchargePercentage": 0.0,
    "CurrencyGuid": "cbb9d115-92cc-ec11-a36a-b0c09018d6d4",
    "Name": "USD",
    "CurrencyCode": "USD",
    "Symbol": "$",
    "LongName": "US Dollar",
    "IsFuncCurrency": true
}
```
