## Access Code
There are three access code objects that represent an access code in the PayFabric Receivables website, AccessCodeRegisterResponse, AccessCodeResponseVerify, and AccessCodeResponse. 


## AccessCodeRegisterResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| RegistrationKey | Guid | Registration key for the user |  |


## AccessCodeVerifyResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| CreatedOn | DateTime | Timestamp of when the access code was created |  |
| CustomerId | String | The account's customer number | 50 |
| Email | String | The account's email, must be a single valid email address | 255 |
| RegistrationKey | Guid | Guid of the registration key so that the customer may register |  |
| Status | String | Status of the registration key. Can be 'Active', 'Complete', or 'Expired' | 25 |


## AccessCodeResponse

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| UserId | Guid | The account's user id |  |
| AccessStatus | String | The status of the access code | 25 |
