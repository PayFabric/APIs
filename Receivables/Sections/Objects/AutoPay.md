## AutoPay
The autopay object represents an AutoPay to be saved or updated in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AmountOption | String | Indicates the amount type used in the AutoPay. Can be either ``Outstanding``, ``PastDue``, or ``FixedAmount`` | varchar(100) |
| Currency | String | The currency assigned to the AutoPay | nvarchar(max) |
| CustomerId | String | The cusotmer assigned to the AutoPay | nvarchar(25) |
| Description | String | Description of the AutoPay | nvarchar(255) |
| FixedAmount | Decimal | The amount to be charged if AmountOption is ``FixedAmount`` | decimal(19, 5) |
| Frequency | String | Frequency of the AutoPay. Can be either ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | varchar(100) |
| InvoiceTypes | Array of Strings | List of invoice types to be paid via AutoPay | varchar(4000) |
| NextPaymentDate | DateTime | Next process day of the AutoPay | DateTime |
| PaymentDay | Int | Day of the month or week when the AutoPay should begin | int |
| PaymentMethod | Guid | Customer's payment method identifier to be used during processing | unqiueidentifier |
| ApplyCredits | Boolean | Option to allow the autopay to apply credits before making a payment | boolean |