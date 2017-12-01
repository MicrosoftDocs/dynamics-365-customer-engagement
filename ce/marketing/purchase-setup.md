---
title: "Set up Dynamics 365 for Marketing | Microsoft Docs"
description: "How to set up Dynamics 365 for Marketing for the first time"
keywords: "setup; licensing; FRE; wizard; Azure; customer insights"
ms.date: 12/15/2017
ms.service: crm-online
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

# First time setup

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

This topic explains how licensing works, how to set up the system for the first time, and how to rerun the setup wizard if you need to change your setup later. It also provides important privacy information.

## Prerequisites and requirements

> [!IMPORTANT]
> A setup wizard is provided to help you set up [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for the first time. Before running the wizard, you must meet all of the following requirements:
> - Use Google Chrome (only)
> - Put your browser in incognito mode
> - Turn off all pop-up blockers
> - Close all other browser windows and tabs before starting
> - Clear your browser cache before starting
> - You must sign into [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] as a _global administrator_ (also known as a _tenant admin_).  [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [About Office 365 admin roles](https://support.office.com/en-us/article/About-Office-365-admin-roles-da585eea-f576-4f55-a1e0-87090b6aaa9d)
> - You must already be assigned a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] license in [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)].
> - [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] to process contact information, define market segments, and more. During the setup, you can choose to use a [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] account created and managed by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] specifically for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but you might also choose to use your own, fully licensed account to gain access to more [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] features. _If you do choose to use your own [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] account, please note that it must be running on the same tenant as [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]_.
> 
> Once the setup is complete, we recommend that all users also use Google Chrome, though most browsers should also work fine, and wider browser support is expected soon.

## How licensing works

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is provided as a cloud-based solution that is linked to your [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] organization. You can add it to your [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] subscription by going to the [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Commerce Portal, but you might instead use some other sales channel. After you've set up the app, you'll be able to use the user-admin settings in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to create user accounts and set the required access permissions for each user you've licensed.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is available with a variety of bundles and licensing options, the specifics of which will depend on your subscription agreement. Typically, your agreement will include quotas for bulk email messages, contact records, [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] storage, Litmus inbox previews, user licenses, and other allotments. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] provides tools that help you keep an eye on your total and monthly quotas and purchase extra capacity as needed. Please refer to your own subscription agreement and to the [!INCLUDE[pn-ms-dyn-365](../includes/pn-ms-dyn-365.md)] sales websites and other sales channels for specific details about bundles, pricing, and quotas.

<a name="choose-dci-option"></a>

## How to choose your [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] option

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses an [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] service called [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] to store and process customer information. It's used for features such as defining marketing segments, storing and processing email-interaction results, and more. When you are setting up [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you must choose whether to run [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] on the default [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] account included with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], or to bring your own, full-featured [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] hub running on your own [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription.

> [!IMPORTANT]
> As with most of the settings presented by the setup wizard, your choice of [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription for running [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] is _permanent_ and can't be changed after you complete the wizard. There is no way to migrate the data later. Please consider your options and make your choice carefully.

For more information about [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-short.md)] and its many capabilities, see [Dynamics 365 for Customer Insights](https://go.microsoft.com/fwlink/p/?linkid=863946).

The following table summarizes the differences between the two options for running [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

|Use the default [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription  | Bring your own [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription |
|----------------|-----------------------------------------------------------------------------|
| Included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. | Sign up for your own [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] account and add a [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] hub to it.  |
| The setup wizard connects automatically.  | The setup wizard provides links to help you sign up for [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] and [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] (as needed), and guides you through the settings required to establish the connection with [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]. |
| The service is managed and maintained for you by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]. | You must manage and maintain the service yourself. |
| You won't have direct access to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] or its advanced features. | You'll have full access to all [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] features, including the ability to load third-party data, generate reports, connect to other systems, and more. |
| Your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] subscription includes a quota of monthly credits for [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] data, but additional charges may apply if you exceed this quota. See your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] subscription agreement for details of how much [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] data it includes.| You receive the same number of monthly credits for [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] data as you would when using the default [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)]  subscription, but they are automatically applied to the private [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription that you set up for use with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Additional charges may apply if you exceed the quota specified in your [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] subscription agreement.|

## First-time setup

After purchasing your initial license for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you'll receive the URL required to access the app. The first time you open the link, you'll launch a setup wizard that guides you through the initial setup. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses several other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] components, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] services, and apps; the wizard will help you review all the relevant privacy policies and set up and integrate these various elements.

