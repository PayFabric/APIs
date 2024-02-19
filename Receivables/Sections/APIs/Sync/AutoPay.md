AutoPay
============

The AutoPay API is used for creating autopay requests on the Receivables portal. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Create AutoPay Request
--------------------

* `POST /autopay/request` will create a new autopay request on the PayFabric Receivables website based on the JSON request payload

###### Request
For more information on the available fields please see our [object reference](../../Objects/AutoPay.md#SendAutoPayRequestEmailRequest)
```json
{
    "CustomerID": "Nodus001"
}
```

###### Response
```json
{
    "AutoPayRequestURL": "https://sandbox.payfabric.com/customerportal/nodus#/account/autopay-request?accesscode=014f661e79a543bbb45ee6d177f08057",
    "AccessCode": "014f661e79a543bbb45ee6d177f08057"
}
```
