API Guide
==============
PayFabric Receivables APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the two API endpoints:

Website API: ``https://<PayFabric Receivables Site URL>/receivablesapi/{PortalName}/api``  
Sync API: ``https://<PayFabric Receivables Site URL>/sync/{PortalName}/api``

Where do I start?
-----------------

Want to get started with PayFabric Receivables API integration? Here's a quick check list:

1. Sign-up and configure your own PayFabric Receivables site to be used with the APIs.
    - For more information on using PayFabric Receivables please view the [User Guide](http://www.nodus.com/documentation/PayFabric-Receivables-User-Guide.pdf)
2. Read up on which [API endpoint](#API-endpoints) to use. 
3. Read up on how to [authenticate](#authentication) with the APIs. 
4. Read up on how to [handle errors](#handling-exceptions) with the APIs.
5. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](Samples).
6. Have a question or need help? Contact <support@nodus.com>.


API Endpoints
-------------
The two API endpoints are used in various different and similar ways. The sync api will be used for sync'ing data to the PayFabric Receivables website, while the website api will be used for all other calls; these calls include getting invoices, processing payments, and viewing data.


Authentication
--------------
All PayFabric Receivables API calls need a header containing the authorization token. Both api endpoints use similar methods of getting the authorization token, however, they can be used slightly differently.

Website API: We have a [detailed guide](Sections/APIs/API/Token.md) for authenticating with the PayFabric Receivables API.  
Sync API: We have a [detailed guide](Sections/APIs/Sync/Token.md) for authenticating with the PayFabric Receivables Sync API.


Handling Exceptions
-------------------
PayFabric Receivables uses HTTP response codes to indicate the status of requests. 

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter. 


API Documentation
-----------------
PayFabric Receivables sends and receives payloads as structured [JSON Objects](Sections/Objects). 
Many of these objects are used in both requests and responses. Some of the objects (like Address) are embedded
as child elements of other objects.

## Sync API

### Currencies
* [Create a Currency](Sections/APIs/Sync/Currencies.md#create-a-currency)
* [Delete a Currency](Sections/APIs/Sync/Currencies.md#delete-a-currency)
* [Retrieve a Currency](Sections/APIs/Sync/Currencies.md#create-a-currency)

### Customers
* [Delete a Customer](Sections/APIs/Sync/Customers.md#delete-a-customer)
* [Retrieve a Customer](Sections/APIs/Sync/Customers.md#retrieve-customers)
* [Create or Update a Customer](Sections/APIs/Sync/Customers.md#create-or-update-a-customer)

### Integrations
* [Update the Integration Document](Sections/APIs/Sync/Integrations.md#update-the-integration-document)
* [Retrieve Integration Documents](Sections/APIs/Sync/Integrations.md#retrieve-integration-documents)
* [Retrieve Integration Payment Information](Sections/APIs/Sync/Integrations.md#retrieve-integration-payment-information)

### Invoices
* [Create or Update an Invoice](Sections/APIs/Sync/Invoices.md#create-or-update-an-invoice)

### Payments
* [Create or Update a Payment](Sections/APIs/Sync/Payments.md#create-or-update-a-payment)
* [Retrieve Payments](Sections/APIs/Sync/Payments.md#retrieve-payments)
* [Retrieve a Payment](Sections/APIs/Sync/Payments.md#retrieve-payments)
* [Void a Payment](Sections/APIs/Sync/Payments.md#void-payment)


## Receivables API

### Accounts
* [Retrieve the current user](Sections/APIs/API/Accounts.md#retrieve-the-current-user)
* [Create a customer User](Sections/APIs/API/Accounts.md#create-a-customer-User)
* [Update a customer User](Sections/APIs/API/Accounts.md#update-a-customer-User)
* [Send Forgot Password Email](Sections/APIs/API/Accounts.md#send-forgot-password-email)
* [Send Forgot UserName Email](Sections/APIs/API/Accounts.md#send-forgot-userName-email)
* [Verify access code](Sections/APIs/API/Accounts.md#verify-access-code)
* [Update an user's profile](Sections/APIs/API/Accounts.md#Update-an-user's-profile)
* [Retrieve Registration Key](Sections/APIs/API/Accounts.md#retrieve-registration-key)
* [Verify registration key](Sections/APIs/API/Accounts.md#verify-registration-key)
* [Send Reset Password Email](Sections/APIs/API/Accounts.md#send-reset-password-email)
* [Retrieve customer's email](Sections/APIs/API/Accounts.md#retrieve-customer's-email)

### Currencies
* [Retrieve a Currency](Sections/APIs/API/Currencies.md#retrieve-a-currency)

### Customers
* [Update a Customer by Id](Sections/APIs/API/Customers.md#update-a-customer-by-id)
* [Retrieve the current customer](Sections/APIs/API/Customers.md#retrieve-the-current-customer)

### DocumentHistory
* [Retrieve Document History](Sections/APIs/API/DocumentHistory.md#retrieve-document-history)
* [Retrieve Document History Currencies](Sections/APIs/API/DocumentHistory.md#retrieve-document-history-currencies)
* [Export Document History](Sections/APIs/API/DocumentHistory.md#export-document-history)

### Invoices
* [Retrieve invoice currencies by query parameters](Sections/APIs/API/Invoices.md#retrieve-invoice-currencies-by-query-parameters)
* [Retrieve invoice html to be displayed by invoiceId](Sections/APIs/API/Invoices.md#retrieve-invoice-html-to-be-displayed-by-invoiceId)
* [Retrieve invoice html to be displayed by identity](Sections/APIs/API/Invoices.md#retrieve-invoice-html-to-be-displayed-by-identity)
* [Retrieve outstanding invoices by paging query parameters](Sections/APIs/API/Invoices.md#retrieve-outstanding-invoices-by-paging-query-parameters)
* [View Outstanding Invoices All Selected](Sections/APIs/API/Invoices.md#view-outstanding-invoices-all-selected)
* [Export Outstanding Invoices](Sections/APIs/API/Invoices.md#export-outstanding-invoices)
* [View Paid Invoices](Sections/APIs/API/Invoices.md#view-paid-invoices)
* [View Past Due Invoices](Sections/APIs/API/Invoices.md#view-past-due-invoices)

### PaymentMethods
* [Retrieve Payment Methods by Currency Code](Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-by-currency-code)
* [Delete a Payment Method](Sections/APIs/API/PaymentMethods.md#delete-a-payment-method)
* [Retrieve the Edit Wallet URL for PayFabric Hosted Page](Sections/APIs/API/PaymentMethods.md#retrieve-the-edit-wallet-url-for-payfabric-hosted-page)
* [Retrieve a Payment Method and verify currency](Sections/APIs/API/PaymentMethods.md#retrieve-a-payment-method-and-verify-currency)
* [Retrieve the Create Wallet URL for PayFabric Hosted Page](Sections/APIs/API/PaymentMethods.md#retrieve-the-create-wallet-url-for-payfabric-hosted-page)
* [Retrieve the Default Payment Method](Sections/APIs/API/PaymentMethods.md#retrieve-the-default-payment-method)
* [Retrieve Payment Methods Paging](Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-paging)
* [Retrieve TenderType Enabling on Wallet Page](Sections/APIs/API/PaymentMethods.md#retrieve-tendertype-enabling-on-wallet-page)

### Payments
* [Process a Payment](Sections/APIs/API/Payments.md#process-a-payment)
* [Retrieve Payment Receipt](Sections/APIs/API/Payments.md#retrieve-payment-receipt)


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@nodus.com>. Also, feel free to branch these documents and send a pull request with improvements!
