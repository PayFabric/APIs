<?php

require_once "Customer.php";

$customer = new Customer("1");

$addresses = $customer->getAllAddresses();

