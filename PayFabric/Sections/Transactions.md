Transactions
============

The PayFabric Transactions API is used for creating, and processing payment transactions. 'Customer' field is required to save wallet entry for later or future use. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Transaction
--------------------

* `POST /payment/api/transaction/create` will create and save a transaction to the PayFabric server based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001",
  "Document": {
    "Head": [],
    "Lines": [],
    "UserDefined": []
  },
  "PayDate": "",
  "ReferenceKey": null,
  "ReferenceTrxs": [],
  "ReqAuthCode": "",
  <b>"SetupId": "PFP"</b>,
  "Shipto": {
    "City": "",
    "Country": "",
    "Customer": "",
    "Email": "",
    "Line1": "",
    "Line2": "",
    "Line3": "",
    "Phone": "",
    "State": "",
    "Zip": ""
  },
  "TrxUserDefine1": "",
  "TrxUserDefine2": "",
  "TrxUserDefine3": "",
  "TrxUserDefine4": "",
  <b>"Type": "Sale"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md#transaction).

`SetupId` is a per-account setting which can be found in [here](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile). The value from the "Name/Setup ID" field of gateway profile, should replace "PFP" in the transaction request example.

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transaction%20Types.md)
* [Create an eCheck Transaction](Process%20eCheck%20Transaction.md#create-a-echeck-transaction)


###### Response
<pre>
{
  "Key": "151013003794"
}
</pre>

###### Response Header
If create transaction with the gateway whose SurchargeRate greater than 0, and populated a credit card on this transaction, then PayFabric will return the surcharge fields in Response Header like below screenshot.

![CreateUpdateTrxWithSurchargeResponseHeader](https://raw.githubusercontent.com/PayFabric/Portal/master/PayFabric/Sections/Screenshots/CreateUpdateTrxWithSurchargeResponseHeader.png "CreateUpdateTrxWithSurchargeResponseHeader") 

Update a Transaction
--------------------

* `POST /payment/api/transaction/update` will update a transaction with new information based on the request JSON payload

###### Request
<pre>
{
    "Key": "151013003793",
    "Card":{
  "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"
  }
}
</pre>

Please note that the **Key** field is the only required field for an update. Only the fields that need updating should be included, see the **Create a Transaction** endpoint for more information.

###### Response
<pre>
{
  "Result": "True"
}
</pre>

###### Response Header
If update transaction with the gateway whose SurchargeRate greater than 0, and populated a credit card on this transaction, then PayFabric will return the surcharge fields in Response Header like below screenshot.

![CreateUpdateTrxWithSurchargeResponseHeader](https://raw.githubusercontent.com/PayFabric/Portal/master/PayFabric/Sections/Screenshots/CreateUpdateTrxWithSurchargeResponseHeader.png "CreateUpdateTrxWithSurchargeResponseHeader") 

###### Related Reading
* [Update an eCheck Transaction](Process%20eCheck%20Transaction.md#update-a-echeck-transaction)

Process a Transaction
---------------------

* `GET /payment/api/transaction/process/{TransactionKey}?cvc={CVCValue}` will attempt to process the transaction with the payment gateway. `cvc` is optional.

###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "21.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "21.00",
    "OriginationID": "A41E0E04DA61",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "21.00",
    "TrxDate": "7/1/2021 10:48:05 PM",
    "TrxKey": "21070100732372",
    "WalletID": "a37150f5-c863-4ff4-aa19-033406cfa8b0"
}
</pre>

###### Related Reading
* [Process an eCheck Transaction](Process%20eCheck%20Transaction.md#process-a-echeck-transaction)

Create and Process a Transaction
--------------------------------

* `POST /payment/api/transaction/process?cvc={CVCValue}` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload. `cvc` is optional.

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Card":</b> {
  <b>"ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"</b>
  },
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001",
  "Document": {
    "Head": [],
    "Lines": [],
    "UserDefined": []
  },
  "PayDate": "",
  "ReferenceKey": null,
  "ReferenceTrxs": [],
  "ReqAuthCode": "",
  <b>"SetupId": "PFP"</b>,
  "Shipto": {
    "City": "",
    "Country": "",
    "Customer": "",
    "Email": "",
    "Line1": "",
    "Line2": "",
    "Line3": "",
    "Phone": "",
    "State": "",
    "Zip": ""
  },
  "TrxUserDefine1": "",
  "TrxUserDefine2": "",
  "TrxUserDefine3": "",
  "TrxUserDefine4": "",
  <b>"Type": "Sale"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md). 

PayFabric support to create wallet either from [API](Wallets.md) or [Hosted Wallet Page](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md), we highly recommand use hosted wallet page to create wallet for security, and get the wallet ID through [Wallet Retrieve](Wallets.md#retrieve-credit-cards--echecks) API call.

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transaction%20Types.md)
* [Create and Process an eCheck Transaction](Process%20eCheck%20Transaction.md#create-and-process-a-echeck-transaction)


###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "21.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "21.00",
    "OriginationID": "A41E0E04DA61",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "21.00",
    "TrxDate": "7/1/2021 10:48:05 PM",
    "TrxKey": "21070100732372",
    "WalletID": "a37150f5-c863-4ff4-aa19-033406cfa8b0"
}
</pre>


Retrieve a Transaction
----------------------

* `GET /payment/api/transaction/{TransactionKey}` will return the specified transaction

###### Response
<pre>
{
    "Amount": "20.00",
    "AuthorizationType": "NotSet",
    "BatchNumber": "",
    "CCEntryIndicator": "Stored",
    "Card": {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "Billto": {
            "City": "anaheim",
            "Country": "USA",
            "Customer": "",
            "Email": "",
            "ID": "c4b32008-871d-4b2c-9c92-e261ced46456",
            "Line1": "2099 State College",
            "Line2": "",
            "Line3": "",
            "ModifiedOn": "1/1/0001 12:00:00 AM",
            "ModifiedOnUTC": null,
            "Phone": "",
            "State": "",
            "Zip": "92906"
        },
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "11",
            "LastName": "1",
            "MiddleName": "1",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "Credit",
        "CheckNumber": "",
        "Connector": "EVO",
        "Customer": "AARONFIT0001",
        "EncryptedToken": null,
        "ExpDate": "1222",
        "GPAddressCode": "",
        "GatewayToken": "",
        "ID": "b90eaf6a-70d6-4ebb-9aa4-a839033223f1",
        "Identifier": "",
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": "",
        "LastUsedDate": "1/1/0001 12:00:00 AM",
        "LastUsedDateUTC": null,
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "ModifiedOnUTC": null,
        "NewCustomerNumber": null,
        "StartDate": "",
        "Tender": "CreditCard",
        "UserDefine1": "",
        "UserDefine2": "",
        "UserDefine3": "",
        "UserDefine4": ""
    },
    "CardHolderAttendance": "NotSet",
    "CardType": "Credit",
    "Currency": "USD",
    "Customer": "AARONFIT0001",
    "Document": {
        "DefaultBillTo": null,
        "Head": [
            {
                "Name": "InvoiceNumber",
                "Value": null
            }
        ],
        "Lines": [
            {
                "Columns": [],
                "UserDefined": []
            }
        ],
        "UserDefined": []
    },
    "ECheckSetupId": "",
    "EntryClass": "",
    "EntryMode": "LegacyVT",
    "Key": "21122900961579",
    "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
    "ModifiedOn": "12/29/2021 1:46:52 AM",
    "ModifiedOnUTC": "12/29/2021 9:46:52 AM",
    "OrigTrxAmount": "20.00",
    "PayDate": "",
    "PayDateUTC": "",
    "ReferenceKey": null,
    "ReferenceTrxs": [
        {
            "Key": "21122900961581",
            "OriginationID": "D961D17F1F194F46BC0187AEE90FDA70",
            "Status": "Approved",
            "TrxDate": "12/29/2021 1:46:52 AM",
            "Type": "Ship"
        }
    ],
    "ReqAuthCode": "",
    "SetupId": "EVO",
    "Shipto": {
        "City": "FARMINGTON HILLS",
        "Country": "United States",
        "Customer": "",
        "Email": "",
        "ID": "759bfacb-4b49-4118-b9c5-9dc8a9b1212c",
        "Line1": "28595 ORCHARD LAKE RD",
        "Line2": "STE 200",
        "Line3": "",
        "ModifiedOn": "1/1/0001 12:00:00 AM",
        "ModifiedOnUTC": null,
        "Phone": "2485530010",
        "State": "MI",
        "Zip": "48334-2979"
    },
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.0",
    "Tender": "CreditCard",
    "TransactionState": "Partially Captured",
    "TransationStateHistory": [
        {
            "Amount": "20.00",
            "CommittedStateTime": "12/29/2021 9:46:34 AM",
            "TransactionState": "Pending Capture"
        },
        {
            "Amount": "10.00",
            "CommittedStateTime": "12/29/2021 9:46:52 AM",
            "TransactionState": "Partially Captured"
        }
    ],
    "TrxInitiation": "Customer",
    "TrxResponse": {
        "AVSAddressResponse": "",
        "AVSZipResponse": "",
        "AuthCode": "S300PJ",
        "CVV2Response": "NotSet",
        "CardType": "Credit",
        "ExpectedSettledTime": null,
        "FinalAmount": "20.00",
        "IAVSAddressResponse": "",
        "Message": "APPROVED",
        "OrigTrxAmount": "20.00",
        "OriginationID": "E9F6B60A145740B2BD3C28C7A6628574",
        "PayFabricErrorCode": null,
        "RespTrxTag": "12/29/2021 7:46:34 AM",
        "ResultCode": "1",
        "SettledTime": null,
        "Status": "Approved",
        "SurchargeAmount": "0.00",
        "SurchargePercentage": "0.00",
        "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"2\" status=\"1\"><NeededData><Transaction><Type>2</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>2</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>7</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>S300PJ</Desc><Value>S300PJ</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2129</Desc><Value>2129</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D599\"><Name>ThreeDSInfoRespIsChallengeMandated</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D601\"><Name>ThreeDSInfoRespAuthenticationType</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D604\"><Name>ThreeDSInfoRespMessageCategory</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D606\"><Name>ThreeDSInfoRespTransactionStatus</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D607\"><Name>ThreeDSInfoRespTransactionStatusReason</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D616\"><Name>ThreeDsRespSCARequired</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D617\"><Name>ThreeDsRespExemptionControl</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D619\"><Name>ThreeDsRespAuthenticationMethod</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D621\"><Name>ThreeDsRespProcessedAsDataOnly</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D586\"><Name>ProtocolVersion</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>E9F6B60A145740B2BD3C28C7A6628574</Desc><Value>E9F6B60A145740B2BD3C28C7A6628574</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>05715317</Desc><Value>05715317</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>691723</Desc><Value>691723</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Authorized</Desc><Value>Authorized</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>ReadyForCapture</Desc><Value>ReadyForCapture</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>12/29/2021 7:46:34 AM</Desc><Value>12/29/2021 7:46:34 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>E9F6B60A145740B2BD3C28C7A6628574</Desc><Value>E9F6B60A145740B2BD3C28C7A6628574</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>2</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>1222</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>11</Value></Field><Field id=\"TrxField_D6\"><Name>MiddleName</Name><Desc>Middle Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1</Value></Field><Field id=\"TrxField_D8\"><Name>Address1</Name><Desc>Address 1</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>2099 State College</Value></Field><Field id=\"TrxField_D11\"><Name>City</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>anaheim</Value></Field><Field id=\"TrxField_D13\"><Name>Zip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>92906</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>20.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D41\"><Name>ShipToZip</Name><Desc>Ship to Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>48334-2979</Value></Field><Field id=\"TrxField_D48\"><Name>CustomerCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>AARONFIT0001</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D99\"><Name>ShipToCity</Name><Desc>Shipping City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>FARMINGTON HILLS</Value></Field><Field id=\"TrxField_D103\"><Name>ShipToState</Name><Desc>Shipping State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>MI</Value></Field><Field id=\"TrxField_D104\"><Name>ShipToStreet</Name><Desc>Shipping Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>28595 ORCHARD LAKE RD STE 200 </Value></Field><Field id=\"TrxField_D111\"><Name>ShipToCountry</Name><Desc>Shipping Country</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>United States</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>122.97.16.122</Value></Field><Field id=\"TrxField_D155\"><Name>ShipToPhone</Name><Desc>Shipping Phone</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>2485530010</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Customer</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Stored</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>10</Value></Field><Field id=\"TrxField_D544\"><Name>CCFirstTransactionId</Name><Desc>The transaction Id that was first used to validate the credit card before use or storage</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>2B4182E0E116467291C553CCAB5A23B1</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>21122900961579</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D547\"><Name>SubsequentAuthOriginalAmount</Name><Value>3.00</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>11 1 1 </Value></Field><Field id=\"TRXFIELD_D55\"><Name>AccountStreet</Name><Value>2099 State College </Value></Field><Field id=\"TRXFIELD_D47\"><Name>CountryCode</Name><Value>USA</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>21122900961579</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>b90eaf6a-70d6-4ebb-9aa4-a839033223f1</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2021-12-29 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 1:46:34 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field><Field id=\"MSO_TrxType\"><Name>MSO_TrxType</Name><Value>7</Value></Field><Field id=\"MSO_TrxStatus\"><Name>MSO_TrxStatus</Name><Value>0</Value></Field><Field id=\"MSO_IsCardValid\"><Name>MSO_IsCardValid</Name><Value>1</Value></Field><Field id=\"MSO_Auth_Amount\"><Name>MSO_Auth_Amount</Name><Value>20.00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
        "TerminalID": "",
        "TerminalResultCode": "",
        "TrxAmount": "20.00",
        "TrxDate": "12/29/2021 1:46:34 AM",
        "TrxDateUTC": "12/29/2021 9:46:34 AM",
        "TrxKey": "21122900961579",
        "WalletID": null
    },
    "TrxSchedule": "Unscheduled",
    "TrxUserDefine1": "Via endpoint: api2.cipcert.goevo.com; takes 2551.3783ms;",
    "TrxUserDefine2": "",
    "TrxUserDefine3": "",
    "TrxUserDefine4": "",
    "Type": "Book"
}
</pre>


Retrieve Transactions
---------------------

* `GET /payment/api/transaction/get?fromdate=10-13-2015` will return the transactions created after the specified date.

Options
-------

This request accepts the below query string parameters to add options. You can use below query parameters by adding them to your request URL and conneciton them with '&'.

>
| QueryString| Description | 
| :------------- | :------------- | 
|perdevice |When the value is `true`, the transaction will be filtered by device, which's device ID is used to authorize the request. Default value is `false`.|
|customer|This parameter is to filter the result by customer number, which is used to create/process transaction.|
|fromdate|This parameter is to set specific 'date from' to filter transactions. The format: mm/dd/yyyy.|
|page|This parameter is to set the result's page number, each page will return 15 records.|
|status|This parameter is used to filter transaction result against processed transaction's status, the possible values are: `approved`, `failure`, and `denied`. Returned result will include all transaction status if application does not submit this parameter.|
|excludeunprocess|When the value is `true`, the result will filter out the unprocess transaction. Default value is `false`. |
|pagesize|This parameter is to set specific page size, maximum value is 15.|
|enddate|This parameter is to set a specific 'date to' to filter transactions, The format: mm/dd/yyyy. |

###### Response
<pre>
{
    "Paging": {
        "Current": "1",
        "Size": "15",
        "TotalPages": "9",
        "TotalRecords": "134"
    },
    "Records": [
        {
            "Amount": "100.00",
            "AuthorizationType": "NotSet",
            "BatchNumber": "",
            "CCEntryIndicator": "Entered",
            "Card": {
                "Aba": "",
                "Account": "XXXXXXXXXXXX1111",
                "AccountType": "",
                "Billto": {
                    "City": "Chicago",
                    "Country": "United States",
                    "Customer": "",
                    "Email": "candicechenyuan@aliyun.com",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "11403 45 St. South",
                    "Line2": "123asdfadf2",
                    "Line3": "123asdfadf3",
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "ModifiedOnUTC": null,
                    "Phone": "13125550102",
                    "State": "IL",
                    "Zip": "60603-0776"
                },
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "1",
                    "LastName": "1",
                    "MiddleName": "1",
                    "SSN": ""
                },
                "CardName": "Visa",
                "CardType": "Credit",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "EncryptedToken": null,
                "ExpDate": "0122",
                "GPAddressCode": null,
                "GatewayToken": null,
                "ID": "00000000-0000-0000-0000-000000000000",
                "Identifier": null,
                "IsDefaultCard": false,
                "IsLocked": false,
                "IsSaveCard": false,
                "IssueNumber": null,
                "LastUsedDate": "1/1/0001 12:00:00 AM",
                "LastUsedDateUTC": null,
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "ModifiedOnUTC": null,
                "NewCustomerNumber": null,
                "StartDate": null,
                "Tender": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null
            },
            "CardHolderAttendance": "",
            "CardType": "Credit",
            "Currency": "USD",
            "Customer": "aaronfit0001",
            "Document": {
                "DefaultBillTo": null,
                "Head": [
                    {
                        "Name": "InvoiceNumber",
                        "Value": null
                    }
                ],
                "Lines": [],
                "UserDefined": []
            },
            "ECheckSetupId": "",
            "EntryClass": "",
            "EntryMode": "HostedPage",
            "Key": "21011000521501",
            "MSO_EngineGUID": "05dd28ac-fb29-4e75-9c2b-ce11325101f7",
            "ModifiedOn": "1/10/2021 10:56:04 PM",
            "ModifiedOnUTC": "1/11/2021 6:56:04 AM",
            "OrigTrxAmount": "100.00",
            "PayDate": "",
            "PayDateUTC": "",
            "ReferenceKey": null,
            "ReferenceTrxs": null,
            "ReqAuthCode": "11",
            "SetupId": "EVOSNAPWITHSURCHARGE",
            "Shipto": {
                "City": "Chicago",
                "Country": "United States",
                "Customer": "",
                "Email": "candicechenyuan@aliyun.com",
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "11403 45 St. South",
                "Line2": "123asdfadf2",
                "Line3": "123asdfadf3",
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "ModifiedOnUTC": null,
                "Phone": "13125550102",
                "State": "IL",
                "Zip": "60603-0776"
            },
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.0",
            "Tender": "CreditCard",
            "TransactionState": "Settled",
            "TransationStateHistory": [],
            "TrxInitiation": "Customer",
            "TrxResponse": {
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "AuthCode": "11",
                "CVV2Response": "NotSet",
                "CardType": "Credit",
                "ExpectedSettledTime": "2021-01-12T03:00:00.0000000Z",
                "FinalAmount": "100.00",
                "IAVSAddressResponse": "",
                "Message": "APPROVED",
                "OrigTrxAmount": "100.00",
                "OriginationID": "444F2C68DE154FAE9D09569F1095CF22",
                "PayFabricErrorCode": null,
                "RespTrxTag": null,
                "ResultCode": "1",
                "SettledTime": "2021-01-11T07:13:24.0000000Z",
                "Status": "Approved",
                "SurchargeAmount": "0.00",
                "SurchargePercentage": "0.00",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "100.00",
                "TrxDate": "1/10/2021 10:56:04 PM",
                "TrxDateUTC": "1/11/2021 6:56:04 AM",
                "TrxKey": "21011000521501",
                "WalletID": null
            },
            "TrxSchedule": "Unscheduled",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Force"
        },        
        {
            "Amount": "200.00",
            "AuthorizationType": "NotSet",
            "BatchNumber": "",
            "CCEntryIndicator": "Entered",
            "Card": {
                "Aba": "",
                "Account": "XXXXXXXXXXXX1111",
                "AccountType": "",
                "Billto": {
                    "City": "",
                    "Country": "",
                    "Customer": "",
                    "Email": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "",
                    "Line2": "",
                    "Line3": "",
                    "ModifiedOn": "1/1/0001 12:00:00 AM",
                    "ModifiedOnUTC": null,
                    "Phone": "",
                    "State": "",
                    "Zip": ""
                },
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "asbsd",
                    "LastName": "1223345",
                    "MiddleName": "s",
                    "SSN": ""
                },
                "CardName": "Visa",
                "CardType": "Prepaid",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "EncryptedToken": null,
                "ExpDate": "0122",
                "GPAddressCode": null,
                "GatewayToken": null,
                "ID": "00000000-0000-0000-0000-000000000000",
                "Identifier": null,
                "IsDefaultCard": false,
                "IsLocked": false,
                "IsSaveCard": false,
                "IssueNumber": null,
                "LastUsedDate": "1/1/0001 12:00:00 AM",
                "LastUsedDateUTC": null,
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "ModifiedOnUTC": null,
                "NewCustomerNumber": null,
                "StartDate": null,
                "Tender": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null
            },
            "CardHolderAttendance": "",
            "CardType": "Prepaid",
            "Currency": "CAD",
            "Customer": "AARONFIT0001",
            "Document": {
                "DefaultBillTo": null,
                "Head": [
                    {
                        "Name": "InvoiceNumber",
                        "Value": ""
                    }
                ],
                "Lines": [],
                "UserDefined": [
                    {
                        "Name": "ThirdPartyBatch",
                        "Value": null
                    }
                ]
            },
            "ECheckSetupId": "",
            "EntryClass": "",
            "EntryMode": "HostedPage",
            "Key": "21032200596373",
            "MSO_EngineGUID": "65a9df60-1bc8-43d7-a279-1f4bb620e5a0",
            "ModifiedOn": "3/22/2021 12:52:53 AM",
            "ModifiedOnUTC": "3/22/2021 7:52:53 AM",
            "OrigTrxAmount": "200.00",
            "PayDate": "",
            "PayDateUTC": "",
            "ReferenceKey": null,
            "ReferenceTrxs": null,
            "ReqAuthCode": "010101",
            "SetupId": "EVOSNAPNOSURCHARGE",
            "Shipto": {
                "City": "",
                "Country": "",
                "Customer": "",
                "Email": "",
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "",
                "Line2": "",
                "Line3": "",
                "ModifiedOn": "1/1/0001 12:00:00 AM",
                "ModifiedOnUTC": null,
                "Phone": "",
                "State": "",
                "Zip": ""
            },
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.0",
            "Tender": "CreditCard",
            "TransactionState": "Settled",
            "TransationStateHistory": [],
            "TrxInitiation": "Customer",
            "TrxResponse": {
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "AuthCode": "010101",
                "CVV2Response": "NotSet",
                "CardType": "Prepaid",
                "ExpectedSettledTime": "2021-03-23T03:00:00.0000000Z",
                "FinalAmount": "200.00",
                "IAVSAddressResponse": "",
                "Message": "APPROVED",
                "OrigTrxAmount": "200.00",
                "OriginationID": "4720DB1FAC0D4C32877AC13BAAF61D3E",
                "PayFabricErrorCode": null,
                "RespTrxTag": null,
                "ResultCode": "1",
                "SettledTime": "2021-03-24T03:00:00.0000000Z",
                "Status": "Approved",
                "SurchargeAmount": "0.00",
                "SurchargePercentage": "0.00",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "200.00",
                "TrxDate": "3/22/2021 12:52:52 AM",
                "TrxDateUTC": "3/22/2021 7:52:52 AM",
                "TrxKey": "21032200596373",
                "WalletID": null
            },
            "TrxSchedule": "Unscheduled",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Force"
        }
    ]
}
</pre>


