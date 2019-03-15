---
title: "Browser requirements for Dynamics 365 for Marketing | Microsoft Docs"
description: "Learn about the browser requirements for Dynamics 365 for Marketing"
keywords: browser;requirements
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 69bb4966-4abc-474a-8696-216441f1f530
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Browser and system requirements

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is a cloud-based service that does not require special software other than an up-to-date web browser. The system and browser requirements for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] are the same as those for [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] plans for business, education, and government, as listed in  [System requirements for Office](https://go.microsoft.com/fwlink/p/?LinkId=723597).

## General browser configuration

Regardless of which supported browser you use, you must configure your browser as follows:
- **Allow pop-up windows from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]**  
  You must configure your browser to allow all pop-up windows from your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] domain (see your browser’s documentation for instructions). Most modern web browsers block all pop-up windows by default. Some browsers alert you when they block a pop-up window, (for example by showing an icon in the address bar), but others do not. 
- **Allow JavaScript from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]**  
  JavaScript must be enabled for your browser, at least for your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] domain. Most browsers enable JavaScript by default.
- **Allow cookies from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]**  
  Cookies must be enabled for your browser, at least for your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] domain. Most browsers enable cookies by default.

## Enable touch for Microsoft Edge browsers

If you are using [!INCLUDE[pn-microsoft-edge](../includes/pn-microsoft-edge.md)] on a touch device, such as a tablet, then you must do the following to enable the touch-based drag-and-drop features:
1. Run [!INCLUDE[pn-microsoft-edge](../includes/pn-microsoft-edge.md)].
2. Type "about:flags" into the address bar and select **Enter**.
3. A page of local browser settings opens. Under **Standards Preview**, set **Enable touch events** to **Always on**.
4. Restart your browser.
