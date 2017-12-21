PayLinks
========

The PayLinks API is used for creating, updating and retrieving PayLinks. Please note that all requests require API authentication by PayFabric *Security Token*, see our [guide](https://github.com/PayFabric/APIs/blob/v2/Sections/Authentication.md#security-token) on how to create a token.

Create a PayLink
----------------

* `POST /api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload

###### Request
<pre>
{
  <b><i>"SetupId": "PFP"</i></b>,
  <b>"Currency": "USD"</b>,
  <b>"Amount": 49.99</b>,
  <b>"DocumentAmount": 49.99</b>,
  "TaxAmount": 0,
  "TradeDiscount": 0,
  "Freight": 0,
  "MiscAmount": 0,
  <b>"CustomerNumber": "JOHNDOE0001"</b>,
  "CustomerName": null,
  <b>"IsMultipleInvoice": false</b>,
  "DocumentNumber": null,
  "TransactionType": "Sale",
  <b>"DocDate": "2015-10-28T00:00:00"</b>,
  "DueDate": "2015-10-31T00:00:00",
  "DocType": 0,
  "PaymentTerm": null,
  "SourceOfDocument": 0,
  "BatchSource": 0,
  "BatchNo": null,
  "MerchantEmail": null,
  "ReturnUrl": null,
  "Tax": null,
  "ShippingAddress": null,
  "BillingAddress": null,
  "Items": null,
  "UserDefinedFields": null,
  "PostDataType": "PaymentLine",
  "Status": 0,
  <b><i>"Payment": {
    "CreditCardGateway": "PFP",
    "ECheckGateway": "",
    "AcceptType": 1
  }</i></b>,
  <b>"Notification":</b> {
    <b>"Type": "All"</b>,
    "EmailTemplate": null,
    "SMSTemplate": null
  },
  <b>"NotificationEmail": "John.Doe@payfabric.com"</b>,
  <b>"NotificationPhone": "123456789"</b>
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields, click [here](JSON%20Objects.md#paylink-document).

###### Related Reading
* [Which Transaction Type to Use](https://github.com/PayLink/Portal/blob/v2/Sections/Transaction%20Types.md)
* [How to Specify Email or SMS Template](Email%20and%20SMS%20Templates.md)

###### Response
<pre>
{
  "Id": "h3GSpCZKsEWNxFv6T_y_Gw",
  "TransactionKey": "151028003864"
}
</pre>

The response will include the full document object, see the [Retrieve a PayLink](#retrieve-a-paylink) endpoint for more information.

Create a Multiple Invoice PayLink
---------------------------------

* `POST /api/document` will create and save a PayLink document to the PayLink server based on the request JSON payload, the trick to creating a PayLink as a multiple invoice, is using the **IsMultipleInvoice** and **Items** fields

###### Request
<pre>
{
  <b><i>"SetupId": "PFP"</i></b>,
  <b>"Currency": "USD"</b>,
  <b>"Amount": 49.99</b>,
  <b>"DocumentAmount": 49.99</b>,
  "TaxAmount": 0,
  "TradeDiscount": 0,
  "Freight": 0,
  "MiscAmount": 0,
  <b>"CustomerNumber": "JOHNDOE0001"</b>,
  "CustomerName": null,
  <b>"IsMultipleInvoice": true</b>,
  "DocumentNumber": null,
  "TransactionType": "Sale",
  <b>"DocDate": "2015-10-28T00:00:00"</b>,
  "DueDate": "2015-10-31T00:00:00",
  "DocType": 0,
  "PaymentTerm": null,
  "SourceOfDocument": 0,
  "BatchSource": 0,
  "BatchNo": null,
  "MerchantEmail": null,
  "ReturnUrl": null,
  "Tax": null,
  "ShippingAddress": null,
  "BillingAddress": null,
  <b>"Items": [
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
  ]</b>,
  <b><i>"UserDefinedFields": [
    {
      "Key": "Surcharge",
      "Value": "9.99"
    }
  ]</i></b>,
  "PostDataType": "PaymentLine",
  "Status": 0,
  <b><i>"Payment": {
    "CreditCardGateway": "PFP",
    "ECheckGateway": "",
    "AcceptType": 1
  }</i></b>,
  <b>"Notification":</b> {
    <b>"Type": "All"</b>,
    "EmailTemplate": null,
    "SMSTemplate": null
  },
  <b>"NotificationEmail": "John.Doe@payfabric.com"</b>,
  <b>"NotificationPhone": "123456789"</b>
}
</pre>

Please note that **bold** fields are required fields, the **Payment** object *or* **SetupId** field must be supplied, and all others are optional.  If you wish to apply a surcharge fee for multiple invoice payment, please use the **UserDefinedFields** field as shown in the example above. The **Status** field can be used to set the PayLink document status; specify 0 to save the document as a draft, specify 1 to save the document as an active document ready for payment. For more information and descriptions on available fields, click [here](JSON%20Objects.md#paylink-document).

###### Related Reading
* [Which Transaction Type to Use](https://github.com/PayLink/Portal/blob/v2/Sections/Transaction%20Types.md)
* [How to Specify Email or SMS Template](Email%20and%20SMS%20Templates.md)


###### Response
<pre>
{
  "Id": "h3GSpCZKsEWNxFv6T_y_Gw",
  "TransactionKey": "151028003864"
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
  "Id": "AdFXqnNNf0GDNwiO5UE_fw",
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
    "EmailTemplate": null,
    "SMSTemplate": null,
    "ResponseStatus": null,
    "ResponseMessage": null
  },
  "NotificationEmail": "John.Doe@PayFabric.com",
  "NotificationPhone": "",
  "OriginalTender": null,
  "PayFabricTransactionData": {
    "Key": "151104003878",
    "ReferenceKey": null,
    "Customer": "JOHNDOE0001",
    "BatchNumber": "",
    "SetupId": "PFP",
    "MSO_EngineGUID": "00c2d66b-9b4e-4d63-b115-e6c5fc4e7430",
    "Tender": "CreditCard",
    "Type": "Sale",
    "Currency": "USD",
    "Amount": "49.99",
    "ReqAuthCode": "",
    "PayDate": "",
    "TrxUserDefine1": "",
    "TrxUserDefine2": "",
    "TrxUserDefine3": "",
    "TrxUserDefine4": "",
    "Card": {
      "ID": "00000000-0000-0000-0000-000000000000",
      "Customer": "JOHNDOE0001",
      "Tender": "CreditCard",
      "Account": "",
      "CardName": null,
      "ExpDate": "",
      "CheckNumber": "",
      "AccountType": "",
      "Aba": "",
      "Connector": "PayflowPro",
      "GatewayToken": "",
      "CVC": null,
      "Identifier": "",
      "IssueNumber": "",
      "StartDate": "",
      "GPAddressCode": "",
      "UserDefine1": "",
      "UserDefine2": "",
      "UserDefine3": "",
      "UserDefine4": "",
      "CardHolder": {
        "FirstName": "",
        "MiddleName": "",
        "LastName": "",
        "DriverLicense": "",
        "SSN": ""
      },
      "Billto": {
        "Customer": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Line1": "",
        "Line2": "",
        "Line3": "",
        "State": "",
        "City": "",
        "Country": "",
        "Zip": "",
        "Email": "",
        "Phone": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM"
      },
      "IsSaveCard": false,
      "IsDefaultCard": false,
      "IsLocked": false,
      "ModifiedOn": "1/1/0001 12:00:00 AM"
    },
    "Shipto": {
      "Customer": "",
      "ID": "00000000-0000-0000-0000-000000000000",
      "Line1": "",
      "Line2": "",
      "Line3": "",
      "State": "",
      "City": "",
      "Country": "",
      "Zip": "",
      "Email": "",
      "Phone": "",
      "ModifiedOn": "1/1/0001 12:00:00 AM"
    },
    "TrxResponse": {
      "TrxKey": "151104003878",
      "Status": "UnProcess",
      "OriginationID": "",
      "RespTrxTag": "",
      "AuthCode": "",
      "ResultCode": "",
      "Message": "",
      "CVV2Response": "",
      "AVSAddressResponse": "",
      "AVSZipResponse": "",
      "IAVSAddressResponse": "",
      "TrxDate": null,
      "TAXml": ""
    },
    "Document": {
      "Head": [
        {
          "Name": "InvoiceNumber",
          "Value": "STDINV0001"
        }
      ],
      "Lines": [],
      "UserDefined": [
        {
          "Name": "ERPDocumentNumber",
          "Value": ""
        },
        {
          "Name": "IsForScribe",
          "Value": "0"
        },
        {
          "Name": "PayLinkTradeDiscount",
          "Value": "0"
        },
        {
          "Name": "PayLinkFreightAmount",
          "Value": "0"
        },
        {
          "Name": "PayLinkMiscAmount",
          "Value": "0"
        },
        {
          "Name": "PayLinkIsMultipleInvoice",
          "Value": "0"
        },
        {
          "Name": "PayLinkBatchNumber",
          "Value": ""
        },
        {
          "Name": "PayLinkPostDataType",
          "Value": "PaymentLine"
        },
        {
          "Name": "PayLinkDocumentType",
          "Value": "0"
        },
        {
          "Name": "AppID",
          "Value": "PayLink"
        },
        {
          "Name": "PayLinkID",
          "Value": "AdFXqnNNf0GDNwiO5UE_fw"
        }
      ]
    },
    "ModifiedOn": "5/16/2016 11:07:49 PM",
    "ReferenceTrxs": []
  }
}
</pre>

Retrieve PayLinks
-----------------

* `GET /api/document` will return all PayLink documents created
* `GET /api/document?$filter` will return all PayLink documents based on an OData ([What is OData?](http://www.odata.org/documentation/odata-version-3-0/url-conventions/)) query
 
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
| Email | The notification email assigned to the PayLink. |
| Status | The status of the PayLink, available values are `0 = draft, 1 = waiting for payment, 2 = cancelled, 3 = paid, 4 = ERP posting failed, 5 = ERP posting done` |
| TransactionKey | The PayFabric transaction key. |

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
    "CustomerNumber": "John Doe Ltd",
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
      "EmailTemplate": null,
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
      "EmailTemplate": null,
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
"https://sandbox.payfabric.com/v2/paylink/gwx9q6fqcEuagAJLA27CIA"
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
