package com.nodus.payfabric.samples.transaction;

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
 * This sample is to demo how to create a PayFabric transaction without
 * submitting to payment gateways
 * */
public class Create {

	/**
	 * Create transaction
	 * 
	 * @return New Transaction Key
	 * */
	public String createTransaction() {

		// Populate POST String
		StringBuilder datastring = new StringBuilder();
		datastring.append("{");
		datastring.append("\"Customer\":\"AARONFIT0001\",");
		datastring.append("\"Currency\":\"USD\",");
		datastring.append("\"Amount\":\"4.88\",");
		datastring.append("\"Type\":\"Sale\",");
		//datastring.append("\"Type\":\"Book\",");
		datastring.append("\"SetupId\":\"Paypal\""); // Replace with your gateway account profile name
		datastring.append("}");

		// POST
		try {

			byte[] data = datastring.toString().getBytes("UTF-8");
			String url = "https://sandbox.payfabric.com/payment/api/transaction/create";
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
				
			} else {
				TrxKeyResponse trx = JsonHelper.JsonDeserialize(response.toString(), TrxKeyResponse.class);
                return trx.getKey();
			}

		} catch (IOException e) {
			System.out.println(e.getMessage());

			// Handling exception
		}

		return "";
	}

	public static class TrxKeyResponse {
		
		private String key;

		@JsonProperty("Key")
		public String getKey() {
			return key;
		}

		@JsonProperty("Key")
		public void setKey(String key) {
			this.key = key;
		}
		
	}

}
