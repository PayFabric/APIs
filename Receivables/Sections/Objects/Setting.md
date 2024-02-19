## Setting
This lists all objects used in the Settings APIs

## AutopayTemplateRequest
This object is used when creating or updating autopay templates in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AmountOption | String | Y (Create Only) | Indicates the amount type used in the AutoPay. Valid options are ``Outstanding``, ``PastDue``, or ``FixedAmount`` | 100 |
| ApplyCredits | Boolean | N | Option to allow the autopay to apply credits before making a payment |  |
| Currency | String | N | The currency assigned to the AutoPay | 10 |
| CustomerId | String | Y | The customer assigned to the AutoPay | 25 |
| Description | String | Y | Description of the AutoPay | 255 |
| FixedAmount | Decimal | Y, if AmountOption is ``FixedAmount`` | The amount to be charged if AmountOption is ``FixedAmount`` | 19, 5 |
| FixedAmountOption | String | N | Indicates the fixed amount type used in the AutoPay. Valid options are ``None``, ``Preselected``, or ``UserChoice`` | 100 |
| Frequency | String | Y (Create Only) | Frequency of the AutoPay. Valid options are ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | 100 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| InvoiceTypes | Array of Strings | N | List of invoice types to be paid via AutoPay | 4000 |
| Name | String | Y | The name of the autopay template | 50 |
| NextPaymentDate | DateTime | Y (Create Only) | Next process day of the AutoPay |  |
| PaymentDay | Int | N | Day of the month or week when the AutoPay should begin |  |
| StartOption | String | N | Indicates when the autopay should start. Valid options are ``None``, ``DayOfTheMonth``, ``DayOfTheWeek``, ``NextDay``, or ``UserChoice`` | 100 |

## CompanyInformationRequest
This object is used when updating the company information settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Address1 | String | N | The first line of a street address | 100 |
| Address2 | String | N | The second line of a street address | 100 |
| City | String | N | City name | 50 |
| Email | String | N | Email address, must be a single valid email address | 255 |
| Name | String | N | Company name | 100 |
| Phone | String | N | Phone number | 50 |
| PortalURL | String | N | Web address for customers to access the customer portal | 2000 |
| State | String | N | State name | 50 |
| Timezone | String | N | Company time zone. Valid options are listed [here](Timezone.md) | 50 |
| Zip | String | N | Zip code | 50 |

## CompanyStyleRequest
This object is used when updating the company style settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| BannerAlignment | String | N | The Banner Alignment style. Valid options are `Left`, `Center`, or `Right` | 6 |
| MaxBannerHeight | Int | N | The Banner height |  |
| MainColor | String | N | Main color to be used to display, such as buttons | 7 |
| FocusArea | String | N | Focus color to be used for input when focused on the field | 7 |
| BannerBackground | String | N | Banner background color outside of the logo image | 7 |

## CustomerSetupRequest
This object is used when updating the customer setup settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AllowCreate | Boolean | N | Allow customers to be created on the PayFabric Receivables website |  |
| AllowCustomerIdEntry | Boolean | N | Allow customerId to be edited for Receivables created customers |  |
| AllowEdit | Boolean | N | Allow customers to be edited on the PayFabric Receivables website |  |
| CustomerIdPrefix | String | N | CustomerId prefix for Receivables created customers | 10 |
| CustomerIdNumberLength | Int | N | CustomerId number length for Receivables created customers |  |

