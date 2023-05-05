## AutoPay
The autopay object represents an AutoPay to be saved, updated, or viewed in the PayFabric Receivables website. 

## AutoPayPost
This object is used when saving or updating an autopay in the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AmountOption | String | Y (Create Only) | Indicates the amount type used in the AutoPay. Can be either ``Outstanding``, ``PastDue``, or ``FixedAmount`` | 100 |
| ApplyCredits | Boolean | N | Option to allow the autopay to apply credits before making a payment |  |
| Currency | String | N | The currency assigned to the AutoPay | 10 |
| CustomerId | String | Y | The customer assigned to the AutoPay | 25 |
| Description | String | N | Description of the AutoPay | 255 |
| FixedAmount | Decimal | Y, if AmountOption is ``FixedAmount`` | The amount to be charged if AmountOption is ``FixedAmount`` | 19, 5 |
| Frequency | String | Y (Create Only) | Frequency of the AutoPay. Can be either ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | 100 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| InvoiceTypes | Array of Strings | N | List of invoice types to be paid via AutoPay | 4000 |
| NextPaymentDate | DateTime | Y (Create Only) | Next process day of the AutoPay |  |
| PaymentDay | Int | N | Day of the month or week when the AutoPay should begin |  |
| PaymentMethod | Guid | Y (Create Only) | Customer's payment method identifier to be used during processing |  |

## AutoPayResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AmountOption | String | Indicates the amount type used in the AutoPay. Can be either ``Outstanding``, ``PastDue``, or ``FixedAmount`` | 100 |
| ApplyCredits | Boolean | Option to allow the autopay to apply credits before making a payment |  |
| Currency | String | The currency assigned to the AutoPay | 50 |
| CustomerId | String | The customer assigned to the AutoPay | 25 |
| Description | String | Description of the AutoPay | 255 |
| FixedAmount | Decimal | The amount to be charged if AmountOption is ``FixedAmount`` | 19, 5 |
| Frequency | String | Frequency of the AutoPay. Can be either ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | 100 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| InvoiceTypeOption | String | Invoice type option (Read-only) Valid values are ``AllInvoices``, or ``SelectedInvoices`` |  |
| InvoiceTypes | Array of Strings | List of invoice types to be paid via AutoPay | 4000 |
| NextPaymentDate | DateTime | Next process day of the AutoPay |  |
| PaymentDay | Int | Day of the month or week when the AutoPay should begin |  |
| PaymentMethod | Guid | Customer's payment method identifier to be used during processing |  |