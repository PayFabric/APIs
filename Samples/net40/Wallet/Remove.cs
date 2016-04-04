// =====================================================================
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
// =====================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace Samples.Net40
{
    /// <summary>
    /// This sample is to demo how to remove a card from customer wallet
    /// </summary>
    public partial class Wallet
    {
        /// <summary>
        /// Removed card is not recoverable
        /// </summary>
        /// <param name="cardId">Card guid</param>
        public void Remove(Guid cardId)
        {
            try
            {
                var url = "https://sandbox.payfabric.com/v2/rest/api/wallet/delete/" + cardId.ToString();
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Headers["authorization"] = new Token().Create();
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                streamReader.Close();
                responseStream.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();

                //
                // Sample response
                // ------------------------------------------------------
                //{
                //     "Result":"true"
                //}
                // ------------------------------------------------------

            }
            catch (WebException e)
            {
                //  Handling exception from PayFabric
            }
            catch (Exception e)
            {
                //  Handling exception
            }
        }
    }
}
