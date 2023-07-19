---
title: Forward Teams calls to your digital contact center
description: Learn how to forward Microsoft Teams calls to your organization's digital contact center.
author: venki-ms 
ms.author: v-duddupdiv
ms.reviewer: neeranelli 
ms.topic: how-to
ms.date: 06/07/2023 
ms.custom: bap-template 
---

# Forward Teams calls to your digital contact center

If an agent isn't available when a customer calls a Microsoft Teams number in your voice channel, the call can be automatically forwarded to your organization's digital contact center. Standard charges for Teams calls apply to forwarded calls. Calls that are forwarded to your digital contact center numbers are charged based on the [PSTN inbound rate](voice-channel-pricing-scenarios.md).

To turn on call forwarding:

- [Set up auto attendants](/microsoftteams/create-a-phone-system-auto-attendant).
- [Set up call queues](/microsoftteams/create-a-phone-system-call-queue).

## How call forwarding in Teams works

When a Teams call is forwarded to the digital contact center, the contact center agent sees the phone number the customer called from. If the customer is in Dynamics 365, more contact details are provided.

Call forwarding is supported in the following scenarios:

- [**Calls to Teams user numbers**](/microsoftteams/user-call-settings#use-the-teams-admin-center)
- [**Calls to auto attendants**](/microsoftteams/create-a-phone-system-auto-attendant#external-phone-number-transfers---technical-details)  
    Calls can also be forwarded directly to the digital contact center number without the auto attendant flow.
- [**Calls in call queues**](/microsoftteams/create-a-phone-system-call-queue)  
    To forward the calls in a queue, enable the following settings in the Microsoft Teams admin center:  
      - To forward all calls, set **Call overflow handling** > **Maximum calls in the queue** to 0. The default is 50 and the maximum is 200.  
      - To forward calls that have been in the queue longer than five minutes, set **Call timeout handling** > **Maximum wait time** to five minutes.

### See also

[Introduction to the voice channel](voice-channel.md)  
[Identify customers automatically](record-identification-rule.md)
