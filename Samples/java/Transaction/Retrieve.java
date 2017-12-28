package com.nodus.payfabric.samples.transaction;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to retrieve a transaction back from PayFabric
 * */
public class Retrieve {

	/**
	 * This method call will return all transaction fields with masked
	 * account/card number
	 * 
	 * @param transactionKey
	 *            Transaction key
	 * */
	public void retrieveTransaction(String transactionKey) {

		try {

			String url = "https://sandbox.payfabric.com/v2/rest/api/transaction"
					+ "/" + transactionKey;
			URL obj = new URL(url);
			HttpsURLConnection con = (HttpsURLConnection) obj.openConnection();
			con.setRequestMethod("GET");
			con.setRequestProperty("Content-Type",
					"application/json; charset=utf-8");
			con.setRequestProperty("authorization", new Token().Create());
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
			// "result" is a Transaction object with json format
			//
			// Go to
			// https://github.com/PayFabric/APIs/blob/v2/Sections/Objects.md#transaction
			// for details
			//

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
