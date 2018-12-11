Document History
============

The Document History API is used to show that a historical document from the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve Document History
--------------------

* `GET /documents/history` will get the document information from the PayFabric Receivables website based on the JSON request payload

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the document | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Search by currency | [String](../QueryFilter.md#string) |
| DocumentDate | Search by the document date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| DocumentId | Document number | [String Filter](../QueryFilter.md#string-filter) |
| DocumentType | Document type | [String Filter](../QueryFilter.md#string-filter) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |

###### Request
<pre>
	GET /document/history?filter.pageSize=10&filter.pageIndex=0&filter.criteria.DocumentDate.Min=2010-01-01
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 2,
    "Result": [
        {
            "Amount": 5873.79,
            "Currency": {
		"Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": true
            },
	    "DocumentGuid": "00000000-0000-0000-0000-000000000000",
            "DocumentId": "ORDST1026",
            "DocumentType": "Invoice",
            "PONumber": "4567",
            "DocumentDate": "2015-05-08T00:00:00"
        },
        {
            "Amount": 358.2,
            "Currency": {
		"Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": true
            },
	    "DocumentGuid": "00000000-0000-0000-0000-000000000001",
            "DocumentId": "ORDST2095",
            "DocumentType": "Invoice",
            "PONumber": "4567",
            "DocumentDate": "2016-03-14T00:00:00"
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/DocumentHistory.md#DocumentHistoryPagingResponse).


Retrieve Document History Currencies
--------------------

* `GET /documents/history/currencies` will get the document information from the PayFabric Receivables website based on the JSON request payload

###### Response
<pre>
[
	{
		"CurrencyGuid": "faea05ff-d6e8-4f54-b345-efc8978b2199",
		"CCSetupId": "PayFlowProCredit",
		"ECSetupId": "PaymentechECheck",
		"IsUsingECheck": true,
		"IsUsingCreditCard": true,
		"IsValid": true,
		"Name": "USD",
		"CurrencyCode": "Z-US$",
		"Symbol": "$",
		"LongName": "US Dollars",
		"IsFuncCurrency": true
	}
]
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Currency.md#CurrencyResponse).


Export Document History
--------------------

* `POST /documents/history/export` will get the document information from the PayFabric Receivables website based on the JSON request payload

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the document | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Search by currency | [String](../QueryFilter.md#string) |
| DocumentDate | Search by the document date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| DocumentId | Document number | [String Filter](../QueryFilter.md#string-filter) |
| DocumentType | Document type | [String Filter](../QueryFilter.md#string-filter) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |

###### Request
<pre>
	POST /document/history?filter.pageSize=10&filter.pageIndex=0&filter.criteria.DocumentDate.Min=2010-01-01
</pre>

###### Response
This will return a CSV file with the historical documents
