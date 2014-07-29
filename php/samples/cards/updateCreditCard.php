<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$creditCards = $customer->getAllCreditCards();

$creditCards[0]["Identifier"] = "Update Credit Card Demonstration";

$customer->updateCreditCard($creditCards[0]);
