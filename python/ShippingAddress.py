# =====================================================================
# THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
#  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
#  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
#  PARTICULAR PURPOSE.
# =====================================================================

import requests
from Token import Token


class ShippingAddress:
    """ ShippingAddress methods
    """

    def Retrieve(self, addressId):
        """ Retrieve a shipping address record by id

            Keywords:
                addressId - Address GUID
        """

        r = requests.get(url='https://sandbox.payfabric.com/rest/v1/api/address/' + addressId,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': Token().Create()
                         })

        print r.status_code, r.text

        # Sample response
        # ------------------------------------------------------
        # Response text is an address object with json format
        # Go to https://github.com/PayFabric/APIs/wiki/API-Objects#address for more details about address object.
        # ------------------------------------------------------
        #
        return r.json()

    def RetrieveByCustomer(self, customer):
        """ Retrieve all shipping addresses by customer

        :param customer: Customer unique name
        :return: all shipping addresses
        """

        r = requests.get(url='https://sandbox.payfabric.com/rest/v1/api/addresses/' + customer,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': Token().Create()
                         })

        print r.status_code, r.text

        # Sample response
        # ------------------------------------------------------
        # Response text is an array of address object with json format
        # Go to https://github.com/PayFabric/APIs/wiki/API-Objects#address for more details about address object.
        # ------------------------------------------------------
        #
        return r.json();