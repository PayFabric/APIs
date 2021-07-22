
JSON Web Tokens
===============

The PayFabric JSON Web Tokens API is used to authentication for the new mobile hosted payment page. Please note that all requests require API authentication, see our [guide](Authentication.md) on how to authenticate.

These JWT's are intended to be used to indicate your `Payment Intent`.

Create JSON Web Tokens
---------------------------

* `POST /payment/api/jwt/create` will create the jwt token
###### Request
<pre>
{
	<b>"Audience"</b>:"PaymentPage",
	<b>"Subject"</b>:"HPP21040500682801"
}
</pre>
###### Response
<pre>
{
    "Message": "",
    "Payload": {
        "aud": "PaymentPage",
        "dcn": "1",
        "device": "72972a2b-8a71-4e29-aeab-1c418b136869",
        "exp": "1617688157",
        "iat": "1617687257",
        "inst": "f242bd6d-7a23-41d7-a12e-46427ce4eba4",
        "iss": "PayFabric_V3",
        "sub": "HPP21040500682801",
        "supportedPaymentMethods": [
            {
                "attributes": null,
                "src": "URL",
                "type": "CreditCard"
            },
            {
                "attributes": null,
                "src": "URL",
                "type": "ECheck"
            },
            {
                "attributes": [
                    {
                        "key": "data-partner-attribution-id",
                        "value": "Nodus_SP_PPCP"
                    }
                ],
                "src": "https:\/\/www.paypal.com\/sdk\/js?client-id=AfGQA1jQrGwqYSqbrN6M0ZnXwvDZNVKaXlNvI8VYbmb14vFWrF5CQtgw-O6xvz6n7sLtmvWJ0s0A5uW3&merchant-id=Q3E49R5X48QLG&enable-funding=venmo&disable-funding=paylater,card&currency=USD&integration-date=2021-03-16",
                "type": "PAYPAL"
            }
        ]
    },
    "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJQYXlGYWJyaWNfVjMiLCJpYXQiOiIxNjE3Njg3MjU3IiwiZXhwIjoiMTYxNzY4ODE1NyIsImF1ZCI6IlBheW1lbnRQYWdlIiwic3ViIjoiSFBQMjEwNDA1MDA2ODI4MDEiLCJpbnN0IjoiZjI0MmJkNmQtN2EyMy00MWQ3LWExMmUtNDY0MjdjZTRlYmE0IiwiZGV2aWNlIjoiNzI5NzJhMmItOGE3MS00ZTI5LWFlYWItMWM0MThiMTM2ODY5IiwiZGNuIjoiMSIsInN1cHBvcnRlZFBheW1lbnRNZXRob2RzIjpbeyJ0eXBlIjoiQ3JlZGl0Q2FyZCIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IkVDaGVjayIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IlBBWVBBTCIsInNyYyI6Imh0dHBzOi8vd3d3LnBheXBhbC5jb20vc2RrL2pzP2NsaWVudC1pZD1BZkdRQTFqUXJHd3FZU3Fick42TTBablh3dkRaTlZLYVhsTnZJOFZZYm1iMTR2RldyRjVDUXRndy1PNnh2ejZuN3NMdG12V0owczBBNXVXMyZtZXJjaGFudC1pZD1RM0U0OVI1WDQ4UUxHJmVuYWJsZS1mdW5kaW5nPXZlbm1vJmRpc2FibGUtZnVuZGluZz1wYXlsYXRlcixjYXJkJmN1cnJlbmN5PVVTRCZpbnRlZ3JhdGlvbi1kYXRlPTIwMjEtMDMtMTYiLCJhdHRyaWJ1dGVzIjpbeyJrZXkiOiJkYXRhLXBhcnRuZXItYXR0cmlidXRpb24taWQiLCJ2YWx1ZSI6Ik5vZHVzX1NQX1BQQ1AifV19XX0.grPRlquWaPWiySm6oaOLXTbQnLzM3Dz2JUtYF0pcno4"
}
</pre>

