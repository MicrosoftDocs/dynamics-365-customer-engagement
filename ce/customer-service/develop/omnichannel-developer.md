---
title: Developer tools for Customer Service
description: Learn about developer tools and extensibility features for customizing Dynamics 365 Customer Service.
ms.date: 11/26/2026
ms.topic: overview
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# Developer tools for Customer Service

Extend and customize Dynamics 365 Customer Service to meet your business needs. This article introduces the available tools and extensibility features.

## Use a plug-in to route records other than cases

Use a plug-in that implements the `IPlugin` interface to [route records other than cases](trigger-routing-non-case-records.md).

## Create a knowledge article using a template

Use the `msdyn_GetKAObjectFromTemplate` action to programmatically [create a knowledge article](create-knowledge-article-using-template.md) from an existing template.


## Live chat widget SDK 

The Omnichannel for Customer Service live chat widget SDK provides methods to:
- Set, retrieve, and remove a custom context provider for a live chat session.
- Open an existing chat or start a new one.
- Set, retrieve, and remove authentication-token providers for a live chat session.

[Start a chat](initiate-chat-wait-time.md)  
[Live chat SDK reference](omnichannel-reference.md)

## Start proactive chat 

Offer proactive chat to customers who have been browsing your website and might need help.

[Start a chat proactively](start-proactive-chat.md)

## Send custom context

When a customer starts a chat, you can pass custom context to Omnichannel for Customer Service.

[Send custom context](send-context-starting-chat.md)

## Display custom context 

Display a conversation's context variables in the Conversation Summary control on the agent interface.

[Display custom context](display-custom-context.md)

## Send authentication token

Pass an authentication token to Omnichannel for Customer Service to authenticate a customer when they start a chat.

[Send authentication token](send-auth-token-starting-chat.md)

## Enable a bot to escalate and end conversation

Route a conversation to a customer service representative (service representative or representative) when the customer needs human assistance.

[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)<br />

## Close conversations automatically

Use the Web API to close conversations automatically.

[Configure automatic closure of conversations](auto-close-conversation.md)

## runMacro API

Use the `runMacro` API to run a macro by passing its name as a parameter.

[runMacro method](reference/methods/runMacro.md)

## Build a smart assist bot

Build a smart assist bot to help service representatives resolve customer queries.

[Build a smart assist bot](smart-assist-bot.md)

## Enable bot context

Enable your Azure bot to understand context when you author a bot flow.

[Enable bot context](enable-bot-context.md)

## Bring your own custom messaging channel

Implement a connector to integrate custom messaging channels using Direct Line Bot.

[Integrate your own custom channel: Direct Line](bring-your-own-channel.md) 


## Related information

[Introduction to Omnichannel for Customer Service](../implement/introduction-omnichannel.md)  
[Live chat SDK reference](omnichannel-reference.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
