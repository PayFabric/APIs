<?php

require_once "Constants.php";

class Utilities {
    public function isValidTenderType($tenderType) {
        if ($tenderType == Constants::TENDER_TYPE_CREDIT_CARD) {
            return true;
        }
        if ($tenderType == Constants::TENDER_TYPE_ECHECK) {
            return true;
        }
        return false;
    }
    public function toArrayFromJson($json) {
        return json_decode($json, TRUE);
    }
    public function toJsonFromArray($array) {
        return json_encode($array, TRUE);
    }
}
