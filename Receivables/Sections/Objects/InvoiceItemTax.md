## Invoice Item Tax
The invoice item tax object represents a line item tax to be associated to an invoice item. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Invoice Item](InvoiceItem.md)).

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Amount | Decimal | N | Tax amount | 19, 5 |
| Name | String | Y | Name of the tax | 50 |
| Rate | Decimal | N | Tax rate | 1, 8 |
