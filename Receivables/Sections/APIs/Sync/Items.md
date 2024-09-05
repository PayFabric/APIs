Items
============

The Item API is used for creating and updating item information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Item
--------------------

* `POST /item` will create or update an item on the PayFabric Receivables website based on the JSON request payload. If updating an item, make sure to send all values again, otherwise, they will be overwritten.

###### Request
For more information on available fields please see our [object reference](../../Objects/Item.md#ItemPost)
```json
{
	"ID": "TEST"
}
```


###### Response
```text
true
```


Retrieve an Item
--------------------

* `GET /item` will get an item on the PayFabric Receivables website based on the id provided.  

###### Request
```http
GET /item?id=TEST HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Item.md#ItemResponse)
```json
{
	"CommodityCode": "TEST",
	"CreatedOn": "10/30/2017 3:19:11 PM",
	"Description": "TEST Item",
	"ID": "TEST",
	"ModifiedOn": "10/30/2017 3:19:11 PM",
	"TaxExempt": true,
	"UnitOfMeasure": "EACH",
	"UnitPrice": "30.00"
}
```
