## Subscription Item Tax
The Subscription item tax object represents a line item tax to be associated to a subscription item. This will always need to be sent as an array or list. This object may be included as a child attribute of other JSON objects (such as [Subscription Item](SubscriptionItem.md)).

## SubscriptionItemTaxPost
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Name | String | Y | Name of the tax | 50 |


## SubscriptionItemTaxResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Name | String | Y | Name of the tax | 50 |
| Rate | Decimal | N | Rate for the tax | 1, 8 |
