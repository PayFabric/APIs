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
"AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": "378AUE",
    "CVV2Response": "NotSet",
    "CardType": "Credit",
    "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
    "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
    "FinalAmount": "100.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "EE21F1E6B2F94ECF92B83A4807E9D1DD",
    "PayFabricErrorCode": null,
    "RemainingBalance": null,
    "RespTrxTag": "5/26/2022 4:53:59 AM",
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>2524.9933</Desc><Value>2524.9933</Value></Field><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>378AUE</Desc><Value>378AUE</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2226</Desc><Value>2226</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D599\"><Name>ThreeDSInfoRespIsChallengeMandated</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D601\"><Name>ThreeDSInfoRespAuthenticationType</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D604\"><Name>ThreeDSInfoRespMessageCategory</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D606\"><Name>ThreeDSInfoRespTransactionStatus</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D607\"><Name>ThreeDSInfoRespTransactionStatusReason</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D616\"><Name>ThreeDsRespSCARequired</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D617\"><Name>ThreeDsRespExemptionControl</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D619\"><Name>ThreeDsRespAuthenticationMethod</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D621\"><Name>ThreeDsRespProcessedAsDataOnly</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D586\"><Name>ProtocolVersion</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>EE21F1E6B2F94ECF92B83A4807E9D1DD</Desc><Value>EE21F1E6B2F94ECF92B83A4807E9D1DD</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>36047280</Desc><Value>36047280</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>987196</Desc><Value>987196</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>5/26/2022 4:53:59 AM</Desc><Value>5/26/2022 8:54:00 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>EE21F1E6B2F94ECF92B83A4807E9D1DD</Desc><Value>EE21F1E6B2F94ECF92B83A4807E9D1DD</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0123</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 tes</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>dd</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>100.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D49\"><Name>CVV2</Name><Desc>CVV2</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value></Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>63.117.2.51</Value></Field><Field id=\"TrxField_D168\"><Name>CardHolderAttendance</Name><Desc>Card holder attendance</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ECommerce</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Merchant</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>22052501048782</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>123 tes dd </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501048782</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 10:54:00 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "100.00",
    "TrxDate": "5/26/2022 8:54:00 AM",
    "TrxDateUTC": "2022-05-26T05:54:00.530Z",
    "TrxKey": "22052501048782",
    "WalletID": "00000000-0000-0000-0000-000000000000"
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
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": "7KASMC",
    "CVV2Response": "NotSet",
    "CardType": "Credit",
    "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
    "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
    "FinalAmount": "100.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "B41325DBCF4A411F91861AECEBEF6E17",
    "PayFabricErrorCode": null,
    "RemainingBalance": null,
    "RespTrxTag": "5/26/2022 5:11:16 AM",
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>1296.8765</Desc><Value>1296.8765</Value></Field><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>7KASMC</Desc><Value>7KASMC</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2226</Desc><Value>2226</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D599\"><Name>ThreeDSInfoRespIsChallengeMandated</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D601\"><Name>ThreeDSInfoRespAuthenticationType</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D604\"><Name>ThreeDSInfoRespMessageCategory</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D606\"><Name>ThreeDSInfoRespTransactionStatus</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D607\"><Name>ThreeDSInfoRespTransactionStatusReason</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D616\"><Name>ThreeDsRespSCARequired</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D617\"><Name>ThreeDsRespExemptionControl</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D619\"><Name>ThreeDsRespAuthenticationMethod</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D621\"><Name>ThreeDsRespProcessedAsDataOnly</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D586\"><Name>ProtocolVersion</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>B41325DBCF4A411F91861AECEBEF6E17</Desc><Value>B41325DBCF4A411F91861AECEBEF6E17</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>23846746</Desc><Value>23846746</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>987222</Desc><Value>987222</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>5/26/2022 5:11:16 AM</Desc><Value>5/26/2022 9:11:17 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>B41325DBCF4A411F91861AECEBEF6E17</Desc><Value>B41325DBCF4A411F91861AECEBEF6E17</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0123</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 tes</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>dd</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>100.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D49\"><Name>CVV2</Name><Desc>CVV2</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value></Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>63.117.2.51</Value></Field><Field id=\"TrxField_D168\"><Name>CardHolderAttendance</Name><Desc>Card holder attendance</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ECommerce</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Merchant</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>22052501048797</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>123 tes dd </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501048797</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:11:17 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "100.00",
    "TrxDate": "5/26/2022 9:11:17 AM",
    "TrxDateUTC": "2022-05-26T06:11:17.505Z",
    "TrxKey": "22052501048797",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>


