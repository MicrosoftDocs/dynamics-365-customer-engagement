---
title: "Build Windows client applications using the XRM tools (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "XRM tooling is a set of APIs that provides support for building Windows client applications for Dynamics 365"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e2f22576-1705-4854-a804-a1ca232c0cfc
caps.latest.revision: 33
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Build Windows client applications using the XRM tools


XRM tooling is a set of APIs built on top of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement SDK assembly APIs (Organization service and IDiscoveryService) that provide support for building [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] client applications for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. It provides the following capabilities:  
  
-   Supports all the authentication modes to sign in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], including OAuth.  
  
-   Provides [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] support for authentication and connection to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
-   Provides thread safety for actions performed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] in a multithreaded environment. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Multithreading in Components](https://msdn.microsoft.com/library/vstudio/3es4b6yy.aspx), [Thread-Safe Components](https://msdn.microsoft.com/library/vstudio/a8544e2s.aspx)  
  
-   Provides a common [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)] login control for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for consistent sign-in experience to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] from your Windows client applications.  
  
-   Supports secure storage of the sign-in credentials and reuse of the stored credentials to automatically sign in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] after initial sign in.  
  
-   Provides built-in diagnostic tracing and performance reporting of the actions performed in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], which you can configure based on your organization’s requirements.  
  
## Components of XRM tooling  
 XRM tooling has the following three components:  
  
- **Interface for developers**: This provides the low-level interaction and wrapper methods for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] SDK assembly APIs. It is an instrumented API that provides a thread safe environment for making calls to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] with built-in diagnostic capabilities to help you determine the performance of individual calls. It also provides a standard set of trace listeners for debugging support. The namespace for this component is <xref:Microsoft.Xrm.Tooling.Connector>.  
  
- **Common login control**: This is a WPF user control that provides a common user interface for the sign in experience to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. The login control provides support for all the authentication modes that are supported by [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. The common login control has built-in encryption for securely storing your credentials/profile, and then reusing it at runtime to automatically sign in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. The namespace for this component is <xref:Microsoft.Xrm.Tooling.CrmConnectControl>.  
  
- **Web resource utility**: This provides support for accessing information from the following two types of web resources in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]: Image and XML. You can access an image from a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web resource and return it as WPF BitmapImage objects. Similarly, you can return an XML web resource as a string. The namespace for this component is <xref:Microsoft.Xrm.Tooling.WebResourceUtility>.  
  
## Client applications that use XRM tooling  
 The following applications in the current version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] use the common WPF login control for authenticating users while signing in to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] from the client application:  
  
- [!INCLUDE[pn_unified_service_desk_for_crm](../includes/pn-unified-service-desk-for-crm.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Unified Service Desk Developer Guide](https://msdn.microsoft.com/library/dn864923.aspx)  
  
- Package Deployer tool. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Deploy packages using CRM Package Deployer and Windows PowerShell](../admin/deploy-packages-using-package-deployer-windows-powershell.md)  
  
- Configuration Migration tool. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage your configuration data](../admin/manage-configuration-data.md)  
  
### See also  
 [Sample: Quick start for XRM Tooling API](xrm-tooling/sample-quick-start-xrm-tooling-api.md)   
 [Use the Dynamics 365 Organization service](use-microsoft-dynamics-365-organization-service.md)   
 [Discover the URL for Your Organization With IDiscoveryService Web Service](org-service/discover-url-organization-organization-service.md)   
 [Write Applications and Server Extensions](extend-dynamics-365-server.md)   
 [Blog: PowerShell module for performing data operations and manipulating user and system settings in CRM](http://blogs.msdn.com/b/crm/archive/2015/09/25/powershell-module-for-performing-data-operations-and-manipulating-user-and-system-settings-in-crm.aspx)