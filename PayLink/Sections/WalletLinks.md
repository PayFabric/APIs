Wallet Links
===========

The Wallet Links API is used for creating and retrieving Wallet Links. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

Create a Wallet Link
----------------

* `POST /paylink/api/wallet` will create and save a Wallet Link document to the PayLink server based on the request JSON payload

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
  <b>"NotificationEmail": "sample@email.com"</b>,
  <b>"NotificationPhone": "123456789"</b>,
}
</pre>

Please note that **bold** fields are required fields and all others are optional. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#walletlink-document).

###### Response
<pre>
{
    "Id": "x__BqrJ0xU2nEK_aOO7ozDE",
    "InstID": "11a2c6f2-33f6-48b3-a5ab-697db2519ec7",
    "Device": "23c6b04e-cd06-4185-801a-8614508f065f",
    "TenderType": 0,
    "CustomerNumber": "CUST0001",
    "CustomerName": "JOHNDOE0001",
    "NotificationEmail": "sample@email.com",
    "NotificationEmailDisplay": "sample@email.com",
    "NotificationPhone": "123456789",
    "NotificationPhoneDisplay": "123456789",
    "CustomeMessage": "",
    "Status": 0,
    "Notification": {
        "Type": "All",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": "1",
        "ResponseMessage": "Invalid SMS template.\r\n"
    },
    "WalletID": "00000000-0000-0000-0000-000000000000",
    "ReturnUrl": "",
    "CompletedOn": null,
    "CreatedOn": "2022-05-26T05:37:37.63",
    "ModifiedOn": "2022-05-26T05:37:37.63",
    "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/x__BqrJ0xU2nEK_aOO7ozDE",
    "AcceptType": "0",
    "CompleteOnUTC": null,
    "CreatedOnUTC": "2022-05-26T12:37:37.63Z",
    "ModifiedOnUTC": "2022-05-26T12:37:37.63Z"
}
</pre>


Retrieve a Wallet Link URL
-------------------------

* `GET /paylink/api/wallet/retrieve/h3GSpCZKsEWNxFv6T_y_Gw/link` will return the specified Wallet Link document's unique URL

###### Response
<pre>
"https://sandbox.payfabric.com/paylink/web/walletlink/h3GSpCZKsEWNxFv6T_y_Gw"
</pre>

Retrieve a Wallet Link
-------------------------

* `GET /paylink/api/wallet/PQM1UzV3xEC_YMs1hGxTdjE` will return the specified Wallet Link document

###### Response
<pre>
{
    "Id": "PQM1UzV3xEC_YMs1hGxTdjE",
    "InstID": "11a2c6f2-33f6-48b3-a5ab-697db2519ec7",
    "Device": "23c6b04e-cd06-4185-801a-8614508f065f",
    "TenderType": 1,
    "CustomerNumber": "CUST0001",
    "CustomerName": "JOHNDOE0001",
    "NotificationEmail": "sample@email.com",
    "NotificationEmailDisplay": "sample@email.com",
    "NotificationPhone": "123456789",
    "NotificationPhoneDisplay": "123456789",
    "CustomeMessage": "",
    "Status": 1,
    "Notification": {
        "Type": "All",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": "",
        "ResponseMessage": ""
    },
    "WalletID": "dd290509-cdcc-47e4-bad0-e39f8b633a7e",
    "ReturnUrl": "",
    "CompletedOn": "2022-05-26T06:03:24.073",
    "CreatedOn": "2022-05-26T05:59:00.66",
    "ModifiedOn": "2022-05-26T06:03:24.09",
    "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/PQM1UzV3xEC_YMs1hGxTdjE",
    "AcceptType": "0",
    "CompleteOnUTC": "2022-05-26T13:03:24.073Z",
    "CreatedOnUTC": "2022-05-26T12:59:00.66Z",
    "ModifiedOnUTC": "2022-05-26T13:03:24.09Z"
}
</pre>

Retrieve Wallet Links
-------------------------

* `GET /paylink/api/wallet` will return all Wallet Link documents created.
* `GET /paylink/api/wallet?$filter` will return all Wallet Link documents based on an OData ([What is OData?](http://www.odata.org/documentation/odata-version-3-0/url-conventions/)) query. 

e.g. `https://sandbox.payfabric.com/paylink/api/wallet?$filter=CustomerNumber eq 'test' and Device eq GUID'a284c1d0-a6fc-4938-98b4-0000b8cf4210' and Status eq '0' and NotificationEmail eq 'test@nodus.com' and NotificationPhone eq '1234567890' and CreatedOn gt datetime'2018-06-16' & $orderby CompletedOn desc`

###### Available OData Fields
>
| Field | Description | 
| :------------- | ------------- | 
| CustomerNumber | Customer number specified at the time of creating a wallet link. |
| CreatedOn | The date the wallet link was created on. The passed in date will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). |
| ModifiedOn | The date the wallet link was modified on. The passed in date will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md).|
| NotificationEmail | Email specified at the time of creating a wallet link. |
| NotificationPhone | Phone number specified at the time of creating a wallet link. |
| Status | `0=incomplete, 1=complete, 2=cancelled` |
|Device| Device used at the time of creating a wallet link. |
| CompletedOn | The date the wallet link was completed on. The passed in date will be treated in merchant [Timezone](https://github.com/PayFabric/Portal/blob/R19/PayFabric/Sections/Timezone.md). |

###### Response
<pre>
[
    {
        "Id": "x__BqrJ0xU2nEK_aOO7ozDE",
        "InstID": "11a2c6f2-33f6-48b3-a5ab-697db2519ec7",
        "Device": "23c6b04e-cd06-4185-801a-8614508f065f",
        "TenderType": 0,
        "CustomerNumber": "CUST0001",
        "CustomerName": "JOHNDOE0001",
        "NotificationEmail": "sample@email.com",
        "NotificationEmailDisplay": "sample@email.com",
        "NotificationPhone": "123456789",
        "NotificationPhoneDisplay": "123456789",
        "CustomeMessage": "",
        "Status": 0,
        "Notification": {
            "Type": "All",
            "SMSTemplate": null,
            "EmailTemplate": null,
            "ResponseStatus": "",
            "ResponseMessage": ""
        },
        "WalletID": "00000000-0000-0000-0000-000000000000",
        "ReturnUrl": "",
        "CompletedOn": null,
        "CreatedOn": "2022-05-26T05:37:37.636",
        "ModifiedOn": "2022-05-26T05:37:37.636",
        "Link": "https://sandbox.payfabric.com/PayLink/Web/walletlink/x__BqrJ0xU2nEK_aOO7ozDE",
        "AcceptType": "0",
        "CompleteOnUTC": null,
        "CreatedOnUTC": "2022-05-26T12:37:37.636Z",
        "ModifiedOnUTC": "2022-05-26T12:37:37.636Z"
    }
]
</pre>

Cancel a Wallet Link
-------------------

* `POST /paylink/api/wallet/h3GSpCZKsEWNxFv6T_y_Gw/cancel` will cancel the specified Wallet Link document

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or completed. 

