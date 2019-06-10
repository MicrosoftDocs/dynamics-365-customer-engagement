---
title: "Set up Dynamics 365 for Marketing | Microsoft Docs"
description: "How to run the setup wizard for Dynamics 365 for Marketing"
keywords: setup; licensing; FRE; Azure; privacy; marketing services; marketing insights service
ms.date: 04/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: f722b098-be63-412a-aadc-7b34d11fa668
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

# Run the setup wizard

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Read this topic to learn how to set up a new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance after you have purchased a license.

> [!TIP]
> A trial version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is also available. If you'd like to set up a trial, see [Sign up for a free trial of Dynamics 365 for Marketing](trial-signup.md) for instructions. This topic describes how to set up a production version.

## Prerequisites and requirements

> [!IMPORTANT]
> To run the setup wizard, you must meet all the following requirements:
> 
> - You must already have a Microsoft 365 tenant.
> - **You must be running [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] or higher** (supplied together with most trial and stand-alone [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setups).
> - You must not already have a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app available on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instance. You can have at most one [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] per [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instance, and each  [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app can only be used with one [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instance.
> - You must sign into your tenant with a user account that has all the following:
>   - Admin privileges on the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instance where you are installing [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].
>   - Permissions to register applications in [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)]. The global administrator always has this right, but other accounts can also have it. See [Do I have permissions to register applications on Azure?](setup-troubleshooting.md#register-apps-azure) for information about how to confirm this setting for your account.
> - A known issue currently prevents you from running the setup wizard unless you have a Dynamics 365 for Customer Engagement license assigned to you on your tenant. However, although most of our customers do have this license, it's not actually required by the terms of the Dynamics 365 for Marketing license agreement. A workaround is available for users who need to install Marketing without having a Customer Engagement license assigned to them&mdash;see [Configuration, installation, and first-run experience](readme.md#configuration-installation-and-first-run-experience) in the readme for details.
> - An unconfigured [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app must be available on your tenant.
> - If you want to integrate with a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal (optional), then an unconfigured portal app must be available on your tenant. Depending on the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] licensing plan you have chosen, your license may include a free portal (provided no other free portals are already in use on your tenant), or you may need to purchase a portal license before you can set up the integration. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal)
> - You must be located in a country/region where the product is supported. To read the latest list of countries/regions where you can use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).
> - Close all other browser windows and tabs before starting.
> - Clear your browser cache before starting.
> 
> If you run into trouble while working with the setup wizard, see the [Administration and setup FAQ](setup-troubleshooting.md) for some possible solutions.

> [!IMPORTANT]
> Your system is constrained by certain limits and quotas that apply to the number of contacts you can market to, monthly email messages you can send, Litmus previews you can view, and more. Please familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you are running a trial, preview, or subscribed version of the product.
> 
> - For subscribed (paid) versions, please download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).
> - For trial and previews, see [Dynamics 365 for Marketing limits for trials and previews](trial-preview-limits.md).
> 
> You can keep an eye on your usage levels by going to  **Settings**  >  **Advanced settings**  >  **Other settings**  >  **Quota limits**  in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Quota limits](quota-management.md)
> 
> See also the  [Readme](https://go.microsoft.com/fwlink/p/?linkid=864736) document for the latest news and updates.

## Step 1: Launch the setup wizard

After purchasing your license for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll have an unconfigured [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app available on your tenant. To set up the app, you must run its setup from the **Applications** tab in the [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)], as described in [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md)

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses several other [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] components, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] services, and apps; the setup wizard will help you review all the relevant privacy policies and set up and integrate these various elements. Proceed as described in the following subsections.

> [!IMPORTANT]
> Most of the settings you make while running the setup wizard will be *permanent* for your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installation, so take care while filling it out.

## Step 2: Choose an organization and portal options

The first page of the wizard lets you choose where you will install the app and to choose whether to set up a portal to run your marketing pages and event website.

![Choose an organization and name your portal](media/setup-form-1.png "Choose an organization and name your portal")

Choose an instance and set your portal options:

1. Select the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization where you want to add [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. (A [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] *organization* is another name for a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] *instance*.)

1. Select one of the following **Web hosting** options:
    - **Use own webserver**: Select this option if you will run your landing pages and event website on an external webserver or CMS system. This option doesn't require a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals license and won't install the portal.
    - **Use Dynamics 365 portals**: Select this option if you will run your landing pages and event website on a dedicated [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal running on your tenant and linked to  your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. This requires a dedicated [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portals license. A free portals license is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but some restrictions apply&mdash;see [When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal) for details.

1. If you selected to **Use Dynamics 365 portals**, then enter a prefix for your portal URL in the field provided. You can also see what the full URL will be here. All your portals are hosted on your tenant, which uses a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]-owned domain name, plus the subdomain name that you choose here. Your contacts and customers can see the URL when they open a portal, so you should choose a subdomain name that they will recognize, such as your organization's name. The subdomain that you choose must also be unique among all other subdomains in the same tenant; you'll be notified to try again if you pick one that's already in use.

1. Select  **Continue**  to continue.

## Step 3: Give consent and enter your postal address

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes several services, solutions, and apps, some of which require you to consider and accept various license agreements and privacy statements. The second page of the setup wizard lists each of these and provides links for more information. It also asks you to enter your organization's postal address.

![Provide consent and enter your postal address](media/setup-form-2.png "Provide consent and enter your postal address")

Give consent and enter your postal address:

1. Carefully read the consent text shown for each check box, and follow the links to make sure you understand all the relevant issues. If you agree with the terms, then mark each check box as you go to indicate your consent. Some of these are optional, so you can still use the product without them, though the related features will be disabled. Other features are required, so you won't be able to use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] without agreeing to them.

2. Type the full physical street address for your organization in the field provided. All marketing email messages sent by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must include the physical street address of your organization, and several other required elements. These requirements help maximize email deliverability while also helping make sure you conform to common legal requirements for marketing email.  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices for email marketing](get-ready-email-marketing.md)

3. Select  **Setup**  to start setting up the app. A page will open that tracks the setup progress, which typically takes about half an hour.

## Privacy notice

[!INCLUDE[cc-privacy-marketing-fre](../includes/cc-privacy-marketing-fre.md)]

### See also

[How Dynamics 365 for Marketing uses cookies](cookies.md)  
[Engage with customers online with portals](portals.md)
