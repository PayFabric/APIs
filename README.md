PayFabric APIs
==============
PayFabric APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com/v2/rest/api``
1. Sandbox Server: ``https://sandbox.payfabric.com/v2/rest/api``

Where do I start?
-----------------

Want to get started with PayFabric API integration? Here's a quick check list:

1. Register and then configure a PayFabric account, check out the [Quick Start Guide](https://github.com/PayFabric/Portal/wiki) to learn how.
2. Read up on how to [authenticate](#authentication) with our APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with our APIs.
3. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Samples).
4. Have a question or need help? Contact <support@payfabric.com>.


Authentication
--------------
PayFabric clients have two ways to authenticate, *Device ID* and *Password* authentication and *Security Token* authentication.

We have a [detailed guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Authentication.md) for authenticating your users with our APIs.


Handling Exceptions
-------------------
PayFabric uses HTTP response codes to indicate the status of requests. 

We have a [guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
PayFabric sends and receives payloads as structured [JSON Objects](https://github.com/PayFabric/APIs/wiki/API-Object-V2). 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

### Transactions
* [Create a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#create-a-transaction)
* [Update a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#update-a-transaction)
* [Process a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#process-a-transaction)
* [Create and Process a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#create-and-process-a-transaction)
* [Retrieve a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#retrieve-a-transaction)
* [Retrieve Transactions](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#retrieve-transactions)
* [Capture a Pre-Authorized Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#cancel-a-transaction-or-capture-a-pre-authorized-transaction)
* [Cancel a Transaction](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#cancel-a-transaction-or-capture-a-pre-authorized-transaction)
* [Refund a Customer](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Transactions.md#refund-a-customer)

### Wallets / Credit Cards / eChecks
* [Create a Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#create-a-credit-card)
* [Update a Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#update-a-credit-card--echeck)
* [Retrieve a Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#retrieve-a-credit-card--echeck)
* [Retrieve Credit Cards / eChecks](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#retrieve-credit-cards--echecks)
* [Lock Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#lock-credit-card--echeck)
* [Unlock Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#unlock-credit-card--echeck)
* [Remove Credit Card / eCheck](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Wallets.md#remove-credit-card--echeck)

### Payment Gateway Profiles
* [Retrieve a Payment Gateway Profile](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/PaymentGatewayProfiles.md#retrieve-a-payment-gateway-profile)
* [Retrieve Payment Gateway Profiles](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/PaymentGatewayProfiles.md#retrieve-payment-gateway-profiles)

### Addresses
* [Retrieve a Shipping Address](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Addresses.md#retrieve-a-shipping-address)
* [Retrieve Shipping Addresses](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Addresses.md#retrieve-shipping-addresses)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to fork these docs and send a pull request with improvements!
