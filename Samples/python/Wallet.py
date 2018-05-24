# =====================================================================                                     
# THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY                                    
# KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE                                       
# IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A                                                
# PARTICULAR PURPOSE.                                                                                       
# =====================================================================                                     

import json
import requests
from Token import Token


class Wallet:
    """ Customer wallet methods
    """

    def AddCard(self, cardId):
        """ Card is not only credit card, but also ECheck(ACH) account
        """

        data = {
            'Tender': 'CreditCard',
            #'Customer': 'be2972fb-8ef3-4bc1-bb05-4250978ef8e8',
            'Customer': 'ARRONFIT0001',
            'Account': cardId,
            #'Account': '5555555555554441',
            'Cvc': '1453',
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
            },
            'IsDefaultCard': 'true',
            'UserDefined1': 'Example',
            'UserDefined2': 'Example'
        }
        # Replace with your own device id and device password
        r = requests.post(url='https://sandbox.payfabric.com/v2/rest/api/wallet/create',
                          data=json.dumps(data),
                          headers={
                              'Content-Type': 'application/json; charset=utf-8',
                              'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                          })

        print r.status_code, r.text

        # Sample response
        # ----------------------------------------------------
        # {
        # "Message":"",
        #    "Result":"1627aea5-8e0a-4371-9022-9b504344e724"   
        #}
        # ----------------------------------------------------
        #
        return r.json()

    def Retrieve(self, customer):
        """ Will return all cards by customer with masked account/card number.

        :param customer: Customer unique name
        :return: all cards by customer
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/v2/rest/api/wallet/get/' + customer,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        #
        # Sample response
        # ------------------------------------------------------
        # Response text is an array of card object with json format
        # Go to https:#github.com/PayFabric/APIs/blob/v2/Sections/Objects.md#card for more details about card object.
        # ------------------------------------------------------
        #
        return r.json()

    def Update(self, cardId):
        """ Card number is not able to be updated. But you can remove the old card and add the new one.
            Below example is updating expiration date, billto city, and 2 user defined fields

        :param cardId: Card guid
        :return: updating result
        """

        data = {
            'ID': cardId,
            'ExpDate': '0219',
            'Billto': {
                'City': 'Rowland Height',
                'Line1': 'Fullerton Blvd',
                },
            'UserDefined1': 'New Update', 'UserDefined2': 'New Update'
        }
        # Replace with your own device id and device password
        r = requests.post(url='https://sandbox.payfabric.com/v2/rest/api/wallet/update',
                          data=json.dumps(data),
                          headers={
                              'Content-Type': 'application/json; charset=utf-8',
                              'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                          })

        print r.status_code, r.text

        # Sample response
        # ----------------------------------------------------
        #{
        #    "Result":"true"  
        #}
        # ----------------------------------------------------
        #
        return r.json()

    def Remove(self, cardId):
        """ Removed card is not recoverable

        :param cardId: Card guid
        :return: removing result
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/v2/rest/api/wallet/delete/' + cardId,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # Sample response
        # ------------------------------------------------------
        #{
        #     "Result":"true"
        #}
        # ------------------------------------------------------
        #
        return r.json()


