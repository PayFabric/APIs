<?php

require_once "HttpClient.php";

class Transaction {
    public function create($transactionFieldsArray) {
        $result = HttpClient::post("transaction/create",
                Utilities::toJsonFromArray($transactionFieldsArray));
        if (isset($result["Key"])) {
            return $result["Key"];
        }
        return false;
    }

    public function submit($transactionKey) {
        $result = HttpClient::get("transaction/process/" . $transactionKey);
        return $result;
    }

    public function createAndSubmit($transactionFieldsArray) {
        $result = HttpClient::post("transaction/process", 
                Utilities::toJsonFromArray($transactionFieldsArray));
        return $result;
    }

    public function cancel($transactionKey) {
        $result = HttpClient::get("reference/" . $transactionKey . "?trxtype=VOID");
        return $result;
    }

    public function get($transactionKey) {
        $result = HttpClient::get("transaction/" . $transactionKey);
        return $result;
    }
}
