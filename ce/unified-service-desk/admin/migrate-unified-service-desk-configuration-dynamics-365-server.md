---
title: "Migrate Unified Service Desk configuration | MicrosoftDocs"
description: "Learn how you can migrate your latest Unified Service Desk configuration data from your development or test environment to the production environment."
ms.date: 06/27/2024
ms.topic: upgrade-and-migration-article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - admin
ms.custom: evergreen
---
# Migrate Unified Service Desk configuration 



After you have completed the development or configuration of your agent application, you might want to migrate your latest [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data from your development or test environment to your production environment. Migrating your data involves exporting your existing configuration data from the source instance, and then importing it into the target instance.  
  
 To export your configuration data, you can use the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)] and the default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data schema file (USDDefaultSchema.xml). The default schema file contains information about all the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities, relationships, and uniqueness definitions for each entity. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Export Unified Service Desk configuration data](../../unified-service-desk/admin/export-unified-service-desk-configuration-data.md)  
  
 For more information about the [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)], see [Manage your configuration data](/dynamics365/customer-engagement/admin/manage-configuration-data).  
  
> [!NOTE]
>  The default [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data schema file does not export user information from the source system.  
> 
>  For records that include notes and attachments, including Customization Files (compressed folder), these items aren’t included in the record during the export.  
  
 To import the exported [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data to a instance, you can do either of the following:  
  
- **Use the Configuration Migration tool**: The tool also enables you to import the exported configuration data. Before you do that though, you must deploy one of the sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages to create the underlying entities in the target instance. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Import configuration data using the Configuration Migration tool](../../unified-service-desk/admin/import-unified-service-desk-configuration-data.md#ConfigMigration)  
  
- **Use a custom package for Unified Service Desk**: Create a custom package for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to include the exported data along with the files in one of the sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] packages, and then deploy the custom package on the target instance using the [!INCLUDE[pn_package_deployer_tool](../../includes/pn-package-deployer-tool.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Import configuration data using a custom package for Unified Service Desk](../../unified-service-desk/admin/import-unified-service-desk-configuration-data.md#CustomPackage)  
  
> [!IMPORTANT]
>  The [!INCLUDE[pn_configuration_migration_tool](../../includes/pn-configuration-migration-tool.md)] provides logging support to record detailed information about:  
> 
> - Errors that can occur while signing in to the Dynamics 365 instance using the tool.  
> - Activities performed by the tool during the schema definition and export and import of the configuration data.  
> - Data that was imported using the tool.  
> 
>   There are three log files generated by the tool that are available at the following location on the computer where you run the tool: `C:\Users\<UserName>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Configuration Migration Utility\<Version>`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Troubleshoot configuration data migration issues using log files](/dynamics365/customer-engagement/admin/manage-configuration-data#Logfiles)  
  
  
### See also  
 [Export Unified Service Desk configuration data](../../unified-service-desk/admin/export-unified-service-desk-configuration-data.md)  
  
 [Import Unified Service Desk configuration data](../../unified-service-desk/admin/import-unified-service-desk-configuration-data.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
