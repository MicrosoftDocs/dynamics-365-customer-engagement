---
title: Forward your Teams call to digital contact center| MicrosoftDocs 
description: Learn about forwarding Teams calls to Digital Contact Center Platform
author: venki-ms 
ms.author: v-duddupdiv
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 05/29/2023 
ms.custom: bap-template 
---

# Forward your Teams calls to digital contact center

You can forward Microsoft Teams calls to digital contact center.
The digital contact center charges for the forwarded calls are calculated based on [PSTN inbound rate](voice-channel-pricing-scenarios.md). The standard charges of Microsoft Teams calls are also applicable for forwarded calls.

## Prerequisites

Configure auto attendants and call queues to send calls to your digital contact center number. For more information, see: [Plan for Teams auto attendants and call queues - Microsoft Teams](/microsoftteams/plan-auto-attendant-call-queue#prerequisites)

## How you can forward Teams calls
You can forward Teams user numbers calls, auto attendant calls, and calls to the call queues to your digital contact center. The digital contact center agent sees the same number from which the customer called the Teams number. The application also identifies the customer if the contact details are saved in Dynamics 365.

Call forwarding is supported for the following scenarios:
- **Calls to Teams user numbers**: Perform the steps in [Configure call settings for users - Microsoft Teams](/microsoftteams/user-call-settings#use-the-teams-admin-center) to enable call forwarding.
- **Calls to auto attendants**: Perform the steps in [Set up a Microsoft Teams auto attendant - Microsoft Teams](/microsoftteams/create-a-phone-system-auto-attendant#external-phone-number-transfers---technical-details) to enable call forwarding to the auto attendant flow. You can also forward the calls directly to the digital contact center number without going through the auto attendant flow.

   :::image type="content" source="media/add-number-call-menu.png" alt-text="Adding Microsoft Digital Contact Center number in the call menu":::

- **Calls in call queues**: Perform the steps in [Create a call queue in Microsoft Teams - Microsoft Teams](/microsoftteams/create-a-phone-system-call-queue) to enable call forwarding for calls in call queues.
    - To enable the call forwarding for calls in the call queues, enable the following settings in Microsoft Teams admin center.
      - To forward all calls, set the **Maximum calls in the queue** to zero in **Call overflow handling**. The default is 50, but it can range from 0 to 200.

          :::image type="content" source="media/max-call-queues.png" alt-text="Maximum calls in the queue":::

      - To forward the calls in the call queues after five minutes, set the **Maximum wait time** to five minutes in **Call timeout handling**.

         :::image type="content" source="media/max-wait-time.png" alt-text="Maximum wait time":::

### See also

[Introduction to the voice channel](voice-channel.md)  
[Identify customers automatically](record-identification-rule.md)  