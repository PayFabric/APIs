## Process Payment Hosted Checkout
There are three process payment objects that represent the processing of a payment through the hosted checkout page in the PayFabric Receivables website, JWTResponse, JWTOptions and UpdateTransactionResult. 


## JWTResponse
This object is used in the response when creating a JWT to be used in the hosted checkout page on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Options | [Object](ProcessPaymentHostedCheckout.md#jwtoptions) | JWT Options | |
| Token | String | Token used for authentication | 400 |
| Message | String | Error message | 400 |

## JWTOptions
This object is used in the response when creating a JWT to be used in the hosted checkout page on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| ReturnUrl | String | Return url | 100 |
| TrxKey | String | Transaction key | 100 |
| UseBluefin | Boolean | Indicates if bluefin is used |  |
| UseDefaultWallet | Boolean | Indicates if using default wallet |  |
| UseEntryClass | Boolean | Indicates if the entry class is used |  |

## UpdateTransactionResult
This object is used when updating a payment transaction using the hosted checkout page on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Options | [Object](ProcessPaymentHostedCheckout.md#jwtoptions) | JWT Options |
| Result | Boolean | Indicates if it was successful or not |  |
| Message | String | Error message | 4000 |
| HttpStatusCode | int | Http Status Code |  |
