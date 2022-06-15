Transaction Types
=================

This section explains each of the transaction types in PayFabric. The names chosen for PayFabric are among the more common but not universal. Though the names may vary, the processing details do not.  

The transaction types available in PayFabric are:

* Sale
* Authorization (Book)
* Capture (Ship)
* Refund (Credit)
* Force
* Void
* Verify
* Activate
* Reload

You can find what each of these transaction types mean below.

#### Sale
A _Sale_ at one processor may be called _Capture_ at another. An approved _Sale_ is an immediate charge to the customer’s credit card or account.  Money will not be moved until settlement has occurred.  A _Sale_ can only be reversed with a _Void_ or a _Refund_.   A _Sale_ transaction does the same thing regardless of it being a credit card transaction, an eCheck transaction, or an ACH transaction.

A Credit Card _Sale_ transaction can be reversed by issuing a _Refund_ or _Void_.

A Gift Card or ACH _Sale_ transaction can be reversed by issuing a _Void_.

#### Authorization (Book)
A _Authorization_ may also be known as a _Pre-Authorize_, _Pre-Authorization_ or _Authorization_. When dealing with credit card transactions a _Authorization_ is the reserve of a specified amount on the customer’s credit card or account. A _Authorization_ prevents the customer from using that portion of their credit / funds, but does not actually charge the card nor transfer any money. A _Authorization_ is useful for companies that ship merchandise one or more days after receiving an order. By issuing a _Authorization_, a company reserves the necessary amount on the customer’s card at order placement time.  As long as the _Authorization_ transaction remains open an approved _Capture_ transaction is guaranteed. A _Capture_ transaction is necessary to complete the _Authorization_. 

The number of days a _Authorization_ will stay open is determined by each cardholder’s issuing bank. The most common number is seven to ten days, but some banks may hold _Authorization_ for as long as four weeks and little as three days.

A _Authorization_ transaction cannot be reversed.  Issuing a _Void_ for a _Authorization_ transaction will not free up any money on the customer’s credit card.  To free up the reserved money you would need to issue a _Capture_ transaction and then _Void_ that captured amount.

When dealing with ACH or Gift Card, a _Authorization_ is not supported.

#### Capture (Ship)
A _Capture_ may also be known as _Capture_ or _Delayed Capture_. A _Capture_ can only be issued for a transaction that previously has been a _Authorization_. Under ordinary circumstances, a _Capture_ is assured approval as long as the amount is equal to or less than the original _Authorization_ amount and the _Capture_ transaction is sent before the _Authorization_ has expired. A _Capture_ results in an immediate charge to the customer’s credit card or account. If the _Capture_ is for less than the original _Authorization_ amount, the remainder of the original _Authorization_ amount is released back to the customer’s credit line or account.

A _Capture_ transaction can be reversed by issuing a _Refund_ or _Void_.

**NOTE:** Some gateways do not allow _Capture_ transactions with amounts greater than the original _Authorization_ amount. Please check with your gateway to see if that feature is available.

#### Refund (Credit)
A _Refund_ is issued to transfer money from the company’s account to the customer’s account or credit card. There are two types of _Refund_ transactions that you can issue: referenced _Refund_ and non-referenced _Refund_. A referenced _Refund_ occurs when you remove the payment line, or delete a sales document.  To create a non-referenced _Refund_ you need to create a brand new return document.  Some payment gateways allow for the reversal of a _Refund_ by issuing a _Void_ if that transaction has not yet been settled.  If the transaction has settled you will need to issue a _Sale_ to reverse the _Refund_.

When dealing with Gift Card, a _Refund_ is not supported.

**NOTE:** Some gateways do not allow non-referenced _Refund_ transactions to be processed.  Please check with your gateway to see if that feature is available.

#### Force
A _Force_ is used to enter an already approved authorization/transaction. A _Force_ is typically used for capturing a phone or voice authorization. When entering a _Force_ you will be required to enter the authorization code.  

A _Force_ transaction can be reversed by issuing a _Refund_ or a _Void_.

When dealing with ACH or Gift Card, a _Force_ is not supported.

**NOTE:** Authorization code from the payment gateway is required to process _Force_ transactions. Cybersource gateway currently does not support _Force_ transaction type.

#### Void
A _Void_ is issued for an unsettled approved transaction. When a _Void_ is successfully issued, neither the Void nor the original transaction will appear on the customer’s statement. A _Void_ can only be issued against an unsettled transaction. When a _Void_ is sent, if the original transaction has already been settled, the _Void_ will be denied and a warning will be displayed. A Credit Card settled _Sale_ transaction must be reversed with a _Refund_.

#### Verify
A _Verify_ is used to validate credit card number. It's not a payment, PayFabric won't settle _Verify_ transactions, and unable to reverse _Verify_ transactions. 
_Verify_ transaction only supports in Create Transaction/Update Transaction/Process Transaction APIs, it is not available in portal and hosted payment page.
Only EVO gateway supports _Verify_ transaction with Credit Card payment method. PayFabric will set tranaction's Amount to 0.00 if anything other than 0.00 is passed through for _Verify_ transaction. 

#### Activate
An _Activate_ is used to activate a new Gift Card with an initial currency value. Gift Card accounts must be activated as their first transaction.  PayFabric only supports Gift Card in USD currency.

A Gift Card _Activate_ transaction can be reversed by issuing a _Void_.

#### Reload
A _Reload_ is used to add additional currency value to an existing Gift Card. PayFabric only supports Gift Card in USD currency.

A Gift Card _Reload_ transaction can be reversed by issuing a _Void_.
