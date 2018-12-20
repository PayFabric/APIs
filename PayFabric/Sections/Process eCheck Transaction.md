Process an eCheck Transaction
============

The PayFabric Transactions API support electronic check/ACH of multiple gateways, click [here](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Gateway%20Configuration.md) for supported gateways. Please make sure an eCheck [Gateway Profile](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) must be created before process an eCheck/ACH transaction. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Create an eCheck Transaction
--------------------

* `POST /transaction/create` will create and save a transaction with eCheck to the PayFabric server based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  "Card": {
    "Account": "1234567830",
    "Aba": "031200730",
    "Billto": {
      "City": "Anaheim",
      "Country": "USA",
      "Email": "",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "Phone": "(123)456-7890",
      "State": "CA",
      "Zip": "92806"
    },
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "John",
      "LastName": "Doe",
      "MiddleName": "",
      "SSN": ""
    },
    "Customer": "JOHNDOE0001",
    "GPAddressCode": "",
    "GatewayToken": "",
    "Identifier": "",
    "IsDefaultCard": false,
    "IssueNumber": "",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
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
  <b>"SetupId": "PFPeCheck"</b>,
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

###### Response
<pre>
{
  "Key": "151013003794"
}
</pre>


Update an eCheck Transaction
--------------------

* `POST /transaction/update` will update a transaction with new information based on the request JSON payload

###### Request
<pre>
{
    "Key": "151013003793"
}
</pre>

Please note that the **Key** field is the only required field for an update. Only the fields that need updating should be included, see the **Create a eCheck Transaction** endpoint for more information.

###### Response
<pre>
{
  "Result": "True"
}
</pre>


Process an eCheck Transaction
---------------------

* `GET /transaction/process/18103000208029` will attempt to process the transaction with the payment gateway

###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": null,
    "CVV2Response": null,
    "IAVSAddressResponse": null,
    "Message": "Approved",
    "OriginationID": "A1ADACCCD7AC",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "Status": "Approved",
    "TAXml": "<TransactionData><Connection name=\"PFPeCheck\" connector=\"PayflowPro\"><Processor id=\"20\">Norwest</Processor><PaymentType id=\"3\">ECheck</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>0</Desc><Value>0</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>Approved</Desc><Value>Approved</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>A1ADACCCD7AC</Desc><Value>A1ADACCCD7AC</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D5\"><Name>BillToFirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>John</Value></Field><Field id=\"TrxField_D7\"><Name>BillToLastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>Doe</Value></Field><Field id=\"TrxField_D11\"><Name>BillToCity</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>Anaheim</Value></Field><Field id=\"TrxField_D12\"><Name>BillToState</Name><Desc>State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>CA</Value></Field><Field id=\"TrxField_D13\"><Name>BillToZip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>92806</Value></Field><Field id=\"TrxField_D15\"><Name>Amt</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>29.99</Value></Field><Field id=\"TrxField_D47\"><Name>BillToCountry</Name><Desc>Country Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>USA</Value></Field><Field id=\"TrxField_D48\"><Name>CustCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>JOHNDOE0001</Value></Field><Field id=\"TrxField_D54\"><Name>NAME</Name><Desc>Account Holder Name</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>2</Type><Value>John Doe</Value></Field><Field id=\"TrxField_D55\"><Name>BillToStreet</Name><Desc>Account Holder Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>123 PayFabric Way </Value></Field><Field id=\"TrxField_D59\"><Name>ABA</Name><Desc>ABA Routing Number</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>1</Type><Value>xxxxx0730</Value></Field><Field id=\"TrxField_D60\"><Name>ACCT</Name><Desc>Account Number</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>1</Type><Value>xxxxxx7830</Value></Field><Field id=\"TrxField_D61\"><Name>ACCTTYPE</Name><Desc>Account Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>0</Type><Value>Checking</Value><Options><Option id=\"C\"><Desc>Checking</Desc></Option><Option id=\"S\"><Desc>Savings</Desc></Option></Options></Field><Field id=\"TrxField_D88\"><Name>AUTHTYPE</Name><Desc>Authorization Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>WEB</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>3</Value></Field><Field id=\"TRXFIELD_D74\"><Name>CurrencyCode</Name><Value>USD</Value></Field><Field id=\"EncryptAccount\"><Name>EncryptAccount</Name><Value>93C87EA953DF646EED3E</Value></Field><Field id=\"TRXFIELD_D1\"><Name>CCNumber</Name><Value>XXXXXX7830</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXX7830</Value></Field><Field id=\"TRXFIELD_D3\"><Name>CCExpDate</Name><Value>0000</Value></Field><Field id=\"EncryptRouting\"><Name>EncryptRouting</Name><Value>92C97CAF56D96465EE</Value></Field><Field id=\"MSO_CardName\"><Name>MSO_CardName</Name><Value>eCheck</Value></Field><Field id=\"TRXFIELD_D18\"><Name>CCType</Name><Value>ECheck</Value></Field><Field id=\"TRXFIELD_D8\"><Name>Address1</Name><Value>123 PayFabric Way</Value></Field><Field id=\"TRXFIELD_D78\"><Name>Phone</Name><Value>(123)456-7890</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>18103000208029</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>75823750-462e-4636-a149-8a9583feba7e</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2018-10-30 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 2:30:42 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxDate": "10/30/2018 2:30:42 AM",
    "TrxKey": "18103000208029"
}
</pre>


