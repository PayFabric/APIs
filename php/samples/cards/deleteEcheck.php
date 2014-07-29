<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$echecks = $customer->getAllEchecks();

// Just retrieving the ID of the first credit card as an example.
$echeckId = $echecks[0]["ID"];

$customer->deleteEcheck($echeckId);
