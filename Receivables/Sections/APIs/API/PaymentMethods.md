Payment Methods
============

The Payment Method API is used for retrieving the create and edit URL for PayFabric wallets, deleting, and viewing payment method information on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve Payment Methods by Currency Code
--------------------

* `GET /paymentmethods?currencycode={CurrencyCode}` will retrieve the payment methods associated to the currency on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /paymentmethods?currencyCode=USD
</pre>

###### Response
<pre>
[
    {
        "WalletEntryGuid": "9c89c8de-04f1-4db5-87de-b20a28056e62",
        "CustomerId": "Nodus0001",
        "DisplayName": "",
        "CreditCardName": "nodus",
        "CreditCardNumber": "XXXXXXXXX1111",
        "CreditCardExpiredDate": "2032-01-01T00:00:00",
        "TenderType": "CreditCard",
        "CardName": "Visa",
	"CardNameDisplay": "Visa",
        "CreditCardType": "VISA",
        "ECheckType": "Checking",
        "ECheckAccountNumber": "XXXXXXXXX1111",
        "ECheckAbaNumber": "",
        "IsDefault": false,
	"IsLocked": false,
        "ModifiedOn": "2018-05-23T22:07:10",
        "BillTo": null
    }
]
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/PaymentMethod.md#PaymentMethodResponse).


Delete a Payment Method
--------------------

* `DELETE /paymentmethods/{WalletEntryGuid}` will delete the payment method on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	DELETE /paymentmethods/9c89c8de-04f1-4db5-87de-b20a28056e62
</pre>

###### Response
<pre>
	true
</pre>


Retrieve the Edit Wallet URL for PayFabric Hosted Page
--------------------

* `GET /paymentmethods/{WalletEntryGuid}/url"` will retrieve the edit wallet url used on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| isAutoPay | Boolean value if the wallet is coming from AutoPay |
| returnUrl | Return URL to redirect after creation |

###### Request
<pre>
	GET /paymentmethods/9c89c8de-04f1-4db5-87de-b20a28056e62/url
</pre>

###### Response
<pre>
	"https://sandbox.payfabric.com//payment/Web/Wallet/Edit?Token=1%3a4u4j59pmq86l&IsAutoPay=0&Edit=1&Card=9c89c8de%2D04f1%2D4db5%2D87de%2Db20a28056e62&ReturnUri=http%3a%2f%2flocalhost%3a54424%2fnodus%2fapi"
</pre>


Retrieve the Create Wallet URL for PayFabric Hosted Page
--------------------

* `GET /paymentmethods/{tender:(ECheck|CreditCard)}/url?currencyCode={CurrencyCode}"` will retrieve the payment method creation url used on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| isAutoPay | Boolean value if the wallet is coming from AutoPay |
| returnUrl | Return URL to redirect after creation |

###### Request
<pre>
	GET /paymentmethods/CreditCard/url?currencyCode=USD
</pre>

###### Response
<pre>
	"https://sandbox.payfabric.com//payment/Web/Wallet/Create?Token=1%3a4u4j59b2lsn7&Tender=CreditCard&customer=AARONFIT0001&IsAutoPay=0&CurrencyCode=Z%2DUS%24&ReturnUri=http%3a%2f%2flocalhost%3a54424&Country=USA&Street1=98765+Crossway+Park+Dr&Street3=&City=&State=MN&Zip=55304%2D9840&Email=nodus%2Echina%40aliyun%2Ecom&Phone="
</pre>


Retrieve the Default Payment Method
--------------------

* `GET /paymentmethods/default?currencyCode={CurrencyCode}` will retrieve the default payment method on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /paymentmethods/default?currencyCode=USD
</pre>

###### Response
<pre>
{
	"WalletEntryGuid": "9c89c8de-04f1-4db5-87de-b20a28056e62",
	"CustomerId": "Nodus0001",
	"DisplayName": "",
	"CreditCardName": "nodus",
	"CreditCardNumber": "XXXXXXXXX1111",
	"CreditCardExpiredDate": "2032-01-01T00:00:00",
	"TenderType": "CreditCard",
	"CardName": "Visa",
	"CardNameDisplay": "Visa",
	"CreditCardType": "VISA",
	"ECheckType": "Checking",
	"ECheckAccountNumber": "XXXXXXXXX1111",
	"ECheckAbaNumber": "",
	"IsDefault": false,
	"IsLocked": false,
	"ModifiedOn": "2018-05-23T22:07:10",
	"BillTo": null
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/PaymentMethod.md#PaymentMethodResponse).


Retrieve Payment Checkout Page URL
--------------------

* `GET /paymentmethods/hostedpayment/url?paymentIdentity={PaymentIdentity}"` will retrieve the payment method creation url used on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| setupId | SetupId to be used for processing if different then default |
| newWallet | Boolean value if the wallet is new or not |
| returnUri | Return URL to redirect after creation |

###### Request
<pre>
	GET /paymentmethods/hostedpayment/url?paymentIdentity=WEBPMT000000020
</pre>

###### Response
<pre>
	"https://sandbox.payfabric.com//payment/web/transaction/process?Token=2%3a4u79jfzl6aqx&Key=19041500243061&ReturnUri=https%3a%2f%2fsandbox%2Epayfabric%2Ecom%2fcustomerportal%2fNodusMD%2fWallet%2fPayfabricWalletReturn&Symbol=%24&newWallet=True&Country=USA&Street1=One+Microsoft+Way&City=Redmond&State=WA&Zip=98052%2D6399&Email=Nodus0001%40nodus%2Ecom"
</pre>


Retrieve Payment Methods Paging
--------------------

* `GET /paymentmethods/paging` will retrieve the payment methods with paging on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| SortBy | Sort direction and sort field | [SortBy Filter](../QueryFilter.md#sortby-filter) |

###### Request
<pre>
	GET /paymentmethods/paging?filter.pageSize=10&filter.pageIndex0&filter.criteria.CurrencyCode=USD
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
			"WalletEntryGuid": "9c89c8de-04f1-4db5-87de-b20a28056e62",
			"CustomerId": "Nodus0001",
			"DisplayName": "",
			"CreditCardName": "nodus",
			"CreditCardNumber": "XXXXXXXXX1111",
			"CreditCardExpiredDate": "2032-01-01T00:00:00",
			"TenderType": "CreditCard",
			"CardName": "Visa",
			"CardNameDisplay": "Visa",
			"CreditCardType": "VISA",
			"ECheckType": "Checking",
			"ECheckAccountNumber": "XXXXXXXXX1111",
			"ECheckAbaNumber": "",
			"IsDefault": false,
			"IsLocked": false,
			"ModifiedOn": "2018-05-23T22:07:10",
			"BillTo": null
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/PaymentMethod.md#PaymentPagingResponse).


Retrieve TenderType Enabling on Wallet Page
--------------------

* `GET /paymentmethods/tendertypeenabling` will retrieve what tender types are enabled on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /paymentmethods/tendertypeenabling
</pre>

###### Response
<pre>
{
	"CreditCardEnabled": true,
	"ECheckEnabled": true
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/PaymentMethod.md#PaymentMethodTenderTypeEnablingResponse).
