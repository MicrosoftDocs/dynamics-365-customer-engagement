---
title: "Manage access using Unified Service Desk for Dynamics 365 Customer Engagement security roles | MicrosoftDocs"
description: "Learn to control how agents use Unified Service Desk for Dynamics 365 Customer Engagement by using security roles." 
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
ms.assetid: 1d1e06fc-188d-4f3e-91b1-a6c371c28eb4
caps.latest.revision: 5
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Use security roles to manage access 
You must assign the two [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] security roles to appropriate users or teams. The **USD Administrator** role must be assigned to the users who will be configuring the application using [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] to define an agent application. The **USD Agent** role must be assigned to the end users (agents) who will be using the client application to connect to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance with the configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities.  
  
 You must also assign the appropriate [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] security role to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators and agents along with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] security role to facilitate appropriate access on the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] entities along with the custom [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities. For example, you should assign the **Customer Service Representative** role along with the **USD Agent** role to the agents.  
  
 For information about assigning a security role to a user or team in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], see [Security roles and privileges](../../admin/security-roles-privileges.md) or [Manage teams](../../admin/manage-teams.md).  
  
## See also  
 [Create Unified Service Desk Configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)   
 [Access management in Unified Service Desk](../../unified-service-desk/admin/security-unified-service-desk.md)   
 [Privilege and role entities](https://msdn.microsoft.com/library/gg328230.aspx)
