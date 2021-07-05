Templates
=========

The Template API is used for create, update, copy, delete, get and set default template. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

Create Templates by template type
------------------------------

* `POST /api/template/{type}` will create template for a specific type


Create Templates by template type
------------------------------

* `POST /api/template/{type}` will create template for a specific type



Update Templates by template type
------------------------------

* `PATCH /api/template/{TemplateID}` will update the specific template

Delete Templates by template type
------------------------------

* `DELETE /api/template/{TemplateID}` will delete the specific template



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

###### PayLink Email Template
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
        "Message": "<span style=\"font-family: 'Verdana', sans-serif;\"><p>[[[Document.PayLinkURL]]]</p>\r\n<p></p>\r\n<p><img src=\"https://www.securian.com/content/dam/securian/web-assets/brand/sf-logo-rgb-bk-wordmark.svg\" width=\"500\" height=\"115\" alt=\"\" /></p></span>",
        "Name": "svg"
    }
]
</pre>

###### PayLink SMS Template
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

###### WalletLink Email Template
<pre>
[
    {
        "ID": "cecdff81-3a2b-4fe1-9829-abad000ebc7b",
        "IsDefault": false,
        "Subject": "[[[Profile.CompanyName]]] Requests Your Payment Information",
        "Message": "<span style=\"font-family: 'Verdana', sans-serif;\"><p>Dear [[[Document.CustomerName]]],</p>\r\n<p>[[[Profile.CompanyName]]] invites you to use our secure digital wallet. By entering and saving your payment information you will be able to pay our invoices faster and easier in the future. Click the link below to get started or copy and paste the link in your web browser.</p>\r\n<p><a href=\"[[[Document.WalletLinkURL]]]\">[[[Document.WalletLinkURL]]]</a></p>\r\n<p>&nbsp;</p>\r\n<p>Sincerely,</p>\r\n<p>[[[Profile.CompanyName]]] Team</p></span>",
        "Name": "asdfasdfadf"
    },
    {
        "ID": "e7d88cd6-cff0-41af-b92d-abad00080e0c",
        "IsDefault": true,
        "Subject": "All Parameters",
        "Message": "<span style=\"font-family: 'Verdana', sans-serif;\"><p>WalletLinkURL: [[[Document.WalletLinkURL]]]</p>\r\n<p>CustomerNumber: [[[Document.CustomerNumber]]]</p>\r\n<p>CustomerName: [[[Document.CustomerName]]]</p>\r\n<p>DocumentDate: [[[Document.DocumentDate]]]</p>\r\n<p>Message: [[[Document.Message]]]</p>\r\n<p>CompanyName: [[[Profile.CompanyName]]]</p>\r\n<p>Email: [[[Profile.Email]]]</p>\r\n<p>Phone: [[[Profile.Phone]]]</p>\r\n<p>Address1: [[[Profile.Address1]]]</p>\r\n<p>Address2: [[[Profile.Address2]]]</p>\r\n<p>Address3: [[[Profile.Address3]]]</p>\r\n<p>City: [[[Profile.City]]]</p>\r\n<p>State: [[[Profile.State]]]</p>\r\n<p>Zip: [[[Profile.Zip]]]</p>\r\n<p>Country: [[[Profile.Country]]]</p></span>",
        "Name": "All Parameters"
    }
]
</pre>

###### WalletLink SMS Template
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

###### PayLink Payment page Template
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

