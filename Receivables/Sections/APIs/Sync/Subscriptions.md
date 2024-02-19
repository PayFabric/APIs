Subscriptions
============

The Subscription API is used for creating, updating and viewing available subscriptions. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update a Subscription
--------------------

* `POST /subscriptions` will create and save a tax to the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Subscription.md#SubscriptionPost)
```json
{
    "Id": "SUBSCRIPTION0001",
    "CustomerId": "Nodus0001",
    "SubscriptionItems": [
        {
            "Id": "Test1",
            "ItemCode": "Test",
            "NextBillDate": "2022-05-19",
            "Frequency": "Monthly",
            "Sequence": "1"
        }
    ]
}
```

###### Response
```text
true
```


Retrieve Subscriptions
--------------------

* `GET /subscriptions?customerId={customerId}` will get the details for a tax on the PayFabric Receivables website based on the URL parameter

This request accepts an additional query string parameter that you may add. This query string is `id` which is the identifier of a specific subscription. You can add it to the query string by adding a '&' at the end then populating the id.

###### Request
```http
GET /subscriptions?customerId=Nodus0001 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Subscription.md#SubscriptionResponse)
```json
[
    {
        "ID": "SUBSCRIPTION0001",
        "CustomerID": "Nodus0001",
        "Currency": "USD",
        "InvoiceType": "Default",
        "PONumber": "",
        "Email": "Nodus0001@nodus.com",
        "CopyEmail": [
            "Nodus0002@nodus.com"
        ],
        "PaymentTerms": "Net 30",
        "TaxGroup": "Default",
        "Comments": "",
        "PaymentMethod": null,
        "CreatedOn": "2022-05-05T16:41:11.5417473Z",
        "LastBillDate": null,
        "NextBillDate": "1/1/2050 12:00:00 AM",
        "Status": "Open",
        "BillingAddress": {
            "Address1": "1234 Street",
            "Address2": "",
            "Address3": "",
            "AddressId": "PRIMARY",
            "City": "Los Angeles",
            "Country": "USA",
            "Name": "Nodus Technologies",
            "State": "CA",
            "Zip": "12345"
        },
        "ShippingAddress": {
            "Address1": "1234 Street",
            "Address2": "",
            "Address3": "",
            "AddressId": "PRIMARY",
            "City": "Los Angeles",
            "Country": "USA",
            "Name": "Nodus Technologies",
            "State": "CA",
            "Zip": "12345"
        },
        "SubscriptionItems": [
            {
                "ID": "TestItem01",
                "ItemCode": "TestItem01",
                "UnitOfMeasure": "",
                "UnitPrice": 5.0,
                "Quantity": 3.0,
                "Markdown": 0.5,
                "CommodityCode": "",
                "Description": "Pen",
                "Comment": "",
                "Frequency": "Monthly",
                "FrequencyInterval": 1,
                "Occurrences": "5",
                "Sequence": 1,
                "Taxable": true,
                "StartDate": "2050-01-01T00:00:00.0000000Z",
                "NextBillDate": "2050-01-01T00:00:00.0000000Z",
                "NextBillDay": 1,
                "Taxes": [
                    {
                        "Name": "SalesTax",
                        "Rate": 0.08
                    }
                ]
            }
        ]
    }
]
```
