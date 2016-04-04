package com.nodus.payfabric.samples.transaction;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to refund a customer
 * */
public class Refund {

	/**
	 * Refund a customer if the original transaction is already settled.
	 * */
	public void refundTransaction() {
		// Populate POST String
		StringBuilder datastring = new StringBuilder();
		datastring.append("{");
		datastring.append("\"Customer\":\"ARRONFIT0001\",");
		datastring.append("\"Currency\":\"USD\",");
		datastring.append("\"Amount\":\"10.05\",");
		datastring.append("\"Type\":\"Credit\",");
		datastring.append("\"SetupId\":\"Paypal\","); // Replace with your
														// gateway account
														// profile name
		datastring.append("\"Card\":{");
		datastring.append("\"Account\":\"5555555555554444\",");
		datastring.append("\"Cvc\":\"1453\",");
		datastring.append("\"Tender\":\"CreditCard\",");
		datastring.append("\"CardName\":\"MasterCard\",");
		datastring.append("\"ExpDate\":\"0115\",");
		datastring.append("\"CardHolder\":{");
		datastring.append("\"FirstName\":\"Jason\",");
		datastring.append("\"LastName\":\"Zhao\"");
		datastring.append("},");
		datastring.append("\"Billto\":{");
		datastring.append("\"Zip\":\"95128\",");
		datastring.append("\"Country\":\"US\",");
		datastring.append("\"State\":\"CA\",");
		datastring.append("\"City\":\"ANAHEIM\",");
		datastring.append("\"Line1\":\"2099 S State College Blvd\",");
		datastring.append("\"Email\":\"support@payfabric.com\"");
		datastring.append("}");
		datastring.append("}");
		datastring.append("}");

		// POST
		try {

			byte[] data = datastring.toString().getBytes("UTF-8");
			String url = "https://sandbox.payfabric.com/rest/v1/api/transaction/process";
			URL obj = new URL(url);
			HttpsURLConnection con = (HttpsURLConnection) obj.openConnection();
			con.setRequestMethod("POST");
			con.setRequestProperty("Content-Type",
					"application/json; charset=utf-8");
			con.setRequestProperty("authorization", new Token().Create());
			con.setRequestProperty("Content-Length", data.length + "");
			con.setDoOutput(true);
			DataOutputStream streamWriter = new DataOutputStream(
					con.getOutputStream());
			streamWriter.write(data);
			streamWriter.flush();
			streamWriter.close();
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
			// Sample repsonse is similar to below
			//
			// {
			// "AVSAddressResponse": null,
			// "AVSZipResponse": null,
			// "AuthCode": null,
			// "CVV2Response": null,
			// "IAVSAddressResponse": null,
			// "Message": "Approved",
			// "OriginationID": "A70E6C184BA5",
			// "RespTrxTag": null,
			// "ResultCode": "0",
			// "Status": "Approved",
			// "TrxDate": "5\/31\/2014 3:17:27 PM",
			// "TrxKey": "140531067716"
			// }

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
