# Develop Azure Compute Solutions - Azure Web Apps


## Create Web App

- Choose B1, disable Application insights
<img src="/pictures/create_web_app.png" title="create web app"  width="600">

- create local web app

- publish the web app
<img src="/pictures/publish_web_app.png" title="publish web app"  width="600">
<img src="/pictures/publish_web_app1.png" title="publish web app"  width="600">
<img src="/pictures/publish_web_app2.png" title="publish web app"  width="600">
<img src="/pictures/publish_web_app3.png" title="publish web app"  width="600">
<img src="/pictures/publish_web_app4.png" title="publish web app"  width="900">


## Create another Web App and link it to the same service plan

You can have multiple web apps running as part of the same **App Service Plan**.

- Choose the same as above
<img src="/pictures/create_second_web_app.png" title="create web app"  width="600">

- create another local web app

- publish the web app and choose the other web app
<img src="/pictures/publish_second_web_app.png" title="publish web app"  width="600">
<img src="/pictures/publish_second_web_app2.png" title="publish web app"  width="900">

- now you have two web apps linked to only one **App Service Plan**
<img src="/pictures/publish_second_web_app3.png" title="publish web app"  width="900">


## SQL Database and connection string

- Enable public endpoint, choose sql authentication
<img src="/pictures/create_sql_db.png" title="create sql database"  width="900">
<img src="/pictures/create_sql_db2.png" title="create sql database"  width="900">

- create MVC project
```
System.Data.SqlClient
```

- at the end, the app should connect to the SQL database and retrieve the data in it :
<img src="/pictures/create_sql_db3.png" title="create sql database"  width="900">

- create course web app and publish the course app to it :
<img src="/pictures/create_third_web_app.png" title="create web app"  width="900">

- the app should retrieve data as well :
<img src="/pictures/create_third_web_app2.png" title="create web app"  width="900">

So far, the connection string is stored in the app itself (app_settings). Now, let's store it in the web app itself.

- in the **Configuration** panel, add a connection string. In the appsettings.json file, remove the *ConnectionStrings* section. Publish again
<img src="/pictures/configuration.png" title="create web app"  width="900">

The app should be able to retrieve the data as well.

## Continuous Deployment

- create a new web app and allow continuous deployment :
<img src="/pictures/create_cd_web_app.png" title="create web app for continuous deployment"  width="600">

- on deployment center :
<img src="/pictures/deployment_center.png" title="deployment center"  width="600">

- create a new .NET Core Web App

## Logging

- in the *App Service Logs* section, set the following :
<img src="/pictures/logs.png" title="logs"  width="600">

- you can see the logs showing up in the *Log stream* section :
<img src="/pictures/logs2.png" title="logs"  width="900">

## App Configuration

- create an App Configuration :
<img src="/pictures/app_configuration.png" title="app configuration"  width="600">

### App Settings

- in the *Configuration Explorer* section, add a configuration for the database :
<img src="/pictures/configuration_explorer.png" title="configuration explorer"  width="900">

- create a web app and install nuget package :
```
Microsoft.Azure.AppConfiguration.AspNetCore
```

- in the *Access Keys* section of the *App Configuration*, grab the connection string of the primary key :
<img src="/pictures/app_configuration_access_keys.png" title="app configuration access keys"  width="900">

- you can now reference the settings in your code 
<img src="/pictures/app_configuration_access_keys2.png" title="app configuration access keys"  width="900">