Please note that **bold** fields are required fields, in this API, the two fields are all required. For more information and descriptions on available fields please see our [object reference](Objects.md#json-web-tokens).

Validate JSON Web Tokens
---------------------------

* `POST /payment/api/jwt/validate` can check the JWT valid or not.

###### Request
<pre>
{
	"Token":"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJQYXlGYWJyaWNfVjMiLCJpYXQiOiIxNjE3Njg3MjU3IiwiZXhwIjoiMTYxNzY4ODE1NyIsImF1ZCI6IlBheW1lbnRQYWdlIiwic3ViIjoiSFBQMjEwNDA1MDA2ODI4MDEiLCJpbnN0IjoiZjI0MmJkNmQtN2EyMy00MWQ3LWExMmUtNDY0MjdjZTRlYmE0IiwiZGV2aWNlIjoiNzI5NzJhMmItOGE3MS00ZTI5LWFlYWItMWM0MThiMTM2ODY5IiwiZGNuIjoiMSIsInN1cHBvcnRlZFBheW1lbnRNZXRob2RzIjpbeyJ0eXBlIjoiQ3JlZGl0Q2FyZCIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IkVDaGVjayIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IlBBWVBBTCIsInNyYyI6Imh0dHBzOi8vd3d3LnBheXBhbC5jb20vc2RrL2pzP2NsaWVudC1pZD1BZkdRQTFqUXJHd3FZU3Fick42TTBablh3dkRaTlZLYVhsTnZJOFZZYm1iMTR2RldyRjVDUXRndy1PNnh2ejZuN3NMdG12V0owczBBNXVXMyZtZXJjaGFudC1pZD1RM0U0OVI1WDQ4UUxHJmVuYWJsZS1mdW5kaW5nPXZlbm1vJmRpc2FibGUtZnVuZGluZz1wYXlsYXRlcixjYXJkJmN1cnJlbmN5PVVTRCZpbnRlZ3JhdGlvbi1kYXRlPTIwMjEtMDMtMTYiLCJhdHRyaWJ1dGVzIjpbeyJrZXkiOiJkYXRhLXBhcnRuZXItYXR0cmlidXRpb24taWQiLCJ2YWx1ZSI6Ik5vZHVzX1NQX1BQQ1AifV19XX0.grPRlquWaPWiySm6oaOLXTbQnLzM3Dz2JUtYF0pcno4"
}
</pre>
 
###### Response For a Valid JWT
<pre>
{
    "Message": null,
    "Payload": {
        "aud": "PaymentPage",
        "dcn": "1",
        "device": "72972a2b-8a71-4e29-aeab-1c418b136869",
        "exp": "1617689798",
        "iat": "1617688898",
        "inst": "f242bd6d-7a23-41d7-a12e-46427ce4eba4",
        "iss": "PayFabric_V3",
        "sub": "HPP21040500682801",
        "supportedPaymentMethods": [
            {
                "attributes": null,
                "src": "URL",
                "type": "CreditCard"
            },
            {
                "attributes": null,
                "src": "URL",
                "type": "ECheck"
            },
            {
                "attributes": [
                    {
                        "key": "data-partner-attribution-id",
                        "value": "Nodus_SP_PPCP"
                    }
                ],
                "src": "https:\/\/www.paypal.com\/sdk\/js?client-id=AfGQA1jQrGwqYSqbrN6M0ZnXwvDZNVKaXlNvI8VYbmb14vFWrF5CQtgw-O6xvz6n7sLtmvWJ0s0A5uW3&merchant-id=Q3E49R5X48QLG&enable-funding=venmo&disable-funding=paylater,card&currency=USD&integration-date=2021-03-16",
                "type": "PAYPAL"
            }
        ]
    },
    "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJQYXlGYWJyaWNfVjMiLCJpYXQiOiIxNjE3Njg4ODk4IiwiZXhwIjoiMTYxNzY4OTc5OCIsImF1ZCI6IlBheW1lbnRQYWdlIiwic3ViIjoiSFBQMjEwNDA1MDA2ODI4MDEiLCJpbnN0IjoiZjI0MmJkNmQtN2EyMy00MWQ3LWExMmUtNDY0MjdjZTRlYmE0IiwiZGV2aWNlIjoiNzI5NzJhMmItOGE3MS00ZTI5LWFlYWItMWM0MThiMTM2ODY5IiwiZGNuIjoiMSIsInN1cHBvcnRlZFBheW1lbnRNZXRob2RzIjpbeyJ0eXBlIjoiQ3JlZGl0Q2FyZCIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IkVDaGVjayIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IlBBWVBBTCIsInNyYyI6Imh0dHBzOi8vd3d3LnBheXBhbC5jb20vc2RrL2pzP2NsaWVudC1pZD1BZkdRQTFqUXJHd3FZU3Fick42TTBablh3dkRaTlZLYVhsTnZJOFZZYm1iMTR2RldyRjVDUXRndy1PNnh2ejZuN3NMdG12V0owczBBNXVXMyZtZXJjaGFudC1pZD1RM0U0OVI1WDQ4UUxHJmVuYWJsZS1mdW5kaW5nPXZlbm1vJmRpc2FibGUtZnVuZGluZz1wYXlsYXRlcixjYXJkJmN1cnJlbmN5PVVTRCZpbnRlZ3JhdGlvbi1kYXRlPTIwMjEtMDMtMTYiLCJhdHRyaWJ1dGVzIjpbeyJrZXkiOiJkYXRhLXBhcnRuZXItYXR0cmlidXRpb24taWQiLCJ2YWx1ZSI6Ik5vZHVzX1NQX1BQQ1AifV19XX0.jYmTSkHVDvmQs5bNyfrDUy7Y9iSELUHo92FqsVCp5VA",
    "Valid": true
}
</pre>

###### Response for an expired JWT
<pre>
{
    "Message": "JWT token has expired.",
    "Payload": null,
    "Token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJQYXlGYWJyaWNfVjMiLCJpYXQiOiIxNjE3Njg3MjU3IiwiZXhwIjoiMTYxNzY4ODE1NyIsImF1ZCI6IlBheW1lbnRQYWdlIiwic3ViIjoiSFBQMjEwNDA1MDA2ODI4MDEiLCJpbnN0IjoiZjI0MmJkNmQtN2EyMy00MWQ3LWExMmUtNDY0MjdjZTRlYmE0IiwiZGV2aWNlIjoiNzI5NzJhMmItOGE3MS00ZTI5LWFlYWItMWM0MThiMTM2ODY5IiwiZGNuIjoiMSIsInN1cHBvcnRlZFBheW1lbnRNZXRob2RzIjpbeyJ0eXBlIjoiQ3JlZGl0Q2FyZCIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IkVDaGVjayIsInNyYyI6IlVSTCIsImF0dHJpYnV0ZXMiOm51bGx9LHsidHlwZSI6IlBBWVBBTCIsInNyYyI6Imh0dHBzOi8vd3d3LnBheXBhbC5jb20vc2RrL2pzP2NsaWVudC1pZD1BZkdRQTFqUXJHd3FZU3Fick42TTBablh3dkRaTlZLYVhsTnZJOFZZYm1iMTR2RldyRjVDUXRndy1PNnh2ejZuN3NMdG12V0owczBBNXVXMyZtZXJjaGFudC1pZD1RM0U0OVI1WDQ4UUxHJmVuYWJsZS1mdW5kaW5nPXZlbm1vJmRpc2FibGUtZnVuZGluZz1wYXlsYXRlcixjYXJkJmN1cnJlbmN5PVVTRCZpbnRlZ3JhdGlvbi1kYXRlPTIwMjEtMDMtMTYiLCJhdHRyaWJ1dGVzIjpbeyJrZXkiOiJkYXRhLXBhcnRuZXItYXR0cmlidXRpb24taWQiLCJ2YWx1ZSI6Ik5vZHVzX1NQX1BQQ1AifV19XX0.grPRlquWaPWiySm6oaOLXTbQnLzM3Dz2JUtYF0pcno4",
    "Valid": false
}
</pre>

