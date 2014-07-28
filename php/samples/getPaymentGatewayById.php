<?php

require_once "PaymentGateway.php";

$paymentGateways = PaymentGateway::getAllPaymentGateways();

$paymentGateway = PaymentGateway::getPaymentGatewayById($paymentGateways[0]["ID"]);
