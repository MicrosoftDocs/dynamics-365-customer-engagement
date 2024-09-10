---
title: Disconnect from Azure Communication Services resources
description: Learn how you can disconnect an Azure Communication Services resource.
ms.date: 08/29/2024
ms.service: dynamics-365-customerservice
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
ms.collection:
---

# Disconnect from Azure Communication Services resources

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


If you're no longer using an Azure Communication Services resource or want to connect to a different resource, you can disconnect the current resource, and later reconnect to a new or existing resource by selecting the **Get started** button.

To permanently release or remove one or more phone numbers from your organization, see [Release phone numbers](voice-channel-manage-phone-numbers.md#release-phone-numbers).

> [!IMPORTANT]
> - When you disconnect a resource, all phone numbers associated with it are also released from Dynamics 365; therefore, disconnect a resource only when you no longer need it.
> - To reconnect a phone number to the voice channel, you must trigger the voice channel creation. This can either be editing a voice channel setting and reverting  to the original value or creating a new voice channel for the phone number.

## Disconnect from an Azure Communication Services resource

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.
1. Select **Manage** for **Phone numbers**.
1. Select **Advanced** on the menu. The **Manage Azure Communication Services** dialog opens.
1. Select **Disconnect** for **Disconnect from Azure**. A dialog that asks you to confirm the disconnection displays.
1. Select **Disconnect** again.
   Any phone numbers associated with the resource are no longer displayed on the **Phone numbers** page.
1. To avoid errors, delete and clean up the Event Grid subscriptions you created as a part of [enabling call recording and SMS services](voice-channel-configure-services.md).

### Related information

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Import phone numbers](voice-channel-sync-from-acs.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

