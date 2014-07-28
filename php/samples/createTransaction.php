<?php

require_once "Customer.php";
require_once "PaymentGatewayManager.php";
require_once "Constants.php";


// Pass the Customer ID as the constructor argument.
$customer = new Customer("1");

$echecks = $customer->getAllEchecks();

$echeckId = $echecks[0]["ID"];

$card = Array("ID" => $echeckId);

$transaction = Array(
        "Amount" => "12.00",
        "Customer" => $customer->getId(),
        "Currency" => "USD",
        "SetupId" => "PayPal",
        "Tender" => Constants::TENDER_TYPE_ECHECK,
        "Type" => Constants::TRANSACTION_TYPE_SALE,
        "Card" => $card);

$transactionKey = $customer->createTransaction($transaction);

