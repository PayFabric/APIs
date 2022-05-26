Addresses
=========

The PayFabric Addresses API is used for returning customer shipping addresses which were entered previously.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Shipping Address
---------------------------

* `GET /payment/api/address/75B12D6B-B2C7-409D-89CB-006535D6CD95` will return the specified address

###### Response
<pre>
{
    "City": "CA",
    "Country": "USA",
    "Customer": "07053835",
    "Email": "arya.wang@nodus.com",
    "ID": "05b64467-3679-448a-97b1-21c25d88cb90",
    "Line1": "Streetline 1",
    "Line2": "Streetline 2",
    "Line3": "Streetline 3",
    "Phone": "1234567890",
    "State": "CA",
    "Zip": "12345",
    "ModifiedOn": "5/6/2022 10:38:38 PM",
    "ModifiedOnUTC": "2022-05-07T05:38:38.000Z"
}
</pre>

Retrieve Shipping Addresses
---------------------------

* `GET /addressesByCustomer?customer=JOHNDOE0001` will return all shipping addresses for the specified customer, the latter support special characters.
 
###### Response
<pre>
[
    {
        "City": "1",
        "Country": "1",
        "Customer": "JOHNDOE0001",
        "Email": "rena.wu@nodus.com",
        "ID": "cf48cd94-0b50-4fbc-8fa2-b22c27842a26",
        "Line1": "1",
        "Line2": "1",
        "Line3": "1",
        "Phone": "1",
        "State": "1",
        "Zip": "1",
        "ModifiedOn": "1/13/2022 10:00:52 PM",
        "ModifiedOnUTC": "2022-01-14T06:00:52.000Z"
    },
    {
        "City": "asd",
        "Country": "United States of America",
        "Customer": "JOHNDOE0001",
        "Email": "southeast@winncom.com; rluke@point-broadband.com",
        "ID": "e8eeac64-552f-438e-bf8e-51a3ba8e5182",
        "Line1": "sd",
        "Line2": "",
        "Line3": "",
        "Phone": "7067730145",
        "State": "GA",
        "Zip": "asdf",
        "ModifiedOn": "12/13/2021 10:17:31 PM",
        "ModifiedOnUTC": "2021-12-14T06:17:31.000Z"
    }
]
</pre>

Retrieve Shipping Addresses (Query with Paging)
-----------------------------------------------

* `GET /payment/api/addresses/get?customer=JOHNDOE0001&fromDate=01-01-2015&page=1` will return shipping addresses for the specified customer after a specified date in merchant timezone.

###### Response
<pre>
{
    "Paging": {
        "Current": "1",
        "Size": "15",
        "TotalPages": "1",
        "TotalRecords": "2"
    },
    "Records": [
        {
            "City": "asd",
            "Country": "United States of America",
            "Customer": "JOHNDOE0001",
            "Email": "southeast@winncom.com; rluke@point-broadband.com",
            "ID": "e8eeac64-552f-438e-bf8e-51a3ba8e5182",
            "Line1": "sd",
            "Line2": "",
            "Line3": "",
            "Phone": "7067730145",
            "State": "GA",
            "Zip": "asdf",
            "ModifiedOn": "12/13/2021 10:17:31 PM",
            "ModifiedOnUTC": "2021-12-14T06:17:31.000Z"
        },
        {
            "City": "1",
            "Country": "1",
            "Customer": "JOHNDOE0001",
            "Email": "rena.wu@nodus.com",
            "ID": "cf48cd94-0b50-4fbc-8fa2-b22c27842a26",
            "Line1": "1",
            "Line2": "1",
            "Line3": "1",
            "Phone": "1",
            "State": "1",
            "Zip": "1",
            "ModifiedOn": "1/13/2022 10:00:52 PM",
            "ModifiedOnUTC": "2022-01-14T06:00:52.000Z"
        }
    ]
}
</pre>
