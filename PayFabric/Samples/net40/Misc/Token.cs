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
using System.Runtime.Serialization;

namespace Samples.Net40
{
    /// <summary>
    /// This sample is to exchange security token from PayFabric, by supplying device id/password
    /// Security token is one-time use credential
    /// </summary>
    public class Token
    {
        public string Create()
        {
            try
            {

                // Replace url when going live
                var url = "https://sandbox.payfabric.com/payment/api/token/create";

                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "GET";

                // Replace with your own device id and device password
                httpWebRequest.Headers["authorization"] = "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc";
                
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string result = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();

                // Parse JSON response
                TokenResponse obj = JsonHelper.JsonDeserialize<TokenResponse>(result);
                return obj.Token;

            }
            catch (WebException e)
            {
                // do something
            }
            catch (Exception e)
            {
                // do something
            }

            return string.Empty;
        }
    }

    [DataContract]
    public class TokenResponse
    {
        [DataMember]
        public string Token { get; set; }
    
    }
}
