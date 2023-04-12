Reference Sale or Authorization Transactions
===========================================

The PayFabric provided the ablity to perform referenced 'Sale' or 'Authorization' transaction against previous successful transaction on PayFabric without having to re-enter the credit card information. This is to cater the business use case for eCommerce business where the end-customer did not checkmark 'Save for later use' during the checkout process. Without the card being saved, if the shipment has to be split due to backordered or out-of-stock inventory, the merchant have to reach out back to the end-user to ask for their card information to re-authorization for the remaining backordered goods for later shipment.

Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create and Process a Transaction
--------------------------------

* `POST /payment/api/transaction/process?cvc={CVCValue}` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload. `cvc` is optional.

###### Request for create and process a Sale/Authorization transaction by using an existing approved transaction as a reference
<pre>
{

    "<b>ReferenceKey</b>": "<b>Ref23040701258785</b>",
    "<b>Type</b>": "<b>book</b>",
    "Amount":"10",
     "Shipto": {
            "City": "LA",
            "Country": "UK",
            "Customer": "",
            "Email": "test@email.com",
            "ID": "00000000-0000-0000-0000-000000000000",
            "Line1": "5000",
            "Line2": "1",
            "Line3": "d",
            "Phone": "1111111111",
            "State": "LA",
            "Zip": "12345"
    },
    "Document": {
    "Head": [],
    "Lines": [],
    "UserDefined": []
  }
}
</pre>


Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md). 

PayFabric support to create wallet either from [API](Wallets.md) or [Hosted Wallet Page](https://github.com/PayFabric/Hosted-Pages/blob/master/Sections/Wallet%20Page.md), we highly recommand use hosted wallet page to create wallet for security, and get the wallet ID through [Wallet Retrieve](Wallets.md#retrieve-credit-cards--echecks) API call.

###### Related Reading
* [How to Submit Level 2 and 3 Fields](Level%202%20and%20Level%203%20Fields.md)
* [Which Transaction Type to Use](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transaction%20Types.md)
* [Create and Process an eCheck Transaction](Process%20eCheck%20Transaction.md#create-and-process-a-echeck-transaction)
* [Create and Process a reference sale/authorization Transaction by Using an Existing Approved Transaction as a Reference]()


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

