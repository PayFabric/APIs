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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/outstanding/currencies?filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Currency.md#CurrencyResponse)
```json
[
	{
        "CCSetupId": "PFP",
        "ECSetupId": "PFP_ECheck",
        "IsUsingECheck": true,
        "IsUsingCreditCard": true,
        "IsValid": true,
        "SurchargePercentage": null,
        "CurrencyGuid": "8f2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
        "Name": "USD",
        "CurrencyCode": "USD",
        "Symbol": "$",
        "LongName": "US Dollars",
        "IsFuncCurrency": true
    }
]
```


Retrieve invoice html to be displayed by identity
--------------------

* `GET /invoices/display?invoiceId={InvoiceId}` will get the invoice html associated to the InvoiceId on the PayFabric Receivables website based on the JSON request payload.

###### Request
```http
GET /invoices/display?invoiceId=STDINV2006 HTTP/1.1
```

###### Response
```html
"<style>
	 .content {
		 background-color: white;
		 Font-Family: 'Segoe UI';
		 padding: 30px;
		 color: rgb(85, 85, 85);
		 font-size: 13px
	}

	 .content hr {
		 border: 0.5px solid rgb(238, 238, 239)
	}

	 .content .hr {
		 margin: 5px 0
	}

	 .content table {
		 border-collapse: collapse;
		 padding: 0
	}

	 .content .flex-space-between {
		 display: flex;
		 justify-content: space-between
	}

	 .content .header-font {
		 color: rgb(85, 85, 85);
		 font-size: 13px;
		 font-weight: bold
	}

	 .content .h5-font {
		 font-size: 14px;
		 color: rgb(85, 85, 85)
	}

	 .content .content-font {
		 color: rgb(85, 85, 85);
		 font-size: 14px
	}

	 .content .text-right {
		 text-align: right
	}

	 .content .text-center {
		 text-align: center
	}

	 .content .title {
		 margin-bottom: 15px
	}

	 .content .company-info img {
		 max-height: 50px;
		 max-width: 250px
	}

	 .content .invoice-info table tr td {
		 padding: 5px 10px;
		 min-width: 125px;
		 line-height: 18px
	}

	 .content .invoice-info table .due-date {
		 color: rgb(19, 105, 156)
	}

	 .content .invoice-info table tr:last-child {
		 background: rgb(19, 105, 156);
		 color: white
	}

	 .content .invoice-info table tr td:last-child {
		 text-align: right
	}

	 .content .address {
		 margin-top: 10px;
		 margin-bottom: 20px
	}

	 .content .customer-info table tr td {
		 padding: 0 20px;
		 height: 50px;
		 min-width: 250px;
		 background-color: rgb(240, 248, 254);
		 border-bottom: 2px solid white
	}

	 .content .nodus-table {
		 width: 100%;
		 margin-bottom: 10px
	}

	 .content .nodus-table tr th {
		 background: rgb(238, 238, 239);
		 border-bottom: 1px solid #ddd;
		 padding: 0 10px;
		 height: 37px;
		 color: rgb(85, 85, 85);
		 font-size: 13px;
		 border-right: 1px solid white
	}

	 .content .nodus-table tr td {
		 padding: 0 10px;
		 height: 37px;
		 color: rgb(85, 85, 85);
		 font-size: 13px
	}

	 .content .nodus-table tr:nth-child(2n) td {
		 background-color: rgb(252, 252, 252)
	}

	 .content .nodus-table tr:nth-child(2n+1) td {
		 background-color: rgb(250, 250, 250)
	}

	 .content .comments {
		 margin-top: 50px
	}

	 .content .comments-box {
		 margin-top: 5px;
		 border: 1px solid rgb(238, 238, 239);
		 height: 100px;
		 min-width: 350px;
		 word-break: break-word;
		
	}

	 .content .sub-total table {
		 width: 100%;
		 margin-bottom: 10px;
		 font-size: 13px
	}

	 .content .sub-total table tr td {
		 height: 37px;
		 padding: 0 10px
	}

	 .content .sub-total table .bottom {
		 font-size: 20px;
		 font-weight: bold;
		 color: rgb(19, 105, 156)
	}

	 .content .payment {
		 margin-top: 15px
	}

	 .content .payment span {
		 margin-top: 30px
	}

	 .content .payment .nodus-table {
		 margin-top: 20px
	}
</style>
<div class="content"> 
	<div class="title flex-space-between"> 
		<div class="company-info "> 
			<img src='' >
			<br> Nodus Tech 
			<br> West First Street 
			<br> - <br> Claremont CA Claremont, CA 91711 
		</div> 
		<div class="invoice-info"> 
			<table class="header-font"> 
				<tbody> 
					<tr> 
						<td>Invoice # </td>
						<td>STDINV2006</td> 
                    </tr> 
                    <tr> 
                        <td>Invoice Date </td> 
                        <td>1/4/2016</td>
					</tr> 
					<tr class="due-date"> 
						<td>Due Date </td> 
						<td>2/3/2030</td>
					</tr> 
					<tr> 
						<td>Amount Due </td> 
						<td>$8.00</td> 
					</tr> 
				</tbody> 
			</table>
		</div> 
	</div>
	<!--@ @-->
	<hr> 
	<div class="address flex-space-between"> 
		<div class="bill-addresss"> 
			<h5 class="h5-font">Bill To</h5>
			<span class=""> Jia Zhou
				<br> P.O. Box 2734
				<br> Green Bay , WI 54305-5303
				<br> USA
				<br> 
			</span>
		</div> 
		<div class="ship-addresss"> 
			<h5 class="h5-font">Ship To</h5> 
			<br> 
			<br>  ,
			<br>         
		</div> 
		<div class="customer-info"> 
			<table> 
				<tbody> 
					<tr> 
						<td>
							<span class="header-font">Purchase Order No.</span> <br>
							<span class="content-font">PO </span> 
						</td> 
					</tr> 
					<tr> 
						<td>
							<span class="header-font">Customer ID</span> <br>
							<span class="content-font">Nodus0001</span> 
						</td> 
					</tr> 
				</tbody>
			</table> 
		</div> 
	</div> 
	<table class="nodus-table"> 
		<tbody> 
			<tr> 
				<th>Item Code</th> 
				<th>Description</th> 
				<th>Unit Price</th> 
				<th>Quantity</th> 
				<th>Markdown</th> 
				<th>Tax Amount</th> 
				<th>Extended Price</th> 
			</tr> 
		</tbody>
	</table>
	<!--@ @--> 
	<div class="invoice-total flex-space-between"> 
		<div class="comments">
			<span>Comments</span> 
			<div class="comments-box"> 
				<br>
				<br>
				<br>
			</div> 
		</div> 
		<div class="sub-total"> 
			<table> 
				<tbody> 
					<tr class="text-right"> 
						<td>Sub Total</td> 
						<td>$399.75</td> 
					</tr> 
					<tr class="text-right"> 
						<td>Miscellaneous</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Tax</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Freight</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right"> 
						<td>Trade Discount</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Total</td> 
						<td>$399.75</td> 
					</tr> 
					<tr class="bottom text-right"> 
						<td>Amount Due</td> 
						<td>$8.00</td> 
					</tr> 
				</tbody>
			</table> 
		</div> 
	</div>
	<!--@  @--> 
	<div class="payment">
	<!--@  @--> 
	</div>
</div>"
```


