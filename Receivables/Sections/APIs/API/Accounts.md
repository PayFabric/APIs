Accounts
============

The Account API is used for all information related to an account on the PayFabric Receivables website. Please note that some of the below requests require API authentication and some do not, see our [guide](Token.md) on how to authenticate.

Retrieve the current user
--------------------
This api requires authentication

* `GET /currentuser` will retrieve the currently logged in user.

###### Request
```http
GET /currentuser HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AccountUser.md#AccountUserResponse)
```json
{
	"UserName": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"Name": "Nodus Technologies"
}
```


Get all customer users
--------------------

* `GET /users` will get a customer user for the currently logged in customer.

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| UserName | Username of the user | String |
| Status | Status of the users | User status. Valid options are ``Active``, ``Inactive``, ``Pending``, and ``Locked`` |

###### Request
```http
GET /users HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserResponse)
```json
[
	{
		"Status": "Active",
		"LastLogin": "2020-06-01T22:52:49.7370000Z",
		"RegisterDate": "2020-05-28T18:17:32.9200000Z",
		"LastPasswordChangedDate": null,
		"FailedLoginAttempts": 0,
		"AccessCode": null,
		"ModifiedOn": null,
		"CustomerId": "Nodus0001",
		"Name": null,
		"Permission": "FullAccess",
		"UserName": "Nodus0001",
		"Email": "Nodus0001@nodus.com"
	}
]
```


Create a customer user
--------------------

* `POST /users` will create a user on the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserPost)
```json
{
	"CustomerId": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"Password": "password1",
	"Permission": "FullAccess",
	"RegistrationKey":"6F25DF7B-8B48-4041-91F4-9E84EF723A8A",
	"UserName": "Nodus0001"
}
```


###### Response
```text
true
```


Update a customer user
--------------------
This api requires authentication

* `PUT /users` will update a user on the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserPost)
```json
{
	"UserName": "Nodus0001"
}
```


###### Response
```text
true
```


Send Forgot Password Email
--------------------

* `POST /users/forgotpassword?username={UserName}` will send a forgot password email from the PayFabric Receivables website.

###### Request
```http
POST /users/forgotpassword?username=Nodus0001 HTTP/1.1
```

###### Response
```text
true
```


Send Forgot UserName Email
--------------------

* `POST /users/forgotusername` will send a forgot username email from the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/ForgotUsernameEmail.md)
```json
{
	"CustomerId": "Nodus0001",
	"Email": "Nodus0001@nodus.com"
}
```


###### Response
```text
true
```


Verify access code
--------------------

* `GET /users/isaccessible?accessCode={AccessCodeGuid}` will verify the access code from the PayFabric Receivables website.

###### Request
```http
GET /users/isaccessible?accessCode=9F13BA90-14DE-4A98-8708-F147CCC1F0DB HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeResponse)
```json
{
    "AccessStatus": "Valid",
    "UserId": "d4c6ed39-6c85-4b01-accc-9d277e9e418f"
}
```


Update an user's profile
--------------------
This api requires authentication

* `POST /users/profile` will send an update for the customer's profile

###### Request
For more information on available fields please see our [object reference](../../Objects/AccountUser.md#AccountUserPost)
```json
{
	"UserName": "Nodus0001"
}
```


###### Response
```text
true
```


Retrieve a Registration Key
--------------------

* `POST /users/registration` will register a customer on the PayFabric Receivables website based on the JSON request payload.

###### Request
For more information on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserSelfRegister)
```json
{
	"CustomerId": "Nodus0001"
}
```


###### Response
For more information on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeRegisterResponse)
```json
{
    "RegistrationKey": "6dede74f-4eae-4c26-a210-6a7418c8988b"
}
```


Invite a Customer User
--------------------

* `POST /users/invite` will send the registration email to the customer user based on the JSON request payload. If user has authentication, it will display the Registration Key on the page, otherwise it will only send an email when "SendEmail" is true.

###### Request
For more information on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserRegister)
```json
{
	"CustomerId": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"Permission": "FullAccess",
}
```


###### Response
For more information on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeRegisterResponse)
```json
{
    "RegistrationKey": "6dede74f-4eae-4c26-a210-6a7418c8988b"
}
```


Verify registration key
--------------------

* `GET /users/registration/{RegistrationGuid}` will verify the registration key for the customer on the PayFabric Receivables website based on the JSON request payload.

###### Request
```http
GET /users/registration/6dede74f-4eae-4c26-a210-6a7418c8988b HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeVerifyResponse)
```json
{
    "CustomerId": "Nodus0001",
    "Email": "Nodus0001@nodus.com",
    "CreatedOn": "2018-05-25T13:55:51.243",
    "RegistrationKey": "6dede74f-4eae-4c26-a210-6a7418c8988b",
    "Status": "Active",
	"Permission": "FullAccess"
}
```


Send Reset Password Email
--------------------

* `POST /users/resetpassword` will send a reset password confirmation email from the PayFabric Receivables website based on the JSON request payload if the email template is enabled.

###### Request
For more information on available fields please see our [object reference](../../Objects/ResetPasswordEmail.md)
```json
{
	"AccessCode": "d4c6ed39-6c85-4b01-accc-9d277e9e418f",
	"NewPassword": "password1"
}
```


###### Response
```text
true
```
