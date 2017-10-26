---
title: "Set up your webinar provider accounts in Dynamics 365 for Marketing | Microsoft Docs"
description: "Set up the connections to your webinar provider accounts in Dynamics 365 for Marketing"
keywords: "administration; webinar; webinar provider"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
ms.assetid: 04813c0e-cbfd-45da-a316-76d23aae759e
ms.reviewer: renwe
---
# Events settings

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The **Events Settings** let you set up the connections to your webinar provider accounts. You must set up at least one webinar configuration to enable the webinar feature.

To find these settings, open **Advanced settings** and then choose one of the pages under the **Events Settings** heading in the leftmost column. You can also access these same settings by finding the **Events Settings** section in the rightmost column and choosing from the icons there.

See the remaining sections of this topic for information about how to work with each page in the **Events Settings** section.

## Webinar configuration

To run a webinar, your organization must first set up one or more accounts with a webinar provider, and then configure [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] to work together with each account so that it can sign in, register attendees, and fetch the URLs that attendees can use to join the webinar itself.

[!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] has partnered with a webinar provider called [On24](https://www.on24.com/), so [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] is prepared to work with On24 right out of the box. This is the only provider currently supported for use with [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)].  

For each On24 account that you want to use with [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)], you must set up a dedicated webinar configuration, which identifies the provider and account and stores your sign-in credentials.

To set up your webinar provider:

1. Go to **Settings** > **Events Settings** > **Webinar Configurations**. Here you'll see a list of existing configurations (if any), and tools for adding new ones. No configurations are provided out of the box.
2. To edit an existing configuration, select it from the list; to create a new configuration, select **New**.
3. Make the following settings:
    - **Name**: Enter a name that you and others will recognize.
    - **Webinar Provider**: Select **On24**.
4. If you're setting up a new configuration, or if you need to update your account credentials for an existing configuration, set **Update credentials?** to **Yes** and then enter your sign-in credentials for the account.
5. Select **Check** to make sure your credentials are valid.

## Event management settings

You can find event management settings by going to **Settings** > **Events Settings** >  **Event Management Settings**. These settings are used to provision the webinar provider service on [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)], and are preconfigured as needed to use On24. Don't change anything here unless instructed to do so by [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)].
