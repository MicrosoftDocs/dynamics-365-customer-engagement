---
title: "Browser requirements for Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about the browser requirements for Dynamics 365 Marketing."
ms.date: 08/16/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Browser and system requirements

Dynamics 365 Marketing is a cloud-based service that does not require special software other than an up-to-date web browser, though some restrictions apply. Read this topic to find out which devices, browser, and browser settings you should use when working with Dynamics 365 Marketing.

In most cases, Dynamics 365 Marketing supports the same browsers and mobile devices as other model-driven apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation). These are described in [Requirements/supported configurations](https://docs.microsoft.com/power-platform/admin/online-requirements), though some Dynamics 365 Marketing features may require slightly newer systems, and a few other exceptions apply, as specified in this topic.

## Supported desktop browsers

The [desktop browser requirements](https://docs.microsoft.com/power-platform/admin/web-application-requirements) for Dynamics 365 Marketing are the same as those for other model-driven apps in Dynamics 365.

## Supported tablet browsers

You can use the following OS/browser combinations to work with Dynamics 365 Marketing on a tablet:

- Apple iOS 11 (or higher) with the current Apple Safari browser
- Google Android 7 (or higher) with the current Google Chrome browser
- Microsoft surface tablets running any supported desktop browser

## Accessibility

Dynamics 365 Marketing has been tested to work correctly with the following accessibility technologies:

- Microsoft Edge browser (current version) with Microsoft Narrator screen reader
- Google Chrome browser (current version) with NV Access NVDA screen reader
- Google Chrome browser (current version) with Freedom Scientific JAWS screen reader
- Google Android Talkback screen reader
- Apple iOS Voice Over screen reader

## Browser configuration

Regardless of which supported browser you use, you must configure your browser as follows:

- **Allow pop-up windows from Dynamics 365 Marketing**<br>You must configure your browser to allow all pop-up windows from your Dynamics 365 Marketing domain (see your browser's documentation for instructions). Most modern web browsers block all pop-up windows by default. Some browsers alert you when they block a pop-up window, (for example by showing an icon in the address bar), but others do not.
- **Allow JavaScript from Dynamics 365 Marketing**<br>JavaScript must be enabled for your browser, at least for your Dynamics 365 Marketing domain. Most browsers enable JavaScript by default.
- **Allow cookies from Dynamics 365 Marketing**<br>Cookies must be enabled for your browser, at least for your Dynamics 365 Marketing domain. Most browsers enable cookies by default.

## Enable touch for Microsoft Edge browsers

If you are using Microsoft Edge on a touch device, such as a tablet, then you must do the following to enable the touch-based drag-and-drop features:

1. Run Microsoft Edge.
2. Type &quot;about:flags&quot; into the address bar and select Enter.
3. A page of local browser settings opens. Under Standards Preview, set Enable touch events to Always on.
4. Restart your browser.

## Supported email clients

Marketing emails created and delivered using Dynamics 365 Marketing, including all templates included with Dynamics 365 Marketing, will render correctly on a wide range of recipient email clients, though older clients typically support fewer formatting options. For a complete list of tested email clients, see [Tested email clients](email-templates.md#tested-clients)


[!INCLUDE[footer-include](../includes/footer-banner.md)]