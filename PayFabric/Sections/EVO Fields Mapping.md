#EVO Fields Mapping

| EVO Field Name| PayFabric Field Name|Descriptions|
| :-------------------| :-----------------------| :-----------------------|
|TransactionData.Amount|Amount||
|TransactionData.CurrencyCode|Currency||
|TransactionData.Reference|Document.Header.CustRef||
|TransactionData.Geolocation.Latitude|Document.Header.Latitude||
|TransactionData.Geolocation.Longitude|Document.Header.Longitude||
|Capture.TransactionId|ReqOriginid||
|Return.TransactionId|ReqOriginid||
|Undo.TransactionId|ReqOriginid||
|QueryTransactionsParameters.TransactionIds|ReqOriginid||
|BankcardTransactionData.OrderNumber|Document.Header.PONumber||
|BankcardTransactionData.InvoiceNumber|Document.Header.InvoiceNumber||
|BankcardTransactionData.InternetTransactionData.IpAddress|Document.Header.ClientIP||
|BankcardTransactionData.InternetTransactionData.SessionId|Document.Header.SessionID||
|BankcardTransactionData.GoodsType|Document.Header.GoodsIndicator||
|BankcardTransactionData.CustomerPresent|Document.Header.CardHolderAttendance||
|BankcardTransactionData.EmployeeId|Document.Header.ServerID||
|BankcardTransactionData.TipAmount|Document.Header.TipAmount||
|BankcardTransactionData.FeeAmount|Document.Header.FeeAmount||
|BankcardTransactionData.TerminalId|Document.Header.TerminalId||
|BankcardTransactionData.CardholderAuthenticationEntity|Document.Header.CardHolderAuth||
|BankcardTransactionData.IsQuasiCash|Document.Header.IsQuasiCash||
|BankcardTransactionData.IsPartialShipment|Document.Header.IsPartialShipment||
|BankcardTransactionData.ApprovalCode|ReqAuthCode||
|CardData.PAN|Card.Account||
|CardData.Expire|Card.ExpDate||
|CardData.CardType|Card.CardName||
|CardData.Track1Data|Document.Header.Swipe||
|CardData.CardSequenceNumber|Card.IssueNumber||
|CardData.Track2Data|Document.Header.Swipe2||
|CardData.CardholderName|Card.CardHolder.FirstName, Card.CardHolder.MiddleName, Card.CardHolder.LastName|CardData.CardholderName = {FirstName} {MiddleName} {Last Name}|
|CardSecurityData.CVData|Card.CVC||
|TransactionCustomerData.BillingData.Name.First|Card.CardHolder.FirstName||
|TransactionCustomerData.BillingData.Name.Middle|Card.CardHolder.MiddleName||
|TransactionCustomerData.BillingData.Name.Last|Card.CardHolder.LastName||
|TransactionCustomerData.BillingData.Name.Title|Document.Header.BillToTitle||
|TransactionCustomerData.BillingData.Name.Suffix|Document.Header.BillToSuffix||
|TransactionCustomerData.BillingData.Address.Street1|Card.Address.Line1||
|TransactionCustomerData.BillingData.Address.Street2|Card.Address.Line2||
|TransactionCustomerData.BillingData.Address.City|Card.Address.City||
|TransactionCustomerData.BillingData.Address.StateProvince|Card.Address.State||
|TransactionCustomerData.BillingData.Address.PostalCode|Card.Address.Zip||
|TransactionCustomerData.BillingData.Address.CountryCode|Document.Header.BillToCountryISOA3||
|TransactionCustomerData.BillingData.Email|Card.Address.Email||
|TransactionCustomerData.BillingData.Phone|Card.Address.Phone||
|TransactionCustomerData.BillingData.Fax|Document.Header.FaxNumber||
|TransactionCustomerData.ShippingData.Address.PostalCode|Shipto.Address.Zip||
|TransactionCustomerData.ShippingData.Address.City|Shipto.Address.City||
|TransactionCustomerData.ShippingData.Name.First|Document.Header.ShipToFirstName||
|TransactionCustomerData.ShippingData.Name.Middle|Document.Header.ShipToMiddleName||
|TransactionCustomerData.ShippingData.Name.Last|Document.Header.ShipToLastName||
|TransactionCustomerData.ShippingData.Name.Title|Document.Header.ShipToTitle||
|TransactionCustomerData.ShippingData.Name.Suffix|Document.Header.ShipToSuffix||
|TransactionCustomerData.ShippingData.Address.StateProvince|Shipto.Address.State||
|TransactionCustomerData.ShippingData.Address.Street1|Shipto.Address.Line1||
|TransactionCustomerData.ShippingData.Address.Street2|Shipto.Address.Line2||
|TransactionCustomerData.ShippingData.Address.BusinessName|Document.Header.ShipToCompany|Only submit ShipToCompany value when ShipToFirstName is NOT null or empty|
|TransactionCustomerData.ShippingData.Phone|Shipto.Address.Phone||
|TransactionCustomerData.ShippingData.Email|Shipto.Address.Email||
|TransactionCustomerData.ShippingData.Fax|Document.Header.ShipToFaxNumber||
|TransactionCustomerData.ShippingData.Address.CountryCode|Document.Header.ShipToCountryISOA3||
|TransactionCustomerData.CustomerId|Customer||
|TransactionCustomerData.CustomerTaxId|Document.Header.TaxID||
|BankcardCapturePro.ShippingData.Address.City|Shipto.Address.City||
|BankcardCapturePro.ShippingData.Name.First|Document.Header.ShipToFirstName||
|BankcardCapturePro.ShippingData.Name.Middle|Document.Header.ShipToMiddleName||
|BankcardCapturePro.ShippingData.Name.Last|Document.Header.ShipToLastName||
|BankcardCapturePro.ShippingData.Name.Title|Document.Header.ShipToTitle||
|BankcardCapturePro.ShippingData.Name.Suffix|Document.Header.ShipToSuffix||
|BankcardCapturePro.ShippingData.Address.StateProvince|Shipto.Address.State||
|BankcardCapturePro.ShippingData.Address.Street1|Shipto.Address.Line1||
|BankcardCapturePro.ShippingData.Address.Street2|Shipto.Address.Line2||
|BankcardCapturePro.ShippingData.Address.CountryCode|Document.Header.ShipToCountryISOA3||
|BankcardCapturePro.ShippingData.Phone|Shipto.Address.Phone||
|BankcardCapturePro.ShippingData.Fax|Document.Header.ShipToFaxNumber||
|BankcardCapturePro.ShippingData.Email|Shipto.Address.Email||
|BankcardCapturePro.ShippingData.Address.BusinessName|Document.Header.ShipToCompany|Only submit ShipToCompany value when ShipToFirstName is NOT null or empty|
|BankcardCapturePro.MultiplePartialCapture|Document.Header.MultipleCaptureEnabled||
|BankcardCapturePro.ShipDate|Document.Header.MultipleCaptureEnabled||
|BankcardCapturePro.TipAmount|Document.Header.TipAmount||
|AlternativeMerchantData.MerchantId|Document.Header.MerchantID||
|AlternativeMerchantData.Description|Document.Header.MerchantDescriptor||
|AlternativeMerchantData.CustomerServicePhone|Document.Header.MerchantServiceNumber||
|AlternativeMerchantData.CustomerServicePhone|Document.Header.MerchantServiceNumber||
|AlternativeMerchantData.CustomerServiceInternet|Document.Header.MerchantEmail||
|AlternativeMerchantData.Address.City|Document.Header.MerchantCity||
|AlternativeMerchantData.Address.CountryCode|Document.Header.MerchantCountryCode||
|AlternativeMerchantData.Name|Document.Header.MerchantName||
|AlternativeMerchantData.Address.StateProvince|Document.Header.MerchantState||
|AlternativeMerchantData.Address.Street1|Document.Header.MerchantStreet||
|AlternativeMerchantData.Address.PostalCode|Document.Header.MerchantZip||
|AlternativeMerchantData.SIC|Document.Header.MerchantSIC||
|AlternativeMerchantData.Address.Street2|Document.Header.MerchantStreet2||
|TransactionReportingData.Description|Document.Header.DESC||
|TransactionReportingData.Reference|Document.Header.CustRef||
|TransactionReportingData.Comment|Document.Header.Comment1, Document.Header.Comment2, Document.Header.Comment3, Document.Header.Comment4, Document.Header.Comment5|TransactionReportingData.Comment = {Comment1} ~ {Comment2} ~ {Comment3} ~ {Comment4} ~ {Comment5}|

