Process a Gift Card Transaction
============

The PayFabric Transactions API support Gift Card gateway, click [here](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Gateway%20Configuration.md) for supported gateways. Please make sure an EVO Gift [Gateway Profile](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) must be created before process an EVO Gift transaction. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create a Gift Card Transaction
--------------------

* `POST /transaction/create` will create and save a transaction with Gift Card into PayFabric based on the request JSON payload

###### Request for sale
<pre>
{
  <b>"Amount": "29.99"</b>,  
  "Card": {
    "Account": "41111111111"    
    },    
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001", 
  <b>"SetupId": "Evo Gift"</b>,
  "Shipto": {
    "City": "Anaheim",
    "Country": "US",   
    "Email": "email@sample.com",
    "Line1": "123 test",
    "Line2": "",
    "Line3": "",
    "Phone": "1234567890",
    "State": "CA",
    "Zip": "12345"
  }, 
  <b>"Type": "Sale"</b>
}
</pre>

###### Request for Activate
<pre>
{
  <b>"Amount": "29.99"</b>,  
  "Card": {
    "Account": "41111111111"    
    },    
  "Currency": "USD",
  "Customer": "JOHNDOE0001", 
  <b>"SetupId": "Evo Gift"</b>, 
  <b>"Type": "Activate"</b>
}
</pre>

