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

You can forward the different types of Teams calls to Microsoft Digital Contact Center.

## Prerequisites

- Pricing is as per [PSTN inbound rate](voice-channel-pricing-scenarios.md). Standard charges of Microsoft Teams calls are also applicable as the calls are transferred out of Teams.
- You must know about Teams call queues and auto attendant. For more information, see [Set up a Microsoft Teams auto attendant - Microsoft Teams](create-a-phone-system-auto-attendant.md) and [Create a call queue in Microsoft Teams - Microsoft Teams](create-a-phone-system-call-queue.md)

## How you can forward Teams calls
The teams calls are of three types: Calls of Teams user numbers, Teams auto attendant calls, Teams call queues. You can forward all these calls to Microsoft Digital Contact Center.
1. Forward the calls of Teams user numbers using Call forwarding in Microsoft Teams. To know how to forward Teams calls see, [Configure call settings for users - Microsoft Teams](user-call-settings.md)
2. Forward the calls of Teams auto attendants using auto attendant settings in teams. For auto attendant settings in teams, see [Set up a Microsoft Teams auto attendant - Microsoft Teams](create-a-phone-system-auto-attendant.md). You can forward all auto attendant calls to Microsoft Digital Contact Center or add Microsoft Digital Contact Center number in the call menu.

   :::image type="content" source="media/add-number-call-menu.png" alt-text="Adding Microsoft Digital Contact Center number in the call menu" lightbox="media/set-open-activities.png":::

   - To configure auto attendants to send calls to external numbers, check the prerequisites in [Plan for Teams auto attendants and call queues - Microsoft Teams](plan-auto-attendant-call-queue.md)
3. Forward the Teams call queues by using call queue settings in Teams. For call queue settings in Teams, see [Create a call queue in Microsoft Teams - Microsoft Teams](create-a-phone-system-call-queue.md)
    Forward the Teams call queues to Microsoft Digital Contact Center number by using the Overflow settings in **Call overflow handling**.
> [!NOTE]
> Forward every call queues to Microsoft Digital Contact Centre by setting the **Maximum calls in the queue** to zero.

   :::image type="content" source="media/max-call-queues.png" alt-text="Maximum calls in the queue":::

   - Forward the call queues to Microsoft Digital Contact Center after specific time by using the **Call timeout handling**. To forward the call queues after five minutes, set the **Maximum wait time** to five minutes.

   :::image type="content" source="media/max-wait-time.png" alt-text="Maximum wait time":::

   - To configure call queues to send calls to external numbers, check the prerequisites in [Plan for Teams auto attendants and call queues - Microsoft Teams](plan-auto-attendant-call-queue.md)

The call in Microsoft Digital Contact center looks same as it was from the original Teams caller and also identifies the previous callers.