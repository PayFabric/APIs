Wallet 3.1
===========================

The PayFabric Wallet 3.1 API is used to manage customer wallet records. 

Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.


Delete Wallets in Bulk
---------------------------

Delete a wallet record.

### Endpoint
* `GET /payment/3.1/api/wallet/bulkdelet`  will delete the filtered wallets based on the . 

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190</kbd>

| Query String     | DataType |  Required? |
| :--------------- | :------- | :--------- | 
| Customer         | String   |  Optional, must be a string value, and not exceed 128 characters.|
| CustomerOperator | Operator | Conditional – Required if Customer is provided. Must be one of: "Contains" or "Equals". |
| Tender         | String   |  Optional, must be a string value, and must be one of: "CreditCard" or "ECheck". |
| CardType         | String   |  Optional, must be a string value, and must be one of: "AmericanExpress", "DinersClub", "Discover", "JCB", "MasterCard" or "Visa". |
| ExpDateStart         | String   | Optional, must be a string value representing a specific month and year in the format of MM/YYYY and must be a valid date. If both ExpDateStart and ExpDateEnd are provided, then ExpDateEnd must be greater than ExpDateStart.  |
| ExpDateEnd         | String   |  Optional, must be a string value representing a specific month and year in the format of MM/YYYY and must be a valid date. If both ExpDateStart and ExpDateEnd are provided, then ExpDateEnd must be greater than ExpDateStart.  |
| Account         | String   |  Optional, must be a string value representing the last 4 digits of the card number.  Must not exceed 4 characters. |
| FirstName         | String   |  Optional, must be a string value, and not exceed 64 characters. |
| FirstNameOperator         | String   |  Conditional – Required if 'FirstName' is provided. Must be one of: "Contains" or "Equals".  |
| LastName         | String   |  Optional, must be a string value, and not exceed 64 characters. |
| LastNameOperator         | String   |  Conditional – Required if 'LastName' is provided. Must be one of: "Contains" or "Equals".  |
| LastUsedDateStart         | String   |  Optional, must be a date value representing a specific day, month and year in the format of MM/DD/YYYY and must be a valid date. If both LastUsedDateStart and LastUsedDateEnd are provided, then LastUsedDateEnd must be greater than LastUsedDateStart. |
| LastUsedDateEnd         | String   |  Optional, must be a date value representing a specific day, month and year in the format of MM/DD/YYYY and must be a valid date. If both LastUsedDateStart and LastUsedDateEnd are provided, then LastUsedDateEnd must be greater than LastUsedDateStart.  |

###### Response
```JSON
{
  "Result": "True"
}
```
