Transaction Types
=================

This section explains each of the transaction types in PayFabric. Names chosen for the transaction types are more common among the payment industry but not universal. Other known names used for each transaction type is provided in the details below.  Though the names may vary, the processing details do not.

Transaction types available in PayFabric are:

* Sale
* Authorization (Book)
* Capture (Ship)
* Refund (Credit)
* Force
* Void
* Verify
* Activate
* Reload

Definitions of the transaction types are as follows.  Note that certain details may be different between payment cards (credit cards, debit cards, gift cards) and ACH (aka eCheck) as described below.

### Sale
**Other Known Name(s):** _Capture_, _Auth Capture_, _Authorization_.  Not the same as a _Capture (Ship)_ and _Authorization_ transactions defined by PayFabric below.</li>

**Definition:** _Sale_ is a payment transaction type which is to immediately charge the payment card or bank account.

**Settlement:** Money will not be moved until settlement has occurred.

**Reversal:** A credit/debit card _Sale_ transactions can be reversed by a _Void_ transaction before settlement or by a _Refund_ transaction after settlement.  A gift card or ACH _Sale_ transaction can only be reversed by issuing a _Void_.

### Authorization (Book)
**Other Known Name(s):** _Book_, _Pre-Authorize_, _Pre-Authorization_.

**Definition:** _Authorization_ is a transaction type that reserves a specified amount against a payment card account (except gift cards). An _Authorization_ prevents the cardholder from using that portion of their credit or fund on the payment card account, but does not actually charge the card nor transfer any money.
The number of days an _Authorization_ will stay open is determined by each payment card’s issuing bank. The most common number is seven to ten days, but some banks may hold _Authorization_ for as long as four weeks and little as three days.  _Authorization_ is not supported on ACH and gift cards.

**Use Case(s):** An _Authorization_ is useful for merchants that fulfills goods or services one or more days after receiving an order. By processing an _Authorization_, the merchant reserves the necessary amount on the payment card at order placement time.  As long as the _Authorization_ transaction remains open, an approved _Capture_ transaction is guaranteed for the authorized amount.

**Settlement:** Money will not be moved until the Authorization is captured by a _Capture_ transaction and the _Capture_ transaction is settled.  The _Authorization_ transaction itself will not go through settlement process.

**Reversal:** An _Authorization_ transaction cannot be reversed as processing a _Void_ transaction against the _Authorization_ transaction will not free up the reserved fund on the payment card.  To free up the reserved fund you would need to process a _Capture_ transaction and then _Void_ the captured amount.

### Capture (Ship)
**Other Known Name(s):** _Delayed Capture_, _Ship_.

**Definition:** _Capture_ is a payment transaction type used to capture funds reserved by an approved _Authorization_ transaction. Under ordinary circumstances, a _Capture_ is assured approval as long as the amount is equal to or less than the original _Authorization_ amount and the _Capture_ transaction is sent before the _Authorization_ has expired. A _Capture_ results in an immediate charge to the customer’s credit card or account. If the _Capture_ is for less than the original _Authorization_ amount, the remainder reservation of the original authorized amount is released.

**Settlement:** Money will not be moved until settlement has occurred.

**Reversal:** A _Capture_ transaction can be reversed by a _Void_ transaction before settlement or by _Refund_ transaction after settlement.

 > **Note:** Some gateways, processors, and card issuing banks do not allow _Capture_ transactions with amounts greater than the original _Authorization_ amount.

### Refund (Credit)
**Other Known Name(s):** _Credit_.

**Definition:** _Refund_ is a payment transaction type to transfer money from merchant’s account back to its customer’s payment card (except gift cards) or bank account.  There are two types of _Refund_ transactions, referenced _Refund_ and non-referenced _Refund_. A referenced _Refund_ requires referencing an existing _Sale_ or _Capture_ transaction and issues the refund against the original payment method.  A non-referenced _Refund_ requires the transaction to specify the payment card or bank account that the refund should be issued to.   _Refund_ is not supported on gift cards.

**Reversal:** Some payment gateways allow for the reversal of a _Refund_ by a _Void_ transaction before settlement.  After settlement, you will need to charge for the fund again.

 > **Note:** Some gateways and processors do not allow non-referenced _Refund_ transactions.

### Force
**Other Known Name(s):** _Voice Authorization_.

**Definition:** A credit card _Sale_ transaction may fail with response message instructing the merchant to perform a voice authorization to process the transaction over the phone.  Once the voice authorization approves the _Sale_ transaction, an Authorization Code is issued over the phone, and a _Force_ transaction is used to enter the approved _Sale_ transaction into PayFabric.  When entering a _Force_ transaction, Authorization Code must be provided (`ReqAuthCode` node on the [Transaction object](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#transaction)).  _Force_ transaction is not applicable and not support for ACH or gift cards.

**Reversal:** Just as _Sale_ transactions, a _Force_ transaction can be reversed by a _Void_ transaction before settlement or by _Refund_ transaction after settlement.

**Settlement:** Money will not be moved until settlement has occurred.

### Void
**Definition:** A _Void_ transaction is an action to reverse an approved payment transaction before it's settled.  When a _Void_ transaction is approved, neither the Void nor the original transaction will appear on the account-holder’s statement.  _Void_ transactions will be denied if processed against settled transactions.

**Reversal:** You cannot reverse a _Void_ transaction.

### Verify
**Definition:** A _Verify_ transaction is an action to validate credit card number.  It is not a payment transaction, not applicable to settlements and transaction reversals.  Only EVO gateway supports the _Verify_ transaction type.  Any declared transaction amount will be ignored and all _Verify_ transactions will result with $0.00 transaction amount. 

### Activate
**Definition:** An _Activate_ transaction is an action to activate a new gift card with an initial fund. Gift card accounts must be activated as their first transaction.  PayFabric only supports gift cards in the USD currency.

**Reversal:** An _Activate_ transaction can be reversed by a _Void_ transaction.

### Reload
**Definition:** A _Reload_ transaction is an action to add additional fund to an active gift card. PayFabric only supports gift cards in the USD currency.

**Reversal:** A _Reload_ transaction can be reversed by a _Void_ transaction.
