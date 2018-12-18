---
title: "Migrate Unified Service Desk configurations from Web Client to Unified Interface App | MicrosoftDocs"
description: "The three-step process for migrating Web Client configurations to Unified Interface"
keywords: ""
ms.date: 08/17/2018
ms.service: 
  - "dynamics-365-customerservice"
ms.custom: 
  - "dyn365-USD, dyn365-admin"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 7B923254-C1B1-4345-84B7-69FA641A18A9
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
---

# How to migrate Unified Service Desk configurations from Dynamics 365 Web Client to Unified Interface App

The migration of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Interface is a three-step process.

- **Step 1:** Fetch and migrate the configuration elements to a **USD_UI_Configurations** folder using the Web Client - Unified Interface Migration Assistant.

- **Step 2:** Import the **USDWebResources** folder, which is in the **USD_UI_Configurations** folder, using the **Solutions** option in the Dynamics 365.

- **Step 3:** Import the **Data** zip folder from the **USD_UI_Configurations** folder to the Unified Interface App using the Configuration Migration Tool (DataMigrationUtility.exe).

This diagram illustrates the flow of the migration:
> [!div class="mx-imgBorder"]
> ![Migration Steps](../media/migration-steps-web-client-unified-interface-migration-assistant.PNG "Migration Steps") 

