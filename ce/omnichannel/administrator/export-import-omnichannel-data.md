---
title: "Export and import Omnichannel Administration app data | MicrosoftDocs"
description: "Export and import Omnichannel Administration app data from a source organization to another organization"
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/10/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Export and import Omnichannel Administration app data

Now that you have used Omnichannel for Customer Service in a test environment, you're ready to unlock all the benefits and features in a live production environment (or any target environment). You don't have to start all over. Instead, you can follow this process to export your Omnichannel Administration app configuration data from your test environment and import the data into your new target environment. That way, you can keep all of the queues, routing rules, work streams, and other custom settings that you set up the first time. 

To import and export your Omnichannel configuration data, you must first install the following on both the source and target environments, and make sure that the versions are the same:

  - The Omnichannel for Customer Service Administration app 
  - Any third-party solutions you plan to integrate, such as Screenmeet
  
> [!NOTE]
> The following processes do not export and import users, so you must add them to the target environment after you have imported the configuration data.

## Export configuration data using the Configuration Migration tool 

You can export your Omnichannel configuration data from your source system by using the Omnichannel configuration data schema file. 

1. Download the Configuration Migration tool. For information on downloading the Configuration Migration tool, see [Download tools from NuGet](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/download-tools-nuget).  

  > [!NOTE]
  > Use the PowerShell script in the link to download the latest version of the tool.

2. Download and extract the tool, and then find the tool in the \Tools\ConfigurationMigration folder. 

3. Create a schema file per Omnichannel Solution following the steps in [Create a schema to export configuration data](https://docs.microsoft.com/en-us/power-platform/admin/create-schema-export-configuration-data).

4. Choose the entities and fields that you want to export and import. The entities that you choose to export and import depend on the resources that you want to reuse across the source and target organizations. (Example: If you use the same API keys and provider for your geolocation provider, then you can include that entity too.) 

These are some of the core entities you can use, but you are not limited to only these entities:

    - Work stream 
    - Context variable 
    - Rule item 
    - Queue 
    - Quick reply 
    - Presence 
    - Operating hours 
    - Sentiment analysis 

5. In order to filter for only the Omnichannel queues, you can use the following commands:  
    **Tools > Configure Import Settings > Use Fetch XML to filter records > Edit FetchXML**

  ```html
  <fetch> 
    <entity name="queue" > 
      <filter> 
        <condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" /> 
      </filter> 
    </entity> 
  </fetch> 
  ```

6. Double-click the DataMigrationUtility.exe file in the \Tools\ConfigurationMigration folder to run the Configuration Migration tool, and choose **Export data** in the main screen. 

7. On the **Login** screen, provide authentication details to connect to your Dynamics 365 Server from where you want to export data. If you have multiple organizations on the Common Data Service platform server, and want to select the organization from where to export the data, select the **Always display list of available orgs checkbox**. Select **Login**. 

8. If you have multiple organizations, and you selected the Always display list of available orgs check box, the next screen lets you choose the organization that you want to connect to. Select the Common Data Service platform organization to connect to. 

9. On the next screen, select the Omnichannel configuration data schema file (OmnichannelBaseSchema.xml) to be used for the data export. 

10. Specify the name and location of the data file to be exported. 

11. Choose **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the screen once the export is complete. 

12. Choose **Exit** to close the tool. 

## Import configuration data using the Configuration Migration tool 

1. Run the Configuration Migration tool, and click **Import data** in the main screen. For information about the downloading the tool, see step 1 in the previous section.

2. On the **Login** screen, provide authentication details to connect to your Common Data Service platform server from where you want to import data. If you have multiple organizations on the Common Data Service platform server, and want to select the organization to where you want to export the data, select the **Always display list of available orgs** checkbox. Click **Login**. 

3. If you have multiple organizations, and you selected the **Always display list of available orgs** checkbox, the next screen lets you choose the organization that you want to connect to. Select the Common Data Service platform organization to connect to. 

4. The next screen prompts you to provide the data file (.zip) to be imported. Browse to the data file, select it, and then click **Import Data**. 

5. The next screen displays the import status of your records. The data import is done in multiple passes to first import the foundation data while queuing up the dependent data, and then import the dependent data in the subsequent passes to handle any data dependencies or linkages. This ensures clean and consistent data import. 

6. Click **Exit** to close the tool. 

## Test the migration

To check and compare records between the source and target environment:

1. Using [advanced find](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/basics/save-advanced-find-search), select all fields of the entities you previously exported and imported.

2. Spot-check the data in several of the records. 

To check the functionality on your target environment: 

1. Create users, assign them Omnichannel roles, and add them to queues. 

2. Add default presence and capacity to the users. 

3. Create a Live Chat Widget.

4. Test a scenario in Live Chat.

## Export and import related artifacts

For entity routing, follow the instructions to [Export and import your flows across environments with packaging](https://flow.microsoft.com/en-us/blog/import-export-bap-packages/).


## See also

- [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)
- [Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)
- [Enable third-party co-browse and screen sharing](../developer/how-to/third-party-co-browse.md)
- [Overview of channels](channels.md)
