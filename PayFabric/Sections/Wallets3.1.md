Wallet 3.1
===========================

The PayFabric Wallet 3.1 API is used to manage customer wallet records. 

Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.


Delete Wallets in Bulk
---------------------------
Merchants could use either our [Merchant Portal]() or our Payment API’s to initiate a purge of their stored wallets based on criteria provided.

### Endpoint
* `POST /payment/3.1/api/wallet/bulkdelet`  will delete the filtered wallets based on the . 

### Example
###### Request
```JSON
{
    "Customer": "AA",
    "CustomerOperator": "equals",
    "Tender": "CreditCard",
    "FirstName": "a",
    "FirstNameOperator": "Contains",
    "CardType": null,
    "ExpDateStart": null,
    "ExpDateEnd": null,
    "Account": "1111",
    "LastUsedDateStart": "04/06/2023"
}
```
**IMPORTANT!!!**

**Will purge all wallets when call this API without any filters!!!  Reversal/Undo of the deletion is not possible using standard PayFabric processes!!!**

###### Available filters
| Filter Name     | DataType |  Required? |
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
    "Result": true,
    "WalletsToDeleteCount": 5,
    "TotalWalletCount": 13087,
    "Message": "Thank you for confirming the deletion. 5 records will be scheduled to be permanently deleted within 24 hours."
}
```
