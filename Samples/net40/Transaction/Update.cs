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
    /// This sample is to demo how to update an existing transaction.
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// Update card and billing address
        /// </summary>
        /// <param name="transactionKey">Existing PayFabric transaction key</param>
        public void Update(string transactionKey)
        {
            try
            {
                // Populate POST String
                StringBuilder datastring = new StringBuilder();
                datastring.Append("{");
                datastring.Append("\"Key\":\"" + transactionKey + "\",");
                datastring.Append("\"Card\":{");
                datastring.Append("\"Account\":\"5555555555554444\",");
                datastring.Append("\"Cvc\":\"1453\",");
                datastring.Append("\"Tender\":\"CreditCard\",");
                datastring.Append("\"CardName\":\"MasterCard\",");
                datastring.Append("\"ExpDate\":\"0117\",");
                datastring.Append("\"CardHolder\":{");
                datastring.Append("\"FirstName\":\"Jason\",");
                datastring.Append("\"MiddleName\":\"\",");
                datastring.Append("\"LastName\":\"Zhao\"");      
                datastring.Append("},");
                datastring.Append("\"Billto\":{");
                datastring.Append("\"Country\":\"US\",");
                datastring.Append("\"State\":\"CA\",");
                datastring.Append("\"City\":\"ANAHEIM\",");
                datastring.Append("\"Zip\":\"92806\",");
                datastring.Append("\"Line1\":\"2099 S State College Blvd\",");
                datastring.Append("\"Email\":\"support@payfabric.com\"");
                datastring.Append("}");
                datastring.Append("}");
                datastring.Append("}");

                // POST
                byte[] data = System.Text.Encoding.UTF8.GetBytes(datastring.ToString());
                var url = "https://sandbox.payfabric.com/V3/PayFabric/rest/api/transaction/update";
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
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

                //
                // "result" is a JSON string similar to
                // 
                //      {
                //          "Result":"true"
                //      }
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
