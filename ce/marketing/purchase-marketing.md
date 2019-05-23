---
title: "License a Marketing app and add it to your tenant (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to get started with Dynamics 365 for Marketing by purchasing a license and adding the app to your tenant"
keywords: purchase;setup
ms.date: 04/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: cb596c13-98fd-4717-adcf-c432609788a1
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

# Purchase a production version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

If you already have a paid [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instance in use (probably with other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps running on it), then you can integrate [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] with your instance by adding a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app to your tenant and then assigning it to the appropriate instance.

> [!IMPORTANT]
> - [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can only be used on instances running [!include[pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)] or higher.
> - You can only install the product if you are located in a country/region where it is supported. To read the latest list of countries/regions where you can use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).

<a name="how-licensed"></a>

## How [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] is licensed

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is licensed per instance, with each instance priced according to the number of *marketing contacts* stored in your database. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] license. While you're planning your marketing activities, please be sure to purchase enough marketing contacts to remain within your quota.

> [!NOTE]
> When you sign up for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll choose a licensing option that defines your contract period and various quotas for that period. Each of the contacts that you engage through marketing activities during the contract period count against your total contact quota, even if you delete, or otherwise stop marketing to, an existing marketing contact during the contract period. You can only reduce your purchased contact quota on contract renewal date.

Unlike most other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps, [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] isn't priced per user, so users already licensed to access any [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] app on an instance where [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] is installed will also be able to access [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] without requiring you to purchase any additional licenses. You can even request any number of free (&quot;zero dollar&quot;) [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] licenses to assign to users that don't have a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] license, but these aren't valid for apps other than [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

In some cases, you may be entitled to a free [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] license for one or more of your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] instances. This may be triggered by purchasing a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] app bundle and/or by purchasing a certain minimal number of seat licenses for your other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps. Free licenses such as these usually also include a limited quota of free marketing contacts, which you can increase by purchasing additional capacity.

You can choose to run your marketing pages, landing pages, and events website either on an external web server (such as your own CMS system) or on a Dynamics 365 portal running on the same tenant as your Dynamics 365 for Marketing instance. If you want to run these features on a Dynamics 365 portal, then you must have a free portals license available on your tenant before you run the Dynamics 365 for Marketing setup wizard, but if you will use an external website, then no portals license is needed. (Depending on the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] licensing plan you have chosen, your license may include a free portal provided no other free portals are already in use on your tenant.) [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [When do I need a portal license, and how can I get one?](setup-troubleshooting.md#why-portal)

For more information about licensing, see the [Administration and setup FAQ](setup-troubleshooting.md). For complete licensing details, including specific quotas and other conditions, see the  [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544).

## Add a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app to your Microsoft 365 tenant

There are many ways to add one or more [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps to your Microsoft 365 tenant. For example, you can purchase it from the [Dynamics 365 for Marketing overview page](https://dynamics.microsoft.com/en-us/marketing/overview/), or by going to **Billing** > **Purchase services** in your Microsoft 365 admin center, or by contacting your Microsoft sales representative or channel partner. As mentioned previously, you might even qualify to have a free [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app added to your tenant.

- On purchasing a license, an unconfigured [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] app will be automatically added to your tenant.
- If you are entitled to a free license, then see [My Dynamics 365 for Customer Engagement license agreement entitles me to a free Dynamics 365 for Marketing license. How can I get the free app added to my tenant?](setup-troubleshooting.md#claim-free-license) for details about how to find or obtain it.

You can have any number of [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps available on your tenant. Initially, each of these apps will be unconfigured and unassigned to any [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance. Later, you'll run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard to assign the app to an instance and configure it.

<a name="set-up-app"></a>

## Set up an unconfigured [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app

When a new [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app gets added to your tenant, it begins in an unconfigured state. To set it up for use with an existing [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instance:

1. Go to [admin.microsoft.com](https://admin.microsoft.com) and sign in to your Microsoft 365 tenant using an administrator account that has a [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] license assigned.

2. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

3. Go to the **Applications** tab of the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] admin center.
   > [!IMPORTANT]
   > Don't work on the **Instances** tab when setting up [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. Though you can open details about an instance there and see that the various [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps and solutions are available, your setup is likely to fail or be incomplete if you try to work from there.

   ![Set up Marketing using the Applications tab, not the Instances tab](media/purchase-app-tab.png "Set up Marketing using the Applications tab, not the Instances tab")

4. Find a **Dynamics 365 Marketing Application** in the list on the **Applications** tab.
   > [!NOTE]
   > If you see the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app listed several times, then you probably have several [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps available on your tenant. [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps that are already configured show an instance ID appended to the app name and show a value of **Configured** in the **Status** column. [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] apps that aren't assigned show a value of **Not configured** in the **Status** column and don't include an instance ID in their name.

5. Select an unconfigured [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app in the list and then choose **Manage** from the side panel.  
    ![Choose an app and then select the Manage button](media/purchase-manage-button.png "Choose an app and then select the Manage button")

6. The setup wizard launches, which you will use to make initial settings for the app (including the choice of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance to install on (here called an *organization*)). Follow the instructions in [Run the setup wizard](purchase-setup.md) as you work through the setup wizard.
