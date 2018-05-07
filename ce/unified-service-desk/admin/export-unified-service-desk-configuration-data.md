---
title: "Export Unified Service Desk for Dynamics 365 Customer Engagement configuration data | MicrosoftDocs"
description: "Learn how to prepare a file for use with another instance using the Configuration Migration Tool and configuration data schema file."
ms.custom: dyn365-USD, dyn365-admin
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: f3d3b348-ddf7-4174-af34-9583a9f2b7e6
caps.latest.revision: 9
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Export Unified Service Desk configuration data
You can export your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data from your source system by using the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data schema file.  
  
1.  Download the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)] and the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data schema file (USDDefaultSchema.xml). The tool and the configuration data schema file are available in the [CRM SDK download package](http://go.microsoft.com/fwlink/?LinkID=627298).  
  
    1.  Download the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] package (.exe), and extract it to find the tool in the SDK\Tools\ConfigurationMigration folder.  
  
    2.  Download the UII SDK package (.exe), and extract it to find the USDDefaultSchema.xml file in the UII\USD Developer Assets\USD Configuration Tool Schema folder.  
  
2.  Double-click the DataMigrationUtility.exe file in the SDK\Tools\ConfigurationMigration folder to run the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)], and choose **Export data** in the main screen.  
  
3.  On the **Login** screen, provide authentication details to connect to your [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)] from where you want to export data. If you have multiple organizations on the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server, and want to select the organization from where to export the data, select the **Always display list of available orgs** check box. Select **Login**.  
  
4.  If you have multiple organizations, and you selected the **Always display list of available orgs** check box, the next screen lets you choose the organization that you want to connect to. Select a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization to connect to.  
  
5.  On the next screen, select the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data schema file (USDDefaultSchema.xml) to be used for the data export.  
  
6.  Specify the name and location of the data file to be exported.  
  
7.  Choose **Export Data**. The screen displays the export progress status and the location of the exported file at the bottom of the screen once the export is complete.  
  
8.  Choose **Exit** to close the tool.  
  
## Next Step  
 [Import Unified Service Desk configuration data](../../unified-service-desk/admin/import-unified-service-desk-configuration-data.md)  
  
## See also  
 [Migrate your Unified Service Desk configuration to another Dynamics 365 server](../../unified-service-desk/admin/migrate-unified-service-desk-configuration-dynamics-365-server.md)
