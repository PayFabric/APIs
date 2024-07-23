PayLinks
========

The PayLinks API is used for creating, updating and retrieving PayLinks. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

Create a PayLink
----------------

* `POST /paylink/api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload

###### Request
<pre>
{
   <b>"Currency": "USD"</b>,
   <b>"Amount": 20</b>,
   <b>"DocumentAmount": 20</b>,
   "TaxAmount": "1.5", 
    "TradeDiscount": "3", 
    "Freight": "1", 
    "MiscAmount": "2.5", 
    "CustomerNumber": "AARONFIT0001", 
    "CustomerName": "AARON Fit 001", 
    <b>"IsMultipleInvoice": false, </b>
    "DocumentNumber": "STDINV2267", 
    <b>"TransactionType": "Sale", </b>
    <b>"DocDate": "4/3/2020 5:21:09 PM", </b>
    "DueDate": "4/3/2020 5:21:09 PM", 
    "DocType": 3,
    "PaymentTerm": "Retail", 
    "PostDataType": "PaymentLine",
    "BatchNo":"Test",
    "Status": "1", 
    "IntegrationStatus": null, 
    "ShippingAddress": {
        "Address1": "123 Test Street", 
        "Address2": "12 Test Street", 
        "Address3": "1 Test Street", 
        "Email": "sample@email.com", 
        "City": "Anaheim", 
        "State": "CA", 
        "Country": "USA", 
        "Zip": "90201", 
        "Phone1": "1523691233", 
        "Phone2": "4525616636", 
        "Phone3": "4515845632"
    }, 
    "BillingAddress": {
        "Address1": "line 12", 
        "Address2": "liner r3", 
        "Address3": "line 3", 
        "Email": "sample@email.com", 
        "City": "Anaheim", 
        "State": "CA", 
        "Country": "US", 
        "Zip": "90201", 
        "Phone1": "1523691233", 
        "Phone2": "4525616636", 
        "Phone3": "4515845632"
    }, 
    "Notification": {
        <b>"Type": "All", </b>
        "SMSTemplate": null, 
        "EmailTemplate": null     
    }, 
    <b>"NotificationEmail": "sample@email.com",</b> 
    <b>"NotificationPhone": "15151472869",  </b>
     "UserDefinedFields": [
                 {
                    "Key": "SubTotal", 
                    "Value": "20"
                }
            ],
    "Items": [
        {
            <b>"ItemCode": "A100", </b>
            "ItemCommodityCode": "A100", 
            "ItemProdCode": "A100", 
            "ItemUOM": "Each", 
            "ItemDiscount": "0", 
            "Description": "A100 item", 
            "ItemDesc": "A100", 
            "ItemUPC": "A100", 
            "ItemFreightAmount": "1.23", 
            "ItemHandlingAmount": "2.36", 
            "ItemTaxRate": "2.00", 
            "ItemCost": "2.3", 
            "ItemTaxAmount": "1.02", 
            <b>"UnitPrice":"6",</b>
            "ItemAmount": "39.95", 
            <b>"Quantity":"3",</b>
            "PriceLevel": "Retail", 
            "UnitOfMeasure": "Each", 
            "SiteCode": "WAREHOUSE", 
            "MarkDown": "0", 
            "TaxAmount": "0",               
            "UserDefinedFields": [
                {
                    "Key": "ExtPrice", 
                    "Value": "18.00"
                }
            ]
        }
    ], 
    "Payment": {
        "CreditCardGateway": "EVO", 
        "ECheckGateway": "USASOAPECheck", 
        "AcceptType": 0
    },    
    "CustomeMessage": "CustomeMessage"
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

Below is the payment page for the single invoice paylink created with above body
![PL_SI_PMTPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_PMTPage.png)

If this paylink using the gateway whose SurchargeRate greater than 0, then the PayLink hosted payment page will show the Surcharge to end user

![SIPLHostedPMTPageWithSurcharge](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/SIPLHostedPMTPageWithSurcharge.png)

Below is the Invoice Details page, can be opened by clicking the Invoice Number on paylink payment page
![PL_SI_InvDetailsPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_InvDetailsPage.png)

Below is the PayLink Confirmation page
![PL_SI_CFMPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_CFMPage.png)

Below is the PayLink Confirmation page with Surcharge

![SIPLCMFPageWithSurcharge](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/SIPLCMFPageWithSurcharge.png)

###### Related Reading
* [Which Transaction Type to Use](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Transaction%20Types.md)

###### Response
<pre>
{
    "Id": "Fs8Fd9OULU6cQicrHPXC9TE",
    "InstID": "8b5dce02-346e-490e-a07a-8b56294b3a58",
    "Device": "28c54462-f769-2a35-2114-0f5fd3ca1241",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 20.0,
    "DocumentAmount": 20.0,
    "TaxAmount": 1.5,
    "TradeDiscount": 3.0,
    "Freight": 1.0,
    "MiscAmount": 2.5,
    "CustomerNumber": "AARONFIT0001",
    "CustomerName": "AARON Fit 001",
    "IsMultipleInvoice": false,
    "DocumentNumber": "STDINV2267",
    "DocumentNumberDisplay": "STDINV2267",
    "TransactionType": "Sale",
    "CreatedOn": "2022-05-26T14:32:12.412",
    "ModifiedOn": "2022-05-26T14:32:12.412",
    "DocDate": "2020-04-03T17:21:09",
    "DueDate": "2020-04-03T17:21:09",
    "DocType": 3,
    "PaymentTerm": "Retail",
    "SourceOfDocument": 0,
    "BatchSource": 0,
    "BatchNo": "Test",
    "MerchantEmail": null,
    "ReturnUrl": null,
    "Status": 1,
    "IntegrationStatus": 0,
    "Tax": null,
    "ShippingAddress": {
        "Email": "sample@email.com",
        "Address1": "123 Test Street",
        "Address2": "12 Test Street",
        "Address3": "1 Test Street",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "90201",
        "Country": "USA",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "BillingAddress": {
        "Email": "sample@email.com",
        "Address1": "line 12",
        "Address2": "liner r3",
        "Address3": "line 3",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "90201",
        "Country": "US",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "Items": [
        {
            "ItemCode": "A100",
            "AppliedAmount": 0.0,
            "DueDate": null,
            "Description": "A100 item",
            "UnitPrice": "6",
            "ItemAmount": "39.95",
            "Quantity": "3",
            "PriceLevel": "Retail",
            "UnitOfMeasure": "Each",
            "SiteCode": "WAREHOUSE",
            "MarkDown": 0.0,
            "TaxAmount": 0.0,
            "MiscAmount": 0.0,
            "UserDefinedFields": [
                {
                    "Key": "ExtPrice",
                    "Value": "18.00"
                }
            ],
            "Items": null,
            "ShippingAddress": null,
            "BillingAddress": null
        }
    ],
    "UserDefinedFields": [
        {
            "Key": "SubTotal",
            "Value": "20"
        }
    ],
    "Notification": {
        "Type": "All",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": "2",
        "ResponseMessage": "Invalid SMS template."
    },
    "PostDataType": "PaymentLine",
    "TransactionKey": "22052601049295",
    "PaidOn": null,
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": "CustomeMessage",
    "Payment": {
        "CreditCardGateway": "EVO",
        "ECheckGateway": "EVOACH",
        "AcceptType": 0
    },
    "NotificationEmail": "sample@email.com",
    "NotificationEmailDisplay": "sample@email.com",
    "NotificationPhone": "15151472869",
    "NotificationPhoneDisplay": "15151472869",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://sandbox.payfabric.com/PayLink/Web/Fs8Fd9OULU6cQicrHPXC9TE",
    "EntryClass": null,
    "CreatedOnUTC": "2022-05-26T11:32:12.412Z",
    "ModifiedOnUTC": "2022-05-26T11:32:12.412Z",
    "PaidOnUTC": null,
    "LastProcessDateUTC": null
}
</pre>

The response will include the full document object, see the [Retrieve a PayLink](#retrieve-a-paylink) endpoint for more information.

Create a Multiple Invoice PayLink
---------------------------------

* `POST /paylink/api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload, the trick to creating a PayLink as a multiple invoice, is using the **IsMultipleInvoice** and **Items** fields

