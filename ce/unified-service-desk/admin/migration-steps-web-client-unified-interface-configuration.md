---
title: "Migration steps of Web Client configurations to Unified Interface App | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 07/30/2018
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
---

# Migration steps of the configurations from Dynamics 365 Web Client to Unified Interface App

The migration of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations from [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client to [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Interface is a two stage process.

- **Step 1:** Fetch and migrate the configuration elements to a **USDConfigurations** folder using the Web Client - Unified Interface Migration Assistant.

- **Step 2:** Import the **Data** zip folder from the **USDConfigurations** folder to the Unified Interface App using the Configuration Migration Tool (DataMigrationUtility.exe).

The diagram demonstrates the flow of the migration:

![Migration Steps](../media/migration-steps-web-client-unified-interface-migration-assistant.PNG "Migration Steps")

**[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client**. The [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Web Client is the instance from where you want to migrate your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configurations.

**Web Client - Unified Interface Migration Assistant.** The tool to fetch and migrate the Web Client configurations to **USDConfigurations** folder, which contains **Data** and **WebResources** zip folder. If you have **RunXrmCommand** action in Web Client configurations, the migration assitant migrates the **RunXRMCommand** actions as web resource and you can find them in the **WebResources** folder under the **USDConfigurations** folder.

**USDConfigurations.** The configurations are migrated to the **USDConfigurations** zip folder that contains **Data** and/or **WebResources** zip folder.

**Configuration Migration Tool.** The Configuration Migration tool enables you to import the **Data** zip folder and deploy on the target [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Interface App.

**[!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Unified Inerface App.** The target [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to which you want to deploy the configurations.

## Step 1: Use migration assistant to fetch and migrate the Web Client configurations

1. Run the **UCMigrationTool.exe**.

2. In the introduction screen, Select **Continue**.

3. In the **Login** screen, provide authentication details to connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance from where you want fetch and migrate the configurations. If you have multiple organizations, and want to select the organization where you want to fetch and migrate the configurations, select the **Display list of available organizations** check box, and select **Login**.</br>
![Migration Assistant Login screen](../media/usd-migration-assistant-login.PNG "Migration Assistant Login Screen")

4. In the **Export Configurations** screen, select **Export**.</br>
**Data file location** is the location where the migration assistant stores **Data.zip** folder. The **Data.zip** folder is present in the **USDConfigurations** folder.</br>
When the export is successfully completed, select **Next**.</br>
![Export configurations screen](../media/usd-migration-assistant-export-configurations.PNG "Export configurations screen")

5. In the **Select Configurations** screen, select the configuration elements you want to migrate, and select **Next**.</br>
![Select configurations screen](../media/usd-migration-assistant-select-configurations.PNG "Select configurations screen")

6. In the **Confirm Selection** screen, review the configurations you selected for migration, and select **Next**. If you want to change the selection, select **Previous** and repeat the step 5.

7. In the **Migrate Configurations** screen, choose **Migrate**. After the migration is completed, select **Next**.</br>
![Migrate configurations screen](../media/usd-migration-assistant-migrate.PNG "Migrate configurations screen")

8. In the **File Download** screen, a the migration assistant provides a default location to download the **USDConfigurations.zip** folder. To change the default download location, select **Browse** and choose a location, and select **Download File**.</br>
The migration assistant displays the **Download Completed**.</br>
![File Download screen](../media/usd-migration-assistant-download-file.PNG "File Download screen")

9. Select **Exit** close and exit the tool.

## Step 2: Use configuration Migration Tool to import and deploy the configurations on Unified Interface App

**Prerequesites:** Download the Configuration Migration tool (DataMigrationUtility.exe). To download the tool, see [Download the tools from NuGet](../../developer/download-tools-nuget.md).

1. Go to the location where you downloaded the Configuration Migration Tool (DataMigrationUtility.exe).

2. Open **ConfigurationMigation** and execute **DataMigrationUtility.exe**. 

3. In the next screen, select **Import data*, and select **Continue**.

4. In the **Login** screen, provide authentication details to connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance to which you want to deploy the migrated configurations. If you have multiple organizations, and want to select the organization to which you want to deploy the migrated configurations, select the **Display list of available organizations** check box, and select **Login**.

## See also

[Migration of Unified Service Desk configurations from Dynamics 365 Web Client to Dynamics 365 Unified Interface App](overview-migration-assistant.md)

[Download the Web Client - Unified Interface Migration Assistant](download-migration-assistant.md)