<?php

const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
const DEVICE_PASSWORD = "SamsonitePhp1";

class ShippingAddress {

    public function retrieveByShippingAddressId($shippingAddressId) {
        
        // Setup the HTTP request.
        $httpUrl = "https://sandbox.payfabric.com/payment/api/address/" . $shippingAddressId;
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
        $addressArray = json_decode($httpResponseBody, TRUE);

        // Output the results of the request.
        var_dump($httpResponseBody);

        return $addressArray;
        
    }
    
}

/* Example Response 
{
  "City": "Burlingame",
  "Country": "USA",
  "Customer": "1",
  "Email": "",
  "ID": "1e622ec4-b9a1-4f5d-a79b-31134925ca32",
  "Line1": "2000 Murchison Drive",
  "Line2": "",
  "Line3": "",
  "ModifiedOn": "7\/27\/2014 4:11:28 PM",
  "Phone": "",
  "State": "CA",
  "Zip": "94010"
}
*/
