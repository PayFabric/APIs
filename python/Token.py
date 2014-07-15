# =====================================================================
# THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
#  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
#  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
#  PARTICULAR PURPOSE.
# =====================================================================

import requests


class Token:
    """This sample is to exchange security token from PayFabric, by supplying device id/password"""

    def Create(self):
        """ Security token is one-time use credential """

        # Replace url when going live
        # Replace with your own device id and device password
        #
        r = requests.get(url='https://sandbox.payfabric.com/rest/v1/api/token/create',
                         headers={
                             'Content-Type': 'application/json; charset=utf-8',
                             'authorization': '0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc',
                         })

        return r.json()['Token']