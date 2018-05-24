WalletLinks
===========

The WalletLinks API is used for creating and retrieving WalletLinks. Please note that all requests require API authentication by PayFabric *Security Token*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) on how to create a token.

Create a WalletLink
----------------

* `POST /api/wallet` will create and save a WalletLink document to the PayLink server based on the request JSON payload

###### Request
<pre>
{
  <b>"CustomerNumber": "CUST0001"</b>,
  "CustomerName": "JOHNDOE0001",
  "CustomeMessage": "",
  "ReturnUrl": "",
  <b>"Notification":</b> {
    <b>"Type": "All"</b>
  },  
  <b>"NotificationEmail": "John.Doe@nodus.com"</b>,
  <b>"NotificationPhone": "123456789"</b>,
}
</pre>

Please note that **bold** fields are required fields and all others are optional. For more information and descriptions on available fields please see our [JSON Objects](Sections/JSON%20Objects.md#walletlink-document).

###### Response
<pre>
{
  "Id": "h3GSpCZKsEWNxFv6T_y_Gw",
  "Device": "33665f05-8346-4809-e0f1-01050545236f",
  "TenderType": 0,
  "CustomerNumber": "CUST0001",
  "CustomerName": "JOHNDOE0001",
  "NotificationEmail": "John.Doe@nodus.com",
  "NotificationPhone": "123456789",
  "Message": "",
  "CustomeMessage": null,
  "Status": 0,
  "Notification": {
    "Type": "All",
    "SMSTemplate": null,
    "ResponseStatus": "",
    "ResponseMessage": ""
  },
  "WalletID": "00000000-0000-0000-0000-000000000000",
  "ReturnUrl": null,
  "CompleteOn": null,
  "CreatedOn": "2015-11-09T12:35:19.4571668+13:00"
}
</pre>


Retrieve a WalletLink URL
-------------------------

* `GET /api/wallet/retrieve/h3GSpCZKsEWNxFv6T_y_Gw/link` will return the specified WalletLink documents' unique URL

###### Response
<pre>
"https://sandbox.payfabric.com/paylink/web/walletlink/h3GSpCZKsEWNxFv6T_y_Gw"
</pre>


Cancel a WalletLink
-------------------

* `POST /api/wallet/h3GSpCZKsEWNxFv6T_y_Gw/cancel` will cancel the specified WalletLink document

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or completed.  
