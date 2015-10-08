Addresses
=========

The PayFabric Addresses API is used for returning customer shipping addresses which were entered previously.  Please note that all requests require API authentication, see our [guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Authentication.md) on how to authenticate.

Get Address
-----------

* `GET /rest/api/address/75B12D6B-B2C7-409D-89CB-006535D6CD95` will return the specified address

```json
{
  "City": "Anaheim",
  "Country": "USA",
  "Customer": "CUST0001",
  "Email": "Example@nodus.com",
  "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
  "Line1": "2099 S. State College Blvd, Suite 250",
  "Line2": "",
  "Line3": "",
  "ModifiedOn": "10/2/2015 10:39:32 AM",
  "Phone": "(909) 482-4701",
  "State": "CA",
  "Zip": "92806"
}
```

Get Addresses
-------------

* `GET /rest/api/addresses/CUST0001` will return all shipping addresses for the specified customer
 
```json
[
  {
    "City": "Anaheim",
    "Country": "USA",
    "Customer": "CUST0001",
    "Email": "Example@nodus.com",
    "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
    "Line1": "2099 S. State College Blvd, Suite 250",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "10/2/2015 10:39:32 AM",
    "Phone": "(909) 482-4701",
    "State": "CA",
    "Zip": "92806"
  },
  {
    "City": "Anaheim",
    "Country": "USA",
    "Customer": "CUST0001",
    "Email": "Example@nodus.com",
    "ID": "82BCC961-8BB7-44A4-AB9E-70599460E366",
    "Line1": "1099 N. State College Blvd, Suite 250",
    "Line2": "",
    "Line3": "",
    "ModifiedOn": "8/2/2015 11:00:32 AM",
    "Phone": "(909) 482-4701",
    "State": "CA",
    "Zip": "92806"
  }
]
```

Get Addresses (Query with Paging)
---------------------

* `GET /rest/api/addresses/get?customer=CUST0001&fromDate=01-01-2015&page=1` will return shipping addresses for the specified customer after a specified date

```json
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
      "Customer": "CUST0001",
      "Email": "Example@nodus.com",
      "ID": "75B12D6B-B2C7-409D-89CB-006535D6CD95",
      "Line1": "2099 S. State College Blvd, Suite 250",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "10/2/2015 10:39:32 AM",
      "Phone": "(909) 482-4701",
      "State": "CA",
      "Zip": "92806"
    },
    {
      "City": "Anaheim",
      "Country": "USA",
      "Customer": "CUST0001",
      "Email": "Example@nodus.com",
      "ID": "82BCC961-8BB7-44A4-AB9E-70599460E366",
      "Line1": "1099 N. State College Blvd, Suite 250",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "8/2/2015 11:00:32 AM",
      "Phone": "(909) 482-4701",
      "State": "CA",
      "Zip": "92806"
    }
  ]
```
