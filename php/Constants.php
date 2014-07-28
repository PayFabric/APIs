<?php

class Constants {
    // Set to base URL of PayFabric's Sandbox or Production server.
    const BASE_URL = "https://sandbox.payfabric.com/rest/v1/api/";
    // Set to your Device ID and Device Password.
    const DEVICE_ID = "49b8e79d-bc02-9295-fe09-a4112427490c";
    const DEVICE_PASSWORD = "SamsonitePhp1";
    // Various useful constants. Do not change these.
    const TENDER_TYPE_CREDIT_CARD = "CreditCard";
    const TENDER_TYPE_ECHECK = "ECheck";
    const CREDIT_CARD_TYPE_VISA = "Visa";
    const CREDIT_CARD_TYPE_MASTERCARD = "MasterCard";
    const TRANSACTION_TYPE_SALE = "Sale";
    const TRANSACTION_TYPE_BOOK = "Book";
    const TRANSACTION_TYPE_SHIP = "Ship";
    const TRANSACTION_TYPE_VOID = "Void";
    const TRANSACTION_TYPE_CREDIT = "Credit";
}
