---
title: Forward your Teams call to Digital Contact Center Platform| MicrosoftDocs 
description: Learn about forwarding Teams calls to Digital Contact Center Platform
author: venki-ms 
ms.author: v-duddupdiv
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 05/29/2023 
ms.custom: bap-template 
---

# Forward your Teams calls to Digital Contact Center Platform

You can forward the Microsoft Teams calls to Digital Contact Center Platform.
The charges for the forwarded calls are calculated based on [PSTN inbound rate](voice-channel-pricing-scenarios.md). The standard charges of Microsoft Teams calls are also applicable for forwarded calls.

## Prerequisites

Configure auto attendants and call queues to send calls to external numbers. For more information, see: [Plan for Teams auto attendants and call queues - Microsoft Teams](/microsoftteams/plan-auto-attendant-call-queue#prerequisites)

## How you can forward Teams calls
You can forward Teams user numbers calls, auto attendant calls, and calls in the call queues to Digital Contact Center Platform. The agent sees the same number from which the customer called the Teams Number. The application also identifies the customer once the ID record identification is enabled.

Call forwarding is supported for following scenarios:
- Calls to Teams user numbers: Perform the steps in [Configure call settings for users - Microsoft Teams](/microsoftteams/user-call-settings#use-the-teams-admin-center) to enable call forwarding.
- Calls to auto attendants: Perform the steps in [Set up a Microsoft Teams auto attendant - Microsoft Teams](/microsoftteams/create-a-phone-system-auto-attendant#external-phone-number-transfers---technical-details) to enable call forwarding to auto attendants. You can also forward the calls directly to Digital Contact Center Platform number.

   :::image type="content" source="media/add-number-call-menu.png" alt-text="Adding Microsoft Digital Contact Center number in the call menu":::

- Calls in call queues: Perform the steps in [Create a call queue in Microsoft Teams - Microsoft Teams](/microsoftteams/create-a-phone-system-call-queue) to enable call forwarding for calls in call queues.
    - To enable the call forwarding for calls in the call queues, enable the following settings in Microsoft Teams admin center.
      - To forward all calls, set the **Maximum calls in the queue** to zero in **Call overflow handling**. The default is 50, but it can range from 0 to 200.

          :::image type="content" source="media/max-call-queues.png" alt-text="Maximum calls in the queue":::

      - To forward the calls in the call queues after five minutes, set the **Maximum wait time** to five minutes in **Call timeout handling**.

         :::image type="content" source="media/max-wait-time.png" alt-text="Maximum wait time":::