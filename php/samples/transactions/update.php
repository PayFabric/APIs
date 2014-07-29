<?php

require_once "Transaction.php";
require_once "Constants.php";

/* In this example we create a transaction, and then update a couple of fields 
 * of the transaction. 
 * 
 * If you create a transaction without submitting the transaction to a Payment 
 * Gateway, you can update all of the fields of the transaction. This is demonstrated
 * in this sample.
 * 
 * If you have already submitted a transaction to a Payment Gateway, you can
 * only edit the "UserDefined" fields of the transaction. */

// These are the minimum fields you need to provide when creating a new transaction.
$card = Array("ID" => 
        "1e700b9f-3e43-4cc0-9a02-884dd4c7e6ee"); // Credit Card ID generated by PayFabric. 
                                                 // Can be retrieved via Customer class.
$transactionFields = Array(
        "Amount" => "1.12",
        "Customer" => "0001", // Customer ID
        "Currency" => "USD",
        "SetupId" => "Strongtrans", // Payment Gateway name
        "Tender" => Constants::TENDER_TYPE_CREDIT_CARD,
        "Type" => Constants::TRANSACTION_TYPE_SALE,
        "Card" => $card);

$key = Transaction::create($transactionFields);

// Now update some data from the transaction.
$transactionFields["Amount"] = "13.46";
/* When you update a transaction, you must provide the transaction key. This is 
 * generated and returned by PayFabric upon creation of the transaction. If you
 * do not have this key, you cannot update a transaction. */
$transactionFields["Key"] = $key;

Transaction::update($transactionFields);