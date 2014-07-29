<?php

require_once "Utilities.php";
require_once "Constants.php";


/* HttpClient - Handles HTTP requests to the PayFabric server.
 *
 * All requests are relative to the PayFabric REST server. For example,
 * when you call HttpClient::get("transactions"), HttpClient will 
 * read the BASE_URL from the Constants class and concatenate "transactions" 
 * to the end of that URL, creating something like 
 * "sandbox.payfabric.com/api/transaction".  
 * 
 * HttpClient uses cURL to execute its HTTP requests. 
 * 
 * HttpClient takes care of adding the authorization header to every message it sends.
 * Just DEVICE_ID and DEVICE_PASSWORD in Constants.php to contain your application
 * credentials. 
 * 
 * HttpClient throws exceptions when it receives HTTP response codes
 * indicating that the request failed. 
 * httpRedirectionMessageException - 300 to 399 status codes
 * httpClientErrorMessageException - 400 to 499 status codes
 * httpServerErrorMessageException - 500 to 599 status codes
 * 
 * Use get() to perform HTTP GET requests.
 * Use post() to perform HTTP POST requests. 
 * 
 * Set CURLOPT_VERBOSE to TRUE to enable cURL's verbose output. */
class HttpClient {
    
    function get($resource) {
        $curlOptions = Array(CURLOPT_RETURNTRANSFER => TRUE,
                // CURLOPT_VERBOSE => TRUE,
                CURLOPT_HTTPHEADER => self::_getDefaultHeader());
        
        $result = self::_send(Constants::BASE_URL . $resource, $curlOptions);

        return Utilities::toArrayFromJson($result);
    }

    function post($resource, $json) {
        $curlOptions = Array(CURLOPT_RETURNTRANSFER => TRUE,
                // CURLOPT_VERBOSE => TRUE, // debug
                CURLOPT_HTTPHEADER => self::_getDefaultHeader(), 
                CURLOPT_POSTFIELDS => $json);

        $result = self::_send(Constants::BASE_URL . $resource, $curlOptions);

        return Utilities::toArrayFromJson($result);
    }

    private function _getDefaultHeader() {
        $httpHeader = Array(
                "Content-Type: application/json",
                "authorization: " . Constants::DEVICE_ID . "|" .
                        Constants::DEVICE_PASSWORD);
        return $httpHeader;
    }

    private function _handleResponseCode($httpResponseCode) {
        $c = (int) $httpResponseCode;
        if ($c >= 300 && $c < 400) {
            throw new Exception("httpRedirectionMessageException");
        }
        if ($c >= 400 && $c < 500) {
            throw new Exception("httpClientErrorException");
        }
        if ($c >= 500 && $c < 600) {
            throw new Exception("httpServerErrorException");
        }
    }

    private function _send($url, $curlOptions) {
        // Init, execute, and close cURL session.
        $curlHandle = curl_init($url);
        curl_setopt_array($curlHandle, $curlOptions);
        $httpResponseBody = curl_exec($curlHandle);
        $httpResponseCode = curl_getinfo($curlHandle, CURLINFO_HTTP_CODE);
        curl_close($curlHandle);
        // Check for errors.
        self::_handleResponseCode($httpResponseCode);
        return $httpResponseBody;
    }    
}
