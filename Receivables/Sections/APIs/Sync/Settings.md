Settings
============

The Setting API is used for updating the settings of the Receivables portal. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Update Company Information
--------------------

* `PATCH /settings/company/information` will update the company information settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#CompanyInformationRequest)
```json
{
    "Name": "Nodus Technologies"
}
```

###### Response
```text
true
```


Update Company Style
--------------------

* `PATCH /settings/company/style` will update the company style settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#CompanyStyleRequest)
```json
{
    "BannerAlignment": "Left",
    "MaxBannerHeight": 50,
    "MainColor": "#197CBD",
    "FocusArea": "#F0F8FE",
    "BannerBackground": "#FFFFFF"
}
```

###### Response
```text
true
```


Upload Company Logo
--------------------

* `POST /settings/company/style/image?type={Logo Type}` will update the company logo settings on the PayFabric Receivables website based on the JSON request payload
* `Content-Type: multipart/form-data` is required to send the logo

###### Request
```http
POST /settings/company/style/image?type=SmallLogo HTTP/1.1
```
In the form-data add the following key value:
* `Logo` - This will contiain the actual logo file to be uploaded

###### Response
```text
true
```


Update Customer Setup
--------------------

* `PATCH /settings/customer/setup` will update the customer setup settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#CustomerSetupRequest)
```json
{
    "CustomerIdPrefix": "PFC"
}
```

###### Response
```text
true
```


Update Invoice Setup
--------------------

* `PATCH /settings/invoice/setup` will update the invoice setup settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#InvoiceSetupRequest)
```json
{
    "InvoiceIdPrefix": "PFI"
}
```

###### Response
```text
true
```


Create or Update Invoice Types
--------------------

* `POST /settings/invoice/types` will create or update the invoice type settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#InvoiceTypeRequest)
```json
{
    "ID": "STDINV"
}
```

###### Response
```text
true
```


Create or Update Invoice Templates
--------------------

* `POST /settings/invoice/templates` will create or update the invoice template settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#InvoiceTemplateRequest)
```json
{
    "Name": "New Template",
    "Template": "This is an invoice template"
}
```

###### Response
```text
true
```


Create or Update Invoice Payment Terms
--------------------

* `POST /settings/invoice/paymentterms` will create or update the invoice payment term settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#InvoicePaymentTermsRequest)
```json
{
    "Name": "New Payment Terms",
    "DueDateOption": "DaysAfterInvoiceDate",
    "DueDateNumber": 2
}
```

###### Response
```text
true
```

Update Invoice Table Display
--------------------

* `PATCH /settings/invoice/tabledisplay` will update the invoice table display settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#InvoiceTableDisplayRequest)
```json
{
    "PayInvoicesPoNumber": true,
    "HistoryPoNumber": true
}
```

###### Response
```text
true
```


Create or Update Payment Transaction Processing
--------------------

* `POST /settings/payment/transactionprocessing` will create or update the payment transaction processing settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#TransactionProcessingRequest)
```json
{
    "CurrencyCode": "New Currency",
    "ShortName": "USD"
}
```


Update Payment Preferences
--------------------

* `PATCH /settings/payment/preferences` will update the payment preferences settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#PaymentPreferencesRequest)
```json
{
    "PartialPayments": true
}
```

###### Response
```text
true
```


Create or Update an Autopay Template
--------------------

* `POST /settings/payment/autopaytemplates` will create or update the autopay template settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#AutopayTemplateRequest)
```json
{
    "Name": "New Autopay",
    "Description": "This is a new Autopay"
}
```


Update Integration
--------------------

* `PATCH /settings/integration` will update the integration settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#IntegrationSettingsPatchRequest)
```json
{
    "NewCustomerIntegration": true
}
```

###### Response
```text
true
```


Create or Update Email Templates
--------------------

* `POST /settings/emailtemplates` will create or update the email template settings on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/Setting.md#EmailTemplateSaveDto)
```json
{
    "Type": "ManualPaymentConfirmation",
    "Body": "This is an email template",
    "Subject": "Payment Confirmation"
}
```

###### Response
```text
true
```
