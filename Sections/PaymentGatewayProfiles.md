Payment Gateway Profiles
========================

The PayFabric Payment Gateway Profiles API is used for returning the gateway profiles that have been setup from the PayFabric portal, see our [guide](https://github.com/PayFabric/Portal/tree/v2/Sections/Quick%20Start.md#setup-gateway-account) on how to set up a gateway.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Retrieve a Payment Gateway Profile
----------------------------------

* `GET /rest/api/setupid/079C5DA2-DF91-4AD6-9BA2-A52300FEF06A` will return the specified payment gateway profile 
 
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
}
</pre>

Retrieve Payment Gateway Profiles
---------------------------------

* `GET /rest/api/setupid` will return all payment gateway profiles configured for the PayFabric user
 
###### Response
<pre>
[
  {
    "CardClass": "ECheck",
    "CardClassID": "2",
    "Connector": "AuthorizeNet",
    "ID": "B0AB461C-114C-48C5-A9AE-A52300ACC36E",
    "Name": "AuthorizeNet ECheck",
    "Processor": "Authorize.net",
    "ProcessorID": "1"
  },
  {
    "CardClass": "Credit",
    "CardClassID": "1",
    "Connector": "PayflowPro",
    "ID": "079C5DA2-DF91-4AD6-9BA2-A52300FEF06A",
    "Name": "PFP",
    "Processor": "TSYS(Vital/VisaNet)",
    "ProcessorID": "18"
  }
]
</pre>
