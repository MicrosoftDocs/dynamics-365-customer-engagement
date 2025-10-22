---
title: Enable consult and transfer settings for representatives
description: Learn about how to enable the consult and transfer settings for conversations so that representatives can efficiently select a supervisor or another representative to consult with or transfer the conversation in Dynamics 365 Contact Center and Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection:
ms.date: 10/20/2025
ms.custom: bap-template
---

# Enable consult with representatives and transfer of conversations

By default, customer service representatives (service representatives or representatives) can consult with other representatives and transfer conversations to resolve customer issues efficiently.

For advanced consult and transfer scenarios, you can enable the consult to queue and direct transfer of conversations in your contact center. The consult to queue setting helps the system to intelligently select the most eligible representative to consult with. Direct transfer lets representative select another representative directly without first initiating a consult. Service representatives can make sure that customers receive the best assistance they need.

## Prerequisite

System administrator or Omnichannel administrator role.

## Enable consult and transfer settings

You can enable the settings in Copilot Service admin center under **Channels** > **Consult and transfer** page.

### Enable consult to queue

1. Turn on the toggle for **Consult to queue**
1. Enter countdown numbers for voice and messaging channels to indicate the time the system spends to find representatives to consult with.

   :::image type="content" source="../media/consult-to-queue-settings.png" alt-text="Screenshot of consult to queue setting in admin center.":::

1. Save and close.

### Enable blocking of capacity during consult

By default, representative capacity is blocked for consult to queue sessions. But you have to explicitly block representative capacity for direct consult session.

- On the **Consult and transfer** page, select the checkbox to block capacity of the representatives who are engaged in a consultation that's invoked using the consult with representatives option on the communication panel.

### Enable direct transfer of conversations

When you enable the transfer to representative setting, representatives can select another representative directly and initiate transfer.

1. On the **Consult and transfer** page, in **Transfer settings** turn on the **transfer to representatives** toggle.
1. Select **Save**.

### Configure custom inbox view

The consultee can configure the inbox to show their consult sessions. They can then join the session back from the inbox and leave the consultation to release their capacity.

1. Create a view using the **Advanced** option in [Configure custom views for the inbox](configure-inbox.md#configure-custom-views-for-the-inbox).
1. Use the conditions as shown in the following screenshot to configure the view.

   :::image type="content" source="../media/configure-consults-inbox-view.png" alt-text="Screenshot of the conditions builder to view consult sessions in inbox.":::

## Runtime experience

Only after you enable the consult to queue setting, your service representatives can see the **Queue** tab on the communication panel. Similarly, the **Representatives** tab appears if you enable the direct transfer setting. The tab also appears when the representative wants to transfer conversations to another representative after engaging in a consultation with them.

The consult session isn't reestablished if the representative refreshes the browser. However, the representative capacity is blocked based on the consult type or block capacity setting.

The representative capacity is released in the following scenarios:

- If the primary representative ends the call or conversation and closes their session.
- If the primary representative ends the consult.

## Related information

[Consult with representative or supervisor](../use/oc-conversation-control.md#consult-with-representative-or-supervisor)  
[Use consult to collaborate with other representatives or supervisors](../use/voice-channel-transfer-consult.md#use-consult-to-collaborate-with-other-representatives-or-supervisors)  
[Transfer conversations to representatives](../use/oc-conversation-control.md#transfer-conversations)  
[Transfer calls to representatives](../use/voice-channel-transfer-consult.md#transfer-calls)