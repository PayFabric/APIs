## Integration
There are three Integration objects that represent the integration of invoices and payments in the PayFabric Receivables website to the back office, IntegrationPost, IntegrationResponse and IntegrationPagingResponse. 


## IntegrationPost
This object is used when updating the integration information on the PayFabric Receivables website.

| Attribute | Data Type | Required |Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| DocumentId | String | Y | Document number | 50 |
| DocumentType | String | Y | Indicates the type of the document. Valid values are ``Customer``, ``Invoice``, ``Payment``, and ``Application`` | 25 |
| ErrorMessage | String | N | Error message if it failed to submit | 4000 |
| Status | String | Y | Indicates the status of the document. Valid values are ``Pending``, ``Success``, and ``Failed`` | 25 |

## IntegrationResponse
This object is used when getting the integration information on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Date | DateTime | Date of the document |  |
| DocumentId | String | Document number | 50 |
| ErrorMessage | String Error message if it failed to submit | 4000 |
| FailedAttempts | Int | Number of failed attempts |  |
| IntegrationId | Guid | Unique identifier for the document |  |
| LastAttempt | DateTime | Date and time of last attempt |  |
| Status | String | Status of the document | 25 |
| Type | String | Type of the document | 25 |

## IntegrationPagingResponse
This object is used when getting integration information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |
| Total | Int | Total number of results |
| Result | [Array of Objects](Integration.md#IntegrationResponse) | Integration response details |