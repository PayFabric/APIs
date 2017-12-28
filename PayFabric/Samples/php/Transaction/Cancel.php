<?php

const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
const DEVICE_PASSWORD = "SamsonitePhp1";

class Transaction {

    public function cancel($transactionKey) {
        
        // Setup the HTTP request.
        $httpUrl = "https://sandbox.payfabric.com/payment/api/reference/" .  $transactionKey . "?trxtype=Void";
        $httpHeader = Array(
                "Content-Type: application/json",
                "authorization: " . DEVICE_ID . "|" . DEVICE_PASSWORD);        
        $curlOptions = Array(CURLOPT_RETURNTRANSFER => TRUE,
                CURLOPT_HTTPHEADER => $httpHeader);

        // Execute the HTTP request.
        $curlHandle = curl_init($httpUrl);
        curl_setopt_array($curlHandle, $curlOptions);
        $httpResponseBody = curl_exec($curlHandle);
        $httpResponseCode = curl_getinfo($curlHandle, CURLINFO_HTTP_CODE);
        curl_close($curlHandle);

        if ($httpResponseCode >= 300) {
            // Handle errors.
        }          

        // Convert the JSON into a multi-dimensional array.
        $responseArray = json_decode($httpResponseBody, TRUE);

        // Output the results of the request.
        var_dump($httpResponseBody);

        return $responseArray;        

    }

}

