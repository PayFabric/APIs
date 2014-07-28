<?php

require_once "PaymentGatewayManager.php";

$paymentGatewayManager = new PaymentGatewayManager();

$paymentGateways = $paymentGatewayManager->getAllPaymentGateways();

$paymentGateway = $paymentGatewayManager->getPaymentGatewayById($paymentGateways[0]["ID"]);
