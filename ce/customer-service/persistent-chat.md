---
title: "Persistent chat | MicrosoftDocs"
description: "Overview of Persistent chat in Omnichannel for Customer Service."
author: Meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 12/02/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure persistent chat

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Overview

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and agents need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Persistent chat allows authenticated users to leave the conversation between sessions and pick it up later. This gives customers the flexibility to reply at their convenience.

Although live chats and persistent chats share the same channel, there are a few core differences between the two.

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Agent availability outside of operation hours|Allows customers to reach out to agents outside of working hours. If no agents are available, the conversation will remain open and the agent will receive the customer's message during their operating hours.|Outside of operating hours, customers may not be able to chat with live agents. 
|Ending conversations|Customers cannot end conversations from their side. Only agents can do it. |Both customers and agents can end the conversation by simply closing the chat.|
|Default system messages|Persistent chat does not display default messages about average wait time and queue positions, since a customer does not wait for an agent to start describing their issue. |Live chat sends the customer system messages about wait time. These messages can be overwritten in the settings tab. 

## How persistent chat works

From the start of a conversation until the agent explicitly ends it, agents and customers will be able to see the history of the conversation in the chat widget itself. Customers can close the chat widget and come back over longer time periods, and still see their history, picking up where they left off. Agents can release their capacity while waiting for a customer reply by putting the chat into waiting state. Once the issue is resolved, agents will end the conversation. The next time that a customer engages with chat, they will start a fresh session. At this time, only an agent can end a conversation. 

## Admin setup for persistent chat

Persistent chat can be enabled in the chat widget settings under the chat channel. When persistent chat is chosen as the conversation mode, some fields in the settings will update to reflect this conversation mode. Admins will need to add authentication settings, which are required for persistent chat. 

The admin also needs to make a few changes at the work stream level for persistent chat to work properly:

- The 'auto-close after inactivity' field should be changed from 5 minutes to 28 days, allowing conversations to stay open longer.

- The 'agent affinity' field should be set to true. When a customer returns to a persistent chat, this will ensure that the system first ties to connect them to the same agent. The default for live chat sets this to 'false', but for persistent chat it should be 'true'.  

- If an organization wants both a live chat widget and a persistent chat widget, create two separate workstreams so the admin settings make sense for that conversation mode.   

## Persistent chat for agents

If an organization chooses persistent chat as its mode of conversation, it is crucial that agents who are required to interact with customers are adequately trained. Agents need to be trained not to end the conversation, but to close them and move them into a waiting period, typically 28 days. If an agent has confirmed with the customer that the issue is resolved and the agent wants to end the session, the agent should select **End**. No more history will be shown when the customer comes back, and a fresh session will be initiated. However, agents must be trained to verify with customers that issues are resolved before taking this step.

### See also

[Overview of channels](https://docs.microsoft.com/dynamics365/omnichannel/administrator/channels)
