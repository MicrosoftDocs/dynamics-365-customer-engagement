---
title: "Impersonation in plug-ins (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Impersonation is used to execute business logic (custom code) on behalf of a system user to provide a desired feature or service for that user. Any business logic executed within a plug-in, including Web service method calls and data access, is governed by the security privileges of the impersonated user."
ms.custom: 
ms.date: 1/24/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 857bedcc-c2f6-4747-8f89-93388c9ea19f
caps.latest.revision: 30
author: phecke
ms.author: pehecke
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Impersonation in plug-ins

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Impersonation is used to execute business logic (custom code) on behalf of a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps system user to provide a desired feature or service for that user. Any business logic executed within a plug-in, including Web service method calls and data access, is governed by the security privileges of the impersonated user.  
  
 Plug-ins not executed by either the sandbox or asynchronous service execute under the security account that is specified on the **Identity** tab of the **CRMAppPool Properties** dialog box. The dialog box can be accessed by right-clicking the **CRMAppPool** application pool in [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] Manager and then clicking **Properties** in the shortcut menu. By default, CRMAppPool uses the Network Service account identity but this can be changed by a system administrator during installation. If the **CRMAppPool** identity is changed to a system account other than Network Service, the new identity account must be added to the **PrivUserGroup** group in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change a Microsoft Dynamics 365 for Customer Engagement apps service account or AppPool identity](https://technet.microsoft.com/library/hh699751.aspx) for more detailed instructions.

Additional information about using impersonation with plug-ins can be found in the CDS for Apps topic [Impersonate a user](/powerapps/developer/common-data-service/impersonate-a-user.md).
  
> [!IMPORTANT]
> For plug-ins executing offline, any entities created by the plug-in are owned by the logged on user. Impersonation in plug-ins is not supported while in offline mode.  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md)   
 [Impersonate Another User](org-service/impersonate-another-user.md)  
 [Support offline execution](support-offline-execution.md)
