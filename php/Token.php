<?php

require_once "HttpClient.php";

class Token {
    public function get() {
        $result = HttpClient::get("token/create");
        return $result["Token"];
    }
}
