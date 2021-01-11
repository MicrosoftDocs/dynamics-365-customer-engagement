---
title: "Persistent chat | MicrosoftDocs"
description: "Overview of Persistent chat in Omnichannel for Customer Service."
author: Meghanalanka
ms.author: v-mlanka
manager: shujoshi
ms.date: 01/06/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure persistent chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Overview

Persistent chat is an asynchronous mode for the chat channel that allows conversations to happen over multiple sessions. Unlike in live chat, where customers and agents need to be available simultaneously, persistent chat allows users to leave the conversation between sessions and pick it up later. 

Persistent chat allows authenticated users to leave the conversation between sessions and pick it up later. This gives customers the flexibility to reply at their convenience.

Live chat and persistent chat share the same channel. 

The primary differences between live chat and persistent chat are as follows:

| Feature                       | Persistent chat                   | Live chat
|------------------------------------------|-----------------------------------|------------------------------|
|Agent availability outside of operation hours|Allows customers to reach out to agents outside of working hours. If no agents are available, the conversation will remain open and the agent will receive the customer's messages during the operating hours.|Outside of operating hours, customers may not be able to chat with live agents. 
|Ending conversations|Customers can't end conversations from their side. Only agents can do it. |Both customers and agents can end the conversation by closing the chat.|
|Default system messages|Persistent chat doesn't display default messages about average wait time and queue positions, because a customer does not wait for an agent to start describing their issue. |Live chat sends the customer system messages about wait time. These messages can be overwritten in the settings tab. 

## How persistent chat works

From the start of a conversation until the agent explicitly ends it, agents and customers will be able to see the history of the conversation in the chat widget. Customers can close the chat widget and come back over longer time periods, and still see their history, picking up where they left off. Agents can release their capacity while waiting for a customer reply by putting the chat into waiting state. After the issue is resolved, agents will end the conversation. The next time that a customer engages with chat, they will start a fresh session.

## Set up persistent chat

Persistent chat can be enabled in the chat widget settings for a chat channel. When persistent chat is chosen as the conversation mode, some fields in the settings will update to reflect this conversation mode. Admins will need to add authentication settings, which are required for persistent chat. 

The following settings are required in the work stream:

- The **auto-close after inactivity** field should be changed from 5 minutes to 28 days, allowing conversations to stay open longer.

- The **agent affinity** field should be set to true. When a customer returns to a persistent chat, this will ensure that the system first ties to connect them to the same agent. The default for live chat sets this to **false**, but for persistent chat it should be **true**.  

- If an organization wants both a live chat widget and a persistent chat widget, create two separate work streams so the admin settings make sense for that conversation mode.   

## Persistent chat for agents

If your organization has chosen persistent chat as the mode of conversation, you should train your agents on the following aspects: 

- Agents should not end the conversation; instead, they should close the conversation so that it is moved into a waiting state, which is typically 28 days or the value that is configured in the work stream.

- Agents need to confirm if the customer's issues is resolved and then end the session by selecting **End**. After the agent ends the chat, the chat history will not be shown when the customer comes back. A fresh chat session will be initiated.

**Note**: Agents should be trained to verify with customers that issues are resolved before taking this step.

### See also

[Configure a chat widget](https://go.microsoft.com/fwlink/p/?linkid=2152613)

[Create work streams](https://go.microsoft.com/fwlink/p/?linkid=2152613)