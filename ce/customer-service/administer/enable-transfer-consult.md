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

You can enable the consult with other customer service representatives (service representatives or representatives) and transfer of conversations in your contact center. The consult to queue setting helps the system to intelligently select the most eligible representative to consult with. This allows service representatives to consult with other representatives and transfer conversations to them, making sure that customers receive the best assistance they need.

## Prerequisite

System administrator or Omnichannel administrator role.

## Enable consult and transfer settings

1. In Copilot Service admin center, go to **Channels** in **Customer support**.
1. Select **Manage** for **Consult and transfer**.
1. On the **Consult and transfer** page, do the following steps to enable consult:
   - Turn on the toggle for **Consult to queue**.
   - Enter countdown numbers for voice and messaging channels to indicate the time the system spends to find representatives to consult with.
   - Select the checkbox to block capacity of the representatives who are engaged in a consultation that's invoked using the consult with representatives option on the communication panel.
1. To enable transfer, turb on the **transfer to representatives** toggle.
1. Select **Save**.

## Runtime experience

Only after you enable the consult or transfer setting, your service representatives can see the **Queue** or **Representatives** tab on the communication panel. The tab also appears when the representative wants to transfer conversations to another representative after engaging in a consultation with them.

## Related information

[Consult with representative or supervisor](../use/oc-conversation-control.md#consult-with-representative-or-supervisor)  
[Use consult to collaborate with other representatives or supervisors](../use/voice-channel-transfer-consult.md#use-consult-to-collaborate-with-other-representatives-or-supervisors)  
[Transfer conversations to representatives](../use/oc-conversation-control.md#transfer-conversations)  
[Transfer calls to representatives](../use/voice-channel-transfer-consult.md#transfer-calls)