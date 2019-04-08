---
title: "Use Single-Tenant Server-to-server authentication | MicrosoftDocs"
description: "An enterprise can create a web application or service to connect to all the Dynamics 365 for Customer Engagement (online) organizations for the single tenant"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: e238f839-3592-44c4-9f82-dc287551c581
caps.latest.revision: 7
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Use Single-Tenant Server-to-server authentication

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

The single-tenant server-to-server scenario typically applies for enterprise organizations who have multiple [!INCLUDE[pn_crm_8_2_0_online](../includes/pn-crm-8-2-0-online.md)] organizations using [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../includes/pn-active-dir-fed-svcs-ad-fs.md)] for authentication. However, it can also be applied by organizations using [!INCLUDE[pn_crm_8_2_0_online_subsequent](../includes/pn-crm-8-2-0-online-subsequent.md)] when the application will not be distributed to other [!INCLUDE[pn_dyn_365_online](../includes/pn-crm-online.md)] organizations.
  
 An enterprise can create a web application or service to connect to all the [!INCLUDE[pn_dyn_365_online](../includes/pn-crm-online.md)] organizations for the single tenant.  
  
## Differences from multi-tenant scenario  
 Creating a web application or service for a single-tenant server-to-server authentication is similar to that used for a multi-tenant organization but there are some important differences.  
  
-   Because all the organizations are in the same tenant, there is no need for a tenant admin to grant consent. The application is already registered on the tenant.  
  
-   You have the opportunity to use certificates rather than keys if you prefer.  

> [!NOTE]
> For more information including a walkthrough and code sample, see the [Use Single-Tenant server-to-server authentication](/powerapps/developer/common-data-service/use-single-tenant-server-server-authentication) PowerApps topic.
  
### See also  
 [Use Multi-Tenant Server-to-server authentication](use-multi-tenant-server-server-authentication.md)   
 [Build web applications using Server-to-Server (S2S) authentication](build-web-applications-server-server-s2s-authentication.md)   
 [Connect to Dynamics 365 for Customer Engagement](connect-customer-engagement.md)
