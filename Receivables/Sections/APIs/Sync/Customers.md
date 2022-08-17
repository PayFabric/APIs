Customers
============

The Customer API is used for creating, updating, deleting and viewing customers on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Delete a Customer
--------------------

* `DELETE /customers?id={CustomerId}` will delete a currency on the PayFabric Receivables website based on the URL parameter

###### Request
```http
DELETE /customers?id=Nodus0002 HTTP/1.1
```

###### Response
```text
true
```


Retrieve a Customer by customer identifier
--------------------

* `GET /customers?id={CustomerId}` will retrieve the customer from PayFabric Receivables website whose Id has been specified in the URL parameter

###### Request
```http
GET /customers?id=Nodus0002 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Customer.md#CustomerResponse)
```json
{
    "CustomerId": "Nodus0002",
    "Name": "Nodus Technologies",
    "Currency": "Z-US$",
    "Email": "Nodus0002@nodus.com",
    "CopyEmail": [
        "Nodus0003@nodus.com",
		"Nodus0004@nodus.com"
    ],
    "PaymentTerms": "",
    "BillingAddress": {
        "AddressId": "PRIMARY5",
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "Name": "Nodus Technologies",
        "City": "Los Angeles",
        "State": "CA",
        "Zip": "12345",
        "Country": "USA",
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "isDefaultBilling": true,
        "IsDefaultShipping": true,
        "Email": "",
        "Fax": "",
        "Phone": ""
    },
    "PrimaryAddress": {
        "AddressId": "PRIMARY5",
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "Name": "Nodus Technologies",
        "City": "Los Angeles",
        "State": "CA",
        "Zip": "12345",
        "Country": "USA",
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "isDefaultBilling": false,
        "IsDefaultShipping": false,
        "Email": "",
        "Fax": "",
        "Phone": ""
    },
    "ShippingAddress": {
        "AddressId": "PRIMARY5",
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "Name": "Nodus Technologies",
        "City": "Los Angeles",
        "State": "CA",
        "Zip": "12345",
        "Country": "USA",
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "isDefaultBilling": true,
        "IsDefaultShipping": true,
        "Email": "",
        "Fax": "",
        "Phone": ""
    },
    "CustomerGuid": "9e2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
    "Status": "Active",
    "CreditBalance": 100.56,
    "InvoiceBalance": 500.20,
    "PastDueBalance": 200.24,
    "HasAddress": false,
    "Class": "USA-ILMO-T1",
    "ExtensionData": "",
    "StatementName": "Nodus Technologies",
    "ShippingMethod": "",
    "TaxExemptNumber": 121,
    "TaxExempt": false,
    "TaxGroup": ""
}
```


Create or Update a Customer
--------------------

* `POST /customers` will create or update a customer to the PayFabric Receivables website based on the JSON request payload. If updating a customer, make sure to send all values again, otherwise, they will be overwritten.

###### Request
For more information on available fields please see our [object reference](../../Objects/Customer.md#CustomerPost)
```json
{
    "CustomerId": "Nodus0002"
}
```


###### Response
```text
true
```
