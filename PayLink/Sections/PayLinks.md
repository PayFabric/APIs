PayLinks
========

The PayLinks API is used for creating, updating and retrieving PayLinks. Please note that all requests require API authentication by PayFabric *Device ID* and *Device Password*, see our [guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) for more details.

Create a PayLink
----------------

* `POST /api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload

###### Request
<pre>
{
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
  "DocDate": "2015-10-28T00:00:00",
  "DueDate": "2015-10-31T00:00:00",
  "DocType": 3,
  "PaymentTerm": null,
  "SourceOfDocument": 0,
  "BatchSource": 0,
  "BatchNo": "B2018",
  "MerchantEmail": null,
  "ReturnUrl": null,
  "Tax": {
    "Name": "All Details",
     "percent": 0.5,
     "amount": 0.2
    },
  "ShippingAddress": null,
  "BillingAddress": null,
  "Items": null,
  "UserDefinedFields": null,
  "PostDataType": "CashReceipt",
  "Status": 0,
  "Payment": {
    "CreditCardGateway": "PFP",
    "ECheckGateway": "",
    "AcceptType": 1
  },
  "Notification": {
    "Type": "All"
  },
  "NotificationEmail": "John.Doe@payfabric.com",
  "NotificationPhone": "123456789"
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

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
        "CreditCardGateway": "PFP",
        "ECheckGateway": "",
        "AcceptType": 1
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
  "Currency": "USD",
  "Amount": 49.99,
  "DocumentAmount": 49.99,
  "TaxAmount": 0,
  "TradeDiscount": 0,
  "Freight": 0,
  "MiscAmount": 0,
  "CustomerNumber": "JOHNDOE0001",
  "CustomerName": null,
  "IsMultipleInvoice": true,
  "DocumentNumber": "test01",
  "TransactionType": "Sale",
  "DocDate": "2015-10-28T00:00:00",
  "DueDate": "2015-10-31T00:00:00",
  "DocType": 3,
  "PaymentTerm": null,
  "SourceOfDocument": 0,
  "BatchSource": 0,
  "BatchNo": "B2018",
  "MerchantEmail": null,
  "ReturnUrl": null,
  "Tax": {
      "Name": "All Details",
      "percent": 0.5,
      "amount": 0.2
    },
  "ShippingAddress": null,
  "BillingAddress": null,
  "Items": [
    {
      "ItemCode": "INV0001",
      "AppliedAmount": 20.00,
      "DueDate": "2015-10-31"
    },
    {
      "ItemCode": "INV0002",
      "AppliedAmount": 20.00,
      "DueDate": "2015-10-31"
    }
  ],
  "UserDefinedFields": [
    {
      "Key": "Surcharge",
      "Value": "9.99"
    }
  ],
  "PostDataType": "CashReceipt",
  "Status": 0,
  "Payment": {
    "CreditCardGateway": "PFP",
    "ECheckGateway": "",
    "AcceptType": 1
  },
  "Notification": {
    "Type": "All"
  },
  "NotificationEmail": "John.Doe@payfabric.com",
  "NotificationPhone": "123456789"
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional.  If you wish to apply a surcharge fee for multiple invoice payment, please use the **UserDefinedFields** field as shown in the example above. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields please see our [JSON Objects](JSON%20Objects.md#paylink-document).

###### Related Reading
* [Which Transaction Type to Use](../../../../portal/tree/master/Sections/Transaction%20Types.md)

###### Response
<pre>
{
    "Id": "hF5LOdXrC0amj0KliEUwxDE",
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
    "IsMultipleInvoice": true,
    "DocumentNumber": "MINV0000000622",
    "TransactionType": "Sale",
    "CreatedOn": "2018-07-19T19:02:40.3761203-07:00",
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
    "Items": [
        {
            "ItemCode": "INV0001",
            "AppliedAmount": 20,
            "DueDate": "2015-10-31T00:00:00",
            "Description": null,
            "UnitPrice": 0,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0,
            "TaxAmount": 0,
            "MiscAmount": 0,
            "UserDefinedFields": null,
            "Items": null
        },
        {
            "ItemCode": "INV0002",
            "AppliedAmount": 20,
            "DueDate": "2015-10-31T00:00:00",
            "Description": null,
            "UnitPrice": 0,
            "Quantity": null,
            "PriceLevel": null,
            "UnitOfMeasure": null,
            "SiteCode": null,
            "MarkDown": 0,
            "TaxAmount": 0,
            "MiscAmount": 0,
            "UserDefinedFields": null,
            "Items": null
        }
    ],
    "UserDefinedFields": [
        {
            "Key": "Surcharge",
            "Value": "9.99"
        }
    ],
    "Notification": {
        "Type": "All",
        "SMSTemplate": null,
        "EmailTemplate": null,
        "ResponseStatus": "",
        "ResponseMessage": ""
    },
    "PostDataType": "CashReceipt",
    "TransactionKey": "180719177570",
    "PaidOn": null,
    "LastProcessDate": null,
    "Message": "",
    "CustomeMessage": null,
    "Payment": {
        "CreditCardGateway": "PFP",
        "ECheckGateway": "",
        "AcceptType": 1
    },
    "NotificationEmail": "John.Doe@payfabric.com",
    "NotificationPhone": "123456789",
    "OriginalTender": null,
    "PayFabricTransactionData": null,
    "Link": "https://sandbox.payfabric.com/PayLink/Web/hF5LOdXrC0amj0KliEUwxDE"
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

e.g. `https://dev-cn.payfabric.com/paylink/api/document?$filter=CustomerNumber eq 'AARONFIT0001' and Device eq GUID'a284c1d0-a6fc-4938-98b4-0000b8cf4210' and DocumentNumber eq 'ORDER001' and DocDate lt datetime'2018-09-25' and DueDate eq null and PaidOn gt datetime'2017-02-02' and Amount gt 8 and NotificationEmail eq 'test@nodus.com' and Status eq '3' and IntegrationStatus eq '2' and TransactionKey eq '180227157886' & $orderby CreatedOn desc`

###### Available OData Fields
>
| Field | Description | 
| :------------- | ------------- | 
| CustomerNumber | The customer number specified during PayLink creation. |
| DocumentNumber | The document number specified during PayLink creation. |
| DocDate | The document date specified during PayLink creation. |
| DueDate | The payment due date specified during PayLink creation. |
| CreatedOn | The date the PayLink was created. |
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
