## Customer User
There are two customer user objects that represent a customer that has been set up with a login in the PayFabric Receivables website, CustomerUserPost, and CustomerUserRegister. 


## CustomerUserPost
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CustomerId | String | Y (Create Only) | The account's customer number | 50 |
| Email | String | Y (Create Only) | The account's email, must be a single valid email address | 255 |
| Name | String | N| The account's name | 255 |
| Password | String | Y (Create Only) | The account's password | 100 |
| Permission | String | Y (Create Only) | The account's permission. Valid options are ``Full Access``, ``View & Pay``, or ``View Only`` | 20 |
| RegistrationKey | Guid | Y (Create Only) | Guid of the registration key so that the customer may register |  |
| Status | String | N | The account's status | 25 |
| UserName | String | Y | The account's username | 255 |

## CustomerUserSelfRegister
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| CustomerId | String | Y | The account's customer number | 50 |

## CustomerUserRegister
| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| AccessCode | Guid | N | Guid of the registration key so that a pending user may register |  |
| CustomerId | String | Y | The account's customer number | 50 |
| Email | String | Y | The account's email, must be a single valid email address | 255 |
| Name | String | N | The account's name | 255 |
| Permission | String | Y | The account's permission. Valid options are ``Full Access``, ``View & Pay``, or ``View Only`` | 20 |
| SendEmail | Boolean | N | Indicates if a registration email should be sent to the customer |  |

## CustomerUserResponse
| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AccessCode | Guid | Guid of the registration key so that the user may register |  |
| CustomerId | String | The account's customer number | 50 |
| Email | String | The account's email, must be a single valid email address | 255 |
| LastLogin | DateTime | The last login date for this user |  |
| LastPasswordChangedDate | DateTime | The last date the password changed for this user |  |
| ModifiedOn | DateTime | The last modified date for this user |  |
| Name | String | The account's name | 255 |
| Permission | String | The account's permissions | 100 |
| RegisterDate | DateTime | The register date for this user |  |
| Status | String | The account's status | 25 |
| UserName | String | The account's username | 255 |
