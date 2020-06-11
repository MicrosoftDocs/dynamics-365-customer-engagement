---
title: "Export and import Omnichannel Administration app data | MicrosoftDocs"
description: "Export and import Omnichannel Administration app data from a source organization to another organization"
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/11/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Export and import Omnichannel Administration app data

Now that you have used Omnichannel for Customer Service in a test environment, you're ready to unlock all the benefits and features in a live production environment (or any target environment). You don't have to start all over. Instead, you can follow this process to export your Omnichannel Administration app configuration data from your test environment and import the data into your new target environment. That way, you can keep all of the queues, routing rules, work streams, and other custom settings that you set up the first time.

To export and import your Omnichannel Administration app configuration data, install the following apps of same version in both the source and target environments:

- The Omnichannel for Customer Service Administration app
- Any third-party solutions you plan to integrate, such as ScreenMeet
  
> [!NOTE]
> The following processes don't help with the export and import of users, so you must add them to the target environment after you have imported the configuration data.

## Export configuration data using the Configuration Migration tool

You can export the configuration data from your source system by using the Omnichannel Administration app configuration data schema file.

1. Download the Configuration Migration tool. Use the [PowerShell script](https://docs.microsoft.com/powerapps/developer/common-data-service/download-tools-nuget#download-tools-using-powershell) to download the latest version of the tool.  

2. Create a schema file per Omnichannel Solution following the steps in [Create a schema to export configuration data](https://docs.microsoft.com/power-platform/admin/create-schema-export-configuration-data).

3. Select the entities and fields that you want to export and import. The entities that you choose to export and import depend on the resources that you want to reuse across the source and target organizations. (Example: If you use the same API keys and provider for your geolocation provider, then you can include that entity too.)

    These are some of the core entities you can use, but you are not limited to only these entities:

    -  Work stream
    -  Context variable
    -  Rule item
    -  Queue
    -  Quick reply
    -  Presence
    -  Operating hours
    -  Sentiment analysis

4. In order to filter for only the Omnichannel for Customer Service queues, you can use the following commands:  
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
5. Double-click the DataMigrationUtility.exe file to run the Configuration Migration tool, and choose **Export data** in the main screen.

6. On the **Login** screen, provide authentication details to connect to your Dynamics 365 Server instance from where you want to export data. If you have multiple organizations on the Common Data Service platform server, and want to select the organization from where to export the data, select the **Always display list of available orgs checkbox**. Select **Login**.

7. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select the Common Data Service platform organization to connect to.

8. Specify the name and location of the data file to be exported.

9. Choose **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the page after the export is complete.

10. Choose **Exit** to close the tool.

## Import configuration data using the Configuration Migration tool 

1. Run the Configuration Migration tool, and click **Import data** on the main screen. For information about downloading the tool, see step 1 in the previous section.

2. On the **Login** screen, provide authentication details to connect to your Common Data Service platform server from where you want to import data. If you have multiple organizations on the Common Data Service platform server, and want to select the organization from where you want to import the data, select the **Always display list of available orgs** checkbox. Click **Login**. 

3. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select the Common Data Service platform organization to connect to. 

4. The next screen prompts you to provide the data file (.zip) to be imported. Browse to the data file, select it, and then click **Import Data**.

5. The next screen displays the import status of your records. The data import is done in multiple passes,foundation data is imported first, while the dependent data is queuing up, and then the dependent data is imported in the subsequent passes to handle any data dependencies or linkages. This ensures clean and consistent data import.

6. Click **Exit** to close the tool.

## Test the export or import

To check and compare records between the source and target environment:

1. Using [advanced find](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/basics/save-advanced-find-search), select all fields of the entities you previously exported and imported.

2. Spot-check the data in several of the records.

To check the functionality on your target environment:

1. Create users, assign them Omnichannel for Customer Service roles, and add them to queues.

2. Add default presence and capacity to the users.

3. Create a live chat widget.

4. Test a scenario in live chat.

## Export and import related artifacts

For entity routing, follow the instructions to [Export and import your flows across environments with packaging](https://flow.microsoft.com/blog/import-export-bap-packages/).

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Enable third-party co-browse and screen sharing](../developer/how-to/third-party-co-browse.md)  
[Overview of channels](channels.md)  
