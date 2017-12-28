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
    /// This sample is to demo how to cancel a transaction before it is settled
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// Only unsettled transaction can be cancelled.
        /// </summary>
        /// <param name="originalKey">Orignial transaction key</param>
        public void Cancel(string originalKey)
        {
            try
            {
                var url = "https://sandbox.payfabric.com/payment/api/reference/" + originalKey + "?trxtype=Void";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Headers["authorization"] = new Token().Create();
                httpWebRequest.Method = "GET";                                   
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
                // ------------------------------------------------------
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
