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
    /// This sample is to demo how to add a new card into customer wallet
    /// </summary>
    public partial class Wallet
    {
        /// <summary>
        /// Card is not only credit card, but also ECheck(ACH) account
        /// </summary>
        public void AddCard()
        {
            try
            {
                //  Populate POST String
                StringBuilder datastring = new StringBuilder();
                datastring.Append("{");
                datastring.Append("\"Tender\":\"CreditCard\",");
                datastring.Append("\"Customer\":\"ARRONFIT0001\",");
                datastring.Append("\"Account\":\"4111111111111111\",");
                datastring.Append("\"ExpDate\":\"0517\",");
                datastring.Append("\"IsDefaultCard\":\"true\",");
                datastring.Append("\"CardHolder\":{");
                datastring.Append("\"FirstName\":\"jason\",");
                datastring.Append("\"MiddleName\":\"K\",");
                datastring.Append("\"LastName\":\"zhao\"");
                datastring.Append("},");
                datastring.Append("\"Billto\":{");
                datastring.Append("\"Country\":\"US\",");
                datastring.Append("\"State\":\"CA\",");
                datastring.Append("\"City\":\"Chicago\",");
                datastring.Append("\"Zip\":\"92806\",");
                datastring.Append("\"Email\":\"JasonZhao@nodus.com\",");
                datastring.Append("\"Line1\":\"2009 S State College Blvd\"");
                datastring.Append("}");

                // POST
                byte[] data = System.Text.Encoding.UTF8.GetBytes(datastring.ToString());
                var url = "https://sandbox.payfabric.com/V3/PayFabric/rest/api/wallet/create";
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
                // Sample response
                // ----------------------------------------------------
                //{
                //    "Message":"",
                //    "Result":"1627aea5-8e0a-4371-9022-9b504344e724"   
                //}
                // ----------------------------------------------------
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