## EmailTemplateSaveDto
This object is used when creating or updating email templates in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Attachment | Boolean | N | Option to attach the invoice to the email as a pdf. </br>Only applies when Type is: <ul><li>``InvoiceReminder``</li><li>``NewInvoiceNotificationOutstanding``</li><li>``NewInvoiceNotificationPartiallyPaid``</li><li>``NewInvoiceNotificationPaid``</li><li>``PaymentRequestSingleInvoice``</li></ul> |  |
| BCC | String | N | The email addresses to be blind copied | 1000 |
| Body | String | Y | The body of the email | 4000 |
| Default | String | N | Option to specify if this is the default email template. Valid options are ``Yes`` and ``No``. </br>Only applies when Type is: <ul><li>``PaymentRequestSingleInvoice``</li><li>``PaymentRequestMultipleInvoice``</li><li>``PaymentRequestPrepayment``</li></ul> | 10 |
| Delivery | String | N | Option to specify when the email should be sent. Valid options are ``LoginAndNewCustomer`` and ``LoginOnly``. </br>Only applies when Type is: <ul><li>``UserRegistration``</li></ul> | 20 |
| InvoiceStatus | String | N | The invoice status this email template applies to. Valid values are ``Outstanding``, or ``PastDue``. </br>Only applies when Type is: <ul><li>``InvoiceReminderMultipleInvoice``</li></ul>  |  |
| InvoiceTypes | Array of Strings | N | The invoice types this email template applies to. </br>Only applies when Type is: <ul><li>``InvoiceReminder``</li><li>``InvoiceReminderMultipleInvoice``</li><li> ``NewInvoiceNotificationOutstanding``</li><li>``NewInvoiceNotificationPartiallyPaid``</li><li>``NewInvoiceNotificationPaid``</li></ul>  |  |
| Name | String | N | The name of the email template. Required if the type is ``InvoiceReminder``, ``InvoiceReminderMultipleInvoice``, ``PaymentRequestSingleInvoice``, ``PaymentRequestMultipleInvoice``, or ``PaymentRequestPrepayment`` | 50 |
| ScheduleDays | Int | N | The number of days used for the schedule type. </br>Only applies when Type is: <ul><li>``InvoiceReminder``</li><li>``AutoPayUpcoming``</li></ul> |  |
| ScheduleOptions | Array of Strings | N | The schedule options of when this email template should send. Valid options for ScheduleType of ``Weekly`` are ``Sunday`` through ``Saturday``. Valid options for ScheduleType of ``Monthly`` are 1-31. Only applies when Type is: <ul><li>``InvoiceReminderMultipleInvoice``</li></ul> |  |
| ScheduleType | String | N | The schedule of when this email template should send. Valid options are ``AfterPostingDate``, ``BeforePastDueDate``, ``OnPastDueDate``, ``AfterPastDueDate``, ``Monthly``, ``Weekly``, ``ByAutoPayAmount``, and ``Always``. </br>Only applies when Type is: <ul><li>``InvoiceReminder``</li><li>``InvoiceReminderMultipleInvoice``</li><li>``AutoPayUpcoming``</li></ul> | 50 |
| Subject | String | Y | The subject of the email | 100 |
| Type | String | Y | The type of the email template. Valid options are <ul><li>``UserRegistration``</li><li>``UserRegistrationComplete``</li><li>``UserNameRequest``</li><li>``ResetPasswordRequest``</li><li>``ResetPasswordConfirmation``</li><li>``NewInvoiceNotificationOutstanding``</li><li>``NewInvoiceNotificationPartiallyPaid``</li><li>``NewInvoiceNotificationPaid``</li><li>``InvoiceReminder``</li><li>``InvoiceReminderMultipleInvoice``</li><li>``ManualPaymentConfirmation``</li><li>``AutoPayPaymentConfirmation``</li><li>``AutoPayPaymentDeclined``</li><li>``SubscriptionPaymentDeclined``</li><li>``PaymentRequestSingleInvoice``</li><li>``PaymentRequestMultipleInvoice``</li><li>``PaymentRequestPrepayment``</li><li>``AutoPayRequest``</li><li>``PaymentMethodRequest``</li><li>``AutoPayActivated``</li><li>``AutoPayUpdated``</li><li>``AutoPayDeactivated``</li><li>``AutoPayUpcoming``</li></ul>  | 10 |

## IntegrationSettingsPatchRequest
This object is used when updating the integration settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| ApplicationIntegration | Boolean | N | Allow application integration records to be created |  |
| IntegrationMethod | String | N | Method to show how records will be integrated to another system | 15 |
| LogoutURL | String | N | Logout url used in passthrough | 15 |
| NewCustomerIntegration | Boolean | N | Allow customer integration records to be created |  |
| NewInvoiceIntegration | Boolean | N | Allow invoice integration records to be created |  |
| NewPaymentIntegration | Boolean | N | Allow payment integration records to be created |  |
| OriginatingPortalName | String | N | Originating portal name used in passthrough | 15 |
| OriginatingPortalURL | String | N | Originating portal url used in passthrough | 15 |
| PaymentMethodIntegration | String | N | Allow payment method integration records to be created. Valid values are `PaymentMethodRequestsOnly`, or `Disabled` | 15 |
| SurchargeIntegration | Boolean | N | Allow surcharge integration records to be created |  |

## InvoicePaymentTermsRequest
This object is used when creating or updating the invoice payment term settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Name | String | Y | Name of the payment term | 50 |
| DefaultPaymentTerms | Boolean | N | Mark as the default payment term |  |
| DiscountAmount | Decimal | N | Discount amount  | 19, 5 |
| DiscountDateOption | String | N | Discount date option. Valid options are ``NoDiscount``, ``DaysAfterInvoiceDate``, ``DayOfTheSameMonthAsInvoiceDate``, or ``DayOfTheMonthAfterInvoiceDate`` | 30 |
| DiscountDateNumber | Int | N | The number of days used for the Discount Date  |  |
| DiscountType | String | N | Discount type option. Valid options are ``Amount``, ``Percent`` | 10 |
| DueDateOption | String | Y | Due date option. Valid options are ``DaysAfterInvoiceDate``, ``DayOfTheSameMonthAsInvoiceDate``, or ``DayOfTheMonthAfterInvoiceDate`` | 30 |
| DueDateNumber | Int | Y | The number of days used for the Due Date  |  |

