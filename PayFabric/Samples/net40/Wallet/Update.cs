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
    /// This sample is to demo how to update an existing card
    /// </summary>
    public partial class Wallet
    {
        /// <summary>
        /// Card number is not able to be updated. But you can remove the old card and add the new one.
        /// Below example is updating expiration date, billto city, and 2 user defined fields
        /// </summary>
        /// <param name="cardId">Card guid</param>
        public void Update(Guid cardId)
        {
            try
            {
                //  Populate POST String
                StringBuilder datastring = new StringBuilder();
                datastring.Append("{");
                datastring.Append("\"ID\":\"d8f265e3-fbae-459d-b04b-857679d35c84\",");
                datastring.Append("\"ExpDate\":\"0219\",");
                datastring.Append("\"CardHolder\":{");
                datastring.Append("\"FirstName\":\"newupdate\",");
                datastring.Append("\"MiddleName\":\"\",");
                datastring.Append("\"LastName\":\"newupdate\"");
                datastring.Append("},");
                datastring.Append("\"Billto\":{");
                datastring.Append("\"Zip\":\"123456\",");
                datastring.Append("\"Country\":\"new\",");
                datastring.Append("\"State\":\"new\",");
                datastring.Append("\"Email\":\"\",");
                datastring.Append("\"City\":\"Rowland Height\",");
                datastring.Append("\"Line1\":\"Fullerton Blvd\"");
                datastring.Append("},");
                datastring.Append("\"UserDefined1\":\"New Update\",");
                datastring.Append("\"UserDefined2\":\"New Update\"");
                datastring.Append("}");

                // POST
                byte[] data = System.Text.Encoding.UTF8.GetBytes(datastring.ToString());
                var url = "https://sandbox.payfabric.com/payment/api/wallet/update";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
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
                //    "Result":"true"  
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
