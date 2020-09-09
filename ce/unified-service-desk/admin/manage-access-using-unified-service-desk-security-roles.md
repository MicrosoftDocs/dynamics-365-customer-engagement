---
title: "Manage access using Unified Service Desk security roles | MicrosoftDocs"
description: "Learn to control how agents use Unified Service Desk by using security roles."
ms.custom: 
  - dyn365-USD
  - dyn365-admin
ms.date: 08/23/2017
ms.service: 
  - dynamics-365-customerservice
ms.topic: article
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---
# Use security roles to manage access 
You must assign the two [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] security roles to appropriate users or teams. The **USD Administrator** role must be assigned to the users who will be configuring the application using the Common Data Service platform to define an agent application. The **USD Agent** role must be assigned to the end users (agents) who will be using the client application to connect to the Common Data Service platform instance with the configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities.  
  
 You must also assign the appropriate the Common Data Service platform security role to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators and agents along with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] security role to facilitate appropriate access on the Common Data Service platform entities along with the custom [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities. For example, you should assign the **Customer Service Representative** role along with the **USD Agent** role to the agents.  
  
 For information about assigning a security role to a user or team in the Common Data Service platform, see [Security roles and privileges](/dynamics365/customer-engagement/admin/security-roles-privileges) or [Manage teams](/dynamics365/customer-engagement/admin/manage-teams).  
  
## See also  
 [Create Unified Service Desk Configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)   
 [Access management in Unified Service Desk](../../unified-service-desk/admin/security-unified-service-desk.md)   
 [Privilege and role entities](https://msdn.microsoft.com/library/gg328230.aspx)