## InvoiceSetupRequest
This object is used when updating the invoice setup settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AllowCreate | Boolean | N | Allow invoices to be created on the PayFabric Receivables website |  |
| AllowDelete | Boolean | N | Allow invoices to be deleted on the PayFabric Receivables website |  |
| AllowInvoiceIdEntry | Boolean | N | Allow invoiceId to be edited for Receivables created invoices |  |
| InvoiceIdPrefix | String | N | InvoiceId prefix for Receivables created invoices | 10 |
| InvoiceIdNumberLength | Int | N | InvoiceId number length for Receivables created invoices |  |
| PaymentsOnNewInvoices | Boolean | N | Allow invoices to be paid when creating invoices on the Receivables website |  |
| RequireApproval | Boolean | N | Require approval of invoice after completion |  |
| ShowFreightPrice | Boolean | N | Display freight price when creating invoices on the Receivables website |  |
| ShowMiscellaneousPrice | Boolean | N | Display freight price when creating invoices on the Receivables website |  |
| SubscriptionInvoiceStatus | String | N | Invoice status of subscription invoices. Valid options are ``Incomplete``, ``Pending``, ``Complete`` |  |

## InvoiceTableDisplayRequest
This object is used when updating the invoice table display settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| HistoryPoNumber | Boolean | N | Show Purchase Order number on the History page on the PayFabric Receivables website |  |
| PayInvoicesPoNumber | Boolean | N | Show Purchase Order number on the Pay Invoices page on the PayFabric Receivables website |  |

## InvoiceTemplateRequest
This object is used when creating or updating the invoice template settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| ItemGroupingField | String | N | Item grouping field. Valid options are ``No Grouping``, ``Item.ShippingAddressName``, ``Item.ShippingAddressContact``, ``Item.ShippingAddress1``, ``Item.ShippingMethod``, or ``Item.RequestedShipDate`` | 30 |
| Name | String | Y | Name of the invoice template | 50 |
| Template | String | Y | Invoice template html | 4000 |

## InvoiceTypeRequest
This object is used when creating or updating the invoice type settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Description | String | N | Description of the invoice type | 50 |
| DefaultInvoiceType | Boolean | N | Mark as the default invoice type |  |
| ID | String | Y | Id of the invoice type | 50 |
| InvoiceTemplate | String | N | Name of the invoice template to associate | 50 |

## PaymentPreferencesRequest
This object is used when updating the payment preference settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| ApplyCredits | Boolean | N | Allow the customer to apply credits |  |
| AutoApplyCredits | Boolean | N | Automatically apply credits when making a payment |  |
| AutoPayCustomerAccess | Boolean | N | Allow the customer to access autopay |  |
| CreateAccountAfterLink | Boolean | N | Allow a user to create an account after making a payment |  |
| CreatePaymentRecords | Boolean | N | Allow CSRs to create payment records |  |
| DeletePayments | Boolean | N | Allow payments to be deleted on the PayFabric Receivables website |  |
| PartialPayments | Boolean | N | Allow invoices to be partially payed |  |
| Prepayment | Boolean | N | Allow prepayments to be made |  |

## TransactionProcessingRequest
This object is used when creating or updating the transaction processing settings in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CurrencyCode | String | Y | Unique value associated to the currency | 10 |
| ShortName | String | Y | ISO currency code. Valid options are listed [here](ISOCodes.md) | 4 |
| LongName | String | N | Long name to describe the currency | 50 |
| Symbol | String | N | Currency symbol | 5 |
| FunctionalCurrency | Boolean | N | Indicates if the currency will be used as the main currency |  |
| TransactionDetail | String | N | Transaction detail to be sent. Valid options are ``Level2Simple``, ``Level3Summary``, or ``Level3Detailed`` | 16 |
| CreditCardGatewayProfile |  String | SetupID associated to the currency used to process credit cards | 32 |
| eCheckGatewayProfile | String | SetupID associated to the currency used to process eChecks | 32 |
| PaymentIdPrefix | String | N | PaymentId prefix for Receivables created payments | 10 |
| PaymentIdNumberLength | Int | N | PaymentId number length for Receivables created payments |  |
| TenderTypes | [Array of Objects](#tendertyperequest) | N | Tender types associated to this currency |  |

## TenderTypeRequest
This object is used with the [TransactionProcessingRequest](#transactionprocessingrequest).

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| TenderType | String | Y | Tender type. Valid options are ``Visa``, ``MasterCard``, ``AmericanExpress``, ``Discover``, ``JCB``, ``DinersClub``, or ``eCheck`` | 20 |
| BatchPrefix | String | N | Batch prefix | 20 |
| BatchCutoffTime | String | N | Time when a new batch should be created | 6 |
| BackOfficeID | String | N | Back office tender type name | 25 |
