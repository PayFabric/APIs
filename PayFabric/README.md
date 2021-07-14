PayFabric APIs - Version 3.0
==============
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com/payment``
1. Sandbox Server: ``https://sandbox.payfabric.com/payment``

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
PayFabric sends and receives payloads as structured [JSON Objects](Sections/Objects.md). 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

### Transactions
* [Create a Transaction](Sections/Transactions.md#create-a-transaction)
* [Update a Transaction](Sections/Transactions.md#update-a-transaction)
* [Process a Transaction](Sections/Transactions.md#process-a-transaction)
* [Create and Process a Transaction](Sections/Transactions.md#create-and-process-a-transaction)
* [Retrieve a Transaction](Sections/Transactions.md#retrieve-a-transaction)
* [Retrieve Transactions](Sections/Transactions.md#retrieve-transactions)
* [Cancel (Void) a Transaction](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-credit-refund)
* [Capture a Pre-Authorized Transaction](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-credit-refund)
* [Credit a Transaction](Sections/Transactions.md#referenced-transactions-capture-ship-void-or-credit-refund)
* [Refund a Customer](Sections/Transactions.md#refund-a-customer)
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

Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to branch these documents and send a pull request with improvements!

Versions
------------
For our other supported versions of the APIs please see the below:

* [Version 3.1](https://github.com/PayFabric/APIs/tree/V3.1)
* [Version 2.0](https://github.com/PayFabric/APIs/tree/v2)
