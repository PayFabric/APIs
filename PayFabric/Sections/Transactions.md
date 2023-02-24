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
  <b>"SetupId": "EVO US_CC"</b>,
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

`SetupId` is the [Gateway Profile](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) Name. It is a per-account identifier of a profile containing the credentials for a given credit card processing merchant account. The Gateway Profile Name can also be retrieved through [API call](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Payment%20Gateway%20Profiles.md#retrieve-payment-gateway-profiles).
`ECheckSetupId` which should be the Gateway Profile Name for an ACH/eCheck payment method can be used in addition to, or in place of `SetupId`.

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
    "TAXml": "&lt;TransactionData&gt;&lt;Connection name=\"EVO\" connector=\"EVO\"&gt;&lt;Processor id=\"1\"&gt;Evo US&lt;/Processor&gt;&lt;PaymentType id=\"1\"&gt;Credit&lt;/PaymentType&gt;&lt;/Connection&gt;&lt;Transaction post=\"False\" type=\"1\" status=\"1\"&gt;&lt;NeededData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;NeededData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/NeededData&gt;&lt;FailureData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;FailureData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/FailureData&gt;&lt;ResponseData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;ResponseData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D625\"&gt;&lt;Name&gt;WebRequestExecutionDuration&lt;/Name&gt;&lt;Desc&gt;2524.9933&lt;/Desc&gt;&lt;Value&gt;2524.9933&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D83\"&gt;&lt;Name&gt;CVV2ResponseCode&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D24\"&gt;&lt;Name&gt;AuthCode&lt;/Name&gt;&lt;Desc&gt;378AUE&lt;/Desc&gt;&lt;Value&gt;378AUE&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D545\"&gt;&lt;Name&gt;ResponseBatchID&lt;/Name&gt;&lt;Desc&gt;2226&lt;/Desc&gt;&lt;Value&gt;2226&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D573\"&gt;&lt;Name&gt;ProcessedAs3D&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D599\"&gt;&lt;Name&gt;ThreeDSInfoRespIsChallengeMandated&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D601\"&gt;&lt;Name&gt;ThreeDSInfoRespAuthenticationType&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D604\"&gt;&lt;Name&gt;ThreeDSInfoRespMessageCategory&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D606\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatus&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D607\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatusReason&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D616\"&gt;&lt;Name&gt;ThreeDsRespSCARequired&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D617\"&gt;&lt;Name&gt;ThreeDsRespExemptionControl&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D619\"&gt;&lt;Name&gt;ThreeDsRespAuthenticationMethod&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D621\"&gt;&lt;Name&gt;ThreeDsRespProcessedAsDataOnly&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D586\"&gt;&lt;Name&gt;ProtocolVersion&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;EE21F1E6B2F94ECF92B83A4807E9D1DD&lt;/Desc&gt;&lt;Value&gt;EE21F1E6B2F94ECF92B83A4807E9D1DD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D462\"&gt;&lt;Name&gt;GatewayOriginationID&lt;/Name&gt;&lt;Desc&gt;36047280&lt;/Desc&gt;&lt;Value&gt;36047280&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D463\"&gt;&lt;Name&gt;ProcessorOriginationID&lt;/Name&gt;&lt;Desc&gt;987196&lt;/Desc&gt;&lt;Value&gt;987196&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D31\"&gt;&lt;Name&gt;ResponseMsg&lt;/Name&gt;&lt;Desc&gt;APPROVED&lt;/Desc&gt;&lt;Value&gt;APPROVED&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D17\"&gt;&lt;Name&gt;ResultCode&lt;/Name&gt;&lt;Desc&gt;1&lt;/Desc&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D464\"&gt;&lt;Name&gt;TransactionState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D465\"&gt;&lt;Name&gt;CaptureState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Desc&gt;5/26/2022 4:53:59 AM&lt;/Desc&gt;&lt;Value&gt;5/26/2022 8:54:00 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D288\"&gt;&lt;Name&gt;TransactionID&lt;/Name&gt;&lt;Desc&gt;EE21F1E6B2F94ECF92B83A4807E9D1DD&lt;/Desc&gt;&lt;Value&gt;EE21F1E6B2F94ECF92B83A4807E9D1DD&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/ResponseData&gt;&lt;RequestData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;1&lt;/Status&gt;&lt;Category&gt;RequestData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D1\"&gt;&lt;Name&gt;CCNumber&lt;/Name&gt;&lt;Desc&gt;Credit Card Number, could also be a DPAN/VPAN&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D3\"&gt;&lt;Name&gt;CCExpDate&lt;/Name&gt;&lt;Desc&gt;Expiration Date MMYY&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;0123&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D5\"&gt;&lt;Name&gt;FirstName&lt;/Name&gt;&lt;Desc&gt;First Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;123 tes&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D7\"&gt;&lt;Name&gt;LastName&lt;/Name&gt;&lt;Desc&gt;Last Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;dd&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D15\"&gt;&lt;Name&gt;TrxAmount&lt;/Name&gt;&lt;Desc&gt;Transaction Amount&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;3&lt;/Type&gt;&lt;Value&gt;100.00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D18\"&gt;&lt;Name&gt;CCType&lt;/Name&gt;&lt;Desc&gt;Card Type&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Visa&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D49\"&gt;&lt;Name&gt;CVV2&lt;/Name&gt;&lt;Desc&gt;CVV2&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D74\"&gt;&lt;Name&gt;CurrencyCode&lt;/Name&gt;&lt;Desc&gt;Currency Code&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;USD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D141\"&gt;&lt;Name&gt;ClientIP&lt;/Name&gt;&lt;Desc&gt;IP Address&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;63.117.2.51&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D168\"&gt;&lt;Name&gt;CardHolderAttendance&lt;/Name&gt;&lt;Desc&gt;Card holder attendance&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;ECommerce&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D539\"&gt;&lt;Name&gt;TransactionInitiation&lt;/Name&gt;&lt;Desc&gt;Transaction Initiation indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Merchant&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D542\"&gt;&lt;Name&gt;CCEntryIndicator&lt;/Name&gt;&lt;Desc&gt;Credit card entry indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Entered&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D543\"&gt;&lt;Name&gt;POSEntryMode&lt;/Name&gt;&lt;Desc&gt;POS Entry Mode&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D550\"&gt;&lt;Name&gt;PayFabricTransactionKey&lt;/Name&gt;&lt;Desc&gt;The PayFabric Transaction Key associated to this Payment Request.&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;22052501048782&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D19\"&gt;&lt;Name&gt;PaymentType&lt;/Name&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D2\"&gt;&lt;Name&gt;TRXFIELD_D2&lt;/Name&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D54\"&gt;&lt;Name&gt;AccountName&lt;/Name&gt;&lt;Value&gt;123 tes dd &lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"SaveCreditCard\"&gt;&lt;Name&gt;SaveCreditCard&lt;/Name&gt;&lt;Value&gt;0&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_PFTrxKey\"&gt;&lt;Name&gt;MSO_PFTrxKey&lt;/Name&gt;&lt;Value&gt;22052501048782&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_WalletID\"&gt;&lt;Name&gt;MSO_WalletID&lt;/Name&gt;&lt;Value&gt;00000000-0000-0000-0000-000000000000&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_EngineGUID\"&gt;&lt;Name&gt;MSO_EngineGUID&lt;/Name&gt;&lt;Value&gt;4f76bfce-6d2d-4a20-a7b8-5ba0f363e090&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D540\"&gt;&lt;Name&gt;TransactionSchedule&lt;/Name&gt;&lt;Value&gt;Unscheduled&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D541\"&gt;&lt;Name&gt;AuthorizationType&lt;/Name&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Date\"&gt;&lt;Name&gt;MSO_Last_Xmit_Date&lt;/Name&gt;&lt;Value&gt;2022-05-25 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Time\"&gt;&lt;Name&gt;MSO_Last_Xmit_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 10:54:00 PM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Date\"&gt;&lt;Name&gt;MSO_Last_Settled_Date&lt;/Name&gt;&lt;Value&gt;1900-01-01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Time\"&gt;&lt;Name&gt;MSO_Last_Settled_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/RequestData&gt;&lt;/Transaction&gt;&lt;/TransactionData&gt;",
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
  <b>"SetupId": "EVO US_CC"</b>,
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
    "TAXml": "&lt;TransactionData&gt;&lt;Connection name=\"EVO\" connector=\"EVO\"&gt;&lt;Processor id=\"1\"&gt;Evo US&lt;/Processor&gt;&lt;PaymentType id=\"1\"&gt;Credit&lt;/PaymentType&gt;&lt;/Connection&gt;&lt;Transaction post=\"False\" type=\"1\" status=\"1\"&gt;&lt;NeededData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;NeededData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/NeededData&gt;&lt;FailureData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;FailureData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/FailureData&gt;&lt;ResponseData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;ResponseData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D625\"&gt;&lt;Name&gt;WebRequestExecutionDuration&lt;/Name&gt;&lt;Desc&gt;1296.8765&lt;/Desc&gt;&lt;Value&gt;1296.8765&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D83\"&gt;&lt;Name&gt;CVV2ResponseCode&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D24\"&gt;&lt;Name&gt;AuthCode&lt;/Name&gt;&lt;Desc&gt;7KASMC&lt;/Desc&gt;&lt;Value&gt;7KASMC&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D545\"&gt;&lt;Name&gt;ResponseBatchID&lt;/Name&gt;&lt;Desc&gt;2226&lt;/Desc&gt;&lt;Value&gt;2226&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D573\"&gt;&lt;Name&gt;ProcessedAs3D&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D599\"&gt;&lt;Name&gt;ThreeDSInfoRespIsChallengeMandated&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D601\"&gt;&lt;Name&gt;ThreeDSInfoRespAuthenticationType&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D604\"&gt;&lt;Name&gt;ThreeDSInfoRespMessageCategory&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D606\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatus&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D607\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatusReason&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D616\"&gt;&lt;Name&gt;ThreeDsRespSCARequired&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D617\"&gt;&lt;Name&gt;ThreeDsRespExemptionControl&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D619\"&gt;&lt;Name&gt;ThreeDsRespAuthenticationMethod&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D621\"&gt;&lt;Name&gt;ThreeDsRespProcessedAsDataOnly&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D586\"&gt;&lt;Name&gt;ProtocolVersion&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Desc&gt;&lt;Value&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D462\"&gt;&lt;Name&gt;GatewayOriginationID&lt;/Name&gt;&lt;Desc&gt;23846746&lt;/Desc&gt;&lt;Value&gt;23846746&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D463\"&gt;&lt;Name&gt;ProcessorOriginationID&lt;/Name&gt;&lt;Desc&gt;987222&lt;/Desc&gt;&lt;Value&gt;987222&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D31\"&gt;&lt;Name&gt;ResponseMsg&lt;/Name&gt;&lt;Desc&gt;APPROVED&lt;/Desc&gt;&lt;Value&gt;APPROVED&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D17\"&gt;&lt;Name&gt;ResultCode&lt;/Name&gt;&lt;Desc&gt;1&lt;/Desc&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D464\"&gt;&lt;Name&gt;TransactionState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D465\"&gt;&lt;Name&gt;CaptureState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Desc&gt;5/26/2022 5:11:16 AM&lt;/Desc&gt;&lt;Value&gt;5/26/2022 9:11:17 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D288\"&gt;&lt;Name&gt;TransactionID&lt;/Name&gt;&lt;Desc&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Desc&gt;&lt;Value&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/ResponseData&gt;&lt;RequestData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;1&lt;/Status&gt;&lt;Category&gt;RequestData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D1\"&gt;&lt;Name&gt;CCNumber&lt;/Name&gt;&lt;Desc&gt;Credit Card Number, could also be a DPAN/VPAN&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D3\"&gt;&lt;Name&gt;CCExpDate&lt;/Name&gt;&lt;Desc&gt;Expiration Date MMYY&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;0123&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D5\"&gt;&lt;Name&gt;FirstName&lt;/Name&gt;&lt;Desc&gt;First Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;123 tes&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D7\"&gt;&lt;Name&gt;LastName&lt;/Name&gt;&lt;Desc&gt;Last Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;dd&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D15\"&gt;&lt;Name&gt;TrxAmount&lt;/Name&gt;&lt;Desc&gt;Transaction Amount&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;3&lt;/Type&gt;&lt;Value&gt;100.00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D18\"&gt;&lt;Name&gt;CCType&lt;/Name&gt;&lt;Desc&gt;Card Type&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Visa&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D49\"&gt;&lt;Name&gt;CVV2&lt;/Name&gt;&lt;Desc&gt;CVV2&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D74\"&gt;&lt;Name&gt;CurrencyCode&lt;/Name&gt;&lt;Desc&gt;Currency Code&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;USD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D141\"&gt;&lt;Name&gt;ClientIP&lt;/Name&gt;&lt;Desc&gt;IP Address&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;63.117.2.51&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D168\"&gt;&lt;Name&gt;CardHolderAttendance&lt;/Name&gt;&lt;Desc&gt;Card holder attendance&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;ECommerce&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D539\"&gt;&lt;Name&gt;TransactionInitiation&lt;/Name&gt;&lt;Desc&gt;Transaction Initiation indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Merchant&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D542\"&gt;&lt;Name&gt;CCEntryIndicator&lt;/Name&gt;&lt;Desc&gt;Credit card entry indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Entered&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D543\"&gt;&lt;Name&gt;POSEntryMode&lt;/Name&gt;&lt;Desc&gt;POS Entry Mode&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D550\"&gt;&lt;Name&gt;PayFabricTransactionKey&lt;/Name&gt;&lt;Desc&gt;The PayFabric Transaction Key associated to this Payment Request.&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;22052501048797&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D19\"&gt;&lt;Name&gt;PaymentType&lt;/Name&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D2\"&gt;&lt;Name&gt;TRXFIELD_D2&lt;/Name&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D54\"&gt;&lt;Name&gt;AccountName&lt;/Name&gt;&lt;Value&gt;123 tes dd &lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"SaveCreditCard\"&gt;&lt;Name&gt;SaveCreditCard&lt;/Name&gt;&lt;Value&gt;0&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_PFTrxKey\"&gt;&lt;Name&gt;MSO_PFTrxKey&lt;/Name&gt;&lt;Value&gt;22052501048797&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_WalletID\"&gt;&lt;Name&gt;MSO_WalletID&lt;/Name&gt;&lt;Value&gt;00000000-0000-0000-0000-000000000000&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_EngineGUID\"&gt;&lt;Name&gt;MSO_EngineGUID&lt;/Name&gt;&lt;Value&gt;4f76bfce-6d2d-4a20-a7b8-5ba0f363e090&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D540\"&gt;&lt;Name&gt;TransactionSchedule&lt;/Name&gt;&lt;Value&gt;Unscheduled&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D541\"&gt;&lt;Name&gt;AuthorizationType&lt;/Name&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Date\"&gt;&lt;Name&gt;MSO_Last_Xmit_Date&lt;/Name&gt;&lt;Value&gt;2022-05-25 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Time\"&gt;&lt;Name&gt;MSO_Last_Xmit_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 11:11:17 PM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Date\"&gt;&lt;Name&gt;MSO_Last_Settled_Date&lt;/Name&gt;&lt;Value&gt;1900-01-01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Time\"&gt;&lt;Name&gt;MSO_Last_Settled_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/RequestData&gt;&lt;/Transaction&gt;&lt;/TransactionData&gt;",
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
    "SetupId": "EVO US_CC",
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
        "TAXml": "&lt;TransactionData&gt;&lt;Connection name=\"EVO\" connector=\"EVO\"&gt;&lt;Processor id=\"1\"&gt;Evo US&lt;/Processor&gt;&lt;PaymentType id=\"1\"&gt;Credit&lt;/PaymentType&gt;&lt;/Connection&gt;&lt;Transaction post=\"False\" type=\"1\" status=\"1\"&gt;&lt;NeededData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;NeededData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/NeededData&gt;&lt;FailureData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;FailureData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/FailureData&gt;&lt;ResponseData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;ResponseData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D625\"&gt;&lt;Name&gt;WebRequestExecutionDuration&lt;/Name&gt;&lt;Desc&gt;1296.8765&lt;/Desc&gt;&lt;Value&gt;1296.8765&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D83\"&gt;&lt;Name&gt;CVV2ResponseCode&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D24\"&gt;&lt;Name&gt;AuthCode&lt;/Name&gt;&lt;Desc&gt;7KASMC&lt;/Desc&gt;&lt;Value&gt;7KASMC&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D545\"&gt;&lt;Name&gt;ResponseBatchID&lt;/Name&gt;&lt;Desc&gt;2226&lt;/Desc&gt;&lt;Value&gt;2226&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D573\"&gt;&lt;Name&gt;ProcessedAs3D&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D599\"&gt;&lt;Name&gt;ThreeDSInfoRespIsChallengeMandated&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D601\"&gt;&lt;Name&gt;ThreeDSInfoRespAuthenticationType&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D604\"&gt;&lt;Name&gt;ThreeDSInfoRespMessageCategory&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D606\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatus&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D607\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatusReason&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D616\"&gt;&lt;Name&gt;ThreeDsRespSCARequired&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D617\"&gt;&lt;Name&gt;ThreeDsRespExemptionControl&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D619\"&gt;&lt;Name&gt;ThreeDsRespAuthenticationMethod&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D621\"&gt;&lt;Name&gt;ThreeDsRespProcessedAsDataOnly&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D586\"&gt;&lt;Name&gt;ProtocolVersion&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Desc&gt;&lt;Value&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D462\"&gt;&lt;Name&gt;GatewayOriginationID&lt;/Name&gt;&lt;Desc&gt;23846746&lt;/Desc&gt;&lt;Value&gt;23846746&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D463\"&gt;&lt;Name&gt;ProcessorOriginationID&lt;/Name&gt;&lt;Desc&gt;987222&lt;/Desc&gt;&lt;Value&gt;987222&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D31\"&gt;&lt;Name&gt;ResponseMsg&lt;/Name&gt;&lt;Desc&gt;APPROVED&lt;/Desc&gt;&lt;Value&gt;APPROVED&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D17\"&gt;&lt;Name&gt;ResultCode&lt;/Name&gt;&lt;Desc&gt;1&lt;/Desc&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D464\"&gt;&lt;Name&gt;TransactionState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D465\"&gt;&lt;Name&gt;CaptureState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Desc&gt;5/26/2022 5:11:16 AM&lt;/Desc&gt;&lt;Value&gt;5/26/2022 9:11:17 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D288\"&gt;&lt;Name&gt;TransactionID&lt;/Name&gt;&lt;Desc&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Desc&gt;&lt;Value&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/ResponseData&gt;&lt;RequestData&gt;&lt;Transaction&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Status&gt;1&lt;/Status&gt;&lt;Category&gt;RequestData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D1\"&gt;&lt;Name&gt;CCNumber&lt;/Name&gt;&lt;Desc&gt;Credit Card Number, could also be a DPAN/VPAN&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D3\"&gt;&lt;Name&gt;CCExpDate&lt;/Name&gt;&lt;Desc&gt;Expiration Date MMYY&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;0123&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D5\"&gt;&lt;Name&gt;FirstName&lt;/Name&gt;&lt;Desc&gt;First Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;123 tes&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D7\"&gt;&lt;Name&gt;LastName&lt;/Name&gt;&lt;Desc&gt;Last Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;dd&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D15\"&gt;&lt;Name&gt;TrxAmount&lt;/Name&gt;&lt;Desc&gt;Transaction Amount&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;3&lt;/Type&gt;&lt;Value&gt;100.00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D18\"&gt;&lt;Name&gt;CCType&lt;/Name&gt;&lt;Desc&gt;Card Type&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Visa&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D49\"&gt;&lt;Name&gt;CVV2&lt;/Name&gt;&lt;Desc&gt;CVV2&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D74\"&gt;&lt;Name&gt;CurrencyCode&lt;/Name&gt;&lt;Desc&gt;Currency Code&lt;/Desc&gt;&lt;Required&gt;1&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;USD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D141\"&gt;&lt;Name&gt;ClientIP&lt;/Name&gt;&lt;Desc&gt;IP Address&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;63.117.2.51&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D168\"&gt;&lt;Name&gt;CardHolderAttendance&lt;/Name&gt;&lt;Desc&gt;Card holder attendance&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;ECommerce&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D539\"&gt;&lt;Name&gt;TransactionInitiation&lt;/Name&gt;&lt;Desc&gt;Transaction Initiation indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Merchant&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D542\"&gt;&lt;Name&gt;CCEntryIndicator&lt;/Name&gt;&lt;Desc&gt;Credit card entry indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Entered&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D543\"&gt;&lt;Name&gt;POSEntryMode&lt;/Name&gt;&lt;Desc&gt;POS Entry Mode&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D550\"&gt;&lt;Name&gt;PayFabricTransactionKey&lt;/Name&gt;&lt;Desc&gt;The PayFabric Transaction Key associated to this Payment Request.&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;22052501048797&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D19\"&gt;&lt;Name&gt;PaymentType&lt;/Name&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D2\"&gt;&lt;Name&gt;TRXFIELD_D2&lt;/Name&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D54\"&gt;&lt;Name&gt;AccountName&lt;/Name&gt;&lt;Value&gt;123 tes dd &lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"SaveCreditCard\"&gt;&lt;Name&gt;SaveCreditCard&lt;/Name&gt;&lt;Value&gt;0&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_PFTrxKey\"&gt;&lt;Name&gt;MSO_PFTrxKey&lt;/Name&gt;&lt;Value&gt;22052501048797&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_WalletID\"&gt;&lt;Name&gt;MSO_WalletID&lt;/Name&gt;&lt;Value&gt;00000000-0000-0000-0000-000000000000&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_EngineGUID\"&gt;&lt;Name&gt;MSO_EngineGUID&lt;/Name&gt;&lt;Value&gt;4f76bfce-6d2d-4a20-a7b8-5ba0f363e090&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D540\"&gt;&lt;Name&gt;TransactionSchedule&lt;/Name&gt;&lt;Value&gt;Unscheduled&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D541\"&gt;&lt;Name&gt;AuthorizationType&lt;/Name&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Date\"&gt;&lt;Name&gt;MSO_Last_Xmit_Date&lt;/Name&gt;&lt;Value&gt;2022-05-25 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Time\"&gt;&lt;Name&gt;MSO_Last_Xmit_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 11:11:17 PM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Date\"&gt;&lt;Name&gt;MSO_Last_Settled_Date&lt;/Name&gt;&lt;Value&gt;1900-01-01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Time\"&gt;&lt;Name&gt;MSO_Last_Settled_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/RequestData&gt;&lt;/Transaction&gt;&lt;/TransactionData&gt;",
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
|fromdate|This parameter is to set specific 'date from' to filter transactions. The format: mm/dd/yyyy and in merchant timezone. For example, merchant set the time zone as EST, and call this API by passing the fromdate = 05/20/2022, then API will return the transactions later than 2022-5-20 00:00:00 in EST.|
|page|This parameter is to set the result's page number, each page will return 15 records.|
|status|This parameter is used to filter transaction result against processed transaction's status, the possible values are: `approved`, `failure`, and `denied`. Returned result will include all transaction status if application does not submit this parameter.|
|excludeunprocess|When the value is `true`, the result will filter out the unprocess transaction. Default value is `false`. |
|pagesize|This parameter is to set specific page size, maximum value is 15.|
|enddate|This parameter is to set a specific 'date to' to filter transactions, The format: mm/dd/yyyy and in merchant timezone. For example, merchant set the time zone as EST, and call this API by passing the enddate = 05/20/2022, then API will return the transactions earlier than 2022-5-20 23:59:59 in EST. |

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
            "SetupId": "EVO US_CC",
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

When specifying an amount capture or refund, note that over-capture and refunding higher amount than the original transaction is not allowed.

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
     ] 
  }
}
</pre>
<b>Note:</b> CaptureComplete = true means this is the last capture transaction, no capture allowed for the original authorization transaction; CaptureComplete = false means this is not the last capture transaction, it allows to do multiple captures for the original authorization transaction. CaptureComplete will be set to true if pass invalid value or don't pass any value. For **EVO gateway profile**, If over capture or transactions include tip amount or incremental amount, CaptureComplete will be set to true automatically whatever the input value is. This logic is not applied with other gateways' transactions other than EVO.

