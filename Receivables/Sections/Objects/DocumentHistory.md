## Document History
Document History object represents a historical document found in the PayFabric Receivables website, either invoices or payments.

## DocumentHistoryResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Amount of the document | 19, 5 |
| Currency | [Object](Currency.md#currencypost) | Currency code | 10 |
| DocumentDate | DateTime | Date of the document |  |
| DocumentGuid | Guid | Document unique identifier |  |
| DocumentId | String | Document number | 50 |
| DocumentType | String | Document type | 50 |
| PONumber | String | Purchase order number | 50 |

## DocumentHistoryPagingResponse
This object is used when getting document history information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |
| Total | Int | Total number of results |
| Result | [Object](DocumentHistory.md#DocumentHistoryResponse) | Document history response details |