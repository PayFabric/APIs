package com.nodus.payfabric.samples.shippingaddress;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.UUID;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to retrieve one of customer's shipping address
 * */
public class Retrieve {

	/**
	 * Retrieve a shipping address record by id
	 * 
	 * @param addressID
	 *            Address UUID
	 * */
	public void retrieveShippingAddress(UUID addressID) {
		try {

			String url = "https://sandbox.payfabric.com/payment/api/address"
					+ "/" + addressID.toString();
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
            // Sample response
            // ------------------------------------------------------
            // Response text is an address object with json format
            // Go to https://github.com/PayFabric/APIs/blob/master/PayFabric/Sections/Objects.md#address for more details about address object.
            // ------------------------------------------------------
			
		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
	}
}
