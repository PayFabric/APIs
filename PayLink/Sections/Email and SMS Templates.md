# Email and SMS Templates
Payment Links and Wallet Links both utilize Email and SMS templates to send notifications to the intended recipient.  If no template is specified during the Payment and Wallet Link creation they will use the default template as defined within the PayLink Portal.  For more information on the templates and where to find them, please see our [Portal Documentation](https://github.com/PayLink/Portal/blob/v2/Sections/Features.md).

## Specifying the Template
The JSON payload sent during the API's exposes a [Notification object](JSON%20Objects.md#notification) which had two fields accepting both an EmailTemplate and SMSTemplate Name.  This name is defined by the PayLink user during creation of custom templates.

### Example
<pre>
{
  "Notification": {
    "Type": "All",
    "EmailTemplate": "EmailTemplate1",
    "SMSTemplate": "SMSTemplate1"
  },  
  "NotificationEmail": "John.Doe@nodus.com",
  "NotificationPhone": "123456789",
}
</pre>

If no template name is provided the default as defined in the PayLink portal will be used.  If a template name is provided that does not match a template, the Payment Link or Wallet Link will still be created however, a warning message will be included in the Notification ResponseMessage field indication the template did not match.

## Additional APIs
There are two additional APIs provided for Email and SMS Templates, you may find them here:

* [Retrieve Email Templates](Notifications.md#retrieve-email-notification-templates)
* [Retrieve SMS Templates](Notifications.md#retrieve-sms-notification-templates)
