package com.nodus.payfabric.samples.wallet;

import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import org.codehaus.jackson.annotate.JsonProperty;

import com.nodus.payfabric.samples.misc.JsonHelper;
import com.nodus.payfabric.samples.misc.Token;

/**
 * This sample is to demo how to add a new card into customer wallet
 * */
public class Add {

	/**
	 * Card is not only credit card, but also ECheck(ACH) account
	 * */
	public String addCard() {

		// Populate POST String
		StringBuilder datastring = new StringBuilder("");
		datastring.append("{");
		datastring.append("\"Tender\":\"CreditCard\",");
		datastring.append("\"Customer\":\"ARRONFIT0008\",");
		datastring.append("\"Account\":\"5555555555554444\",");
		datastring.append("\"Cvc\":\"1453\",");
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
		datastring.append("},");
		datastring.append("\"IsDefaultCard\":\"true\",");
		datastring.append("\"UserDefined1\":\"Example\",");
		datastring.append("\"UserDefined2\":\"Example\"");
		datastring.append("}");

		// POST
		try {

			byte[] data = datastring.toString().getBytes("UTF-8");
			String url = "https://sandbox.payfabric.com/payment/api/wallet/create";
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
			} else {
				WalletResponse wallet = JsonHelper.JsonDeserialize(
						response.toString(), WalletResponse.class);
				return wallet.getResult();
			}

			//
			// Sample response
			// ----------------------------------------------------
			// {
			// "Message":null,
			// "Result":"1627aea5-8e0a-4371-9022-9b504344e724"
			// }
			// ----------------------------------------------------
			//

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}

		return "";
	}

	public static class WalletResponse {

		private String message;
		private String result;

		@JsonProperty("Message")
		public String getMessage() {
			return message;
		}

		@JsonProperty("Message")
		public void setMessage(String message) {
			this.message = message;
		}

		@JsonProperty("Result")
		public String getResult() {
			return result;
		}

		@JsonProperty("Result")
		public void setResult(String result) {
			this.result = result;
		}
	}
}
