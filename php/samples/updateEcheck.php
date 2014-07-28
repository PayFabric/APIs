<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$echecks = $customer->getAllEchecks();

$echecks[0]["Identifier"] = "Update Echeck Demonstration";

$customer->updateEcheck($echecks[0]);
