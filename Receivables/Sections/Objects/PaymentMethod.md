## Payment Method
There are three payment method objects that represent the available payment methods in the PayFabric Receivables website, PaymentMethodResponse, PaymentMethodPagingResponse and PaymentMethodTenderTypeEnablingResponse. 

## PaymentMethodResponse
This object is used when getting payment information on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillTo | [Object](Address.md#AddressResponse) | Billing Address object |
| CardName | String | Type of credit card: ``Visa``, ``Mastercard``, ``Discover``,``JCB``,``American Express``,``Diners Club``. Only valid for credit cards. | nvarchar(25) |
| CardNameDisplay | String | How the CardName should be displayed as | nvarchar(25) |
| CreditCardExpiredDate | DateTime | Expiration date of the credit card | datetime |
| CreditCardName | String | Credit card holder name | nvarchar(200) |
| CreditCardNumber | String | Credit card number | nvarchar(25) |
| CreditCardType | Type of credit card used for GP and CCA. CardName plus currency short code | nvarchar(25) |
| CustomerId | String | Customer number | nvarchar(50) |
| DisplayName | String | Unique name for the wallet entry to easily identify it | nvarchar(25) |
| ECheckAbaNumber | String | ECheck ABA number | nvarchar(50) |
| ECheckAccountNumber | String | ECheck account number | nvarchar(50) |
| ECheckType | String | ECheck account type. Valid options are ``Checking`` and ``Savings`` | nvarchar(32) |
| IsDefault | Boolean | Indicates if this is the primary card for the customer | bit |
| IsLocked | Boolean | Indicates if this card is locked from making changes | bit |
| ModifiedOn | DateTime | Timestap indicating when this record was last modified. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| TenderType | String | Tender type. Valid options are ``Unknown``, ``CreditCard``, and ``ECheck`` | nvarchar(100) |
| WalletEntryGuid | Guid | Unique identifier for the wallet | uniqueidentifier |

## PaymentPagingResponse
This object is used when getting payment information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Index | Int | Page number of results  | int |
| Total | Int | Total number of results | int |
| Result | [Object](PaymentMethod.md#PaymentMethodResponse) | Payment method response details |

## PaymentMethodTenderTypeEnablingResponse
This object is used when retrieving the enabled tender types

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CreditCardEnabled | Boolean | Credit card is enabled  | bit |
| ECheckEnabled | Boolean | ECheck is enabled  | bit |
