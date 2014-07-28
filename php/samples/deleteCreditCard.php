<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$creditCards = $customer->getAllCreditCards();

// Just retrieving the ID of the first credit card as an example.
$creditCardId = $creditCards[0]["ID"];

$customer->deleteCreditCard($creditCardId);
