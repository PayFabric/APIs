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
    /// This sample is to demo how to submit a PayFabric transaction to payment gateways
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// Process a pre-saved PayFabric transaction
        /// </summary>
        /// <param name="transactionKey">PayFabric transaction which is ready to process</param>
        public void Process(string transactionKey)
        {
            try
            {
                var url = "https://sandbox.payfabric.com/V2/Rest/api/transaction/process/" + transactionKey;
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
                //  "result" of HttpRequest is a JSON text similar with following format. 
                //
                //  {
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
                //    "TrxKey":"140500229001"
                //}
                //
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

        /// <summary>
        /// Process a transaction right away by submitting all necessary fields at one time
        /// </summary>
        public void Process()
        {
            try
            {
                #region Populate POST string

                StringBuilder datastring = new StringBuilder();
                datastring.Append("{");

                #region Required Fields

                datastring.Append("\"Customer\":\"AARONFIT0001\",");
                datastring.Append("\"Currency\":\"USD\",");
                datastring.Append("\"Amount\":\"4.81\",");
                datastring.Append("\"Type\":\"Sale\",");

                // Replace with your gateway account profile name
                datastring.Append("\"SetupId\":\"Paypal\",");

                #endregion

                #region Card Object

                datastring.Append("\"Card\":{");
                datastring.Append("\"Account\":\"4111111111111111\",");
                datastring.Append("\"Cvc\":\"745\",");
                datastring.Append("\"Tender\":\"CreditCard\",");
                datastring.Append("\"CardName\":\"Visa\",");
                datastring.Append("\"ExpDate\":\"0117\",");

                // Card Holder
                datastring.Append("\"CardHolder\":{");
                datastring.Append("\"FirstName\":\"jason\",");
                datastring.Append("\"MiddleName\":\"K\",");
                datastring.Append("\"LastName\":\"zhao\",");
                datastring.Append("\"Email\":\"jasonzhao@nodus.com\"");
                datastring.Append("},");

                // Bill to
                datastring.Append("\"Billto\":{");
                datastring.Append("\"Country\":\"US\",");
                datastring.Append("\"State\":\"CA\",");
                datastring.Append("\"City\":\"ANAHEIM\",");
                datastring.Append("\"Zip\":\"92806\",");
                datastring.Append("\"Line1\":\"2099 S State College Blvd\",");
                datastring.Append("\"Email\":\"support@payfabric.com\"");
                datastring.Append("}");

                datastring.Append("},");

                #endregion

                //
                //  Notes:
                // 
                //  You might not have to populate the level 2 and level 3 fields below
                //  unless you have customers are submit Business, corporate, or purchasing cards
                //

                #region Optional Level 2 Fields

                // Begin "Document"
                datastring.Append("\"Document\":{");

                datastring.Append("\"Head\":{");
                datastring.Append("\"InvoiceNumber\":\"INV14-98870\",");
                datastring.Append("\"PONumber\":\"PUR14-009872\",");
                datastring.Append("\"DiscountAmount\":\"200.00\",");
                datastring.Append("\"DutyAmount\":\"0.00\",");
                datastring.Append("\"FreightAmount\":\"24.00\",");
                datastring.Append("\"HandlingAmount\":\"20.00\",");
                datastring.Append("\"TaxExempt\":\"N\",");
                datastring.Append("\"TaxAmount\":\"400.00\",");
                datastring.Append("\"ShipFromZip\":\"92806\",");
                datastring.Append("\"ShipToZip\":\"92806\",");
                datastring.Append("\"OrderDate\":\"06/09/2014\",");
                datastring.Append("\"VATTaxAmount\":\"0.00\",");
                datastring.Append("\"VATTaxRate\":\"0\"");
                datastring.Append("},");

                #endregion

                #region Optional Level 3 Fields

                datastring.Append("\"Lines\":[");

                // Line Item 1
                datastring.Append("{");
                datastring.Append("\"ItemCommodityCode\":\"24X BIKE\",");
                datastring.Append("\"ItemProdCode\":\"B872\",");
                datastring.Append("\"ItemUPC\":\"B872\",");
                datastring.Append("\"ItemUOM\":\"SET\",");
                datastring.Append("\"ItemDesc\":\"Mountain Bicycle\",");
                datastring.Append("\"ItemAmount\":\"2000.00\",");
                datastring.Append("\"ItemCost\":\"112.00\",");
                datastring.Append("\"ItemDiscount\":\"100.00\",");
                datastring.Append("\"ItemFreightAmount\":\"12.00\",");
                datastring.Append("\"ItemHandlingAmount\":\"10.00\",");
                datastring.Append("\"ItemQuantity\":\"10\"");
                datastring.Append("},");

                // Line Item 2
                datastring.Append("{");
                datastring.Append("\"ItemCommodityCode\":\"12X BIKE\",");
                datastring.Append("\"ItemProdCode\":\"B0654\",");
                datastring.Append("\"ItemUPC\":\"B0654\",");
                datastring.Append("\"ItemUOM\":\"SET\",");
                datastring.Append("\"ItemDesc\":\"City Bicycle\",");
                datastring.Append("\"ItemAmount\":\"2000.00\",");
                datastring.Append("\"ItemCost\":\"80.00\",");
                datastring.Append("\"ItemDiscount\":\"100.00\",");
                datastring.Append("\"ItemFreightAmount\":\"12.00\",");
                datastring.Append("\"ItemHandlingAmount\":\"10.00\",");
                datastring.Append("\"ItemQuantity\":\"20\"");
                datastring.Append("}");

                datastring.Append("]");

                // End "Document"
                datastring.Append("}");

                #endregion

                datastring.Append("}");

                #endregion

                var url = "https://sandbox.payfabric.com/V2/Rest/api/transaction/process";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                byte[] data = System.Text.Encoding.UTF8.GetBytes(datastring.ToString());
                HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                
                // Replace with your own device id and device password
                httpWebRequest.Headers["authorization"] = "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc";

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
                //  "result" of HttpRequest is a JSON text similar with following format. 
                //
                //  {
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
                //    "TrxKey":"140500229001"
                //}
                //
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
