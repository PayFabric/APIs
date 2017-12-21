Notifications
=============

The Notifications API is used for resending PayLink notifications, and retrieve available SMS notification templates. Please note that all requests require API authentication by PayFabric *Security Token*, see our [guide](https://github.com/PayFabric/APIs/blob/v2/Sections/Authentication.md#security-token) on how to create a token.

Resend PayLink Notification Email
---------------------------------

* `POST api/notification/email/gwx9q6fqcEuagAJLA27CIA` will resend the specified documents' email notification

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 400 Bad Request Response if the notification fails.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document status is not 1.  

Resend PayLink Notification SMS
-------------------------------

* `POST api/notification/sms/gwx9q6fqcEuagAJLA27CIA` will resend the specified documents' sms notification

###### Response
A successful `POST` will result in a HTTP 200 OK Response.  
A failed `POST` may result in a HTTP 400 Bad Request Response if the notification fails.  
A failed `POST` may result in a HTTP 404 Not Found Response if the specified document does not exist or the Device ID used for the *Security Token* does not match.  
A failed `POST` may result in a HTTP 405 Method Not Allowed Response if the specified document status is not 1. 

Retrieve Email Notification Templates
-----------------------------------

* `GET api/notification/email/templates` will return all email notification templates configured in the PayLink portal

###### Related Reading
* [How to Create Notification Templates](https://github.com/PayLink/Portal/blob/v2/Sections/Features.md.md#templates)

###### Response
<pre>
[
  {
    "Id": "f06e91f0-98b2-4fb6-a58d-ab5368a3cd4a",
    "Name": "Standard",
    "Subject": "Invoice",
    "Contents": "Dear [[[Document.CustomerName]]], your invoice(s) for [[[Transaction.TransactionAmount]]] is now ready to view and pay at [[[Document.PayLinkURL]]]"
  },
  {
    "Id": "33665f05-8346-4809-e0f1-01050545236f",
    "Name": "Custom",
    "Subject": "Invoice",
    "Contents": "From [[[Profile.CompanyName]]]: Your invoice(s) for [[[Transaction.TransactionAmount]]] is now ready to view and pay at [[[Document.PayLinkURL]]].  If you think this is in error, please call us on [[[Profile.Phone]]]."
  }
]
</pre>


Retrieve SMS Notification Templates
-----------------------------------

* `GET api/notification/sms/templates` will return all SMS notification templates configured in the PayLink portal

###### Related Reading
* [How to Create Notification Templates](https://github.com/PayLink/Portal/blob/v2/Sections/Features.md#templates)

###### Response
<pre>
[
  {
    "Id": "f06e91f0-98b2-4fb6-a58d-ab5368a3cd4a",
    "Name": "Standard",
    "Message": "[[[Profile.CompanyName]]] Message: Dear [[[Document.CustomerName]]], your invoice(s) for [[[Transaction.TransactionAmount]]] is now ready to view and pay at [[[Document.PayLinkURL]]]"
  },
  {
    "Id": "33665f05-8346-4809-e0f1-01050545236f",
    "Name": "Custom",
    "Message": "From [[[Profile.CompanyName]]]: Your invoice(s) for [[[Transaction.TransactionAmount]]] is now ready to view and pay at [[[Document.PayLinkURL]]].  If you think this is in error, please call us on [[[Profile.Phone]]]."
  }
]
</pre>
