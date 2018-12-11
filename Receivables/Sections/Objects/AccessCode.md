## Access Code
There are three access code objects that represent an access code in the PayFabric Receivables website, AccessCodeRegisterResponse, AccessCodeResponseVerify, and AccessCodeResponse. 


## AccessCodeRegisterResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Message | String | Message about the registration | nvarchar(max) |
| RegistrationKey | Guid | Registration key for the user | uniqueidentifier |


## AccessCodeVerifyResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CreatedOn | DateTime | Timestamp of when the access code was created | datetime |
| CustomerId | String | The account's customer number | nvarchar(50) |
| Email | String | The account's email | nvarchar(256) |
| RegistrationKey | Guid | Guid of the registration key so that the customer may register | uniqueidentifier |
| Status | String | Status of the registration key. Can be 'Active', 'Complete', or 'Expired' | nvarchar(25) |


## AccessCodeResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| UserId | Guid | The account's user id | uniqueidentifier |
| AccessStatus | String | The status of the access code | nvarchar(25) |