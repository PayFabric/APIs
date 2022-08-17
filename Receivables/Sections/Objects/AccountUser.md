## Account User
There are two account user objects that represents a user set up with a login in the PayFabric Receivables website, AccountUserPost and AccountUserResponse. 


## AccountUserPost
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CustomerId | String | N | The account's customer number | 50 |
| Email | String | N | The account's email, must be a single valid email address | 255 |
| Name | String | N | The account's full name | 255 |
| OldPassword | String | N | The account's old password | 100 |
| Password | String | N | The account's password | 100 |
| UserName | String | Y | The account's username | 100 |

## AccountUserResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Email | String | The account's email, must be a single valid email address | 255 |
| Name | String | The account's full name | 255 |
| UserName | String | The account's username | 100 |
