<?php

require_once "Constants.php";
require_once "HttpClient.php";
require_once "Utilities.php";

class Customer {
    private $_id; // Customer ID

    function __construct($id) {
        $this->_id = $id;
    }

    /* CARDS */
    public function createCreditCard($creditCardArray) {
        /* These arrays contain all of the fields that are required when
         * creating a new credit card. */
        $addressFields = Array("Customer", "Line1", "City", "State", "Country",
                "Zip");
        $cardholderFields = Array("FirstName", "LastName");
        $creditCardFields = Array("Tender", "Customer", "Account", "ExpDate",
                "CardHolder", "Billto");

        // Check that the user's credit card array contains all required fields.
        foreach ($creditCardFields as $field) {
            if (!array_key_exists($field, $creditCardArray)) {
                throw new Exception("missingRequiredCardFieldException");
            }
        }
        foreach ($cardholderFields as $field) {
            if (!array_key_exists($field, $creditCardArray["CardHolder"])) {
                throw new Exception("missingRequiredCardholderFieldException");
            }
        }
        foreach ($addressFields as $field) {
            if (!array_key_exists($field, $creditCardArray["Billto"])) {
                throw new Exception("missingRequiredAddressFieldException");
            }
        }

        // Send the request to PayFabric.
        $result = HttpClient::post("wallet/create", 
                Utilities::toJsonFromArray($creditCardArray));

        // Parse PayFabric response and return status to user.
        if (is_null($result["Result"])) {
            return FALSE;
        }
        return $result["Result"];
    }

    public function deleteCreditCard($creditCardId) {
        $result = HttpClient::get("wallet/delete/" . $creditCardId);
        return $result["Result"] === "True";
    }
 
    public function getAllCreditCards() {
        return HttpClient::get("wallet/get/" . $this->_id . "?tender=" . Constants::TENDER_TYPE_CREDIT_CARD);
    }

    public function getAllEchecks() {
        return HttpClient::get("wallet/get/". $this->_id . "?tender=" . Constants::TENDER_TYPE_ECHECK);
    }

    public function deleteEcheck($echeckId) {
        return $this->deleteCreditCard($echeckId);
    }

    public function getId() {
        return $this->_id;
    }
   
    public function updateCreditCard($creditCardArray) {
        if (isset($creditCardArray["Account"])) {
            unset($creditCardArray["Account"]);
        }
        $json = Utilities::toJsonFromArray($creditCardArray);
        $result = HttpClient::post("wallet/update", $json);
        return $result["Result"] === "True";
    }


    public function createTransaction($transactionArray) {
        $result = HttpClient::post("transaction/create", 
                Utilities::toJsonFromArray($transactionArray));
        if (isset($result["Key"])) {
            return $result["Key"];
        }
        return false;       
    }

    public function submitTransactionToPaymentGateway($transactionKey) {
        $result = HttpClient::get("transaction/process/" . $transactionKey);
    }

    /* ADDRESSES */
    public function getAllAddresses() {
        return HttpClient::get("addresses/" . $this->_id);
    }

    public function getAddressById($addressId) {
        return HttpClient::get("address/" . $addressId);
    }
}
