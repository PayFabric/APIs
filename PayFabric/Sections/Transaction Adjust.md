Transaction Adjustment
=================

Transaction adjustment API provide ability to adjust tip, increment authorization and correct authorization for approved EVO Snap* transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

This adjust API is only available for unsettled EVO Snap transactions.


| Parameter  | Description|
| :-----------|:---------| 
| Action | Accept value is 'IncrementAuthorization' and 'CorrectAuthorization'. |
| TrxKey | PayFabric transaction key.|
| AdjustAmount| Adjust amount for each action.|

Increment Authorization
---------------------------
<b>Incremental Authorization</b> represent additions to previously authorized amounts and do not replace the original authorization. The sum of all linked estimated and incremental authorizations represents the total amount authorized for a given transaction.

Set *Action* = *IncrementAuthorization*, then *AdjustAmount* means the increase amount to the specified approved transaction, the final amount will update with fomular: New Final Amount = Original Final Amount + Adjust Amount; Increment authorization is available for Approved Sale and book transactions. But Increment authorization call will be failed if followed on a transaction which already adjusted tip or a book transaciton which has been captured/partially captured.

* `PATCH /payment/3.1/api/Transaction/Adjust` allows to adjust tip amount, increment authorization and partial reversal for approved EVO Snap transactions

###### Request
<pre>
{
    "Action": "IncrementAuthorization",
    "TrxKey": "21100900761487",
    "AdjustAmount": "30"
}
</pre>
###### Response
<pre>
{
    "Result": true,
    "Message": "APPROVED",
    "AdjustAmount": "30",
    "TrxAmount": "120.00",
    "OriginationID": "A677B1F59D85414BAB8D5E677A79BE11"
}
</pre>

Correct authorization
---------------------------
<b>Correct Authorization</b> transactions are used to assist issuing banks with managing a cardholder’s open-to-buy balance, allowing optimal use of their funds.  This processing is especially important for prepaid cards and debit cardholders where the balance represents a checking or savings account balance.  

Set *Action* = *CorrectAuthorization*, then *AdjustAmount* means the new final amount, it will correct the final amount for the specified transaction; Correct authorization is available for Approved Sale and book transactions. Correct authorization call will be failed if follows a book transaciton which has been captured/partially captured.

* `PATCH /payment/3.1/api/Transaction/Adjust` allows to adjust tip amount, increment authorization and partial reversal for approved EVO Snap transactions

###### Request
<pre>
{
    "Action": "CorrectAuthorization",
    "TrxKey": "21100900761488",
    "AdjustAmount": "100"
}
</pre>
###### Response
<pre>
{
    "Result": true,
    "Message": "APPROVED",
    "AdjustAmount": "100",
    "TrxAmount": "100.00",
    "OriginationID": "A677B1F59D85414BAB8D5E677A79BE11"
}
</pre>