Retrieve invoice html to be displayed by invoiceGuid
--------------------

* `GET /invoices/display/{InvoiceGuid}` will get the invoice html associated to the InvoiceGuid on the PayFabric Receivables website based on the JSON request payload.

###### Request
```http
GET /invoices/display/12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
```html
"<style>
	 .content {
		 background-color: white;
		 Font-Family: 'Segoe UI';
		 padding: 30px;
		 color: rgb(85, 85, 85);
		 font-size: 13px
	}

	 .content hr {
		 border: 0.5px solid rgb(238, 238, 239)
	}

	 .content .hr {
		 margin: 5px 0
	}

	 .content table {
		 border-collapse: collapse;
		 padding: 0
	}

	 .content .flex-space-between {
		 display: flex;
		 justify-content: space-between
	}

	 .content .header-font {
		 color: rgb(85, 85, 85);
		 font-size: 13px;
		 font-weight: bold
	}

	 .content .h5-font {
		 font-size: 14px;
		 color: rgb(85, 85, 85)
	}

	 .content .content-font {
		 color: rgb(85, 85, 85);
		 font-size: 14px
	}

	 .content .text-right {
		 text-align: right
	}

	 .content .text-center {
		 text-align: center
	}

	 .content .title {
		 margin-bottom: 15px
	}

	 .content .company-info img {
		 max-height: 50px;
		 max-width: 250px
	}

	 .content .invoice-info table tr td {
		 padding: 5px 10px;
		 min-width: 125px;
		 line-height: 18px
	}

	 .content .invoice-info table .due-date {
		 color: rgb(19, 105, 156)
	}

	 .content .invoice-info table tr:last-child {
		 background: rgb(19, 105, 156);
		 color: white
	}

	 .content .invoice-info table tr td:last-child {
		 text-align: right
	}

	 .content .address {
		 margin-top: 10px;
		 margin-bottom: 20px
	}

	 .content .customer-info table tr td {
		 padding: 0 20px;
		 height: 50px;
		 min-width: 250px;
		 background-color: rgb(240, 248, 254);
		 border-bottom: 2px solid white
	}

	 .content .nodus-table {
		 width: 100%;
		 margin-bottom: 10px
	}

	 .content .nodus-table tr th {
		 background: rgb(238, 238, 239);
		 border-bottom: 1px solid #ddd;
		 padding: 0 10px;
		 height: 37px;
		 color: rgb(85, 85, 85);
		 font-size: 13px;
		 border-right: 1px solid white
	}

	 .content .nodus-table tr td {
		 padding: 0 10px;
		 height: 37px;
		 color: rgb(85, 85, 85);
		 font-size: 13px
	}

	 .content .nodus-table tr:nth-child(2n) td {
		 background-color: rgb(252, 252, 252)
	}

	 .content .nodus-table tr:nth-child(2n+1) td {
		 background-color: rgb(250, 250, 250)
	}

	 .content .comments {
		 margin-top: 50px
	}

	 .content .comments-box {
		 margin-top: 5px;
		 border: 1px solid rgb(238, 238, 239);
		 height: 100px;
		 min-width: 350px;
		 word-break: break-word;
		
	}

	 .content .sub-total table {
		 width: 100%;
		 margin-bottom: 10px;
		 font-size: 13px
	}

	 .content .sub-total table tr td {
		 height: 37px;
		 padding: 0 10px
	}

	 .content .sub-total table .bottom {
		 font-size: 20px;
		 font-weight: bold;
		 color: rgb(19, 105, 156)
	}

	 .content .payment {
		 margin-top: 15px
	}

	 .content .payment span {
		 margin-top: 30px
	}

	 .content .payment .nodus-table {
		 margin-top: 20px
	}
