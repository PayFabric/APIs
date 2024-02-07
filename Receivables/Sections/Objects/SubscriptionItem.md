## Subscription Item
The Subscription item object represents a line item to be associated to a subscription. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Subscription](Subscription.md)).

## SubscriptionItemPost
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Comment | String | N | Additional comment for the item | 500 |
| CommodityCode | String | N | Commodity code of the item | 255 |
| Description | String | N | Description of the item | 100 |
| Frequency | String | Y | Frequency this item should be purchased. Valid options are ``Monthly``, ``Quarterly``, and ``Annually`` | 20 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| Id | String | Y | Subscription item identifier | 50 |
| ItemCode | String | Y | Item code | 50 |
| Markdown | Decimal | N | Total markdown amount | 19, 5 |
| NextBillDate | DateTime | Y | The next bill date of the item |  |
| NextBillDay | int | N | The next bill day of the item |  |
| Occurrences | String | N | Number of occurrences the item should create. Valid options are ``Unlimited``, or a number between 1 and 24 |  |
| Quantity | Decimal | N | Number of quantity | 19, 5 |
| Sequence | Int | Y | Line item number identifier |  |
| Taxable | Boolean | N | Indicates if the item is taxable |  |
| Taxes | [Array of Objects](SubscriptionItemTax.md) | N | Subscrition line item taxes |  |
| UnitOfMeasure | String | N | Unit of measure | 25 |
| UnitPrice | Decimal | N | Unit price | 19, 5 |


## SubscriptionItemResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Comment | String | Additional comment for the item | 500 |
| CommodityCode | String | Commodity code of the item | 255 |
| Description | String | Description of the item | 100 |
| Frequency | String | Frequency this item should be purchased. Valid options are ``Monthly``, ``Quarterly``, and ``Annually`` | 20 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| Id | String | Subscription item identifier | 50 |
| ItemCode | String | Item code | 50 |
| Markdown | Decimal | Total markdown amount | 19, 5 |
| NextBillDate | DateTime | The next bill date of the item |  |
| NextBillDay | int | The next bill day of the item |  |
| Occurrences | String | Number of occurrences the item should create. Valid options are ``Unlimited``, or a number between 1 and 24 |  |
| Quantity | Decimal | Number of quantity | 19, 5 |
| Sequence | Int | Line item number identifier |  |
| StartDate | DateTime | The date the item started in the subscription |  |
| Taxable | Boolean | Indicates if the item is taxable |  |
| Taxes | [Array of Objects](SubscriptionItemTax.md) | Subscrition line item taxes |  |
| UnitOfMeasure | String | Unit of measure | 25 |
| UnitPrice | Decimal | Unit price | 19, 5 |
