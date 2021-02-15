---
title: "Build Windows client applications using the XRM tools (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "XRM tooling is a set of APIs that provides support for building Windows client applications for Dynamics 365 Customer Engagement (on-premises)"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: e2f22576-1705-4854-a804-a1ca232c0cfc
caps.latest.revision: 33
ms.author: nabuthuk
author: Nkrb
manager: kvivek
search.audienceType: 
  - developer

---
# Build Windows client applications using the XRM tools

XRM tooling is a set of APIs built on top of the Dynamics 365 Customer Engagement (on-premises) SDK assembly APIs (Organization service and IDiscoveryService) that provide support for building Windows client applications for Dynamics 365 Customer Engagement (on-premises).   

> [!NOTE]
> [!INCLUDE[cc-cdsnote-1](./includes/cc-cdsnote-1.md)]
>
> The XRM tooling documentation that is applicable to Dataverse users is now available in the Power Apps documentation at: [Build Windows client applications using the XRM tools](https://docs.microsoft.com/powerapps/developer/common-data-service/xrm-tooling/build-windows-client-applications-xrm-tools)
>
> [!INCLUDE[cc-cdsnote-2-section](./includes/cc-cdsnote-2-section.md)]

XRM tooling provides the following capabilities:  
  
- Supports all the authentication modes to sign in to Dynamics 365 Customer Engagement (on-premises), including OAuth.  
  
- Provides [PowerShell](xrm-tooling/use-powershell-cmdlets-xrm-tooling-connect.md) support for authentication and connection to Dynamics 365 Customer Engagement (on-premises).  
  
- Provides thread safety for actions performed in Dynamics 365 Customer Engagement (on-premises) in a multithreaded environment. More information: [Multithreading in Components](https://msdn.microsoft.com/library/vstudio/3es4b6yy.aspx), [Thread-Safe Components](https://msdn.microsoft.com/library/vstudio/a8544e2s.aspx)  
  
- Provides a common [Windows Presentation Foundation login control](/powerapps/developer/common-data-service/xrm-tooling/use-xrm-tooling-common-login-control-client-applications) for Dynamics 365 Customer Engagement (on-premises) for consistent sign-in experience to from your Windows client applications.  
  
- Supports secure storage of the sign-in credentials and reuse of the stored credentials to automatically sign in to Dynamics 365 Customer Engagement (on-premises) after initial sign in.  
  
- Provides built-in diagnostic [tracing](/powerapps/developer/common-data-service/xrm-tooling/configure-tracing-xrm-tooling
) and performance reporting of the actions performed in Dynamics 365 Customer Engagement (on-premises), which you can configure based on your organization’s requirements.  


### See also 

[Sample: Quick start for XRM Tooling API](/powerapps/developer/common-data-service/xrm-tooling/sample-quick-start-xrm-tooling-api)<br />
[Simplified connection quick start](/powerapps/developer/common-data-service/xrm-tooling/sample-simplified-connection-quick-start)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]