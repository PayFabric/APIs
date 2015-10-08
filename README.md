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
3. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Samples/README.md).
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
* [Create a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-a-transaction)
* [Update a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#update-a-transaction)
* [Process a Transaction by Transaction Key](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#submit-a-transaction-to-payment-gateway-by-transaction-key)
* [Create and process a Transaction by Transaction Object](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-and-submit-a-transaction-by-transaction-object)
* [Retrieve a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-a-transaction)
* [Capture a Pre-Authorized Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#capture-a-pre-authorized-transaction)
* [Cancel a Transaction](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#cancel-a-transaction)
* [Refund a Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#refund-a-customer)

### Wallets / Credit Cards / eChecks
* [Add a Card or eCheck into Wallet](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#create-a-credit-card)
* [Update an Existing Card or eCheck](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#update-an-existing-card)
* [Remove a Card or eCheck](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#delete-a-card)
* [Retrieve Cards and eChecks by Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-cards-by-customer)

### Payment Gateways
* [Retrieve All Gateway Account Profiles](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-all-payment-gateways)
* [Retrieve a Gateway Account Profile By Id](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-a-payment-gateway-by-id)

### Addresses
* [Retrieve Shipping addresses by Customer](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-shipping-addresses-by-customer)
* [Retrieve Shipping address by Id](https://github.com/PayFabric/APIs/wiki/API-Reference---V2#get-shipping-address-by-id)

Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to fork these docs and send a pull request with improvements!
