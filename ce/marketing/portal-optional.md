---
title: "Run Dynamics 365 for Marketing with a portal or portal-free (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to implement interactive marketing features with or without a Dynamics 365 portal with Dynamics 365 for Marketing"
keywords: portal; website; page; marketing page; event website
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: b908216e-f09b-4f12-a78c-658ba3cc3e48
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

# Decide whether to install Dynamics 365 for Marketing with or without a Dynamics 365 portal

Dynamics 365 for Marketing provides several features that enable contacts to interact directly with the system. These are:

- **Landing pages**, which provide forms that contacts can use to register for mailing lists, free downloads, webinars, or other perks
- **Subscription centers**, which enable contacts to manage their mailing list subscriptions and personal information
- **Forwarding pages**, which enable contacts to forward marketing emails they have received from you (while preserving accurate tracking info)
- **The event website**, which enables contacts to read about and register for your events

Each of these features requires one or more webpages that are available publicly on the internet. Each page must furthermore be able to fetch information from Dynamics 365 for Marketing and also be able to submit data back to it. There are two ways to accomplish this:

- **Use Dynamics 365 portals** : This option is based on a Dynamics 365 add-on product that runs directly on the same tenant as your Dynamics 365 for Marketing instance. It enables  you to go live with Marketing without needing to manage or modify your own website. To use this option, you must have a separate Dynamics 365 portals license for each Dynamics 365 for Marketing instance that uses portal features. A free portals license is provided with Dynamics 365 for Marketing, but you can only have [one free portal per tenant](setup-troubleshooting.md#why-portal), so you must purchase additional portals licenses if you want to use a portal with more than one Dynamics 365 instance on your tenant.
- **Use your own website or CMS system** : This option requires that you have your own website where you can host pages, add scripts, and embed forms from Dynamics 365 for Marketing. You can use this option in parallel with a Dynamics 365 portal if you wish.

Each time you [install Dynamics 365 for Marketing](purchase-setup.md), you must choose whether or not to integrate it with a portal. If you choose the portals option, then you must have an unconfigured portal available on the same tenant before you can complete the setup wizard, which will set up the integration for you. If you choose the non-portals option, then you&#39;ll be able to complete the Marketing setup even without an unconfigured portal available.

The following table compares how each of the public-facing interactive features works when you implement it using a Dynamics 365 portal or your own website.

|   | **With Dynamics 365 portals** | **Without Dynamics 365 portals** |
| --- | --- | --- |
| Landing pages | Design and publish landing pages using the [graphical page designer](create-deploy-marketing-pages.md) in Dynamics 365 for Marketing. | Design and publish landing pages on your own website or CMS system.<br><br>Enable forms by adding a Dynamics 365 for Marketing [form-capture script](embed-forms.md#form-capture) or by [embedding a marketing form](embed-forms.md#embed-form) created using the graphical form designer in Dynamics 365 for Marketing. |
| Subscription centers | Design and publish subscription centers using the [graphical page designer](create-deploy-marketing-pages.md) in Dynamics 365 for Marketing.<br><br>A [default subscription center](set-up-subscription-center.md#default-center) is also published on the service fabric used by your Dynamics 365 for Marketing instance. You can customize this page using the page designer in Dynamics 365 for Marketing. | Design and publish subscription centers for your own website or CMS system using techniques similar to those for creating landing pages. [Prefilling must be enabled](embed-forms.md#form-prefil) for subscription center forms.<br><br>To satisfy the legal requirement, a [default subscription center](set-up-subscription-center.md#default-center) is published on the service fabric used by your Dynamics 365 for Marketing instance. This allows you to run email marketing campaigns even without a portal or external website. You can customize this page using the [graphical page designer](create-deploy-marketing-pages.md) in Dynamics 365 for Marketing. |
| Forward-to-a-friend pages | Design and publish forwarding pages using the [graphical page designer](create-deploy-marketing-pages.md) in Dynamics 365 for Marketing. | Not supported. |
| Event website | The then-current version of the [event website](set-up-event-portal.md) is published automatically on the portal when you install Dynamics 365 for Marketing.<br><br>To update or customize the site, you can [download the latest version](developer/event-management-web-application.md) as an Angular project, customize it as needed using your preferred development tools, and then [publish the result on the portal](developer/portal-hosted.md). | [Download the current version](developer/event-management-web-application.md) of the [event website](set-up-event-portal.md) as an Angular project, customize it using your preferred development tools, and then [publish the result on your own website](developer/self-hosted.md). |

### See also

[Run the setup wizard](purchase-setup.md)  
[Create interactive features with or without portals](portals.md)  
[When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal)  
[Integrate with landing pages published on an external website](embed-forms.md)  
[Set up subscription lists and subscription centers](set-up-subscription-center.md)  
[Set up the event website](set-up-event-portal.md)  
[Build and host a custom event website](developer/event-management-web-application.md)