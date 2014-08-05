package com.nodus.payfabric.samples.transaction;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to capture a pre-authorized transaction
 * */
public class Capture {

	/**
	 * There are two solutions to capture a pre-auth transaction. This method
	 * call demos the simpler one, Which is not able to submit new user defined
	 * fields for "Ship" transaction. If you want to do so, please use
	 * "/transaction/process".
	 * 
	 * @param preAuthorizedKey
	 *            Original pre-authorized transaction key
	 * */
	public void captureTransaction(String preAuthorizedKey) {

		try {

			String url = "https://sandbox.payfabric.com/rest/v1/api/reference"
					+ "/" + preAuthorizedKey + "?trxtype=Ship";
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
			// Sample response - a transaction response object
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
			// "TrxKey":"140500229002"
			// }

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}

	}
}
