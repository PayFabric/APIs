## AutoPay Template
The autopay template object represents an AutoPay template that has been already been defined in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AmountOption | String | Indicates the amount type used in the AutoPay. Can be either ``Outstanding``, ``PastDue``, or ``FixedAmount`` | varchar(100) |
| AutoPayTemplateGuid | Guid | Unique identifer of the AutoPay template | uniqueidentifier | 
| Currency | String | The currency assigned to the AutoPay | nvarchar(max) |
| CurrencyOption | String | The currency option to be used. Can be either ``CustomerCurrency``, or ``SelectedCurrency`` | varchar(100) |
| Description | String | Description of the AutoPay | nvarchar(255) |
| FixedAmount | Decimal | The amount to be charged if AmountOption is ``FixedAmount`` | decimal(19, 5) |
| FixedAmountOption | String | The fixed amount option used for the AutoPay. Can be either ``Preselected`` or ``UserChoice`` | varchar(100) |
| Frequency | String | Frequency of the AutoPay. Can be either ``Daily``, ``Monthly``, ``Quarterly``, or ``Annually`` | varchar(100) |
| Name | String | Title name of the Autopay template | nvarchar(50) |
| Start | String | Start option when the AutoPay should begin. Can be either ``DayOfTheMonth``, ``UserChoice``, or ``NextDay`` | varchar(100) |
| StartDay | Int | Day of the month or week when the AutoPay should begin | int |

