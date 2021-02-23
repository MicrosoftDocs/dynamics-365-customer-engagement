---
title: "Manage access in Unified Service Desk  | MicrosoftDocs"
description: "Learn how to control user access to Unified Service Desk  by using configuration and security roles."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 08/23/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# Access management in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

## Overview of access control

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration entities and the underlying [!INCLUDE[pn_user_inteface_integration_uii](../../includes/pn-user-interface-integration-uii.md)] entities are stored in Microsoft Dataverse, and you can use the Dataverse security model to govern access to both of these entities. Dataverse has a robust security model that combines role-based, record-level, and field-level security to define the overall security rights that users have. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Security concepts for Microsoft Dynamics CRM](/dynamics365/customer-engagement/admin/security-concepts)  
  
 [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] users can be broadly classified into two categories:  
  
- **Administrators**: People who configure the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities to define an agent application.  
  
- **Agents**: People who use the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application to read the configuration in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities to perform their day-to-day work in a call center.  
  
## Using Unified Service Desk security roles  
 When you deploy [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to the Dataverse instance, four security roles are created:  
  
- **UIIAdministrator** and **UIIAgent** roles define access to the UII and required the Dataverse entities.  
  
- **USD Administrator** and **USD Agent** roles define access to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities, the underlying UII entities, and required the Dataverse entities. You must assign one of these two roles to users in your organization depending on their job role (administrator or agent).  
  
  [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Implement security using custom security roles](../../unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles.md)  
  
## Using Unified Service Desk configuration  
 Another approach to filtering access to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] data is through the use of configurations. A configuration is the logical grouping of various components in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] agent application such as action calls, agent scripts, entity searches, events, and hosted controls. The configuration can be assigned to a user so that when the user starts the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] agent application, only the components included in the configuration are displayed. This is a great way to filter things that you want to be displayed to your agents without having to manage their security roles. However, please keep the following things in mind:  
  
- A configuration can only be assigned to a user, and not to a team in Dataverse.  
  
- A configuration only filters the components when you access [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] information through the client application. If you access Dataverse or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] directly, you can access data as per your Dataverse security role.  
  
  [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  
  
  
## See also  
 [Manage access using Unified Service Desk security roles](../../unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles.md)  
  
 [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]