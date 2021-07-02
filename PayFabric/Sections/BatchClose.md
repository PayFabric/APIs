Batch Close
============

This provides more flexibility to control the batch cutoff/close time instead of relying on the batch close defaults. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Manually Batch Close Transactions
----------------------------------

* `POST /setupid/{ID}/batchclose` will 

###### Request
No request body required

###### Response
{
    "Result": "True"
}
