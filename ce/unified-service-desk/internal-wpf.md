---
title: "Use Internal WPF hosting method for your controls in Unified Service Desk | MicrosoftDocs"
description: "Learn about the Internal WPF hosting methods for your controls in Unified Service Desk."
ms.date: 12/01/2018
ms.topic: "article"
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
ms.custom: 
  - dyn365-USD
monikerRange: '>= dynamics-usd-3'
---

# Use Internal WPF to host web applications 

> [!Note]
>
> Because support for Internet Explorer 11 is deprecated, support for IE Process has also been deprecated in Unified Service Desk. For information: [Deprecation announcement](../customer-service/deprecations-customer-service.md#internet-explorer-11-support-for-dynamics-365-and-microsoft-power-platform-is-deprecated).

 The `Internal WPF` browser control uses the [WpfBrowser](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.controls.wpfbrowser) component, which is based on the [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)][WebBrowser](/dotnet/api/system.windows.forms.webbrowser) control, to host the webpages in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. This browser control is the traditional method of hosting controls in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. It uses the security subsystem in [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] and [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] to allow the hosted application to operate the browser functionality in the same mode as the application without changing the [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] settings, and therefore reduces the security of Internet Explorer for applications outside of Unified Service Desk. While there are advantages, occasionally you may find that you need the features of an [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] add-in or a feature in the native browser that may not be supported in this browser control, and you should use the **IE Process** browser control instead.

 ### See also  
 [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)   

 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   

 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
