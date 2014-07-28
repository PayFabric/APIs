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

