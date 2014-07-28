<?php

require_once "Transaction.php";
require_once "Constants.php";

/* Argument is the transaction key that PayFabric returned when the 
 * transaction was initially created. If you do not have this key you 
 * cannot programmatically retrieve a transaction. */ 
$transaction = Transaction::get("140728070071");
