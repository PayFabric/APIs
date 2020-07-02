PayLinks
========

The PayLinks API is used for creating, updating and retrieving PayLinks. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

Create a PayLink
----------------

* `POST /api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload

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
        "Email": "qa-receive@payfabric.com", 
        "City": "CA", 
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
        "Email": "qa-receive@payfabric.com", 
        "City": "CA", 
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
    <b>"NotificationEmail": "qa-receive@payfabric.com",</b> 
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
        "ECheckGateway": "USASOAPECheck“, 
        "AcceptType": 0
    },    
    "CustomeMessage": "CustomeMessage"
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

Below is the payment page for the single invoice paylink created with above body
![PL_SI_PMTPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_PMTPage.png)

Below is the Invoice Details page, can be opened by clicking the Invoice Number on paylink payment page
![PL_SI_InvDetailsPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_InvDetailsPage.png)

Below is the PayLink Confirmation page
![PL_SI_CFMPage](https://github.com/PayFabric/Portal/blob/master/PayLink/Sections/Screenshot/PL_SI_CFMPage.png)


###### Related Reading
* [Which Transaction Type to Use](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Transaction%20Types.md)

###### Response
<pre>
{
    "Id": "xFNH3msjakqS2PNbRFCQ9TE",
    "InstID": "cd76620f-28a2-43d1-b3be-6cb1e70301f5",
    "Device": "a284c1d0-a6fc-4938-98b4-0000b8cf4210",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 49.99,
    "DocumentAmount": 49.99,
    "TaxAmount": 0,
    "TradeDiscount": 0,
    "Freight": 0,
    "MiscAmount": 0,
    "CustomerNumber": "JOHNDOE0001",
    "CustomerName": null,
    "IsMultipleInvoice": false,
    "DocumentNumber": null,
    "TransactionType": "Sale",
    "CreatedOn": "2018-07-19T19:00:52.2094728-07:00",
    "DocDate": "2015-10-28T00:00:00",
    "DueDate": "2015-10-31T00:00:00",
    "DocType": 3,
    "PaymentTerm": null,
    "SourceOfDocument": 0,
    "BatchSource": 0,
    "BatchNo": "B2018",
    "MerchantEmail": null,
    "ReturnUrl": null,
    "Status": 0,
    "IntegrationStatus": 0,
    "Tax": {
        "Name": "All Details",
        "percent": 0.5,
        "amount": 0.2
    },
    "ShippingAddress": null,
    "BillingAddress": null,
    "Items": null,
    "UserDefinedFields": null,
    "Notification": {
        "Type": "All",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": "",
        "ResponseMessage": ""
    },
    "PostDataType": "CashReceipt",
    "TransactionKey": "180719177546",
    "PaidOn": null,
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": null,
    "Payment": {
        "CreditCardGateway": "EVO", 
        "ECheckGateway": "USASOAPECheck“, 
        "AcceptType": 0
    },  
    "NotificationEmail": "John.Doe@payfabric.com",
    "NotificationPhone": "123456789",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://sandbox.payfabric.com/PayLink/Web/xFNH3msjakqS2PNbRFCQ9TE"
}
</pre>

The response will include the full document object, see the [Retrieve a PayLink](#retrieve-a-paylink) endpoint for more information.

Create a Multiple Invoice PayLink
---------------------------------

* `POST /api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload, the trick to creating a PayLink as a multiple invoice, is using the **IsMultipleInvoice** and **Items** fields

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
        "Email": "qa-receive@payfabric.com", 
        "City": "CA", 
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
        "Email": "qa-receive@payfabric.com", 
        "City": "CA", 
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
        "ECheckGateway": "USASOAPECheck“, 
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

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional.  If you wish to apply a surcharge fee for multiple invoice payment, please use the **UserDefinedFields** field as shown in the example above. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

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
    "Id": "r6OwE3phSEOZR3Kg52ygpTE",
    "InstID": "11a2c6f2-33f6-48b3-a5ab-697db2519ec7",
    "Device": "23c6b04e-cd06-4185-801a-8614508f065f",
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
    "DocumentNumber": "MINV0000010077",
    "TransactionType": "Sale",
    "CreatedOn": "2020-06-15T00:19:34.7744464-07:00",
    "ModifiedOn": "0001-01-01T00:00:00",
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
        "Email": "qa-receive@payfabric.com",
        "Address1": "123 Test Street",
        "Address2": "12 Test Street",
        "Address3": "1 Test Street",
        "City": "CA",
        "State": "CA",
        "Zip": "90201",
        "Country": "USA",
        "Phone1": "1523691233",
        "Phone2": "4525616636",
        "Phone3": "4515845632"
    },
    "BillingAddress": {
        "Email": "qa-receive@payfabric.com",
        "Address1": "line 12",
        "Address2": "liner r3",
        "Address3": "~!@!$@#%# gfywefyeasg",
        "City": "CA",
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
        "ResponseMessage": "2"
    },
    "PostDataType": "CashReceipt",
    "TransactionKey": "20061500015812",
    "PaidOn": null,
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": "CustomeMessage",
    "Payment": {
        "CreditCardGateway": "EVO", 
        "ECheckGateway": "USASOAPECheck“, 
        "AcceptType": 0
    },  
    "NotificationEmail": "rena.wu@nodus.com",
    "NotificationPhone": "18915400883",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://dev-us2.payfabric.com/PayLink/Web/r6OwE3phSEOZR3Kg52ygpTE"
}
</pre>

