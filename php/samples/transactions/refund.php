<?php

require_once "Transaction.php";
require_once "Constants.php";

/* Refunding a customer is almost the same as creating a sale. The only 
 * difference is that you specify the transaction type as a CREDIT instead of 
 * a SALE. */

// These are the minimum fields you need to provide when creating a new transaction.
$card = Array("ID" => 
        "1e700b9f-3e43-4cc0-9a02-884dd4c7e6ee"); // ID of credit card or eCheck that will receive refund.
                                                 // Can be retrieved via Customer class.
$fields = Array(
        "Amount" => "1.12",
        "Customer" => "1", // Customer ID
        "Currency" => "USD",
        "SetupId" => "Strongtrans", // Payment Gateway name
        "Tender" => Constants::TENDER_TYPE_CREDIT_CARD,
        "Type" => Constants::TRANSACTION_TYPE_CREDIT, // This is the only field that changes.
        "Card" => $card);

/* Upon success PayFabric returns a transaction key. Right now the transaction
 * is only stored on the PayFabric server. It has not yet been submitted to a 
 * Payment Gateway. */
$key = Transaction::create($fields);
/* Use Transaction::submit($transactionKey) to submit the 
 * transaction to a Payment Gateway. */ 
Transaction::submit($key);
