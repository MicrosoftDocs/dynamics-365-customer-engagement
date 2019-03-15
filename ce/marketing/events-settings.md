---
title: "Set up event administration options and webinar provider accounts (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Set options for event administration and configure connections to your webinar provider accounts in Dynamics 365 for Marketing"
keywords: administration; webinar; webinar provider
ms.date: 03/15/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 04813c0e-cbfd-45da-a316-76d23aae759e
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

# Event management settings

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The **Event management** settings let you set up the connections to your webinar provider accounts and set up a few defaults for event administration. 

To find these settings, open **Settings** > **Advanced settings** and then choose one of the pages under the **Event management** heading in the leftmost column. You can also access these same settings by finding the **Event management** section in the rightmost column and choosing from the icons there.

See the remaining sections of this topic for information about how to work with each page in the **Event management** section.

## Webinar providers

A *webinar provider* is a third-party company that hosts webinars. The provider accepts registrations, provides URLs where the presenter and participants can join each webinar, and also provides a server to run the webinar itself. Providers typically also deliver attendance statistics and other webinar features. [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] does not provide this service, so to run a webinar, you must sign up with a third-party provider and then configure [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] with the details needed to connect to that provider.

Each webinar provider that you use must have a record listed on the **Webinar providers** page. For each account that you have with your webinar provider, you must also set up a **Webinar configuration** record as described in the next section.

