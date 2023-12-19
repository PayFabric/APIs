## Invoice Item
The invoice item object represents a line item to be associated to an invoice. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Invoice](Invoice.md)).

## InvoiceItemPost
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Comment | String | N | Additional comment for the item | 500 |
| CommodityCode | String | N | Commodity code of the item | 255 |
| Description | String | N | Description of the item | 100 |
| ExtendedPrice | Decimal | N | Total extended price | 19, 5 |
| ExtensionData | String | N | Additional comment information | 4000 |
| InvoiceNumber | String | N | Invoice number | 50 |
| ItemCode | String | Y | Item code | 50 |
| Markdown | Decimal | N | Total markdown amount | 19,5 |
| NonInventory | Boolean | N | Indicates if the item is a valid predefined item |  |
| PriceLevel | String | N | Price level | 50 |
| Quantity | Decimal | N | Number of quantity | 19, 5 |
| ReqShipDate | DateTime | N | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| SalesPerson | String |  N |SalesPerson number | 25 |
| Sequence | Int | N | Line item number identifier |  |
| ShippingMethod | String | N | Shipping method name | 100 |
| ShippingToAddress | [Object](Address.md#AddressPost) | N | Address object |
| Site | String | N | Site or warehouse | 50 |
| Taxable | Boolean | N | Indicates if the item is taxable |  |
| TaxAmount | Deciaml |  N |Tax amount | 19, 5 |
| Taxes | [Array of Objects](InvoiceItemTax.md) | N | Invoice line item taxes |  |
| UnitOfMeasure | String | N | Unit of measure | 25 |
| UnitPrice | Decimal | N | Unit price | 19, 5 |


## InvoiceItemResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Comment | String | Additional comment for the item | 500 |
| CommodityCode | String | Commodity code of the item | 255 |
| Description | String | Description of the item | 100 |
| ExtendedPrice | Decimal | Total extended price | 19, 5 |
| ExtensionData | String | Additional comment information | 4000 |
| InvoiceNumber | String | Invoice number | 50 |
| InvoiceId | String | Invoice identifier | 50 |
| ItemCode | String | Item code | 50 |
| Markdown | Decimal | Total markdown amount | 19, 5 |
| MarkdownPercentage | Decimal | Markdown percentage | 19, 5 |
| NonInventory | Boolean | Indicates if the item is a valid predefined item |  |
| PriceLevel | String | Price level | 50 |
| Quantity | Decimal | Number of quantity | 19, 5 |
| ReqShipDate | DateTime | Timestamp indicating when this item is required to ship. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| SalesPerson | String | SalesPerson number | 25 |
| Sequence | Int | Line item number identifier |  |
| ShippingMethod | String | Shipping method name | 100 |
| ShippingToAddress | [Object](Address.md#AddressResponse) | Address object |
| Site | String | N | Site or warehouse | 50 |
| Taxable | Boolean | Indicates if the item is taxable |  |
| TaxAmount | Deciaml | Tax amount
| Taxes | [Array of Objects](InvoiceItemTax.md) | N | Invoice line item taxes |  |
| UnitOfMeasure | String | Unit of measure | 25 |
| UnitPrice | Decimal | Unit price | 19, 5 |