Referenced Transaction(s): Capture (Ship), Void or Refund (Credit)
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Refund (Credit). They all use the transaction Key from the original transaction to process the new transaction.

#### Capture (Ship)

* `GET /payment/api/reference/{TransactionKey}?trxtype=Capture` will attempt to execute and finalize (capture) an authorization transaction, also known as Book transactions.
* `POST /payment/api/transaction/process` will attempt to execute and finalize (capture) a pre-authorized transaction with specific amount, if `Amount` is not provided in request body, it will capture with authorized amount. if `Amount` is provoided in request body, it could be able to capture an authorization transaction multiple times, which depends on what gateway been used. (Note: Following gateways support multiple captures, Authorize.Net, USAePay & Payeezy (aka First Data GGE4).)

###### Request
<pre>
{
  "Amount": "1",
  "Type": "Capture",
  "ReferenceKey": "151013003792",
   "Document": {
    "Head": [ 
        {
                <b>"Name":"CaptureComplete",</b>
               <b> "Value":false</b>
        }
     ],   
  }
}
</pre>
<b>Note:</b> CaptureComplete = true means this is the last capture transaction, no capture allowed for the original authorization transaction; CaptureComplete = false means this is not the last capture transaction, it allows to do multiple captures for the original authorization transaction. CaptureComplete will be set to true if pass invalid value or don't pass any value. For **EVO gateway profile**, If over capture or transactions include tip amount or incremental amount, CaptureComplete will be set to true automatically whatever the input value is. This logic is not applied with other gateways' transactions other than EVO.

