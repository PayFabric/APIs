Invoices
============

The Invoice API is used for viewing invoices on the PayFabric Receivables website. Please note that all requests require API authentication, see our [guide](Token.md) on how to authenticate.

Retrieve invoice currencies by query parameters
--------------------

* `GET /invoices/currencies` will get all currencies associated to invoices on the PayFabric Receivables website based on the JSON request payload.

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/outstanding/currencies?filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
<pre>
[
	{
		"CurrencyGuid": "faea05ff-d6e8-4f54-b345-efc8978b2199",
		"CCSetupId": "PayFlowProCredit",
		"ECSetupId": "PaymentechECheck",
		"IsUsingECheck": true,
		"IsUsingCreditCard": true,
		"IsValid": true,
		"Name": "USD",
		"CurrencyCode": "Z-US$",
		"Symbol": "$",
		"LongName": "US Dollars",
		"IsFuncCurrency": true
	}
]
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Currency.md#CurrencyResponse).


Retrieve invoice html to be displayed by invoiceId
--------------------

* `GET /invoices/display/{InvoiceId}` will get the invoice html associated to the InvoiceId on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /invoices/display/STDINV2006
</pre>

###### Response
<pre>
"
<style>         table {min-height: 25px; line-height: 25px;  border-collapse: collapse;}      table tr th, table tr td { border:1px solid gray; padding:5px; }   .divBorder{border:1px solid gray; !important  }   .money{text-align:right;}   .p5{padding:5px;}     </style>
\<div style=\"width: 45%; font-size: 14px; padding-top: 10px;margin-bottom:10px;float:left\">    \<strong>Nodus Tech\</strong>\<br>    \<strong>West First Street\</strong>\<br>    \<strong>-\</strong>\<br>     \<strong>ClaremontCAClaremont, CA 91711\</strong>    \</div>    
\<table style=\"margin-top:20px; float:right\">
   \<tbody>
      \<tr>
         \<td style=\"width:100px;\"> \<strong>Invoice\</strong>\</td>
         \<td style=\"width:170px;\"> \<strong>STDINV2006\</strong>\</td>
      \</tr>
      \<tr>
         \<td> \<strong>Date\</strong>\</td>
         \<td> \<strong>1/5/2016\</strong>\</td>
      \</tr>
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \</div>
\<div style=\"width: 270px;margin-top:20px; float:left\">    \<strong>Bill To:\</strong>    \<br>    
\<div class=\"divBorder p5\">PRIMARY\<br>P.O. Box 2734\<br>\<br>Green BayWI54305-5303\<br>\</div>
\</div>      \<div style=\"width: 270px;margin-top:20px; float:right\">     \<strong>Ship To\</strong>    \<br>    
\<div class=\"divBorder p5\">\<br>\<br>\<br>\<br>\</div>
\</div>    
\<div style=\"clear:both;\">    \</div>
\<br>   \<!--@ @--> 
\<table style=\"width:100%\">
   \<tbody>
      \<tr>
         \<th>Purchase Order No.\</th>
         \<th>Customer ID\</th>
         \<th>Salesperson ID\</th>
         \<th>Shipping Method\</th>
         \<th>Payment Terms\</th>
         \<th>Req Ship Date\</th>
      \</tr>
   \</tbody>
\</table>
\<!--@ @-->   \<div style=\"width: 270px;margin-top:20px; float:left\">     \<strong>Comments:\</strong>    \<br>    \<div class=\"divBorder\" style=\"height: 80px;padding: 2px;\">         \</div>    \</div>    
\<table style=\"float:right\">
   \<tbody>
      \<tr>
         \<td style=\"width:134px;border-top-width:0;\">\<strong>Sub Total:\</strong>\</td>
         \<td style=\"width:180px;border-top-width:0;\" class=\"money\">$399.75\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Miscellaneous:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Tax:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Freight:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Trade Discount:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Total:\</strong>\</td>
         \<td class=\"money\">$399.75\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Amount Due:\</strong>\</td>
         \<td class=\"money\">$8.00\</td>
      \</tr>
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \<b> Associated Payment(s):&nbsp;\</b>    \<br>   \</div>
\<div style=\"clear:both;\">    \<br>   \</div>
\<table width=\"100%\">
   \<tbody>
      \<tr>
         \<th>PAYMENT NUMBER\</th>
         \<th class=\"money\">AMOUNT APPLIED\</th>
         \<th>DATE\</th>
         \<th>STATUS\</th>
      \</tr>
      \<!--@@-->     
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \<br>   \</div>
"
</pre>


Retrieve invoice html to be displayed by identity
--------------------

* `GET /invoices/display/{InvoiceGuid}` will get the invoice html associated to the InvoiceGuid on the PayFabric Receivables website based on the JSON request payload.

###### Request
<pre>
	GET /invoices/display/12345678-0000-0000-0000-000000000000
</pre>

