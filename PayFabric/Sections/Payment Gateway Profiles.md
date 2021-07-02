Payment Gateway Profiles
========================

The PayFabric Payment Gateway Profiles API is used for returning the gateway profiles that have been setup from the PayFabric portal, see our [guide](https://github.com/PayFabric/Portal/blob/master/PayFabric/Sections/Configure%20Portal.md#gateway-profile) on how to set up a gateway.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Payment Gateway Profile
----------------------------------

* `GET /setupid/079C5DA2-DF91-4AD6-9BA2-A52300FEF06A` will return the specified payment gateway profile 
 
###### Response
<pre>
{
  "CardClass": "Credit",
  "CardClassID": "1",
  "Connector": "PayflowPro",
  "ID": "079C5DA2-DF91-4AD6-9BA2-A52300FEF06A",
  "Name": "PFP",
  "Processor": "TSYS(Vital/VisaNet)",
  "ProcessorID": "18"
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
        "CardClass": "Credit",
        "CardClassID": "1",
        "Connector": "EVO",
        "ID": "bb373958-aa49-40d5-b515-8e4d96836c88",
        "Name": "EVO",
        "Processor": "Evo US",
        "ProcessorID": "1",
        "SurchargeRate": "4"
    },
    {
        "CardClass": "Credit",
        "CardClassID": "1",
        "Connector": "EVO",
        "ID": "d75c0619-db8d-41c9-9322-85e25d2b0a99",
        "Name": "EVO0623",
        "Processor": "Evo US",
        "ProcessorID": "1",
        "SurchargeRate": "0"
    }
]
</pre>


Manually Batch Close Transactions
----------------------------------

* `POST /setupid/079C5DA2-DF91-4AD6-9BA2-A52300FEF06A/batchclose` will settle the transactions processed via the specified gateway. This API provides more flexibility to control the batch cutoff/close time instead of relying on the batch close defaults. 

###### Response
{
    "Result": "True"
}


