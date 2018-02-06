---
title: "Create portals and interactive webpages (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How the Dynamics 365 Portals solution is integrated with Dynamics 365 for Marketing"
keywords: "portal; website; page; marketing page; event portal"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 465341c8-19fd-4da8-87aa-980c5ba10e26
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Engage with customers online with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes the full portal capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] solution, which it uses to enable features like the event portal and marketing pages. If those features are all you need, you never actually have to access the portal capabilities because [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] creates, configures, and manages these portals automatically. However, you can also use the portals solution to create custom portals and websites that include features that interact directly with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] data.

The portals solution is highly flexible and customizable. You can create portals for a wide variety of purposes (such as self-service, registration, and data management) and audiences (including customers, partners, and employees).

> [!NOTE]
> The portals solution is included with the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app and is available as an add-on for many other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications. For complete details about how to work with the portals solution, see [its online help](https://docs.microsoft.com/dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365).

## Open the portals area

Portals are shown as a work area for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Use the work-area menu to navigate between the portals and other work areas in the app, such as marketing, events, and settings.

![Navigation controls, expanded view](media/nav-expanded-ill.png "Navigation controls, expanded view")

## Customize the event portal

A full-featured events portal is provided with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. It is built by using the standard portals features, and its various elements are visible throughout the portals work area. The many features of the event portal are fully functional right out of the box. The information published there comes directly from your event-management data in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and it provides full support for any number of events.

Many organizations will find that the standard event portal fulfills all their needs, but if you'd like to customize it, you can do so by using the standard tools and entities of the portal capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] solution. The event portal is set up as a website named "Event Portal," and all the various other elements that it uses (templates, pages, files, and more) are shown as being part of that website.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up the event portal](set-up-event-portal.md)

## Work with marketing pages

Behind the scenes, each marketing page is created as a portal website that is hosted under the portal capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] solution. However, you won't find them listed anywhere in the portals work area. Instead you'll set them up by using the **Marketing Pages**, **Marketing Forms**, and **Marketing Form Field** entities in the **Marketing** work area. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and deploy marketing pages](create-deploy-marketing-pages.md).

To view traffic information about each marketing page (such as who visited, where they visited from, and for how long), go to **Marketing** &gt; **Internet Marketing** &gt; **Websites**, and then choose the **Marketing Page Websites** view from the view-selector menu at the top of the page. Here you'll see a separate website listed for each marketing page you have published. Select any of these to view the traffic information. Go back to the **Active Websites** view to see the list of standard websites that you are monitoring by using this feature. These are websites where you have added a tracking script generated by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], but which are not hosted as [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Register contacts' engagement with your Internet marketing initiatives](register-engagement.md)

### See also

[Deliver web engagement experience with portal capabilities for Dynamics 365](https://docs.microsoft.com/dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365)  
[Find your way around](navigation.md)