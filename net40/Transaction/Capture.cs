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
    /// This sample is to demo how to capture a pre-authorized transaction
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// There are two solutions to capture a pre-auth transaction. This method call demos the simpler one,
        /// Which is not able to submit new user defined fields for "Ship" transaction. If you want to do so,
        /// please use "/transaction/process".
        /// </summary>
        /// <param name="preAuthorizedKey">Original pre-authorized transaction key</param>
        public void Capture(string preAuthorizedKey)
        {
            try
            {
                var url = "https://sandbox.payfabric.com/v2/rest/api/reference/" + preAuthorizedKey + "?trxtype=Ship";
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Headers["authorization"] = new Token().Create(); 
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; 
                Stream responseStream = httpWebResponse.GetResponseStream(); 
                StreamReader streamReader = new StreamReader(responseStream); 
                string result = streamReader.ReadToEnd(); 
                streamReader.Close(); 
                responseStream.Close(); 
                httpWebRequest.Abort(); 
                httpWebResponse.Close(); 

                //
                // Sample response - a transaction response object
                //{
                //    "AVSAddressResponse":"Y",
                //    "AVSZipResponse":"Y",
                //    "AuthCode":"010010",
                //    "CVV2Response":"Y",
                //    "IAVSAddressResponse":"Y",
                //    "Message":"APPROVED",
                //    "OriginationID":"987220999",
                //    "RespTrxTag":"",
                //    "ResultCode":"0",
                //    "Status":"Approved",
                //    "TrxDate":"",
                //    "TrxKey":"140500229002"
                //}

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
