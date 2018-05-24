# =====================================================================
# THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
# KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
# IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
# PARTICULAR PURPOSE.
# =====================================================================

import json
import requests
from Token import Token


class Transaction:
    """ Transactions methods
    """

    def Create(self, isBookTransaction=None):
        """
            Create transaction
        :param isBookTransaction: set to True if need to create 'Book' transaction.
                                    otherwise will be created 'Sale' transaction
        :return: creation result.
        """

        transactionType = 'Book' if isBookTransaction else 'Sale'

        data = {
            'Customer': 'AARONFIT0001',
            'Currency': 'USD',
            'Amount': '4.88',
            'Type': transactionType,
            'SetupId': 'Paypal',  # Replace with your gateway account profile name
            'Shipto': {
                'Country': 'US',
                'State': 'CA',
                'City': 'ANAHEIM',
                'Line1': '2099 S State College Blvd',
                'Email': 'support@payfabric.com'
            },
        }
        # Replace with your own device id and device password
        r = requests.post(url='https://sandbox.payfabric.com/v2/rest/api/transaction/create',
                          data=json.dumps(data),
                          headers={
                              'Content-Type': 'application/json; charset=utf-8',
                              'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                          })

        print r.status_code, r.text

        return r.json()


    def Retrieve(self, transactionKey):
        """ This method call will return all transaction fields with masked account/card number

        :param transactionKey: Transaction key
        :return: retrieved transaction (JSON format)
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/v2/rest/api/transaction/' + transactionKey,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # "result" is a Transaction object with json format
        # 
        # Go to https:#github.com/PayFabric/APIs/blob/v2/Sections/Objects.md#transaction for details
        #
        return r.json()


    def Update(self, transactionKey):
        """ Update card and billing address

        :param transactionKey: Existing PayFabric transaction key
        :return: update result (JSON format)
        """

        data = {
            'Key': transactionKey,
            'Card': {
                'Account': '5555555555554444',
                'Cvc': '1453',
                'Tender': 'CreditCard',
                'CardName': 'MasterCard',
                'ExpDate': '0115',
                'CardHolder': {
                    'FirstName': 'Jason',
                    'LastName': 'Zhao',
                },
                'Billto': {
                    'Zip': '22313',
                    'Country': 'US',
                    'State': 'CA',
                    'City': 'ANAHEIM',
                    'Line1': '2099 S State College Blvd',
                    'Email': 'support@payfabric.com'
                }
            }
        }
        # Replace with your own device id and device password
        r = requests.post(url='https://sandbox.payfabric.com/v2/rest/api/transaction/update',
                          data=json.dumps(data),
                          headers={
                              'Content-Type': 'application/json; charset=utf-8',
                              'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                          })

        print r.status_code, r.text

        # "result" is a JSON string similar to
        # 
        # {
        # "Result":"true"
        #      }
        #
        return r.json()


    def Process(self, transactionKey):
        """ Process a pre-saved PayFabric transaction

        :param transactionKey: PayFabric transaction which is ready to process
        :return: process result (JSON object)
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/v2/rest/api/transaction/process/' + transactionKey,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # "result" of HttpRequest is a JSON text similar with following format.
        #
        # {
        #    "AVSAddressResponse":"Y",
        #    "AVSZipResponse":"Y",
        #    "AuthCode":"010010",
        #    "CVV2Response":"Y",
        #    "IAVSAddressResponse":"Y",
        #    "Message":"APPROVED",
        #    "OriginationID":"987220999",
        #    "RespTrxTag":"",
        #    "ResultCode":"0",
        #    "Status":"Approved",
        #    "TrxDate":"",
        #    "TrxKey":"140500229001"
        #}
        #
        return r.json()


    def Refund(self):
        """ Refund a customer if the original transaction is already settled.
        """

        data = {
            'Customer': 'ARRONFIT0003',
            'Currency': 'USD',
            'Amount': '10.05',
            'Type': 'Credit',
            'SetupId': 'Paypal',
            'Card': {
                'Account': '5555555555554444',
                'Cvc': '1453',
                'Tender': 'CreditCard',
                'CardName': 'MasterCard',
                'ExpDate': '0115',
                'CardHolder': {
                    'FirstName': 'Jason',
                    'LastName': 'Zhao',
                },
                'Billto': {
                    'Zip': '22313',
                    'Country': 'US',
                    'State': 'CA',
                    'City': 'ANAHEIM',
                    'Line1': '2099 S State College Blvd',
                    'Email': 'support@payfabric.com'
                }
            }
        }
        # Replace with your own device id and device password
        r = requests.post(url='https://sandbox.payfabric.com/v2/rest/api/transaction/process',
                          data=json.dumps(data),
                          headers={
                              'Content-Type': 'application/json; charset=utf-8',
                              'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                          })

        print r.status_code, r.text

        # Sample response is similar to below
        #
        # {
        # "AVSAddressResponse": null,
        #    "AVSZipResponse": null,
        #    "AuthCode": null,
        #    "CVV2Response": null,
        #    "IAVSAddressResponse": null,
        #    "Message": "Approved",
        #    "OriginationID": "A70E6C184BA5",
        #    "RespTrxTag": null,
        #    "ResultCode": "0",
        #    "Status": "Approved",
        #    "TrxDate": "5\/31\/2014 3:17:27 PM",
        #    "TrxKey": "140531067716"
        #}
        #
        return r.json()


    def Cancel(self, originalKey):
        """ Only unsettled transaction can be cancelled.

            Keywords:
                originalKey - Original transaction key
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/v2/rest/api/reference/' + originalKey + '?trxtype=Void',
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # Sample response - a transaction response object
        # ------------------------------------------------------
        # {
        # "AVSAddressResponse":"Y",
        #    "AVSZipResponse":"Y",
        #    "AuthCode":"010010",
        #    "CVV2Response":"Y",
        #    "IAVSAddressResponse":"Y",
        #    "Message":"APPROVED",
        #    "OriginationID":"987220999",
        #    "RespTrxTag":"",
        #    "ResultCode":"0",
        #    "Status":"Approved",
        #    "TrxDate":"",
        #    "TrxKey":"140500229002"
        #}
        # ------------------------------------------------------
        #
        return r.json()

    def Capture(self, preAuthorizedKey):
        """ There are two solutions to capture a pre-auth transaction. This method call demos the simpler one,
            Which is not able to submit new user defined fields for "Ship" transaction. If you want to do so,
            please use "/transaction/process".

            Keywords:
                preAuthorizedKey - Original pre-authorized transaction key
        """
        # Replace with your own device id and device password
        r = requests.get(
            url='https://sandbox.payfabric.com/v2/rest/api/reference/' + preAuthorizedKey + '?trxtype=Ship',
            headers={
                'Content-Type': 'application/json; charset=utf-8',
                'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
            })

        print r.status_code, r.text

        # Sample response - a transaction response object
        # {
        # "AVSAddressResponse":"Y",
        #    "AVSZipResponse":"Y",
        #    "AuthCode":"010010",
        #    "CVV2Response":"Y",
        #    "IAVSAddressResponse":"Y",
        #    "Message":"APPROVED",
        #    "OriginationID":"987220999",
        #    "RespTrxTag":"",
        #    "ResultCode":"0",
        #    "Status":"Approved",
        #    "TrxDate":"",
        #    "TrxKey":"140500229002"
        #}
        #
        return r.json()

