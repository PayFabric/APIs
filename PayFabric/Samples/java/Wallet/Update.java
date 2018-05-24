package com.nodus.payfabric.samples.wallet;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.UUID;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to update an existing card
 * */
public class Update {

	/**
	 * Card number is not able to be updated. But you can remove the old card
	 * and add the new one. Below example is updating expiration date, billto
	 * city, and 2 user defined fields
	 * 
	 * @param cardID
	 *            Card UUID
	 * */
	public void updateCard(UUID cardID) {

		// Populate POST String
		StringBuilder datastring = new StringBuilder();
		datastring.append("{");
		datastring.append("\"ID\":\"" + cardID.toString() + "\",");
		datastring.append("\"ExpDate\":\"0219\",");
		datastring.append("\"Billto\":{");
		datastring.append("\"City\":\"Rowland Height\",");
		datastring.append("\"Line1\":\"Fullerton Blvd\"");
		datastring.append("},");
		datastring.append("\"UserDefined1\":\"New Update\",");
		datastring.append("\"UserDefined2\":\"New Update\"");
		datastring.append("}");
		
		System.out.println(datastring);

		// POST
		try {

			byte[] data = datastring.toString().getBytes("UTF-8");
			String url = "https://sandbox.payfabric.com/payment/api/wallet/update";
			URL obj = new URL(url);
			HttpsURLConnection con = (HttpsURLConnection) obj.openConnection();
			con.setRequestMethod("POST");
			con.setRequestProperty("Content-Type",
					"application/json; charset=utf-8");
						
			// Replace with your own device id and device password
			con.setRequestProperty("authorization", "0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc");
			
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
			// Sample response
			// ----------------------------------------------------
			// {
			// "Result":"true"
			// }
			// ----------------------------------------------------
			//

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
