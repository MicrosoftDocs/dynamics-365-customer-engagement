---
title: "Use security roles to manage access | MicrosoftDocs"
description: "Learn to control how agents use Unified Service Desk by using custom security roles."
ms.date: 08/23/2017
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
  - dyn365-admin
tags: MigrationHO
---
# Use security roles to manage access to Unified Service Desk



You must assign the **USD Administrator** and **USD Agent** security roles to appropriate users or teams. The **USD Administrator** role must be assigned to users who will be configuring the application using Microsoft Dataverse to define an agent application. The **USD Agent** role must be assigned to end users (agents) who will be using the client application to connect to the Dataverse instance with the configured [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities.  
  
 You must also assign the appropriate the Dataverse security role to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] administrators and agents along with the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] security role to facilitate appropriate access on the Dataverse entities along with the custom [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and UII entities. For example, you should assign the **Customer Service Representative** role along with the **USD Agent** role to the agents.  
  
 For information about assigning a security role to a user or team in Dataverse, see [Security roles and privileges](/dynamics365/customer-engagement/admin/security-roles-privileges) or [Manage teams](/dynamics365/customer-engagement/admin/manage-teams).  
  
## See also

 [Create Unified Service Desk configuration](../../unified-service-desk/admin/manage-access-using-unified-service-desk-configuration.md)   
 [Access management in Unified Service Desk](../../unified-service-desk/admin/security-unified-service-desk.md)   
 [Privilege and role entities](/previous-versions/dynamicscrm-2016/developers-guide/gg328230(v=crm.8))


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
