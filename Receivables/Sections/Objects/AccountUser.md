## Account User
There are two account user objects that represents a user set up with a login in the PayFabric Receivables website, AccountUserPost and AccountUserResponse. 


## AccountUserPost
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CustomerId | String | The account's customer number | nvarchar(50) |
| Email | String | The account's email, must be a single valid email address | nvarchar(255) |
| FirstName | String | The account's first name | nvarchar(50) |
| LastName | String | The account's last name | nvarchar(50) |
| OldPassword | String | The account's old password | nvarchar(100) |
| Password | String | The account's password | nvarchar(100) |
| UserName\* | String | The account's username | nvarchar(100) |
\* Required

## AccountUserResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Email | String | The account's email, must be a single valid email address | nvarchar(255) |
| FirstName | String | The account's first name | nvarchar(50) |
| LastName | String | The account's last name | nvarchar(50) |
| UserName | String | The account's username | nvarchar(100) |
