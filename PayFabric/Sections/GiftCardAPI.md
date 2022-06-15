# Gift Card APIs
The API is used for managing gift card. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Inquiry Gift Card Balance
------------------------------
* `POST /payment/3.1/api/giftcard/balance` will inquiry the gift card balance.

###### Request
<pre>
{
    <b>"Account":"4111111111111111",</b>
    "CVC":"123"  
}
</pre>
###### Response
<pre>
{
    "CurrentBalance": "10.00",
    "Status": "Approved",
    "ResponseCode": "1",
    "Message": "APPROVED",
    "MaskedAccount": "XXXXXXXXXXXX1111"
}
</pre>