###### Request for Reload
<pre>
{
  <b>"Amount": "100"</b>,  
  "Card": {
    "Account": "41111111111"    
    },    
  "Currency": "USD",
  "Customer": "JOHNDOE0001", 
  <b>"SetupId": "Evo Gift"</b>, 
  <b>"Type": "Reload"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](Objects.md#transaction).

###### Response
<pre>
{
    "Key": "22052501047735"
}
</pre>


Update a Gift Card Transaction
--------------------

* `POST /transaction/update` will update a transaction with new information based on the request JSON payload

###### Request
<pre>
{
    "Key": "22052501047735"
}
</pre>

Please note that the **Key** field is the only required field for an update. Only the fields that need updating should be included, see the **Create a Gift Card Transaction** request for more information.

###### Response
<pre>
{
  "Result": "True"
}
</pre>


Process a Gift Card Transaction
---------------------

* `GET /transaction/process/22052501047735?CVC=123` will attempt to process the transaction with the payment gateway

###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": "0PHBUR",
    "CVV2Response": null,
    "CardType": "",
    "ExpectedSettledTime": null,
    "ExpectedSettledTimeUTC": null,
    "FinalAmount": "29.99",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "29.99",
    "OriginationID": "2433FF4FB6F8425F8690C47517E4C520",
    "PayFabricErrorCode": null,
    "RemainingBalance": "1.00",
    "RespTrxTag": null,
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO GIFT\" connector=\"EVO\"><Processor id=\"3\">Evo Gift</Processor><PaymentType id=\"6\">GiftCard</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>1727.1506</Desc><Value>1727.1506</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>0PHBUR</Desc><Value>0PHBUR</Value></Field><Field id=\"TrxField_D187\"><Name>CurrentBalance</Name><Desc>1.00</Desc><Value>1.00</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>2433FF4FB6F8425F8690C47517E4C520</Desc><Value>2433FF4FB6F8425F8690C47517E4C520</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc /><Value></Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>984978</Desc><Value>984978</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>2433FF4FB6F8425F8690C47517E4C520</Desc><Value>2433FF4FB6F8425F8690C47517E4C520</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0000</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>29.99</Value></Field><Field id=\"TrxField_D41\"><Name>ShipToZip</Name><Desc>Ship to Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>12345</Value></Field><Field id=\"TrxField_D48\"><Name>CustomerCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>JOHNDOE0001</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D99\"><Name>ShipToCity</Name><Desc>Shipping City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D103\"><Name>ShipToState</Name><Desc>Shipping State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D104\"><Name>ShipToStreet</Name><Desc>Shipping Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 test </Value></Field><Field id=\"TrxField_D155\"><Name>ShipToPhone</Name><Desc>Shipping Phone</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1234567890</Value></Field><Field id=\"TrxField_D202\"><Name>ShipToEmail</Name><Desc>Shipping email.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>email@sample.com</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>6</Value></Field><Field id=\"TRXFIELD_D60\"><Name>AccountNumber</Name><Value>xxxxxxx1111</Value></Field><Field id=\"EncryptAccount\"><Name>EncryptAccount</Name><Value>96CB7CAC57D86267EF3FC1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D18\"><Name>CCType</Name><Value>GiftCard</Value></Field><Field id=\"TRXFIELD_D111\"><Name>ShipToCountry</Name><Value>US</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501047735</Value></Field><Field id=\"TRXFIELD_D550\"><Name>PF_TransactionKey</Name><Value>22052501047735</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>2f7170cd-6e9f-4c9e-9737-881695e542c1</Value></Field><Field id=\"TRXFIELD_D539\"><Name>TransactionInitiation</Name><Value>Merchant</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"TRXFIELD_D542\"><Name>CCEntryIndicator</Name><Value>Entered</Value></Field><Field id=\"TRXFIELD_D168\"><Name>CardHolderAttendance</Name><Value>ECommerce</Value></Field><Field id=\"TRXFIELD_D141\"><Name>ClientIP</Name><Value>63.117.2.51</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 3:11:58 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "29.99",
    "TrxDate": "5/25/2022 1:11:58 PM",
    "TrxDateUTC": "2022-05-25T10:11:58.357Z",
    "TrxKey": "22052501047735",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>

Create and Process a Sale Gift Card Transaction
--------------------------------

* `POST /transaction/process?CVC=123` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload, Please refer the [Request](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/ProcessGiftCardTransaction.md#request-for-activate) for `Activate` Transaction and [Request](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/ProcessGiftCardTransaction.md#request-for-reload) for `Reload` Transaction.

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,  
  "Card": {
    "Account": "41111111111"    
    },    
  <b>"Currency": "USD"</b>,
  "Customer": "JOHNDOE0001", 
  <b>"SetupId": "Evo Gift"</b>,
  "Shipto": {
    "City": "Anaheim",
    "Country": "US",   
    "Email": "email@sample.com",
    "Line1": "123 test",
    "Line2": "",
    "Line3": "",
    "Phone": "1234567890",
    "State": "CA",
    "Zip": "12345"
  }, 
  <b>"Type": "Sale"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional, for more information on available payment *Card* object, please see our [object reference](https://github.com/PayFabric/APIs/blob/R19/PayFabric/Sections/Objects.md#card).

###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": "M7DWK0",
    "CVV2Response": null,
    "CardType": "",
    "ExpectedSettledTime": null,
    "ExpectedSettledTimeUTC": null,
    "FinalAmount": "29.99",
    "IAVSAddressResponse": null,
    "Message": "APPROVED",
    "OrigTrxAmount": "29.99",
    "OriginationID": "567979CB59A3457C99B6BCD5F63F7D6D",
    "PayFabricErrorCode": null,
    "RemainingBalance": "1.00",
    "RespTrxTag": null,
    "ResultCode": "1",
    "SettledTime": null,
    "SettledTimeUTC": null,
    "Status": "Approved",
    "SurchargeAmount": "0.00",
    "SurchargePercentage": "0.00",
    "TAXml": "<TransactionData><Connection name=\"EVO GIFT\" connector=\"EVO\"><Processor id=\"3\">Evo Gift</Processor><PaymentType id=\"6\">GiftCard</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D625\"><Name>WebRequestExecutionDuration</Name><Desc>718.7506</Desc><Value>718.7506</Value></Field><Field id=\"TrxField_D24\"><Name>AuthCode</Name><Desc>M7DWK0</Desc><Value>M7DWK0</Value></Field><Field id=\"TrxField_D187\"><Name>CurrentBalance</Name><Desc>1.00</Desc><Value>1.00</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>567979CB59A3457C99B6BCD5F63F7D6D</Desc><Value>567979CB59A3457C99B6BCD5F63F7D6D</Value></Field><Field id=\"TrxField_D462\"><Name>GatewayOriginationID</Name><Desc /><Value></Value></Field><Field id=\"TrxField_D463\"><Name>ProcessorOriginationID</Name><Desc>984968</Desc><Value>984968</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>APPROVED</Desc><Value>APPROVED</Value></Field><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>1</Desc><Value>1</Value></Field><Field id=\"TrxField_D464\"><Name>TransactionState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D465\"><Name>CaptureState</Name><Desc>Captured</Desc><Value>Captured</Value></Field><Field id=\"TrxField_D288\"><Name>TransactionID</Name><Desc>567979CB59A3457C99B6BCD5F63F7D6D</Desc><Value>567979CB59A3457C99B6BCD5F63F7D6D</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D1\"><Name>CCNumber</Name><Desc>Credit Card Number, could also be a DPAN/VPAN</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>XXXXXXX1111</Value></Field><Field id=\"TrxField_D3\"><Name>CCExpDate</Name><Desc>Expiration Date MMYY</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>1</Type><Value>0000</Value></Field><Field id=\"TrxField_D15\"><Name>TrxAmount</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>29.99</Value></Field><Field id=\"TrxField_D41\"><Name>ShipToZip</Name><Desc>Ship to Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>12345</Value></Field><Field id=\"TrxField_D48\"><Name>CustomerCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>JOHNDOE0001</Value></Field><Field id=\"TrxField_D74\"><Name>CurrencyCode</Name><Desc>Currency Code</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>10</Type><Value>USD</Value></Field><Field id=\"TrxField_D99\"><Name>ShipToCity</Name><Desc>Shipping City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D103\"><Name>ShipToState</Name><Desc>Shipping State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>CA</Value></Field><Field id=\"TrxField_D104\"><Name>ShipToStreet</Name><Desc>Shipping Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>123 test </Value></Field><Field id=\"TrxField_D155\"><Name>ShipToPhone</Name><Desc>Shipping Phone</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>1234567890</Value></Field><Field id=\"TrxField_D202\"><Name>ShipToEmail</Name><Desc>Shipping email.</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>email@sample.com</Value></Field><Field id=\"TrxField_D543\"><Name>POSEntryMode</Name><Desc>POS Entry Mode</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>10</Type><Value>01</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>6</Value></Field><Field id=\"TRXFIELD_D60\"><Name>AccountNumber</Name><Value>xxxxxxx1111</Value></Field><Field id=\"EncryptAccount\"><Name>EncryptAccount</Name><Value>96CB7CAC57D86267EF3FC1</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXXX1111</Value></Field><Field id=\"TRXFIELD_D18\"><Name>CCType</Name><Value>GiftCard</Value></Field><Field id=\"TRXFIELD_D111\"><Name>ShipToCountry</Name><Value>US</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>22052501047736</Value></Field><Field id=\"TRXFIELD_D550\"><Name>PF_TransactionKey</Name><Value>22052501047736</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>2f7170cd-6e9f-4c9e-9737-881695e542c1</Value></Field><Field id=\"TRXFIELD_D539\"><Name>TransactionInitiation</Name><Value>Merchant</Value></Field><Field id=\"TRXFIELD_D540\"><Name>TransactionSchedule</Name><Value>Unscheduled</Value></Field><Field id=\"TRXFIELD_D541\"><Name>AuthorizationType</Name><Value>NotSet</Value></Field><Field id=\"TRXFIELD_D542\"><Name>CCEntryIndicator</Name><Value>Entered</Value></Field><Field id=\"TRXFIELD_D168\"><Name>CardHolderAttendance</Name><Value>ECommerce</Value></Field><Field id=\"TRXFIELD_D141\"><Name>ClientIP</Name><Value>63.117.2.51</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2022-05-25 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 3:03:47 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxAmount": "29.99",
    "TrxDate": "5/25/2022 1:03:47 PM",
    "TrxDateUTC": "2022-05-25T10:03:47.637Z",
    "TrxKey": "22052501047736",
    "WalletID": "00000000-0000-0000-0000-000000000000"
}
</pre>

Void Gift Card Transaction
--------------------------------
To void a gift card transaction, you can use the same way as void a credit card transaction, please refer [Void](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Transactions.md#void) for details.
