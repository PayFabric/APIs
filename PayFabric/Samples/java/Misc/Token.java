package com.nodus.payfabric.samples.misc;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

import org.codehaus.jackson.annotate.JsonProperty;

/**
 * This sample is to exchange security token from PayFabric, by supplying device
 * id/password Security token is one-time use credential
 * */
public class Token {

	public String Create() {
		try {

			// Replace url when going live
			String url = "https://sandbox.payfabric.com/payment/api/token/create";
			URL obj = new URL(url);
			HttpsURLConnection con = (HttpsURLConnection) obj.openConnection();
			con.setRequestMethod("GET");
			con.setRequestProperty("Content-Type",
					"application/json; charset=utf-8");
			// Replace with your own device id and device password
			con.setRequestProperty("authorization",
					"0ad64468-f4bc-0c99-4e31-bd08dd862c43|123456abc");
			con.setDoOutput(true);

			BufferedReader streamReader = new BufferedReader(
					new InputStreamReader(con.getInputStream()));
			String inputLine;
			StringBuffer response = new StringBuffer();
			while ((inputLine = streamReader.readLine()) != null) {
				response.append(inputLine);
			}
			streamReader.close();
			con.disconnect();

			// Parse JSON response
			TokenResponse token = JsonHelper.JsonDeserialize(
					response.toString(), TokenResponse.class);
			return token.getToken();

		} catch (Exception e) {
			System.out.println(e.getMessage());
		}

		return "";
	}

	public static class TokenResponse {

		private String token;

		@JsonProperty("Token")
		public String getToken() {
			return token;
		}

		@JsonProperty("Token")
		public void setToken(String token) {
			this.token = token;
		}
	}
}
