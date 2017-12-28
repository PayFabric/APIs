<?php

const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
const DEVICE_PASSWORD = "SamsonitePhp1";

class Wallet {

    public function retrieveCardsByCustomerId($customerId, $cardType) {
        
        // Setup the HTTP request.
        $httpUrl = "https://sandbox.payfabric.com/payment/api/wallet/get/" . $customerId . "?tender=" . $cardType;
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
[
  {
    "Aba": "",
    "Account": "XXXXXXXXXXXX1111",
    "AccountType": "",
    "Billto": {
      "City": "San Francisco",
      "Country": "USA",
      "Customer": "",
      "Email": "",
      "ID": "80d4c693-5681-4733-a612-35c1e594ee44",
      "Line1": "600 Ellis",
      "Line2": "",
      "Line3": "",
      "ModifiedOn": "1\/1\/0001 12:00:00 AM",
      "Phone": "",
      "State": "CA",
      "Zip": "94109"
    },
    "CVC": null,
    "CardHolder": {
      "DriverLicense": "",
      "FirstName": "Herb",
      "LastName": "Caen",
      "MiddleName": "",
      "SSN": ""
    },
    "CardName": "Visa",
    "CheckNumber": null,
    "Customer": "1",
    "ExpDate": "1215",
    "GPAddressCode": "",
    "GatewayToken": "",
    "ID": "1e700b9f-3e43-4cc0-9a02-884dd4c7e6ee",
    "Identifier": "",
    "IsDefaultCard": true,
    "IsLocked": false,
    "IsSaveCard": false,
    "IssueNumber": "",
    "ModifiedOn": "7\/28\/2014 11:57:40 AM",
    "SetupId": null,
    "StartDate": "",
    "Tender": "CreditCard",
    "UserDefine1": "",
    "UserDefine2": "",
    "UserDefine3": "",
    "UserDefine4": ""
  }
]
*/
