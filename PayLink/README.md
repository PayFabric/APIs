PayLink APIs
==============
PayLink APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com/PayLink``
1. Sandbox Server: ``https://sandbox.payfabric.com/PayLink``

Where do I start?
-----------------

Want to get started with PayLink API integration? Here's a quick check list:

1. Configure a PayLink service, check out the [Configure Portal](../../../Portal/blob/master/Sections/Configure%20Portal.md) to learn how.
2. Read up on how to [authenticate](#authentication) with our APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with our APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with.
5. Have a question or need help? Contact <support@payfabric.com>.


Authentication
--------------
PayLink clients require a PayFabric *Security Token* to authenticate with APIs.

We have a [detailed guide](https://github.com/PayFabric/APIs/blob/master/Sections/Authentication.md#security-token) in our PayFabric documentation for creating a new *Security Token*.


Handling Exceptions
-------------------
PayLink uses HTTP response codes to indicate the status of requests. 

We have a [guide](/Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
PayLink sends and receives payloads as structured [JSON Objects](Sections/JSON%20Objects.md). 
Many of these objects are used in both requests and responses. Some of the objects (like Address or Cardholder) are embedded
as child elements of other objects.

### PayLinks
* [Create a PayLink](/PayLink/Sections/PayLinks.md#create-a-paylink)
* [Update a PayLink](/PayLink/Sections/PayLinks.md#update-a-paylink)
* [Retrieve a PayLink](/PayLink/Sections/PayLinks.md#retrieve-a-paylink)
* [Retrieve PayLinks](/PayLink/Sections/PayLinks.md#retrieve-paylinks)
* [Retrieve a PayLink URL](/PayLink/Sections/PayLinks.md#retrieve-a-paylink-url)
* [Remove a PayLink](/PayLink/Sections/PayLinks.md#remove-a-paylink)
* [Cancel a PayLink](/PayLink/Sections/PayLinks.md#cancel-a-paylink)

### WalletLinks
* [Create a WalletLink](/PayLink/Sections/WalletLinks.md#create-a-walletlink)
* [Retrieve a WalletLink URL](/PayLink/Sections/WalletLinks.md#retrieve-a-walletlink-url)
* [Cancel a WalletLink](/PayLink/Sections/WalletLinks.md#cancel-a-walletlink)

### Notifications
* [Resend PayLink Notification Email](/PayLink/Sections/Notifications.md#resend-paylink-notifiation-email)
* [Resend PayLink Notification SMS](/PayLink/Sections/Notifications.md#resend-paylink-notification-sms)
* [Retrieve SMS Notification Templates](/PayLink/Sections/Notifications.md#retrieve-sms-notification-templates)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to branch these docs and send a pull request with improvements!
