## Apply Credit
The apply credit object represents the application of a credit to an invoice and associated payment in the PayFabric Receivables website. 

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CreditGuid | Guid | Unique identifier for the credit |  |
| ApplyAmount | Decimal | Amount to be applied |  |
| CreditBalance | Decimal | Available credit balance for the credit |  |
| CreatedOn | DateTime | Created on date for the credit |  |
| CreditIdentity | String | Unique identifier for the credit | 50 |
| CreditId | String | Credit number | 25 |
| PaymentType | String | Payment type of the transaction. Valid options are ``CreditMemo``, ``Return``, and ``Payment`` | 25 |