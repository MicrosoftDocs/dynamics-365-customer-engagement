---
title: "Recover Edge WebView2 Process instances in Unified Service Desk | MicrosoftDocs"
description: "Know about recovering an Edge WebView2 Process instance in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/05/2021
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


# Preview: Recover an Edge WebView2 Process instance

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]


[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]
> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../../legal/supp-dynamics365-preview.md).

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Edge WebView2 Process in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

By default, **Edge WebView2** process instance recovery is enabled.

## When Unified Service Desk can help recover Edge WebView2 Process instances

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] can help agents to recover an Edge WebView2 Process instance in the following scenarios:

- When Edge WebView2 Process closes abruptly.
- When you manually end an unresponsive Edge WebView2 Process instance from Task Manager.

## Recover an unresponsive Edge WebView2 Process instance

When a hosted control that uses an **Edge WebView2** process browser control closes abruptly, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application displays the message **Edge WebView2 Process closed abruptly**.


To recover the closed instance (which may contain more than one webpage), select **Reload**. After you select **Reload**, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] reloads the webpage to the last known URL.


 In the above illustration, the **Customer Service Dashboard** application is hosted using the **Edge WebView2** process. The Edge WebView2 process instance closed abruptly and selecting the **Reload** option loads the **Customer Service Dashboard** application.

If you don't want to recover, select **Cancel**. If you cancel, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application skips recovery of the Edge WebView2 Process instance and displays a message, **The webpage stopped responding. If you frequently experience unexpected closing of Edge WebView2 Process webpage, contact your system administrator**.


## See also

[Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)

[Use Edge WebView2 Process to host web application](../edge-webview2-process.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]