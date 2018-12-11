## Integration
There are three Integration objects that represent the integration of invoices and payments in the PayFabric Receivables website to the back office, IntegrationPost, IntegrationResponse and IntegrationPagingResponse. 


## IntegrationPost
This object is used when updating the integration information on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DocumentId\* | String | Document number | nvarchar(50) |
| Status\* | String | Indicates the status of the document. Can be either ``Pending``, ``Success``, or ``Failed`` | varchar(25) |
| ErrorMessage | String | Error message if it failed to submit | nvarchar(max) |
\*Required

## IntegrationResponse
This object is used when getting the integration information on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Date | DateTime | Date of the document | datetime |
| DocumentId | String | Document number | nvarchar(50) |
| ErrorMessage | String Error message if it failed to submit | nvarchar(max) |
| FailedAttempts | Int | Number of failed attempts | int |
| IntegrationId | Guid | Unique identifier for the document | uniqueidentifier |
| LastAttempt | DateTime | Date and time of last attempt | datetime |
| Status | String | Status of the document | nvarchar(25) |
| Type | String | Type of the document | nvarchar(25) |

## IntegrationPagingResponse
This object is used when getting integration information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Index | Int | Page number of results  | int |
| Total | Int | Total number of results | int |
| Result | [Object](Integration.md#IntegrationResponse) | Integration response details |