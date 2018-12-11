## Customer
There are two Customer objects that represent a customer in the PayFabric Receivables website, CustomerPost and CustomerResponse. 


## CustomerPost
This object is used when creating a customer on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressPost) | Address object |
| CopyEmail | String Array | List of emails to be CC'd for emails | nvarchar(255) |
| Class | String | Class associated to a customer | varchar(50) |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId\* | String | Customer ID specified by the client | nvarchar(50) |
| Email | String | Email address | nvarchar(255) |
| ExtensionData | String | Additional information | nvarchar(max) |
| Name | String | Customer name | nvarchar(100) |
| ParentCustomerId | String | Parent customer number | nvarchar(25) |
| PaymentTerms | String | Payment term | nvarchar(50) |
| PrimaryAddress | [Object](Address.md#AddressPost) | Address object |
| ShippingAddress | [Object](Address.md#AddressPost) | Address object |
| ShippingMethod | String | Shipping method associated to the customer | nvarchar(50) |
| Status | String | Status of the customer. Valid options are ``Active``, ``Inactive``, and ``Deleted`` | nvarchar(50) |
| StatementName | String | Statement name | nvarchar(100) |
\*Required

## CustomerResponse
This object is used when getting a customer on the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| BillingAddress | [Object](Address.md#AddressResponse) | Address object |
| CopyEmail | String Array | List of emails to be CC'd for emails | nvarchar(255) |
| Class | String | Class associated to a customer | varchar(50) |
| CreditBalance | Decimal | Credit balance | decimal(19,2) |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId | String | Customer ID specified by the client | nvarchar(50) |
| Email | String | Email address | nvarchar(255) |
| ExtensionData | String | Additional information | nvarchar(max) |
| InvoiceBalance | Decimal | Total invoice balance | decimal(19,2) |
| Name | String | Customer name | nvarchar(100) |
| ParentCustomerId | String | Parent customer number | nvarchar(25) |
| PastDueBalance | Decimal | Total past due balance | decimal(19,2) |
| PaymentTerms | String | Payment term | nvarchar(50) |
| PrimaryAddress | [Object](Address.md#AddressResponse) | Address object |
| ShippingAddress | [Object](Address.md#AddressResponse) | Address object |
| ShippingMethod | String | Shipping method associated to the customer | nvarchar(50) |
| Status | String | Status of the customer. Valid options are ``Active``, ``Inactive``, and ``Deleted`` | nvarchar(50) |
| StatementName | String | Statement name | nvarchar(100) |
