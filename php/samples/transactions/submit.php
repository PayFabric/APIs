<?php

require_once "Transaction.php";

/* When you call Transaction::create() the PayFabric server creates a record
 * for the transaction and returns a transaction key. 
 * When you want to submit the transaction to a 
 * Payment Gateway you call the method below, passing the transaction 
 * key as the argument. */
Transaction::submit($transactionKey);
