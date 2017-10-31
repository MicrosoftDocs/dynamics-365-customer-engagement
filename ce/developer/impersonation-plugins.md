---
title: "Impersonation in plug-ins (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Impersonation is used to execute business logic (custom code) on behalf of a system user to provide a desired feature or service for that user. Any business logic executed within a plug-in, including Web service method calls and data access, is governed by the security privileges of the impersonated user."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 857bedcc-c2f6-4747-8f89-93388c9ea19f
caps.latest.revision: 30
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Impersonation in plug-ins

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Impersonation is used to execute business logic (custom code) on behalf of a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement system user to provide a desired feature or service for that user. Any business logic executed within a plug-in, including Web service method calls and data access, is governed by the security privileges of the impersonated user.  
  
 Plug-ins not executed by either the sandbox or asynchronous service execute under the security account that is specified on the **Identity** tab of the **CRMAppPool Properties** dialog box. The dialog box can be accessed by right-clicking the **CRMAppPool** application pool in [!INCLUDE[pn_Internet_Information_Services](../includes/pn-internet-information-services.md)] Manager and then clicking **Properties** in the shortcut menu. By default, CRMAppPool uses the Network Service account identity but this can be changed by a system administrator during installation. If the **CRMAppPool** identity is changed to a system account other than Network Service, the new identity account must be added to the **PrivUserGroup** group in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change a Microsoft Dynamics CRM service account or AppPool identity](https://technet.microsoft.com/library/hh699751.aspx) for more detailed instructions.  
  
 The two methods that can be employed to impersonate a user are discussed below.  
  
## Impersonation during plug-in registration  
 One method to impersonate a system user within a plug-in is by specifying the impersonated user during plug-in registration. When registering a plug-in programmatically, if the `SdkMessageProcessingStep.ImpersonatingUserId` attribute is set to a specific [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] system user, Web service calls made by the plug-in execute on behalf of the impersonated user. If `ImpersonatingUserId` is set to a value of **null** or `Guid.Empty` during plug-in registration, the calling/logged on user or the standard "system" user is the impersonated user.  
  
 Whether the calling/logged on user or "system" user is used for impersonation is dependent on the request being processed by the pipeline and is beyond the scope of the SDK documentation. For more information about the "system" user, refer to the next topic.  
  
> [!NOTE]
>  When you register a plug-in using the plug-in registration tool, service methods invoked by the plug-in execute under the account of the calling or logged on user by default unless you select a different user in the **Run in User’s Context** dropdown menu.  
  
## Impersonation during plug-in execution  
 Impersonation that was defined during plug-in registration can be altered in a plug-in at run time. Even if impersonation was not defined at plug-in registration, plug-in code can still use impersonation. The following discussion identifies the key properties and methods that play a role in impersonation when making Web service method calls in a plug-in.  
  
 The platform passes the impersonated user ID to a plug-in at run time through the <xref:Microsoft.Xrm.Sdk.IExecutionContext.UserId> property. This property can have one of three different values as shown in the table below.  
  
|UserId Value|Condition|  
|------------------|---------------|  
|Initiating user or "system" user|The `SdkMessageProcessingStep.ImpersonatingUserId` attribute is set to **null** or `Guid.Empty` at plug-in registration.|  
|Impersonated user|The `ImpersonatingUserId` property is set to a valid system user ID at plug-in registration.|  
|"system" user|The current pipeline was executed by the platform, not in direct response to a service method call.|  
  
 The <xref:Microsoft.Xrm.Sdk.IExecutionContext.InitiatingUserId> property of the execution context contains the ID of the system user that called the service method that ultimately caused the plug-in to execute.  
  
> [!IMPORTANT]
>  For plug-ins executing offline, any entities created by the plug-in are owned by the logged on user. Impersonation in plug-ins is not supported while in offline mode.  
  
### See also  
 [Plug-in Development](plugin-development.md)   
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Understand the Data Context Passed to a Plug-in](understand-data-context-passed-plugin.md)   
 [Impersonate Another User](org-service/impersonate-another-user.md)
