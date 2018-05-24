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

        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/payment/api/address/' + addressId,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # Sample response
        # ------------------------------------------------------
        # Response text is an address object with json format
        # Go to https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#address for more details about address object.
        # ------------------------------------------------------
        #
        return r.json()

    def RetrieveByCustomer(self, customer):
        """ Retrieve all shipping addresses by customer

        :param customer: Customer unique name
        :return: all shipping addresses
        """
        # Replace with your own device id and device password
        r = requests.get(url='https://sandbox.payfabric.com/payment/api/addresses/' + customer,
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc'
                         })

        print r.status_code, r.text

        # Sample response
        # ------------------------------------------------------
        # Response text is an array of address object with json format
        # Go to https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#address for more details about address object.
        # ------------------------------------------------------
        #
        return r.json();