#### Void

* `GET /payment/api/reference/{TransactionKey}?trxtype=VOID` or `POST /transaction/process` with following request will attempt to cancel a transaction that has already been processed successfully with a payment gateway. PayFabric attempts to reverse the transaction by submitting a VOID transaction before settlement with the bank, if cancellation is not possible a refund (credit) must be performed.

###### Request
<pre>
{
  "Type": "Void",
  "ReferenceKey": "151013003792"
}
</pre>

#### Refund（Reference)

A referenced refund will refund against an original settled payment transaction.

To issue a full refund:
> `GET /payment/api/reference/{TransactionKey}?trxtype=Refund`

The following API can also be used to issue full or partial refund:
> `POST /transaction/process`

###### Request
<pre>
{
  "Type": "Refund",
  "ReferenceKey": "151013003792"
}
</pre>

Or

<pre>
{
  "Amount":"100",
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
    "TAXml": "&lt;TransactionData&gt;&lt;Connection name=\"EVO\" connector=\"EVO\"&gt;&lt;Processor id=\"1\"&gt;Evo US&lt;/Processor&gt;&lt;PaymentType id=\"1\"&gt;Credit&lt;/PaymentType&gt;&lt;/Connection&gt;&lt;Transaction post=\"False\" type=\"6\" status=\"1\"&gt;&lt;NeededData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;NeededData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/NeededData&gt;&lt;FailureData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;FailureData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/FailureData&gt;&lt;ResponseData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;ResponseData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D625\"&gt;&lt;Name&gt;WebRequestExecutionDuration&lt;/Name&gt;&lt;Desc&gt;937.5086&lt;/Desc&gt;&lt;Value&gt;937.5086&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;13529CF98B794C51A341CED02CE06A2E&lt;/Desc&gt;&lt;Value&gt;13529CF98B794C51A341CED02CE06A2E&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D462\"&gt;&lt;Name&gt;GatewayOriginationID&lt;/Name&gt;&lt;Desc&gt;96745031&lt;/Desc&gt;&lt;Value&gt;96745031&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D463\"&gt;&lt;Name&gt;ProcessorOriginationID&lt;/Name&gt;&lt;Desc&gt;987264&lt;/Desc&gt;&lt;Value&gt;987264&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D31\"&gt;&lt;Name&gt;ResponseMsg&lt;/Name&gt;&lt;Desc&gt;APPROVED&lt;/Desc&gt;&lt;Value&gt;APPROVED&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D17\"&gt;&lt;Name&gt;ResultCode&lt;/Name&gt;&lt;Desc&gt;1&lt;/Desc&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D464\"&gt;&lt;Name&gt;TransactionState&lt;/Name&gt;&lt;Desc&gt;Returned&lt;/Desc&gt;&lt;Value&gt;Returned&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D465\"&gt;&lt;Name&gt;CaptureState&lt;/Name&gt;&lt;Desc&gt;CapturedUndoPermitted&lt;/Desc&gt;&lt;Value&gt;CapturedUndoPermitted&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Desc&gt;5/26/2022 5:27:50 AM&lt;/Desc&gt;&lt;Value&gt;5/26/2022 9:27:51 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D288\"&gt;&lt;Name&gt;TransactionID&lt;/Name&gt;&lt;Desc&gt;13529CF98B794C51A341CED02CE06A2E&lt;/Desc&gt;&lt;Value&gt;13529CF98B794C51A341CED02CE06A2E&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/ResponseData&gt;&lt;RequestData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;1&lt;/Status&gt;&lt;Category&gt;RequestData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D1\"&gt;&lt;Name&gt;CCNumber&lt;/Name&gt;&lt;Desc&gt;Credit Card Number, could also be a DPAN/VPAN&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D3\"&gt;&lt;Name&gt;CCExpDate&lt;/Name&gt;&lt;Desc&gt;Expiration Date MMYY&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;0123&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D5\"&gt;&lt;Name&gt;FirstName&lt;/Name&gt;&lt;Desc&gt;First Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;123 tes&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D7\"&gt;&lt;Name&gt;LastName&lt;/Name&gt;&lt;Desc&gt;Last Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;dd&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D15\"&gt;&lt;Name&gt;TrxAmount&lt;/Name&gt;&lt;Desc&gt;Transaction Amount&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;3&lt;/Type&gt;&lt;Value&gt;100.00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;Origination ID&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;B41325DBCF4A411F91861AECEBEF6E17&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D18\"&gt;&lt;Name&gt;CCType&lt;/Name&gt;&lt;Desc&gt;Card Type&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Visa&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D74\"&gt;&lt;Name&gt;CurrencyCode&lt;/Name&gt;&lt;Desc&gt;Currency Code&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;USD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D141\"&gt;&lt;Name&gt;ClientIP&lt;/Name&gt;&lt;Desc&gt;IP Address&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;63.117.2.51&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D168\"&gt;&lt;Name&gt;CardHolderAttendance&lt;/Name&gt;&lt;Desc&gt;Card holder attendance&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;ECommerce&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D539\"&gt;&lt;Name&gt;TransactionInitiation&lt;/Name&gt;&lt;Desc&gt;Transaction Initiation indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Merchant&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D542\"&gt;&lt;Name&gt;CCEntryIndicator&lt;/Name&gt;&lt;Desc&gt;Credit card entry indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Entered&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D543\"&gt;&lt;Name&gt;POSEntryMode&lt;/Name&gt;&lt;Desc&gt;POS Entry Mode&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D550\"&gt;&lt;Name&gt;PayFabricTransactionKey&lt;/Name&gt;&lt;Desc&gt;The PayFabric Transaction Key associated to this Payment Request.&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;22052501048810&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D19\"&gt;&lt;Name&gt;PaymentType&lt;/Name&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D24\"&gt;&lt;Name&gt;AuthCode&lt;/Name&gt;&lt;Value&gt;7KASMC&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Value&gt;5/26/2022 5:11:16 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D2\"&gt;&lt;Name&gt;TRXFIELD_D2&lt;/Name&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D54\"&gt;&lt;Name&gt;AccountName&lt;/Name&gt;&lt;Value&gt;123 tes dd &lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"SaveCreditCard\"&gt;&lt;Name&gt;SaveCreditCard&lt;/Name&gt;&lt;Value&gt;0&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_PFTrxKey\"&gt;&lt;Name&gt;MSO_PFTrxKey&lt;/Name&gt;&lt;Value&gt;22052501048810&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_WalletID\"&gt;&lt;Name&gt;MSO_WalletID&lt;/Name&gt;&lt;Value&gt;00000000-0000-0000-0000-000000000000&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_EngineGUID\"&gt;&lt;Name&gt;MSO_EngineGUID&lt;/Name&gt;&lt;Value&gt;4f76bfce-6d2d-4a20-a7b8-5ba0f363e090&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D540\"&gt;&lt;Name&gt;TransactionSchedule&lt;/Name&gt;&lt;Value&gt;Unscheduled&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D541\"&gt;&lt;Name&gt;AuthorizationType&lt;/Name&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Date\"&gt;&lt;Name&gt;MSO_Last_Xmit_Date&lt;/Name&gt;&lt;Value&gt;2022-05-25 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Time\"&gt;&lt;Name&gt;MSO_Last_Xmit_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 11:27:51 PM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Date\"&gt;&lt;Name&gt;MSO_Last_Settled_Date&lt;/Name&gt;&lt;Value&gt;1900-01-01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Time\"&gt;&lt;Name&gt;MSO_Last_Settled_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/RequestData&gt;&lt;/Transaction&gt;&lt;/TransactionData&gt;",
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

Without referencing an original payment transaction to refund against, a non-referenced refund can processed in the same manner as processing a normal transaction with `Type` set to `Refund`:
* Invoke [Create and Process a Transaction](#create-and-process-a-transaction) API to submit and process the transaction.
  > `POST /payment/api/transaction/process?cvc={CVCValue}`

###### Request
<pre>
{
    "SetupId": "EVO US_CC",
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
    "TAXml": "&lt;TransactionData&gt;&lt;Connection name=\"EVO\" connector=\"EVO\"&gt;&lt;Processor id=\"1\"&gt;Evo US&lt;/Processor&gt;&lt;PaymentType id=\"1\"&gt;Credit&lt;/PaymentType&gt;&lt;/Connection&gt;&lt;Transaction post=\"False\" type=\"6\" status=\"1\"&gt;&lt;NeededData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;NeededData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/NeededData&gt;&lt;FailureData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;FailureData&lt;/Category&gt;&lt;Fields /&gt;&lt;/Transaction&gt;&lt;/FailureData&gt;&lt;ResponseData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;Approved&lt;/Status&gt;&lt;Category&gt;ResponseData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D625\"&gt;&lt;Name&gt;WebRequestExecutionDuration&lt;/Name&gt;&lt;Desc&gt;1281.2611&lt;/Desc&gt;&lt;Value&gt;1281.2611&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D83\"&gt;&lt;Name&gt;CVV2ResponseCode&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D24\"&gt;&lt;Name&gt;AuthCode&lt;/Name&gt;&lt;Desc /&gt;&lt;Value&gt;&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D545\"&gt;&lt;Name&gt;ResponseBatchID&lt;/Name&gt;&lt;Desc&gt;2226&lt;/Desc&gt;&lt;Value&gt;2226&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D573\"&gt;&lt;Name&gt;ProcessedAs3D&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D599\"&gt;&lt;Name&gt;ThreeDSInfoRespIsChallengeMandated&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D601\"&gt;&lt;Name&gt;ThreeDSInfoRespAuthenticationType&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D604\"&gt;&lt;Name&gt;ThreeDSInfoRespMessageCategory&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D606\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatus&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D607\"&gt;&lt;Name&gt;ThreeDSInfoRespTransactionStatusReason&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D616\"&gt;&lt;Name&gt;ThreeDsRespSCARequired&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D617\"&gt;&lt;Name&gt;ThreeDsRespExemptionControl&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D619\"&gt;&lt;Name&gt;ThreeDsRespAuthenticationMethod&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D621\"&gt;&lt;Name&gt;ThreeDsRespProcessedAsDataOnly&lt;/Name&gt;&lt;Desc&gt;False&lt;/Desc&gt;&lt;Value&gt;False&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D586\"&gt;&lt;Name&gt;ProtocolVersion&lt;/Name&gt;&lt;Desc&gt;NotSet&lt;/Desc&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D16\"&gt;&lt;Name&gt;OriginationID&lt;/Name&gt;&lt;Desc&gt;FC831CCC776D46DA93739A6D4BFBEE6D&lt;/Desc&gt;&lt;Value&gt;FC831CCC776D46DA93739A6D4BFBEE6D&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D462\"&gt;&lt;Name&gt;GatewayOriginationID&lt;/Name&gt;&lt;Desc&gt;41803231&lt;/Desc&gt;&lt;Value&gt;41803231&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D463\"&gt;&lt;Name&gt;ProcessorOriginationID&lt;/Name&gt;&lt;Desc&gt;987272&lt;/Desc&gt;&lt;Value&gt;987272&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D31\"&gt;&lt;Name&gt;ResponseMsg&lt;/Name&gt;&lt;Desc&gt;APPROVED&lt;/Desc&gt;&lt;Value&gt;APPROVED&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D17\"&gt;&lt;Name&gt;ResultCode&lt;/Name&gt;&lt;Desc&gt;1&lt;/Desc&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D464\"&gt;&lt;Name&gt;TransactionState&lt;/Name&gt;&lt;Desc&gt;Returned&lt;/Desc&gt;&lt;Value&gt;Returned&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D465\"&gt;&lt;Name&gt;CaptureState&lt;/Name&gt;&lt;Desc&gt;Captured&lt;/Desc&gt;&lt;Value&gt;Captured&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D76\"&gt;&lt;Name&gt;TrxDate&lt;/Name&gt;&lt;Desc&gt;5/26/2022 5:30:43 AM&lt;/Desc&gt;&lt;Value&gt;5/26/2022 9:30:44 AM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D288\"&gt;&lt;Name&gt;TransactionID&lt;/Name&gt;&lt;Desc&gt;FC831CCC776D46DA93739A6D4BFBEE6D&lt;/Desc&gt;&lt;Value&gt;FC831CCC776D46DA93739A6D4BFBEE6D&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/ResponseData&gt;&lt;RequestData&gt;&lt;Transaction&gt;&lt;Type&gt;6&lt;/Type&gt;&lt;Status&gt;1&lt;/Status&gt;&lt;Category&gt;RequestData&lt;/Category&gt;&lt;Fields&gt;&lt;Field id=\"TrxField_D1\"&gt;&lt;Name&gt;CCNumber&lt;/Name&gt;&lt;Desc&gt;Credit Card Number, could also be a DPAN/VPAN&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D3\"&gt;&lt;Name&gt;CCExpDate&lt;/Name&gt;&lt;Desc&gt;Expiration Date MMYY&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;0123&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D5\"&gt;&lt;Name&gt;FirstName&lt;/Name&gt;&lt;Desc&gt;First Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;123 tes&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D7\"&gt;&lt;Name&gt;LastName&lt;/Name&gt;&lt;Desc&gt;Last Name&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;dd&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D15\"&gt;&lt;Name&gt;TrxAmount&lt;/Name&gt;&lt;Desc&gt;Transaction Amount&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;3&lt;/Type&gt;&lt;Value&gt;100.00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D18\"&gt;&lt;Name&gt;CCType&lt;/Name&gt;&lt;Desc&gt;Card Type&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Visa&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D49\"&gt;&lt;Name&gt;CVV2&lt;/Name&gt;&lt;Desc&gt;CVV2&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;1&lt;/Type&gt;&lt;Value&gt;&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D74\"&gt;&lt;Name&gt;CurrencyCode&lt;/Name&gt;&lt;Desc&gt;Currency Code&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;USD&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D141\"&gt;&lt;Name&gt;ClientIP&lt;/Name&gt;&lt;Desc&gt;IP Address&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;63.117.2.51&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D168\"&gt;&lt;Name&gt;CardHolderAttendance&lt;/Name&gt;&lt;Desc&gt;Card holder attendance&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;ECommerce&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D539\"&gt;&lt;Name&gt;TransactionInitiation&lt;/Name&gt;&lt;Desc&gt;Transaction Initiation indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Merchant&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D542\"&gt;&lt;Name&gt;CCEntryIndicator&lt;/Name&gt;&lt;Desc&gt;Credit card entry indicator&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;Entered&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D543\"&gt;&lt;Name&gt;POSEntryMode&lt;/Name&gt;&lt;Desc&gt;POS Entry Mode&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TrxField_D550\"&gt;&lt;Name&gt;PayFabricTransactionKey&lt;/Name&gt;&lt;Desc&gt;The PayFabric Transaction Key associated to this Payment Request.&lt;/Desc&gt;&lt;Required&gt;0&lt;/Required&gt;&lt;Encrypted&gt;0&lt;/Encrypted&gt;&lt;Type&gt;10&lt;/Type&gt;&lt;Value&gt;22052501048813&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D19\"&gt;&lt;Name&gt;PaymentType&lt;/Name&gt;&lt;Value&gt;1&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D2\"&gt;&lt;Name&gt;TRXFIELD_D2&lt;/Name&gt;&lt;Value&gt;XXXXXXXXXXXX1111&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D54\"&gt;&lt;Name&gt;AccountName&lt;/Name&gt;&lt;Value&gt;123 tes dd &lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"SaveCreditCard\"&gt;&lt;Name&gt;SaveCreditCard&lt;/Name&gt;&lt;Value&gt;0&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_PFTrxKey\"&gt;&lt;Name&gt;MSO_PFTrxKey&lt;/Name&gt;&lt;Value&gt;22052501048813&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_WalletID\"&gt;&lt;Name&gt;MSO_WalletID&lt;/Name&gt;&lt;Value&gt;00000000-0000-0000-0000-000000000000&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_EngineGUID\"&gt;&lt;Name&gt;MSO_EngineGUID&lt;/Name&gt;&lt;Value&gt;4f76bfce-6d2d-4a20-a7b8-5ba0f363e090&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D540\"&gt;&lt;Name&gt;TransactionSchedule&lt;/Name&gt;&lt;Value&gt;Unscheduled&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"TRXFIELD_D541\"&gt;&lt;Name&gt;AuthorizationType&lt;/Name&gt;&lt;Value&gt;NotSet&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Date\"&gt;&lt;Name&gt;MSO_Last_Xmit_Date&lt;/Name&gt;&lt;Value&gt;2022-05-25 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Xmit_Time\"&gt;&lt;Name&gt;MSO_Last_Xmit_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 11:30:44 PM&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Date\"&gt;&lt;Name&gt;MSO_Last_Settled_Date&lt;/Name&gt;&lt;Value&gt;1900-01-01&lt;/Value&gt;&lt;/Field&gt;&lt;Field id=\"MSO_Last_Settled_Time\"&gt;&lt;Name&gt;MSO_Last_Settled_Time&lt;/Name&gt;&lt;Value&gt;1900-01-01 00:00:00&lt;/Value&gt;&lt;/Field&gt;&lt;/Fields&gt;&lt;/Transaction&gt;&lt;/RequestData&gt;&lt;/Transaction&gt;&lt;/TransactionData&gt;",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "100.00",
    "TrxDate": "5/26/2022 9:30:44 AM",
    "TrxDateUTC": "2022-05-26T06:30:44.143Z",
    "TrxKey": "22052501048813",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>
