<?php

const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
const DEVICE_PASSWORD = "SamsonitePhp1";

class Wallet {

    public function removeCard($cardId) {
        
        // Setup the HTTP request.
        $httpUrl = "https://sandbox.payfabric.com/payment/api/wallet/delete/" . $cardId;
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
{"Result":"True"}
*/
