---
title: "Export and import Omnichannel Administration app data | MicrosoftDocs"
description: "Export and import Omnichannel Administration app data from a source organization to another organization"
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 05/28/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Export and import Omnichannel Administration app data

Now that you have used Omnichannel for Customer Service in a test environment, you're ready to unlock all the benefits and features in a live production environment. You don't have to start all over. Instead, you can follow this process to export your Omnichannel Administration app configuration data from your test environment and import the data into your new target environment. That way, you can keep all of the users, queues, and work streams that you set up the first time. 

## Export configuration data using the Configuration Migration tool 

You can export your Omnichannel configuration data from your source system by using the Omnichannel configuration data schema file. 

1. Download the Configuration Migration tool and the default Omnichannel configuration data schema file (OmnichannelBaseSchema.xml). For information on downloading the Configuration Migration tool, see [Download tools from NuGet](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/download-tools-nuget).  

2. Download and extract it, and then find the tool in the \Tools\ConfigurationMigration folder. 

3. Get the OmnichannelBaseSchema.xml file.

4. Double-click the DataMigrationUtility.exe file in the \Tools\ConfigurationMigration folder to run the Configuration Migration tool, and choose **Export data** in the main screen. 

5. On the Login screen, provide authentication details to connect to your Dynamics 365 Server from where you want to export data. If you have multiple organizations on the Common Data Service platform server, and want to select the organization from where to export the data, select the Always display list of available orgs check box. Select Login. 

6. If you have multiple organizations, and you selected the Always display list of available orgs check box, the next screen lets you choose the organization that you want to connect to. Select the Common Data Service platform organization to connect to. 

7. On the next screen, select the Omnichannel configuration data schema file (OmnichannelBaseSchema.xml) to be used for the data export. 

8. Specify the name and location of the data file to be exported. 

9. Choose Export Data. The screen displays the export progress status and the location of the exported file at the bottom of the screen once the export is complete. 

10. Choose Exit to close the tool. 
