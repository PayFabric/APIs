## Transaction
This Transaction object represents a transaction in the PayFabric Receivables website. Usually, this is associated to a payment.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Address1 | String | Billing Address line 1 | nvarchar(200) |
| Address2 | String | Billing Address line 2 | nvarchar(200) |
| CCExpDate | DateTime | Credit card expiration date | datetime |
| CCIssueNumber | String | Credit card issue number | nvarchar(2) |
| CCName | String | Credit card holder name | nvarchar(200) |
| CCNumber | String | Credit card number | nvarchar(25) |
| CCStartDate | DateTime | Credit card start date | datetime |
| CCType | String | Credit card type | nvarchar(25) |
| City | String | Billing address city | nvarchar(100) |
| ConnectorSetupID | String | SetupID used to process | nvarchar(50) |
| ConnectorSetupIDGuid | Guid | SetupID Guid used to process | uniqueidentifier |
| Country | String | Billing address country | nvarchar(100) |
| CreatedOn | DateTime | Created on date | datetime |
| Currency | String | Currency code | nvarchar(10) |
| CustomerId | String | Customer ID specified by the client | nvarchar(50) |
| DocumentId | String | Document ID of the transaction | nvarchar(25) |
| DocumentType | int | Document type | nvarchar(20) |
| ECAbaNumber | String | ECheck ABA number | nvarchar(50) |
| ECAccountNumber | String | ECheck account number | nvarchar(50) |
| ECCheckNumber | String | ECheck check number | nvarchar(10) |
| ECType | int | ECheck type | int |
| Name | String | Customer name | nvarchar(200) |
| State | String | Billing address state | nvarchar(100) |
| Status | String | Status of the transaction. Valid options are ``None``, ``Approved``, ``Denied``, ``MoreInfo``, ``Failure``, ``AVSFailure``, and ``Queued`` | nvarchar(max) |
| TenderType | String | Payment method used with the transaction. Valid options are ``Unknown``, ``CreditCard``, and ``ECheck`` | nvarchar(max) |
| TransactionKey | String | Transaction key identifier | nvarchar(100) |
| TrxAmount | Decimal | Transaction amount | decimal(19,2) |
| TrxAuthCode | String | Transaction auth code returned from the gateway | nvarchar(255) |
| TrxAVSAddressResponse | String | Transaction AVS address response returned from the gateway | nvarchar(10) |
| TrxAVSZipResponse | String | Transaction AVS zip response returned from the gateway | nvarchar(100) |
| TrxCVV2Response | String | Transaction CVV2 response returned from the gateway | nvarchar(100) |
| TrxOriginationID | String | Transaction origination ID returned from the gateway | nvarchar(150) |
| TrxResponseMessage | String | Transaction response message returned from the gateway | nvarchar(4000) |
| TrxResultCode | String | Transaction result code returned from the gateway | nvarchar(50) |
| TrxType | String | Transaction type. Valid options are ``None``, ``Sale``, ``Book``, ``PreAuth``, ``Force``, ``Void``, ``Credit``, ``Ship``, ``TokenCreate``, ``TokenUpdate``, and ``TokenDelete`` | varchar(100) |
| Zip | String | Billing address zip | nvarchar(20) |