* `GET /payment/api/reference/{TransactionKey}?trxtype=VOID` or `POST /transaction/process` with following request will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.

###### Request
<pre>
{
  "Type": "Void",
  "ReferenceKey": "151013003792"
}
</pre>

* `GET /payment/api/reference/{TransactionKey}?trxtype=Refund` or `POST /transaction/process` with following request will attempt to credit a transaction that has already been submitted to a payment gateway and has been settled from the bank. PayFabric attempts to submit a Refund transaction for a previous Sale/Caputre transaction.

###### Request
<pre>
{
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

or 

<pre>
{
  "Amount":"1",
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

Note: `ReferenceKey` is the initial processed transaction's `TrxKey`. If `Amount` is not provided in request body for Refund transaction, it will processed with original transaction amount. If `Amount` is provided, it will process partial refund with the specific amount.

###### Response
<pre>
{
    "AVSAddressResponse": "X",
    "AVSZipResponse": "X",
    "AuthCode": "010101",
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "2021-07-03T02:00:00.0000000Z",
    "FinalAmount": "1.00",
    "IAVSAddressResponse": "N",
    "Message": "Approved",
    "OrigTrxAmount": "1.00",
    "OriginationID": "A41E0E04DA9E",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "SettledTime": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0",
    "TAXml": "",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "1.00",
    "TrxDate": "7/1/2021 10:52:15 PM",
    "TrxKey": "21070100732374",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>

Refund (Non-Reference)
-----------------

To perform a Refund transaction without reference transacton, you just need to create a transaction object, set the `Type` field to `Refund`, and then use [Create and Process a Transaction](#create-and-process-a-transaction) to submit the transaction.

* `POST /payment/api/transaction/process?cvc={CVCValue}`

###### Request
<pre>
{
    "SetupId": "EVO",
    <b>"Type": "Refund"</b>,
    "Customer": "JOHNDOE0001",
    "Amount": 19.99,
    "Currency": "USD",
    "Card": {
        "ID": "8b4a9102-8207-4e8f-99fa-01c6f623ddb8"
        }
    }
}
</pre>

###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": null,
    "CVV2Response": null,
    "CardType": "Credit",
    "FinalAmount": "104.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "AD0D53935734451D86011AF6D0BDF46C",
    "PayFabricErrorCode": null,
    "RespTrxTag": "8/5/2020 5:00:23 AM",
    "ResultCode": "1",
    "Status": "Approved",
    "SurchargeAmount": "4.00",
    "SurchargePercentage": "4.0",
    "TAXml":"",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "104.00",
    "TrxDate": "8/4/2020 11:00:23 PM",
    "TrxKey": "20080400045866"
}
</pre>
