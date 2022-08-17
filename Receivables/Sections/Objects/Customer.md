## Customer
There are two Customer objects that represent a customer in the PayFabric Receivables website, CustomerPost and CustomerResponse. 


## CustomerPost
This object is used when creating a customer on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressPost) | N | Address object |
| Class | String | N | Class associated to a customer | 50 |
| CopyEmail | String Array | N | List of emails to be CC'd for emails | 1000 |
| Currency | String | N | Currency code | 10 |
| CustomerId | String | Y (Create Only) | Customer ID specified by the client | 50 |
| Email | String | N | Email address, must be a single valid email address | 255 |
| ExtensionData | String | N | Additional information | 4000 |
| Name | String | N | Customer name | 100 |
| PaymentTerms | String | N | Payment term | 50 |
| PrimaryAddress | [Object](Address.md#AddressPost) | N | Address object |
| SendEmail | String | N | Send customer registration email override. Valid options are ``Yes``, and ``No`` | 3 |
| ShippingAddress | [Object](Address.md#AddressPost) | N | Address object |
| ShippingMethod | String | N | Shipping method associated to the customer | 50 |
| StatementName | String | N | Statement name | 100 |
| Status | String | N | Status of the customer. Valid options are ``Active``, ``Inactive``, and ``Deleted`` | 50 |
| TaxExempt | Boolean | N | Tax exempt |  |
| TaxExemptNumber | Integer | N | Tax exempt number |  |
| TaxGroup | String | N | Tax group name | 50 |

## CustomerResponse
This object is used when getting a customer on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressResponse) | Address object |
| Class | String | Class associated to a customer | 50 |
| CopyEmail | String Array | List of emails to be CC'd for emails | 1000 |
| CreditBalance | Decimal | Available credit balance | 19, 5 |
| Currency | String | Currency code | 10 |
| CustomerId | String | Customer ID specified by the client | 50 |
| CustomerGuid | Guid | Unique identifier for the customer |  |
| Email | String | Email address, must be a single valid email address | 255 |
| ExtensionData | String | Additional information | 4000 |
| HasAddress | Boolean | Has addresses |  |
| InvoiceBalance | Decimal | Available invoice balance | 19, 5 |
| Name | String | Customer name | 100 |
| PastDueBalance | Decimal | Available past due balance | 19, 5 |
| PaymentTerms | String | Payment term | 50 |
| PrimaryAddress | [Object](Address.md#AddressResponse) | Address object |
| ShippingAddress | [Object](Address.md#AddressResponse) | Address object |
| ShippingMethod | String | Shipping method associated to the customer | 50 |
| StatementName | String | Statement name | 100 |
| Status | String | Status of the customer. Valid options are ``Active``, ``Inactive``, and ``Deleted`` | 50 |
| TaxExempt | Boolean | Tax exempt |  |
| TaxExemptNumber | Integer | Tax exempt number |  |
| TaxGroup | String | Tax group name | 50 |
