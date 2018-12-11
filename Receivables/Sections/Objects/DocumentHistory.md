## Document History
Document History object represents a historical document found in the PayFabric Receivables website, either invoices or payments.

## DocumentHistoryResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Amount of the document | decimal(19,5) |
| Currency | [Object](Currency.md) | Currency code | nvarchar(10) |
| DocumentGuid | Guid | Document unique identifier | uniqueidentifier |
| DocumentDate | DateTime | Date of the document | datetime |
| DocumentId | String | Document number | nvarchar(50) |
| DocumentType | String | Document type | nvarchar(50) |
| PONumber | String | Purchase order number | nvarchar(50) |

## DocumentHistoryPagingResponse
This object is used when getting document history information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Index | Int | Page number of results  | int |
| Total | Int | Total number of results | int |
| Result | [Object](DocumentHistory.md#DocumentHistoryResponse) | Document history response details |