PayFabric APIs
==============
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the server URL:

1. Live Server:    ``https://www.payfabric.com``
1. Sandbox Server: ``https://sandbox.payfabric.com``

Where do I start?
-----------------

Want to get started with PayFabric API integration? Here's a quick check list:

1. Register and then configure a PayFabric account, check out the [Guide](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md) to learn how.
2. Read up on how to [authenticate](#authentication) with our APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with our APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](Samples).
5. Have a question or need help? Contact <support@payfabric.com>.


Authentication
--------------
PayFabric clients require PayFabric *Device ID* and *Password*  to authenticate with APIs.

We have a [detailed guide](Sections/Authentication.md) for authenticating your users with our APIs.


AppID
--------------
PayFabric's 3rd party integrator or integration partner will be provided with an AppID to be submitted through PayFabric Transaction APIs. The AppID  helps identify the application source for the corresponding transaction.

Please submit a name-value-pair under **Document** object > **UserDefined** section with the Name 'AppID'. The value will be the AppID value provided to you by PayFabric Support team. 

Example:
"UserDefined": 
[
	 { "Name": "AppID", "Value": "Custom_App" }
]

Handling Exceptions
-------------------
PayFabric uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
PayFabric sends and receives payloads as structured [JSON Objects for 3.0](Sections/Objects.md) or [JSON Objects for 3.1](Sections/3.1JSONObjects.md) . 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

## Version 3.0

### Transactions
* [Create a Transaction](Sections/Transactions.md#create-a-transaction)
* [Update a Transaction](Sections/Transactions.md#update-a-transaction)
* [Process a Transaction](Sections/Transactions.md#process-a-transaction)
* [Create and Process a Transaction](Sections/Transactions.md#create-and-process-a-transaction)
* [Retrieve a Transaction](Sections/Transactions.md#retrieve-a-transaction)
* [Retrieve Transactions](Sections/Transactions.md#retrieve-transactions)
* [Cancel (Void) a Transaction](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-credit-refund)
* [Capture a Pre-Authorized Transaction](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-credit-refund)
* [Refund Reference](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-refund-credit)
* [Refund Non-Reference](Sections/Transactions.md#refund-non-reference)
* [Process eCheck Transaction](Sections/Process%20eCheck%20Transaction.md)

### Wallets / Credit Cards / eChecks
* [Create a Credit Card / eCheck](Sections/Wallets.md#create-a-credit-card)
* [Update a Credit Card / eCheck](Sections/Wallets.md#update-a-credit-card--echeck)
* [Retrieve a Credit Card / eCheck](Sections/Wallets.md#retrieve-a-credit-card--echeck)
* [Retrieve Credit Cards / eChecks](Sections/Wallets.md#retrieve-credit-cards--echecks)
* [Lock Credit Card / eCheck](Sections/Wallets.md#lock-credit-card--echeck)
* [Unlock Credit Card / eCheck](Sections/Wallets.md#unlock-credit-card--echeck)
* [Remove Credit Card / eCheck](Sections/Wallets.md#remove-credit-card--echeck)
* [Retrieve expired Credit Cards](Sections/Wallets.md#retrieve-expired-wallet)

### Payment Gateway Profiles
* [Retrieve a Payment Gateway Profile](Sections/Payment%20Gateway%20Profiles.md#retrieve-a-payment-gateway-profile)
* [Retrieve Payment Gateway Profiles](Sections/Payment%20Gateway%20Profiles.md#retrieve-payment-gateway-profiles)
* [Manual Batch Close](Sections/Payment%20Gateway%20Profiles.md#manually-batch-close-transactions)

### Addresses
* [Retrieve a Shipping Address](Sections/Addresses.md#retrieve-a-shipping-address)
* [Retrieve Shipping Addresses](Sections/Addresses.md#retrieve-shipping-addresses)

### JSON Web Tokens
* [Create JWT Token](Sections/JWTToken.md#create-json-web-tokens)
* [Validate JWT Token](Sections/JWTToken.md#validate-json-web-tokens)

## Version 3.1

### Email Transaction Receipt
* [Send a Transaction Receipt](/PayFabric/Sections/EmailReceipt.md#send-a-transaction-receipt)

### Email Transaction Receipt Template
* [Get Email Receipt Templates](/PayFabric/Sections/EmailReceipt.md#get-email-receipt-templates)
* [Update Email Receipt Template](/PayFabric/Sections/EmailReceipt.md#update-email-receipt-template)

### Batched Transactions
* [Get Current Batches](/PayFabric/Sections/Batches.md#get-current-batches)
* [Process Batch](/PayFabric/Sections/Batches.md#process-batch)
* [Delete Batch](/PayFabric/Sections/Batches.md#delete-batch)
* [Search by Batch Number](/PayFabric/Sections/Batches.md#search-by-batch-number)

### Scheduled Transactions
* [Search for Future Dated Transactions](/PayFabric/Sections/ScheduledTransaction.md#search-for-future-dated-transactions)

### Custom Reports
* [Get Custom Reports](/PayFabric/Sections/CustomReports.md#get-custom-reports)
* [Create Custom Report](/PayFabric/Sections/CustomReports.md#create-custom-report/PayFabric/Sections/CustomReports.md#create-custom-report)
* [Edit Custom Report](/PayFabric/Sections/CustomReports.md#edit-custom-report)
* [Delete Custom Report](/PayFabric/Sections/CustomReports.md#delete-custom-report)
* [Manaual Execute Custom Report](/PayFabric/Sections/CustomReports.md#manual-execute-custom-report)

### Shipping Addresses
* [Create Shipping Address](/PayFabric/Sections/ShippingAddress.md#create-shipping-address)
* [Delete Shipping Address](/PayFabric/Sections/ShippingAddress.md#delete-shipping-address)

### Payment Terminal
* [Get Registered Terminals](/PayFabric/Sections/Payment%20Terminal.md#get-registered-terminals)
* [Create new Registered Terminal](/PayFabric/Sections/Payment%20Terminal.md#create-new-registered-terminal)
* [Update Registered Terminal](/PayFabric/Sections/Payment%20Terminal.md#update-registered-terminal)
* [Remove Registered Terminal](/PayFabric/Sections/Payment%20Terminal.md#remove-registered-terminal)
* [Get Terminal Settings](/PayFabric/Sections/Payment%20Terminal.md#get-terminal-settings)
* [Update Terminal Settings](/PayFabric/Sections/Payment%20Terminal.md#update-terminal-settings)

### Products
* [Get Products](/PayFabric/Sections/Product.md#get-products)
* [Create Product](/PayFabric/Sections/Product.md#create-product)
* [Edit Product](/PayFabric/Sections/Product.md#update-product)
* [Delete Product](/PayFabric/Sections/Product.md#delete-product)
* [Upload Products](/PayFabric/Sections/Product.md#upload-products)

### Theme
* [Get Themes](/PayFabric/Sections/Theme.md#get-themes)
* [Create Theme](/PayFabric/Sections/Theme.md#create-theme)
* [Update Theme](/PayFabric/Sections/Theme.md#update-theme)
* [Delete Theme](/PayFabric/Sections/Theme.md#delete-theme)

### Transaction Adjustments
* [Transaction Adjustments](/PayFabric/Sections/Transaction%20Adjustments.md)

Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to branch these documents and send a pull request with improvements!

Versions
------------
For our other supported versions of the APIs please see the below:

* [Version 2.0](https://github.com/PayFabric/APIs/tree/v2)
