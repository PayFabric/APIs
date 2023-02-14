Taxes
============

The Tax API is used for creating, updating and viewing available taxes. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Tax
--------------------

* `POST /tax` will create and save a tax to the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Tax.md#TaxPost)
```json
{
	"Name": "StateTax",
	"Description": "StateTax"
	"Rate": "0.08"
}
```

###### Response
```text
true
```


Retrieve Taxes
--------------------

* `GET /tax` will get the details for a tax on the PayFabric Receivables website based on the URL parameter

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'. At least one of the filters below must be included.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| Name | Name of the tax | [String Filter](../QueryFilter.md#string-filter) |
| Group | Tax group name | [String Filter](../QueryFilter.md#string-filter) |

###### Request
```http
GET /tax?taxFilter.Group=Default HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Tax.md#TaxResponse)
```json
{
    "Message": "",
    "Result": true,
    "Data": [
        {
            "Name": "SalesTax",
            "Description": "SalesTax",
            "Rate": 0.08,
            "TaxGroups": [
                "Default",
                "Import"
            ]
        }
    ]
}
```
