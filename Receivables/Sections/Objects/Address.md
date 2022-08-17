## Address
There are two Address objects that represent the shipping or billing address of a customer, AddressPost and AddressResponse. These objects may be included as a child attribute of other JSON objects (such as [Customer](Customer.md)).


## AddressPost
This object is used when creating an address on the PayFabric Receivables website.

| Attribute | Data Type | Required | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- | :--------- |
| Address1 | String | N | The first line of a street address | 100 |
| Address2 | String | N | The second line of a street address | 100 |
| Address3 | String | N | The third line of a street address | 100 |
| AddressID | String | Y | The address identifier | 50 |
| City | String | N | City name | 50 |
| Country | String | N | Country name | 50 |
| Email | String | N | Email address, must be a single valid email address | 255 |
| Fax | String | N | Fax number | 50 |
| Name | String | N | Customer name | 100 |
| Phone | String | N | Phone number line 1 | 50 |
| State | String | N | State name | 50 |
| Zip | String | N | Zip code | 50 |


## AddressResponse
This object is used when getting an address from the PayFabric Receivables website.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| AddressGuid | Guid | Unique identifier for the address |  |
| Address1 | String | The first line of a street address | 100 |
| Address2 | String | The second line of a street address | 100 |
| Address3 | String | The third line of a street address | 100 |
| City | String | City name | 50 |
| Country | String | Country name | 50 |
| Email | String | Email address, must be a single valid email address | 255 |
| Fax | String | Fax number | 50 |
| isDefaultBilling | Boolean | Is the default billing address |  |
| isDefaultShipping | Boolean | Is the default shipping address |  |
| Name | String | Customer name | 50 |
| Phone | String | Phone number line 1 | 50 |
| State | String | State name | 50 |
| Zip | String | Zip code | 50 |
