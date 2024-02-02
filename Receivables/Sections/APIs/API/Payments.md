Payments
============

The Payment API is used for processing, and viewing payment information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Delete Payments
-------------------

* `DELETE /payments` will delete the "Inprogress" payments based on the payment identities based on the JSON request payload.

###### Request
```json	
[ 
    "WEBPMT0000000020" 
]
```

###### Response
```text
true
```


Update an Existing Payment
-------------------

* `PATCH /payments?identity={PaymentIdentity}` will update an existing payment based on the JSON request payload.

###### Request
```http
PATCH /payments?identity=PMT00001 HTTP/1.1
```
For more information and descriptions on available fields please see our [object reference](../../Objects/Payment.md#PaymentPatch)
```json
{
    "Notes": "",
    "Reference": "",
  	"PaymentApplies": [
        {
            "InvoiceId": "INV0001",
            "Identity": "",
            "PayAmount": 1,
            "RowVersion": ""
        }
  	],
  	"BatchNumber": "PFR2019117",
  	"PaymentMethod": "CreditCard",
  	"CCNumber": "",
  	"CheckNumber": "",
  	"CreatedOn": "2019-01-17T12:54:55.0952444-08:00",
  	"CustomerId": "Nodus0001",
  	"Identity": "",
  	"PaymentId": "PMT00001",
	"Amount": 10,
	"BalanceAmount": 10,
  	"PaymentType": "Payment",
  	"User": "Nodus0001"
}
```


###### Response
```text
true
```


Update an Existing InProgress Payment
-------------------

* `PATCH /payments/inprogress` will update an existing payment based on the JSON request payload.

###### Request
For more information and descriptions on available fields please see our [object reference](../../Objects/ProcessPayment.md#InProgressPaymentPatch)
```json
{
	"PaymentIdentity": "WEBPMT000000000000001",
	"CreditDistributions": [
		{
			"CreditGuid": "2b9a5a48-f83a-e911-80d5-00155d000a90",
			"ApplyAmount": 1,
			"CreditBalance": 0,
			"CreatedOn": "2021-01-21",
			"CreditIdentity": "RTN0001",
			"PaymentType": "Return"
		}
	],
  	"Prepayment": 10,
  	"CurrencyCode": "USD",
  	"Comment": "my notes",
  	"WalletEntryGuid": "2b9a5a48-f83a-e911-80d5-00155d000a89",
    "Reference": ""
}
```


###### Response
```text
true
```


Create an InProgress Payment
--------------------

* `POST /payments/inprogress` will create an in-progress payment on the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information and descriptions on available fields please see our [object reference](../../Objects/ProcessPayment.md#InProgressPaymentPost)
```json
{
    "CurrencyCode": "USD",
  	"Prepayment": 10,
  	"PaymentApplies": [
        {
            "Identity": "INV0001",
            "InvoiceId": "INV0001",
            "PayAmount": 3,
            "RowVersion": ""
        }
  	],
    "Comment": ""
}
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/ProcessPayment.md#InProgressPaymentResponse)
```json
{
    "Identity": "WEBPMT000000000000001",
    "TransactionKey": "12546233498"
}
```


Process an Existing Payment
--------------------

* `POST /payments/process?paymentIdentity={PaymentIdentity}&cvv2={CVV2}` will process an inprogress payment on the PayFabric Receivables website based on the JSON request payload. Please note, CVV2 is optional

###### Request
```http
POST /payments/process?paymentIdentity=WEBPMT0000000020&cvv2=123 HTTP/1.1
```

###### Response
```text
true
```

Retrieve InProgress Payment
--------------------

* `GET /payments/inprogress?paymentId={paymentId}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /payments/inprogress?paymentId=WEBPMT0000000020 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "Processed",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```


Retrieve Payment Receipt
--------------------

* `GET /payments/receipt?paymentId={paymentId}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /payments/receipt?paymentId=WEBPMT0000000020 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "Processed",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```


Retrieve Payment Details
--------------------

* `GET /payments/detail?paymentGuid={paymentGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /payments/detail?paymentGuid=1620fcac-35e8-e811-87df-534e57000000 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "Processed",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```


Retrieve Application Record Receipt
--------------------

* `GET /applications/receipt?applicationId={applicationId}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /applications/receipt?applicationId=WEBPMT0000000020 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "Processed",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```


Retrieve Application Record Details
--------------------

* `GET /applications/detail?applicationGuid={applicationGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /applications/detail?applicationGuid=1620fcac-35e8-e811-87df-534e57000000 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "Processed",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```


Download Payment Receipt
--------------------

* `GET /payments/receipt/download?paymentGuid={paymentGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /payments/receipt/download?paymentGuid=12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
This will return the receipt file related payment

Download Payment Details
--------------------

* `GET /payments/detail/download?paymentGuid={paymentGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /payments/detail/download?paymentGuid=12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
This will return the receipt file related payment

Download Application Record Receipt
--------------------

* `GET /applications/receipt/download?applicationGuid={applicationGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /applications/receipt/download?applicationGuid=12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
This will return the receipt file related payment

Download Application Record Details
--------------------

* `GET /applications/detail/download?applicationGuid={applicationGuid}` will get the payment information on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
GET /applications/detail/download?applicationGuid=12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
This will return the receipt file related payment


Create JWT for PayFabric Hosted Checkout Page (DEPRECATED)
--------------------

Please use the JWT creation found on the [Payment Methods](PaymentMethods.md#create-jwt-for-payfabric-hosted-checkout-page) page.

* `POST /payments/mrhpp/jwt` will create the token to be used on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
POST /payments/mrhpp/jwt?paymentIdentity=WEBPMT0000000020&setupId=EVO HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/ProcessPaymentHostedCheckout.md#jwtresponse)
```json
{
    "Message": "",
    "Payload": {
        "aud": "PaymentPage",
        "dcn": "1",
        "device": "72972a2b-8a71-4e29-aeab-1c418b136869",
        "exp": "1617688157",
        "iat": "1617687257",
        "inst": "f242bd6d-7a23-41d7-a12e-46427ce4eba4",
        "iss": "PayFabric_V3",
        "sub": "HPP21040500682801",
        "supportedPaymentMethods": [
            {
                "attributes": null,
                "src": "URL",
                "type": "CreditCard"
            },
            {
                "attributes": null,
                "src": "URL",
                "type": "ECheck"
            },
            {
                "attributes": [
                    {
                        "key": "data-partner-attribution-id",
                        "value": "Nodus_SP_PPCP"
                    }
                ],
                "src": "https:\/\/www.paypal.com\/sdk\/js?client-id=AfGQA1jQrGwqYSqbrN6M0ZnXwvDZNVKaXlNvI8VYbmb14vFWrF5CQtgw-O6xvz6n7sLtmvWJ0s0A5uW3&merchant-id=Q3E49R5X48QLG&enable-funding=venmo&disable-funding=paylater,card¤cy=USD&integration-date=2021-03-16",
                "type": "PAYPAL"
            }
        ]
    },
    "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJQYXlGYWJyaWNfVjMiLCJpYXQiOiIxNjE3Njg3MjU3IiwiZXhwIjoiMTYxNzY4ODE1NyIsImF1ZCI6IlBheW1lbnRQYWdlIiwic3ViIjoiSFBQMjEwNDA1MDA2ODI4MDEiLCJpbnN0IjoiZjI0MmJkNmQtN2EyMy00MWQ3LWExMmUtNDY0MjdjZTRlYmE0IiwiZGV2aWNlIjoiNzI5NzJhMmItOGE3MS00ZTI5LWFlYWItMWM0MThiMTM2ODY5IiwiZGNuIjoiMSIsInN1cHBvcnRlZFBheW1lbnRNZXRob2RzIjpbeyJ0eXBlIjoiQ3JlZGl0Q2FyZCIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IkVDaZZjayIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IlBBWVBBTCIsInNyYyI6Imh0dHBzOi8vd3d3LnBheXBhbC5jb20vc2RrL2pzP2NsaWVudC1pZD1BZkdRQTFqUXJHd3FZU3Fick42TTBablh3dkRaTlZLYVhsTnZJOFZZYm1iMTR2RldyRjVDUXRndy1PNnh2ejZuN3NMdG12V0owczBBNXVXMyZtZXJjaGFudC1pZD1RM0U0OVI1WDQ4UUxHJmVuYWJsZS1mdW5kaW5nPXZlbm1vJmRpc2FibGUtZnVuZGluZz1wYXlsYXRlcixjYXJkJmN1cnJlbmN5PVVTRCZpbnRlZ3JhdGlvbi1kYXRlPTIwMjEtMDMtMTYiLCJhdHRyaWJ1dGVzIjpbeyJrZXkiOiJkYXRhLXBhcnRuZXItYXR0cmlidXRpb24taWQiLCJ2YWx1ZSI6Ik5vZHVzX1NQX1BQQ1AifV19XX0.grPRlquWaPWiySm6oaOLXTbQnLzM3Dz2JUtYF0pcno4",
    "Options": {
        "UseBluefin": false,
        "UseDefaultWallet": false,
        "ReturnUrl": null,
        "TrxKey": "123485920"
    }
}
```

Update Existing Payment Transaction Using Hosted Checkout Page
--------------------

* `PATCH /payments/transactions/setupid` will update the payment to be processed on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
PATCH /payments/transactions/setupid?paymentIdentity=WEBPMT0000000020&setupId=EVO HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/ProcessPaymentHostedCheckout.md#updatetransactionresult)
```json
{
    "Options": {
        "UseBluefin": false,
        "UseDefaultWallet": false,
        "ReturnUrl": null,
        "TrxKey": "123485920"
    },
    "Result": true,
    "Message": null,
    "HttpStatusCode": 200
}
```

Create a New Transaction for Hosted Checkout Page After Transaction Failed Once
--------------------

* `POST /payments/transactions/new` will create a new transaction to be used with the Hosted Checkout Page after the first transaction failed on the PayFabric Receivables website based on the URL parameters.

###### Request
```http
POST /payments/transactions/new?trxKey=123485920 HTTP/1.1
```

###### Response
For more information and descriptions on available fields please see our [object reference](../../Objects/PaymentReceipt.md)
```json
{
    "CreditAmount": 0,
    "AdditionalFee": 0,
    "PrepaymentAmount": 0,
    "Currency": {
        "CurrencyGuid": "1620fcac-35e8-e811-87df-534e57000000",
        "CCSetupId": "PayFlowProCredit",
        "ECSetupId": "PaymentechECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "Name": "USD",
        "CurrencyCode": "Z-US$",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    },
    "PaymentStatus": "InProgress",
    "Company": {
        "Name": "Nodus Tech",
        "LogoLarge": "",
        "Logo": "data:image/gif;base64,...",
        "Country": "Nodus Tech",
        "Address": "West First Street",
        "Address2": "-",
        "City": "Claremont",
        "State": "CA",
        "Zip": "Claremont, CA 91711",
        "Phone": "909 248 6547",
        "PortalName": "nodus",
        "PortalUrl": "https://sandbox.payfabric.com/receivables/nodus",
        "IntegrationKey": null,
        "IntegrationPassword": null
    },
    "Customer": {
        "Status": "Active",
        "BillingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "PrimaryAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "ShippingAddress": {
            "Address1": "98765 Crossway Park Dr",
            "Address2": "",
            "Address3": "",
            "City": "Bloomington",
            "Country": "USA",
            "Email": "",
            "Fax": "",
            "Name": "Dennis Swenson",
            "Phone": "",
            "State": "MN",
            "Zip": "55304-9840"
        },
        "CreditBalance": 0,
        "InvoiceBalance": 0,
        "PastDueBalance": 0,
        "Class": "USA-ILMO-T1",
        "CustomerId": "Nodus0001",
        "CopyEmail": null,
        "Email": "nodus0001@nodus.com",
        "ExtensionData": "",
        "Name": "Nodus Technologies",
        "PaymentTerms": "2% 10/Net 30",
        "StatementName": "Nodus Technologies",
        "Currency": "USD",
        "ShippingMethod": ""
    },
    "Transaction": null,
    "WalletEntryGuid": "12345678-0000-0000-0000-000000000000",
    "Notes": "",
    "Reference": "",
    "CreditDistributions": [],
    "Surcharges": null,
    "PaymentGuid": "12345678-0000-0000-0000-000000000000",
    "PaymentApplies": [
        {
            "AppliedToInvoice": true,
            "InvoiceId": "ORDST1026",
            "Identity": null,
            "PayAmount": 187.44,
            "DocumentType": 1,
            "RowVersion": "AAAAAAAAB/k="
        }
    ],
    "BatchNumber": "1234",
    "PaymentMethod": "Cash",
    "CCNumber": "",
    "CheckNumber": "",
    "CreatedOn": "2019-05-21T00:00:00",
    "CustomerId": "Nodus0001",
    "Identity": "PYMNT00000000001",
    "PaymentId": "PYMNT00000000001",
    "Amount": 200,
    "BalanceAmount": 12.56,
    "PaymentType": "Payment",
    "User": "Nodus0001"
}
```
