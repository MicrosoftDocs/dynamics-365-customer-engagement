---
title: "Set up Dynamics 365 for Marketing | Microsoft Docs"
description: "How to run the setup wizard for Dynamics 365 for Marketing"
keywords: "setup; licensing; FRE; Azure; privacy; marketing services; customer-insights services"
ms.date: 06/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f722b098-be63-412a-aadc-7b34d11fa668
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Run the setup wizard

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

After purchasing your license for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], or signing up for a trial, you'll have an unconfigured [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app available on your tenant. To set up the app, you must run its setup wizard.

- If you are setting up a [trial](trial-signup.md), then you will receive a link to the setup wizard in a welcome email. Click that link to launch the wizard.
- If you setting up a production instance, then launch the setup wizard from the **Applications** tab in the [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)], as described in [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md)

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses several other [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] components, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] services, and apps; the setup wizard will help you review all the relevant privacy policies and set up and integrate these various elements. Proceed as described in the following subsections.

> [!IMPORTANT]
> Most of the settings you make while running the setup wizard will be _permanent_ for your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installation, so take care while filling it out.

## Prerequisites and requirements

> [!IMPORTANT]
> To run the setup wizard, you must meet all the following requirements:
> 
> - You must already have an [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
> - **You must be running [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] or higher** (supplied together with most trial and stand-alone [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setups).
> - You must already have a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] license assigned to your user account on your [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant.
> - An unconfigured [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app must be available on your tenant.
> - An unconfigured portal app must be available on your tenant. Usually this is included with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], provided no other free portals are already in use on your tenant. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Why do I need a new portal, and how can I get one?](setup-troubleshooting.md#why-portal)
> - You must run the setup wizard as a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] user with admin privileges on the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance where you are installing Marketing.
> - You must be located in a country/region where the product is supported. To read the latest list of countries/regions where you can use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).
> - Close all other browser windows and tabs before starting.
> - Clear your browser cache before starting.
> 
> If you run into trouble while working with the setup wizard, see [First time setup FAQ and troubleshooting](setup-troubleshooting.md) for some possible solutions.

> [!IMPORTANT]
> Your system is constrained by certain limits and quotas that apply to the number of contacts you can store, monthly email messages you can send, monthly Litmus previews you can view, and more. Please familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you are running a trial, preview, or subscribed version of the product.
> 
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=874224).
> - For trial and previews, see [Dynamics 365 for Marketing limits for trials and previews](trial-preview-limits.md).
> 
> You can keep an eye on your usage levels by going to  **Settings**  >  **Advanced Settings**  >  **Others**  >  **Quota Limits**  in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Quota limits](quota-management.md)
> 
> See also the  [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

## Step 1: Choose an organization and name your portal

The first page of the wizard lets you choose where you will install the app and to choose an address where your portals and landing pages will run.

![Choose an organization and name your portal](media/setup-form-1.png "Choose an organization and name your portal")

Choose an instance and name your portal:

1. Select the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization where you want to add [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. (A [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] _organization_ is another name for a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] _instance_.) If you aren't already using any other [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] apps, you'll set up a new instance now. If you already have one or more instances, you'll be able to select an existing one that you want to integrate with the Marketing app, or create a new one.

1. Enter a prefix for your portal URL and enter it in the field provided. You can also see what the full URL will be here. The portals feature enables [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] to host webpages, accept values submitted by page visitors, and to update its database directly based on those values. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses the portals feature to publish marketing pages, subscription centers, event portals, surveys, and more. All your portals are hosted on a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] server, which uses a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]-owned domain name, plus the subdomain name that you choose here. Your contacts and customers can see the URL when they open a portal, so you should choose a subdomain name that they will recognize, such as your organization's name. The subdomain that you choose must also be unique among all other subdomains in the same [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] server; you'll be notified to try again if you pick one that's already in use.

1. Select  **Continue**  to continue.

## Step 2: Give consent and enter your postal address

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes several services, solutions, and apps, some of which require you to consider and accept various license agreements and privacy statements. The second page of the setup wizard lists each of these and provides links for more information. It also asks you to enter your organization's postal address.

![Provide consent and enter your postal address](media/setup-form-2.png "Provide consent and enter your postal address")

Give consent and enter your postal address:

1. Carefully read the consent text shown for each check box, and follow the links to make sure you understand all the relevant issues. If you agree with the terms, then mark each checkbox as you go to indicate your consent. Some of these are optional, so you can still use the product without them, though the related features will be disabled. Other features are required, so you won't be able to use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] without agreeing to them.

1. Type the full physical street address for your organization in the field provided. All marketing email messages sent by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must include the physical street address of your organization, and several other required elements. These requirements help maximize email deliverability while also helping make sure you conform to common legal requirements for marketing email.  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices for email marketing](get-ready-email-marketing.md)

1. Select  **Setup**  to start setting up the app. A page will open that tracks the setup progress, which typically takes about half an hour.

## Privacy notice

[!INCLUDE[cc-privacy-marketing-fre](../includes/cc-privacy-marketing-fre.md)]

### See also

[How Dynamics 365 for Marketing uses cookies](cookies.md)  
[Engage with customers online with portals](portals.md)
