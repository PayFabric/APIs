<?php

require_once "Constants.php";
require_once "HttpClient.php";

/* PaymentGateway - Retrieve Payment Gateway information. */
class PaymentGateway {
    public function getAllPaymentGateways() {
        return HttpClient::get("setupid");
    }

    public function getPaymentGatewayById($id) {
        return HttpClient::get("setupid/" . $id);
    }
}
