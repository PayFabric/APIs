## Tax
There are two Tax objects that represent a valid tax to be used in the PayFabric Receivables website, TaxPost and TaxResponse. 


## TaxPost
This object is used when creating a tax on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Description | String | Y | Description of the tax | 100 |
| Name | String | Y | Name of the tax | 50 |
| Rate | Decimal | Y | Rate for the tax | 1, 8 |
| TaxGroups | Array of Strings | N | Tax groups associated |  |


## TaxResponse
This object is used when getting a tax on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Message | String | Error message |
| Result | Boolean | Result of getting the taxes |
| Data | [Array of Objects](Tax.md#TaxPost) | List of taxes |
