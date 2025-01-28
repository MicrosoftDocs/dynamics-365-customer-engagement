---
title: Configure persistent chat
description: Use this article to understand how persistent chat works and how you can configure it in Dynamics 365 Contact Center.
ms.date: 01/27/2025
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure persistent chat

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and customer service representatives (service representatives or representatives) need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Live chat and persistent chat share the same channel. If you need to configure both live and persistent chat widgets, create two separate workstreams and update the settings accordingly.  

The primary differences between live chat and persistent chat are as follows:

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Availability of representatives outside of operation hours|Allows customers to reach out to service representatives outside of working hours. If no representatives are available, the conversation remains open and the representative receives the customer messages during the operating hours.|Outside of operating hours, customers might not be able to chat with live representatives.|
|Ending conversations|Customers can't end conversations from their side. Only representatives can do it. |Both customers and representatives can end the conversation by closing the chat.|
|Default system messages|Persistent chat doesn't display default messages about average wait time and queue positions, because the customer doesn't need to wait for the representative. |In live chat, the customer receives system messages about wait time. These messages can be overwritten in the **Settings** tab.|

## How persistent chat works

From the start of a conversation until the representative explicitly ends it, representatives and customers are able to see the history of the conversation in the chat widget. Customers can close the chat widget and come back to it later, they can still see their history and pick up where they left. When a customer is unresponsive at length, representatives can attend to other conversations by moving their current conversation into a waiting stage, by selecting the ✖ button. Chats in a waiting stage don't take up the representatives' capacity. When the customer comes back to the chat, the representative is notified, and the conversation can be picked up and resolved.

## Prerequisites

Make sure that the authentication settings are configured. More information: [Create chat authentication settings](create-chat-auth-settings.md)

## Set up persistent chat

In admin center, select the **Make chats persistent** checkbox when you create the chat workstream. More information: [Create and manage workstreams](create-workstreams.md)

Make sure that you set the **Keep same agent for entire conversation** toggle to **Yes** in the **Work distribution** settings of the workstream. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)

### Assign work items automatically for returning conversations

When the **Keep same agent for entire conversation** toggle is set to **Yes**, and the representative is away or offline, they can't accept the notification for a returning conversation. In such cases, the conversation is assigned to a different agent.

If you want to make sure that the same agent is assigned to the persistent chat, do the following steps:

1. Create a notification template that's based on the **Chat - incoming authenticated - default** template.
1. Make sure that **Auto-assign work items** toggle is set to **Yes**, and save the notification template with an intuitive name such as **Chat-agent-affinity-autoassign**.
1. In the persistent chat workstream settings, go to **Advanced settings**, and in **Agent notification**, for **Returning Conversation** select the template that you created.

> [!NOTE]
> We recommend that you use the auto-assign setting cautiously because if the agent goes offline for an extended period, the chat might still remain assigned to them.

### Related information

[Configure a chat widget](add-chat-widget.md)  
[Manage notification templates](notification-templates.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
