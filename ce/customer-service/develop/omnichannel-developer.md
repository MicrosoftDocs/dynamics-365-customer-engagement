---
title: Developer tools for Customer Service
description: Developer guide for Customer Service provides developers the information they need to get started with using the extensibility features.
ms.date: 11/27/2023
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Developer tools for Customer Service

Dynamics 365 Customer Service lets you extend and customize the core functionalities to suit your business needs.

Some of the features that you can customize are listed in this article.

## Use a plug-in to route records other than cases

Use the IPlugin Interface plug-in to [route records other than cases](trigger-routing-non-case-records.md).

## Create a knowledge article using a template

Use the msdyn_GetKAObjectFromTemplate action to [create a knowledge article](create-knowledge-article-using-template.md) from an existing knowledge article template programmatically.


## Live chat widget SDK 

Omnichannel for Customer Service live chat widget SDK provides methods that lets you do the following.
- Set, retrieve, and remove custom context provider for a live chat session.
- Open an existing chat or start a new one.
- Set, retrieve, and remove authentication-token providers for a live chat session.

[Start a chat](initiate-chat-wait-time.md)  
[Live chat SDK reference](omnichannel-reference.md)

## Start proactive chat 

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time helps improve customer experience. Omnichannel for Customer Service allows you to offer proactive chat request to your customers when you think they can use some help.

[Start a chat proactively](start-proactive-chat.md)

## Send custom context

When a customer starts a chat, you can pass custom context to Omnichannel for Customer Service.

[Send custom context](send-context-starting-chat.md)

## Display custom context 

Learn how you can display the context variables in the Conversation Summary control for a conversation on the agent user interface.

[Display custom context](display-custom-context.md)

## Send authentication token

Learn how you can pass an authentication token to Omnichannel for Customer Service to authenticate a customer when they start a chat.

[Send authentication token](send-auth-token-starting-chat.md)

## Enable a bot to escalate and end conversation

Omnichannel for Customer Service allows you to route a conversation to a human agent when you think human intervention is required to successfully help the customer.

[Enable a bot to escalate and end conversation](bot-escalate-end-conversation.md)<br />

## Close conversations automatically

Learn how you can automatically close a conversation using Web API.

[Configure automatic closure of conversations](auto-close-conversation.md)

## runMacro API

The `runMacro` API allows you to execute a macro whose name was passed as a parameter in the API call.

[runMacro method](reference/methods/runMacro.md)

## Build a smart assist bot

Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively.

[Build a smart assist bot](smart-assist-bot.md)

## Enable bot context

Enable your Azure bot to understand context while authoring a bot flow. 

[Enable bot context](enable-bot-context.md)

## Bring your own custom messaging channel

Read how you can implement a connector to integrate custom messaging channels using Direct Line Bot.

[Integrate your own custom channel: Direct Line](bring-your-own-channel.md) 


### Related information

[Introduction to Omnichannel for Customer Service](../implement/introduction-omnichannel.md)<br />
[Omnichannel for Customer Service for system customizers](../administer/omnichannel-customizer.md)<br />
[Live chat SDK reference](omnichannel-reference.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
