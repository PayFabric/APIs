PayLink APIs
==============
PayLink APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the API endpoints:

1. Live Server:    ``https://www.payfabric.com``
1. Sandbox Server: ``https://sandbox.payfabric.com``

Where do I start?
-----------------

Want to get started with PayLink API integration? Here's a quick check list:

1. Configure a PayLink service, check out the [Configure Portal](https://github.com/PayFabric/Portal/blob/master/PayLink/README.md) to learn how.
2. Read up on how to [authenticate](#authentication) with our APIs. 
3. Read up on how to [handle errors](#handling-exceptions) with our APIs.
4. Browse the [API docs](#api-documentation) for the API you need to work with.
5. Have a question or need help? Contact <support@payfabric.com>.


Authentication
--------------
PayLink clients require PayFabric *Device ID* and *Device Password* to authenticate with APIs.

We have a [detailed guide](https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Authentication.md) in our PayFabric documentation for more details.


Handling Exceptions
-------------------
PayLink uses HTTP response codes to indicate the status of requests. 

We have a [guide](/PayLink/Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


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
* [Get Post Data](/PayLink/Sections/PayLinks.md#get-post-data)
* [Update Post Data](/PayLink/Sections/PayLinks.md#update-post-data)
* [Resubmit Post Data](/PayLink/Sections/PayLinks.md#resubmit-post-data)

### Wallet Links
* [Create a Wallet Link](/PayLink/Sections/WalletLinks.md#create-a-walletlink)
* [Retrieve a Wallet Link URL](/PayLink/Sections/WalletLinks.md#retrieve-a-walletlink-url)
* [Cancel a Wallet Link](/PayLink/Sections/WalletLinks.md#cancel-a-walletlink)

### Notifications
* [Resend PayLink Notification Email](/PayLink/Sections/Notifications.md#resend-paylink-notifiation-email)
* [Resend PayLink Notification SMS](/PayLink/Sections/Notifications.md#resend-paylink-notification-sms)
* [Retrieve SMS Notification Templates](/PayLink/Sections/Notifications.md#retrieve-sms-notification-templates)

### Templates
* [Create Template](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#create-template-for-specific-template-type)
* [Update Template](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#update-template)
* [Copy Template](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#copy-template)
* [Delete Template](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#delete-template)
* [Set Default template](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#set-specific-template-as-default-template)
* [Get Templates](https://github.com/PayFabric/APIs/blob/master/PayLink/Sections/Templates.md#get-templates-by-template-type)

Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@payfabric.com>. Also, feel free to branch these docs and send a pull request with improvements!
