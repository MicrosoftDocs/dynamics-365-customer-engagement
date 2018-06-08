---
title: "First time setup troubleshooting and FAQ (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Solutions to common questions and issues that can occur during the initial setup of Dynamics 365 for Marketing"
keywords: "troubleshooting;setup"
ms.date: 06/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4c2bc52f-595c-4728-9ef5-5e3281ca0cc0
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# First time setup FAQ and troubleshooting

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Read this topic to find answers to common questions and solutions to known issues that can sometimes occur during the initial setup of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

<a name="incompatible-platform"></a>

## Why is my instance (organization) incompatible with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]?

Your tenant might have several different types of instances (also called _organizations_) installed on it, including some that are full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instances and others that are, for example, [!INCLUDE[pn-power-apps](../includes/pn-power-apps.md)] instances (also called _environments_) that include many components of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], but not all of the components required by [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

When you are setting up your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app, the setup wizard asks you to choose an organization on which to install the app, and the organization selector can show both full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instances and the lighter [!INCLUDE[pn-power-apps](../includes/pn-power-apps.md)] instances. You must choose an instance that includes a full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] installation. If you see an error telling you that _this application isn't compatible with the platform of your selected [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization_, then make sure you have a full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization available (where you want to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]) and choose that one instead.

<a name="geo-support"></a>

## Why can't I install Marketing in my country/region?

Dynamics 365 for Marketing is a relatively new app for the Dynamics 365 platform, so it is not yet supported in all countries/regions where Dynamics 365 is available. If you are located outside of a supported country/region, then the setup wizard will prevent you from setting up the product, even if the Admin center shows that a Marketing app is available on your tenant. The reason you see the unconfigured app on your tenant is probably because you've licensed a Dynamics 365 product or bundle that includes it. You will be able to set it up as soon as support for the product is extended to your country/region.

These geographical restrictions apply both to trial and production versions of Dynamics 365 for Marketing.

To read the latest list of countries/regions where you can use [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF).

<a name="why-portal"></a>

## Why do I need a new portal, and how can I get one?

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] requires a dedicated [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] portals solution for running marketing pages and event portals. A free portal app is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], so usually this won't be an issue, but you can only have one free portal per [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] tenant. Some other [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] apps also include a free portal, so you might already have a configure-free portal on your tenant. The [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard will let you know if you need a new portal app.

If you don't have any unconfigured free or paid portals available, you have two options:

- Recycle an existing portal  
If you have a portal that you aren't using, then you can revert it to an unconfigured portal and then run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard to set it up for use with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. Please contact [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] Microsoft Support for assistance with recycling your portal.
- Purchase an additional portal  
If you are using all your existing portals, then you can purchase a new one for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] as described in the following procedure.

To get a new, unconfigured portal app and then use it with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]:

1. Open your [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] admin center and go to **Billing** > **Subscriptions**.

1. Choose **Buy add-ons** in the tile for your [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] subscription.

1. Purchase a new portal using the form provided.

    > [!IMPORTANT]
    > Be sure not to configure your new portal because the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard requires an _unconfigured_ portal to be present on your tenant. The wizard will configure the portal for you as required.

1. Run the [Marketing setup wizard](purchase-setup.md).

## Why do I get an authorization-failed message when I try to run the setup wizard?

In some cases, when you sign up for a trial of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] or [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)], you will receive an organization that is in an _unmanaged_ state, which means (among other things) that you can't get permission to install third-party solutions&mdash;including [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. As a result, you'll see the following error message when you run the setup wizard for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

![Unmanaged organization error](media/setup-ts-unmanaged-aad.png "Unmanaged organization error")

To fix this, do one of the following:

- If you are just setting up a trial of [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], then consider creating a new trial tenant and set up the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] trial there, as described in [Sign up for a managed Office 365 trial tenant and install the Marketing trial on it](trial-signup.md#get-managed-tenant).
- If you want to continue using the tenant where you received this error, then you must convert your unmanaged org into a managed one and then run the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] setup wizard again. For instructions about how to do this, see [Take over an unmanaged directory as administrator in Azure Active Directory](https://go.microsoft.com/fwlink/p/?linkid=866761).
