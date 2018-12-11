## Customer User
There are two customer user objects that represent a customer that has been set up with a login in the PayFabric Receivables website, CustomerUserPost, and CustomerUserRegister. 


## CustomerUserPost
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CustomerId\* | String | The account's customer number | nvarchar(50) |
| Email\* | String | The account's email | nvarchar(256) |
| Password\* | String | The account's password | nvarchar(100) |
| RegistrationKey\* | Guid | Guid of the registration key so that the customer may register | uniqueidentifier |
| Status | String | The account's status | nvarchar(25) |
| UserName\* | String | The account's username | nvarchar(256) |
\*Required

## CustomerUserRegister
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CustomerId\* | String | The account's customer number | nvarchar(50) |
| Email\* | String | The account's email | nvarchar(256) |
| SendEmail | Boolean | Indicates if a registration email should be sent to the customer | bit |
\*Required
