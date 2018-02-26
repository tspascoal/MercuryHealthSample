# Introduction 

Sample code for Mercury Health.

Mercury Health is a ASP.Net MVC application to track health habits and uses MS Sql Server as the database backend.
The solution has code and automated tests (unit, UI and load tests)

The solution has the following projects

* **MercuryHealth.Web** The web application
* **MercuryHealth.Sql** [database project](https://www.visualstudio.com/vs/ssdt/) used to maintain and deploy the database.
* **MercuryHealth.Models** The models used in the web project
* **MercuryHealth.UnitTests** 
* **MercuryHealth.AutomatedTest** Automated UI tests using selenium (can run tests in IE, Chrome, Firefox, Edge, chrome less Chrome and chrome less FireFox )
* **MercuryHealth.Web.PerfTests**
* **MercuryHealth.LoadTests** 

# Getting Started

1. Open the solution file using Visual Studio
1. Build
1. Run Unit Tests
1. Deploy Database
1. Run application

Some unit tests require Visual Studio Enterprise since they use [Microsoft Fakes](https://msdn.microsoft.com/en-us/library/hh549175.aspx) framework

