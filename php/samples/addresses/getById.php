<?php

require_once "Customer.php";

$customerId = "1";

$customer = new Customer($customerId);

$addresses = $customer->getAllAddresses();

$address = $customer->getAddressById($addresses[0]["ID"]);