Create and Process an eCheck Transaction
--------------------------------

* `POST /transaction/process` will create a transaction on the PayFabric server and attempt to process with the payment gateway based on the request JSON payload

###### Request
<pre>
{
  <b>"Amount": "29.99"</b>,
  "BatchNumber": "",
  <b>"Card"</b>: {
    <b>"Account": "1234567830"</b>,
    <b>"Aba": "031200730"</b>,
    "Billto": {
      "City": "Anaheim",
      "Country": "USA",
      "Email": "",
      "Line1": "123 PayFabric Way",
      "Line2": "",
      "Line3": "",
      "Phone": "(123)456-7890",
      "State": "CA",
      "Zip": "92806"
    },
    <b>"CardHolder"</b>: {
      "DriverLicense": "",
      <b>"FirstName": "John"</b>,
      <b>"LastName": "Doe"</b>,
      "MiddleName": "",
      "SSN": ""
    },
    <b>"Customer": "JOHNDOE0001"</b>,
    "GPAddressCode": "",
    "GatewayToken": "",
    "Identifier": "",
    "IsDefaultCard": false,
    "IssueNumber": "",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
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
  <b>"SetupId": "PFPeCheck"</b>,
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

Please note that **bold** fields are required fields, and all others are optional, for more information on available payment *Card* options please see the [Wallet documentation](Wallets.md). For more information and descriptions on available fields please see our [object reference](Objects.md).

###### Response
<pre>
{
    "AVSAddressResponse": null,
    "AVSZipResponse": null,
    "AuthCode": null,
    "CVV2Response": null,
    "IAVSAddressResponse": null,
    "Message": "Approved",
    "OriginationID": "A5AD0A01E749",
    "PayFabricErrorCode": null,
    "RespTrxTag": null,
    "ResultCode": "0",
    "Status": "Approved",
    "TAXml": "<TransactionData><Connection name=\"PFPeCheck\" connector=\"PayflowPro\"><Processor id=\"20\">Norwest</Processor><PaymentType id=\"3\">ECheck</PaymentType></Connection><Transaction post=\"False\" type=\"1\" status=\"1\"><NeededData><Transaction><Type>1</Type><Status>Approved</Status><Category>NeededData</Category><Fields /></Transaction></NeededData><FailureData><Transaction><Type>1</Type><Status>Approved</Status><Category>FailureData</Category><Fields /></Transaction></FailureData><ResponseData><Transaction><Type>1</Type><Status>Approved</Status><Category>ResponseData</Category><Fields><Field id=\"TrxField_D17\"><Name>ResultCode</Name><Desc>0</Desc><Value>0</Value></Field><Field id=\"TrxField_D31\"><Name>ResponseMsg</Name><Desc>Approved</Desc><Value>Approved</Value></Field><Field id=\"TrxField_D16\"><Name>OriginationID</Name><Desc>A5AD0A01E749</Desc><Value>A5AD0A01E749</Value></Field></Fields></Transaction></ResponseData><RequestData><Transaction><Type>1</Type><Status>1</Status><Category>RequestData</Category><Fields><Field id=\"TrxField_D5\"><Name>BillToFirstName</Name><Desc>First Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>John</Value></Field><Field id=\"TrxField_D7\"><Name>BillToLastName</Name><Desc>Last Name</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>Doe</Value></Field><Field id=\"TrxField_D11\"><Name>BillToCity</Name><Desc>City</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>Anaheim</Value></Field><Field id=\"TrxField_D12\"><Name>BillToState</Name><Desc>State</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>CA</Value></Field><Field id=\"TrxField_D13\"><Name>BillToZip</Name><Desc>Zip</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>92806</Value></Field><Field id=\"TrxField_D15\"><Name>Amt</Name><Desc>Transaction Amount</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>3</Type><Value>29.99</Value></Field><Field id=\"TrxField_D47\"><Name>BillToCountry</Name><Desc>Country Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>USA</Value></Field><Field id=\"TrxField_D48\"><Name>CustCode</Name><Desc>Customer Code</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>JOHNDOE0001</Value></Field><Field id=\"TrxField_D54\"><Name>NAME</Name><Desc>Account Holder Name</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>2</Type><Value>John Doe</Value></Field><Field id=\"TrxField_D55\"><Name>BillToStreet</Name><Desc>Account Holder Street</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>123 PayFabric Way </Value></Field><Field id=\"TrxField_D59\"><Name>ABA</Name><Desc>ABA Routing Number</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>1</Type><Value>xxxxx0730</Value></Field><Field id=\"TrxField_D60\"><Name>ACCT</Name><Desc>Account Number</Desc><Required>1</Required><Encrypted>0</Encrypted><Type>1</Type><Value>xxxxxx7830</Value></Field><Field id=\"TrxField_D61\"><Name>ACCTTYPE</Name><Desc>Account Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>0</Type><Value>Checking</Value><Options><Option id=\"C\"><Desc>Checking</Desc></Option><Option id=\"S\"><Desc>Savings</Desc></Option></Options></Field><Field id=\"TrxField_D88\"><Name>AUTHTYPE</Name><Desc>Authorization Type</Desc><Required>0</Required><Encrypted>0</Encrypted><Type>2</Type><Value>WEB</Value></Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType</Name><Value>3</Value></Field><Field id=\"TRXFIELD_D74\"><Name>CurrencyCode</Name><Value>USD</Value></Field><Field id=\"EncryptAccount\"><Name>EncryptAccount</Name><Value>93C87EA953DF646EED3E</Value></Field><Field id=\"TRXFIELD_D1\"><Name>CCNumber</Name><Value>XXXXXX7830</Value></Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2</Name><Value>XXXXXX7830</Value></Field><Field id=\"TRXFIELD_D3\"><Name>CCExpDate</Name><Value>0000</Value></Field><Field id=\"EncryptRouting\"><Name>EncryptRouting</Name><Value>92C97CAF56D96465EE</Value></Field><Field id=\"MSO_CardName\"><Name>MSO_CardName</Name><Value>eCheck</Value></Field><Field id=\"TRXFIELD_D18\"><Name>CCType</Name><Value>ECheck</Value></Field><Field id=\"TRXFIELD_D8\"><Name>Address1</Name><Value>123 PayFabric Way</Value></Field><Field id=\"TRXFIELD_D78\"><Name>Phone</Name><Value>(123)456-7890</Value></Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard</Name><Value>0</Value></Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey</Name><Value>18103000207970</Value></Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID</Name><Value>00000000-0000-0000-0000-000000000000</Value></Field><Field id=\"MSO_EngineGUID\"><Name>MSO_EngineGUID</Name><Value>75823750-462e-4636-a149-8a9583feba7e</Value></Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date</Name><Value>2018-10-30 00:00:00</Value></Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time</Name><Value>1900-01-01 12:17:38 AM</Value></Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date</Name><Value>1900-01-01</Value></Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time</Name><Value>1900-01-01 00:00:00</Value></Field></Fields></Transaction></RequestData></Transaction></TransactionData>",
    "TerminalID": null,
    "TerminalResultCode": null,
    "TrxDate": "10/30/2018 12:17:38 AM",
    "TrxKey": "18103000207970"
</pre>
