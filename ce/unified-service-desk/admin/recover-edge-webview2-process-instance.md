---
title: "Recover Edge WebView2 Process instances in Unified Service Desk | MicrosoftDocs"
description: "Learn about recovering an Edge WebView2 Process instance in Unified Service Desk."
ms.date: 06/21/2021
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-USD
  - dyn365-admin
monikerRange: '>= dynamics-usd-4.2'
---


# Recover Edge WebView2 Process instances



[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Edge WebView2 Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Edge WebView2 Process instance recovery is enabled.

## When Unified Service Desk can help recover Edge WebView2 Process instances

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover an Edge WebView2 Process instance in the following scenarios:

- When Edge WebView2 Process closes abruptly.
- When you manually end an unresponsive Edge WebView2 Process instance from Task Manager.

## Recover an unresponsive Edge WebView2 Process instance

When a hosted control that uses an Edge WebView2 Process browser control closes abruptly, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays the message "Edge WebView2 Process closed abruptly."


To recover the closed instance (which might contain more than one webpage), select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL.

 The Customer Service Dashboard application is hosted by using Edge WebView2 Process. When the Edge WebView2 Process instance closes abruptly, selecting the **Reload** option loads the Customer Service Dashboard application. If you don't want to recover the application, select **Cancel**.

If you cancel, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips recovery of the Edge WebView2 Process instance and displays the message "The webpage stopped responding. If you frequently experience unexpected closing of Edge WebView2 Process webpage, contact your system administrator."

### See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)  
[Use Edge WebView2 Process to host web applications](../edge-webview2-process.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
