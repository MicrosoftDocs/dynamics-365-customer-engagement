---
title: "Preview features (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Learn what preview features are, and how to activate and use them in Dynamics 365 for Marketing"
keywords: preview
ms.date: 03/08/2019
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

# Activate and use preview features for April 2019

From time to time, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] makes new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] features available as *preview features*, which you can enable and use if you want to get familiar with upcoming features before they're officially released and fully supported. Read this topic to learn about which preview features are currently available, how to activate them, and how to use them.

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

## Enable preview features

Most preview features aren't installed or enabled by default. A system administrator must explicitly enable and install them before they will become available to any instance.

> [!NOTE]
> If you already enabled the preview features that were available for the February 2019 update and would now like to try the new preview features released in March 2019, then all you need to do is [update your instance](apply-updates.md). You don't need to opt-in again as described in this section.

> [!NOTE]
> If you already have a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] environment (including a trial), but don't yet have [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installed on it, and you'd like to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] with the preview features already enabled, then you can do both at once by first enabling the preview on your instance (as described here) and then installing  [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

To enable the preview features:

1. Sign in to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (or any app on your tenant) as an administrator.

1. Go to your [Power platform admin center](https://admin.powerplatform.microsoft.com/) (this link will bring you there).

1. Select **Environments** in the side navigator. A list of environments on your tenant opens. (Environments are also sometimes called *instances* or *organizations*.)

1. Select the environment where you want to enable the preview.
    > [!CAUTION]
    > We highly recommend that you only enable preview features on a sandbox or trial environment, not on a production environment. You can [copy a production instance](manage-marketing-instances.md) to a sandbox if you want to test on your exact configuration, and sandbox environments can be reset, backed up, and restored as you test features without impacting your production users.

1. Find the **Updates** section of the page, and then select the **Manage** link at the top of this section.

    ![Location of the Updates section](media/preview-enable-1.png "Location of the Updates section")

    > [!NOTE]
    > If the **Manage** link isn't present, and it says **On** under **April 2019 update**, then you've already enabled the preview for this environment. But you might still need to install the features, so skip ahead to step 8 to make sure.

1. The **April 2019 update** flyout slides in from the side of the page. Select the **Activate now** button at the bottom of the flyout.

1. The **Turn on April 2019 update?** dialog box opens. To confirm that you want to enable the preview features for your selected environment, enter the environment name in the field provided here and then select **Confirm**.

    ![The enable-preview flyout and dialog](media/preview-enable-2.png "The enable-preview flyout and dialog")

1. [Open the Dynamics 365 admin center](dynamics-365-admin-center.md).

1. Go to the **Applications** tab of the admin center to see a list of applications you have installed.  
    ![Open the Applications tab](media/update-app-tab.png "Open the Applications tab")

    The list shows a row marked **Dynamics 365 Marketing Application** for each entitlement (license) you have for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Free entitlements show a **Status** of **Not configured**. Installed entitlements show a **Status** of **Configured** and include the name of the environment where they are installed at the end of their application name.

1. From the list on the **Applications** tab, select the **Dynamics 365 Marketing Application** where you want to enable the preview, and then choose **Manage** from the side panel.
    - If you're adding the preview to an existing [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installation, then choose the configured application that includes the name of the environment you just enabled for the preview.
    - If you're installing [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] for the first time, then choose an unconfigured entitlement. Later, when asked by the setup wizard, choose the environment you just enabled for the preview.

1. The setup wizard launches. Follow the instructions on your screen to update or install on your selected environment. For more information about the setup wizard, see [Run the setup wizard](purchase-setup.md).

See the remaining sections of this topic for details about how to find and use the preview features.



## Preview: Expanded support for externally hosted forms

The current version of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] already lets you create marketing forms that you can [embed on your own, external website](embed-forms.md), but with a few limitations. We're working towards removing these limitations to enable you to create fully functional marketing pages that can run on your own, external website or CMS system. The following elements of this functionality are now available as preview features:

- Enable prefill on embedded forms
- Run a subscription center as an embedded form
- Use external forms for inbound customer journeys
- Create customer journey triggers that react to external form visits and submissions



<a name="social-posting"></a>

## Preview: Social posting

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can schedule and post messages directly to your organization's accounts on social media sites. In the current preview version, only Twitter and Facebook are supported, but we expect to add more social media channels when this feature becomes generally available.

<a name="config-social"></a>

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

### Schedule and post messages on social media

Use the **Social posts** entity to author and schedule your posts. You can post from any social-media account that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], as described in the previous section.

In the current preview version, only Twitter is supported, but we expect to add more social media channels when this feature becomes generally available.

To schedule and post a message to one of your social-media channels:

1. **Go to Marketing** > **Marketing execution** > **Social Posts**.
1. A calendar opens, showing all scheduled and previously posted messages. Do one of the following:
    - To schedule a post using the calendar, choose a calendar view (month, day or week), select a day or time slot to highlight it, and then select again (click or press enter) and choose **New item** from the context menu. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with marketing calendars](marketing-calendar.md)
    - To schedule a post using date pickers, or to send it right away, select **New** on the command bar.
1. A new social post record is created. Make the following settings:
    - **Name**: Enter an internal name for the post. This name will be shown on the calendar, but won't appear in the post itself.
    - **Social channel**: Choose the social channel on which to post your message. Each of the channels currently supported by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is listed here. (In the current release, only Twitter is available.)
    - **Posting from**: Select the specific account through which to post your message. This drop-down list shows each account for the selected **Social channel** that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Configure your social media accounts](#config-social)
    - **Select scheduling**: Choose how to schedule your post by selecting one of the following:
        - **Post now**: Your message will be posted immediately when you save the record, and will be shown on the calendar for the current date and time.
        - **Schedule**: Choose a specific date and time to post the message. If you started by choosing a date and time on the calendar, then this option is preselected.
        - **Schedule later**: Choose this if you want to save the messages without posting or scheduling it. You can come back later to either choose a schedule or post immediately by selecting one of the other options here.
    - **Posted time**: If you choose to schedule your message, then specify the date and time to post it here. If you started by choosing a date and time on the calendar, then those values are already shown here.

    > [!IMPORTANT]
    > The dates and times for the posting schedule use the time zone configured in your personal settings. To view or edit your time zone, open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and then select **Personalization settings**.

1. Enter the content of your message in the large text field, exactly as you want it to appear in your social-media post.
1. Select **Save** to post or schedule your message according to your settings.

### Reschedule or cancel a post

You can reschedule or cancel any post that hasn't been sent yet. Just find and select it on the calendar to open the record, and then edit the schedule or select **Delete** on the command bar, as needed.

Posts that were already sent are read-only, so you can't change or reschedule them, but you can remove them from the calendar if you want.

## Preview: Detailed quota reporting

The preview features an expanded **Quota limits** page, which now tracks the number of marketing contacts you have licensed and the number you are actually using. As before, this page also monitors your quotas of email messages and Litmus inbox previews.



## Preview support and feedback

If you wish to report an issue with a preview feature, please [open a support ticket](https://docs.microsoft.com/power-platform/admin/get-help-support) and include the following tags in the **Issue title** of your ticket:

- For marketing-contacts monitoring, please include: [PREVIEW][MCM]
- For social posting, please include: [PREVIEW][SOCIAL]
