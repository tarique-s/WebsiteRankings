Application Info

The Application is built using 
•	AngularJS
•	ASP.Net Core MVC / Web API 1.1
•	EntityFramework Core 1.1
•	Visual Studio 2017
•	SQL Server Azure

Deployment

The application is already deployed on Azure as 2 separate apps.
•	The Web App can be accessed at https://websiterankingapp.azurewebsites.net/index.html 
•	The Web Api is deployed at https://wsrankingapi.azurewebsites.net/api
(e.g. Api calls https://wsrankingapi.azurewebsites.net/api/websites/2016-01-06/5 , https://wsrankingapi.azurewebsites.net/api/visitDates )
 
They can be deployed to Azure from Visual Studio 2017 using VS 2017’s Publish to Azure tooling. 
Alternatively, we could write an Azure PowerShell script to deploy it Azure. This script has the added benefit of being able to automate the Deployment Process that is essential in a Dev Ops structure. 

Additional Info
1.	Cloud Native App: I think the application has been created as Cloud Native App. 
The Web App is written purely as an AngularJS application (hosted on Azure App Service) which communicates with a Back-End Web API to get data. 
The Back-End Web API is written using .Net Core and is hosted as another App on Azure App Services. It is stateless and can easily scale with fluctuating demand. As .Net Core is cross platform, it could easily be hosted on Linux based containers like Docker. It is already a Micro Service. 
The Database used is Sql Server Azure, which is hosted on the cloud, and is secured so that only the Backend Web API can access it. 

2.	

3.	We could add a parameter to change the number of Top N websites shown. The Back End Web API takes a parameter, which has been hardcoded to five, to return the number of websites. We could add a control to the Web App and this could be passed on to the Back End Web Api. 

4.	The Web Application as well as the Back End Web API are available online at the above URL’s (they are hosted on Azure.)
5.	Some of the improvements that can be done are 
a.	Add OAuth security to the Back End Web API
b.	Add Authentication to the Web App
