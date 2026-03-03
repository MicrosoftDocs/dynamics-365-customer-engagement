---
title: Show persistent customers their previous conversations
description: Learn how to enable persistent chat customers to see their old conversations with Dynamics 365 Contact Center.
ms.date: 
author: 
ms.author: 
ms.reviewer: 
ms.topic: how-to
---

# Show persistent customers their previous conversations

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

When enabled in a persistent chat workstream, the Live Chat Widget shows any previous conversations with the customer inside the widget. This setting allows your customers to see answers that they previously received from your AI Agents or your Customer Service Representatives, even after the conversation ended.

> [!IMPORTANT]
> - This feature requires a persistent workstream
> - Media attachments and interactive rich messages, such as forms, are not shown in previous conversations
> - Automated status messages (such as queue notifications) are not shown in previous conversations

## Enabling display of previous conversations
     
   :::image type="content" source="../media/show-previous-conversation.png" alt-text="Show previous conversations interface":::

1. Sign in to the Copilot Service admin center application, and then go to the workstream for which you want to configure the queue setting.
2. Select **Edit** on the channel settings page, and go to the **Chat widget** tab.
3. **Toggle Show** previous conversations to **On**.
4. In History duration (months), choose a number from 1 to 12. The Live Chat Widget retrieves previous messages up to this limit.

### Related information

[Configure persistent chat](persistent-chat.md)  
