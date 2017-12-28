<?php

const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
const DEVICE_PASSWORD = "SamsonitePhp1";

class GatewayAccount {
    
    public function retrieveByGatewayAccountId($gatewayAccountId) {

        // Setup the HTTP request.
        $httpUrl = "https://sandbox.payfabric.com/payment/api/setupid/" . $gatewayAccountId;
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
        $gatewayAccountArray = json_decode($httpResponseBody, TRUE);

        // Output the results of the request.
        var_dump($httpResponseBody);

        return $gatewayAccountArray;
        
    }
    
}

/* Example Response
{
  "CardClass": "Credit",
  "CardClassID": "1",
  "Connector": "PayflowPro",
  "Fields": [
    {
      "Key": "Server.Address",
      "Value": "https:\/\/pilot-payflowpro.paypal.com"
    },
    {
      "Key": "Server.Port",
      "Value": ""
    },
    {
      "Key": "Server.ProxyAddress",
      "Value": ""
    },
    {
      "Key": "Server.ProxyPort",
      "Value": ""
    },
    {
      "Key": "Server.ProxyUserID",
      "Value": ""
    },
    {
      "Key": "Server.ProxyPassword",
      "Value": ""
    },
    {
      "Key": "Server.TimeOut",
      "Value": ""
    },
    {
      "Key": "Partner",
      "Value": "PayPal"
    },
    {
      "Key": "Vendor",
      "Value": "strongtrans"
    },
    {
      "Key": "UserID",
      "Value": "strongtrans"
    },
    {
      "Key": "Password",
      "Value": "$tr0ngtr@n$"
    },
    {
      "Key": "MerchantDescriptor",
      "Value": ""
    },
    {
      "Key": "MerchantServiceNumber",
      "Value": ""
    },
    {
      "Key": "CommodityCode",
      "Value": ""
    },
    {
      "Key": "VATNumber",
      "Value": ""
    }
  ],
  "ID": "33fe83aa-6f1c-4fa5-8e33-516a5a0ebfe2",
  "Name": "Strongtrans",
  "Processor": "FDMSNashville",
  "ProcessorID": "9"
}
*/