## Level 2 Fields Mapping
| EVO Field Name| PayFabric Field Name|Descriptions|
| :-------------------| :-----------------------| :-----------------------|
|Level2Data.OrderNumber*|Document.Header.PONumber||
|Level2Data.Tax.Amount*|Document.Header.TaxAmount||
|Level2Data.DutyAmount*|Document.Header.DutyAmount ||
|Level2Data.FreightAmount*|Document.Header.FreightAmount||
|Level2Data.CustomerCode*|Customer||
|Level2Data.DiscountAmount*|Document.Header.DiscountAmount||
|Level2Data.CompanyName*|Document.Header.CompanyName||
|Level2Data.TaxExempt.TaxExemptNumber*|Document.Header.TaxExemptNumber||
|Level2Data.TaxExempt.IsTaxExempt*|None|The value is decided based on tax amount|
|Level2Data.DestinationPostal|Shipto.Address.Zip||
|Level2Data.OrderDate|Document.Header.OrderDate||
|Level2Data.ShipFromPostalCode|Document.Header.ShipFromZip||
|Level2Data.ShipmentId|Document.Header.ShipRef||
|Level2Data.DestinationCountryCode|Shipto.Address.Country||
|Level2Data.MiscHandlingAmount|Document.Header.HandlingAmount||
|Level2Data.Tax.Rate|Document.Header.TaxRate||
|Level2Data.CommodityCode|Document.Header.CommodityCode||
|Level2Data.Tax.InvoiceNumber|Document.Header.InvoiceNumber|
|Level2Data.Description|Document.Header.DESC||
|Level2Data.RequesterName|Document.Header.RequesterName||

## Line Item Fields Mapping
| EVO Field Name| PayFabric Field Name|Descriptions|
| :-------------------| :-----------------------| :-----------------------|
|LineItemDetail.Quantity*|Document.Lines.Columns.ItemQuantity||
|LineItemDetail.Description*|Document.Lines.Columns.ItemDesc||
|LineItemDetail.UnitOfMeasure*|Document.Lines.Columns.ItemUOM||
|LineItemDetail.UnitPrice*|Document.Lines.Columns.ItemCost||
|LineItemDetail.ProductCode*|Document.Lines.Columns.ItemProdCode||
|LineItemDetail.Amount*|Document.Lines.Columns.ItemAmount||
|LineItemDetail.CommodityCode*|Document.Lines.Columns.ItemCommodityCode||
|LineItemDetail.UPC|Document.Lines.Columns.ItemUPC||
|LineItemDetail.DiscountAmount|Document.Lines.Columns.ItemDiscount||
|LineItemDetail.Tax.Amount|Document.Lines.Columns.ItemTaxAmount||
|LineItemDetail.Tax.Rate|Document.Lines.Columns.ItemTaxRate||
|LineItemDetail.Tax.InvoiceNumber|Document.Lines.Columns.ItemInvoiceNumber||

* required.