---
title: "Move data across instances and organizations | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
author: jimholtz
ms.assetid: eacae026-5406-4837-be76-1b243a4181b0
caps.latest.revision: 29
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin

---
# Move configuration data across instances and organizations with the Configuration Migration tool

The Configuration Migration tool enables you to move configuration data across Dynamics 365 Customer Engagement (on-premises) instances and organizations. Configuration data is used to define custom functionality in Customer Engagement (on-premises), and is typically stored in custom entities. Configuration data is different from end user data (account, contacts, and so on). A typical example of configuration data is what you define in [!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)] to configure a customized call center agent application. The [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] entities, along with the configuration data that is stored in the entities, define an agent application. For more information about [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], see [Unified Service Desk Guide](/dynamics365/customer-engagement/unified-service-desk/unified-service-desk).  
  
 The Configuration Migration tool enables you to:  
  
- Select the entities and fields from where you want to export the configuration data.  
  
- Avoid duplicate records on the target system by defining a uniqueness condition for each entity based on a combination of fields in the entity, which is used to compare against the values on the target system. If there are no matching values, a unique record is created on the target system. If a matching record is found, the record is updated on the target system.  
  
  > [!NOTE]
  > If no duplicate detection (uniqueness) condition is specified for an entity that is being exported, the tool uses the primary field name of the entity to compare against the existing data on the target system.  
  
- Disable plug-ins before exporting data and then re-enable them on the target system after the import is complete for all the entities or selected entities.  
  
- Validate the schema for the selected entities to be exported to ensure that all the required data/information is present.  
  
- Reuse an existing schema to export data from a source system.  

- Automatically move DateTime fields forward at import for demo environments.
  
- Embed the exported modules created from this tool (schema and data files) in other programs. For example, you can use the exported data in Customer Engagement (on-premises) Package Deployer along with other solutions files and data to create and deploy packages on a Customer Engagement (on-premises) instance. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Deploy packages using Customer Engagement (on-premises) Package Deployer and Windows PowerShell](../admin/deploy-packages-using-package-deployer-windows-powershell.md)  
  
> [!IMPORTANT]
> The Configuration Migration tool does not support filtering of records in an entity. By default, all the records in the selected entity will be exported.  


## How to use the Configuration Migration tool?

The first step is to download the Configuration Migration tool: [Download tools from NuGet](../developer/download-tools-nuget.md).

Detailed documentation about using the tool is available in the Power Platform Admin Guide as the same tool can be used by Customer Engagement (on-premises) users: [Move configuration data](/power-platform/admin/manage-configuration-data)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]