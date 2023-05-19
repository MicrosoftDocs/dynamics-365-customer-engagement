---
title: Forward your Teams call to Microsoft Digital Contact Center | MicrosoftDocs 
description: Learn about forwarding Teams calls to Microsoft Digital Contact Center
author: venki-ms 
ms.author: v-duddupdiv
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 29/05/2023 
ms.custom: bap-template 
---

# Forward your Teams calls to Microsoft Digital Contact Center

You can forward the Teams calls like user numbers calls, auto attendant calls, and call queues to Microsoft Digital Contact Center.
The price for the forward calls are as per [PSTN inbound rate](voice-channel-pricing-scenarios.md). The standard charges of Microsoft Teams calls are also applicable as the calls are transferred out of Teams.

## Prerequisites

- You must know how to forward Teams calls, see [Configure call settings for users - Microsoft Teams](user-call-settings.md)
- You must know about Teams call queues and auto attendant, see [Set up a Microsoft Teams auto attendant - Microsoft Teams](create-a-phone-system-auto-attendant.md) and [Create a call queue in Microsoft Teams - Microsoft Teams](create-a-phone-system-call-queue.md)
- You must know how to configure auto attendants, call queues, and to send calls to external numbers. For more information, see [Plan for Teams auto attendants and call queues - Microsoft Teams](plan-auto-attendant-call-queue.md)

## How you can forward Teams calls
When you receive an incoming call through teams, you can forward user numbers calls, auto attendant calls, and call queues to Microsoft Digital Contact Center. The same Teams number appears in Microsoft Digital Contact center as well and agent can see the case history of the callers if any.
1. Forward the calls of Teams user numbers using Call forwarding in Microsoft Teams.
2. Forward the calls of Teams auto attendants using auto attendant settings in teams. You can forward all auto attendant calls to Microsoft Digital Contact Center or add Microsoft Digital Contact Center number in the call menu.

   :::image type="content" source="media/add-number-call-menu.png" alt-text="Adding Microsoft Digital Contact Center number in the call menu":::

3. Forward the Teams call queues by using call queue settings in Teams. You can forward the calls by using the overflow settings in **Call overflow handling** and also by setting wait time in **Call timeout handling**.
> [!NOTE]
> Forward every call queues by setting the **Maximum calls in the queue** to zero in call overflow settings. The default is 50, but it can range from 0 to 200.

   :::image type="content" source="media/max-call-queues.png" alt-text="Maximum calls in the queue":::
> [!NOTE]
> To forward the call queues after five minutes, set the **Maximum wait time** to five minutes in call timeout settings.

   :::image type="content" source="media/max-wait-time.png" alt-text="Maximum wait time":::