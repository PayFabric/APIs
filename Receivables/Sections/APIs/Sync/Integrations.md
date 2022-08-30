Integrations
============

The Integration API is used for updating, and viewing integration information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](../Sync/Token.md) on how to authenticate.

Update the Integration Document
--------------------

* `PATCH /integrations` will update a document on the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/Integration.md#IntegrationPost)
```json
{
	"Documents": [{
		"DocumentId": "APIPMT000000001",
		"Status": "Success",
		"DocumentType": "Payment"
	}]
}
```


###### Response
```text
true
```


Retrieve Integration Documents
--------------------

* `GET /integrations` will get the details for integrating documents on the PayFabric Receivables website based on the URL parameter

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
| Date | Search by the document date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FailedAttempts | Number of failed attempts integrating | [Numeric Range Filter](../QueryFilter.md#numeric-range-filter) |
| LastAttempt | Date of last attempt made integrating | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |
| Status | Status of the document integrating | String |
| Type | Type of the document integrating | String |

###### Request
```htpp
GET /integrations?filter.pageSize=10&filter.pageIndex=0&filter.criteria.Status=Pending
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Integration.md#IntegrationPagingResponse)
```json
{
    "Index": 0,
    "Total": 2,
    "Result": [
        {
            "IntegrationId": "b3f5d01c-92cc-ec11-a36a-b0c09018d6d4",
            "Date": "2018-05-29T10:38:34.037",
            "DocumentId": "WEBPMT0000000020",
            "Status": "Pending",
            "Type": "Payment",
            "ErrorMessage": null,
            "FailedAttempts": 0,
            "LastAttempt": "0001-01-01T00:00:00",
	    "CreatedBy": "Nodus0001"
        },
        {
            "IntegrationId": "baf5d01c-92cc-ec11-a36a-b0c09018d6d4",
            "Date": "2018-05-29T10:00:42.66",
            "DocumentId": "WEBPMT0000000019",
            "Status": "Pending",
            "Type": "Payment",
            "ErrorMessage": null,
            "FailedAttempts": 0,
            "LastAttempt": "0001-01-01T00:00:00",
	    "CreatedBy": "Nodus0001"
        }
    ]
}
```
