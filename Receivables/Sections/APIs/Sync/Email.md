Email
============

The Email API is used for viewing emails made on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve Email Report
--------------------

* `GET /reports/emails` will retrieve the email report from PayFabric Receivables website based on the URL parameters

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
| CreatedOn | Search by the created on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| CustomerId | Customer number | [String Filter](../QueryFilter.md#string-filter) |
| CustomerName | Customer name | [String Filter](../QueryFilter.md#string-filter) |
| EmailID | Email identifier | [String Filter](../QueryFilter.md#string-filter) |
| EmailTemplateName | Email template name | [String Filter](../QueryFilter.md#string-filter) |
| Recipients | Recipients email address | [String Filter](../QueryFilter.md#string-filter) |
| Type | Email type | [String Filter](../QueryFilter.md#string-filter) |

###### Request
```http
GET /reports/emails?filter.pageSize=10&filter.pageIndex=0&filter.criteria.CustomerId.EqualsTo=Nodus0001 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Email.md#EmailReportPagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "Type": "NewInvoiceNotificationOutstanding",
            "EmailId": "20231128node125301",
            "CustomerId": "Nodus0001",
            "CustomerName": "Nodus User",
            "CreatedOn": "2023-11-28T19:53:42.7170000Z",
            "Recipients": "Nodus0001@nodus.com",
            "EmailTemplateName": "New Invoice Notification · Outstanding"
        }
    ]
}
```
