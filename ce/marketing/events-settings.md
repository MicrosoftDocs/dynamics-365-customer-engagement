---
title: "Set up event administration options and webinar provider accounts (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Set options for event administration and configure connections to your webinar provider accounts in Dynamics 365 for Marketing"
keywords: "administration; webinar; webinar provider"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 04813c0e-cbfd-45da-a316-76d23aae759e
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Event management settings

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The **Event management** settings let you set up the connections to your webinar provider accounts. You must set up at least one webinar configuration to enable the webinar feature.

To find these settings, open **Settings** > **Advanced settings** and then choose one of the pages under the **Event management** heading in the leftmost column. You can also access these same settings by finding the **Event management** section in the rightmost column and choosing from the icons there.

See the remaining sections of this topic for information about how to work with each page in the **Event management** section.

## Webinar configuration

To run a webinar, your organization must first set up one or more accounts with a webinar provider, and then configure [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to work together with each account so that it can sign in, register attendees, and fetch the URLs that attendees can use to join the webinar itself.

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] has partnered with a webinar provider called [On24](https://www.on24.com/), so [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is prepared to work with On24 right out of the box. This is the only provider currently supported for use with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].  

For each On24 account that you want to use with [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you must set up a dedicated webinar configuration, which identifies the provider and account and stores your sign-in credentials.

To set up your webinar provider:

1. Go to **Settings** > **Advanced settings** > **Event management** > **Webinar configurations**. Here you'll see a list of existing configurations (if any), and tools for adding new ones. No configurations are provided out of the box.
1. To edit an existing configuration, select it from the list; to create a new configuration, select **New**.
1. Make the following settings:
    - **Name**: Enter a name that you and others will recognize.
    - **Webinar provider**: Select **On24**.
1. If you're setting up a new configuration, or if you need to update your account credentials for an existing configuration, open the **Credentials** tab and set **Update credentials?** to **Yes** and then enter your sign-in credentials for the account.

## Event administration

You can find event administration settings by going to **Settings** > **Advanced settings** > **Event management** >  **Event administration**. Use these settings to set up email options and templates for event registrants.

## Privacy notice

[!INCLUDE[cc-privacy-events-webinar](../includes/cc-privacy-events-webinar.md)]

### See also

[Event planning and management in Dynamics 365](event-management.md)  
[Set up a webinar](set-up-webinar.md)