</style>
<div class="content"> 
	<div class="title flex-space-between"> 
		<div class="company-info "> 
			<img src='' >
			<br> Nodus Tech 
			<br> West First Street 
			<br> - <br> Claremont CA Claremont, CA 91711 
		</div> 
		<div class="invoice-info"> 
			<table class="header-font"> 
				<tbody> 
					<tr> 
						<td>Invoice # </td>
						<td>STDINV2006</td> 
                    </tr> 
                    <tr> 
                        <td>Invoice Date </td> 
                        <td>1/4/2016</td>
					</tr> 
					<tr class="due-date"> 
						<td>Due Date </td> 
						<td>2/3/2030</td>
					</tr> 
					<tr> 
						<td>Amount Due </td> 
						<td>$8.00</td> 
					</tr> 
				</tbody> 
			</table>
		</div> 
	</div>
	<!--@ @-->
	<hr> 
	<div class="address flex-space-between"> 
		<div class="bill-addresss"> 
			<h5 class="h5-font">Bill To</h5>
			<span class=""> Jia Zhou
				<br> P.O. Box 2734
				<br> Green Bay , WI 54305-5303
				<br> USA
				<br> 
			</span>
		</div> 
		<div class="ship-addresss"> 
			<h5 class="h5-font">Ship To</h5> 
			<br> 
			<br>  ,
			<br>         
		</div> 
		<div class="customer-info"> 
			<table> 
				<tbody> 
					<tr> 
						<td>
							<span class="header-font">Purchase Order No.</span> <br>
							<span class="content-font">PO </span> 
						</td> 
					</tr> 
					<tr> 
						<td>
							<span class="header-font">Customer ID</span> <br>
							<span class="content-font">Nodus0001</span> 
						</td> 
					</tr> 
				</tbody>
			</table> 
		</div> 
	</div> 
	<table class="nodus-table"> 
		<tbody> 
			<tr> 
				<th>Item Code</th> 
				<th>Description</th> 
				<th>Unit Price</th> 
				<th>Quantity</th> 
				<th>Markdown</th> 
				<th>Tax Amount</th> 
				<th>Extended Price</th> 
			</tr> 
		</tbody>
	</table>
	<!--@ @--> 
	<div class="invoice-total flex-space-between"> 
		<div class="comments">
			<span>Comments</span> 
			<div class="comments-box"> 
				<br>
				<br>
				<br>
			</div> 
		</div> 
		<div class="sub-total"> 
			<table> 
				<tbody> 
					<tr class="text-right"> 
						<td>Sub Total</td> 
						<td>$399.75</td> 
					</tr> 
					<tr class="text-right"> 
						<td>Miscellaneous</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Tax</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Freight</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right"> 
						<td>Trade Discount</td> 
						<td>$0.00</td> 
					</tr> 
					<tr class="text-right">
						<td>Total</td> 
						<td>$399.75</td> 
					</tr> 
					<tr class="bottom text-right"> 
						<td>Amount Due</td> 
						<td>$8.00</td> 
					</tr> 
				</tbody>
			</table> 
		</div> 
	</div>
	<!--@  @--> 
	<div class="payment">
	<!--@  @--> 
	</div>
