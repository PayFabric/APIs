Custom Report
=================

The PayFabric Custom Report APIs are used for managing Custom Report.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer the [Custom Report Object](/PayFabric/Sections/3.1JSONObjects.md#custom-report) for details.

Get Custom Reports
------------------
* `GET /Report` will get list of configured custom reports for a Merchant.

###### Response
<pre>
[    
    {
        "ReportId": "8eb3b96b-854b-421b-bc38-7cf5b7795334",
        "Name": "JUNE- Settled-Daily",
        "Message": "JUNE- Settled-Monthly",
        "Frequency": "Daily",
        "AdditionalFields": [],
        "TransactionTypes": [
            "Authorization",
            "Capture",
            "Force",
            "Refund",
            "Sale",
            "Void",
            "Verify"
        ],
        "TransactionStatus": [
            "Approved",
            "AvsFailure",
            "Denied",
            "Failure",
            "MoreInfo",
            "ThreeDSChallenge"
        ],
        "TransactionState": [
            "Settled"
        ],
        "Recipients": {
            "To": [
                "success+test@simulator.amazonses.com"
            ],
            "BCC": []
        }
    },
    {
        "ReportId": "35ed74df-7fcb-4c9f-9aa1-71261b345b12",
        "Name": "JUNE- Unsettled-Daily",
        "Message": "JUNE- Unsettled-Monthly",
        "Frequency": "Daily",
        "AdditionalFields": [],
        "TransactionTypes": [
            "Authorization",
            "Capture",
            "Force",
            "Refund",
            "Sale",
            "Void",
            "Verify"
        ],
        "TransactionStatus": [
            "Approved",
            "AvsFailure",
            "Denied",
            "Failure",
            "MoreInfo",
            "ThreeDSChallenge"
        ],
        "TransactionState": [
            "Unsettled"
        ],
        "Recipients": {
            "To": [
                "success+test@simulator.amazonses.com"
            ],
            "BCC": []
        }
    }
]
</pre>

Create Custom Report
------------------
* `POST /Report/` Will create a new custom report with all configured filters, columns, sorting and frequency.

###### Request
<pre>
{
    "Name": "test6",
    "Frequency": "Monthly",
    "Message": "fg",
    "AdditionalFields": [
        "*"
    ],
    "TransactionTypes": [
        "*"
    ],
    "TransactionStatus": [
        "*"
    ],
    "TransactionState": [
        "*"
    ],
    "Recipients": {
        "To": [],
        "BCC": [
            "success+test@simulator.amazonses.com"
        ]
    }
}
</pre>

###### Response
<pre>
{
    "ReportId": "8d5901c0-ca43-4fc8-a823-545af6259aaf",
    "Name": "test6"
}
</pre>

Edit Custom Report
------------------
* `PATCH /Report/{CustomReportID} ` will updates an existing report with new filters, columns, sorting and frequency.
###### Request
<pre>
{
  "Name":"test2",
  "Frequency": "weekly",

  "AdditionalFields": ["Email","Currency"],
  "TransactionTypes":  ["Sale","Capture"],
  "TransactionStatus":  ["Approved","Approved"],
 
 "Recipients": {
    "To":["success+test1@simulator.amazonses.com","success+test2@simulator.amazonses.com"],
    "BCC": ["success+test3@simulator.amazonses.com","success+test4@simulator.amazonses.com"]
  }
  
}
</pre>

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if has invalid value in request body or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Delete Custom Report
------------------
* `DELETE /Report/{CustomReportID}` will delete the specific custom report.

###### Response
A successful `DELETE` will result in a HTTP 204 No Content Response.

A failed `DELETE` may result in a HTTP 400 Bad Request Response if the specified custom report does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `DELETE` may result in a HTTP 401 Unauthorized Response if the authorization is failed.

Manual Execute Custom Report
------------------
* `POST /Report/{CustomReportID}/Execute` Will manually tells a custom report to run immediately, outside of the normal frequency window.

###### Request
<b>NOTE:</b> For this API, the request body is optional, if passing a custom report object when call this API, then PF will use the new custom report info when executing custom report, but the specific custom report will still keep the original data. If call this API without passing request body, then PayFabric will execute the custom report with the specific custom report data.
<pre>
{
  "Name":"test2",
  "Frequency": "weekly",

  "AdditionalFields": ["Email","Currency"],
  "TransactionTypes":  ["Sale","Capture"],
  "TransactionStatus":  ["Approved","Approved"],
 
 "Recipients": {
    "To":["success+test1@simulator.amazonses.com","success+test2@simulator.amazonses.com"],
    "BCC": ["success+test3@simulator.amazonses.com","success+test4@simulator.amazonses.com"]
  }
  
}
</pre>
###### Response
A successful `POST` will result in a HTTP 204 No Content Response.

A failed `POST` may result in a HTTP 400 Bad Request Response if the specified custom report does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `POST` may result in a HTTP 401 Unauthorized Response if the authorization is failed.


