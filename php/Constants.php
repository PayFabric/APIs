<?php

/* Constants - Miscellaneous useful constants.
 * 
 * Set BASE_URL to the base url of the PayFabric REST server.
 * Note that HttpClient uses BASE_URL to create the full URL
 * for web service requests. When the other classes use HttpClient
 * to perform web service requests they just provide the relative path
 * to the resource which they want to use. 
 * 
 * Set DEVICE_ID and DEVICE_PASSWORD to your application's credentials.
 * You create these via the PayFabric web portal (Dev Central > Devices).
 * These credentials are included in the HTTPS header of every web 
 * service request that you make. 
 * 
 * You should not need to modify any of the other constants. */

class Constants {
    // Set to base URL of PayFabric's Sandbox or Production server.
    const BASE_URL = "https://sandbox.payfabric.com/rest/v1/api/";
    /* Set to your Device ID and Device Password. These are created
     * via the PayFabric web portal (Dev Central > Devices). */
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
