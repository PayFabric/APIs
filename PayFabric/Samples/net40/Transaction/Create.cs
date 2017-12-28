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
    /// This sample is to demo how to create a PayFabric transaction without submitting to payment gateways
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// Create transaction
        /// </summary>
        /// <returns>New Transaction Key</returns>
        public string Create()
        {

            try
            {
                //  Populate POST String
                StringBuilder datastring = new StringBuilder();
                datastring.Append("{");
                datastring.Append("\"Customer\":\"AARONFIT0001\",");
                datastring.Append("\"Currency\":\"USD\",");
                datastring.Append("\"Amount\":\"4.88\",");
                datastring.Append("\"Type\":\"Sale\",");
                datastring.Append("\"SetupId\":\"Paypal\""); // Replace with your gateway account profile name
                datastring.Append("}");

                // POST
                byte[] data = System.Text.Encoding.UTF8.GetBytes(datastring.ToString());
                var url = "https://sandbox.payfabric.com/payment/api/transaction/create";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Headers["authorization"] = new Token().Create();
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentLength = data.Length;
                Stream stream = httpWebRequest.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string result = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();

                // Parse response
                TrxKeyResponse obj = JsonHelper.JsonDeserialize<TrxKeyResponse>(result);
                return obj.Key;
            }
            catch (WebException e)
            {
                //  Handling exception from PayFabric
            }
            catch (Exception e)
            {
                //  Handling exception
            }

            return string.Empty;
        }
    }

    [DataContract]
    public class TrxKeyResponse
    {
        [DataMember]
        public string Key { get; set; }
    }
}