> [!IMPORTANT]
> Most of the settings you make while running the setup wizard will be *permanent* for your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] instance, so take care while filling it out. One exception to this is the password (policy primary key) for [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)], which you will be able to update later by rerunning the setup wizard. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Rerun the setup wizard to update your Customer Insights key](#rerun-the-setup-wizard-to-update-your-customer-insights-key)).

The remaining sections of this topic provide details about each step of the setup wizard.

### Step 1: The Organization Selector page

A [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] organization (org) is the foundation on which all [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] Customer Engagement apps are built. All the various [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps installed on a given org can potentially be integrated with one another and share data in various ways. If you aren't already using any other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] apps, you'll set up a new org now. If you already have one or more orgs, you'll be able to select an existing one that you want to integrate with the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app, or create a new one.

![The Organization Selector page](media/fre-org-select.png "The Organization Selector page")

Do the following:

1. Use the **Select an organization** drop-down list to choose an existing [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] org.

1. The page includes two check boxes that describe the licensing and privacy policies that apply to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Read the text for each check box carefully, and follow the links provided for complete details. If you agree with all the terms, select the check boxes. If you don't agree with the privacy policy, quit the setup wizard, but you can continue without installing the email templates if you prefer.

1. Select **Continue** to continue.

### Step 2: The Customer Insights page

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] to process contact information, define market segments, and more. On this page of the setup wizard, you can choose to run [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] on an [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] account created and managed by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] specifically for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], or you might instead choose to use your own, [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription to gain access to more [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] features.

> [!IMPORTANT]
> If you choose to use your own [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription, please note that it must be running on the same tenant as [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [How to choose your Customer Insights option](#choose-dci-option)

![The Customer Insights page](media/fre-customer-insights.png "The Customer Insights page")

To use the default[!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] account included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], do the following:

1. Set the drop-down list on this page to **Use default**.

1. Carefully read the check box text at the bottom of the form, and follow and read all the links provided. This text and its links provide important privacy information and describe the privacy policy for [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)]. If you agree with the policies described, select the check box. If you don't accept these terms, quit the setup wizard.

1. Select **Continue** to start the setup and integration process for [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] and continue with the wizard.

To use your own [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] subscription instead of the default account, go to [Use your own Azure subscription for Customer Insights](setup-licensed-dci.md), and then return here to continue.

### Step 3: The Portal page

The portals feature enables [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] to host webpages, accept values submitted by page visitors, and to update its database directly based on those values. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses the portals feature to publish marketing pages, subscription centers, event portals (with online event registration), surveys, and more. As with many other [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] elements, you can integrate [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] with an existing [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] Portals instance if you have one, or set up a new portal instance. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Engage with customers online with portals](portals.md)

![The Portal page](media/fre-portal.png "The Portal page")

Do the following:

1. The **Portal** page shows a list of portals that are already available to your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] org. Choose the option for the portal you want to use with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. The portal you choose must support the events portal feature.

1. The button in the **Actions** column is labeled **Configure** (for new portals), **Change** (for existing portals), or **Retry** (for portals that could not be set up for some reason). Select this button for the portal you selected to open its configuration settings.

1. The **Configure Portal** flyout opens. Make the following settings:
    - **Portal Name**: enter a name for the portal. The name is used to identify this portal in various [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] settings pages (such as this one). Choose a name that will be easy to recognize later.
    - **Portal Subdomain**: all portals are hosted on your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] server, which uses a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)]-owned domain name, plus a subdomain name that you choose (separated by a period). The resulting address will look something like this: https://&lt;YourSubdomain&gt;.&lt;DynamicsDomain&gt;.com. Your contacts and customers will be able to see the URL when they open a portal, so you should choose a subdomain name that they will recognize (such as your organization's name). The subdomain that you choose must also be unique among all other subdomains in the same [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] server; you'll be notified to try again if you pick one that's already in use.

1. Select **Begin Setup** to close the flyout and start setting up the portal.

1. Select **Continue** to continue with the wizard.

### Step 4: The Marketing Email page

All marketing email messages sent by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must include the physical street address of your organization, and several other required elements. These requirements help maximize email deliverability while also helping make sure you conform to common legal requirements for marketing email. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Best practices for email marketing](get-ready-email-marketing.md)

![The Marketing Email page](media/fre-email.png "The Marketing Email page")

Do the following:

1. Type the full physical street address for your organization in the field provided.

1. Select **Continue** to continue with the wizard.

### Step 5: The Survey page

The [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] Surveys app enables you to run online surveys by using a feature called Voice of the Customer. The app is included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but has a separate privacy policy that you must read and accept before you can enable it. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and run online surveys](surveys.md)

![The Survey page](media/fre-survey.png "The Survey page")

Do the following:

1. As soon as the **Survey** page opens, a dialog box opens asking whether you want to allow the app to access your information. This is required for the feature to function. Read the information carefully, and select **Yes** if you agree. If you don't agree, select **No** and then quit the setup wizard.

    > [!IMPORTANT]
    > If you don't see the pop-up dialog, then your browser may be blocking them. Disable your pop-up blocker and then reload the **Survey** page before continuing. Your setup will fail if you continue without agreeing to the message shown in the pop-up.

1. The **Survey** page includes a check box, which you must select to indicate that you have read and agreed to its terms of service. Read the check box text carefully and follow its links for complete details. If you agree to the license terms and privacy policies that apply for the feature, select the check box. If you don't agree, quit the setup wizard.

1. Select **Begin Setup** to start the setup and integration process for Surveys.

### Step 6: The Summary page

You are now done entering settings. The wizard will continue to set up your system. You can track its progress on this page if you like, or you can close the page and wait for an email to arrive announcing that the process is complete. The email will be sent to the address associated with your [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] account.

![The Summary page](media/fre-summary.png "The Summary page")

<a name="rerun-the-setup-wizard-to-update-your-customer-insights-key"></a>

## Rerun the setup wizard to update your [!INCLUDE [pn-customer-insights-short](../includes/pn-customer-insights-short.md)] key

As mentioned earlier in this topic, most of the settings you made while running the setup wizard are permanent for your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] instance. One exception to this is the password (policy primary key) for [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)], which you can only update by rerunning the setup wizard.

To rerun the wizard, go to the **Settings** work area of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and select the **Go to installation setup** link at the top of any page here. The setup wizard launches, behaving just like it did the first time you ran it, but this time only the key field on the **[!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)]** page will be active; all other settings are read-only. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Open advanced settings](open-advanced-settings.md).

## Privacy notice

[!INCLUDE[cc-privacy-marketing-fre](../includes/cc-privacy-marketing-fre.md)]

### See also

[Use your own Azure subscription for Customer Insights](setup-licensed-dci.md)  
[How Dynamics 365 for Marketing uses cookies](cookies.md)