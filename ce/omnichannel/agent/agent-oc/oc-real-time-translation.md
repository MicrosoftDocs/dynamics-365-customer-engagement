---
title: "Real-time translation in Omnichannel for Customer Service | MicrosoftDocs"
description: "Overview of language translation for agent and customer chats in the Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/03/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Real-time language translation of conversations for agents and customers

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

When the administrator enables the setting that allows translation of conversation messages exchanged between the agent and customer or among agents internally, agent messages are displayed to customers in their preferred language or the language they used for initiating the chat.

## How language translation of conversations works

When a customer initiates a chat conversation on the portal in a language other than the default language that is set by the administrator, the assigned agent receives the chat in the language used by the customer that is translated to the language set as default before it is displayed. The translation happens in real time. For example, if a customer initiates chat in Spanish, the message appears to the agent in Spanish with the translated version that has been set as the default for the agent. The agent has the option to view and respond to the chat in the customer or default language.

If the agent has to consult a peer or supervisor, it can be done in a language preferred between the agent and peer or supervisor, which can be different from the language used between the agent and customer. The chat transcripts are saved in the languages used in the conversation.

The agent can see the following details pertaining to the feature:

Information on the language in which agent receives the chat content is displayed on the top of the chat window.

The chat content is displayed in customer language and translated language. The agent can choose to display chat only in the translated language.

A sample screenshot of the agent experience is as follows.

  > [!div class=mx-imgBorder]
  > ![Real-time language translation for agent](../../../media/oc-agent-translated-messages.png "Real-time language translation for agent")

A sample screenshot of the customer experience is as follows.

  > [!div class=mx-imgBorder]
  > ![Real-time language translation for customer](../../../media/oc-customer-translated-messages.png "Real-time language translation for customer")

### See also

[View customer summary](oc-customer-summary.md)  
[View communication panel](oc-conversation-control.md)  
