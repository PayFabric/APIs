Accounts
============

The Account API is used for all information related to an account on the PayFabric Receivables website. Please note that some of the below requests require API authentication and some do not, see our [guide](Token.md) on how to authenticate.

Retrieve the current user
--------------------
This api requires authentication

* `GET /currentuser` will retrieve the currently logged in user.

###### Request
<pre>
	GET /currentuser
</pre>

###### Response
<pre>
{
	"UserName": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"FirstName": "Nodus",
	"LastName": "Technologies"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AccountUser.md#AccountUserResponse).


Create a customer user
--------------------

* `POST /users` will create a user on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
{
	<b>"CustomerId": "Nodus0001"</b>,
	<b>"Email": "Nodus0001@nodus.com"</b>,
	<b>"Password": "password1"</b>,
	<b>"RegistrationKey":"6F25DF7B-8B48-4041-91F4-9E84EF723A8A"</b>,
	"Status": "Active",
	<b>"UserName": "Nodus0001"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserPost).

###### Response
<pre>
	true
</pre>


Update a customer user
--------------------
This api requires authentication

* `PUT /users` will update a user on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
{
	"CustomerId": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"Password": "password1",
	"RegistrationKey":"6F25DF7B-8B48-4041-91F4-9E84EF723A8A",
	"Status": "Active",
	<b>"UserName": "Nodus0001"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserPost).

###### Response
<pre>
	true
</pre>


Send Forgot Password Email
--------------------

* `POST /users/forgotpassword?username={UserName}` will send a forgot password email from the PayFabric Receivables website.

###### Request
<pre>
	POST /users/forgotpassword?username=Nodus0001
</pre>

###### Response
<pre>
	true
</pre>


Send Forgot UserName Email
--------------------

* `POST /users/forgotusername` will send a forgot username email from the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
{
	<b>"CustomerId": "Nodus0001"</b>,
	<b>"Email": "Nodus0001@nodus.com"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/ForgotUsernameEmail.md).

###### Response
<pre>
	true
</pre>


Verify access code
--------------------

* `GET /users/isaccessible?accessCode={AccessCodeGuid}` will verify the access code from the PayFabric Receivables website.

###### Request
<pre>
	GET /users/isaccessible?accessCode=9F13BA90-14DE-4A98-8708-F147CCC1F0DB
</pre>

###### Response
<pre>
{
    "AccessStatus": "Valid",
    "UserId": "d4c6ed39-6c85-4b01-accc-9d277e9e418f"
}
</pre>

For more information and descriptions on available fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeResponse).


Update an user's profile
--------------------
This api requires authentication

* `POST /users/profile` will send an update for the customer's profile

###### Request
<pre>
{
	"CustomerId": "Nodus0001",
	"Email": "Nodus0001@nodus.com",
	"FirstName": "Nodus",
	"LastName": "Technologies",
	"OldPassword": null,
	"Password": null,	
	<b>"UserName": "Nodus0001"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/AccountUser.md#AccountUserPost).

###### Response
<pre>
	true
</pre>


Retrieve Registration Key
--------------------

* `POST /users/registration` will register a customer on the PayFabric Receivables website based on the JSON request payload. If user has authentication, it will display Registration Key on the page, otherwise it will only send email when "SendEmail" is true.

###### Request
<pre>
{
	<b>"CustomerId": "Nodus0001"</b>,
	<b>"Email": "Nodus0001@nodus.com"</b>,
	"SendEmail": false
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/CustomerUser.md#CustomerUserRegister).

###### Response
<pre>
{
    "Message": "",
    "RegistrationKey": "6dede74f-4eae-4c26-a210-6a7418c8988b"
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeRegisterResponse).


Verify registration key
--------------------

* `GET /users/registration/{RegistrationGuid}` will verify the registration key for the customer on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /users/registration/6dede74f-4eae-4c26-a210-6a7418c8988b
</pre>

###### Response
<pre>
{
    "CustomerId": "Nodus0001",
    "Email": "Nodus0001@nodus.com",
    "CreatedOn": "2018-05-25T13:55:51.243",
    "RegistrationKey": "6dede74f-4eae-4c26-a210-6a7418c8988b",
    "Status": "Active"
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/AccessCode.md#AccessCodeVerifyResponse).


Send Reset Password Email
--------------------

* `POST /users/resetpassword` will send a reset password confirmation email from the PayFabric Receivables website based on the JSON request payload if the email template is enabled.

###### Request
<pre>
{
	<b>"AccessCode": "d4c6ed39-6c85-4b01-accc-9d277e9e418f"</b>,
	<b>"NewPassword": "password1"</b>
}
</pre>

Please note that **bold** fields are required fields, and all others are optional. For more information and descriptions on available fields please see our [object reference](../../Objects/ResetPasswordEmail.md).

###### Response
<pre>
	true
</pre>
