package com.nodus.payfabric.samples.transaction;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to submit a PayFabric transaction to payment
 * gateways
 * */
public class Process {

	/**
	 * Process a pre-saved PayFabric transaction
	 * 
	 * @param transactionKey
	 *            PayFabric transaction which is ready to process
	 * */
	public void processTransaction(String transactionKey) {
		
		try {

			String url = "https://sandbox.payfabric.com/payment/api/transaction/process"
					+ "/" + transactionKey;
			URL obj = new URL(url);
			HttpsURLConnection con = (HttpsURLConnection) obj.openConnection();
			con.setRequestMethod("GET");
			con.setRequestProperty("Content-Type",
					"application/json; charset=utf-8");
						
			// Replace with your own device id and device password
			con.setRequestProperty("authorization", "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc");
			
			con.setDoOutput(true);

			InputStream stream;
			int responseCode = con.getResponseCode();
			if (responseCode >= 400) {
				stream = con.getErrorStream();
			} else {
				stream = con.getInputStream();
			}
			BufferedReader streamReader = new BufferedReader(
					new InputStreamReader(stream));
			String inputLine;
			StringBuffer response = new StringBuffer();
			while ((inputLine = streamReader.readLine()) != null) {
				response.append(inputLine);
			}
			streamReader.close();
			con.disconnect();
			System.out.println(response.toString());

			if (responseCode >= 400) {

				// Handling exception from PayFabric

			}

			//
			// "result" of HttpRequest is a JSON text similar with following format.
			//
			// {
			// "AVSAddressResponse":"Y",
			// "AVSZipResponse":"Y",
			// "AuthCode":"010010",
			// "CVV2Response":"Y",
			// "IAVSAddressResponse":"Y",
			// "Message":"APPROVED",
			// "OriginationID":"987220999",
			// "RespTrxTag":"",
			// "ResultCode":"0",
			// "Status":"Approved",
			// "TrxDate":"",
			// "TrxKey":"140500229001"
			// }
			//
			//

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
