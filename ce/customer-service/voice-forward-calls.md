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
The charges for forward calls are based on [PSTN inbound rate](voice-channel-pricing-scenarios.md). The standard charges of Microsoft Teams calls are also applicable as the calls are transferred out of Teams.

## Prerequisites

- Configure auto attendants and call queues to send calls to external numbers. For more information, see [Plan for Teams auto attendants and call queues - Microsoft Teams](/microsoftteams/plan-auto-attendant-call-queue#prerequisites)

## How you can forward Teams calls
When you receive an incoming Teams call, you can forward Teams user numbers calls, auto attendant calls, and calls in the call queues to Digital Contact Center Platform. The same number from Teams is visible in Digital Contact Center Platform and it also supports record identifcation.

You can enable following scenarios to forward Teams call to Digital Contact Centre Platform.
- Forward the calls of Teams user numbers using Call forwarding in Microsoft Teams. To know how to forward the calls in Teams, see [Configure call settings for users - Microsoft Teams](/microsoftteams/user-call-settings#use-the-teams-admin-center)
- Forward the calls of Teams auto attendants using auto attendant settings in Teams. For more information, see [Set up a Microsoft Teams auto attendant - Microsoft Teams](/microsoftteams/create-a-phone-system-auto-attendant#external-phone-number-transfers---technical-details). You can also add Microsoft Digital Contact Center number in the call menu.

   :::image type="content" source="media/add-number-call-menu.png" alt-text="Adding Microsoft Digital Contact Center number in the call menu":::

- Forward the calls in Teams call queues by using call queue settings in Teams. For more information, see [Create a call queue in Microsoft Teams - Microsoft Teams](/microsoftteams/create-a-phone-system-call-queue).
    - To enable the call forwarding for calls in the call queues, you can check following settings in Microsoft Teams admin center.
      - To forward all calls, set the **Maximum calls in the queue** to zero in **Call overflow handling**. The default is 50, but it can range from 0 to 200.

          :::image type="content" source="media/max-call-queues.png" alt-text="Maximum calls in the queue":::

      - To forward the calls in the call queues after five minutes, set the **Maximum wait time** to five minutes in **Call timeout handling**.

         :::image type="content" source="media/max-wait-time.png" alt-text="Maximum wait time":::