---
title: "Support offline execution with Dynamics 365 for Microsoft Office (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Add support to your plug-in for execution by the Dynamics 365 for Microsoft Office Outlook with Offline Access while the client is offline."
ms.custom: on-premise
ms.date: 1/22/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f4f28db1-d744-462a-9eae-544106f95cb8
author: phecke
ms.author: pehecke
manager: kvivek
search.audienceType: 
  - developer

---
# Support offline execution with Dynamics 365 for Microsoft Office

 Offline mode is only supported on [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)]. You can register plug-ins to execute when the Outlook client is in online mode, offline mode, or both.  Your plug-in code can check whether it is executing in offline mode by checking the <xref:Microsoft.Xrm.Sdk.IExecutionContext.IsExecutingOffline> property.  
  
 When you design a plug-in that will be registered for both online and offline execution, remember that the plug-in can execute twice. The first time is while [!INCLUDE[pn_crm_outlook_offline_access](../includes/pn-crm-outlook-offline-access.md)] is offline. The plug-in executes again when [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] goes online and synchronization between [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and the Dynamics 365 Server occurs. You can check the <xref:Microsoft.Xrm.Sdk.IExecutionContext.IsOfflinePlayback> property to determine if the plug-in is executing because of this synchronization.

## Impersonation in offline plug-ins

For plug-ins executing offline, any entities created by the plug-in are owned by the logged on user. Impersonation in plug-ins is not supported while in offline mode.

For additional information on impersonation, see [Impersonation in plug-ins](impersonation-plugins.md) and [Impersonate a user](/powerapps/developer/common-data-service/impersonate-a-user).

## Register an offline plug-in

If your plug-in assembly contains code that supports execution while the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] is offline, there is additional security that the Dynamics 365 Customer Engagement (on-premises) platform imposes on registered assemblies. For more information, see [Walkthrough: Configure Assembly Security for an Offline Plug-in](walkthrough-configure-assembly-security-offline-plugin.md).

For general information about plug-in registration, see [Register and Deploy Plug-Ins](register-deploy-plugins.md).

## Debug an offline plug-in

General information on debugging plug-ins can be found in [Debug a plug-In](debug-plugin.md). When debugging a plug-in that executes while the client is offline, attach your debugger to the Microsoft.Crm.Application.Hoster.exe process on the computer where the client is executing.
  
### See also  
[Plug-in Development](plugin-development.md)   
[Supported messages and entities for plug-ins](supported-messages-entities-plugin.md)
[Write a plug-in](/powerapps/developer/common-data-service/write-plug-in)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]