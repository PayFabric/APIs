Transaction Adjustment
=================

Transaction adjustment API provide ability to adjust tip, increment authorization and correct authorization for approved EVO Snap* transactions.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

<b>Adjust Tip</b> 
<b>Incremental Authorization</b> represent additions to previously authorized amounts and do not replace the original authorization. The sum of all linked estimated and incremental authorizations represents the total amount authorized for a given transaction.
<b>Correct Authorization</b> transactions are used to assist issuing banks with managing a cardholder’s open-to-buy balance, allowing optimal use of their funds.  This processing is especially important for prepaid cards and debit cardholders where the balance represents a checking or savings account balance.  


| Parameter  | Description|
| :-----------|:---------| 
| Action | Accept value is 'TipAdjustment', 'IncrementAuthorization' and 'CorrectAuthorization'. |
| TrxKey | PayFabric transaction key.|
| AdjustAmount| If the *Action* is *TipAdjustment*, then *AdjustAmount* means the new tip amount, it will replace the existing tip amount on this transaction and update the Final transaction amount with fomular: New Final Amount = Original Final Amount - Original Tip Amount + Adjust Amount;
||If the *Action* is *IncrementAuthorization*, then *AdjustAmount* means the increase amount to the specified approved transaction, the final amount will update with fomular: New Final Amount = Original Final Amount + Adjust Amount;
||If the *Action* is *CorrectAuthorization*, then *AdjustAmount* means the new final amount, it will correct the final amount for the specified transaction;|

Adjust Tip
---------------------------

* `PATCH /payment/3.1/api/Transaction/Adjust` allows to adjust tip amount, increment authorization and partial reversal for approved EVO Snap transactions

###### Request
<pre>
{
    "Action": "TipAdjustment",
    "TrxKey": "21100900761487",
    "AdjustAmount": "30"
}

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
