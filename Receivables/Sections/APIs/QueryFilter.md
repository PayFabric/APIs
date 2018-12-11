Query Filter
============

PayFabric Receivables allows for more advanced methods of getting the data that you need through the query parameters. This will show examples of how to use it. All query filters require "filter.criteria" followed by the element you would like to search for with periods.

String
--------------------
The String option is used when the parameter must be an exact match of what you are looking for.  
Example:  
``/invoices/outstanding?filter.criteria.CustomerId="Nodus0001"`` - This would give the outstanding invoices whose CustomerId is "Nodus0001"  

Boolean
--------------------
The Boolean option is used when the parameter must be either true or false.  
Example:  
``/invoices/outstanding?filter.criteria.FeeDebitMemoEnabled="true"`` - This would give the outstanding invoices whose document type is DebitMemo  

String Filter
--------------------
The String Filter option is used when the parameter can be adjusted to meet either an exact match, ``EqualsTo``, or a includes, ``Contains``, of what you are looking for.  
Examples:  
``/invoices/outstanding?filter.criteria.InvoiceId.EqualsTo="INV0001"`` - This would give the outstanding invoice that matches the InvoiceId of "INV0001"  
``/invoices/outstanding?filter.criteria.InvoiceId.Contains="INV"`` - This would give the outstanding invoices that contain an InvoiceId of "INV"  

Date Range Filter
--------------------
The Date Range Filter option is used when the parameter can be adjusted to meet the minimum, ``Min`` or maximum, ``Max`` date you are looking for.  
Examples:  
``/invoices/outstanding?filter.criteria.DueOn.Min="2018-01-01"`` - This would give the outstanding invoices that have a date greater than or equal to "2018-01-01"  
``/invoices/outstanding?filter.criteria.DueOn.Max="2018-02-01"`` - This would give the outstanding invoices that have a date less than or equal to "2018-02-01"  
``/invoices/outstanding?filter.criteria.DueOn.Min="2018-01-01"&filter.criteria.DueOn.Max="2018-02-01"`` - This would give the outstanding invoices that have a date greater than or equal to "2018-01-01" but less than or equal to "2018-02-01"  

Numeric Range Filter
--------------------
The Numeric Range Filter option is used when the parameter can be adjusted to meet the minimum, ``Min`` or maximum, ``Max`` number you are looking for.  
Examples:  
``/invoices/outstanding?filter.criteria.Amount.Min="1"`` - This would give the outstanding invoices that have a value greater than or equal to "1"  
``/invoices/outstanding?filter.criteria.Amount.Max="100"`` - This would give the outstanding invoices that have a value less than or equal to "100"  
``/invoices/outstanding?filter.criteria.Amount.Min="1"&filter.criteria.DueOn.Max="100"`` - This would give the outstanding invoices that have a value greater than or equal to "1" but less than or equal to "100"  

SortBy Filter
--------------------
The SortBy Filter option can control the way the returned list is is sorted. This is done through two options: ``Field`` and ``Direction``  
Examples:  
``/document/history?filter.criteria.SortBy.Field="Amount"`` - This will get all historical documents and sort it by the amount in ascending order
``/document/history?filter.criteria.SortBy.Field="Amount&filter.criteria.SortBy.Direction="desc"`` - This will do the same as before except change the ordering to descending