Retrieve a Transaction
----------------------

* `GET /payment/api/transaction/{TransactionKey}` will return the specified transaction

###### Response
<pre>
{
    "Amount": "100.00",
    "AuthorizationType": "NotSet",
    "BatchNumber": "",
    "CCEntryIndicator": "Entered",
    "CardHolderAttendance": "ECommerce",
    "CardType": "Credit",
    "Currency": "USD",
    "Customer": "",
    "Document": {
        "DefaultBillTo": null,
        "Head": [],
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
    "EntryMode": "API",
    "GiftCardSetupId": "",
    "Key": "22052501048797",
    "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
    "ModifiedOn": "5/26/2022 9:11:17 AM",
    "ModifiedOnUTC": "2022-05-26T06:11:17.530Z",
    "OrigTrxAmount": "100.00",
    "PayDate": "",
    "PayDateUTC": "",
    "ReferenceKey": null,
    "ReferenceTrxs": [],
    "ReqAuthCode": "",
    "SetupId": "EVO",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.0",
    "Tender": "CreditCard",
    "TransactionState": "Pending Settlement",
    "TransationStateHistory": [
        {
            "Amount": "100.00",
            "CommittedStateTime": "5/26/2022 9:11:18 AM",
            "CommittedStateTimeUTC": "2022-05-26T06:11:18.000Z",
            "TransactionState": "Pending Settlement"
        }
    ],
    "TrxInitiation": "Merchant",
    "TrxResponse": {
        "AVSAddressResponse": "",
        "AVSZipResponse": "",
        "AuthCode": "7KASMC",
        "CVV2Response": "NotSet",
        "CardType": "Credit",
        "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
        "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
        "FinalAmount": "100.00",
        "IAVSAddressResponse": "",
        "Message": "APPROVED",
        "OrigTrxAmount": "100.00",
        "OriginationID": "B41325DBCF4A411F91861AECEBEF6E17",
        "PayFabricErrorCode": null,
        "RemainingBalance": null,
        "RespTrxTag": "5/26/2022 5:11:16 AM",
        "ResultCode": "1",
        "SettledTime": null,
        "SettledTimeUTC": null,
        "Status": "Approved",
        "SurchargeAmount": "0.00",
        "SurchargePercentage": "0.00",
        "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>1296.8765</Desc><Value>1296.8765</Value></Field><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>7KASMC</Desc><Value>7KASMC</Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2226</Desc><Value>2226</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D599\"><Name>ThreeDSInfoRespIsChallengeMandated</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D601\"><Name>ThreeDSInfoRespAuthenticationType</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D604\"><Name>ThreeDSInfoRespMessageCategory</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D606\"><Name>ThreeDSInfoRespTransactionStatus</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D607\"><Name>ThreeDSInfoRespTransactionStatusReason</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D616\"><Name>ThreeDsRespSCARequired</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D617\"><Name>ThreeDsRespExemptionControl</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D619\"><Name>ThreeDsRespAuthenticationMethod</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D621\"><Name>ThreeDsRespProcessedAsDataOnly</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D586\"><Name>ProtocolVersion</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>B41325DBCF4A411F91861AECEBEF6E17</Desc><Value>B41325DBCF4A411F91861AECEBEF6E17</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>23846746</Desc><Value>23846746</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>987222</Desc><Value>987222</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>5/26/2022 5:11:16 AM</Desc><Value>5/26/2022 9:11:17 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>B41325DBCF4A411F91861AECEBEF6E17</Desc><Value>B41325DBCF4A411F91861AECEBEF6E17</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0123</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 tes</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>dd</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>100.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D49\"><Name>CVV2</Name><Desc>CVV2</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value></Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>63.117.2.51</Value></Field><Field id=\"TrxField_D168\"><Name>CardHolderAttendance</Name><Desc>Card holder attendance</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ECommerce</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Merchant</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>22052501048797</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>123 tes dd </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501048797</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:11:17 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
        "TerminalID": "",
        "TerminalResultCode": "",
        "TrxAmount": "100.00",
        "TrxDate": "5/26/2022 9:11:17 AM",
        "TrxDateUTC": "2022-05-26T06:11:17.505Z",
        "TrxKey": "22052501048797",
        "WalletID": null
    },
    "TrxSchedule": "Unscheduled",
    "TrxUserDefine1": "Via endpoint: api1.cipcert.goevo.com; takes 1296.8765ms; update takes 0ms",
    "TrxUserDefine2": "",
    "TrxUserDefine3": "",
    "TrxUserDefine4": "",
    "Type": "Sale",
    "Card": {
        "Aba": "",
        "Account": "XXXXXXXXXXXX1111",
        "AccountType": "",
        "CardHolder": {
            "DriverLicense": "",
            "FirstName": "123 tes",
            "LastName": "dd",
            "MiddleName": "",
            "SSN": ""
        },
        "CardName": "Visa",
        "CardType": "Credit",
        "CheckNumber": "",
        "Connector": "EVO",
        "Customer": "",
        "EncryptedToken": null,
        "ExpDate": "0123",
        "GPAddressCode": "",
        "GatewayToken": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Identifier": "",
        "IsDefaultCard": false,
        "IsLocked": false,
        "IsSaveCard": false,
        "IssueNumber": "",
        "LastUsedDate": "5/26/2022 9:11:17 AM",
        "LastUsedDateUTC": "2022-05-26T06:11:17.530Z",
        "Tender": "CreditCard",
        "UserDefine1": "",
        "UserDefine2": "",
        "UserDefine3": "",
        "UserDefine4": "",
        "Billto": {
            "City": "",
            "Country": "",
            "Customer": "",
            "Email": "",
            "ID": "00000000-0000-0000-0000-000000000000",
            "Line1": "",
            "Line2": "",
            "Line3": "",
            "Phone": "",
            "State": "",
            "Zip": ""
        }
    },
    "Shipto": {
        "City": "",
        "Country": "",
        "Customer": "",
        "Email": "",
        "ID": "00000000-0000-0000-0000-000000000000",
        "Line1": "",
        "Line2": "",
        "Line3": "",
        "Phone": "",
        "State": "",
        "Zip": ""
    }
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
|fromdate|This parameter is to set specific 'date from' to filter transactions. The format: mm/dd/yyyy and in merchant timezone. For example, merchant set the time zone as EST, and call this API by passing the fromdate = 05/20/2022, then API will return the transactions processed later than 2022-5-20 00:00:00 in EST.|
|page|This parameter is to set the result's page number, each page will return 15 records.|
|status|This parameter is used to filter transaction result against processed transaction's status, the possible values are: `approved`, `failure`, and `denied`. Returned result will include all transaction status if application does not submit this parameter.|
|excludeunprocess|When the value is `true`, the result will filter out the unprocess transaction. Default value is `false`. |
|pagesize|This parameter is to set specific page size, maximum value is 15.|
|enddate|This parameter is to set a specific 'date to' to filter transactions, The format: mm/dd/yyyy and in merchant timezone. For example, merchant set the time zone as EST, and call this API by passing the enddate = 05/20/2022, then API will return the transactions processed earlier than 2022-5-20 23:59:59 in EST. |

###### Response
<pre>
{
    "Paging": {
        "Current": "1",
        "Size": "15",
        "TotalPages": "1",
        "TotalRecords": "1"
    },
    "Records": [
        {
            "Amount": "100.00",
            "AuthorizationType": "NotSet",
            "BatchNumber": "",
            "CCEntryIndicator": "Entered",
            "CardHolderAttendance": "ECommerce",
            "CardType": "Credit",
            "Currency": "USD",
            "Customer": "",
            "Document": {
                "DefaultBillTo": null,
                "Head": [],
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
            "EntryMode": "API",
            "GiftCardSetupId": "",
            "Key": "22052501048797",
            "MSO_EngineGUID": "4f76bfce-6d2d-4a20-a7b8-5ba0f363e090",
            "ModifiedOn": "5/26/2022 9:11:17 AM",
            "ModifiedOnUTC": "2022-05-26T06:11:17.530Z",
            "OrigTrxAmount": "100.00",
            "PayDate": "",
            "PayDateUTC": "",
            "ReferenceKey": null,
            "ReferenceTrxs": [],
            "ReqAuthCode": "",
            "SetupId": "EVO",
            "SurchargeAmount": "0.00",
            "SurchargePercentage": "0.0",
            "Tender": "CreditCard",
            "TransactionState": "Pending Settlement",
            "TransationStateHistory": [
                {
                    "Amount": "100.00",
                    "CommittedStateTime": "5/26/2022 9:11:18 AM",
                    "CommittedStateTimeUTC": "2022-05-26T06:11:18.000Z",
                    "TransactionState": "Pending Settlement"
                }
            ],
            "TrxInitiation": "Merchant",
            "TrxResponse": {
                "AVSAddressResponse": "",
                "AVSZipResponse": "",
                "AuthCode": "7KASMC",
                "CVV2Response": "NotSet",
                "CardType": "Credit",
                "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
                "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
                "FinalAmount": "100.00",
                "IAVSAddressResponse": "",
                "Message": "APPROVED",
                "OrigTrxAmount": "100.00",
                "OriginationID": "B41325DBCF4A411F91861AECEBEF6E17",
                "PayFabricErrorCode": null,
                "RemainingBalance": null,
                "RespTrxTag": null,
                "ResultCode": "1",
                "SettledTime": null,
                "SettledTimeUTC": null,
                "Status": "Approved",
                "SurchargeAmount": "0.00",
                "SurchargePercentage": "0.00",
                "TAXml": null,
                "TerminalID": "",
                "TerminalResultCode": "",
                "TrxAmount": "100.00",
                "TrxDate": "5/26/2022 9:11:17 AM",
                "TrxDateUTC": "2022-05-26T06:11:17.505Z",
                "TrxKey": "22052501048797",
                "WalletID": null
            },
            "TrxSchedule": "Unscheduled",
            "TrxUserDefine1": null,
            "TrxUserDefine2": null,
            "TrxUserDefine3": null,
            "TrxUserDefine4": null,
            "Type": "Sale",
            "Card": {
                "Aba": "",
                "Account": "XXXXXXXXXXXX1111",
                "AccountType": "",
                "CardHolder": {
                    "DriverLicense": "",
                    "FirstName": "123 tes",
                    "LastName": "dd",
                    "MiddleName": "",
                    "SSN": ""
                },
                "CardName": "Visa",
                "CardType": "Credit",
                "CheckNumber": "",
                "Connector": null,
                "Customer": "",
                "EncryptedToken": null,
                "ExpDate": "0123",
                "GPAddressCode": null,
                "GatewayToken": null,
                "ID": "00000000-0000-0000-0000-000000000000",
                "Identifier": null,
                "IsDefaultCard": false,
                "IsLocked": false,
                "IsSaveCard": false,
                "IssueNumber": null,
                "LastUsedDate": "5/26/2022 9:11:17 AM",
                "LastUsedDateUTC": "2022-05-26T06:11:17.530Z",
                "Tender": null,
                "UserDefine1": null,
                "UserDefine2": null,
                "UserDefine3": null,
                "UserDefine4": null,
                "Billto": {
                    "City": "",
                    "Country": "",
                    "Customer": "",
                    "Email": "",
                    "ID": "00000000-0000-0000-0000-000000000000",
                    "Line1": "",
                    "Line2": "",
                    "Line3": "",
                    "Phone": "",
                    "State": "",
                    "Zip": ""
                }
            },
            "Shipto": {
                "City": "",
                "Country": "",
                "Customer": "",
                "Email": "",
                "ID": "00000000-0000-0000-0000-000000000000",
                "Line1": "",
                "Line2": "",
                "Line3": "",
                "Phone": "",
                "State": "",
                "Zip": ""
            }
        }
    ]
}
</pre>


Referenced Transaction(s): Capture (Ship), Void or Refund (Credit)
---------------------------------------------------------

Referenced transaction uses the original transaction Key as the referenced factor to subsequently process a new transaction. There’re 3 types of referenced transactions: Void, Capture (Ship) and Refund (Credit). They all use the transaction Key from the original transaction to process the new transaction.

#### Capture (Ship)

* `GET /payment/api/reference/{TransactionKey}?trxtype=Capture` will attempt to execute and finalize (capture) an authorization transaction, also known as Book transactions.
* `POST /payment/api/transaction/process` will attempt to execute and finalize (capture) a pre-authorized transaction with specific amount, if `Amount` is not provided in request body, it will capture with authorized amount. if `Amount` is provoided in request body, it could be able to capture an authorization transaction multiple times, which depends on what gateway been used. (Note: Following gateways support multiple captures: EVO PayFabric, Authorize.Net, USAePay & Payeezy (aka First Data GGE4).)

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

### Void

* `GET /payment/api/reference/{TransactionKey}?trxtype=VOID` or `POST /transaction/process` with following request will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.

###### Request
<pre>
{
  "Type": "Void",
  "ReferenceKey": "151013003792"
}
</pre>

### Refund(Refund)

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
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": null,
    "CVV2Response": null,
    "CardType": "Credit",
    "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
    "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
    "FinalAmount": "100.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "13529CF98B794C51A341CED02CE06A2E",
    "PayFabricErrorCode": null,
    "RemainingBalance": null,
    "RespTrxTag": "5/26/2022 5:27:50 AM",
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"6\" status=\"1\"><NeededData><Transaction><Type>6</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>6</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>6</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>937.5086</Desc><Value>937.5086</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>13529CF98B794C51A341CED02CE06A2E</Desc><Value>13529CF98B794C51A341CED02CE06A2E</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>96745031</Desc><Value>96745031</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>987264</Desc><Value>987264</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Returned</Desc><Value>Returned</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>CapturedUndoPermitted</Desc><Value>CapturedUndoPermitted</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>5/26/2022 5:27:50 AM</Desc><Value>5/26/2022 9:27:51 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>13529CF98B794C51A341CED02CE06A2E</Desc><Value>13529CF98B794C51A341CED02CE06A2E</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>6</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0123</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 tes</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>dd</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>3</Type><Value>100.00</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>Origination ID</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>B41325DBCF4A411F91861AECEBEF6E17</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>63.117.2.51</Value></Field><Field id=\"TrxField_D168\"><Name>CardHolderAttendance</Name><Desc>Card holder attendance</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ECommerce</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Merchant</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>22052501048810</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D24\"><Name>AuthCode</Name><Value>7KASMC</Value></Field><Field id=\"TRXFIELD_D76\"><Name>TrxDate</Name><Value>5/26/2022 5:11:16 AM</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>123 tes dd </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501048810</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:27:51 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "100.00",
    "TrxDate": "5/26/2022 9:27:51 AM",
    "TrxDateUTC": "2022-05-26T06:27:51.332Z",
    "TrxKey": "22052501048810",
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
    "AuthCode": "",
    "CVV2Response": "NotSet",
    "CardType": "Credit",
    "ExpectedSettledTime": "5/26/2022 8:00:00 PM",
    "ExpectedSettledTimeUTC": "2022-05-26T17:00:00.000",
    "FinalAmount": "100.00",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "100.00",
    "OriginationID": "FC831CCC776D46DA93739A6D4BFBEE6D",
    "PayFabricErrorCode": null,
    "RemainingBalance": null,
    "RespTrxTag": "5/26/2022 5:30:43 AM",
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO\" connector=\"EVO\"><Processor id=\"1\">Evo US</Processor><PaymentType id=\"1\">Credit</PaymentType></Connection><Transaction post=\"False\" type=\"6\" status=\"1\"><NeededData><Transaction><Type>6</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>6</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>6</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>1281.2611</Desc><Value>1281.2611</Value></Field><Field id=\"TrxField_D83\"><Name>CVV2ResponseCode</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc /><Value></Value></Field><Field id=\"TrxField_D545\"><Name>ResponseBatchID</Name><Desc>2226</Desc><Value>2226</Value></Field><Field id=\"TrxField_D573\"><Name>ProcessedAs3D</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D599\"><Name>ThreeDSInfoRespIsChallengeMandated</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D601\"><Name>ThreeDSInfoRespAuthenticationType</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D604\"><Name>ThreeDSInfoRespMessageCategory</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D606\"><Name>ThreeDSInfoRespTransactionStatus</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D607\"><Name>ThreeDSInfoRespTransactionStatusReason</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D616\"><Name>ThreeDsRespSCARequired</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D617\"><Name>ThreeDsRespExemptionControl</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D619\"><Name>ThreeDsRespAuthenticationMethod</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D621\"><Name>ThreeDsRespProcessedAsDataOnly</Name><Desc>False</Desc><Value>False</Value></Field><Field id=\"TrxField_D586\"><Name>ProtocolVersion</Name><Desc>NotSet</Desc><Value>NotSet</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>FC831CCC776D46DA93739A6D4BFBEE6D</Desc><Value>FC831CCC776D46DA93739A6D4BFBEE6D</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc>41803231</Desc><Value>41803231</Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>987272</Desc><Value>987272</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Returned</Desc><Value>Returned</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D76\"><Name>TrxDate</Name><Desc>5/26/2022 5:30:43 AM</Desc><Value>5/26/2022 9:30:44 AM</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>FC831CCC776D46DA93739A6D4BFBEE6D</Desc><Value>FC831CCC776D46DA93739A6D4BFBEE6D</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>6</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0123</Value></Field><Field id=\"TrxField_D5\"><Name>FirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 tes</Value></Field><Field id=\"TrxField_D7\"><Name>LastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>dd</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>3</Type><Value>100.00</Value></Field><Field id=\"TrxField_D18\"><Name>CCType</Name><Desc>Card Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Visa</Value></Field><Field id=\"TrxField_D49\"><Name>CVV2</Name><Desc>CVV2</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value></Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D141\"><Name>ClientIP</Name><Desc>IP Address</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>63.117.2.51</Value></Field><Field id=\"TrxField_D168\"><Name>CardHolderAttendance</Name><Desc>Card holder attendance</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>ECommerce</Value></Field><Field id=\"TrxField_D539\"><Name>TransactionInitiation</Name><Desc>Transaction Initiation indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Merchant</Value></Field><Field id=\"TrxField_D542\"><Name>CCEntryIndicator</Name><Desc>Credit card entry indicator</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>Entered</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TrxField_D550\"><Name>PayFabricTransactionKey</Name><Desc>The PayFabric Transaction Key associated to this Payment Request.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>22052501048813</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D54\"><Name>AccountName</Name><Value>123 tes dd </Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501048813</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>4f76bfce-6d2d-4a20-a7b8-5ba0f363e090</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 11:30:44 PM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "100.00",
    "TrxDate": "5/26/2022 9:30:44 AM",
    "TrxDateUTC": "2022-05-26T06:30:44.143Z",
    "TrxKey": "22052501048813",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>
