# README
Mark complete when you have implementation and sample.

Transactions: 
- [x] Create
- [ ] Update
- [ ] Get
- [ ] Cancel
- [ ] Refund
- [ ] Capture a Pre-Authorized Transcation
- [ ] Submit to Payment Gateway
- [ ] Create and Submit

Customers:
- [x] Add Card // credit card yes. echeck no.
- [x] Update Card
- [x] Remove Card // credit card and echeck
- [x] Get All Cards // credit card and echeck
- [x] Get All Shipping Addresses 
- [x] Get Shipping Address By ID

Gateways: 
- [x] Get All Payment Gateways
- [x] Get Payment Gateway By ID

## Exceptions
invalidTenderTypeException - the provided tender type is not valid. valid options are "CreditCard"
and "ECheck". These are defined in Constants.php as TENDER_TYPE_CREDIT_CARD and TENDER_TYPE_ECHECK.


