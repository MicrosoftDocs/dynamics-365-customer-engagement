---
title: "Administration frequently asked questions (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Solutions to common questions and issues that can occur during the initial setup and administration of Dynamics 365 for Marketing"
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

# Administration FAQ

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Read this topic to find answers to common questions and solutions to known issues that can sometimes occur during the initial setup and ongoing administration of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

<a name="incompatible-platform"></a>

## Why is my instance (organization) incompatible with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]?

Your tenant might have several different types of instances (also called _organizations_) installed on it, including some that are full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instances and others that are, for example, [!INCLUDE[pn-power-apps](../includes/pn-power-apps.md)] instances (also called _environments_) that include many components of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], but not all of the components required by [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

When you are setting up your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app, the setup wizard asks you to choose an organization on which to install the app, and the organization selector might show both full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] instances and the lighter [!INCLUDE[pn-power-apps](../includes/pn-power-apps.md)] instances if they are present. You must choose an instance that includes a full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] installation. If you see an error telling you that _this application isn't compatible with the platform of your selected [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization_, then make sure you have a full [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] organization available (where you want to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]) and choose that one instead.

<a name="geo-support"></a>

## Why can't I install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] in my country/region?

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is a relatively new app for the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] platform, so it is not yet supported in all countries/regions where [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] is available. If you are located outside of a supported country/region, then the setup wizard will prevent you from setting up the product, even if the Admin center shows that a [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app is available on your tenant. The reason you see the unconfigured app on your tenant is probably because you've licensed a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] product or bundle that includes it&mdash;you'll be able to set it up as soon as support for the product is extended to your country/region.

These geographical restrictions apply both to trial and production versions of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

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

<a name="partial-setup"></a>

## It looks like [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] is set up on my instance, but why does it generate so many errors?

If [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] is visible on your instance, by nothing is working, then you might have just a partial installation. This can happen if you use the [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)] to set up [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] as a service (on the **Instances** tab) rather than as an app (on the **Applications** tab). As a result, you might have the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] service installed, but not its many supporting components.

To fix this, go back to the [Dynamics 365 admin center](dynamics-365-admin-center.md) and reinstall from the **Applications** tab as described in [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md). The setup wizard should fix your installation.

![Set up Marketing using the Applications tab, not the Instances tab](media/purchase-app-tab.png "Set up Marketing using the Applications tab, not the Instances tab")

<a name="run-fre"></a>

## How can I rerun the setup wizard?

If your setup fails for some reason, you'll be notified by email and/or by a status message in your web browser (if you keep it open during the install). Often, part of the solution will be to rerun the setup wizard after waiting for an hour or so. To rerun the setup wizard, do one of the following:

- If you are setting up a [trial](trial-signup.md), then you should have received a welcome email that included a link to the setup wizard. Find your welcome mail and click that link to launch the wizard.
- If you setting up a production instance, then launch the setup wizard from the **Applications** tab in the [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)], as described in [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md).

<a name="reset-portal"></a>

## How can I reset the portal?

Marketing pages and the event portal both run on the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] portals app. Sometimes, you may notice that settings you make in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] aren't reflected on the portal right away, such as (for the event portal): updates to banner images, speaker images, or payment gateway assignments. Also, if your portal becomes unresponsive or otherwise unreliable, it can often help to go in an reset it.

To reset your portal:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md) and go to the **Applications** tab .

1. Each configured portal app is listed in the **Application** column using the name of the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] it is assigned to (so it probably doesn't have "portal" in its name), and shows a value of **Configured** in the **Status** column. Find and select your portal in the list and then select **Manage** in the side panel.  
    ![Select your portal](media/faq-portal-manage.png "Select your portal")

1. The portals manager opens. Select **Portal actions** in the side panel, and then select the **Restart** tile to reset the portal.  
    ![Open portal actions and then select restart](media/faq-portal-manage2.png "Open portal actions and then select restart")

1. You'll be asked to confirm the action. Choose **Restart** to continue and then allow a few minutes for the process to complete.

<a name="portal-url"></a>

## How can I fix my portal after changing my instance name?

The [!INCLUDE[pn-dyn-365-admin-center](../includes/pn-dyn-365-admin-center.md)] enables you to change the  name of any of your instances at any time. If you do so, then the URL for the affected instance will also change to match and, as a result, your portal will no longer be configured correctly and will stop working. To fix it, you must reconfigure your portal as follows:

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md) and go to the **Applications** tab .

1. Each configured portal app is listed in the **Application** column using the name of the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] it is assigned to (so it probably doesn't have "portal" in its name), and shows a value of **Configured** in the **Status** column. Find and select your portal in the list and then select **Manage** in the side panel.  
    ![Select your portal](media/faq-portal-manage.png "Select your portal")

1. The portals manager opens. Select **Portal actions** in the side panel, and then select the **Update [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] URL** tile to update the URL.  
    ![Open portal actions and then update the URL](media/faq-portal-manage3.png "Open portal actions and then update the URL")

1. You'll be asked to confirm the action. Choose **Update URL** to continue and then allow a few minutes for the process to complete.

<a name="contact-support"></a>

## How can I contact support if I still need help?

If you’ve already tried to set up the application several times and are still having trouble, please open a support case through your applicable [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Premier channel or MPN partner channel.

For more information about how to contact [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] directly, and how to find forums, FAQs, and other resources, please see the following:

- [Contact technical support](../admin/contact-technical-support.md)
- [Help and additional resources](../admin/help-additional-resources.md)
- [Support for Microsoft Dynamics 365](https://go.microsoft.com/fwlink/p/?linkid=875262)