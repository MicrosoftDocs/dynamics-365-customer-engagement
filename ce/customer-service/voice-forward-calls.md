---
title: Forward your Teams call to digital contact center
description: Learn about forwarding Teams calls to digital contact center.
author: venki-ms 
ms.author: v-duddupdiv
ms.reviewer: neeranelli 
ms.topic: article
ms.date: 05/31/2023 
ms.custom: bap-template 
---

# Forward your Teams calls to digital contact center

You can forward the Microsoft Teams calls to your digital contact center. The standard charges for Microsoft Teams calls are also applicable to the forwarded calls. These calls that land on your digital contact center numbers are charged based on the [PSTN inbound rate](voice-channel-pricing-scenarios.md).

Perform the steps in [Set up auto attendants](/microsoftteams/create-a-phone-system-auto-attendant) and [Set up call queues](/microsoftteams/create-a-phone-system-call-queue) to enable the forwarding of the calls.

## How call forwarding in Teams works

When you forward a Teams call, the digital contact center agent sees the caller number from which the customer has called the Teams number. The application also identifies the customer if their contact details are saved in Dynamics 365.

Call forwarding is supported in the following scenarios:
- [**Calls to Teams user numbers**](/microsoftteams/user-call-settings#use-the-teams-admin-center).
- [**Calls to auto attendants**](/microsoftteams/create-a-phone-system-auto-attendant#external-phone-number-transfers---technical-details): Calls can also be forwarded directly to the digital contact center number without the auto attendant flow.
- [**Calls in call queues**](/microsoftteams/create-a-phone-system-call-queue):
    - To forward the calls in the call queues, enable the following settings in Microsoft Teams admin center.
      - To forward all calls, set the **Maximum calls in the queue** to zero in **Call overflow handling**. The default is 50, but it can range from 0 to 200.
      - To forward the calls in the call queues after five minutes, set the **Maximum wait time** to five minutes in **Call timeout handling**.

### See also

[Introduction to the voice channel](voice-channel.md)  
[Identify customers automatically](record-identification-rule.md)  