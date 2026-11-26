---
title: "Live chat SDK reference| MicrosoftDocs"
description: "Get an overview of the JavaScript API reference for the live chat widget in Omnichannel for Customer Service."
ms.date: 04/04/2021
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---
# Live chat SDK Reference

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The following JavaScript methods can be used to do various operations with the live chat widget of Omnichannel for Customer Service.

## Methods

| Method | Description |
|---------|-------------|
| [`setContextProvider`](reference/methods/setContextProvider.md) | [!INCLUDE[setContextProvider-description](reference/includes/setContextProvider-description.md)] |
| [`getContextProvider`](reference/methods/getContextProvider.md) | [!INCLUDE[getContextProvider-description](reference/includes/getContextProvider-description.md)] |
| [`removeContextProvider`](reference/methods/removeContextProvider.md) | [!INCLUDE[removeContextProvider-description](reference/includes/removeContextProvider-description.md)] |
| [`setAuthTokenProvider`](reference/methods/setAuthTokenProvider.md) | [!INCLUDE[setAuthTokenProvider-description](reference/includes/setAuthTokenProvider-description.md)] |
| [`getAuthTokenProvider`](reference/methods/getAuthTokenProvider.md) | [!INCLUDE[getAuthTokenProvider-description](reference/includes/getAuthTokenProvider-description.md)] |
| [`removeAuthTokenProvider`](reference/methods/removeAuthTokenProvider.md) | [!INCLUDE[removeAuthTokenProvider-description](reference/includes/removeAuthTokenProvider-description.md)] |
| [`startChat`](reference/methods/startchat.md) | [!INCLUDE[startchat-description](reference/includes/startchat-description.md)] |
| [`startProactiveChat`](reference/methods/startProactiveChat.md) | [!INCLUDE[startproactivechat-description](reference/includes/startproactivechat-description.md)] |
| [`closeChat`](reference/methods/closeChat.md) | [!INCLUDE[closechat-description](reference/includes/closechat-description.md)] |
| [`getAgentAvailability`](reference/methods/getAgentAvailability.md) | [!INCLUDE[getAgentAvailability-description](reference/includes/getAgentAvailability-description.md)] |

## Events

| Event | Description |
|---------|-------------|
| [`lcw:ready`](reference/events/lcw-ready.md) | [!INCLUDE[`lcw-ready-description`](reference/includes/lcw-ready-description.md)] |
| [`lcw:error`](reference/events/lcw-error.md) | [!INCLUDE[`lcw-error-description`](reference/includes/lcw-error-description.md)] |
| [`lcw:startChat`](reference/events/lcw-startchat.md) | This event is triggered when a chat is started.  |
| [`lcw:closeChat`](reference/events/lcw-closechat.md) | This event is triggered when a chat is closed. |
| [`lcw:chatQueued`](reference/events/lcw-chatQueued.md) | This event is raised when the chat conversation is created and started.  |
| [`lcw:chatRetrieved`](reference/events/lcw-chatRetrieved.md) | This event is raised when the system retrieves an ongoing chat conversation from cache after a page is reloaded or opened on another tab. |
| [`lcw:onClose`](reference/events/lcw-onclose.md) | This event is triggered when the customer engaged on the chat widget closes the widget.|
| [`lcw:onMinimize`](reference/events/lcw-onminimize.md) | This event is triggered when the customer engaged on the chat widget minimizes the widget.  |
| [`lcw:onMaximize`](reference/events/lcw-onmaximize.md) | This event is triggered when the customer engaged on the chat widget maximizes the widget. |
| [`lcw:onMessageReceived`](reference/events/lcw-onmessagereceived.md) | This event is triggered when the chat widget gets a new message. |
| [`lcw:onMessageSent`](reference/events/lcw-onmessagesent.md) | This event is triggered when a customer engaged on the chat widget sends a new message.  |
| [`lcw:threadUpdate`](reference/events/lcw-threadUpdate.md) | This event is raised by live chat when an agent ends a conversation. |
| [`lcw:getAgentAvailability`](reference/events/lcw-getAgentAvailability.md) | This event is raised when the [`getAgentAvailability`](reference/methods/getAgentAvailability.md) method returns a successful response. |

### Related information

[Omnichannel for Customer Service for developers](omnichannel-developer.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
