# PierresTreats

![image](/PierresTreats/wwwroot/img/ltr0yebw.bmp)

#### A C# application built with ASP.NET Core, Entity to integrate MySQL databases, and Identity for authentication/authorization

#### By William Jameson

## Technologies Used

* _C#_
* _HTML_
* _CSS_
* _MySQL_

### Dependencies

* _Entity_
* _Identity_
* _Bootstrap_
* _ASP.NET Core_

## Description

_This C# web application lets a user create a list of treats and flavors for their bakery, as well as associate a flavor with a treat. MYSQL is used to create a database structured for a Many-To-Many relationship. From the splash page, the user is able to view all treats and flavors objects in the database. User can also create, view, edit, and delete each of these types of objects, provided that they are logged in. Using Entity and LINQ , user form inputs are passed to mySQL database tables, and conventional RESTful routes are used. This application is meant to showcase Many-To-Many database relationships in connecting an ASP.NET Core web framework with mySQL databases using Entity, as well as handle authorization/authentication with Identity._

### Database Table Structure

![image](/PierresTreats/wwwroot/img/chrome_t8PuXie7oa.png)

## Setup/Installation Requirements

#### To Install MySQL & MySQL Workbench

* _go to https://dev.mysql.com/downloads/ and install **MySQL Community Server** and **MySQL Workbench** for your operating system_
* _follow the instructions at [learnhowtoprogram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for proper installation_

#### To Set Up Project With Dependencies

* _clone repository from https://github.com/wcjameson/PierresTreats
* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory PierresTreats and enter ```dotnet restore``` to install project dependencies_

#### To Create appsettings.json

* _navigate to the subdirectory PierresTreats and create the file ```appsettings.json```_
* _add the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE];uid=[YOUR_USER_ID];pwd=[YOUR_PASSWORD];"
  }
}
```
* _replace the applicable sections with your database name, your user ID, and your password_

#### To Create Database using Migrations

* _navigate to the project directory in your terminal/command line_
* _navigate to the subdirectory PierresTreats and enter ```dotnet ef database update``` to create a new local database for the project_
* _the database will take the name specified in your ```appsettings.json``` file and can be viewed using MySQL_

#### To Run the Web Application

* _navigate to the subdirectory PierresTreats and enter ```dotnet run``` for a snapshot server or ```dotnet watch run``` for a live updating server for the application_
* _access the server in your browser by entering ```localhost:5000``` into your navigation bar_
* _click the hyperlinks and submit forms to navigate between the views_
* _enter ```ctrl``` + ```c``` for Windows or ```command``` + ```.``` for Mac in your terminal/command line to stop the server_

## Known Bugs

* _None_

## License

_MIT License_

Copyright (c) _2022_ _William Jameson_ 

## Contact Information

williamjameson90@gmail.com