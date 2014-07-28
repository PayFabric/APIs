<?php

require_once "PaymentGatewayManager.php";

$paymentGatewayManager = new PaymentGatewayManager();

$paymentGateways = $paymentGatewayManager->getAllPaymentGateways();
