## Item
The item object represents an item to be used when creating invoices on the PayFabric Receivables Management Portal.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CommodityCode | String | Commodity code of the item | nvarchar(255) |
| Description | String | Description of the item | nvarchar(101) |
| ID | String | Item code | nvarchar(50) |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price in the functional currency | decimal(19,2) |

## ItemResponse
The item object represents an item to be used when creating invoices on the PayFabric Receivables Management Portal.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CommodityCode | String | Commodity code of the item | nvarchar(255) |
| CreatedOn | DateTime | Timestamp indicating when this item was created | datetime |
| Description | String | Description of the item | nvarchar(101) |
| ID | String | Item code | nvarchar(50) |
| ModifiedOn | DateTime | Timestamp indicating when this item was modified | datetime |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price in the functional currency | decimal(19,2) |