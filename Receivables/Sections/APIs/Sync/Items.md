Items
============

The Item API is used for creating and updating item information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Item
--------------------

* `POST /item` will create or update an item on the PayFabric Receivables website based on the JSON request payload. If updating an item, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
	"CommodityCode": "TEST",
	"Description": "TEST Item",
	<b>"ID": "TEST"</b>,
	"UnitOfMeasure": "EACH",
	"UnitPrice": "30.00"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Item.md#Item).  

###### Response
<pre>
	true
</pre>


Get an Item
--------------------

* `GET /item` will get an item on the PayFabric Receivables website based on the id provided.  

###### Request
<pre>
	GET /item?id=TEST
</pre>

###### Response
<pre>
{
	"CommodityCode": "TEST",
	"CreatedOn": "10/30/2017 3:19:11 PM",
	"Description": "TEST Item",
	"ID": "TEST",
	"ModifiedOn": "10/30/2017 3:19:11 PM",
	"UnitOfMeasure": "EACH",
	"UnitPrice": "30.00"
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Item.md#ItemResponse).

