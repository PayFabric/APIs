Payment Terminal
-----------------
The PayFabric Payment Terminal APIs are used for managing EMV terminal device and EMV configurations. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate. Please refer the [Payment Terminal Object](/PayFabric/Sections/3.1JSONObjects.md#terminal-setting) for details. 

Get Registered Terminals
---------------------
* `GET /payment/3.1/api/Terminal`  will get all terminals. 

###### Response
<pre>
[
    {
        "ID": "4db29b24-89ae-4159-8412-0bccaea75b90",
        "Name": "A60",
        "SerialNumber": "",
        "Type": "PAX Generic"
    },
    {
        "ID": "b966d05b-0fb1-47c3-ad20-4a317c35606f",
        "Name": "EMV US",
        "SerialNumber": "53135730",
        "Type": "PAX Generic"
    },   
    {
        "ID": "ccc0fb76-4a75-4ffa-b807-dbad8a4631c3",
        "Name": "53095196 IP",
        "SerialNumber": "fdadsfad",
        "Type": "PAX Generic"
    }
]
</pre>

Create new Registered Terminal
---------------------
* `POST /payment/3.1/api/Terminal` will create a new registered terminal.

###### Request
<pre>
{
  "Name": "Test123",
  "SerialNumber": "143456789",
  "Type": "PAX Generic"
}
</pre>

###### Response
<pre>
{
    "ID": "d9669213-6e21-464f-9f30-0ecc6a78227a",
    "Name": "Test123",
    "SerialNumber": "143456789",
    "Type": "PAX Generic"
}
</pre>

Update Registered Terminal
------------------------------
* `PATCH /payment/3.1/api/Terminal/{TerminalID}` will update specific registered terminal.
###### Request
<pre>
{  
    "Name": "Test123",
    "SerialNumber": "143456789",
    "Type": "PAX Generic"
}
</pre>   
###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the specified terminal does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Remove Registered Terminal
------------------------------
* `DELETE /payment/3.1/api/Terminal/{TerminalID}` will delete specific registered terminal.

###### Response
A successful `DELETE` will result in a HTTP 204 No Content Response.

A failed `DELETE` may result in a HTTP 400 Bad Request Response if the specified theme does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `DELETE` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Get Terminal Settings
---------------------
* `GET /payment/3.1/api/Terminal/Settings/{DeviceId}` will return the terminal settings for specific device.

{
    "Terminals": [
        "9d606d68-445d-4224-95d8-6039a5aa7d23",
        "fe49bd04-1e32-4842-ade8-81c118abc828"
    ],
    "DefaultTerminal": "fe49bd04-1e32-4842-ade8-81c118abc828",
    "AllowedProcessingMethod": 2,
    "DefaultProcessingMethod": 1,
    "LockTerminalSelection": true,
    "RequireSignature": true
}

Update Terminal Settings
----------------------
* `PATCH /payment/3.1/api/Terminal/Settings/{DeviceId}` will update the terminal settings for specific device.
###### Request
<pre>
{    
    "DefaultTerminal": "9d606d68-445d-4224-95d8-6039a5aa7d23",
    "AllowedProcessingMethod": 2,
    "DefaultProcessingMethod": 1,
    "LockTerminalSelection": false,
    "RequireSignature": false
}
</pre>

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the request body has invalid value or unexists value or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.
