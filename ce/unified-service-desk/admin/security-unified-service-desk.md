---
title: "Manage access in Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how to control user access to Unified Service Desk for Dynamics 365 Customer Engagement by using configuration and security roles." 
ms.custom:
  - dyn365-USD, dyn365-admin
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
ms.assetid: 6246a780-eb72-4c37-b84a-9a78904ed631
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# About access control
[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration entities and the underlying [!INCLUDE[pn_user_inteface_integration_uii](../../includes/pn-user-interface-integration-uii.md)] entities are stored in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], and you can use the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] security model to govern access to both of these entities. [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] has a robust security model that combines role-based, record-level, and field-level security to define the overall security rights that users have. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Security concepts for Microsoft Dynamics CRM](../../admin/security-concepts.md)  
  
 [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] users can be broadly classified into two categories:  
  
- **Administrators**: People who configure the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities to define an agent application.  
  
- **Agents**: People who use the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application to read the configuration in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities to perform their day-to-day work in a call center.  
  
## Using Unified Service Desk security roles  
 When you deploy [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance, four security roles are created:  
  
- **UIIAdministrator** and **UIIAgent** roles define access to the UII and required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] entities.  
  
- **USD Administrator** and **USD Agent** roles define access to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities, the underlying UII entities, and required [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] entities. You must assign one of these two roles to users in your organization depending on their job role (administrator or agent).  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Implement security using custom security roles](../../unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles.md)  
  
## Using Unified Service Desk configuration  
 Another approach to filtering access to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] data is through the use of configurations. A configuration is the logical grouping of various components in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] agent application such as action calls, agent scripts, entity searches, events, and hosted controls. The configuration can be assigned to a user so that when the user starts the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] agent application, only the components included in the configuration are displayed. This is a great way to filter things that you want to be displayed to your agents without having to manage their security roles. However, please keep the following things in mind:  
  
-   A configuration can only be assigned to a user, and not to a team in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
-   A configuration only filters the components when you access [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] information through the client application. If you access [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] directly, you can access data as per your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] security role.  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  
  
  
## See also  
 [Manage access using Unified Service Desk security roles](../../unified-service-desk/admin/manage-access-using-unified-service-desk-security-roles.md)  
  
 [Manage access using Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)  
