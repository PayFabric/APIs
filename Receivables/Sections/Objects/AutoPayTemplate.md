## AutoPay Template
The autopay template object represents an AutoPay template that has been already been defined in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AmountOption | String | Indicates the amount type used in the AutoPay. Can be either ``Outstanding``, ``PastDue``, or ``FixedAmount`` | 100 |
| AutoPayTemplateGuid | Guid | Unique identifier of the AutoPay template |  | 
| Currency | String | The currency assigned to the AutoPay | 10 |
| CurrencyOption | String | The currency option to be used. Can be either ``CustomerCurrency``, or ``SelectedCurrency`` | 100 |
| Description | String | Description of the AutoPay | 255 |
| FixedAmount | Decimal | The amount to be charged if AmountOption is ``FixedAmount`` | 19, 5 |
| FixedAmountOption | String | The fixed amount option used for the AutoPay. Can be either ``Preselected`` or ``UserChoice`` | 100 |
| Frequency | String | Frequency of the AutoPay. Can be either ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | 100 |
| FrequencyInterval | Int | N | Interval between frequency |  |
| Name | String | Title name of the Autopay template | 50 |
| Start | String | Start option when the AutoPay should begin. Can be either ``DayOfTheMonth``, ``UserChoice``, or ``NextDay`` | 100 |
| StartDay | Int | Day of the month or week when the AutoPay should begin |  |
| InvoiceTypeOption | String | The invoice type option used. Can be either ``AllInvoices``, or ``SelectedInvoices`` | 25 |
| InvoiceTypes | Array of Strings | List of invoice types to be paid via AutoPay | 4000 |
| ApplyCredits | Boolean | Option to allow the autopay to apply credits before making a payment |  |