###### Request
<pre>
{     
    <b>"Currency": "USD", </b>
    <b>"Amount": "80", </b>
    <b>"DocumentAmount": "70", </b>    
    <b>"CustomerNumber": "aaronfit0001", </b>
    "CustomerName": "AARONFIT0001", 
    <b>"IsMultipleInvoice": true, </b>
    "DocumentNumber": "", 
    <b>"TransactionType": "Sale", </b>
    <b>"DocDate": "6/15/2020 2:27:04 PM", </b>
    "DueDate": "6/15/2020 2:27:04 PM", 
    <b>"DocType": "3", </b>
    "PaymentTerm": "Retail", 
    "SourceOfDocument": "1", 
    "BatchSource": "1", 
    <b>"BatchNo": "Test paylink", </b>
    "MerchantEmail": "merchant@nodus.com", 
    "ReturnUrl": null, 
    <b>"Status": "1", </b>
    "IntegrationStatus": null, 
    "ShippingAddress": {
        "Address1": "123 Test Street", 
        "Address2": "12 Test Street", 
        "Address3": "1 Test Street", 
        "Email": "sample@email.com", 
        "City": "Anaheim", 
        "State": "CA", 
        "Country": "USA", 
        "Zip": "90201", 
        "Phone1": "1523691233", 
        "Phone2": "4525616636", 
        "Phone3": "4515845632"
    }, 
    "BillingAddress": {
        "Address1": "line 12", 
        "Address2": "liner r3", 
        "Address3": "~!@!$@#%# gfywefyeasg", 
        "Email": "sample@email.com", 
        "City": "Anaheim", 
        "State": "CA", 
        "Country": "US", 
        "Zip": "90201", 
        "Phone1": "1523691233", 
        "Phone2": "4525616636", 
        "Phone3": "4515845632"
    }, 
    "Notification": {
        <b>"Type": "All", </b>
        "SMSTemplate": "c81b5a0a-23a5-4bcc-b5fe-a8d6002db28d", 
        "EmailTemplate": "9613cf11-fe5a-4c30-b1d6-a8d6002d1b39"   
    }, 
    <b>"NotificationEmail": "rena.wu@nodus.com",</b> 
    <b>"NotificationPhone": "18915400883", </b>
    "PostDataType": "CashReceipt", 
    "UserDefinedFields": null, 
    "Items": [
        {
            <b>"ItemCode": "STDINV2403", </b>
            <b>"AppliedAmount": "30", </b>
            "DueDate": "6/15/2020 2:27:04 PM", 
            "TaxAmount": "4",   
            "UserDefinedFields": [
                {
                    "Key": "SubTotal", 
                    "Value": "44"
                }, 
                {
                    "Key": "Miscellaneous", 
                    "Value": "1.00"
                }, 
                {
                    "Key": "Freight", 
                    "Value": "2.00"
                },				
                {
                    "Key": "TradeDiscount",
                    "Value": "3.00"
                }
            ], 
            "Items": [
                {
                    <b>"ItemCode": "A100", </b>
                    "ItemCommodityCode": "A100", 
                    "ItemProdCode": "A100", 
                    "ItemUOM": "Each", 
                    "ItemDiscount": "0", 
                    "Description": "A100 item", 
                    "ItemDesc": "A100", 
                    "ItemUPC": "A100", 
                    "ItemFreightAmount": "1.23", 
                    "ItemHandlingAmount": "2.36", 
                    "ItemTaxRate": "2.00", 
                    "ItemCost": "2.3", 
                    "ItemTaxAmount": "1.02", 
                    <b>"UnitPrice": "20",</b> 
                    "ItemAmount": "40", 
                    <b>"Quantity": "2", </b>
                    "PriceLevel": "Retail", 
                    "UnitOfMeasure": "Each", 
                    "SiteCode": "WAREHOUSE", 
                    "MarkDown": "0", 
                    "TaxAmount": "0",                     
                    "MiscAmount": "0", 
                    "UserDefinedFields": [                        
                        {
                            "Key": "ExtPrice", 
                            "Value": "40"
                        }
                    ]
                }
            ]
        }, 
        {
            <b>"ItemCode": "STDINV2402", </b>
            <b>"AppliedAmount": "40", </b>
            "DueDate": "6/15/2020 2:27:04 PM", 
            "TaxAmount": "6",            
            "UserDefinedFields": [
                {
                    "Key": "SubTotal", 
                    "Value": "99.00"
                }, 
                {
                    "Key": "Miscellaneous", 
                    "Value": "4.00"
                }, 
                {
                    "Key": "Freight", 
                    "Value": "2.00"
                },
                {
                    "Key": "TradeDiscount",
                    "Value": "3"
                }
            ], 
            "Items": [
                {
                    <b>"ItemCode": "B100", </b>
                    "ItemCommodityCode": "A100", 
                    "ItemProdCode": "A100", 
                    "ItemUOM": "Each", 
                    "ItemDiscount": "0", 
                    "Description": "A100 item", 
                    "ItemDesc": "A100", 
                    "ItemUPC": "A100", 
                    "ItemFreightAmount": "1.23", 
                    "ItemHandlingAmount": "2.36", 
                    "ItemTaxRate": "2.00", 
                    "ItemCost": "2.3", 
                    "ItemTaxAmount": "1.02", 
                    <b>"UnitPrice": "30.00", </b>
                    "ItemAmount": "90.00", 
                    <b>"Quantity": "3", </b>
                    "PriceLevel": "Retail", 
                    "UnitOfMeasure": "Each", 
                    "SiteCode": "WAREHOUSE", 
                    "MarkDown": "0", 
                    "TaxAmount": "0",                    
                    "MiscAmount": "0", 
                    "UserDefinedFields": [                        
                        {
                            "Key": "ExtPrice", 
                            "Value": "90"
                        }
                    ]
                }
            ]
        }
    ],  
    "Payment": {
        "CreditCardGateway": "EVO", 
        "ECheckGateway": "USASOAPECheck", 
        "AcceptType": 0
    },  
    "Tax": {
        "Name": "Tax name", 
        "percent": "11", 
        "amount": "1.11"
    }, 
    "CustomeMessage": "CustomeMessage"
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional.  If you wish to apply a surcharge fee for paylink, then please configure SurchargeRate for the gateway the paylink use. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

Below is the payment page for the multi-Invoices paylink created with above body
![PL_MI_PMTPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_MI_PMTPage.png)

Below is the Invoice Details page, can be opened by clicking the Invoice Number on paylink payment page
![PL_MI_InvDetailsPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_MI_InvDetailsPage.png)

Below is the PayLink Confirmation page
![PL_MI_CFMPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_MI_CFMPage.png)

###### Related Reading
* [Which Transaction Type to Use](../../../../portal/tree/master/Sections/Transaction%20Types.md)

###### Response
<pre>
{
    "Id": "XrModjeSW0e0xJkqx5BUbTE",
    "InstID": "8b5dce02-346e-490e-a07a-8b56294b3a58",
    "Device": "28c54462-f769-2a35-2114-0f5fd3ca1241",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 80.0,
    "DocumentAmount": 70.0,
    "TaxAmount": 0.0,
    "TradeDiscount": 0.0,
    "Freight": 0.0,
    "MiscAmount": 0.0,
    "CustomerNumber": "aaronfit0001",
    "CustomerName": "AARONFIT0001",
    "IsMultipleInvoice": true,
    "DocumentNumber": "MINV0000011570",
    "DocumentNumberDisplay": "MINV0000011570",
    "TransactionType": "Sale",
    "CreatedOn": "2022-05-26T14:36:54.079",
    "ModifiedOn": "2022-05-26T14:36:54.079",
    "DocDate": "2020-06-15T14:27:04",
    "DueDate": "2020-06-15T14:27:04",
    "DocType": 3,
    "PaymentTerm": "Retail",
    "SourceOfDocument": 1,
    "BatchSource": 1,
    "BatchNo": "Test paylink",
    "MerchantEmail": "merchant@nodus.com",
    "ReturnUrl": null,
    "Status": 1,
    "IntegrationStatus": 0,
    "Tax": {
        "Name": "Tax name",
        "percent": 11.0,
        "amount": 1.11
    },
    "ShippingAddress": {
        "Email": "sample@email.com",
        "Address1": "123 Test Street",
        "Address2": "12 Test Street",
        "Address3": "1 Test Street",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "90201",
        "Country": "USA",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "BillingAddress": {
        "Email": "sample@email.com",
        "Address1": "line 12",
        "Address2": "liner r3",
        "Address3": "~!@!$@#%# gfywefyeasg",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "90201",
        "Country": "US",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "Items": [
        {
            "ItemCode": "STDINV2403",
            "AppliedAmount": 30.0,
            "DueDate": "2020-06-15T14:27:04",
            "Description": null,
            "UnitPrice": "0",
            "ItemAmount": null,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0.0,
            "TaxAmount": 4.0,
            "MiscAmount": 0.0,
            "UserDefinedFields": [
                {
                    "Key": "SubTotal",
                    "Value": "44"
                },
                {
                    "Key": "Miscellaneous",
                    "Value": "1.00"
                },
                {
                    "Key": "Freight",
                    "Value": "2.00"
                },
                {
                    "Key": "TradeDiscount",
                    "Value": "3.00"
                }
            ],
            "Items": [
                {
                    "ItemCode": "A100",
                    "AppliedAmount": 0.0,
                    "DueDate": null,
                    "Description": "A100 item",
                    "UnitPrice": "20",
                    "ItemAmount": "40",
                    "Quantity": "2",
                    "PriceLevel": "Retail",
                    "UnitOfMeasure": "Each",
                    "SiteCode": "WAREHOUSE",
                    "MarkDown": 0.0,
                    "TaxAmount": 0.0,
                    "MiscAmount": 0.0,
                    "UserDefinedFields": [
                        {
                            "Key": "ExtPrice",
                            "Value": "40"
                        }
                    ],
                    "Items": null,
                    "ShippingAddress": null,
                    "BillingAddress": null
                }
            ],
            "ShippingAddress": null,
            "BillingAddress": null
        },
        {
            "ItemCode": "STDINV2402",
            "AppliedAmount": 40.0,
            "DueDate": "2020-06-15T14:27:04",
            "Description": null,
            "UnitPrice": "0",
            "ItemAmount": null,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0.0,
            "TaxAmount": 6.0,
            "MiscAmount": 0.0,
            "UserDefinedFields": [
                {
                    "Key": "SubTotal",
                    "Value": "99.00"
                },
                {
                    "Key": "Miscellaneous",
                    "Value": "4.00"
                },
                {
                    "Key": "Freight",
                    "Value": "2.00"
                },
                {
                    "Key": "TradeDiscount",
                    "Value": "3"
                }
            ],
            "Items": [
                {
                    "ItemCode": "B100",
                    "AppliedAmount": 0.0,
                    "DueDate": null,
                    "Description": "A100 item",
                    "UnitPrice": "30.00",
                    "ItemAmount": "90.00",
                    "Quantity": "3",
                    "PriceLevel": "Retail",
                    "UnitOfMeasure": "Each",
                    "SiteCode": "WAREHOUSE",
                    "MarkDown": 0.0,
                    "TaxAmount": 0.0,
                    "MiscAmount": 0.0,
                    "UserDefinedFields": [
                        {
                            "Key": "ExtPrice",
                            "Value": "90"
                        }
                    ],
                    "Items": null,
                    "ShippingAddress": null,
                    "BillingAddress": null
                }
            ],
            "ShippingAddress": null,
            "BillingAddress": null
        }
    ],
    "UserDefinedFields": null,
    "Notification": {
        "Type": "All",
        "SMSTemplate": "c81b5a0a-23a5-4bcc-b5fe-a8d6002db28d",
        "EmailTemplate": "9613cf11-fe5a-4c30-b1d6-a8d6002d1b39",
        "ResponseStatus": "2",
        "ResponseMessage": "Invalid SMS template."
    },
    "PostDataType": "CashReceipt",
    "TransactionKey": "22052601049312",
    "PaidOn": null,
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": "CustomeMessage",
    "Payment": {
        "CreditCardGateway": "EVO",
        "ECheckGateway": "EVOACH",
        "AcceptType": 0
    },
    "NotificationEmail": "rena.wu@nodus.com",
    "NotificationEmailDisplay": "rena.wu@nodus.com",
    "NotificationPhone": "18915400883",
    "NotificationPhoneDisplay": "18915400883",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://sandbox.payfabric.com/PayLink/Web/XrModjeSW0e0xJkqx5BUbTE",
    "EntryClass": null,
    "CreatedOnUTC": "2022-05-26T11:36:54.079Z",
    "ModifiedOnUTC": "2022-05-26T11:36:54.079Z",
    "PaidOnUTC": null,
    "LastProcessDateUTC": null
}
</pre>

The response will include the full document object, see the [Retrieve a PayLink](#retrieve-a-paylink) endpoint for more information.


Update a PayLink
----------------

* `PATCH /paylink/api/document/gwx9q6fqcEuagAJLA27CIA` will update the specified PayLink document with new information based on the request JSON payload
Note: NotificationEmail and NotificationPhone are not able to update.

###### Request
A JSON object using only the fields that need updating should be included, see the [Create a PayLink](#create-a-paylink) endpoint for more information.  To release a draft PayLink document and make it active and ready to accept payments all you must do is supply the following JSON payload:
<pre>
{
  "Status": 1
}
</pre>

###### Response
A successful `PATCH` will result in a HTTP 200 OK Response.  
A failed `PATCH` will result in a HTTP 400 Bad Request Response with the message providing the failed reason.  

Retrieve a PayLink
------------------

* `GET /paylink/api/document/XrModjeSW0e0xJkqx5BUbTE` will return the specified PayLink document

###### Response
<pre>
{
    "Id": "XrModjeSW0e0xJkqx5BUbTE",
    "InstID": "8b5dce02-346e-490e-a07a-8b56294b3a58",
    "Device": "28c54462-f769-2a35-2114-0f5fd3ca1241",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 80.00,
    "DocumentAmount": 70.0,
    "TaxAmount": 0.0,
    "TradeDiscount": 0.0,
    "Freight": 0.0,
    "MiscAmount": 0.0,
    "CustomerNumber": "aaronfit0001",
    "CustomerName": "AARONFIT0001",
    "IsMultipleInvoice": true,
    "DocumentNumber": "MINV0000011570",
    "DocumentNumberDisplay": "MINV0000011570",
    "TransactionType": "Sale",
    "CreatedOn": "2022-05-26T14:36:54.076",
    "ModifiedOn": "2022-05-26T14:40:03.436",
    "DocDate": "2020-06-15T14:27:04",
    "DueDate": "2020-06-15T14:27:04",
    "DocType": 3,
    "PaymentTerm": "Retail",
    "SourceOfDocument": 1,
    "BatchSource": 1,
    "BatchNo": "Test paylink",
    "MerchantEmail": "merchant@nodus.com",
    "ReturnUrl": null,
    "Status": 3,
    "IntegrationStatus": 0,
    "Tax": {
        "Name": "Tax name",
        "percent": 11.0,
        "amount": 1.11
    },
    "ShippingAddress": {
        "Email": "sample@email.com",
        "Address1": "123 Test Street",
        "Address2": "12 Test Street",
        "Address3": "1 Test Street",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "90201",
        "Country": "USA",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "BillingAddress": {
        "Email": "sample@email.com",
        "Address1": "123 TEST",
        "Address2": "1",
        "Address3": "d",
        "City": "Anaheim",
        "State": "CA",
        "Zip": "12345",
        "Country": "USA",
        "Phone1": "1234567890",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "Items": [
        {
            "ItemCode": "STDINV2403",
            "AppliedAmount": 30.0,
            "DueDate": "2020-06-15T14:27:04",
            "Description": null,
            "UnitPrice": "0",
            "ItemAmount": null,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0.0,
            "TaxAmount": 4.0,
            "MiscAmount": 0.0,
            "UserDefinedFields": [
                {
                    "Key": "SubTotal",
                    "Value": "44"
                },
                {
                    "Key": "Miscellaneous",
                    "Value": "1.00"
                },
                {
                    "Key": "Freight",
                    "Value": "2.00"
                },
                {
                    "Key": "TradeDiscount",
                    "Value": "3.00"
                }
            ],
            "Items": [
                {
                    "ItemCode": "A100",
                    "AppliedAmount": 0.0,
                    "DueDate": null,
                    "Description": "A100 item",
                    "UnitPrice": "20",
                    "ItemAmount": "40",
                    "Quantity": "2",
                    "PriceLevel": "Retail",
                    "UnitOfMeasure": "Each",
                    "SiteCode": "WAREHOUSE",
                    "MarkDown": 0.0,
                    "TaxAmount": 0.0,
                    "MiscAmount": 0.0,
                    "UserDefinedFields": [
                        {
                            "Key": "ExtPrice",
                            "Value": "40"
                        }
                    ],
                    "Items": null,
                    "ShippingAddress": null,
                    "BillingAddress": null
                }
            ],
            "ShippingAddress": null,
            "BillingAddress": null
        },
        {
            "ItemCode": "STDINV2402",
            "AppliedAmount": 40.0,
            "DueDate": "2020-06-15T14:27:04",
            "Description": null,
            "UnitPrice": "0",
            "ItemAmount": null,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0.0,
            "TaxAmount": 6.0,
            "MiscAmount": 0.0,
            "UserDefinedFields": [
                {
                    "Key": "SubTotal",
                    "Value": "99.00"
                },
                {
                    "Key": "Miscellaneous",
                    "Value": "4.00"
                },
                {
                    "Key": "Freight",
                    "Value": "2.00"
                },
                {
                    "Key": "TradeDiscount",
                    "Value": "3"
                }
            ],
            "Items": [
                {
                    "ItemCode": "B100",
                    "AppliedAmount": 0.0,
                    "DueDate": null,
                    "Description": "A100 item",
                    "UnitPrice": "30.00",
                    "ItemAmount": "90.00",
                    "Quantity": "3",
                    "PriceLevel": "Retail",
                    "UnitOfMeasure": "Each",
                    "SiteCode": "WAREHOUSE",
                    "MarkDown": 0.0,
                    "TaxAmount": 0.0,
                    "MiscAmount": 0.0,
                    "UserDefinedFields": [
                        {
                            "Key": "ExtPrice",
                            "Value": "90"
                        }
                    ],
                    "Items": null,
                    "ShippingAddress": null,
                    "BillingAddress": null
                }
            ],
            "ShippingAddress": null,
            "BillingAddress": null
        }
    ],
    "UserDefinedFields": [
        {
            "Key": "Surcharge",
            "Value": "0.00"
        },
        {
            "Key": "SurchargePercentage",
            "Value": "0.00"
        },
        {
            "Key": "TrxAmount",
            "Value": "80.00"
        },
        {
            "Key": "OrigTrxAmount",
            "Value": "80.00"
        },
        {
            "Key": "FinalAmount",
            "Value": "80.00"
        },
        {
            "Key": "CardType",
            "Value": "Credit"
        }
    ],
    "Notification": {
        "Type": "All",
        "SMSTemplate": "c81b5a0a-23a5-4bcc-b5fe-a8d6002db28d",
        "EmailTemplate": "9613cf11-fe5a-4c30-b1d6-a8d6002d1b39",
        "ResponseStatus": "",
        "ResponseMessage": ""
    },
    "PostDataType": "CashReceipt",
    "TransactionKey": "22052601049312",
    "PaidOn": "2022-05-26T14:40:03.19",
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": "CustomeMessage",
    "Payment": {
        "CreditCardGateway": "EVO",
        "ECheckGateway": "EVOACH",
        "AcceptType": 0
    },
    "NotificationEmail": "rena.wu@nodus.com",
    "NotificationEmailDisplay": "rena.wu@nodus.com",
    "NotificationPhone": "18915400883",
    "NotificationPhoneDisplay": "18915400883",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://sandbox.payfabric.com/PayLink/Web/XrModjeSW0e0xJkqx5BUbTE",
    "EntryClass": null,
    "CreatedOnUTC": "2022-05-26T11:36:54.076Z",
    "ModifiedOnUTC": "2022-05-26T11:40:03.436Z",
    "PaidOnUTC": "2022-05-26T11:40:03.19Z",
    "LastProcessDateUTC": null
}
</pre>

Retrieve PayLinks
-----------------

* `GET /paylink/api/document` will return all PayLink documents created
* `GET /paylink/api/document?$filter` will return all PayLink documents based on an OData ([What is OData?](http://www.odata.org/documentation/odata-version-3-0/url-conventions/)) query

e.g. `https://sandbox.payfabric.com/paylink/api/document?$filter=CustomerNumber eq 'AARONFIT0001' and Device eq GUID'a284c1d0-a6fc-4938-98b4-0000b8cf4210' and DocumentNumber eq 'ORDER001' and DocDate lt datetime'2018-09-25' and DueDate eq null and PaidOn gt datetime'2017-02-02' and Amount gt 8 and NotificationEmail eq 'test@nodus.com' and Status eq '3' and IntegrationStatus eq '2' and TransactionKey eq '180227157886' & $orderby CreatedOn desc`

###### Available OData Fields
>
| Field | Description | 
| :------------- | ------------- | 
| CustomerNumber | The customer number specified during PayLink creation. |
| DocumentNumber | The document number specified during PayLink creation. |
| DocDate | The document date specified during PayLink creation. |
| DueDate | The payment due date specified during PayLink creation. |
| CreatedOn | The date the PayLink was created. |
| ModifiedOn | The date the PayLink was modified. |
| PaidOn | The date the PayLink was paid. |
| Amount | The amount of the PayLink. |
| NotificationEmail | The notification email assigned to the PayLink. |
| Status | The status of the PayLink, available values are `0 = draft, 1 = waiting for payment, 2 = cancelled and 3 = paid` |
|IntegrationStatus| The integration status of the PayLink, available values are `0 = Pending, 1 = Failed and 2 = Successful`|
| TransactionKey | The PayFabric transaction key. |
|Device| Device used at the time of creating a PayLink. |

###### Response
<pre>
[
     {
        "Id": "85ws0syB7kK1LsButGkyIDE",
        "InstID": "8b5dce02-346e-490e-a07a-8b56294b3a58",
        "Device": "28c54462-f769-2a35-2114-0f5fd3ca1241",
        "SetupId": "AuthCredit",
        "Currency": "USD",
        "Amount": 10.00,
        "DocumentAmount": 10.0,
        "TaxAmount": 0.0,
        "TradeDiscount": 0.0,
        "Freight": 0.0,
        "MiscAmount": 0.0,
        "CustomerNumber": "AARONFIT0001",
        "CustomerName": "aaronfit0001",
        "IsMultipleInvoice": false,
        "DocumentNumber": null,
        "DocumentNumberDisplay": "",
        "TransactionType": "Sale",
        "CreatedOn": "2021-04-02T05:44:01.333",
        "ModifiedOn": "2021-04-02T05:44:01.333",
        "DocDate": "2021-04-01T19:44:00.557",
        "DueDate": "2021-05-01T19:44:00.557",
        "DocType": 3,
        "PaymentTerm": "Net 30",
        "SourceOfDocument": 0,
        "BatchSource": 0,
        "BatchNo": null,
        "MerchantEmail": null,
        "ReturnUrl": null,
        "Status": 1,
        "IntegrationStatus": 0,
        "Tax": null,
        "ShippingAddress": null,
        "BillingAddress": {
            "Email": null,
            "Address1": null,
            "Address2": null,
            "Address3": null,
            "City": null,
            "State": null,
            "Zip": null,
            "Country": null,
            "Phone1": null,
            "Phone2": null,
            "Phone3": null
        },
        "Items": null,
        "UserDefinedFields": [
            {
                "Key": "SubTotal",
                "Value": "10.00"
            },
            {
                "Key": "CustomerName",
                "Value": "aaronfit0001"
            }
        ],
        "Notification": {
            "Type": "Email",
            "SMSTemplate": null,
            "EmailTemplate": null,
            "ResponseStatus": null,
            "ResponseMessage": null
        },
        "PostDataType": "PaymentLine",
        "TransactionKey": "21040100681040",
        "PaidOn": null,
        "LastProcessDate": null,
        "Message": "",
        "CustomeMessage": null,
        "Payment": {
            "CreditCardGateway": "AuthCredit",
            "ECheckGateway": "EVOACH",
            "AcceptType": 0
        },
        "NotificationEmail": "rena.wu@nodus.com",
        "NotificationEmailDisplay": "rena.wu@nodus.com",
        "NotificationPhone": "",
        "NotificationPhoneDisplay": "",
        "OriginalTender": null,
        "PayFabricTransactionData": null,
        "Link": "https://sandbox.payfabric.com/PayLink/Web/85ws0syB7kK1LsButGkyIDE",
        "EntryClass": null,
        "CreatedOnUTC": "2021-04-02T02:44:01.333Z",
        "ModifiedOnUTC": "2021-04-02T02:44:01.333Z",
        "PaidOnUTC": null,
        "LastProcessDateUTC": null
    },
    {
        "Id": "evRKTNqEAEGNGdpX6xmGZzE",
        "InstID": "8b5dce02-346e-490e-a07a-8b56294b3a58",
        "Device": "28c54462-f769-2a35-2114-0f5fd3ca1241",
        "SetupId": "paypal",
        "Currency": "USD",
        "Amount": 39.95,
        "DocumentAmount": 20.0,
        "TaxAmount": 3.0,
        "TradeDiscount": 2.0,
        "Freight": 1.0,
        "MiscAmount": 8.0,
        "CustomerNumber": "AARONFIT0001",
        "CustomerName": "AARON Fit 001",
        "IsMultipleInvoice": false,
        "DocumentNumber": "STDINV2267",
        "DocumentNumberDisplay": "STDINV2267",
        "TransactionType": "Sale",
        "CreatedOn": "2021-04-02T05:45:44.1",
        "ModifiedOn": "2021-05-13T10:50:55.973",
        "DocDate": "2020-04-03T17:21:09",
        "DueDate": "2020-04-03T17:21:09",
        "DocType": 3,
        "PaymentTerm": "Retail",
        "SourceOfDocument": 1,
        "BatchSource": 0,
        "BatchNo": "asdf",
        "MerchantEmail": null,
        "ReturnUrl": null,
        "Status": 3,
        "IntegrationStatus": 2,
        "Tax": null,
        "ShippingAddress": {
            "Email": "sample@email.com",
            "Address1": "123 Test Street",
            "Address2": "12 Test Street",
            "Address3": "1 Test Street",
            "City": "Anaheim",
            "State": "CA",
            "Zip": "90201",
            "Country": "USA",
            "Phone1": "1523691233",
            "Phone2": "4525616636",
            "Phone3": "4515845632"
        },
        "BillingAddress": {
            "Email": "success+bchksale1@simulator.amazonses.com;success+bchksale2@simulator.amazonses.com,success+bchksale3@simulator.amazonses.com",
            "Address1": "U.s.A.",
            "Address2": "",
            "Address3": "",
            "City": "Anaheim",
            "State": "CA",
            "Zip": "12345",
            "Country": "United States",
            "Phone1": "",
            "Phone2": "4525616636",
            "Phone3": "4515845632"
        },
        "Items": [
            {
                "ItemCode": "A100",
                "AppliedAmount": 39.95,
                "DueDate": null,
                "Description": "A100 item",
                "UnitPrice": "3",
                "ItemAmount": "39.95",
                "Quantity": "3",
                "PriceLevel": "Retail",
                "UnitOfMeasure": "Each",
                "SiteCode": "WAREHOUSE",
                "MarkDown": 0.0,
                "TaxAmount": 0.0,
                "MiscAmount": 0.0,
                "UserDefinedFields": [
                    {
                        "Key": "ExtPrice",
                        "Value": "1.95"
                    }
                ],
                "Items": null,
                "ShippingAddress": null,
                "BillingAddress": null
            }
        ],
        "UserDefinedFields": [
            {
                "Key": "SubTotal",
                "Value": "11.95"
            },
            {
                "Key": "Surcharge",
                "Value": "0.00"
            },
            {
                "Key": "SurchargePercentage",
                "Value": "0.00"
            },
            {
                "Key": "TrxAmount",
                "Value": "39.95"
            },
            {
                "Key": "OrigTrxAmount",
                "Value": "39.95"
            },
            {
                "Key": "FinalAmount",
                "Value": "39.95"
            }
        ],
        "Notification": {
            "Type": "Email",
            "SMSTemplate": null,
            "EmailTemplate": null,
            "ResponseStatus": "",
            "ResponseMessage": ""
        },
        "PostDataType": "PaymentLine",
        "TransactionKey": "21040100681059",
        "PaidOn": "2021-04-02T05:46:26.906",
        "LastProcessDate": "2021-05-13T10:50:55.893",
        "Message": "",
        "CustomeMessage": "CustomeMessage",
        "Payment": {
            "CreditCardGateway": "AuthCredit",
            "ECheckGateway": "EVOACH",
            "AcceptType": 0
        },
        "NotificationEmail": "qa-receive@payfabric.com",
        "NotificationEmailDisplay": "qa-receive@payfabric.com",
        "NotificationPhone": "15151472869",
        "NotificationPhoneDisplay": "15151472869",
        "OriginalTender": null,
        "PayFabricTransactionData": null,
        "Link": "https://sandbox.payfabric.com/PayLink/Web/evRKTNqEAEGNGdpX6xmGZzE",
        "EntryClass": null,
        "CreatedOnUTC": "2021-04-02T02:45:44.1Z",
        "ModifiedOnUTC": "2021-05-13T07:50:55.973Z",
        "PaidOnUTC": "2021-04-02T02:46:26.906Z",
        "LastProcessDateUTC": "2021-05-13T07:50:55.893Z"
    }
]
</pre>

Retrieve a PayLink URL
----------------------

* `GET /paylink/api/document/retrieve/gwx9q6fqcEuagAJLA27CIA/link` will return the specified PayLink documents' unique URL

###### Response
<pre>
"https://sandbox.payfabric.com/paylink/web/gwx9q6fqcEuagAJLA27CIA"
</pre>

Remove a PayLink
----------------

* `DELETE /paylink/api/document/AdFXqnNNf0GDNwiO5UE_fw` will remove the specified PayLink document permanently

###### Response
A successful `DELETE` will result in a HTTP 200 OK Response.  

A failed `DELETE` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  

A failed `DELETE` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or paid.  


Cancel a PayLink
----------------

* `POST /paylink/api/document/AdFXqnNNf0GDNwiO5UE_fw/cancel` will cancel a PayLink document

###### Response
A successful `POST` will result in a HTTP 200 OK Response. 

A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  

A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or paid.  

Get Post Data
----------------
* `GET /paylink/api/document/{PayLinkId}/PostData` will get the post data xml for the specific document

<b>Note:</b> Only can get post data for Paid document.

###### Response
```xml
<TokenTransactions><TokenTransaction><PaymentLines><PaymentLine><CCNumber>XXXXXXXXXXXX1111</CCNumber><CCType>V1ffff</CCType><CCExpDate>3/1/2022 12:00:00 AM</CCExpDate><PaymentType>3</PaymentType><GenericName></GenericName><TrxAmount>8.16</TrxAmount><AuthCode>P66QP5</AuthCode><TransactionData><Connection name=\"EvoSnapWithSurcharge\" connector=\"EVO\" /><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>P66QP5</Desc><Value>P66QP5</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2108</Desc><Value>2108</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>D6394745207D471E96E57AF85EE87B7F</Desc><Value>D6394745207D471E96E57AF85EE87B7F</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>77315199</Desc><Value>77315199</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>461295</Desc><Value>461295</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>7/8/2021 5:42:53 AM</Desc><Value>7/8/2021 5:42:53 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>D6394745207D471E96E57AF85EE87B7F</Desc><Value>D6394745207D471E96E57AF85EE87B7F</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0322</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>as12</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>as12</Value></Field><Field id=\"TrxField_D8\"><Name>Address1</Name><Desc>Address 1</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 TEST</Value></Field><Field id=\"TrxField_D11\"><Name>City</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D12\"><Name>State</Name><Desc>State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D13\"><Name>Zip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>12345</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>8.16</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>V1ffff</Value></Field><Field id=\"TrxField_D34\"><Name>PONumber</Name><Desc>PO Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>PO0001</Value></Field><Field id=\"TrxField_D40\"><Name>InvoiceNumber</Name><Desc>Invoice Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>STDINV0001</Value></Field><Field id=\"TrxField_D41\"><Name>ShipToZip</Name><Desc>Ship to Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>8098529922</Value></Field><Field id=\"TrxField_D48\"><Name>CustomerCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>AARONFIT0001</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D99\"><Name>ShipToCity</Name><Desc>Shipping City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ANAHEIM</Value></Field><Field id=\"TrxField_D103\"><Name>ShipToState</Name><Desc>Shipping State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D104\"><Name>ShipToStreet</Name><Desc>Shipping Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1099 S State College Blvd </Value></Field><Field id=\"TrxField_D111\"><Name>ShipToCountry</Name><Desc>Shipping Country</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>US</Value></Field><Field id=\"TrxField_D155\"><Name>ShipToPhone</Name><Desc>Shipping Phone</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1888888888</Value></Field><Field id=\"TrxField_D321\"><Name>SurchargeAmount</Name><Desc>The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>3</Type><Value>0.16</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Customer</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Stored</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>10</Value></Field><Field id=\"TrxField_D544\"><Name>CCFirstTransactionId</Name><Desc>The transaction Id that was first used to validate the credit card before use or storage</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>C4DAA4C0803B4601AA67375563DF735E</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>21070700735575</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D117\" index=\"1\"><Name>ItemCommodityCode</Name><Value>A100</Value></Field><Field id=\"TRXFIELD_D67\" index=\"1\"><Name>ItemProdCode</Name><Value>A100</Value></Field><Field id=\"TRXFIELD_D65\" index=\"1\"><Name>ItemUOM</Name><Value>Each</Value></Field><Field id=\"TRXFIELD_D69\" index=\"1\"><Name>ItemAmount</Name><Value>8.0</Value></Field><Field id=\"TRXFIELD_D68\" index=\"1\"><Name>ItemDiscount</Name><Value>0.0</Value></Field><Field id=\"TRXFIELD_D62\" index=\"1\"><Name>ItemQuantity</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D70\" index=\"1\"><Name>ItemTaxAmount</Name><Value>0.0</Value></Field><Field id=\"TRXFIELD_D64\" index=\"1\"><Name>ItemDesc</Name><Value>A unique online payment system</Value></Field><Field id=\"TRXFIELD_D547\"><Name>SubsequentAuthOriginalAmount</Name><Value>40.75</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>as12 as12 </Value></Field><Field id=\"TRXFIELD_D55\"><Name>AccountStreet</Name><Value>123 TEST </Value></Field><Field id=\"TRXFIELD_D47\"><Name>CountryCode</Name><Value>United States</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>21070700735575</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>0b9cbe13-3c29-4a5f-a5dd-33b1f0f802ab</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>488599af-321c-4d0e-b882-6876fb61c57b</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2021-07-07 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:42:54 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field><Field id=\"MSO_Doc_Number\"><Name>MSO_Doc_Number</Name><Value>STDINV0001</Value></Field><Field id=\"MSO_Doc_Type\"><Name>MSO_Doc_Type</Name><Value>3</Value></Field><Field id=\"MSO_Source_Of_Document\"><Name>MSO_Source_Of_Document</Name><Value>1</Value></Field><Field id=\"BACHNUMB\"><Name>BACHNUMB</Name><Value>TEST</Value></Field><Field id=\"MSO_IsBatched\"><Name>MSO_IsBatched</Name><Value>0</Value></Field><Field id=\"CUSTNMBR\"><Name>CUSTNMBR</Name><Value>AARONFIT0001</Value></Field><Field id=\"MSO_FirstName\"><Name>MSO_FirstName</Name><Value>as12</Value></Field><Field id=\"MSO_LastName\"><Name>MSO_LastName</Name><Value>as12</Value></Field><Field id=\"MSO_CardExpDate\"><Name>MSO_CardExpDate</Name><Value>0322</Value></Field><Field id=\"MSO_CardName\"><Name>MSO_CardName</Name><Value>V1ffff</Value></Field><Field id=\"MSO_Default\"><Name>MSO_Default</Name><Value>0</Value></Field><Field id=\"Status\"><Name>Status</Name><Value>1</Value></Field><Field id=\"SEQNUMBR\"><Name>SEQNUMBR</Name><Value>16384</Value></Field><Field id=\"CRCRDAMT\"><Name>CRCRDAMT</Name><Value>8.16</Value></Field><Field id=\"CCode\"><Name>CCode</Name><Value>United States</Value></Field><Field id=\"PHONNAME\"><Name>PHONNAME</Name><Value></Value></Field><Field id=\"MSO_COMMENT3\"><Name>MSO_COMMENT3</Name><Value>8.16</Value></Field><Field id=\"MSO_COMMENT4\"><Name>MSO_COMMENT4</Name><Value>PayLink</Value></Field><Field id=\"MSO_IsCardValid\"><Name>MSO_IsCardValid</Name><Value>1</Value></Field><Field id=\"MSO_TrxStatus\"><Name>MSO_TrxStatus</Name><Value>1</Value></Field><Field id=\"MSO_TrxType\"><Name>MSO_TrxType</Name><Value>1</Value></Field><Field id=\"MSO_Auth_Amount\"><Name>MSO_Auth_Amount</Name><Value>8.16</Value></Field><Field id=\"MSO_Capture_Amount\"><Name>MSO_Capture_Amount</Name><Value>8.16</Value></Field><Field id=\"BCHSOURC\"><Name>BCHSOURC</Name><Value>Sales Entry</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData></PaymentLine></PaymentLines><DocumentID>STDINV0001</DocumentID><BatchID>TEST</BatchID><CustomerID>AARONFIT0001</CustomerID><Date>7/7/2021 11:41:26 PM</Date><SOPTYPE>3</SOPTYPE><AmountsReceived>8.16</AmountsReceived><DocTypeID>3</DocTypeID><TradeDiscount>0.0</TradeDiscount><FreightAmount>0.0</FreightAmount><MiscAmount>0.0</MiscAmount><TransactionType>1</TransactionType><CurrencyID>Z-US$</CurrencyID></TokenTransaction></TokenTransactions>
```

Update Post Data
-----------------
* `POST /paylink/api/document/{PayLinkId}/PostData` will update the post data xml for the specific document

<b>Note:</b> Only can update post data for `Integration Failed` document. The post data xml is auto generated, please don't add/remove any node(s), just update the value, otherwise will cause failure to integrate to ERP.

###### Request
```xml
{"PostData":"<TokenTransactions><TokenTransaction><PaymentLines><PaymentLine><CCNumber>XXXXXXXXXXXX1111</CCNumber><CCType>V1ffff</CCType><CCExpDate>3/1/2022 12:00:00 AM</CCExpDate><PaymentType>3</PaymentType><GenericName></GenericName><TrxAmount>8.16</TrxAmount><AuthCode>P66QP5</AuthCode><TransactionData><Connection name=\"EvoSnapWithSurcharge\" connector=\"EVO\" /><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>P66QP5</Desc><Value>P66QP5</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2108</Desc><Value>2108</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>D6394745207D471E96E57AF85EE87B7F</Desc><Value>D6394745207D471E96E57AF85EE87B7F</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>77315199</Desc><Value>77315199</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>461295</Desc><Value>461295</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>7/8/2021 5:42:53 AM</Desc><Value>7/8/2021 5:42:53 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>D6394745207D471E96E57AF85EE87B7F</Desc><Value>D6394745207D471E96E57AF85EE87B7F</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0322</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>as12</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>as12</Value></Field><Field id=\"TrxField_D8\"><Name>Address1</Name><Desc>Address 1</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 TEST</Value></Field><Field id=\"TrxField_D11\"><Name>City</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D12\"><Name>State</Name><Desc>State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D13\"><Name>Zip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>12345</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>8.16</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>V1ffff</Value></Field><Field id=\"TrxField_D34\"><Name>PONumber</Name><Desc>PO Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>PO0001</Value></Field><Field id=\"TrxField_D40\"><Name>InvoiceNumber</Name><Desc>Invoice Number</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>STDINV0001</Value></Field><Field id=\"TrxField_D41\"><Name>ShipToZip</Name><Desc>Ship to Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>8098529922</Value></Field><Field id=\"TrxField_D48\"><Name>CustomerCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>AARONFIT0001</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D99\"><Name>ShipToCity</Name><Desc>Shipping City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ANAHEIM</Value></Field><Field id=\"TrxField_D103\"><Name>ShipToState</Name><Desc>Shipping State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D104\"><Name>ShipToStreet</Name><Desc>Shipping Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1099 S State College Blvd </Value></Field><Field id=\"TrxField_D111\"><Name>ShipToCountry</Name><Desc>Shipping Country</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>US</Value></Field><Field id=\"TrxField_D155\"><Name>ShipToPhone</Name><Desc>Shipping Phone</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1888888888</Value></Field><Field id=\"TrxField_D321\"><Name>SurchargeAmount</Name><Desc>The surcharge amount is included in the total transaction amount but is passed in a separate field to the issuer and acquirer for tracking</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>3</Type><Value>0.16</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Customer</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Stored</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>10</Value></Field><Field id=\"TrxField_D544\"><Name>CCFirstTransactionId</Name><Desc>The transaction Id that was first used to validate the credit card before use or storage</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>C4DAA4C0803B4601AA67375563DF735E</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>21070700735575</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D117\" index=\"1\"><Name>ItemCommodityCode</Name><Value>A100</Value></Field><Field id=\"TRXFIELD_D67\" index=\"1\"><Name>ItemProdCode</Name><Value>A100</Value></Field><Field id=\"TRXFIELD_D65\" index=\"1\"><Name>ItemUOM</Name><Value>Each</Value></Field><Field id=\"TRXFIELD_D69\" index=\"1\"><Name>ItemAmount</Name><Value>8.0</Value></Field><Field id=\"TRXFIELD_D68\" index=\"1\"><Name>ItemDiscount</Name><Value>0.0</Value></Field><Field id=\"TRXFIELD_D62\" index=\"1\"><Name>ItemQuantity</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D70\" index=\"1\"><Name>ItemTaxAmount</Name><Value>0.0</Value></Field><Field id=\"TRXFIELD_D64\" index=\"1\"><Name>ItemDesc</Name><Value>A unique online payment system</Value></Field><Field id=\"TRXFIELD_D547\"><Name>SubsequentAuthOriginalAmount</Name><Value>40.75</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>as12 as12 </Value></Field><Field id=\"TRXFIELD_D55\"><Name>AccountStreet</Name><Value>123 TEST </Value></Field><Field id=\"TRXFIELD_D47\"><Name>CountryCode</Name><Value>United States</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>21070700735575</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>0b9cbe13-3c29-4a5f-a5dd-33b1f0f802ab</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>488599af-321c-4d0e-b882-6876fb61c57b</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2021-07-07 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:42:54 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field><Field id=\"MSO_Doc_Number\"><Name>MSO_Doc_Number</Name><Value>STDINV0001</Value></Field><Field id=\"MSO_Doc_Type\"><Name>MSO_Doc_Type</Name><Value>3</Value></Field><Field id=\"MSO_Source_Of_Document\"><Name>MSO_Source_Of_Document</Name><Value>1</Value></Field><Field id=\"BACHNUMB\"><Name>BACHNUMB</Name><Value>TEST</Value></Field><Field id=\"MSO_IsBatched\"><Name>MSO_IsBatched</Name><Value>0</Value></Field><Field id=\"CUSTNMBR\"><Name>CUSTNMBR</Name><Value>AARONFIT0001</Value></Field><Field id=\"MSO_FirstName\"><Name>MSO_FirstName</Name><Value>as12</Value></Field><Field id=\"MSO_LastName\"><Name>MSO_LastName</Name><Value>as12</Value></Field><Field id=\"MSO_CardExpDate\"><Name>MSO_CardExpDate</Name><Value>0322</Value></Field><Field id=\"MSO_CardName\"><Name>MSO_CardName</Name><Value>V1ffff</Value></Field><Field id=\"MSO_Default\"><Name>MSO_Default</Name><Value>0</Value></Field><Field id=\"Status\"><Name>Status</Name><Value>1</Value></Field><Field id=\"SEQNUMBR\"><Name>SEQNUMBR</Name><Value>16384</Value></Field><Field id=\"CRCRDAMT\"><Name>CRCRDAMT</Name><Value>8.16</Value></Field><Field id=\"CCode\"><Name>CCode</Name><Value>United States</Value></Field><Field id=\"PHONNAME\"><Name>PHONNAME</Name><Value></Value></Field><Field id=\"MSO_COMMENT3\"><Name>MSO_COMMENT3</Name><Value>8.16</Value></Field><Field id=\"MSO_COMMENT4\"><Name>MSO_COMMENT4</Name><Value>PayLink</Value></Field><Field id=\"MSO_IsCardValid\"><Name>MSO_IsCardValid</Name><Value>1</Value></Field><Field id=\"MSO_TrxStatus\"><Name>MSO_TrxStatus</Name><Value>1</Value></Field><Field id=\"MSO_TrxType\"><Name>MSO_TrxType</Name><Value>1</Value></Field><Field id=\"MSO_Auth_Amount\"><Name>MSO_Auth_Amount</Name><Value>8.16</Value></Field><Field id=\"MSO_Capture_Amount\"><Name>MSO_Capture_Amount</Name><Value>8.16</Value></Field><Field id=\"BCHSOURC\"><Name>BCHSOURC</Name><Value>Sales Entry</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData></PaymentLine></PaymentLines><DocumentID>STDINV0001</DocumentID><BatchID>TEST</BatchID><CustomerID>AARONFIT0001</CustomerID><Date>7/7/2021 11:41:26 PM</Date><SOPTYPE>3</SOPTYPE><AmountsReceived>8.16</AmountsReceived><DocTypeID>3</DocTypeID><TradeDiscount>0.0</TradeDiscount><FreightAmount>0.0</FreightAmount><MiscAmount>0.0</MiscAmount><TransactionType>1</TransactionType><CurrencyID>Z-US$</CurrencyID></TokenTransaction></TokenTransactions>"}
```

###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified document does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Resubmit Post Data
------------------
* `POST /paylink/api/document/{PayLinkId}/PostData/Resubmit` will resubmit the payment to configured ERP

###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified document does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is failed.
