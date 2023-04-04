Credit Card / eCheck Wallet
===========================

The PayFabric Wallet API is used to manage customer wallet records. Each credit card or bank account is saved as as wallet record, and its ownership tied to `Customer`.

Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.


| Query String     | DataType | Definition | Required? |
| :--------------- | :------- | :--------- | :---------|
| customer         | String   | Retrieve wallets matching the `Customer`. | Required |
| tender           | String   | Can be <kbd>CreditCard</kbd> or <kbd>ECheck</kbd>. | Optional |
| fromLastUsedDate | String   | Retrieve wallets which its `LastUsedDate` is later than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and is based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Optional |  
| toLastUsedDate   | String   | Retrieve wallets which its `LastUsedDate` is earlier than the specified date. Date format `YYYY-MM-DD` or `MM-DD-YYYY`, and is based on merchant [Timezone](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Timezone.md). | Optional | 




Remove Credit Card / eCheck
---------------------------

Delete a wallet record.

### Endpoint
<kbd><kbd>GET</kbd> /payment/api/wallet/delete/<kbd>{WALLET_ID}</kbd></kbd>

### Example
###### Request
<kbd><kbd>GET</kbd> /payment/api/wallet/delete/cbb571ea-e834-41c4-8a20-7d55bb7ae190</kbd>

###### Response
```JSON
{
  "Result": "True"
}
```
