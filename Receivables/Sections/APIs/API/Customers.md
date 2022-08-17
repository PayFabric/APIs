Customers
============

The Customer API is used for updating and viewing customers on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Update a Customer by Id
--------------------

* `PATCH /customers?id={CustomerId}` will update a customer to the PayFabric Receivables website based on the JSON request payload. You only need to send what needs to be changed.

###### Request
For more information on available fields please see our [object reference](../../Objects/Customer.md#CustomerPost)
```http
PATCH /customers?id=Nodus0001 HTTP/1.1
```

```json
{
    "Email": "Nodus0001@nodus.com",
    "Name": "Nodus Technologies"
}
```


###### Response
```text
true
```


Retrieve the current customer
--------------------

* `GET /customers/current` will retrieve the currently used customer information

###### Request
```http
GET /customers/current HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Customer.md#CustomerResponse)
```json
{
    "CustomerGuid": "9e2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
    "Status": "Active",
    "BillingAddress": {
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "AddressId": "PRIMARY5",
        "isDefaultBilling": true,
        "IsDefaultShipping": true,
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "USA",
        "Email": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone": "",
        "State": "CA",
        "Zip": "12345"
    },
    "PrimaryAddress": {
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "AddressId": "PRIMARY5",
        "isDefaultBilling": false,
        "IsDefaultShipping": false,
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "USA",
        "Email": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone": "",
        "State": "CA",
        "Zip": "12345"
    },
    "ShippingAddress": {
        "AddressGuid": "862f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "AddressId": "PRIMARY5",
        "isDefaultBilling": true,
        "IsDefaultShipping": true,
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "USA",
        "Email": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone": "",
        "State": "CA",
        "Zip": "12345"
    },
    "CreditBalance": 100.56,
    "InvoiceBalance": 500.20,
    "PastDueBalance": 200.24,
    "HasAddress": false,
    "HasOutstandingInvoice": true,
    "CustomerId": "Nodus0001",
    "Name": "Nodus Technologies",
    "Currency": "USD",
    "Email": "Nodus0002@nodus.com",
    "CopyEmail": [
        "Nodus0003@nodus.com",
		"Nodus0004@nodus.com"
    ],
    "PaymentTerms": "",
    "Class": "USA-ILMO-T1",
    "ExtensionData": "",
    "StatementName": "Nodus Technologies",
    "ShippingMethod": "",
    "TaxExemptNumber": 121,
    "TaxExempt": false,
    "TaxGroup": null
}
```

