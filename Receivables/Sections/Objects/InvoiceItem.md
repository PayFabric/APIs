## Invoice Item
The invoice item object represents a line item to be associated to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Invoice](Invoice.md)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Description | String | Description of the item | nvarchar(101) |
| ExtendedPrice | Decimal | Total extended price | decimal(19,2) |
| ExtensionData | String | Additional comment information | nvarchar(max) |
| InvoiceNumber | String | Invoice number | nvarchar(50) |
| InvoiceType | String | Invoice type | nvarchar(50) |
| ItemCode | String | Item code | nvarchar(50) |
| Markdown | Decimal | Total markdown amount | decimal(19,5) |
| MarkdownPercentage | Decimal | Markdown percentage | decimal(19,5) |
| NonInventory | Boolean | Indicates if the item is a valid predefined item | bit |
| PriceLevel | String | Price level | varchar(50) |
| Quantity | Decimal | Number of quantity | decimal(19,2) |
| ReqShipDate | DateTime | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| SalesPerson | String | SalesPerson number | nvarchar(25) |
| Sequence | Int | Line item number identifier | int |
| ShippingMethod | String | Shipping method name | varchar(100) |
| ShippingToAddress | [Object](Address.md) | Address object |
| Taxable | Boolean | Indicates if the item is taxable | bit |
| TaxAmount | Deciaml | Tax amount in the functional currency | decimal(19,2) |
| UnitOfMeasure | String | Unit of measure | nvarchar(25) |
| UnitPrice | Decimal | Unit price in the functional currency | decimal(19,2) |
