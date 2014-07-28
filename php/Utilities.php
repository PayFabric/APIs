<?php

require_once "Constants.php";

class Utilities {
    public function toArrayFromJson($json) {
        return json_decode($json, TRUE);
    }
    public function toJsonFromArray($array) {
        return json_encode($array, TRUE);
    }
}
