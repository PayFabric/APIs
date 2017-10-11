PayFabric APIs - Version 2.0
==============
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com/v2/rest/api``
1. Sandbox Server: ``https://sandbox.payfabric.com/v2/rest/api``

Where do I start?
-----------------

Want to get started with PayFabric API integration? Here's a quick check list:

1. Register and then configure a PayFabric account, check out the [Quick Start Guide](https://github.com/PayFabric/Portal/tree/v2/Sections/Quick%20Start.md) to learn how.
2. Read up on how to [authenticate](#authentication) with our APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with our APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](https://github.com/PayFabric/APIs/tree/v2/Samples).
5. Have a question or need help? Contact <support@payfabric.com>.


Authentication
--------------
PayFabric clients have two ways to authenticate, *Device ID* and *Password* authentication and *Security Token* authentication.

We have a [detailed guide](Sections/Authentication.md) for authenticating your users with our APIs.


Handling Exceptions
-------------------
PayFabric uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
PayFabric sends and receives payloads as structured [JSON Objects](Sections/Objects). 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

### Transactions
* [Create a Transaction](Sections/Transactions.md#create-a-transaction)
* [Update a Transaction](Sections/Transactions.md#update-a-transaction)
* [Process a Transaction](Sections/Transactions.md#process-a-transaction)
* [Create and Process a Transaction](Sections/Transactions.md#create-and-process-a-transaction)
* [Retrieve a Transaction](Sections/Transactions.md#retrieve-a-transaction)
* [Retrieve Transactions](Sections/Transactions.md#retrieve-transactions)
* [Cancel (Void) a Transaction](Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
* [Capture a Pre-Authorized Transaction](Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
* [Credit a Transaction](Sections/Transactions.md#referenced-transactions-void-capture-ship-or-credit)
* [Refund a Customer](Sections/Transactions.md#refund-a-customer)

### Wallets / Credit Cards / eChecks
* [Create a Credit Card / eCheck](Sections/Wallets.md#create-a-credit-card)
* [Update a Credit Card / eCheck](Sections/Wallets.md#update-a-credit-card--echeck)
* [Retrieve a Credit Card / eCheck](Sections/Wallets.md#retrieve-a-credit-card--echeck)
* [Retrieve Credit Cards / eChecks](Sections/Wallets.md#retrieve-credit-cards--echecks)
* [Lock Credit Card / eCheck](Sections/Wallets.md#lock-credit-card--echeck)
* [Unlock Credit Card / eCheck](Sections/Wallets.md#unlock-credit-card--echeck)
* [Remove Credit Card / eCheck](Sections/Wallets.md#remove-credit-card--echeck)

### Payment Gateway Profiles
* [Retrieve a Payment Gateway Profile](Sections/PaymentGatewayProfiles.md#retrieve-a-payment-gateway-profile)
* [Retrieve Payment Gateway Profiles](Sections/PaymentGatewayProfiles.md#retrieve-payment-gateway-profiles)

### Addresses
* [Retrieve a Shipping Address](Sections/Addresses.md#retrieve-a-shipping-address)
* [Retrieve Shipping Addresses](Sections/Addresses.md#retrieve-shipping-addresses)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to branch these documents and send a pull request with improvements!

API Versions
------------
For our other supported versions of the APIs please see the below:

* [Version 1.0](https://github.com/PayFabric/APIs/tree/v1)
* [Latest Version](https://github.com/PayFabric/APIs)
