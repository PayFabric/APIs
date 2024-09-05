API Guide
==============
PayFabric Receivables APIs are organized around Representational State Transfer (**REST**) architecture and are designed to have predictable, resource-oriented URLs and use HTTP response codes to indicate API errors. Below are the two API endpoints:

Website API: ``https://{PayFabric URL}/customerportal/api/{PortalName}/api``  
Sync API: ``https://{PayFabric URL}/receivables/sync/api/{PortalName}/api``

Where do I start?
-----------------

Want to get started with PayFabric Receivables API integration? Here's a quick check list:

1. Sign-up and configure your own PayFabric Receivables site to be used with the APIs.
    - For more information on using PayFabric Receivables please view the [User Guide](https://www.nodus.com/payfabric-receivables-user-guide/)
2. Read up on which [API endpoint](#API-endpoints) to use. 
3. Read up on how to [authenticate](#authentication) with the APIs. 
4. Read up on how to [handle errors](#handling-exceptions) with the APIs.
5. Browse the [API docs](#api-documentation) for the API you need to work with, you could also view our [language specific examples](Samples).
6. Have a question or need help? Contact <support@nodus.com>.


API Endpoints
-------------
The two API endpoints are used in various different and similar ways. The sync api will be used for integrating data to and from the PayFabric Receivables website. The website api will be used for all other calls, which include getting invoices, processing payments, and viewing data.


Authentication
--------------
All PayFabric Receivables API calls need a header containing the authorization token. Both api endpoints use similar methods of getting the authorization token, however, they can be used slightly differently.

Customer Portal API: We have a [detailed guide](Sections/APIs/API/Token.md) for authenticating with the PayFabric Receivables API.  
Sync API: We have a [detailed guide](Sections/APIs/Sync/Token.md) for authenticating with the PayFabric Receivables Sync API.  

If the need to call the customer portal API as an impersonated customer user, here is the [detailed guide](Sections/APIs/API/TokenImpersonate.md).


Handling Exceptions
-------------------
PayFabric Receivables uses HTTP response codes to indicate the status of requests.

We have a [guide](Sections/Errors.md) detailing the meanings of the most common response codes that you will encounter.


API Documentation
-----------------
PayFabric Receivables sends and receives payloads as structured [JSON Objects](Sections/Objects). Many of these objects are used in both requests and responses. Some of the objects (like Address) are embedded
as child elements of other objects.

## Sync API

### AutoPay
* [`POST` Create AutoPay Request](Sections/APIs/Sync/AutoPay.md#create-autopay-request)

### Currencies
* [`POST` Create a Currency](Sections/APIs/Sync/Currencies.md#create-a-currency)
* [`DELETE` Delete a Currency](Sections/APIs/Sync/Currencies.md#delete-a-currency)
* [`GET` Retrieve a Currency](Sections/APIs/Sync/Currencies.md#retrieve-a-currency-by-currency-code)

### Customers
* [`DELETE` Delete a Customer](Sections/APIs/Sync/Customers.md#delete-a-customer)
* [`GET` Retrieve a Customer](Sections/APIs/Sync/Customers.md#retrieve-a-customer-by-customer-identifier)
* [`POST` Create or Update a Customer](Sections/APIs/Sync/Customers.md#create-or-update-a-customer)
* [`PATCH` Update a Customer ID](Sections/APIs/Sync/Customers.md#update-a-customer-id)
* [`GET` Retrieve Customers Report](Sections/APIs/Sync/Customers.md#retrieve-customers-report)

### Email
* [`GET` Retrieve Email Report](Sections/APIs/Sync/Email.md#retrieve-email-report)

### Integrations
* [`PATCH` Update the Integration Document](Sections/APIs/Sync/Integrations.md#update-the-integration-document)
* [`GET` Retrieve Integration Documents](Sections/APIs/Sync/Integrations.md#retrieve-integration-documents)

### Invoices
* [`POST` Create or Update an Invoice](Sections/APIs/Sync/Invoices.md#create-or-update-an-invoice)
* [`POST` Create or Update an Invoice with an Attachment](Sections/APIs/Sync/Invoices.md#create-or-update-an-invoice-with-an-attachment)
* [`PATCH` Update an Invoice](Sections/APIs/Sync/Invoices.md#update-an-invoice)
* [`PATCH` Update an Invoice Attachment](Sections/APIs/Sync/Invoices.md#update-an-invoice-attachment)
* [`GET` Retrieve an Invoice](Sections/APIs/Sync/Invoices.md#retrieve-an-invoice)
* [`GET` Retrieve Invoices Report](Sections/APIs/Sync/Invoices.md#retrieve-invoices-report)

### Items
* [`POST` Create or Update an Item](Sections/APIs/Sync/Items.md#create-or-update-an-item)
* [`GET` Retrieve an Item](Sections/APIs/Sync/Items.md#retrieve-an-item)

### Payments
* [`POST` Create or Update a Payment](Sections/APIs/Sync/Payments.md#create-or-update-a-payment)
* [`GET` Retrieve Payments](Sections/APIs/Sync/Payments.md#retrieve-payments-by-query-parameters)
* [`GET` Retrieve a Payment](Sections/APIs/Sync/Payments.md#retrieve-a-payment)
* [`GET` Retrieve an Application Record](Sections/APIs/Sync/Payments.md#retrieve-an-application-record)
* [`PATCH` Void a Payment](Sections/APIs/Sync/Payments.md#void-a-payment)
* [`POST` Create/Send a Payment Request](Sections/APIs/Sync/Payments.md#createsend-a-payment-request)
* [`GET` Retrieve Payments Report](Sections/APIs/Sync/Payments.md#retrieve-payments-report)

### Payment Methods
* [`POST` Create Payment Method Request](Sections/APIs/Sync/PaymentMethod.md#create-payment-method-request)

### Settings
* [`PATCH` Update Company Information](Sections/APIs/Sync/Settings.md#update-company-information)
* [`POST` Upload Company Logo](Sections/APIs/Sync/Settings.md#upload-company-logo)
* [`POST` Update Company Style](Sections/APIs/Sync/Settings.md#upload-company-style)
* [`PATCH` Update Customer Setup](Sections/APIs/Sync/Settings.md#update-customer-setup)
* [`PATCH` Update Invoice Setup](Sections/APIs/Sync/Settings.md#update-invoice-setup)
* [`POST` Create or Update Invoice Types](Sections/APIs/Sync/Settings.md#create-or-update-invoice-types)
* [`POST` Create or Update Invoice Templates](Sections/APIs/Sync/Settings.md#create-or-update-invoice-templates)
* [`POST` Create or Update Invoice Payment Terms](Sections/APIs/Sync/Settings.md#create-or-update-invoice-payment-terms)
* [`PATCH` Update Invoice Table Display](Sections/APIs/Sync/Settings.md#update-invoice-table-display)
* [`POST` Create or Update Payment Transaction Processing](Sections/APIs/Sync/Settings.md#create-or-update-payment-transaction-processing)
* [`PATCH` Update Payment Preferences](Sections/APIs/Sync/Settings.md#update-payment-preferences)
* [`POST` Create or Update an Autopay Template](Sections/APIs/Sync/Settings.md#create-or-update-an-autopay-template)
* [`PATCH` Update Integration](Sections/APIs/Sync/Settings.md#update-integration)
* [`POST` Create or Update Email Templates](Sections/APIs/Sync/Settings.md#create-or-update-email-templates)
* [`GET` Retrieve Email Templates](Sections/APIs/Sync/Settings.md#retrieve-email-templates)
* [`GET` Retrieve Invoice Types](Sections/APIs/Sync/Settings.md#retrieve-invoice-types)

### Subscription
* [`POST` Create or Update a Subscription](Sections/APIs/Sync/Subscriptions.md#create-or-update-a-subscription)
* [`GET` Retrieve a Subscription](Sections/APIs/Sync/Subscriptions.md#retrieve-a-subscription)
* [`GET` Retrieve Sbuscription Report](Sections/APIs/Sync/Subscriptions.md#retrieve-subscription-report)

### Tax
* [`POST` Create or Update a Tax](Sections/APIs/Sync/Taxes.md#create-or-update-a-tax)
* [`GET` Retrieve Taxes](Sections/APIs/Sync/Taxes.md#retrieve-taxes-by-query)


## Customer Portal API

### Accounts
* [`GET` Retrieve the current user](Sections/APIs/API/Accounts.md#retrieve-the-current-user)
* [`GET` Retrieve customer Users](Sections/APIs/API/Accounts.md#get-all-customer-users)
* [`POST` Create a customer User](Sections/APIs/API/Accounts.md#create-a-customer-User)
* [`PUT` Update a customer User](Sections/APIs/API/Accounts.md#update-a-customer-User)
* [`POST` Send Forgot Password Email](Sections/APIs/API/Accounts.md#send-forgot-password-email)
* [`POST` Send Forgot UserName Email](Sections/APIs/API/Accounts.md#send-forgot-userName-email)
* [`GET` Verify access code](Sections/APIs/API/Accounts.md#verify-access-code)
* [`POST` Update an user's profile](Sections/APIs/API/Accounts.md#Update-an-user's-profile)
* [`GET` Retrieve Registration Key](Sections/APIs/API/Accounts.md#retrieve-a-registration-key)
* [`POST` Invite a Customer User](Sections/APIs/API/Accounts.md#invite-a-customer-user)
* [`GET` Verify registration key](Sections/APIs/API/Accounts.md#verify-registration-key)
* [`POST` Send Reset Password Email](Sections/APIs/API/Accounts.md#send-reset-password-email)

### AutoPay
* [`GET` Retrieve all AutoPay templates](Sections/APIs/API/AutoPays.md#retrieve-all-autopay-templates)
* [`GET` Retrieve a specific AutoPay template](Sections/APIs/API/AutoPays.md#retrieve-a-specific-autopay-template)
* [`GET` Retrieve the current customer's AutoPay](Sections/APIs/API/AutoPays.md#retrieve-the-current-customers-autopay)
* [`POST` Save an AutoPay](Sections/APIs/API/AutoPays.md#save-an-autopay)
* [`PATCH` Update an AutoPay](Sections/APIs/API/AutoPays.md#update-an-autopay)
* [`DELETE` Delete an AutoPay](Sections/APIs/API/AutoPays.md#delete-an-autopay)

### Currencies
* [`GET` Retrieve a Currency](Sections/APIs/API/Currencies.md#retrieve-a-currency)

### Customers
* [`PATCH` Update a Customer by Id](Sections/APIs/API/Customers.md#update-a-customer-by-id)
* [`GET` Retrieve the current customer](Sections/APIs/API/Customers.md#retrieve-the-current-customer)

### DocumentHistory
* [`GET` Retrieve Document History](Sections/APIs/API/DocumentHistory.md#retrieve-document-history)
* [`GET` Retrieve Document History Currencies](Sections/APIs/API/DocumentHistory.md#retrieve-document-history-currencies)
* [`POST` Export Document History](Sections/APIs/API/DocumentHistory.md#export-document-history)

### Invoices
* [`GET` Retrieve invoice currencies by query parameters](Sections/APIs/API/Invoices.md#retrieve-invoice-currencies-by-query-parameters)
* [`GET` Retrieve invoice html to be displayed by identity](Sections/APIs/API/Invoices.md#retrieve-invoice-html-to-be-displayed-by-identity)
* [`GET` Retrieve invoice html to be displayed by invoiceGuid](Sections/APIs/API/Invoices.md#retrieve-invoice-html-to-be-displayed-by-invoiceGuid)
* [`GET` Retrieve outstanding invoices by paging query parameters](Sections/APIs/API/Invoices.md#retrieve-outstanding-invoices-by-paging-query-parameters)
* [`GET` View Outstanding Invoices All Selected](Sections/APIs/API/Invoices.md#view-outstanding-invoices-all-selected)
* [`POST` Export Outstanding Invoices](Sections/APIs/API/Invoices.md#export-outstanding-invoices)
* [`GET` View Paid Invoices](Sections/APIs/API/Invoices.md#view-paid-invoices)
* [`GET` View Past Due Invoices](Sections/APIs/API/Invoices.md#view-past-due-invoices)
* [`GET` Retrieve Invoice AttachmentId by identity](Sections/APIs/API/Invoices.md#retrieve-invoice-attachmentId-by-identity)
* [`GET` Retrieve Invoice AttachmentId by invoiceGuid](Sections/APIs/API/Invoices.md#retrieve-invoice-attachmentId-by-invoiceGuid)
* [`GET` Download Invoice Attachment by identity](Sections/APIs/API/Invoices.md#download-invoice-attachment-by-identity)
* [`GET` Download Invoice Attachment by invoiceGuid](Sections/APIs/API/Invoices.md#download-invoice-attachment-by-invoiceGuid)

### PaymentMethods
* [`GET` Retrieve Payment Methods by Currency Code](Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-by-currency-code)
* [`DELETE` Delete a Payment Method](Sections/APIs/API/PaymentMethods.md#delete-a-payment-method)
* [`GET` Retrieve the Edit Wallet URL for PayFabric Hosted Page](Sections/APIs/API/PaymentMethods.md#retrieve-the-edit-wallet-url-for-payfabric-hosted-page)
* [`GET` Retrieve the Create Wallet URL for PayFabric Hosted Page](Sections/APIs/API/PaymentMethods.md#retrieve-the-create-wallet-url-for-payfabric-hosted-page)
* [`GET` Retrieve the Default Payment Method](Sections/APIs/API/PaymentMethods.md#retrieve-the-default-payment-method)
* ~~[`GET` Retrieve Payment Checkout Page URL](Sections/APIs/API/PaymentMethods.md#retrieve-payment-checkout-page-url-deprecated)~~ (Deprecated)
* [`GET` Retrieve Payment Methods Paging](Sections/APIs/API/PaymentMethods.md#retrieve-payment-methods-paging)
* [`GET` Retrieve TenderType Enabling on Wallet Page](Sections/APIs/API/PaymentMethods.md#retrieve-tendertype-enabling-on-wallet-page)
* [`GET` Retrieve the View Wallet URL for PayFabric Hosted Page](Sections/APIs/API/PaymentMethods.md#retrieve-the-view-wallet-url-for-payfabric-hosted-page)
* [`GET` Retrieve the Number of Subscriptions Associated to the Wallet](Sections/APIs/API/PaymentMethods.md#retrieve-the-number-of-subscriptions-associated-to-the-wallet)
* [`POST` Create JWT for PayFabric Hosted Checkout Page](Sections/APIs/API/PaymentMethods.md#create-jwt-for-payfabric-hosted-checkout-page)

### Payments
* [`DELETE` Delete Payments](Sections/APIs/API/Payments.md#delete-payments)
* [`PATCH` Update an Existing Payment](Sections/APIs/API/Payments.md#update-an-existing-payment)
* [`PATCH` Update an InProgress Payment](Sections/APIs/API/Payments.md#update-an-existing-inprogress-payment)
* [`POST` Create an InProgress Payment](Sections/APIs/API/Payments.md#create-an-inprogress-payment)
* [`POST` Process an Existing Payment](Sections/APIs/API/Payments.md#process-an-existing-payment)
* [`GET` Retrieve InProgress Payment](Sections/APIs/API/Payments.md#retrieve-inprogress-payment)
* [`GET` Retrieve Payment Receipt](Sections/APIs/API/Payments.md#retrieve-payment-receipt)
* [`GET` Retrieve Payment Details](Sections/APIs/API/Payments.md#retrieve-payment-details)
* [`GET` Retrieve Application Record Receipt](Sections/APIs/API/Payments.md#retrieve-application-record-receipt)
* [`GET` Retrieve Application Record Details](Sections/APIs/API/Payments.md#retrieve-application-record-details)
* [`GET` Download Payment Receipt](Sections/APIs/API/Payments.md#download-payment-receipt)
* [`GET` Download Payment Details](Sections/APIs/API/Payments.md#download-payment-details)
* [`GET` Download Application Record Receipt](Sections/APIs/API/Payments.md#download-application-record-receipt)
* [`GET` Download Application Record Details](Sections/APIs/API/Payments.md#download-application-record-details)
* ~~[`POST` Create JWT for PayFabric Hosted Checkout Page](Sections/APIs/API/Payments.md#create-jwt-for-payfabric-hosted-checkout-page)~~ (Deprecated)
* [`PATCH` Update existing payment transaction using hosted checkout page](Sections/APIs/API/Payments.md#update-existing-payment-transaction-using-hosted-checkout-page)
* [`POST` Create a New Transaction for Hosted Checkout Page After Transaction Failed Once](Sections/APIs/API/Payments.md#create-a-new-transaction-for-hosted-checkout-page-after-transaction-failed-once)



Pass-Through Authentication
----------------------
* [Instructions](../Receivables/PassThroughAuthentication.md)  


Help us make it better
----------------------
Please tell us how we can make the APIs better. If you have a specific feature request or if you found a bug, please contact <support@nodus.com>. Also, feel free to branch these documents and send a pull request with improvements!
