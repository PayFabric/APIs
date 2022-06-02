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
    "CardClassID": "3",
    "Connector": "EvoACH",
    "DailyBatchCloseTime": "20:00",
    "ID": "d91e5b3a-b10f-4f02-b3b9-32bfbdc1834e",
    "Name": "EVO ACH",
    "Processor": "Evo ACH",
    "ProcessorID": "1",
    "SettledTime": "5/31/2022 8:00:00 PM",
    "SettledTimeUTC": "2022-06-01T03:00:00.000Z",
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
        "CardClassID": "3",
        "Connector": "EvoACH",
        "DailyBatchCloseTime": "20:00",
        "ID": "d91e5b3a-b10f-4f02-b3b9-32bfbdc1834e",
        "Name": "EVO ACH",
        "Processor": "Evo ACH",
        "ProcessorID": "1",
        "SettledTime": "5/31/2022 8:00:00 PM",
        "SettledTimeUTC": "2022-06-01T03:00:00.000Z",
        "SurchargeRate": "0"
    },
    {
        "CardClass": "Credit",
        "CardClassID": "1",
        "Connector": "EVO",
        "DailyBatchCloseTime": "20:00",
        "ID": "769d99c9-047d-44b3-824b-9a7ccf45eccb",
        "Name": "EVO",
        "Processor": "Evo US",
        "ProcessorID": "1",
        "SettledTime": "3/4/2020 8:00:00 PM",
        "SettledTimeUTC": "2020-03-05T04:00:00.000Z",
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