> [!NOTE]
> [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] has partnered with a webinar provider called [On24](https://www.on24.com/), so [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is prepared to work with On24 right out of the box, though you'll still need to set up an account with them before you can run a webinar. This is the only provider currently supported for use with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

To set up a webinar provider:

1. Go to **Settings** > **Advanced settings** > **Event management** > **Webinar providers**. Here you'll see a list of existing providers (if any), and tools for adding new ones.
1. To edit an existing provider, select it from the list; to create a new one, select **New**. (You can also delete or deactivate a listed provider by selecting it in the list and then selecting the appropriate button on the command bar.)
1. Make the following settings:
    - **Name**: Enter the name of the provider.
    - **Base service URL**: Enter your webinar provider's base service URL. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses this URL to communicate with your webinar provider's system. Please contact your webinar provider if you don't know what it is.
    - **Max duration in minutes**: Shows the maximum number of minutes that your provider allows for a single session. Any webinars that are longer than this must be broken down into multiple sessions.
    - **Terms of service**: Enter the URL for a web page that lists your webinar provider's terms of service. Select the globe button to open this URL in a new browser tab. Please contact your webinar provider if you don't know the URL. This link is provided to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users when they are in the process of enabling webinar functionality, which requires them to agree to these terms.
    - **Privacy policy**: Enter the URL for a web page that shows your webinar provider's privacy policy. Select the globe button to open this URL in a new browser tab. Please contact your webinar provider if you don't know the URL. This link is provided to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users when they are in the process of enabling webinar functionality, which requires them to agree to this policy.
1. Save your work.

## Webinar configurations

After you have set up an account with your webinar provider, and set up the provider itself as described in the previous section, you must enter your account details to enable [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to authenticate and interact with it. Even if you use just one webinar provider, you might have several accounts with that provider, and can configure each of them as needed.

> [!NOTE]
> Each time you set up an event or session as a webinar (or hybrid), you must choose a webinar configuration. This is how you can control which account you'll be using for that event or session.

To configure a webinar account:

1. Go to **Settings** > **Advanced settings** > **Event management** > **Webinar configurations**. Here you'll see a list of existing configurations (if any), and tools for adding new ones.
1. To edit an existing configuration, select it from the list; to create a new configuration, select **New**. (You can also delete or deactivate a record by selecting it in the list and then selecting the appropriate button on the command bar.)
1. Make the following settings:
    - **Name**: Enter a name for the account.
    - **Webinar provider**: Select the name of the webinar provider record (set up as described in the previous section).
1. The following read-only information is also provided here, some of which may be useful for troubleshooting:
    - **Terms of service**: Displays the URL where your provider lists their terms of service. This value comes from the selected **Webinar provider** record. Select the globe button to open this URL in a new browser tab.
    - **Privacy policy**: Displays the URL where your provider details their privacy policy. This value comes from the selected **Webinar provider** record. Select the globe button to open this URL in a new browser tab.
    - **Last metrics update**: Shows the last date and time that your provider returned usage statistics (such as attendance records) to [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].
    - **Provider service status**: Shows the current status of the provider service and your connection to it.
    - **Message**: Displays a custom message sent by the provider (typically related to the displayed status).
1. Open the **Credentials** tab.
    - If you are editing an existing configuration and need to change your credentials, then set **Update credentials?** to **Yes** to expose the credentials settings.
    - If you are creating a new configuration, then the credentials settings are already shown here.
1. Make the following settings:
    - **Client ID**, **Access token key**, and **Access token secret**: These values identify your account and provide authentication (sign-in) credentials for accessing it and communicating with your webinar provider. You should have received these values when you signed up for the account. Please contact your webinar provider if you need help finding these values.
1. Save your work.

<a name="event-admin"></a>

## Event administration

Use the **Event administration** settings to set up a few standard options for your events, including email options, email templates, and default payment gateway. These settings are optional.

To set your event-administration options:

1. Go to **Settings** > **Advanced settings** > **Event management** > **Event administration**. Here you'll see a list of existing event-administration records (if any), and tools for adding new ones. Note the following:
    - You can only have one active event-administration record at a time.
    - If no event-administration records are shown, then select **New** on the command bar to create one.
    - If an event-administration record already exists, then select it to open it.
    - To delete an existing event-administration record, select it and choose **Delete** on the command bar.
    - If you'd like to temporarily disable an existing event-administration record, possibly so you can create a new one to use in the meantime, then select the existing record and choose **Deactivate** from the command bar. To view, edit, and/or reactivate a deactivated record, switch to the **Inactive event administration** view using system view menu (above the list).
1. Make the following settings:
    - **Name**: Enter a name for the current event-administration record.
    - **Send mail to purchaser**: Set to **Yes** if you'd like the system to send an automatic email to the purchaser each time she or he registers an attendee for an event.
    - **Email template for purchaser**: Choose the (hard-coded) email template to send to the purchaser when **Send mail to purchaser** is enabled.
    - **Send mail to event attendee**: Set to **Yes** if you'd like the system to send an automatic email to each new contact that is registered for an event. This includes both self-registering contacts (if allowed) and contacts registered by another purchaser.
    - **Event template for event attendee**: Choose the (hard-coded) email template to send to each registrant when **Send mail to event attendee** is enabled.
    - **Match contact based on**: Choose the strategy to use when matching a new event registration to an existing contact record. If a contact record is found that has matching values for *all* of the fields you choose here, then the registration will be linked to that contact record. If no match is found, then a new contact will be created and linked to the new registration record. You can choose to match by email alone; first name and last name; or email, first name, and last name.
    > [!NOTE]
    > In order to make the name-based contact matching strategy work with AAD, it is mandatory to provide first name and last name on sign-up. More information [Configuration for Azure Active Directory](developer/self-hosted.md#configuration-for-azure-active-directory). 
    > In order to make the name-based contact matching strategy work with **Portal Authentication** it is mandatory to provide first and last name after registering.
    
    > [!NOTE]
    > The email templates provided for sending confirmations to the event purchaser and/or attendee are hard coded, so you can't customize or translate their content. If you require custom messaging, then set up a [customer journey](customer-journeys-create-automated-campaigns.md) with event, trigger, and email tiles.

## Privacy notice

[!INCLUDE[cc-privacy-events-webinar](../includes/cc-privacy-events-webinar.md)]

### See also

[Event planning and management](event-management.md)  
[Set up a webinar](set-up-webinar.md)  
[Set up and manage an event waitlist](event-waitlist.md)  
[Create and manage recurring events](event-recurring.md)  
[Create and use event templates](event-templates.md)
