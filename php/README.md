# README
A simple PayFabric REST client, in PHP. This sample code is intended as a 
starting point for your own projects. We kept it lightweight so that you
could get the general idea of how to interact with PayFabric via PHP. 
You are free to take the source and add logging, exception handling, etc. 
as you see fit. If you think your changes would be beneficial to the general
PayFabric community you are welcome to submit pull requests on this repository!

## Installation
Set DEVICE\_ID and DEVICE\_PASSWORD in Constants.php to your application's Device ID
and Device Password. 

BASE\_URL in Constants.php is set to the base URL of the PayFabric sandbox environment.
When you want to go live, change BASE\_URL to the base URL of the PayFabric production
environment.

Install PHP's cURL library. cURL is used to execute HTTP requests. To install from 
the command line of an Ubuntu server:
```bash
$ sudo apt-get install php5-curl 
```

Include this directory in your PHP project, and then include each of the classes
which you would like to use in your source code.

```php
<?php 

require_once "/path/to/this/directory/Transaction.php"

$customer = new Customer($customerId);
...
```

## Usage
Check out the samples directory for examples on using the classes and performing
common tasks.

If you want to try out any of the classes, it's relatively easy to create small
scripts and execute them from the command line. Suppose that you create a file
called "test.php", and enter the following:
```php
<?php

require_once "Token.php"; // Assuming your script file is in the same directory as Token.php.

var_dump(Token::get());
```
To execute "test.php" from the command line:
```bash
$ php -f test.php
```

## Authors
Kayce Basques - kayce@basqu.es
