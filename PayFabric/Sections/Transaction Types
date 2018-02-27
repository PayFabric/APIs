Transaction Types
=================

This section explains each of the transaction types in PayFabric. The names chosen for PayFabric are among the more common but not universal. Though the names may vary, the processing details do not.  

The transaction types available in PayFabric are:

* Sale
* Book
* Ship
* Credit
* Force
* Void

You can find what each of these transaction types mean below.

#### Sale
A _Sale_ at one processor may be called _Capture_ at another. An approved _Sale_ is an immediate charge to the customer’s credit card or account.  Money will not be moved until settlement has occurred.  A _Sale_ can only be reversed with a _Void_ or a _Credit_.   A _Sale_ transaction does the same thing regardless of it being a credit card transaction, an eCheck transaction, or an ACH transaction.

#### Book
A _Book_ may also be known as a _Pre-Authorize_, _Pre-Authorization_ or _Authorization_. When dealing with credit card transactions a _Book_ is the reserve of a specified amount on the customer’s credit card or account. A _Book_ prevents the customer from using that portion of their credit / funds, but does not actually charge the card nor transfer any money. A _Book_ is useful for companies that ship merchandise one or more days after receiving an order. By issuing a _Book_, a company reserves the necessary amount on the customer’s card at order placement time.  As long as the book transaction remains open an approved _Ship_ transaction is guaranteed. A _Ship_ transaction is necessary to complete the _Book_. 

The number of days a _Book_ will stay open is determined by each cardholder’s issuing bank. The most common number is seven to ten days, but some banks may hold _Books_ for as long as four weeks and little as three days.

A _Book_ transaction cannot be reversed.  Issuing a _Void_ for a _Book_ transaction will not free up any money on the customer’s credit card.  To free up the reserved money you would need to issue a _Ship_ transaction and then _Void_ that shipped amount.

When dealing with eChecks and ACH, a _Book_ is not supported.

#### Ship
A _Ship_ may also be known as _Capture_ or _Delayed Capture_. A _Ship_ can only be issued for a transaction that previously has been a _Book_. Under ordinary circumstances, a _Ship_ is assured approval as long as the amount is equal to or less than the original _Book_ amount and the _Ship_ transaction is sent before the _Book_ has expired. A _Ship_ results in an immediate charge to the customer’s credit card or account. If the _Ship_ is for less than the original _Book_ amount, the remainder of the original _Book_ amount is released back to the customer’s credit line or account.

A _Ship_ transaction can be reversed by issuing a credit or void.

**NOTE:** Some gateways do not allow ship transactions with amounts greater than the original book amount. Please check with your gateway to see if that feature is available.

#### Credit
A _Credit_ is issued to transfer money from the company’s account to the customer’s account or credit card. There are two types of _Credit_ transactions that you can issue:  referenced credit and non-referenced credit.  A referenced credit occurs when you remove the payment line, or delete a sales document.  To create a non-referenced credit you need to create a brand new return document.  Some payment gateways allow for the reversal of a _Credit_ by issuing a _Void_ if that transaction has not yet been settled.  If the transaction has settled you will need to issue a _Sale_ to reverse the _Credit_.

**NOTE:** Some gateways do not allow non-referenced credit transactions to be processed.  Please check with your gateway to see if that feature is available.

#### Force
A _Force_ is used to enter an already approved authorization/transaction. A _Force_ is typically used for capturing a phone or voice authorization. When entering a _Force_ you will be required to enter the authorization code.  

A _Force_ transaction can be reversed by issuing a _Credit_ or a _Void_.

**NOTE:** Authorization code from the payment gateway is required to process _Force_ transactions. Cybersource gateway currently does not support _Force_ transaction type.

#### Void
A _Void_ is issued for an unsettled approved transaction. When a _Void_ is successfully issued, neither the Void nor the original transaction will appear on the customer’s statement. A _Void_ can only be issued against an unsettled transaction. When a _Void_ is sent, if the original transaction has already been settled, the _Void_ will be denied and a warning will be displayed. A settled _Sale_ transaction must be reversed with a _Credit_.
