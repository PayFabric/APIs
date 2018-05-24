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
using System.Net;
using System.IO;

namespace Samples.Net40
{
    /// <summary>
    /// This sample is to demo how to retrieve a transaction back from PayFabric
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// This method call will return all transaction fields with masked account/card number
        /// </summary>
        /// <param name="transactionKey">Transaction key</param>
        public void Retrieve(string transactionKey)
        {
            try
            {
                var url = "https://sandbox.payfabric.com/v2/rest/api/transaction/" + transactionKey;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                
                // Replace with your own device id and device password
                httpWebRequest.Headers["authorization"] = "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc";

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
                // "result" is a Transaction object with json format
                // 
                // Go to https://github.com/PayFabric/APIs/blob/v2/Sections/Objects.md#transaction for details
                //


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
