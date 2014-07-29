<?php

require_once "Constants.php";

/* Utilities - Miscellaneous utilties. */
class Utilities {
    public function toArrayFromJson($json) {
        return json_decode($json, TRUE);
    }
    public function toJsonFromArray($array) {
        return json_encode($array, TRUE);
    }
}
