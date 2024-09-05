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


Retrieve Subscription Report
--------------------

* `GET /reports/subscriptions` will get the subscription report on the PayFabric Receivables website based on the URL parameters.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- |
| PaymentId | Payment number | [String Filter](../QueryFilter.md#string-filter) |
| CreatedOn | Search by the created on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| Id | Subscription Id | [String Filter](../QueryFilter.md#string-filter) |
| CustomerId | Customer number | [String Filter](../QueryFilter.md#string-filter) |
| CustomerName | Customer name | [String Filter](../QueryFilter.md#string-filter) |
| Status | Subscription status | [String](../QueryFilter.md#string) |
| NextBillDate | Search by the next bill date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| LastBillDate | Search by the last bill date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |

###### Request
```http 
GET /reports/subscriptions?filter.pageSize=10&filter.pageIndex=0&filter.criteria.CustomerId.EqualsTo=Nodus0001 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Subscription.md#SubscriptionReportResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "SubscriptionGuid": "f655f4af-5f50-ef11-a2fb-0050568f9b1b",
            "Id": "S0000003",
            "CustomerID": "Nodus0001",
            "CustomerName": "Nodus",
            "Status": "Open",
            "NextBillDate": "2024-08-01T07:00:00.0000000Z",
            "CreatedOn": "2024-08-01T23:42:27.6042003Z",
            "LastBillDate": null
        }
    ]
}
```
