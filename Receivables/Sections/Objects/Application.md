## Application
There are one Application object that represent an application in the PayFabric Receivables website.

## ApplicationResponse
This object is used when getting an application record on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Amount | Decimal | Total amount paid by the application |  |
| ApplicationId | String | Application identifier | 50 |
| AppliedCredits | [Array of Objects](Application.md#AppliedCreditResponse) | Credits used in the application |  |
| CreatedOn | DateTime | Date the application was created |  |
| CustomerId | String | Customer associated to the application | 50 |
| ModifiedOn | DateTime | Date the application was last modified |  |

## AppliedCreditResponse
This object is used when getting an applied credit on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| ApplyAmount | Decimal | Total amount this credit has applied |  |
| Identity | String | Payment identity | 50 |
| InvoiceApply | [Array of Objects](Application.md#InvoiceApplyResponse) | Invoices applied to this credit |  |
| PaymentId | String | Payment identifier | 50 |
| Type | String | Type of payment | 50 |

## InvoiceApplyResponse
This object is used when getting an applied credit on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DiscountAmount | Decimal | Discount amount applied to the invoice | 19, 5 |
| Identity | Decimal | Invoice number identifier (Optional if using Invoice number) | 19, 5 |
| InvoiceId | String | Invoice number | 30 |
| InvoiceType | String | Invoice type | 50 |
| Amount | Decimal | Payment amount applied to the invoice in the functional currency | 19, 5 |
| TotalAppliedAmount | Decimal | Total amount applied to the invoice in the functional currency | 19, 5 |