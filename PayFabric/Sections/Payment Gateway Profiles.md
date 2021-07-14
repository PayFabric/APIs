Payment Gateway Profiles
========================

The PayFabric Payment Gateway Profiles API is used for returning the gateway profiles that have been setup from the PayFabric portal, see our [guide](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) on how to set up a gateway.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Payment Gateway Profile
----------------------------------

* `GET /api/setupid/6f417308-c26f-499b-acc4-d6080ad0551f` will return the specified payment gateway profile 
 
###### Response
<pre>
{
    "CardClass": "Credit",
    "CardClassID": "1",
    "Connector": "PayflowPro",
    "DailyBatchCloseTime": "19:00",
    "ID": "6f417308-c26f-499b-acc4-d6080ad0551f",
    "Name": "db back up",
    "Processor": "TSYS(Vital/VisaNet)",
    "ProcessorID": "18",
    "SettledTime": "2021-07-02T02:00:00.0000000Z",
    "SurchargeRate": "0"
}
</pre>

Retrieve Payment Gateway Profiles
---------------------------------

* `GET /api/setupid` will return all payment gateway profiles configured for the PayFabric user
 
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
        "SettledTime": "2021-07-02T02:30:00.0000000Z",
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
        "SettledTime": "2021-07-01T08:30:00.0000000Z",
        "SurchargeRate": "0"
    }
]
</pre>


Manually Batch Close Transactions
----------------------------------

* `POST /api/setupid/079C5DA2-DF91-4AD6-9BA2-A52300FEF06A/batchclose` will settle the transactions processed via the specified gateway. This API provides more flexibility to control the batch cutoff/close time instead of relying on the batch close defaults. 

###### Response
{
    "Result": "True"
}