The response will include the full document object, see the [Retrieve a PayLink](#retrieve-a-paylink) endpoint for more information.


Update a PayLink
----------------

* `PATCH /api/document/gwx9q6fqcEuagAJLA27CIA` will update the specified PayLink document with new information based on the request JSON payload

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

* `GET /api/document/AdFXqnNNf0GDNwiO5UE_fw` will return the specified PayLink document

###### Response
<pre>
{
  "Id": "gwx9q6fqcEuagAJLA27CIA",
  "Device": "33665f05-8346-4809-e0f1-01050545236f",
  "SetupId": null,
  "Currency": "USD",
  "Amount": 49.99,
  "DocumentAmount": 49.99,
  "TaxAmount": 0,
  "TradeDiscount": 0,
  "Freight": 0,
  "MiscAmount": 0,
  "CustomerNumber": "JOHNDOE0001",
  "CustomerName": null,
  "IsMultipleInvoice": false,
  "DocumentNumber": "STDINV0001",
  "TransactionType": "Sale",
  "DocDate": "2015-11-04T09:20:58.337",
  "DueDate": "1900-01-01T00:00:00",
  "DocType": 0,
  "PaymentTerm": "Net 30",
  "SourceOfDocument": 0,
  "BatchSource": 0,
  "BatchNo": null,
  "MerchantEmail": null,
  "ReturnUrl": null,
  "Status": 1,
  "Tax": {
    "Name": "All Details",
    "percent": 0.5,
    "amount": 0.2
  },
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
      "Value": "49.99"
    },
    {
      "Key": "InvoiceNumber",
      "Value": "STDINV0001"
    },
    {
      "Key": "CustomerName",
      "Value": "JOHNDOE0001"
    }
  ],
  "PostDataType": "PaymentLine",
  "TransactionKey": "151104003878",
  "PaidOn": "1900-01-01T00:00:00",
  "LastProcessDate": "1900-01-01T00:00:00",
  "Message": "",
  "CustomeMessage": null,
  "Payment": {
    "CreditCardGateway": "PFP",
    "ECheckGateway": "",
    "AcceptType": 1
  },
  "Notification": {
    "Type": "Email",
    "SMSTemplate": null,
    "ResponseStatus": null,
    "ResponseMessage": null
  },
  "NotificationEmail": "John.Doe@PayFabric.com",
  "NotificationPhone": "",
  "OriginalTender": null
}
</pre>

Retrieve PayLinks
-----------------

