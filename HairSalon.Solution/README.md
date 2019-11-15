# _Bakery Tracker_

#### _MVC application to track hairstylists and clients._

#### By _**Carrie Schmid**_

## Description

_A user can add and track staff, track clients by hairstylist._

## Setup/Installation Requirements

_download and open browser_

Using MySQL:
> CREATE DATABASE first_last;
> USE first_last;
> CREATE TABLE clients (ClientsId PRIMARY KEY, FirstName VARCHAR(255), LastName VARCHAR(255), StylistsId INT(11));
> CREATE TABLE stylists (StylistsId PRIMARY KEY, FirstName VARCHAR(255), LastName VARCHAR(255), Specialty VARCHAR(255));

## Known Bugs

_none_


## Specs
|Behavior| Input | Output|
|:-|:-|:-|
|Enter name of new hairsylist and their specialty| Maggie Smith, highlights| See new hairstylist added to a list of all the sylists|
|Enter new client item with name and phone number| John Cox, 503-459-2859  | John Cox/Maggie Smith|


## Support and contact details


_Carrie Schmid: carriepederson7@gmail.com_

## Technologies Used

_C#_

### License

*MIT Liscence*

Copyright (c) 2019 **_Carrie Schmid_**
