---
title: "Preview features (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Learn what preview features are, and how to activate and use them in Dynamics 365 for Marketing"
keywords: preview
ms.date: 01/02/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: d27cf07f-3cef-4fdb-8d12-ffea28ed6f50
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

# Activate and use preview features

From time to time, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] makes new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] features available as *preview features*, which you can enable and use if you want to get familiar with upcoming features before they're officially released and fully supported. Read this topic to learn about which preview features are currently available, how to activate them, and how to use them.


> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

## Enable preview features

Most preview features aren't installed or enabled by default. A system administrator must explicitly enable and install them before they will become available to any instance. To enable the current preview features:

1. Sign in to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (or any app on your tenant) as an administrator.

1. Go to your [Power platform admin center](https://admin.powerplatform.microsoft.com/).

1. Select **Environments** in the side navigator. A list of environments on your tenant opens. (Environments are also sometimes called *instances* or *organizations*.)

1. Select the environment where you have [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installed want to enable the preview.
    > [!NOTE]
    > We highly recommend that you only enable preview features on a [sandbox environment](manage-marketing-instances.md), not on a production environment. Sandbox environments can be reset, backed up, and restored as you test features without impacting your production users.

1. Select **Settings** on the command bar.

1. On the **Settings** page, select **Product** > **Features**. The features settings for your selected environment are shown.

1. Set the **April 2009 release** slider to **On**.

1. Select **Save** to save your settings.

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Go to the **Applications** tab of the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] admin center.

1. Find a **Dynamics 365 Marketing Application** in the list on the **Applications** tab

1. Select the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app where you want to enable the preview, and then choose **Manage** from the side panel.  

1. The setup wizard launches, which should now show a message that an update is available. Follow the instructions on your screen to update your selected app.

1. The preview features are now available on the application and environment you selected.

See the remaining sections of this topic for details about how to find and use the preview features.

<a name="config-social"></a>

## Preview: Social posting

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can schedule and post messages directly to your organization's accounts on social media sites. In the current preview version, only Twitter is supported, but we expect to add more social media channels when this feature becomes generally available.

### Configure your social media accounts

Before you can start posting to social media, an administrator must sign in and connect to the social accounts where users want to post and schedule messages.

To add and authenticate a social media account:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**. A list view opens showing your existing social media accounts (if any).
1. Select **New** on the command bar.
1. A new social configuration record opens. Make the following settings:
    - **Name**: Enter a name that you and others will easily recognize. Choose a name that gives a good idea what type of channel it is what type of content should be posted there, such as "Contoso Electronics Twitter."
    - **Social channel**: Choose the social-media site you want to connect to (such as Twitter).
1. Select **Sign in** on the command bar.
1. Follow the instructions on your screen to sign in to your social media account and allow [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to post through this account.

If your sign-in times out, or if the password changes on one of your accounts, you can update an account by doing the following:

1. Go to **Settings** > **Advanced Settings** > **Marketing settings** > **Social configuration**.
1. Select a social media configuration from the list.
1. Select **Sign in** on the command bar.
1. Follow the instructions on your screen to update your sign-in details.

You can delete a social configuration at any time to prevent [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] from posting through that account from now on.

## Schedule and post messages on social media

Use the **Social posts** entity to author and schedule your posts. You can post from any social-media account that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md), as described in the previous section.

In the current preview version, only Twitter is supported, but we expect to add more social media channels when this feature becomes generally available.

## Preview: Detailed quota reporting

The preview features an expanded **Quota limits** page, which now tracks the number of marketing contacts you have licensed and the number you are actually using. As before, this page also monitors your quotas of email messages and Litmus inbox previews.

To see how much of each quota you've used, go to **Settings** > **Advanced settings** > **Other settings** > **Quota limits**.

The following quotas are tracked here:

- **Marketing email messages**: Shows the total number of email messages you can still send this month, and the total number you have sent. Your email quota is equal to ten times your marketing contacts quota.
- **Litmus inbox previews**: Shows the total number of Litmus email previews (inbox previews) users at your organization can still request this month, and the total number that have been used. This quota is included with your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] license and is shared by all users from your organization. Individual users can get more previews by setting up a private (not shared) account with Litmus, but individual accounts aren't tracked here. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use the advanced inbox preview feature](prepare-marketing-emails.md#inbox-preview)
- **Marketing contacts**: Shows the total number of *marketing contacts* that you can have in your database according to your current [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] subscription. Marketing contacts only include those that you engage with marketing activities such as emails, landing pages, forms, LinkedIn integration, events, and surveys. Contacts that you never engage in marketing activities won't be counted as part of this quota. For more information about marketing contacts and how they are counted, see [Purchase a production version of Dynamics 365 for Marketing](purchase-marketing.md#how-licensed) and the [Administration and setup FAQ](setup-troubleshooting.md#licensing)
- **Total contacts**: Shows the total number of all contacts that are stored in your database. No quota applies here, so this is just for your reference (for example, so you can easily compare your number of total contacts to your number of marketing contacts)

You can read the following information about each type of quota listed here:

- **Total purchased**: Shows the total number of each quota that you have purchased for the current cycle.
- **Total used by this org.**: Shows the total number of each quota that you've used for the current [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organization (also known as an *instance*).
- **Total used by tenant**: Shows the total number of each quota that you've used for the tenant (which may include several [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] organizations). Some quotas apply per organization, while others apply at the tenant level. 
- **Percentage used by tenant**: Shows a percentage of how much of each quota you've already used for the current cycle.
- **Days remaining in current cycle**: For quotas that apply over time, this value shows how many days are left until the quota gets reset.
- **Status**: Indicates whether or not you've used up your quota for the current cycle.