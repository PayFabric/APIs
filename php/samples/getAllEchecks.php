<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$creditCards = $customer->getAllEchecks();
