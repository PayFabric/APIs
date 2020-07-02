WalletLinks
===========

The WalletLinks API is used for creating and retrieving WalletLinks. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

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

Please note that **bold** fields are required fields and all others are optional. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#walletlink-document).

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
  "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/h3GSpCZKsEWNxFv6T_y_Gw"
}
</pre>


Retrieve a WalletLink URL
-------------------------

* `GET /api/wallet/retrieve/h3GSpCZKsEWNxFv6T_y_Gw/link` will return the specified WalletLink document's unique URL

###### Response
<pre>
"https://sandbox.payfabric.com/paylink/web/walletlink/h3GSpCZKsEWNxFv6T_y_Gw"
</pre>

Retrieve a WalletLink
-------------------------

* `GET /api/wallet/YjBOQLdsgUudHEDpxg0T5zE` will return the specified WalletLink document

###### Response
<pre>
{
    "Id": "YjBOQLdsgUudHEDpxg0T5zE",
    "InstID": "cd76620f-28a2-43d1-b3be-6cb1e70301f5",
    "Device": "a284c1d0-a6fc-4938-98b4-0000b8cf4210",
    "TenderType": 0,
    "CustomerNumber": "test",
    "CustomerName": null,
    "NotificationEmail": "test@nodus.com",
    "NotificationPhone": null,
    "Message": "",
    "CustomeMessage": null,
    "Status": 0,
    "Notification": {
        "Type": "Email",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": null,
        "ResponseMessage": null
    },
    "WalletID": "00000000-0000-0000-0000-000000000000",
    "ReturnUrl": null,
    "CompletedOn": null,
    "CreatedOn": "2018-07-17T00:44:38.267",
    "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/YjBOQLdsgUudHEDpxg0T5zE"
}
</pre>

Retrieve WalletLinks
-------------------------

* `GET /api/wallet` will return all WalletLink documents created.
* `GET /api/wallet?$filter` will return all WalletLink documents based on an OData ([What is OData?](http://www.odata.org/documentation/odata-version-3-0/url-conventions/)) query. 

e.g. `https://sandbox.payfabric.com/paylink/api/wallet?$filter=CustomerNumber eq 'test' and Device eq GUID'a284c1d0-a6fc-4938-98b4-0000b8cf4210' and Status eq '0' and NotificationEmail eq 'test@nodus.com' and NotificationPhone eq '1234567890' and CreatedOn gt datetime'2018-06-16' & $orderby CompletedOn desc`

###### Available OData Fields
>
| Field | Description | 
| :------------- | ------------- | 
| CustomerNumber | Customer number specified at the time of creating a wallet link. |
| CreatedOn | The date the wallet link was created on. |
| ModifiedOn | The date the wallet link was modified on. |
| NotificationEmail | Email specified at the time of creating a wallet link. |
| NotificationPhone | Phone number specified at the time of creating a wallet link. |
| Status | `0=incomplete, 1=complete, 2=cancelled` |
|Device| Device used at the time of creating a wallet link. |
| CompletedOn | The date the wallet link was completed on. |

###### Response
<pre>
[
    {
        "Id": "YjBOQLdsgUudHEDpxg0T5zE",
        "InstID": "cd76620f-28a2-43d1-b3be-6cb1e70301f5",
        "Device": "a284c1d0-a6fc-4938-98b4-0000b8cf4210",
        "TenderType": 0,
        "CustomerNumber": "test",
        "CustomerName": null,
        "NotificationEmail": "test@nodus.com",
        "NotificationPhone": null,
        "Message": "",
        "CustomeMessage": null,
        "Status": 0,
        "Notification": {
            "Type": "Email",
            "SMSTemplate": null,
            "EmailTemplate": null,
            "ResponseStatus": null,
            "ResponseMessage": null
        },
        "WalletID": "00000000-0000-0000-0000-000000000000",
        "ReturnUrl": null,
        "CompletedOn": null,
        "CreatedOn": "0001-01-01T00:00:00",
        "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/YjBOQLdsgUudHEDpxg0T5zE"
    },
    {
        "Id": "bxC_7z8JZ0-KB8_hdhy2JDE",
        "InstID": "cd76620f-28a2-43d1-b3be-6cb1e70301f5",
        "Device": "a284c1d0-a6fc-4938-98b4-0000b8cf4210",
        "TenderType": 1,
        "CustomerNumber": "Test1",
        "CustomerName": null,
        "NotificationEmail": "test@nodus.com",
        "NotificationPhone": null,
        "Message": "",
        "CustomeMessage": null,
        "Status": 1,
        "Notification": {
            "Type": "Email",
            "SMSTemplate": null,
            "EmailTemplate": null,
            "ResponseStatus": null,
            "ResponseMessage": null
        },
        "WalletID": "a4976d58-ea23-4e0e-95ae-7e7e9c2e5d47",
        "ReturnUrl": null,
        "CompletedOn": "2018-07-17T01:20:43.61",
        "CreatedOn": "0001-01-01T00:00:00",
        "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/bxC_7z8JZ0-KB8_hdhy2JDE"
    }
]
</pre>

Cancel a WalletLink
-------------------

* `POST /api/wallet/h3GSpCZKsEWNxFv6T_y_Gw/cancel` will cancel the specified WalletLink document

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or completed. 

