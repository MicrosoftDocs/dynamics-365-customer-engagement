---
title: "Export and import app configuration data | MicrosoftDocs"
description: "Learn to export and import app configuration data from source to target environments in Omnichannel Administration and Omnichannel admin center apps."
ms.date: 01/24/2022
ms.topic: article
author: neeranelli    
ms.author: nenellim
manager: shujoshi
ms.reviewer: nenellim
---

# Export and import app configuration data

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

After you have used Omnichannel for Customer Service in a test environment, you can export your app configuration data to a live production environment. Follow the process outlined in this topic to export and then import the app data into your new target environment. That way, you can keep all of the queues, routing rules, workstreams, and other custom settings that you set up earlier.

While you can use the configuration migration tool to export and import entity data, omnichannel-related configurations contain different entities that have internal dependencies. Therefore, you must bring together the required data by following a very specific process. For example, if you have already imported the context variables and then try to import pre-conversation configuration that also creates context variables, the import might not work. Similarly, you need to import all the internal entities, such as ruleset configurations that contain decision rulesets and contracts, for the import of workstreams and record queues to be successful.

> [!IMPORTANT]
>
> - To export and import record type of channel across environments, contact [Microsoft Support](https://dynamics.microsoft.com/support/).
> - Org lifecycle operations, such as copy and restore of org, are not supported.
> - We recommend that you to not export the msdyn_analytics entity. The entity contains org-specific configuration data for intraday insights in Omnichannel for Customer Service; exporting the entity might lead to an incorrect configuration of your intraday insights data.
> - The processes outlined in this topic pertain to export and import of data, and not users. To export and import **users**, you must add them to the target environment after you've imported the configuration data.


## Export app configuration data

You can export the configuration data from your source system by using the app configuration data schema file, in Omnichannel admin center or Omnichannel Administration.

1. [Download the Configuration Migration tool from NuGet using the PowerShell script](/powerapps/developer/data-platform/download-tools-nuget).

2. Create a schema file per omnichannel solution. More information: [Create a schema to export configuration data](/power-platform/admin/create-schema-export-configuration-data)

3. Select the entities and fields that you want to export. The entities that you select to export depend on the resources that you want to reuse across the source and target organizations. For example, if you use the same API keys and provider for your geolocation provider, then you can include that entity too.

  > [!Note]
  > You cannot export the Calendar entity.

4. To filter the Omnichannel for Customer Service queues only, go to **Tools** > **Configure Import Settings** > **Use Fetch XML to filter records** > **Edit FetchXML**, and update the XML file as follows:

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

6. On the **Login** screen, provide authentication details to connect to your Dynamics 365 Server instance from where you want to export data. If you have multiple organizations on the Dynamics 365 server, and want to select the organization from where to export the data, select the **Always display list of available orgs** checkbox. Select **Login**.

7. Select the organization that you want to connect to.

8. Specify the name and location of the data file to be exported.

9. Select **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the page after the export is complete.

10. Select **Exit** to close the tool.

## Import app configuration data

1. [Download the Configuration Migration tool from NuGet using the PowerShell script](/powerapps/developer/data-platform/download-tools-nuget).

2. Run the Configuration Migration tool, and select **Import data** on the main screen.

3. On the **Login** screen, provide authentication details to connect to your Dataverse server from where you want to import data. 

4. If you have multiple organizations in the Dynamics 365 instance, and want to select the organization from where you want to import the data, select the **Always display list of available orgs** checkbox and then select **Login**.

5. Select the organization that you want to connect to.

6. Select the data file (.zip), and then select **Import Data**.

   The import status of your records is displayed. To ensure a clean and consistent import of data, the import process runs in multiple passes. The foundation data is imported first, while the dependent data is queuing up, and then the dependent data is imported in the subsequent passes to handle any data dependencies or linkages.

7. Select **Exit** to close the tool.

> [!Note]
> During the import process, if any privacy terms are displayed, you'll need to accept them to be able to successfully create records for social channels.

## Test the export and import of data

**To check and compare records between the source and target environments**

1. Using [advanced find](../customerengagement/on-premises/basics/save-advanced-find-search.md), select all of the fields of the entities that you exported or imported.

2. Perform a random check of the data across multiple records to confirm that all data is successfully exported and imported between the source and target environments.

**To check the functionality in your target environment**

1. Create users, assign them Omnichannel for Customer Service roles, and then add them to queues.

2. Add default presence and capacity to the users.

3. Create a live chat widget.

4. Test a scenario in live chat.


### See also

[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Upgrade Omnichannel for Customer Service](upgrade-omnichannel.md)  
[Enable third-party co-browse and screen sharing](third-party-co-browse.md)  
[Overview of channels](channels.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