* `GET /api/document` will return all PayLink documents created
* `GET /api/document?$filter` will return all PayLink documents based on an OData ([What is OData?](http://www.odata.org/documentation/odata-version-3-0/url-conventions/)) query

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
    "Id": "gwx9q6fqcEuagAJLA27CIA",
    "Device": "33665f05-8346-4809-e0f1-01050545236f",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 49.99,
    "DocumentAmount": 49.99,
    "TaxAmount": 0,
    "TradeDiscount": 0,
    "Freight": 0,
    "MiscAmount": 0,
    "CustomerNumber": "JOHNDOE0001",
    "CustomerName": null,
    "IsMultipleInvoice": false,
    "DocumentNumber": "STDINV0001",
    "TransactionType": "Sale",
    "DocDate": "2015-11-04T09:20:58.337",
    "DueDate": "1900-01-01T00:00:00",
    "DocType": 0,
    "PaymentTerm": "Net 30",
    "SourceOfDocument": 0,
    "BatchSource": 0,
    "BatchNo": null,
    "MerchantEmail": null,
    "ReturnUrl": null,
    "Status": 1,
    "Tax": {
      "Name": "All Details",
      "percent": 0.5,
      "amount": 0.2
  },
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
        "Value": "49.99"
      },
      {
        "Key": "InvoiceNumber",
        "Value": "STDINV0001"
      },
      {
        "Key": "CustomerName",
        "Value": "JOHNDOE0001"
      }
    ],
    "PostDataType": "PaymentLine",
    "TransactionKey": "151104003878",
    "PaidOn": "1900-01-01T00:00:00",
    "LastProcessDate": "1900-01-01T00:00:00",
    "Message": "",
    "CustomeMessage": null,
    "Payment": {
      "CreditCardGateway": "PFP",
      "ECheckGateway": "",
      "AcceptType": 1
    },
    "Notification": {
      "Type": "Email",
      "SMSTemplate": null,
      "ResponseStatus": null,
      "ResponseMessage": null
    },
    "NotificationEmail": "John.Doe@PayFabric.com",
    "NotificationPhone": "",
    "OriginalTender": null
  },
  {
    "Id": "gwx9q6fqcEuagAJLA27CIB",
    "Device": "33665f05-8346-4809-e0f1-01050545236f",
    "SetupId": null,
    "Currency": "USD",
    "Amount": 49.99,
    "DocumentAmount": 49.99,
    "TaxAmount": 0,
    "TradeDiscount": 0,
    "Freight": 0,
    "MiscAmount": 0,
    "CustomerNumber": "JOHNDOE0001",
    "CustomerName": null,
    "IsMultipleInvoice": false,
    "DocumentNumber": "STDINV0002",
    "TransactionType": "Sale",
    "DocDate": "2015-11-04T09:20:58.337",
    "DueDate": "1900-01-01T00:00:00",
    "DocType": 0,
    "PaymentTerm": "Net 30",
    "SourceOfDocument": 0,
    "BatchSource": 0,
    "BatchNo": null,
    "MerchantEmail": null,
    "ReturnUrl": null,
    "Status": 1,
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
        "Value": "49.99"
      },
      {
        "Key": "InvoiceNumber",
        "Value": "STDINV0002"
      },
      {
        "Key": "CustomerName",
        "Value": "JOHNDOE0001"
      }
    ],
    "PostDataType": "PaymentLine",
    "TransactionKey": "151104003879",
    "PaidOn": "1900-01-01T00:00:00",
    "LastProcessDate": "1900-01-01T00:00:00",
    "Message": "",
    "CustomeMessage": null,
    "Payment": {
      "CreditCardGateway": "PFP",
      "ECheckGateway": "",
      "AcceptType": 1
    },
    "Notification": {
      "Type": "Email",
      "SMSTemplate": null,
      "ResponseStatus": null,
      "ResponseMessage": null
    },
    "NotificationEmail": "John.Doe@PayFabric.com",
    "NotificationPhone": "",
    "OriginalTender": null
  }
]
</pre>

Retrieve a PayLink URL
----------------------

* `GET /api/document/retrieve/gwx9q6fqcEuagAJLA27CIA/link` will return the specified PayLink documents' unique URL

###### Response
<pre>
"https://sandbox.payfabric.com/paylink/web/gwx9q6fqcEuagAJLA27CIA"
</pre>

Remove a PayLink
----------------

* `DELETE /api/document/AdFXqnNNf0GDNwiO5UE_fw` will remove the specified PayLink document permanently

###### Response
A successful `DELETE` will result in a HTTP 200 OK Response.  
A failed `DELETE` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `DELETE` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or paid.  


Cancel a PayLink
----------------

* `POST /api/document/AdFXqnNNf0GDNwiO5UE_fw/cancel` will cancel a PayLink document

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document has already been cancelled or paid.  
