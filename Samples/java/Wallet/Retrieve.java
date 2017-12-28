package com.nodus.payfabric.samples.wallet;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to retrieve customer's cards
 * */
public class Retrieve {
	/**
	 * Will return all cards by customer with masked account/card number.
	 * 
	 * @param Customer
	 *            Customer unique name
	 * */
	public void retrieveCards(String customer) {

		try {
			//Options are CreditCard, ECheck
			String tender = "CreditCard";
			String url = "https://sandbox.payfabric.com/v2/rest/api/wallet/get"
					+ "/" + customer + "?tender=" + tender;
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
            // Sample response
            // ------------------------------------------------------
            // Response text is an array of card object with json format
            // Go to https://github.com/PayFabric/APIs/blob/v2/Sections/Objects.md#card for more details about card object.
            // ------------------------------------------------------
			
		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
