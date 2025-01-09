---
title: "WinDDA in Unified Service Desk | MicrosoftDocs"
description: "Learn about the Windows data-driven adapter (WinDDA) and its binding elements to access HTML-based applications in Unified Service Desk."
ms.date: 06/27/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: evergreen
---
# WinDDA
[!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)] data-driven adapter (WinDDA) is used to interact with Windows-based applications. The key technology used in the data-driven adapter is Microsoft Active Accessibility (MSAA), with some functionality covered through Win32 function calls. The MSAA API allows you to automate the user interface. An application can use this API to make its interface more accessible to users with accessibility issues. Although modifying a user interface (UI) to make it more accessible to users is the primary intent of the API, it can also be used for [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] integration. Windows generates accessibility proxy objects for Windows controls that don’t explicitly provide their own MSAA support. The use of proxy objects provides an alternative to the more common approach of controlling an application through Windows API calls. It also allows you to control any application type (beyond Win32) that exposes its user interface through MSAA.  
  
## WinDDA tags and events  
 The WinDDA consists of the following tags that are used to define a control:  
  
- [AccControl Tag](../unified-service-desk/acccontrol-tag.md)  
  
- [AccSelector Tag](../unified-service-desk/acc-selector-tag.md)  
  
- [Next Tag](../unified-service-desk/next-tag-windda.md)  
  
- [FindWindow Tag](../unified-service-desk/find-window-tag.md)  
  
  The following topic provides information about the events that the WinDDA supports:  
  
- [WinDDA events](../unified-service-desk/win-dda-events.md)  
  
### See also  
 [Use Data Driven Adapters](../unified-service-desk/use-data-driven-adapters-ddas.md)   
 [WebDDA](../unified-service-desk/web-dda.md)   
 [UIADDA](../unified-service-desk/uiadda.md)   
 [JavaDDA](../unified-service-desk/javadda.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
