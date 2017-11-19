---
title: "Set up your webinar provider accounts in Dynamics 365 for Marketing | Microsoft Docs"
description: "Set up the connections to your webinar provider accounts in Dynamics 365 for Marketing"
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
1. To edit an existing configuration, select it from the list; to create a new configuration, select **New**.
1. Make the following settings:
    - **Name**: Enter a name that you and others will recognize.
    - **Webinar Provider**: Select **On24**.
1. If you're setting up a new configuration, or if you need to update your account credentials for an existing configuration, open the **Credentials** tab and set **Update credentials?** to **Yes** and then enter your sign-in credentials for the account.

## Event management settings

You can find event management settings by going to **Settings** > **Events Settings** >  **Event Management Settings**. Use these settings to set up email options and templates for event registrants.

## Privacy notice

When you accept the terms and conditions for event management, the webinar-integration feature is activated. The webinar integration feature leverages a partner webinar provider to conduct an event or a session as a webinar. To use any webinar provider’s service, you must have an account with them. The only partner webinar provider service provided out of the box at this time is ON24. When using the webinar-integration feature, data essential to providing and running the webinar would be processed and stored on [!INCLUDE[pn-azure-service-fabric](../includes/pn-azure-service-fabric.md)], and then sent to ON24. Such data would include the webinar participants’ registration data such as their names, emails, and company names. In addition, ON24 would send webinar metrics such as webinar viewing duration to [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] via [!INCLUDE[pn-azure-service-fabric](../includes/pn-azure-service-fabric.md)].

You don't need to activate the webinar feature to use the rest of the event-management solution. An administrator can turn off the webinar integration feature by removing the credentials in the webinar configuration.

[!INCLUDE[pn-windows-azure](../includes/pn-windows-azure.md)] components and services used by the webinar-integration feature are:

- [!INCLUDE[pn_azure_key_vault](../includes/pn_azure_key_vault.md)] ([!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [What is Azure Key Vault?](https://docs.microsoft.com/en-us/azure/key-vault/key-vault-whatis))
  - Provides encryption key for encrypting/decrypting customer’s ON24 account credentials
- [!INCLUDE[pn-azure-service-fabric](../includes/pn-azure-service-fabric.md)] ([!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Overview of Azure Service Fabric](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-overview))
  - Processes and sends registration data and webinar account credentials to ON24
  - Retrieves webinar metrics from On24 to [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]
  -Stores customer’s ON24 account credentials (custom encrypted)
