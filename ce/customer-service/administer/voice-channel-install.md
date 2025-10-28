---
title: Install the voice channel in Dynamics 365 Contact Center
description: Learn about how to install the voice channel in Dynamics 365 Contact Center and Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.date: 07/30/2025
ms.topic: how-to
---

# Install the voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

To configure and use the voice channel for your business needs, you need to install the channel in Dynamics 365.

## Prerequisite

Specific licensing requirements apply to use the voice channel in Dynamics 365 Contact Center and Customer Service. Learn about licenses and pricing in [Dynamics 365 Pricing](https://go.microsoft.com/fwlink/?linkid=2309515) and [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true).

## Install the voice channel

1. Perform the steps outlined in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels).

1. In the **Voice** section, set the **Add voice** toggle to **Yes** to enable the voice channel. Ensure that you select the **Voice and SMS Terms** checkbox.

1. Save and close.

## Next steps

[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  

> [!NOTE]  
> The voice channel supports a maximum call duration of two hours, after which the call is disconnected. As a workaround, we recommend that you activate the callback feature.

### Related information

[System requirements for using the voice channel](/dynamics365/contact-center/implement/system-requirements-contact-center)  
[Set up inbound calling](../voice-channel-route-queues.md)  