/* Example Response
{
  "AVSAddressResponse": null,
  "AVSZipResponse": null,
  "AuthCode": "129PNI",
  "CVV2Response": null,
  "IAVSAddressResponse": null,
  "Message": "Approved",
  "OriginationID": "A70A6DC39B5C",
  "RespTrxTag": null,
  "ResultCode": "0",
  "Status": "Approved",
  "TAXml": "<TransactionData><Connection name=\"Strongtrans\" connector=\"PayflowPro\"><Processor id=\"9\">FDMSNashville<\/Processor><PaymentType id=\"1\">Credit<\/PaymentType><Server><Address>https:\/\/pilot-payflowpro.paypal.com<\/Address><Port \/><ProxyAddress \/><ProxyPort \/><ProxyUserID \/><ProxyPassword \/><TimeOut \/><\/Server><Partner>PayPal<\/Partner><Vendor>strongtrans<\/Vendor><UserID>strongtrans<\/UserID><Password>$tr0ngtr@n$<\/Password><MerchantDescriptor \/><MerchantServiceNumber \/><CommodityCode \/><VATNumber \/><ConnectionXSLPath>C:\\Program Files (x86)\\Common Files\\Nodus\\Framework\\ConnectionManager\\Connectors\\PayflowPro<\/ConnectionXSLPath><\/Connection><Transaction post=\"False\" type=\"5\" status=\"1\"><NeededData><Transaction><Type>5<\/Type><Status>Approved<\/Status><Category>NeededData<\/Category><Fields \/><\/Transaction><\/NeededData><FailureData><Transaction><Type>5<\/Type><Status>Approved<\/Status><Category>FailureData<\/Category><Fields \/><\/Transaction><\/FailureData><ResponseData><Transaction><Type>5<\/Type><Status>Approved<\/Status><Category>ResponseData<\/Category><Fields><Field id=\"TrxField_D17\"><Name>ResultCode<\/Name><Desc>0<\/Desc><Value>0<\/Value><\/Field><Field id=\"TrxField_D31\"><Name>ResponseMsg<\/Name><Desc>Approved<\/Desc><Value>Approved<\/Value><\/Field><Field id=\"TrxField_D24\"><Name>AuthCode<\/Name><Desc>129PNI<\/Desc><Value>129PNI<\/Value><\/Field><Field id=\"TrxField_D16\"><Name>OriginationID<\/Name><Desc>A70A6DC39B5C<\/Desc><Value>A70A6DC39B5C<\/Value><\/Field><\/Fields><\/Transaction><\/ResponseData><RequestData><Transaction><Type>5<\/Type><Status>1<\/Status><Category>RequestData<\/Category><Fields><Field id=\"TrxField_D16\"><Name>ORIGID<\/Name><Desc>Origination ID<\/Desc><Required>1<\/Required><Encrypted>0<\/Encrypted><Type>5<\/Type><Value>A70A6DC39612<\/Value><\/Field><Field id=\"TRXFIELD_D19\"><Name>PaymentType<\/Name><Value>1<\/Value><\/Field><Field id=\"TRXFIELD_D48\"><Name>CustomerCode<\/Name><Value>1<\/Value><\/Field><Field id=\"TRXFIELD_D15\"><Name>TrxAmount<\/Name><Value>1.12<\/Value><\/Field><Field id=\"TRXFIELD_D24\"><Name>AuthCode<\/Name><Value>129PNI<\/Value><\/Field><Field id=\"TRXFIELD_D74\"><Name>CurrencyCode<\/Name><Value>USD<\/Value><\/Field><Field id=\"TRXFIELD_D1\"><Name>CCNumber<\/Name><Value>XXXXXXXXXXXX1111<\/Value><\/Field><Field id=\"TRXFIELD_D2\"><Name>TRXFIELD_D2<\/Name><Value>XXXXXXXXXXXX1111<\/Value><\/Field><Field id=\"TRXFIELD_D3\"><Name>CCExpDate<\/Name><Value>1215<\/Value><\/Field><Field id=\"TRXFIELD_D18\"><Name>CCType<\/Name><Value>Visa<\/Value><\/Field><Field id=\"TRXFIELD_D5\"><Name>FirstName<\/Name><Value>Herb<\/Value><\/Field><Field id=\"TRXFIELD_D7\"><Name>LastName<\/Name><Value>Caen<\/Value><\/Field><Field id=\"TRXFIELD_D54\"><Name>AccountName<\/Name><Value>Herb Caen<\/Value><\/Field><Field id=\"TRXFIELD_D8\"><Name>Address1<\/Name><Value>600 Ellis<\/Value><\/Field><Field id=\"TRXFIELD_D55\"><Name>AccountStreet<\/Name><Value>600 Ellis <\/Value><\/Field><Field id=\"TRXFIELD_D12\"><Name>State<\/Name><Value>CA<\/Value><\/Field><Field id=\"TRXFIELD_D11\"><Name>City<\/Name><Value>San Francisco<\/Value><\/Field><Field id=\"TRXFIELD_D47\"><Name>CountryCode<\/Name><Value>USA<\/Value><\/Field><Field id=\"TRXFIELD_D13\"><Name>Zip<\/Name><Value>94109<\/Value><\/Field><Field id=\"SaveCreditCard\"><Name>SaveCreditCard<\/Name><Value>0<\/Value><\/Field><Field id=\"MSO_PFTrxKey\"><Name>MSO_PFTrxKey<\/Name><Value>140821070485<\/Value><\/Field><Field id=\"MSO_WalletID\"><Name>MSO_WalletID<\/Name><Value>1e700b9f-3e43-4cc0-9a02-884dd4c7e6ee<\/Value><\/Field><Field id=\"MSO_Last_Xmit_Date\"><Name>MSO_Last_Xmit_Date<\/Name><Value>2014-08-21 00:00:00<\/Value><\/Field><Field id=\"MSO_Last_Xmit_Time\"><Name>MSO_Last_Xmit_Time<\/Name><Value>1900-01-01 8:28:25 PM<\/Value><\/Field><Field id=\"MSO_Last_Settled_Date\"><Name>MSO_Last_Settled_Date<\/Name><Value>1900-01-01<\/Value><\/Field><Field id=\"MSO_Last_Settled_Time\"><Name>MSO_Last_Settled_Time<\/Name><Value>1900-01-01 00:00:00<\/Value><\/Field><\/Fields><\/Transaction><\/RequestData><\/Transaction><\/TransactionData>",
  "TrxDate": "8\/21\/2014 8:28:25 PM",
  "TrxKey": "140821070485"
}
*/
