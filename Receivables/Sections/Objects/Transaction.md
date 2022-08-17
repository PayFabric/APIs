## Transaction
This Transaction object represents a transaction in the PayFabric Receivables website. Usually, this is associated to a payment.

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| Address1 | String | Billing Address line 1 | 200 |
| Address2 | String | Billing Address line 2 | 200 |
| CardType | String | Credit card type | 50 |
| CCExpDate | DateTime | Credit card expiration date |  |
| CCIssueNumber | String | Credit card issue number | 2 |
| CCName | String | Credit card holder name | 200 |
| CCNumber | String | Credit card number | 25 |
| CCStartDate | DateTime | Credit card start date |  |
| CCType | String | Credit card type | 25 |
| City | String | Billing address city | 100 |
| ConnectorSetupID | String | SetupID used to process | 50 |
| ConnectorSetupIDGuid | Guid | SetupID Guid used to process |  |
| Country | String | Billing address country | 100 |
| CreatedOn | DateTime | Created on date |  |
| Currency | String | Currency code | 10 |
| CustomerId | String | Customer ID specified by the client | 50 |
| DocumentId | String | Document ID of the transaction | 25 |
| DocumentType | int | Document type | 20 |
| ECAbaNumber | String | ECheck ABA number | 50 |
| ECAccountNumber | String | ECheck account number | 50 |
| ECCheckNumber | String | ECheck check number | 10 |
| ECType | int | ECheck type |  |
| Name | String | Customer name | 200 |
| State | String | Billing address state | 100 |
| Status | String | Status of the transaction. Valid options are ``None``, ``Approved``, ``Denied``, ``MoreInfo``, ``Failure``, ``AVSFailure``, and ``Queued`` | 4000 |
| SurchargeAmount | Decimal | Surcharge amount | 19, 5 |
| SurchargePercentage | Decimal | Surcharge percentage | 19, 5 |
| TenderType | String | Payment method used with the transaction. Valid options are ``Unknown``, ``CreditCard``, and ``ECheck`` | 4000 |
| TransactionKey | String | Transaction key identifier | 100 |
| TrxAmount | Decimal | Transaction amount | 19, 2 |
| TrxAuthCode | String | Transaction auth code returned from the gateway | 255 |
| TrxAVSAddressResponse | String | Transaction AVS address response returned from the gateway | 10 |
| TrxAVSZipResponse | String | Transaction AVS zip response returned from the gateway | 100 |
| TrxCVV2Response | String | Transaction CVV2 response returned from the gateway | 100 |
| TrxOriginationID | String | Transaction origination ID returned from the gateway | 150 |
| TrxResponseMessage | String | Transaction response message returned from the gateway | 4000 |
| TrxResultCode | String | Transaction result code returned from the gateway | 50 |
| TrxType | String | Transaction type. Valid options are ``None``, ``Sale``, ``Book``, ``PreAuth``, ``Force``, ``Void``, ``Credit``, ``Ship``, ``TokenCreate``, ``TokenUpdate``, and ``TokenDelete`` | 100 |
| Zip | String | Billing address zip | 20 |
