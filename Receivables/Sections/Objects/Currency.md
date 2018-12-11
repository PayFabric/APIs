## Currency
There are two Currency objects that represent a valid currency to be used in the PayFabric Receivables website, CurrencyPost and CurrencyResponse. 


## CurrencyPost
This object is used when creating a currency on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Name\* | String | Name of the currency | nvarchar(50) |
| CurrencyCode\* | String | Unique value associated to the currency | nvarchar(10) |
| IsFuncCurrency | Boolean | Indicates if the currency will be used as the main currency | bit |
| LongName | String | Long name to describe the currency | nvarchar(50) |
| Symbol | String | Currency symbol | nvarchar(5) |
\*Required


## CurrencyResponse
This object is used when getting a currency on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CurrencyCode | String | Unique value associated to the currency | nvarchar(10) |
| CurrencyGuid | Guid | Unique identifier associated to the currency | uniqueidentifier |
| CCSetupID | String | SetupID associated to the currency used to process credit cards | nvarchar(50) |
| ECSetupID | String | SetupID associated to the currency used to process eChecks | nvarchar(50) |
| IsUsingCreditCard | Boolean | Indicates if the currency can be used to process credit cards | bit |
| IsUsingEcheck | Boolean | Indicates if the currency can be used to process eChecks | bit |
| IsValid | Boolean | Indicates if the currency is valid and can be used | bit |
| Name | String | Short name to describe the currency | nvarchar(50) |
| LongName | String | Long name to describe the currency | nvarchar(50) |
| IsFuncCurrency | Boolean | Indicates if the currency will be used as the main currency | bit |
| Symbol | String | Currency symbol | nvarchar(5) |