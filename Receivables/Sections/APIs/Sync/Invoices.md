Invoices
============

The Invoice API is used for creating and updating invoice information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create or Update an Invoice
--------------------

* `POST /invoices` will create or update an invoice on the PayFabric Receivables website based on the JSON request payload. If updating an invoice, make sure to send all values again, otherwise, they will be overwritten.

###### Request
<pre>
{
	<b>"Amount": "30.00"</b>,
	"BalanceDue": "30.00",
	"BatchNumber": "API20180525",
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
		"Phone": "1234567890",
		"State": "CA",
		"Zip": "12345"
	},
	"Comments": null,
	"CopyEmail": "Nodus0002@nodus.com; Nodus0003@nodus.com",
	"Currency": "Z-US$",
	<b>"CustomerId": "Nodus0002"</b>,
	"CustomerName": "Nodus Technologies",
	"Discount": "0.00",
	"DocumentType": "Invoice",
	"DueDate": "10/30/2017 3:19:11 PM",
	"Email": "Nodus0001@nodus.com",
	"ExtensionData": "&lt;ExtData&gt;&lt;Ext_USERDEF1&gt;UserDefine1 Value&lt;/Ext_USERDEF1&gt;&lt;Ext_USERDEF2&gt;UserDefine2 Value&lt;/Ext_USERDEF2&gt;&lt;/ExtData&gt;",
	"Freight": "0.00",
	"Identity": "",
	"InvoiceGuid": "8e734fd5-29a5-4a6f-80ca-63cc92b793b9",
	<b>"InvoiceId": "STDINV999999"</b>,
	"InvoiceItems": [{
		"Comment": null,
		"CommodityCode": "TEST",
		"Description": "TEST Item",
		"ExtendedPrice": "30.00",
		"ExtensionData": "",
		"InvoiceNumber": "STDINV999999",
		"ItemCode": "TEST",
		"Markdown": "0.00",
		"MarkdownPercentage": "0.00",
		"NonInventory": true,
		"PriceLevel": "RETAIL",
		"Quantity": "1",
		"ReqShipDate": "10/30/2017 3:19:11 PM",
		"SalesPerson": "SANDRA M.",
		"Sequence": "1",
		"ShippingMethod": "GROUND",
		"ShippingToAddress": {
			"Address1": "1234 Street",
			"Address2": null,
			"Address3": null,
			"AddressID": "PRIMARY",
			"City": "Los Angeles",
			"Country": "US",
			"EMailAddress": "TEST@nodus.com",
			"Fax": null,
			"Name": "Test User",
			"Phone": "1234567890",
			"State": "CA",
			"Zip": "12345"
		},
		"Taxable": "0",
		"TaxAmount": "0.00",
		"UnitOfMeasure": "EACH",
		"UnitPrice": "30.00"
	}],
	"InvoiceType": "3",
	"MiscCost": "0.00",
	"PaymentTerms": null,
	"PONumber": null,
	"PostingDate": "09/30/2017 2:00:00 PM",
	"SalesPerson": "SANDRA M.",
	"SendNewInvoiceEmail": "No",
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
		"Phone": "1234567890",
		"State": "CA",
		"Zip": "12345"
	},
	"ShippingMethod": "GROUND",
	"Site": "WAREHOUSE",
	"SubTotal": "30.00",
	"Tax": "0.00",
	"TermDiscounts": null,
	"Tracking_Number": null
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Invoice.md#InvoicePost).

###### Response
<pre>
	true
</pre>


Create or Update an Invoice with an Attachment
--------------------

* `POST /invoices/InvoiceWithAttachment` will create or update an invoice on the PayFabric Receivables website with the provided attachment. If updating an invoice, make sure to send all values again, otherwise, they will be overwritten.  
* `Content-Type: multipart/form-data` is required to send the attachment along with the other invoice data

###### Request
<pre>
{
	<b>"Amount": "30.00"</b>,
	"BalanceDue": "30.00",
	"BatchNumber": "API20180525",
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
		"Phone": "1234567890",
		"State": "CA",
		"Zip": "12345"
	},
	"Comments": null,
	"CopyEmail": "Nodus0002@nodus.com; Nodus0003@nodus.com",
	"Currency": "Z-US$",
	<b>"CustomerId": "Nodus0002"</b>,
	"CustomerName": "Nodus Technologies",
	"Discount": "0.00",
	"DocumentType": "Invoice",
	"DueDate": "10/30/2017 3:19:11 PM",
	"Email": "Nodus0001@nodus.com",
	"ExtensionData": "&lt;ExtData&gt;&lt;Ext_USERDEF1&gt;UserDefine1 Value&lt;/Ext_USERDEF1&gt;&lt;Ext_USERDEF2&gt;UserDefine2 Value&lt;/Ext_USERDEF2&gt;&lt;/ExtData&gt;",
	"Freight": "0.00",
	"Identity": "",
	"InvoiceGuid": "8e734fd5-29a5-4a6f-80ca-63cc92b793b9",
	<b>"InvoiceId": "STDINV999999"</b>,
	"InvoiceItems": [{
		"Comment": null,
		"CommodityCode": "TEST",
		"Description": "TEST Item",
		"ExtendedPrice": "30.00",
		"ExtensionData": "",
		"InvoiceNumber": "STDINV999999",
		"ItemCode": "TEST",
		"Markdown": "0.00",
		"MarkdownPercentage": "0.00",
		"NonInventory": true,
		"PriceLevel": "RETAIL",
		"Quantity": "1",
		"ReqShipDate": "10/30/2017 3:19:11 PM",
		"SalesPerson": "SANDRA M.",
		"Sequence": "1",
		"ShippingMethod": "GROUND",
		"ShippingToAddress": {
			"Address1": "1234 Street",
			"Address2": null,
			"Address3": null,
			"AddressID": "PRIMARY",
			"City": "Los Angeles",
			"Country": "US",
			"EMailAddress": "TEST@nodus.com",
			"Fax": null,
			"Name": "Test User",
			"Phone": "1234567890",
			"State": "CA",
			"Zip": "12345"
		},
		"Taxable": "0",
		"TaxAmount": "0.00",
		"UnitOfMeasure": "EACH",
		"UnitPrice": "30.00"
	}],
	"InvoiceType": "3",
	"MiscCost": "0.00",
	"PaymentTerms": null,
	"PONumber": null,
	"PostingDate": "09/30/2017 2:00:00 PM",
	"SalesPerson": "SANDRA M.",
	"SendNewInvoiceEmail": "No",
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
		"Phone": "1234567890",
		"State": "CA",
		"Zip": "12345"
	},
	"ShippingMethod": "GROUND",
	"Site": "WAREHOUSE",
	"SubTotal": "30.00",
	"Tax": "0.00",
	"TermDiscounts": null,
	"Tracking_Number": null
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/Invoice.md#InvoicePost).

###### Response
<pre>
	true
</pre>
