Payment Gateway Profiles
========================

The PayFabric Payment Gateway Profiles API is used for returning the gateway profiles that have been setup from the PayFabric portal, see our [guide](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) on how to set up a gateway.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Payment Gateway Profile
----------------------------------

* `GET /payment/api/setupid/{GatewayID}` will return the specified payment gateway profile 
 
###### Response
<pre>
{
    "CardClass": "ECheck",
    "CardClassID": "2",
    "Connector": "AuthorizeNet",
    "DailyBatchCloseTime": "19:30",
    "ID": "df2001bf-72a5-4784-b089-8720d3085938",
    "Name": "AuthECheck",
    "Processor": "Authorize.net",
    "ProcessorID": "1",
    "SettledTime": "5/25/2022 7:30:00 PM",
    "SettledTimeUTC": "2022-05-26T02:30:00.000Z",
    "SurchargeRate": "0"
}
</pre>

Retrieve Payment Gateway Profiles
---------------------------------

* `GET /payment/api/setupid` will return all payment gateway profiles configured for the PayFabric user
 
###### Response
<pre>
[
    {
        "CardClass": "ECheck",
        "CardClassID": "2",
        "Connector": "AuthorizeNet",
        "DailyBatchCloseTime": "19:30",
        "ID": "df2001bf-72a5-4784-b089-8720d3085938",
        "Name": "AuthECheck",
        "Processor": "Authorize.net",
        "ProcessorID": "1",
        "SettledTime": "5/25/2022 7:30:00 PM",
        "SettledTimeUTC": "2022-05-26T02:30:00.000Z",
        "SurchargeRate": "0"
    },
    {
        "CardClass": "Credit Card",
        "CardClassID": "1",
        "Connector": "AuthorizeNet",
        "DailyBatchCloseTime": "01:30",
        "ID": "c8204c50-0ade-4d79-a607-2e106a596dc0",
        "Name": "AuthorizeCredit",
        "Processor": "Authorize.net",
        "ProcessorID": "1",
        "SettledTime": "5/26/2022 1:30:00 AM",
        "SettledTimeUTC": "2022-05-26T08:30:00.000Z",
        "SurchargeRate": "0"
    }
]
</pre>


Manually Batch Close Transactions
----------------------------------

* `POST /payment/api/setupid/{GatewayID}/batchclose` will settle the transactions processed via the specified gateway. This API provides more flexibility to control the batch cutoff/close time instead of relying on the batch close defaults. 

###### Response
{
    "Result": "True"
}


