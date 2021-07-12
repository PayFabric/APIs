Theme
=================

The PayFabric theme APIs are used for managing PayFabric themes.  Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

Get Themes
----------
* `GET /Theme`  will get all themes. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

###### Response
<pre>
[
    {
        "ThemeId": "63757d18-2c2d-46b9-b031-0e10c4a25ff0",
        "Name": "test",
        "CSS": "",
        "JS": "alert(1)",
        "Parameters": []
    },
    {
        "ThemeId": "78d90734-84d6-4387-9511-727591188fe9",
        "Name": "d",
        "CSS": "",
        "JS": "alert(2)",
        "Parameters": [
            "NOBATCH",
            "NOSETUPID",
            "NOBILLTO",
            "NOSHIPTO",
            "NOHISTORYCARD",
            "NOPAYLATER"
        ]
    },
    {
        "ThemeId": "bcebc047-7674-4a36-8d8f-861bc91f3abc",
        "Name": "Virtual Terminal",
        "CSS": "",
        "JS": "",
        "Parameters": []
    }
]
</pre>

Create Theme
-------------
* `POST /Theme` will create a theme. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

###### Request
<pre>
{
    "Name": "abc",
    "CSS": "body{background-color:pink;}",
    "JS": "alert(123)",
    "Parameters": [
        "NOBATCH",
        "NOSETUPID",
        "NOBILLTO",
        "NOSHIPTO",
        "NOHISTORYCARD",
        "NOPAYLATER"
    ]
}
</pre>

###### Response
<pre>
{
    "ThemeId": "573028d6-d5a3-4318-beaa-a7df223ef08f",
    "Name": "abc",
    "CSS": "body{background-color:pink;}",
    "JS": "alert(123)",
    "Parameters": [
        "NOBATCH",
        "NOSETUPID",
        "NOBILLTO",
        "NOSHIPTO",
        "NOHISTORYCARD",
        "NOPAYLATER"
    ]
}
</pre>

Update Theme
-------------
* `PATCH /Theme/{ThemeId}` will update a theme.Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

###### Request
<pre>
{
    "Name": "abc",
    "CSS": "body{background-color:pink;}",
    "JS": "alert(123)",
    "Parameters": [
        "NOBATCH",
        "NOSETUPID",
        "NOBILLTO",
        "NOSHIPTO",
        "NOHISTORYCARD",
        "NOPAYLATER"
    ]
}
</pre>

###### Response
A successful `PATCH` will result in a HTTP 204 No Content Response.

A failed `PATCH` may result in a HTTP 400 Bad Request Response if the specified theme does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `PATCH` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.

Delete Theme
-------------
* `DELETE /Theme/{ThemeId}` will delete a theme.Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

###### Response
A successful `DELETE` will result in a HTTP 204 No Content Response.

A failed `DELETE` may result in a HTTP 400 Bad Request Response if the specified theme does not exist or the Device ID used for the Security Token does not match or post failed.

A failed `DELETE` may result in a HTTP 401 Unauthorized Response if the authorization is wrong.
