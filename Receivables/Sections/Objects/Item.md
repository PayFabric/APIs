## Invoice
There are two Item objects that represent an item in the PayFabric Receivables website, ItemPost, and ItemResponse. 

## ItemPost
The item object represents an item to be used when creating invoices on the PayFabric Receivables Management Portal.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :---------| :--------- | :--------- |
| CommodityCode | String | N | Commodity code of the item | 255 |
| Description | String | N | Description of the item | 100 |
| ID | String | Y | Item code | 50 |
| UnitOfMeasure | String | N | Unit of measure | 25 |
| UnitPrice | Decimal | N | Unit price | 19, 5 |

## ItemResponse
The item object represents an item to be used when creating invoices on the PayFabric Receivables Management Portal.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CommodityCode | String | Commodity code of the item | 255 |
| CreatedOn | DateTime | Timestamp indicating when this item was created |  |
| Description | String | Description of the item | 100 |
| ID | String | Item code | 50 |
| ModifiedOn | DateTime | Timestamp indicating when this item was modified |  |
| UnitOfMeasure | String | Unit of measure | 25 |
| UnitPrice | Decimal | Unit price | 19, 5 |