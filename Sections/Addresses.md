Addresses
=========

Get Address
-----------

* `GET /rest/api/address/75B12D6B-B2C7-409D-89CB-006535D6CD95` will return the specified address

```json
{
  "City": "Anaheim",
  "Country": "USA",
  "Customer": "Nodus Technologies, Inc.",
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

Get Addresses (Query with Paging)
---------------------

* `GET /rest/api/addresses/get?customer=AARONFIT0001&fromDate=01-01-2015&page=1` will return shipping addresses for the specified customer after a specified date
