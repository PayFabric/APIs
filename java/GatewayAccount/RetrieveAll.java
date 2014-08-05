package com.nodus.payfabric.samples.gatewayaccount;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to get all gateway account profile within one PayFabric account 
 * */
public class RetrieveAll {

	/**
	 * Retrieve all active gateway account profiles 
	 * */
	public void retrieveAllGatewayAccounts() {
		
		try {

			String url = "https://sandbox.payfabric.com/rest/v1/api/setupid";
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
            // Response text is an array of gateway account object with json format
            // Go to https://github.com/PayFabric/APIs/wiki/API-Objects#gateway-account for more details about gateway account object.
            // ------------------------------------------------------
			
		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}
		
	}
}
