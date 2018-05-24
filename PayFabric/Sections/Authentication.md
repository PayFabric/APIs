PayFabric API Authentication
============================

Clients running in server-side programming environments can include an authorization field in the HTTP header of each request that is made to PayFabric. The authorization field includes a _Device ID_ and a _Device Password_. These are the credentials for this application. You can generate these credentials via the PayFabric web portal. These credentials will provide access to all the PayFabric APIs, so you should only use this authentication method in secure environments.

Authentication C# Sample code snippet, for more sample codes, click [here](https://github.com/PayFabric/APIs/tree/master/PayFabric/Samples)
----------------------

                var url = "https://sandbox.payfabric.com/payment/api/address/" + addressId.ToString();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                
                // Replace with your own device id and device password
                httpWebRequest.Headers["authorization"] = "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc";
                
                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                string result = streamReader.ReadToEnd();  // JSON result
                Console.WriteLine(result);
                streamReader.Close();
                responseStream.Close();
                httpWebRequest.Abort();
                httpWebResponse.Close();
