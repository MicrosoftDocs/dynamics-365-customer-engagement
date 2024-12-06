---
title: Configure persistent chat
description: Use this article to understand how persistent chat works and how you can configure it in Dynamics 365 Contact Center.
ms.date: 06/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
ms.collection:
---

# Configure persistent chat

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and agents need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Live chat and persistent chat share the same channel. If you need to configure both live and persistent chat widgets, create two separate workstreams and update the settings accordingly.  

The primary differences between live chat and persistent chat are as follows:

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Agent availability outside of operation hours|Allows customers to reach out to agents outside of working hours. If no agents are available, the conversation will remain open and the agent will receive the customer's messages during the operating hours.|Outside of operating hours, customers might not be able to chat with live agents.
|Ending conversations|Customers can't end conversations from their side. Only agents can do it. |Both customers and agents can end the conversation by closing the chat.|
|Default system messages|Persistent chat doesn't display default messages about average wait time and queue positions, because a customer doesn't need to wait for an agent. |In live chat, the customer receives system messages about wait time. These messages can be overwritten in the **Settings** tab.

## How persistent chat works

From the start of a conversation until the agent explicitly ends it, agents and customers will be able to see the history of the conversation in the chat widget. Customers can close the chat widget and come back after a long time, and still see their history, with the ability to pick up where they left. When a customer is unresponsive for a long time, agents can attend to other conversations by moving their current conversation into a waiting stage, by selecting the ✖ button. Chats in a waiting stage do not take up agent capacity. When the customer comes back to the chat, the agent is notified and the conversation can be picked up and resolved.

## Prerequisites

Make sure that the authentication settings are configured. More information: [Create chat authentication settings](create-chat-auth-settings.md)

## Set up persistent chat

In admin center, select the **Make chats persistent** checkbox when you create the chat workstream. More information: [Create and manage workstreams](create-workstreams.md)

Make sure that you set the **Keep same agent for entire conversation** toggle to **Yes** in the **Work distribution** settings of the workstream. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)

### Related information

[Configure a chat widget](add-chat-widget.md)  
[Create and manage workstreams](create-workstreams.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
