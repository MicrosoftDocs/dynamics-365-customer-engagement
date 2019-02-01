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

# Activate and use preview features for April 2019

From time to time, [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] makes new [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] features available as *preview features*, which you can enable and use if you want to get familiar with upcoming features before they're officially released and fully supported. Read this topic to learn about which preview features are currently available, how to activate them, and how to use them.


> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

## Enable preview features

Most preview features aren't installed or enabled by default. A system administrator must explicitly enable and install them before they will become available to any instance. 

> [!NOTE]
> If you already have a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] environment (including a trial), but don't yet have [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] installed on it, and you'd like to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] with the preview features already enabled, then you can enable the preview and install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] at the same time by running the procedure provided here (you don't need to install [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] first).

To enable the preview features:

1. Sign in to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (or any app on your tenant) as an administrator.

1. Go to your [Power platform admin center](https://admin.powerplatform.microsoft.com/) (this link will bring you there).

1. Select **Environments** in the side navigator. A list of environments on your tenant opens. (Environments are also sometimes called *instances* or *organizations*.)

1. Select the environment where you want to enable the preview.
    > [!CAUTION]
    > We highly recommend that you only enable preview features on a sandbox environment, not on a production environment. You can [copy a production instance](manage-marketing-instances.md) to a sandbox if you want to test on your exact configuration, and sandbox environments can be reset, backed up, and restored as you test features without impacting your production users.

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

<a name="social-posting"></a>

## Preview: Social posting

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] can schedule and post messages directly to your organization's accounts on social media sites. In the current preview version, only Twitter is supported, but we expect to add more social media channels when this feature becomes generally available.

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

Use the **Social posts** entity to author and schedule your posts. You can post from any social-media account that your admin has set up and authenticated in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md), as described in the previous section.

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