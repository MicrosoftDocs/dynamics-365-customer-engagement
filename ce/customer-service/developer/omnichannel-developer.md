---
title: "Omnichannel for Customer Service for developers | MicrosoftDocs"
description: "Developer guide for Omnichannel for Customer Service provides developers the information they need to get started with using the extensibility features"
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 04/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Omnichannel for Customer Service for developers

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]


## Live chat widget SDK 

Omnichannel for Customer Service live chat widget SDK provides methods that allow you to:
- Set, retrieve, and remove custom context provider for a live chat session.
- Open an existing chat or initiate a new one.
- Set, retrieve, and remove authentication-token providers for a live chat session.

[Initiate a chat](../initiate-chat-wait-time.md)<br />
[JavaScript API reference for live chat SDK](omnichannel-reference.md)

## Start proactive chat 

Anticipating areas where customers need help and then engaging them through chat when they have been browsing your website for some time helps improve customer experience. Omnichannel for Customer Service allows you to offer proactive chat request to your customers when you think they can use some help.

[Start chat proactively](../start-proactive-chat.md)

## Manage custom context

When a customer initiates a chat, you can pass custom context to Omnichannel for Customer Service.

[Manage custom context](../send-context-starting-chat.md)

## Display custom context 

Learn how you can display the context variables in the Conversation Summary Control for a conversation on the UI.

[Display custom context](../display-custom-context.md)

## Send authentication token 

Learn how you can pass an authentication token to Omnichannel for Customer Service to authenticate a customer when they initiate a chat.

[Send authentication token](../send-auth-token-starting-chat.md)

##  Enable a bot to escalate and end conversation

Omnichannel for Customer Service allows you to route a conversation to a human agent when you think human intervention is required to successfully help the customer.

[Enable a bot to escalate and end conversation](../bot-escalate-end-conversation.md)<br />

## Auto-close a conversation 

Learn how you can automatically close a conversation using Web API.

[Auto-close a conversation](../auto-close-conversation.md)

## runMacro API

`runMacro` API allows you to execute a macro whose name was passed as a parameter in the API call.

[runMacro method](reference/methods/runMacro.md)

## Build a smart assist bot

Read how you can build a smart assist bot to help agents resolve customer queries faster and more effectively.

[Build a smart assist bot](../smart-assist-bot.md)

## Enable bot context

Enable your Azure bot to understand context while authoring a bot flow. 

[Enable bot context](../enable-bot-context.md)

## Bring your own custom messaging channel

Read how you can implement a connector to integrate custom messaging channels using Direct Line Bot.

[Bring your own channel](../bring-your-own-channel.md) 


### See also

[Introduction to Omnichannel for Customer Service](../introduction-omnichannel.md)<br />
[Omnichannel for Customer Service for administrators](../omnichannel-administrator.md)<br />
[Omnichannel for Customer Service for system customizers](../omnichannel-customizer.md)<br />
[Omnichannel for Customer Service for agents](../omnichannel-agent-overview.md)<br />
[Dynamics 365 Channel Integration Framework guide](../../customer-service/channel-integration-framework/channel-integration-framework.md)
