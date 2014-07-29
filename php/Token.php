<?php

require_once "HttpClient.php";

/* Token - Retrieve a token from PayFabric. */
class Token {
    public function get() {
        $result = HttpClient::get("token/create");
        return $result["Token"];
    }
}
