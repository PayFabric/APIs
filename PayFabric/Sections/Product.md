Product
=================

The PayFabric Product APIs are used for managing products.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer the [Product Related Objects](/PayFabric/Sections/3.1JSONObjects.md#product) for details.

Get products
------------
* `GET /payment/3.1/api/Product` will return first 50 products by default.

###### Response
<pre>
{
    "Page": "1",
    "TotalRecords": "1",
    "TotalPages": "1",
    "Records": [
        {
            "ID": 25349,
            "ItemNumber": "A100",
            "Description": "TEST123",
            "UOM": "EACH",
            "Cost": "1.98",
            "CommodityCode": "ADSFASDF"
        }
    ]
}
</pre>

Get products in page
--------------------
* `GET /payment/3.1/api/Product?page=2&pagesize=5` will return the products based on the specific page and pagesize, the max pagesize is 500.

###### Response
<pre>
{
    "Page": "2",
    "TotalRecords": "9009",
    "TotalPages": "1802",
    "Records": [
        {
            "ID": 175568,
            "ItemNumber": "A1002",
            "Description": "asdfasdfadsf",
            "UOM": "sadfasdfadsfad",
            "Cost": "1002",
            "CommodityCode": "asdfasdfasdfasdf"
        },
        {
            "ID": 175569,
            "ItemNumber": "A1003",
            "Description": "asdfasdfadsf",
            "UOM": "sadfasdfadsfad",
            "Cost": "1003",
            "CommodityCode": "asdfasdfasdfasdf"
        },
        {
            "ID": 175570,
            "ItemNumber": "A1004",
            "Description": "asdfasdfadsf",
            "UOM": "sadfasdfadsfad",
            "Cost": "1004",
            "CommodityCode": "asdfasdfasdfasdf"
        },
        {
            "ID": 175571,
            "ItemNumber": "A1005",
            "Description": "asdfasdfadsf",
            "UOM": "sadfasdfadsfad",
            "Cost": "1005",
            "CommodityCode": "asdfasdfasdfasdf"
        },
        {
            "ID": 175572,
            "ItemNumber": "A1006",
            "Description": "asdfasdfadsf",
            "UOM": "sadfasdfadsfad",
            "Cost": "1006",
            "CommodityCode": "asdfasdfasdfasdf"
        }
    ]
}
</pre>

Create product
---------------------------
* `POST /payment/3.1/api/Product` will create product.

###### Request
<pre>
 {
  "ItemNumber": "B4",
  "Description": "B1",
  "UOM": "1",
  "Cost": "2",
  "CommodityCode": "B1"
}
</pre>

###### Response
<pre>
 {
    "ID": 25350,
    "ItemNumber": "B4",
    "Description": "B1",
    "UOM": "1",
    "Cost": "2",
    "CommodityCode": "B1"
}
</pre>

Update product
---------------------------
* `PATCH /payment/3.1/api/Product/{ProductID}` will update the specific product.
###### Request
<pre>
 {
  "ItemNumber": "B4",
  "Description": "B1",
  "UOM": "1",
  "Cost": "2",
  "CommodityCode": "B1"
}
</pre>
###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the specified product does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Delete product
---------------------------
* `DELETE /payment/3.1/api/Product/{ProductID}` will delete the specific product.

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the specified product does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.


Upload products
---------------------------
* `POST /payment/3.1/api/Product/Upload`  will upload products in a file.

###### Success Response
<pre>
{
    "Message": "Products successfully imported.",
    "Type": "Successful"
}
</pre>

###### Paritally Success Response
<b>Note:</b>The valid products are still uploaded to PayFabric, only the invalid records are skipped.
<pre>
{
    "Message": "Some products were unable to be imported due to: [Row] 3: [UOM] value cannot be empty; [Cost] value is invalid;",
    "Type": "Partially Successful"
}
</pre>
