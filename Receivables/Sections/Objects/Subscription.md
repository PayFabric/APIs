## Subscription
There are two Subscrijption objects that represent a valid subscription to be used in the PayFabric Receivables website, SubscriptionPost and SubscriptionResponse. 


## SubscriptionPost
This object is used when creating a subscription on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressResponse) | N | Billing address object | 
| Comments | String | N | Additional comments | 500 |
| CopyEmail | Array of Strings | N | CC'd recipients to be used in e-mail notifications regarding an individual invoice | 1000 |
| CreatedOn | String | N | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| CustomerId | String | Y | Customer ID specified by the client | 50 |
| Currency | String | N | Currency code | 10 |
| Email | String | N | Recipient to be used in e-mail notifications regarding an individual invoice, must be a single valid email address | 255 |
| Id | String | Y | Subscription identifier | 50 |
| InvoiceType | String | N | Invoice type | 50 |
| LastBillDate | String | N | Timestamp indicating when the last bill date was. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| NextBillDate | String | N | Timestamp indicating when the next bill date is. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| PaymentMethod | Guid | N | Payment method to be used for processing |  |
| PaymentTerms | String | N | Payment terms | 50 |
| PONumber | String | N | Purchase order number | 50 |
| ShippingAddress | [Object](Address.md#AddressResponse) | N | Shipping address object |  |
| Status | String | N | Status of the subscription. Valid options are ``Open``, and ``Closed`` | 10 |
| SubscriptionItems | [Array of Objects](SubscriptionItem.md#SubscriptionItemResponse) | Y | Subscription line item object |  |
| TaxGroup | String | N | Tax group to be applied | 50 |


## SubscriptionResponse
This object is used when getting subscriptions on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressResponse) | Billing address object | 
| Comments | String | Additional comments | 500 |
| CopyEmail | Array of Strings | CC'd recipients to be used in e-mail notifications regarding an individual invoice | 1000 |
| CreatedOn | String | Timestamp indicating when this document was created. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| CustomerId | String | Customer ID specified by the client | 50 |
| Currency | String | Currency code | 10 |
| Email | String | Recipient to be used in e-mail notifications regarding an individual invoice, must be a single valid email address | 255 |
| Id | String | Subscription identifier | 50 |
| InvoiceType | String | Invoice type | 50 |
| LastBillDate | String | Timestamp indicating when the last bill date was. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| NextBillDate | String | Timestamp indicating when the next bill date is. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| PaymentMethod | Guid | Payment method to be used for processing |  |
| PaymentTerms | String | Payment terms | 50 |
| PONumber | String | Purchase order number | 50 |
| ShippingAddress | [Object](Address.md#AddressResponse) | Shipping address object |  |
| Status | String | Status of the subscription. Valid options are ``Open``, and ``Closed`` | 10 |
| SubscriptionItems | [Array of Objects](SubscriptionItem.md#SubscriptionItemResponse) | Subscription line item object |  |
| TaxGroup | String | Tax group to be applied | 50 |