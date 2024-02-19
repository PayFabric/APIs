Payment Method
============

The Payment Method API is used for creating payment method requests on the Receivables portal. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create Payment Method Request
--------------------

* `POST /paymentmethod/request` will create a new payment method request on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/PaymentMethod.md#SendPaymentMethodRequestEmailRequest)
```json
{
    "CustomerID": "Nodus001"
}
```

###### Response
```json
{
    "PaymentMethodRequestURL": "https://sandbox.payfabric.com/customerportal/nodus#/account/payment-method-request?accesscode=014f661e79a543bbb45ee6d177f08057",
    "AccessCode": "014f661e79a543bbb45ee6d177f08057"
}
```
