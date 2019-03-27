---
title: "Build Windows client applications using the XRM tools (Developer Guide for Dynamics 365 for Customer Engagement apps)| MicrosoftDocs"
description: "XRM tooling is a set of APIs that provides support for building Windows client applications for Dynamics 365 for Customer Engagement apps"
ms.custom: 
ms.date: 03/27/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: e2f22576-1705-4854-a804-a1ca232c0cfc
caps.latest.revision: 33
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Build Windows client applications using the XRM tools

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

XRM tooling is a set of APIs built on top of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps SDK assembly APIs (Organization service and IDiscoveryService) that provide support for building [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] client applications for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps.   

> [!NOTE]
> [!INCLUDE[cc-cdsnote-1](./includes/cc-cdsnote-1.md)]
>
> The XRM tooling documentation that is applicable to Dynamics 365 for Customer Engagement apps (online) users is now available in the PowerApps documentation at: [Build Windows client applications using the XRM tools](https://docs.microsoft.com/powerapps/developer/common-data-service/xrm-tooling/build-windows-client-applications-xrm-tools)
>
> [!INCLUDE[cc-cdsnote-2-section](./includes/cc-cdsnote-2-section.md)]

XRM tooling provides the following capabilities:  
  
- Supports all the authentication modes to sign in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps, including OAuth.  
  
- Provides [PowerShell](xrm-tooling/use-powershell-cmdlets-xrm-tooling-connect.md) support for authentication and connection to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
- Provides thread safety for actions performed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps in a multithreaded environment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Multithreading in Components](https://msdn.microsoft.com/library/vstudio/3es4b6yy.aspx), [Thread-Safe Components](https://msdn.microsoft.com/library/vstudio/a8544e2s.aspx)  
  
- Provides a common [Windows Presentation Foundation login control](/powerapps/developer/common-data-service/xrm-tooling/use-xrm-tooling-common-login-control-client-applications) for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps for consistent sign-in experience to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps from your Windows client applications.  
  
- Supports secure storage of the sign-in credentials and reuse of the stored credentials to automatically sign in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps after initial sign in.  
  
- Provides built-in diagnostic [tracing](/powerapps/developer/common-data-service/xrm-tooling/configure-tracing-xrm-tooling
) and performance reporting of the actions performed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] apps, which you can configure based on your organization’s requirements.  


### See also 

[Sample: Quick start for XRM Tooling API](/powerapps/developer/common-data-service/xrm-tooling/sample-quick-start-xrm-tooling-api)<br />
[Simplified connection quick start](/powerapps/developer/common-data-service/xrm-tooling/sample-simplified-connection-quick-start)