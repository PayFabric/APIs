Handling Exceptions
===================
PayFabric Receivables uses HTTP response codes to indicate the completion status of requests. Below is a description of the meanings of the most common response codes that you will encounter. In general, status codes in the range of 200 to 299 indicate success. 400 to 499 indicate that the client has made a mistake. 500 and beyond indicate that PayFabric Receivables experienced an error. 

| Code        | Description | 
| ------------- | :------------- | 
| 200 OK | Request Successful | 
| 400 Bad Request | The request is missing required information. Verify that you are accessing the correct URL (including all query string parameters). If sending a JSON payload, check that you have provided all required elements, and make sure that there are no typos in your element names (JSON elements are case-sensitive!) |
| 401 Unauthorized | The authorization header with the authentication token is invalid or revoked |  
| 404 Not Found | The requested resource could not be located. Check for typos in your URL |  
| 412 Precondition Failed | Missing fields or mandatory parameters. See description of status code 400 |  
| 500 Internal Server Error| PayFabric Receivables has encountered an error |
