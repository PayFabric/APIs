## Email
There are two email objects that represent an email that has been sent from the PayFabric Receivables website, EmailReportPagingResponse, and EmailReportResponse. 


## EmailReportPagingResponse
This object is used when getting emails through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |  |
| Total | Int | Total number of results |  |
| Result | [Array of Objects](Email.md#EmailReportResponse) | Email response details |

## EmailReportResponse
This object is used when getting an email on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| EmailId | String | Email identifier | 50 |
| CustomerId | String | Customer ID | 50 |
| CustomerName | String | Customer name | 100 |
| CreatedOn | DateTime | Created on date |  |
| Recipients | String | Email addresses of who the email has been sent to | 1000 |
| Type | String | Email type | 100 |
| EmailTemplateName | String | Email template name | 150 |