</div>"
```


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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/outstanding?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
For more information on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "InvoiceGuid": "62f5d01c-92cc-ec11-a36a-b0c09018d6d4",
            "DueOn": "2014-03-12T00:00:00.0000000Z",
            "InvoiceStatus": "Outstanding",
            "CustomerName": "Nodus Technologies",
            "CustomerGuid": "9e2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
            "ParentCustomerName": null,
            "ParentCustomerId": "",
            "DiscountDate": "1900-01-01T00:00:00.0000000",
            "DiscountAmount": 0.0,
            "RowVersion": "AAAAAAAAhNE=",
            "Currency": {
                "CurrencyGuid": "8f2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
                "Name": "USD",
                "CurrencyCode": "USD",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": true
            },
            "Amount": 128.35,
            "BalanceDue": 45.0,
            "BatchNumber": "INV & PAYMENT",
            "CustomerId": "Nodus0001",
            "DueDate": "2014-03-12T00:00:00.0000000Z",
            "ExtensionData": null,
            "Identity": "STDINV1024",
            "InvoiceId": "STDINV1024",
            "PostingDate": "2014-02-10T00:00:00.0000000Z",
            "InvoiceType": "STDINV",
            "DocumentType": "Invoice",
            "PONumber": "4567",
            "Email": "",
            "CopyEmail": []
        }
    ]
}
```


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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/outstanding/allselected?filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
For more information and descriptions on response fields please see our [object reference](../../Objects/InvoiceAllSelected.md)
```json
[
    {
        "Guid": "3c964e18-1851-4ec2-baee-6711cdd293e8",
        "InvoiceId": "SLS1002",
        "PayAmount": 86,
		"Identity": "SLS1002"
    },
    {
        "Guid": "ab56b644-8b34-4e81-8358-62e0547fb16e",
        "InvoiceId": "INV1024",
        "PayAmount": 45,
		"Identity": "INV1024"
    }
]
```


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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/outstanding/export?filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
This will return a CSV file with the related invoices


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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/paid?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
For more information and descriptions on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "InvoiceGuid": "62f5d01c-92cc-ec11-a36a-b0c09018d6d4",
            "DueOn": "2014-03-12T00:00:00.0000000Z",
            "InvoiceStatus": "Paid",
            "CustomerName": "Nodus Technologies",
            "CustomerGuid": "9e2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
            "ParentCustomerName": null,
            "ParentCustomerId": "",
            "DiscountDate": "1900-01-01T00:00:00.0000000",
            "DiscountAmount": 0.0,
            "RowVersion": "AAAAAAAAhNE=",
            "Currency": {
                "CurrencyGuid": "8f2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
                "Name": "USD",
                "CurrencyCode": "USD",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": true
            },
            "Amount": 128.35,
            "BalanceDue": 0.0,
            "BatchNumber": "INV & PAYMENT",
            "CustomerId": "Nodus0001",
            "DueDate": "2014-03-12T00:00:00.0000000Z",
            "ExtensionData": null,
            "Identity": "STDINV1024",
            "InvoiceId": "STDINV1024",
            "PostingDate": "2014-02-10T00:00:00.0000000Z",
            "InvoiceType": "STDINV",
            "DocumentType": "Invoice",
            "PONumber": "4567",
            "Email": "",
            "CopyEmail": []
        }
    ]
}
```


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
| PONumber | Purchase order number | [String Filter](../QueryFilter.md#string-filter) |
| PostingDate | Search by the posting date within a specified interval | [Date Range Filter](../QueryFilter.md#date-range-filter) |
| RBPFeeDebitMemoEnabled | Search by if the the invoice has a fee for AutoPay | [Boolean](../QueryFilter.md#boolean) |
| RBPFeeDebitMemoPrefix | Search by the fee pre fix for AutoPay | [String](../QueryFilter.md#string) |

###### Request
```http
GET /invoices/pastdue?filter.pageSize=10&filter.pageIndex=0&filter.criteria.invoiceId.contains=STDINV HTTP/1.1
```

###### Response
For more information and descriptions on response fields please see our [object reference](../../Objects/Invoice.md#InvoicePagingResponse)
```json
{
    "Index": 0,
    "Total": 1,
    "Result": [
        {
            "InvoiceGuid": "62f5d01c-92cc-ec11-a36a-b0c09018d6d4",
            "DueOn": "2014-03-12T00:00:00.0000000Z",
            "InvoiceStatus": "Outstanding",
            "CustomerName": "Nodus Technologies",
            "CustomerGuid": "9e2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
            "ParentCustomerName": null,
            "ParentCustomerId": "",
            "DiscountDate": "1900-01-01T00:00:00.0000000",
            "DiscountAmount": 0.0,
            "RowVersion": "AAAAAAAAhNE=",
            "Currency": {
                "CurrencyGuid": "8f2f9b0e-92cc-ec11-a36a-b0c09018d6d4",
                "Name": "USD",
                "CurrencyCode": "USD",
                "Symbol": "$",
                "LongName": "US Dollars",
                "IsFuncCurrency": true
            },
            "Amount": 128.35,
            "BalanceDue": 45.0,
            "BatchNumber": "INV & PAYMENT",
            "CustomerId": "Nodus0001",
            "DueDate": "2014-03-12T00:00:00.0000000Z",
            "ExtensionData": null,
            "Identity": "STDINV1024",
            "InvoiceId": "STDINV1024",
            "PostingDate": "2014-02-10T00:00:00.0000000Z",
            "InvoiceType": "STDINV",
            "DocumentType": "Invoice",
            "PONumber": "4567",
            "Email": "",
            "CopyEmail": []
        }
    ]
}
```


Retrieve invoice attachmentId by identity
--------------------

* `GET /invoices/attachmentId?invoiceId={InvoiceId}` will get the invoice attachmentId associated to the InvoiceId on the PayFabric Receivables website.

###### Request
```http
GET /invoices/attachmentId?invoiceId=STDINV2006 HTTP/1.1
```

###### Response
```text
4045734381292355584
```


Retrieve invoice attachmentId by invoiceGuid
--------------------

* `GET /invoices/attachmentId/{invoiceGuid}` will get the invoice attachmentId associated to the InvoiceGuid on the PayFabric Receivables website.

###### Request
```http
GET /invoices/attachmentId/12345678-0000-0000-0000-000000000000 HTTP/1.1
```

###### Response
```text
4045734381292355584
```


Download invoice attachment by identity
--------------------

* `GET /invoices/file/download?invoiceId={InvoiceId}` will download the invoice attachmentId associated to the InvoiceId on the PayFabric Receivables website.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| IsIframe | Indicates if this request is embedded in an iFrame |

###### Request
```http
GET /invoices/file/download?invoiceId=STDINV2006 HTTP/1.1
```

###### Response
This will return the related PDF attachment


Download invoice attachment by invoiceGuid
--------------------

* `GET /invoices/{invoiceGuid}/file/download` will download the invoice attachmentId associated to the InvoiceId on the PayFabric Receivables website.

Options
-------

This request accepts the below query string parameters to add additional options to search. You can add them to your request URL by adding a '?' before the first parameter and connecting additional ones with a '&'.

| QueryString | Description |
| :------------- | :------------- |
| IsIframe | Indicates if this request is embedded in an iFrame |

###### Request
```http
GET /invoices/12345678-0000-0000-0000-000000000000/file/download HTTP/1.1
```

###### Response
This will return the related PDF attachment