###### Response
<pre>
"
<style>         table {min-height: 25px; line-height: 25px;  border-collapse: collapse;}      table tr th, table tr td { border:1px solid gray; padding:5px; }   .divBorder{border:1px solid gray; !important  }   .money{text-align:right;}   .p5{padding:5px;}     </style>
\<div style=\"width: 45%; font-size: 14px; padding-top: 10px;margin-bottom:10px;float:left\">    \<strong>Nodus Tech\</strong>\<br>    \<strong>West First Street\</strong>\<br>    \<strong>-\</strong>\<br>     \<strong>ClaremontCAClaremont, CA 91711\</strong>    \</div>    
\<table style=\"margin-top:20px; float:right\">
   \<tbody>
      \<tr>
         \<td style=\"width:100px;\"> \<strong>Invoice\</strong>\</td>
         \<td style=\"width:170px;\"> \<strong>STDINV2006\</strong>\</td>
      \</tr>
      \<tr>
         \<td> \<strong>Date\</strong>\</td>
         \<td> \<strong>1/5/2016\</strong>\</td>
      \</tr>
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \</div>
\<div style=\"width: 270px;margin-top:20px; float:left\">    \<strong>Bill To:\</strong>    \<br>    
\<div class=\"divBorder p5\">PRIMARY\<br>P.O. Box 2734\<br>\<br>Green BayWI54305-5303\<br>\</div>
\</div>      \<div style=\"width: 270px;margin-top:20px; float:right\">     \<strong>Ship To\</strong>    \<br>    
\<div class=\"divBorder p5\">\<br>\<br>\<br>\<br>\</div>
\</div>    
\<div style=\"clear:both;\">    \</div>
\<br>   \<!--@ @--> 
\<table style=\"width:100%\">
   \<tbody>
      \<tr>
         \<th>Purchase Order No.\</th>
         \<th>Customer ID\</th>
         \<th>Salesperson ID\</th>
         \<th>Shipping Method\</th>
         \<th>Payment Terms\</th>
         \<th>Req Ship Date\</th>
      \</tr>
   \</tbody>
\</table>
\<!--@ @-->   \<div style=\"width: 270px;margin-top:20px; float:left\">     \<strong>Comments:\</strong>    \<br>    \<div class=\"divBorder\" style=\"height: 80px;padding: 2px;\">         \</div>    \</div>    
\<table style=\"float:right\">
   \<tbody>
      \<tr>
         \<td style=\"width:134px;border-top-width:0;\">\<strong>Sub Total:\</strong>\</td>
         \<td style=\"width:180px;border-top-width:0;\" class=\"money\">$399.75\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Miscellaneous:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Tax:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Freight:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Trade Discount:\</strong>\</td>
         \<td class=\"money\">$0.00\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Total:\</strong>\</td>
         \<td class=\"money\">$399.75\</td>
      \</tr>
      \<tr>
         \<td>\<strong>Amount Due:\</strong>\</td>
         \<td class=\"money\">$8.00\</td>
      \</tr>
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \<b> Associated Payment(s):&nbsp;\</b>    \<br>   \</div>
\<div style=\"clear:both;\">    \<br>   \</div>
\<table width=\"100%\">
   \<tbody>
      \<tr>
         \<th>PAYMENT NUMBER\</th>
         \<th class=\"money\">AMOUNT APPLIED\</th>
         \<th>DATE\</th>
         \<th>STATUS\</th>
      \</tr>
      \<!--@@-->     
   \</tbody>
\</table>
\<div style=\"clear:both;\">    \<br>   \</div>
"
</pre>


Retrieve outstanding invoices by paging query parameters
--------------------

* `GET /invoices/outstanding` will get all outstanding invoice on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/outstanding?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 2,
    "Result": [
        {
            "InvoiceGuid": "3c964e18-1851-4ec2-baee-6711cdd293e8",
            "InvoiceId": "SLS1002",
            "PONumber": "4567",
            "PostingDate": "2013-12-04T00:00:00",
            "DueOn": "2014-01-03T00:00:00",
            "Amount": 8690.09,
            "BalanceDue": 86,
            "Status": "PastDue",
            "DocumentType": "Invoice",
            "InvoiceType": "SERVICE & REPAIR",
            "Currency": {
                "Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": false
            },
            "CustomerName": "Nodus Technologies",
            "CustomerId": "Nodus0001",
            "ParentCustomerName": null,
            "ParentCustomerId": "Nodus0001",
            "Identity": "",
            "ExtensionData": "",
            "BatchNumber": "BEG BAL",
            "DiscountDate": null,
            "DiscountAmount": 0,
            "RowVersion": "AAAAAAAAB/U="
        },
        {
            "InvoiceGuid": "ab56b644-8b34-4e81-8358-62e0547fb16e",
            "InvoiceId": "INV1024",
            "PONumber": "4567",
            "PostingDate": "2014-02-10T00:00:00",
            "DueOn": "2014-03-12T00:00:00",
            "Amount": 128.35,
            "BalanceDue": 45,
            "Status": "PastDue",
            "DocumentType": "Invoice",
            "InvoiceType": "STDINV",
            "Currency": {
                "Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": false
            },
            "CustomerName": "Nodus Technologies",
            "CustomerId": "Nodus0001",
            "ParentCustomerName": null,
            "ParentCustomerId": "Nodus0001",
            "Identity": "",
            "ExtensionData": "<ExtData><Ext_USERDEF1></Ext_USERDEF1><Ext_USERDEF2></Ext_USERDEF2><Ext_USRDEF03></Ext_USRDEF03><Ext_USRDEF04></Ext_USRDEF04><Ext_USRDEF05></Ext_USRDEF05><Ext_USRDAT01>1/1/1900</Ext_USRDAT01><Ext_USRDAT02>1/1/1900</Ext_USRDAT02><Ext_USRTAB01></Ext_USRTAB01><Ext_USRTAB09></Ext_USRTAB09><Ext_USRTAB03></Ext_USRTAB03></ExtData>",
            "BatchNumber": "INV & PAYMENT",
            "DiscountDate": null,
            "DiscountAmount": 0,
            "RowVersion": "AAAAAAAAB/Q="
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse).


View Outstanding Invoices All Selected
--------------------

* `GET /invoices/outstanding/allselected` will get all outstanding invoice on the PayFabric Receivables website based on the JSON request payload.

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/outstanding/allselected?filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
<pre>
[
    {
        "Guid": "3c964e18-1851-4ec2-baee-6711cdd293e8",
        "InvoiceId": "SLS1002",
        "PayAmount": 86
    },
    {
        "Guid": "ab56b644-8b34-4e81-8358-62e0547fb16e",
        "InvoiceId": "INV1024",
        "PayAmount": 45
    }
]
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/InvoiceAllSelected.md).


