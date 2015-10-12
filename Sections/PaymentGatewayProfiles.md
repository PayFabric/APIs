Payment Gateway Profiles
========================

The PayFabric Payment Gateway Profiles API is used for returning the gateway profiles that have been setup from the PayFabric portal, see [here](https://github.com/PayFabric/Portal/wiki#setup-gateway-account) for a guide on how to set up a gateway.  Please note that all requests require API authentication, see our [guide](https://github.com/ShaunSharples/APIs/blob/ShaunSharples-patch-1/Sections/Authentication.md) on how to authenticate.

Get Payment Gateway Profile
---------------------------

* `GET /rest/api/setupid/079C5DA2-DF91-4AD6-9BA2-A52300FEF06A` will return the specified payment gateway profile 
 
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

Get Payment Gateway Profiles
----------------------------

* `GET /rest/api/setupid` will return all payment gateway profiles configured for the PayFabric user
 
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
