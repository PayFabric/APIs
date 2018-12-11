Customers
============

The Customer API is used for creating, updating, deleting and viewing customers on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Delete a Customer
--------------------

* `DELETE /customers?id={CustomerId}` will delete a currency on the PayFabric Receivables website based on the URL parameter

###### Request
<pre>
	DELETE /customers?id=Nodus0002
</pre>

###### Response
<pre>
	true
</pre>


Retrieve a Customer by customer identifier
--------------------

* `GET /customers?id={CustomerId}` will retrieve the customer from PayFabric Receivables website whose Id has been specified in the URL parameter

###### Request
<pre>
	GET /customers?id=Nodus0002
</pre>

###### Response
<pre>
{
    "Status": "Active",
    "BillingAddress": {
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "US",
        "EMail": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone1": null,
        "Phone2": null,
        "Phone3": null,
        "State": "CA",
        "UserDefine1": null,
        "UserDefine2": null,
        "Zip": "12345"
    },
    "PrimaryAddress": {
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "US",
        "EMail": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone1": null,
        "Phone2": null,
        "Phone3": null,
        "State": "CA",
        "UserDefine1": null,
        "UserDefine2": null,
        "Zip": "12345"
    },
    "ShippingAddress": {
        "Address1": "1234 Street",
        "Address2": "",
        "Address3": "",
        "City": "Los Angeles",
        "Country": "US",
        "EMail": "",
        "Fax": "",
        "Name": "Nodus Technologies",
        "Phone1": null,
        "Phone2": null,
        "Phone3": null,
        "State": "CA",
        "UserDefine1": null,
        "UserDefine2": null,
        "Zip": "12345"
    },
    "CreditBalance": 0,
    "InvoiceBalance": 0,
    "PastDueBalance": 0,
    "Class": "Customer",
    "CustomerId": "Nodus0002",
    "CopyEmail": [
        "Nodus0003@nodus.com",
        "Nodus0004@nodus.com"
    ],
    "Email": "Nodus0002@nodus.com",
    "ExtensionData": "",
    "Name": "Nodus Technologies",
    "ParentCustomerId": "",
    "PaymentTerms": null,
    "StatementName": "Nodus Technologies ",
    "Currency": "USD",
	"ShippingMethod": "GROUND"
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Customer.md#CustomerResponse).


Create or Update a Customer
--------------------

* `POST /customers` will create or update a customer to the PayFabric Receivables website based on the JSON request payload. If updating a customer, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
	"Status": "Active",
	"BillingAddress": {
		"Address1": "1234 Street",
		"Address2": null,
		"Address3": null,
		"AddressID": "PRIMARY",
		"City": "Los Angeles",
		"Country": "US",
		"EMailAddress": "Nodus0002@nodus.com",
		"Fax": null,
		"Name": "Nodus Technologies",
		"Phone1": "1234567890",
		"Phone2": null,
		"Phone3": null,
		"State": "CA",
		"UserDefine1": null,
		"UserDefine2": null,
		"Zip": "12345"
	},
	"PrimaryAddress": {
		"Address1": "1234 Street",
		"Address2": null,
		"Address3": null,
		"AddressID": "PRIMARY",
		"City": "Los Angeles",
		"Country": "US",
		"EMailAddress": "Nodus0002@nodus.com",
		"Fax": null,
		"Name": "Nodus Technologies",
		"Phone1": "1234567890",
		"Phone2": null,
		"Phone3": null,
		"State": "CA",
		"UserDefine1": null,
		"UserDefine2": null,
		"Zip": "12345"
	},
	"ShippingAddress": {
		"Address1": "1234 Street",
		"Address2": null,
		"Address3": null,
		"AddressID": "PRIMARY",
		"City": "Los Angeles",
		"Country": "US",
		"EMailAddress": "Nodus0002@nodus.com",
		"Fax": null,
		"Name": "Nodus Technologies",
		"Phone1": "1234567890",
		"Phone2": null,
		"Phone3": null,
		"State": "CA",
		"UserDefine1": null,
		"UserDefine2": null,
		"Zip": "12345"
	},
	"Class": "Customer",
	<b>"CustomerId": "Nodus0002"</b>,
	"CopyEmail": [
		"Nodus0003@nodus.com",
		"Nodus0004@nodus.com"
	],	
	"Email": "Nodus0002@nodus.com",
	"ExtensionData": "",
	"Name": "Nodus Technologies",
	"ParentCustomerId": "",
	"PaymentTerms": null,
	"StatementName": "Nodus Technologies",
	"Currency": "USD",
	"ShippingMethod": "GROUND"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Customer.md#CustomerPost).

###### Response
<pre>
	true
</pre>