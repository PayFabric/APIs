## Currency
There are two Currency objects that represent a valid currency to be used in the PayFabric Receivables website, CurrencyPost and CurrencyResponse. 


## CurrencyPost
This object is used when creating a currency on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CurrencyCode | String | Y | Unique value associated to the currency | 10 |
| IsFuncCurrency | Boolean | N | Indicates if the currency will be used as the main currency |  |
| LongName | String | N | Long name to describe the currency | 50 |
| Name | String | Y | Name of the currency | 50 |
| Symbol | String | N | Currency symbol | 5 |


## CurrencyResponse
This object is used when getting a currency on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CCSetupID | String | SetupID associated to the currency used to process credit cards | 50 |
| CurrencyCode | String | Unique value associated to the currency | 10 |
| CurrencyGuid | Guid | Unique identifier associated to the currency |  |
| ECSetupID | String | SetupID associated to the currency used to process eChecks | 50 |
| IsFuncCurrency | Boolean | Indicates if the currency will be used as the main currency |  |
| IsUsingCreditCard | Boolean | Indicates if the currency can be used to process credit cards |  |
| IsUsingEcheck | Boolean | Indicates if the currency can be used to process eChecks |  |
| IsValid | Boolean | Indicates if the currency is valid and can be used |  |
| LongName | String | Long name to describe the currency | 50 |
| Name | String | Short name to describe the currency | 50 |
| Symbol | String | Currency symbol | 5 |