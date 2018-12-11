Customers
============

The Customer API is used for updating and viewing customers on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Update a Customer by Id
--------------------

* `PATCH /customers?id={CustomerId}` will update a customer to the PayFabric Receivables website based on the JSON request payload. You only need to send what needs to be changed.

###### Request
<pre>
	PATCH /customers?id=Nodus0001
</pre>

<pre>
{
    "Email": "Nodus0001@nodus.com",
    "Name": "Nodus Technologies"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/Customer.md#CustomerPost).

###### Response
<pre>
	true
</pre>


Retrieve the current customer
--------------------

* `GET /customers/current` will retrieve the currently used customer information

###### Request
<pre>
	GET /customers/current
</pre>

###### Response
<pre>
{
    "Status": "Active",
    "BillingAddress": {
        "Address1": "98765 Crossway Park Dr",
        "Address2": "",
        "Address3": "",
        "City": "Bloomington",
        "Country": "USA",
        "EMail": "",
        "Fax": "",
        "Name": "Dennis Swenson",
        "Phone": null,
        "State": "MN",
        "Zip": "55304-9840"
    },
    "PrimaryAddress": {
        "Address1": "98765 Crossway Park Dr",
        "Address2": "",
        "Address3": "",
        "City": "Bloomington",
        "Country": "USA",
        "EMail": "",
        "Fax": "",
        "Name": "Dennis Swenson",
        "Phone": null,
        "State": "MN",
        "Zip": "55304-9840"
    },
    "ShippingAddress": {
        "Address1": "98765 Crossway Park Dr",
        "Address2": "",
        "Address3": "",
        "City": "Bloomington",
        "Country": "USA",
        "EMail": "",
        "Fax": "",
        "Name": "Dennis Swenson",
        "Phone": null,
        "State": "MN",
        "Zip": "55304-9840"
    },
    "CreditBalance": 0,
    "InvoiceBalance": 842.1,
    "PastDueBalance": 247,
    "Class": "USA-ILMO-T1",
    "CustomerId": "Nodus0001",
    "CopyEmail": [],
    "Email": "nodus0001@nodus.com",
    "ExtensionData": "",
    "Name": "Nodus Technologies",
    "ParentCustomerId": "Nodus0001",
    "PaymentTerms": null,
    "StatementName": "Nodus Technologies",
    "Currency": "Z-US$"
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Customer.md#CustomerResponse).
