package com.nodus.payfabric.samples.misc;

import java.io.IOException;

import org.codehaus.jackson.map.ObjectMapper;

public class JsonHelper {
	public static <T> String JsonSerializer(T t) {
		ObjectMapper mapper = new ObjectMapper();
		try {
			return mapper.writeValueAsString(t);
		} catch (IOException e) {
			return "";
		}
	}

	public static <T> T JsonDeserialize(String jsonString, Class<T> classType) {
		try {
			ObjectMapper mapper = new ObjectMapper();
			T obj = mapper.readValue(jsonString, classType);
			return obj;
		} catch (IOException e) {
			System.out.println(e.getMessage());
			return null;
		}
	}
}
