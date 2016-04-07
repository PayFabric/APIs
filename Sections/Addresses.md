Addresses
=========

The PayFabric Addresses API is used for returning customer shipping addresses which were entered previously.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Shipping Address
---------------------------

* `GET /rest/api/address/75B12D6B-B2C7-409D-89CB-006535D6CD95` will return the specified address

###### Response
<pre>
{
  "City": "Anaheim",
  "Country": "USA",
  "Customer": "John Doe Ltd",
  "Email": "John.Doe@payfabric.com",
  "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
  "Line1": "123 PayFabric Way",
  "Line2": "",
  "Line3": "",
  "ModifiedOn": "10/2/2015 10:39:32 AM",
  "Phone": "(123) 456-7890",
  "State": "CA",
  "Zip": "92806"
}
</pre>

Retrieve Shipping Addresses
---------------------------

* `GET /rest/api/addresses/John+Doe+Ltd` will return all shipping addresses for the specified customer
 
###### Response
<pre>
[
  {
    "City": "Anaheim",
    "Country": "USA",
    "Customer": "John Doe Ltd",
    "Email": "John.Doe@payfabric.com",
    "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
    "Line1": "123 PayFabric Way",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "10/2/2015 10:39:32 AM",
    "Phone": "(123) 456-7890",
    "State": "CA",
    "Zip": "92806"
  },
  {
    "City": "Anaheim",
    "Country": "USA",
    "Customer": "John Doe Ltd",
    "Email": "John.Doe@payfabric.com",
    "ID": "75B12D6B-B2C7-409D-89CB-006535DDDDDD",
    "Line1": "123 PayFabric Way",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "10/2/2015 10:39:32 AM",
    "Phone": "(123) 456-7890",
    "State": "CA",
    "Zip": "92806"
  }
]
</pre>

Retrieve Shipping Addresses (Query with Paging)
-----------------------------------------------

* `GET /rest/api/addresses/get?customer=John+Doe+Ltd&fromDate=01-01-2015&page=1` will return shipping addresses for the specified customer after a specified date

###### Response
<pre>
{
  "Paging": {
    "Current": "1",
    "Size": "15",
    "TotalPages": "1",
    "TotalRecords": "2"
  },
  "Records": 
  [
    {
      "City": "Anaheim",
      "Country": "USA",
      "Customer": "John Doe Ltd",
      "Email": "John.Doe@payfabric.com",
      "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "10/2/2015 10:39:32 AM",
      "Phone": "(123) 456-7890",
      "State": "CA",
      "Zip": "92806"
    },
    {
      "City": "Anaheim",
      "Country": "USA",
      "Customer": "John Doe Ltd",
      "Email": "John.Doe@payfabric.com",
      "ID": "75B12D6B-B2C7-409D-89CB-006535DDDDDD",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "10/2/2015 10:39:32 AM",
      "Phone": "(123) 456-7890",
      "State": "CA",
      "Zip": "92806"
    }
  ]
</pre>
