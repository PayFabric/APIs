AutoPays
============

The AutoPay API is used for all information related to an AutoPay or AutoPay template on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve all AutoPay templates
--------------------

* `GET /autopaytemplates` will retrieve all autopay templates.

###### Request
```http 
GET /autopaytemplates HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AutoPayTemplate.md)
```json
[
    {
        "Currency": "",
        "Description": "Pay outstanding balance on a monthly basis",
        "AmountOption": "Outstanding",
        "FixedAmountOption": "None",
        "FixedAmount": 0.0,
        "Frequency": "Monthly",
        "FrequencyInterval": 1,
        "Start": "UserChoice",
        "StartDay": null,
        "CurrencyOption": "CustomerCurrency",
        "InvoiceTypeOption": "AllInvoices",
        "InvoiceTypes": [],
        "ApplyCredits": true,
        "AutoPayTemplateGuid": "c5b9d115-92cc-ec11-a36a-b0c09018d6d4",
        "Name": "Monthly AutoPay"
    }
]
```


Retrieve a specific AutoPay template
--------------------

* `GET /autopaytemplate?id={autopayTemplateGuid}` will retrieve the specific autopay template.

###### Request
```http
GET /autopaytemplate?id=5edab5e7-892d-ea11-a2b7-b0c09018d6d4 HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AutoPayTemplate.md)
```json
{
    "Currency": "",
    "Description": "Pay outstanding balance on a monthly basis",
    "AmountOption": "Outstanding",
    "FixedAmountOption": "None",
    "FixedAmount": 0.0,
    "Frequency": "Monthly",
    "FrequencyInterval": 1,
    "Start": "UserChoice",
    "StartDay": null,
    "CurrencyOption": "CustomerCurrency",
    "InvoiceTypeOption": "SelectedInvoices",
    "InvoiceTypes": [ "STDINV" ],
    "ApplyCredits": true,
    "AutoPayTemplateGuid": "5edab5e7-892d-ea11-a2b7-b0c09018d6d4",
    "Name": "Monthly AutoPay"
}
```


Retrieve the current customer's AutoPay
--------------------

* `GET /autopay` will retrieve the autopay for the currently logged in customer.

###### Request
```http
GET /autopay HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AutoPay.md#autopayresponse)
```json
{
    "AmountOption": "Outstanding",
    "CustomerId": "Nodus0001",
    "Currency": "USD",
    "Description": "Pay outstanding balance on a daily basis",
    "FixedAmount": 0.0,
    "PaymentDay": 0,
    "Frequency": "Daily",
    "FrequencyInterval": 1,
    "NextPaymentDate": "2022-05-04T16:41:01.1700000Z",
    "PaymentMethod": "9d0c3ace-28b2-4906-a68b-d2831c12048b",
    "InvoiceTypes": [],
    "ApplyCredits": null
}
```


Save an AutoPay
--------------------

* `POST /autopay` will save the AutoPay to the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/AutoPay.md#autopaypost)
```json
{
    "AmountOption": "Outstanding",
    "CustomerID": "Nodus0001",
    "Frequency": "Monthly",
    "NextPaymentDate": "2019-07-15T21:17:37.0300000Z",
    "PaymentMethod": "015eb504-46c3-4574-907c-e9f30589c90d"
}
```

###### Response
```text
true
```


Update an AutoPay
--------------------

* `PATCH /autopay` will update the AutoPay to the PayFabric Receivables website based on the JSON request payload. You only need to send what needs to be changed.

###### Request
For more information on available fields please see our [object reference](../../Objects/AutoPay.md#autopaypost)
```json
{
    "CustomerID": "Nodus0001"
}
```

###### Response
```text
true
```


Delete an AutoPay
--------------------

* `DELETE /autopay` will delete the AutoPay associated to the currently logged in customer.

###### Request
```http
DELETE /autopay HTTP/1.1
```

###### Response
```text
true
```