1. **Dynamics 365 Web Client** </br></br> The [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client is the instance from where you want to migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations.

2. **Web Client - Unified Interface Migration Assistant** </br></br> The tool to fetch and migrate the Web Client configurations to **USD_UI_Configurations** folder, which contains the **Data** and **WebResources** zip folders. If you have **RunXrmCommand** actions in Web Client configurations, the migration assistant migrates the **RunXRMCommand** actions as a web resource and you can find them in the **USDWebResources** folder under the **USD_UI_Configurations** folder.

3. **USD_UI_Configurations** </br></br> The configurations are migrated to the **USD_UI_Configurations** zip folder that contains the **Data** and/or **WebResources** zip folder.

4. **Configuration Migration Tool** </br></br> The Configuration Migration Tool lets you to import the **Data** zip folder and deploy it to the target [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Interface App.

5. **Dynamics 365 Unified Interface App** The target [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to which you want to deploy the configurations.

## Step 1: Use migration assistant to fetch and migrate the Web Client configurations

1. Run **UCMigrationTool.exe**.

2. In the introduction screen, select **Continue**.

3. In the **Login** screen, provide authentication details to connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance from where you want to fetch and migrate the configurations. If you have multiple organizations, and want to select the organization where you want to fetch and migrate the configurations, select the **Display list of available organizations** check box, and select **Login**.</br>
![Migration Assistant Login screen](../media/usd-migration-assistant-login.PNG "Migration Assistant Login Screen")

4. In the **Export Configurations** screen, select **Export**.</br>
**Data file location** is the location where the migration assistant stores the **Data.zip** folder, which contains the configurations that you export from the Web Client.</br>
When the export is successfully completed, select **Next**.</br>
![Export configurations screen](../media/usd-migration-assistant-export-configurations.PNG "Export configurations screen")

5. In the **Select Configurations** screen, select the configuration elements (hosted controls) you want to migrate, and select **Next**.</br>This is a multi-select list, and you can select several configuration elements to migrate.
</br>The migration assistant displays only the hosted controls to select. If you select a hosted control, the migration assistant exports all the actions, action calls, events, and other elements associated with the particular hosted control.</br>
![Select configurations screen](../media/usd-migration-assistant-select-configurations.PNG "Select configurations screen")

6. In the **Confirm Selection** screen, review the configurations you selected for migration, and select **Next**. If you want to change the selection, select **Previous** and repeat step 5.

7. In the **Migrate Configurations** screen, choose **Migrate**. After the migration is completed, select **Next**.</br>
![Migrate configurations screen](../media/usd-migration-assistant-migrate.PNG "Migrate configurations screen")

8. In the **File Download** screen, the migration assistant provides a default location to download the **USD_UI_Configurations.zip** folder. To change the default download location, select **Browse** and choose a location, and select **Download File**.</br>
The migration assistant displays the **Download Completed**.</br>
![File Download screen](../media/usd-migration-assistant-download-file.PNG "File Download screen")

9. Select **Exit** to close and exit the tool.

## Step 2: Import the USDWebResources folder

The **USDWebResources** folder contains the migrated **RunXrmCommand** actions that were present in Web Client. To deploy the **USDWebResources** on the target Unified Intrface App, import the web resources as a solution in the Dynamics 365.

To import the **USDWebResources** zip folder, follow these steps:

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. Go to **Settings** > **Solutions**.

3. Select **Import** to import the web resource.

4. In the **Select Solution Package** window, browse and select the **USDWebResources** zip folder, and select **Next**.

5. In the **Solution Information** screen, review the solution information and select **Import**.</br>
You can see the success message after the solution is imported successfully.

6. In the **Importing Solution** screen, select **Close**.

You can see the **USDWebResources** in the solutions list.</br>

![USDWebResource imported to Dynamics 365](../media/usd-configuration-migration-webresources-import.PNG "USDWebResource imported to Dynamics 365")

For more information, see [Import, update, and export solutions](/dynamics365/customer-engagement/customize/import-update-export-solutions)

## Step 3: Use Configuration Migration Tool to import and deploy the configurations on Unified Interface App

**Prerequesites:** Download the Configuration Migration tool (DataMigrationUtility.exe). To download the tool, see [Download the tools from NuGet](/dynamics365/customer-engagement/developer/download-tools-nuget).

1. Go to the location where you downloaded the Configuration Migration Tool (DataMigrationUtility.exe).

2. Open **ConfigurationMigration** and execute **DataMigrationUtility.exe**. 

3. In the next screen, select **Import data**, and select **Continue**.</br>
![Configuration Migration Tool options screen](../media/usd-configuration-migration-tool-options.PNG "Configuration Migration Tool options data screen")

4. In the **Login** screen, provide authentication details to connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to which you want to deploy the migrated configurations. If you have multiple organizations, and want to select the organization to which you want to deploy the migrated configurations, select the **Display list of available organizations** check box, and select **Login**.</br>
![Configuration Migration Tool login screen](../media/usd-configuration-migration-tool-login.PNG "Configuration Migration Tool login screen")

5. In the next screen, browse the **USD_UI_Configurations** folder and select the **Data.zip** folder, and then select **Import Data**.</br>
![Browse and select data.zip folder](../media/usd-configuration-migration-tool-import-data.PNG "Browse and select data.zip folder")

6. After the import is complete, select **Exit**.</br>
![Importing is completed. Select Exit](../media/usd-configuration-migration-tool-import-complete.PNG "Importing is completed. Select Exit")

## Test the deployment of the configurations on the target Unified Interface App.

1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].

2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]

3. Select configurations that you migrated from the Web Client.</br>
For example, the selected configuration elements are as follows:

  |Configuration Name|Description|
  |-------|-------|
  |KB Article| CRM Page|
  |KB Search| KM Control|

  </br>![Select configurations](../media/usd-migration-assistant-selected-configurations.PNG "Selected configurations")</br>
 You must select **Hosted Controls** to verify.</br></br>
You can see configurations are migrated to Unified Interface specific elements.

  |Configuration Name|Description|
  |-------|-------|
  |KB Article| Unified Interface Page|
  |KB Search| Unified Interface KM Control|
  
  </br>![Verifying the configuration migration](../media/usd-configuration-migration-verification.PNG "Verifying the configuration migration")

## See also

[Migration of Unified Service Desk configurations from Dynamics 365 Web Client to Dynamics 365 Unified Interface App](overview-migration-assistant.md)

[Download the Web Client - Unified Interface Migration Assistant](download-migration-assistant.md)

[Download the tools from NuGet](/dynamics365/customer-engagement/developer/download-tools-nuget)

[Import configuration data](/dynamics365/customer-engagement/admin/import-configuration-data)
