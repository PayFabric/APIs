## Payment Method
There are three payment method objects that represent the available payment methods in the PayFabric Receivables website, PaymentMethodResponse, PaymentMethodPagingResponse and PaymentMethodTenderTypeEnablingResponse. 

## PaymentMethodResponse
This object is used when getting payment information on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillTo | [Object](Address.md#AddressResponse) | Billing Address object |  |
| CardName | String | Type of credit card: ``Visa``, ``Mastercard``, ``Discover``,``JCB``,``American Express``,``Diners Club``. Only valid for credit cards. | 25 |
| CardNameDisplay | String | How the CardName should be displayed as | 25 |
| CardType | String | Type of the card: ``Credit``, ``Debit``, ``Prepaid``, or blank for eCheck | 25 |
| CreditCardExpiredDate | DateTime | Expiration date of the credit card |  |
| CreditCardName | String | Credit card holder name | 200 |
| CreditCardNumber | String | Credit card number | 25 |
| CreditCardType | String | Type of credit card used for GP and CCA. CardName plus currency short code | 25 |
| CustomerId | String | Customer number | 50 |
| DisplayName | String | Unique name for the wallet entry to easily identify it | 25 |
| ECheckAbaNumber | String | ECheck ABA number | 50 |
| ECheckAccountNumber | String | ECheck account number | 50 |
| ECheckType | String | ECheck account type. Valid options are ``Checking`` and ``Savings`` | 32 |
| IsDefault | Boolean | Indicates if this is the primary card for the customer |  |
| IsLocked | Boolean | Indicates if this card is locked from making changes |  |
| ModifiedOn | DateTime | Timestap indicating when this record was last modified. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" |  |
| TenderType | String | Tender type. Valid options are ``Unknown``, ``CreditCard``, and ``ECheck`` | 100 |
| WalletEntryGuid | Guid | Unique identifier for the wallet |  |

## PaymentPagingResponse
This object is used when getting payment information through paging on the PayFabric Receivables website.

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| Index | Int | Page number of results  |
| Total | Int | Total number of results |
| Result | [Object](PaymentMethod.md#PaymentMethodResponse) | Payment method response details |

## PaymentMethodTenderTypeEnablingResponse
This object is used when retrieving the enabled tender types

| Attribute | Data Type | Definition |
| :----------- | :--------- | :--------- |
| CreditCardEnabled | Boolean | Credit card is enabled  |
| ECheckEnabled | Boolean | ECheck is enabled  |

## SendPaymentMethodRequestEmailRequest
This object is used when creating a new payment method request

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CopyEmail | String Array | N | List of emails to be CC'd for emails | 1000 |
| CustomerID | String | Y | Customer number  | 50 |
| Email | String | N | Email address, must be a single valid email address | 255 |
| PaymentMethods | String Array | N | Array of allowed Payment Methods. Valid options are `CreditCard` or `eCheck`  | 25 |

## SendPaymentMethodRequestEmailResponse
This object is used when creating a new payment method request

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| PaymentMethodRequestURL  | String | Payment Method Request URL with the access code | 1000 |
| AccessCode | String | The access code to allow the recipient access to the AutoPay page  | 40 |
