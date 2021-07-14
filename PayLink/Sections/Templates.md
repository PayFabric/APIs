Templates
=========

The Template API is used for create, update, copy, delete, get and set default template. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details. Please refer [Template Object](/PayFabric/Sections/3.1JSONObjects.md#template) for details.

Get Templates by template type
------------------------------

* `GET /paylink/api/template/{type}` will get templates for a specific type

###### Accepted value for 'type' field
>
| Type | Description | 
| :------------- | ------------- | 
| PayLinkEmailTemplate | By passing this value can get all the PayLink Notification Email Templates. |
| PayLinkSMSTemplate | By passing this value can get all the PayLink Notification SMS Templates.  |
| WalletLinkEmailTemplate | By passing this value can get all the WalletLink Notification Email Templates. |
| WalletLinkSMSTemplate | By passing this value can get all the WalletLink Notification SMS Templates. |
| PaymentPageTemplate | By passing this value can get all the Payment page Templates. |
| ConfirmationPageTemplate | By passing this value can get all the PayLink Confirmation page Templates. |

###### PayLink Email Template Response
<pre>
[
    {
        "ID": "706f7c7d-1278-4498-b185-ad2b0008f9cd",
        "IsDefault": true,
        "Subject": "0517",
        "Message": "<span style=\"font-family: 'Verdana', sans-serif;\"><p>[[[Document.PayLinkURL]]]</p></span>",
        "Name": "0517"
    },
    {
        "ID": "c2d0105f-fcca-4738-bdc3-abc20007c454",
        "IsDefault": false,
        "Subject": "svg",
        "Message": "[[[Document.PayLinkURL]]]",
        "Name": "svg"
    }
]
</pre>

###### PayLink SMS Template Response
<pre>
[
    {
        "ID": "4572003c-0c9e-49d3-ae8e-abad000ada00",
        "IsDefault": true,
        "Message": "PL0430:[[[Document.PayLinkURL]]]",
        "Name": "0430"
    },
    {
        "ID": "0a99fc04-81e9-4d6e-8094-ab8e010a3f58",
        "IsDefault": false,
        "Message": "[[[Document.PayLinkURL]]]",
        "Name": "0331"
    }
]
</pre>

###### WalletLink Email Template Response
<pre>
[
    {
        "ID": "cecdff81-3a2b-4fe1-9829-abad000ebc7b",
        "IsDefault": false,
        "Subject": "[[[Profile.CompanyName]]] Requests Your Payment Information",
        "Message": "[[[Document.WalletLinkURL]]]",
        "Name": "asdfasdfadf"
    },
    {
        "ID": "e7d88cd6-cff0-41af-b92d-abad00080e0c",
        "IsDefault": true,
        "Subject": "All Parameters",
        "Message": "WalletLinkURL: [[[Document.WalletLinkURL]]]",
        "Name": "All Parameters"
    }
]
</pre>

###### WalletLink SMS Template Response
<pre>
[
    {
        "ID": "54c021f1-7adc-4d2b-ba44-abad000bbbbc",
        "IsDefault": true,
        "Message": "0710: [[[Document.WalletLinkURL]]]",
        "Name": "WL0430"
    },
    {
        "ID": "44c7cd58-912e-418c-894a-ab9d017937d1",
        "IsDefault": false,
        "Message": "[[[Document.WalletLinkURL]]]",
        "Name": "ADSFADSF"
    }
]
</pre>

###### PayLink Payment page Template Response
<pre>
[
    {
        "ID": "ae702f91-d7ef-4bdf-9c5f-abda01864ead",
        "IsDefault": true,
        "CSS": null,
        "JS": null,
        "Name": "null"
    },
    {
        "ID": "0deb44db-4961-487e-8fbd-ab9d01794d16",
        "IsDefault": false,
        "CSS": "body{background-color:pink;}",
        "JS": "alert(1)",
        "Name": "PMT Test"
    }
]
</pre>

###### PayLink Confirmation Page Templates Response
<pre>
{
        "ID": "167af213-c91f-4fb7-8c56-abda018658ab",
        "IsDefault": true,
        "CSS": null,
        "JS": null,
        "Name": "null"
    },
    {
        "ID": "ef7ee4f8-d1fb-45e1-83fe-ab9d01796b09",
        "IsDefault": false,
        "CSS": "body{background-color:lightblue;}",
        "JS": "alert(2)",
        "Name": "confirm page"
    }
</pre>

Create Template for specific template type
--------------------------------

* `POST /paylink/api/template/{type}` will create template for a specific type

Please the available 'type' value [Available 'type' Value](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Templates.md#accepted-value-for-type-field)

###### Create PayLink Email Template Request
* Please refer the available [parameters](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Parameters.md#paylink-emailsms-template-parameters) for PayLink Email Template 
<pre>
{
    <b>"Subject": "PL Email Template",</b>
    <b>"Message": "[[[Document.PayLinkURL]]]",</b>
    <b>"Name": "PL Email Template"</b>
}
</pre>
###### Create PayLink Email Template Response
<pre>
{
    "ID": "73b3d7ca-a2d7-493f-8d13-ad5c0012b437",
    "Subject": "PL Email Template",
    "Message": "[[[Document.PayLinkURL]]]",
    "CSS": null,
    "JS": null,
    "Name": "PL Email Template"
}
</pre>

###### Create PayLink SMS Template Request
* Please refer the available [parameters](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Parameters.md#paylink-emailsms-template-parameters) for PayLink SMS Template 
<pre>
{
    <b>"Subject": "PayLink SMS Template",</b>
    <b>"Message": "[[[Document.PayLinkURL]]]",</b>
    <b>"Name": "PayLink SMS Template"</b>
}
</pre>
###### Create PayLink SMS Template Response
<pre>
{
    "ID": "f0473844-3769-448d-a7e0-ad5c001163d1",
    "Subject": "PayLink SMS Template",
    "Message": "[[[Document.PayLinkURL]]]",
    "CSS": null,
    "JS": null,
    "Name": "PayLink SMS Template"
}
</pre>

###### Create WalletLink Email Template Request
* Please refer the available [parameters](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Parameters.md#walletlink-emailsms-template-parameters) for WalletLink Email Template 
<pre>
{
    <b>"Subject": "WalletLink Email",</b>
    <b>"Message": "[[[Document.WalletLinkURL]]]",</b>
    <b>"Name": "WalletLink Email"</b>
}
</pre>
###### Create WalletLink Email Template Response
<pre>
{
    "ID": "ee2f96b1-c837-430c-b722-ad5b0179f399",
    "Subject": "WalletLink Email",
    "Message": "[[[Document.WalletLinkURL]]]",
    "CSS": null,
    "JS": null,
    "Name": "WalletLink Email"
}
</pre>

###### Create WalletLink SMS Template Request
* Please refer the available [parameters](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Parameters.md#walletlink-emailsms-template-parameters) for WalletLink SMS Template 
<pre>
{
    <b>"Subject": "WalletLink SMS",</b>
    <b>"Message": "[[[Document.WalletLinkURL]]]",</b>
    <b>"Name": "WalletLink SMS"</b>
}
</pre>
###### Create WalletLink SMS Template Response
<pre>
{
    "ID": "ee2f96b1-c837-430c-b722-ad5b0179f399",
    "Subject": "WalletLink SMS",
    "Message": "[[[Document.WalletLinkURL]]]",
    "CSS": null,
    "JS": null,
    "Name": "WalletLink SMS"
}
</pre>

###### Create PayLink Payment Page Template Request
<pre>
{
    "CSS": "body{background-color:lightblue;}",
    "JS": "alert(2)",
    <b>"Name": "Payment Page Template"</b>
}
</pre>
###### Create PayLink Payment Page Template Response
<pre>
{
    "ID": "96a7a7d9-88bd-41ce-86f1-ad5c00105f35",
    "Subject": null,
    "Message": null,
    "CSS": "body{background-color:lightblue;}",
    "JS": "alert(2)",
    "Name": "Payment Page Template"
}
</pre>

###### Create PayLink Confirmation Page Template Request
<pre>
{
    "CSS": "body{background-color:lightblue;}",
    "JS": "alert(1)",
    <b>"Name": "PL Confirm Page"</b>
}
</pre>
###### Create PayLink Confirmation Page Template Response
<pre>
{
    "ID": "1dc50bb7-d1d3-4afd-b2d5-ad5b0176ad59",
    "Subject": null,
    "Message": null,
    "CSS": "body{background-color:lightblue;}",
    "JS": "alert(1)",
    "Name": "PL Confirm Page"
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see [Template Object](https://github.com/PayFabric/APIs/blob/Release-16/PayFabric/Sections/3.1JSONObjects.md#template)

Copy Template
------------------------------

* `POST /paylink/api/template/{TemplateID}/copy` will copy the specific template

###### Copy PayLink Tempalte Request
<pre>
{
    "Name": "COPY Template"
}
</pre>

###### Copy PayLink Tempalte Response
<pre>
{
    "ID": "42c2ce0c-523f-4ee6-95f3-ad5c001488c1",
    "Subject": "[[[Profile.CompanyName]]] Requests Your Payment Information",
    "Message": "[[[Document.WalletLinkURL]]]",
    "CSS": null,
    "JS": null,
    "Name": "COPY Template"
}
</pre>

Update Template
------------------------------
* `PATCH /paylink/api/template/{TemplateID}` will update the specific template
* 
###### Update Template Request
Please refer the [create template request](https://github.com/PayFabric/APIs/blob/Release-16/PayLink/Sections/Templates.md#create-template-for-specific-template-type) for each template type.

###### Update Template Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the specified template ID is not match with the template type or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Delete Template
------------------------------

* `DELETE /paylink/api/template/{TemplateID}` will delete the specific template

###### Response
A successful `DELETE` will result in a HTTP 204 No Content Response.

A failed `DELETE` may result in a HTTP 400 Bad Request Response if the specified template ID is not match with the template type or the Device ID used for the Security Token does not match or post failed.

A failed `DELETE` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.


Set specific Template as default template
------------------------------

* `POST /paylink/api/template/{type}/default` will set specific template as default template for specific template type.
###### Set default template request
{
    "Id" : "a9394e22-999e-46ef-8105-29e9d210770d"
}
###### Set default template response
A successful `POST` will result in a HTTP 200 OK Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified template ID is not match with the template type or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.


