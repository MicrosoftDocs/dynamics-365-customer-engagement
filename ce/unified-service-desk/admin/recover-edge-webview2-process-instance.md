---
title: "Recover Edge WebView2 Process instances in Unified Service Desk | MicrosoftDocs"
description: "Know about recovering an Edge WebView2 Process instance in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 03/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.2'
---


# Recover an Edge WebView2 Process instance

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Edge WebView2 Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, Edge WebView2 Process instance recovery is enabled.

## When Unified Service Desk can help recover Edge WebView2 Process instances

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover an Edge WebView2 Process instance in the following scenarios:

- When Edge WebView2 Process closes abruptly.
- When you manually end an unresponsive Edge WebView2 Process instance from Task Manager.
- When you manually end an unresponsive Edge WebView2 Process instance using a keyboard shortcut.

## Recover an unresponsive Edge WebView2 Process instance

When a hosted control that uses an Edge WebView2 Process browser control closes abruptly, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays the message **Edge WebView2 Process closed abruptly**.


To recover the closed instance (which may contain more than one webpage), select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL.


 In the above illustration, the **Customer Service Dashboard** application is hosted using the **Edge WebView2 Process**. The Edge WebView2 Process instance closed abruptly and selecting the **Reload** option loads tha **Customer Service Dashboard** application.

If you don't want to recover, select **Cancel**. If you cancel, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips recovery of the Edge WebView2 Process instance and displays a message, **The webpage stopped responding. If you frequently experience unexpected closing of Edge WebView2 Process webpage, contact your system administrator**.


## Limitations

### Unified Service Desk encounters a non-fatal error

While hosting web applications using the Edge WebView2 Process, Unified Service Desk crashes intermittently. However, the crash is non-fatal.
<br>
![Unified Service Desk fatal error](../media/unified-service-desk-fatal-error.PNG "Unified Service Desk fatal error")

**Workaround**
Select **No** to continue using Unified Service Desk, or select **Yes** to restart Unified Service Desk. 

## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

[Use Edge WebView2 Process to host web application](../edge-webview2-process.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]