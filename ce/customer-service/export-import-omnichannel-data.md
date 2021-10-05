---
title: "Import and export app data | MicrosoftDocs"
description: "Learn to import and export app data from from a source to target environment in Omnichannel Administration and Omnichannel admin center apps."
ms.date: 10/05/2021
ms.topic: article
author: mh-jaya    
ms.author: v-jmh
manager: shujoshi
ms.reviewer: nenellim
---

# Import and export app data

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

Now that you have used Omnichannel for Customer Service in a test environment, you're ready to unlock all the benefits and features in a live production environment or any target environment; you don't have to start over. You can follow this process to export your Omnichannel Administration app configuration data from your test environment and import the data into your new target environment. That way, you can keep all of the queues, routing rules, workstreams, and other custom settings that you set up the first time.

To import and export your app configuration data in Omnichannel Administration and Omnichannel admin center, install the following apps of the same version in both the source and target environments:

- Omnichannel for Customer Service Administration app
- Any third-party solutions that you plan to integrate
  
> [!NOTE]
>
> - We recommend that you don't export the msdyn_analytics entity. The entity contains org-specific configuration data for intraday insights in Omnichannel for Customer Service; export of the entity might lead to an incorrect configuration of your intraday insights data.
> - The processes outlined in this topic pertain to import and export of data, and not users. To import and export users, you must add them to the target environment after you've imported the configuration data.

During the import process, if any privacy terms are displayed, you'll need to accept them to be able to successfully create records for social channels.

## Import configuration data using the Configuration Migration tool

1. [Download the Configuration Migration tool](/powerapps/developer/data-platform/download-tools-nuget) and install it.

2. Run the Configuration Migration tool, and select **Import data** on the main screen. 

3. On the **Login** screen, provide authentication details to connect to your Dataverse server from where you want to import data. If you have multiple organizations on the Dynamics 365 instance, and want to select the organization from where you want to import the data, select the **Always display list of available orgs** check box. Select **Login**. 

4. If you have multiple organizations, and you selected **Always display list of available orgs**, the next screen lets you select the organization that you want to connect to. Select the organization.

5. Select the data file (.zip) that you want to import, and then select **Import Data**.

   The import status of your records is displayed. The data import is done in multiple passes. Foundation data is imported first, while the dependent data is queuing up, and then the dependent data is imported in the subsequent passes to handle any data dependencies or linkages. This ensures clean and consistent data import.

6. Select **Exit** to close the tool.

## Export configuration data using the Configuration Migration tool

You can export the configuration data from your source system by using the app configuration data schema file, in Omnichannel Administration or Omnichannel admin center.

1. [Download the Configuration Migration tool](/powerapps/developer/data-platform/download-tools-nuget).  

2. Create a schema file per omnichannel solution. More information: [Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)

3. Select the entities and fields that you want to import and export. The entities that you select to import and export depend on the resources that you want to reuse across the source and target organizations. For example, if you use the same API keys and provider for your geolocation provider, then you can include that entity too.

    Some of the core entities that you can use are as follows:

    -  Workstream
    -  Context variable
    -  Rule item
    -  Queue
    -  Quick reply
    -  Presence
    <!---  Operating hours -->
    -  Sentiment analysis

4. To filter the Omnichannel for Customer Service queues only, go to **Tools** > **Configure Import Settings** > **Use Fetch XML to filter records** > **Edit FetchXML**. 
   Enter the following commands:

    ```html
    <fetch> 
      <entity name="queue" > 
        <filter> 
          <condition attribute="msdyn_isomnichannelqueue" operator="eq" value="1" /> 
        </filter> 
      </entity> 
    </fetch> 
    ```

5. Double-click **DataMigrationUtility.exe** to run the Configuration Migration tool, and select **Export data**.

6. On the **Login** screen, provide authentication details to connect to your Dynamics 365 Server instance from where you want to export data. If you have multiple organizations on the Dynamics 365 server, and want to select the organization from where to export the data, select the **Always display list of available orgs** check box. Select **Login**.

7. If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you select the organization that you want to connect to. Select the organization that you want to connect to.

8. Specify the name and location of the data file to be exported.

9. Select **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the page after the export is complete.

10. Select **Exit** to close the tool.

## Test the import and export of data

**To check and compare records between the source and target environments**

1. Using [advanced find](../customerengagement/on-premises/basics/save-advanced-find-search.md), select all of the fields of the entities that you imported or exported.

2. Perform a random check of data across multiple records to verify that the data is successfully imported or exported from the source to the target environment.

**To check the functionality in your target environment**

1. Create users, assign them Omnichannel for Customer Service roles, and then add them to queues.

2. Add default presence and capacity to the users.

3. Create a live chat widget.

4. Test a scenario in live chat.

## Artifacts related to export and import

For entity routing, follow the instructions to [export and import your flows across environments with packaging](https://go.microsoft.com/fwlink/p/?linkid=2132475).

### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Enable third-party co-browse and screen sharing](third-party-co-browse.md)  
[Overview of channels](channels.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