Export Outstanding Invoices
--------------------

* `GET /invoices/outstanding/export` will get all outstanding invoice on the PayFabric Receivables website based on the JSON request payload.

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/outstanding/export?filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
This will return a CSV file with the historical documents


View Paid Invoices
--------------------

* `GET /invoices/paid` will get all outstanding invoice on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/paid?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "InvoiceGuid": "21e116b2-cdba-4522-972c-6be798b0df84",
            "InvoiceId": "ORDST1026",
            "PONumber": "4567",
            "PostingDate": "2015-05-08T00:00:00",
            "DueOn": "2015-05-08T00:00:00",
            "Amount": 5873.79,
            "BalanceDue": 0,
            "Status": "Paid",
            "DocumentType": "Invoice",
            "InvoiceType": "STDINV",
            "Currency": {
                "Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": false
            },
            "CustomerName": "Aaron Fitz Electrical",
            "CustomerId": "AARONFIT0001",
            "ParentCustomerName": null,
            "ParentCustomerId": "AARONFIT0001",
            "Identity": "",
            "ExtensionData": "<ExtData/>",
            "BatchNumber": "MAYORD",
            "DiscountDate": null,
            "DiscountAmount": 0,
            "RowVersion": "AAAAAAAAB/Q="
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse).

View Past Due Invoices
--------------------

* `GET /invoices/pastdue` will get all outstanding invoice on the PayFabric Receivables website based on the JSON request payload.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| PageSize | Number of results to return in a single page |
| PageIndex | Page number of results |

Criteria Options
-------

This request accepts the below query string parameters to add additional options to search via the criteria filtering. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description | Type |
| :------------- | :------------- | :------------- | 
| Amount | Amount of the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| BalanceDue | Balance remaining on the invoices | [Number Range Filter](../QueryFilter.md#number-range-filter) |
| CurrencyCode | Payment currency code | [String](../QueryFilter.md#string) |
| DueOn | Search by the due on date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| FeeDebitMemoEnabled | Search by if the invoice has a fee | [Boolean](../QueryFilter.md#boolean) |
| FeeDebitMemoPrefix | Search by the fee pre fix | [String](../QueryFilter.md#string) |
| InvoiceId | Invoice number | [String Filter](../QueryFilter.md#string-filter) |
| IsParentAccount | Search by if it is a parent account | [Boolean](../QueryFilter.md#boolean) |
| ParentCustomerId | Parent customer number | [String](../QueryFilter.md#string) |
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
<pre>
	GET /invoices/pastdue?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV
</pre>

###### Response
<pre>
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "InvoiceGuid": "3c964e18-1851-4ec2-baee-6711cdd293e8",
            "InvoiceId": "SLS1002",
            "PONumber": "4567",
            "PostingDate": "2013-12-04T00:00:00",
            "DueOn": "2014-01-03T00:00:00",
            "Amount": 8690.09,
            "BalanceDue": 86,
            "Status": "PastDue",
            "DocumentType": "Invoice",
            "InvoiceType": "SERVICE & REPAIR",
            "Currency": {
                "Name": "USD",
                "CurrencyCode": "Z-US$",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": false
            },
            "CustomerName": "Aaron Fitz Electrical",
            "CustomerId": "AARONFIT0001",
            "ParentCustomerName": null,
            "ParentCustomerId": "AARONFIT0001",
            "Identity": "",
            "ExtensionData": "",
            "BatchNumber": "BEG BAL",
            "DiscountDate": null,
            "DiscountAmount": 0,
            "RowVersion": "AAAAAAAAB/Q="
        }
    ]
}
</pre>

For more information and descriptions on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse).
