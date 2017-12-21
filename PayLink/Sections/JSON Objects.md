# API JSON Objects
PayLink uses JSON objects to send and receive client data. This is the official reference documentation for JSON objects used in the PayLink REST API.

Some objects have read-only fields, the fields access security is defined as:

* Read-Only - RO - Cannot be created or modified
* Read-Write - RW - Can be created or modified

## PayLink Document
This object represents the PayLink record that customers will pay through their unique URL. If configured, this will also act as an ERP document such as sales order, invoice, etc. This document once paid will be populated into the ERP system. Below is the explanation about this JSON object.

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Id | GUID | Unique Id GUID for the PayLink document | RO |
| Device | GUID | Unique PayFabric Device that was used to create the authentication token | RO |
| SetupId | String | PayFabric payment gateway account profile name, **required if** `Payment` field is omitted | RW |
| Payment | [Payment Object](#payment) | Specify payment gateway account profile names and accepted payment types, **required if** `SetupId` is blank | RW |
| Currency* | String | Currency code, such as `USD`, `CAD` | RW |
| Amount* | Decimal | Transaction amount | RW |
| DocumentAmount* | Decimal | Document/invoice amount | RW |
| TaxAmount | Decimal | Tax amount | RW |
| TradeDiscount | Decimal | Trade discount amount | RW |
| Freight | Decimal  | Freight amount | RW |
| MiscAmount | Decimal  | Misc amount | RW |
| CustomerNumber* | String | Customer unique number| RW |
| CustomerName | String | Customer name | RW |
| IsMultipleInvoice* | Boolean | Specifies that the PayLink document is for multiple invoice numbers, `true | false` | RW |
| DocumentNumber | String | Document/invoice unique number | RW |
| TransactionType* | String | Credit card transaction type, such as `Sale` or `Book` | RW |
| DocDate* | DateTime | Document/invoice date | RW |
| DueDate | DateTime | Document/invoice due date | RW |
| DocType | Integer | Document type. **Dynamics GP Only** | RW |
| PaymentTerm | String | Document payment term, such as `NET40` | RW |
| SourceOfDocument | Integer | Source of document. **Dynamics GP Only** | RW |
| BatchSource | Integer | Batch source. **Dynamics GP Only** | RW |
| BatchNo | String | Batch number. **Dynamics GP Only** | RW |
| MerchantEmail | String | Email From | RW |
| ReturnUrl | String | User defined return URL, overwrites PayLink confirmation page | RW |
| Status | Integer | Document status, available values `0 = draft, 1 = waiting for payment, 2 = cancelled, 3 = paid, 4 = ERP posting failed, 5 = ERP posting completed` | RO |
| ShippingAddress | [Address Object](#address) | Shipping address | RW |
| BillingAddress | [Address Object](#address) | Billing address | RW |
| Items | Array of [Item Object](#item) | Collection of line items | RW |
| UserDefinedFields | Array of [Field Object](#field) | Collection of user defined values | RW |
| PostDataType | String | ERP posting data type | RW |
| TransactionKey | String | PayFabric transaction key | RO |
| PaidOn | DateTime | Date and time payment was made | RO |
| LastProcessDate | DateTime | Date and time document was last processed, such as updates or ERP posting | RO |
| Message | String | Document status update messages | RO |
| CustomeMessage | String | User defined message | RW |
| Notification* | [Notification Object](#notification) | Specify notification method and SMS template | RW |
| NotificationEmail | String | Email where notification is sent, **required if** notification type is `All` *or* `Email` | RW |
| NotificationPhone | String | Mobile phone number where notification is sent, **required if** notification type is `All` *or* `SMS` | RW |
\* Required


## WalletLink Document
This object represents the WalletLink record that customers will be able to save their credit card or eCheck details through their unique URL. Below is the explanation about this JSON object.

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Id | GUID | Unique Id GUID for the WalletLink document | RO |
| Device | GUID | Unique PayFabric Device that was used to create the authentication token | RO |
| CustomerNumber* | String | Customer unique number| RW |
| CustomerName | String | Customer name | RW |
| TenderType | Integer | The tender type the customer used to complete the WalletLink, available values `0 = unknown, 1 = credit card, 2 = ECheck, 3 = ACH` | RO |
| WalletID | GUID | Unique Id of created Wallet record, see [PayFabric Wallet](https://github.com/PayFabric/APIs/blob/v2/Sections/Wallets.md) documentation for info | RW |
| ReturnUrl | String | User defined return URL, overwrites WalletLink confirmation page | RW |
| Status | Integer | Document status, available values `0 = incomplete, 1 = complete, 2 = cancelled` | RO |
| CreatedOn | DateTime | Date and time WalletLink was created | RO |
| CompleteOn | DateTime | Date and time WalletLink was completed | RO |
| Message | String | Document status update messages | RO |
| CustomeMessage | String | User defined message | RW |
| Notification* | [Notification Object](#notification) | Specify notification method and SMS template | RW |
| NotificationEmail | String | Email where notification is sent, **required if** notification type is `All` *or* `Email` | RW |
| NotificationPhone | String | Mobile phone number where notification is sent, **required if** notification type is `All` *or* `SMS` | RW |
\* Required


## Address
Address objects represent the shipping or billing address of a customer. This object may be included as a child attribute of other JSON objects (such as [Document](#paylink-document)).

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Country | String | Country name| RW |
| State | String | State name| RW |
| City | String | City name | RW |
| Zip | String | Zip or post code | RW |
| Address1 | String | Street line 1 | RW |
| Address2 | String | Street line 2 | RW |
| Address3 | String | Street line 3 | RW |
| Email | String | Email address| RW |
| Phone1 | String | Phone number 1 | RW |
| Phone2 | String | Phone number 2 | RW |
| Phone3 | String | Phone number 3 | RW |
All fields are optional


## Notification
The notification object allows the user to define which type of notification method is used, and also to specify a different SMS or email notification template from the default.

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Type* | String | Notification type, available values are `All, SMS, Email, None` | RW |
| SMSTemplate | String | Unique name of the SMS notification template created on the portal, see [here](https://github.com/PayLink/APIs/blob/master/Sections/Notifications.md#retrieve-sms-notification-templates) for information on returning available SMS notification templates | RW |
| EmailTemplate | String | Unique name of the email notification template created on the portal, see [here](https://github.com/PayLink/APIs/blob/master/Sections/Notifications.md#retrieve-email-notification-templates) for information on returning available email notification templates | RW |
\* Required


## Payment
The payment object allows the user to define which payment gateway account should be used for payment types, and also which form of payment is accepted.

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| CreditCardGateway | String | Payment gateway account profile name for credit card payments, if blank and AcceptType is `0` *or* `1` will choose default credit card gateway | RW |
| ECheckGateway | String | Payment gateway account profile name for eCheck payments, if blank and AcceptType is `0` *or* `2` will choose default eCheck gateway | RW |
| AcceptType* | Integer | Payment type acceptance, available values are `0 = all, 1 = credit card, 2 = eCheck` | RW |
\* Required


## Item
Description

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| ItemCode* | String | If multiple invoice then single invoice number, if not multiple invoice then item code | RW |
| AppliedAmount* | Decimal | Amount to apply to ERP system for single invoice. **Multiple Invoice Only** | RW |
| DueDate* | DateTime | Payment due date for single invoice. **Multiple Invoice Only** | RW |
| Description* | String | If multiple invoice then single invoice number, if not multiple invoice then item description | RW |
| UnitPrice* | Decimal | If multiple invoice then use applied amount, if not multiple invoice then item unit price | RW |
| Quantity* | Decimal | If multiple invoice then use `1`, if not multiple invoice then item quantity | RW |
| PriceLevel | String | Item price level | RW |
| UnitOfMeasure | String | Item unit of measure | RW |
| SiteCode | String | Location of inventory | RW |
| MarkDown | Decimal | Mark down amount | RW |
| TaxAmount | Decimal | Tax amnount | RW |
| MiscAmount | Decimal | Misc amount | RW |
| UserDefinedFields | Array of [Field Object](#field) | Collection of user defined values | RW |
| Items | Array of [Item Object](#item) | Collection of items for each single invoice. **Multiple Invoice Only** | RW |
\* Required


## Field
The field object is used for custom user defined values.

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Key* | String | Unique key for this field | RW |
| Value* | String | Value for this field | RW |
\* Required


## SMS Template
The SMS Template object is a used to return information on created notification templates, this is used for retrieving available Ids for use in the [Notification Object](#notification).

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Id | GUID | Unique Id of the template | RO |
| Name | String | Unique name of the template | RO |
| Message | String | Message body of the SMS | RO |


## Email Template
The Email Template object is a used to return information on created notification templates, this is used for retrieving available names for use in the [Notification Object](#notification).

| Attribute | Data Type | Definition | Access |
| :----------- | :--------- | :--------- | :--------- |
| Id | GUID | Unique Id of the template | RO |
| Name | String | Unique name of the template | RO |
| Subject | String | Subject line of the email | RO |
| Contents | String | Body contents of the email | RO |
