## Customer User
There are two customer user objects that represent a customer that has been set up with a login in the PayFabric Receivables website, CustomerUserPost, and CustomerUserRegister. 


## CustomerUserPost
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CustomerId\* | String | The account's customer number | nvarchar(50) |
| Email\* | String | The account's email | nvarchar(256) |
| Password\* | String | The account's password | nvarchar(100) |
| Permission\* | String | The account's permission. Valid options are ``Full Access``, ``View & Pay``, or ``View Only`` | nvarchar(20) |
| RegistrationKey\* | Guid | Guid of the registration key so that the customer may register | uniqueidentifier |
| Status | String | The account's status | nvarchar(25) |
| UserName\* | String | The account's username | nvarchar(256) |
\*Required

## CustomerUserSelfRegister
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CustomerId\* | String | The account's customer number | nvarchar(50) |
\*Required

## CustomerUserRegister
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccessCode | Guid | Guid of the registration key so that a pending user may register | uniqueidentifier |
| CustomerId\* | String | The account's customer number | nvarchar(50) |
| Email\* | String | The account's email | nvarchar(256) |
| Name | String | The account's name | nvarchar(256) |
| Permission\* | String | The account's permission. Valid options are ``Full Access``, ``View & Pay``, or ``View Only`` | nvarchar(20) |
| SendEmail | Boolean | Indicates if a registration email should be sent to the customer | bit |
\*Required

## CustomerUserResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccessCode | Guid | Guid of the registration key so that the user may register | uniqueidentifier |
| CustomerId | String | The account's customer number | nvarchar(50) |
| Email | String | The account's email | nvarchar(256) |
| LastLogin | DateTime | The last login date for this user | datetime |
| LastPasswordChangedDate | DateTime | The last date the password changed for this user | datetime |
| ModifiedOn | DateTime | The last modified date for this user | datetime |
| Name | String | The account's name | nvarchar(256) |
| Permission | String | The account's permissions | nvarchar(100) |
| RegisterDate | DateTime | The register date for this user | datetime |
| Status | String | The account's status | nvarchar(25) |
| UserName | String | The account's username | nvarchar(256) |