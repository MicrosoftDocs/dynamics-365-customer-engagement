---
title: "Understand conversation states in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn what are the conversation states in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/07/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 92C7CE55-87CE-437A-ABD3-65600CAE4DD2
ms.custom: 
---

# Understand conversation states in Omni-channel Engagement Hub

The topic explains the various states of the conversation (work item) in Omni-channel Engagement Hub.

Types of conversation states:

 - Open

 - Active
 
 - Waiting
 
 - Wrap-up

 - Closed

## Open

The conversations (work items) that are in the queue or available for you (agent) to pick are classified under **Open** state. 

The conversation (work item) transitions from **Open** to **Active** or **Closed** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When the you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. <br><br> When the supervisor assigns the conversation to you. | SMS, Chat, Conversation, and Entity Routing |
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you.| Chat |

## Active

The conversations that you pick for working are classified under **Active** state. In the **Active** state, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, **Wrap-up**, or **In-progress** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Closed           | When you complete working on the conversation and end the conversation and close the session.| Entity Routing |
| Active        | Open             | When you disconnect the conversation and doesn't reconnect with in a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another agent or queue. <br><br> | Conversation |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button).<br><br> When the customer disconnects the conversation, and you **Wrap-up** (close) the session (not ending the conversation by selecting the **End** button). <br><br> When you select the **Waiting** button in communication panel. |   Conversation |
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget.| Conversation |
| Active        | In-progress      | When you close the session with conversation in active state.  | SMS  |

## Waiting

The conversations that you close or customer disconnects are classified under **Waiting** state. These conversations are not just closed and not ended by selecting the **End** button either in communication panel (for agent) and portal chat widget (for customer).

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When you don't reconnect to the conversation with in a specified timeout period.<br><br> When the customer selects the **End** button to end the conversation and close the session.| Conversation. |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **My Dashboard**. | Conversation |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period. | Conversation |

## In-progress

The session that you close while conversation is still in active state are classified under **In-progress** state.

| Initial state | Transition state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| In-progress   | Closed           | When you don't perform any action, then then conversation auto-closes after the inactivity timeout. | SMS |

## Wrap-up

The conversations that are ended either by you or the customer are classified under **Wrap-up** state. This state is a phase where can finish the Wrap-up activities like taking notes and update the customer information before moving the conversation to **Closed** state.

The conversation (work item) transitions from **Wrap-up** to **Closed** state under the following scenario. 

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Conversation |

## Closed

The conversations that are completed by ending, and closing the session are classified under **Closed** state. When you close a conversation, you cannot reactivate or reopen the conversation again.

## See also

[Understand conversation state lifecycle](../../administrator/conversation-state-lifecycle.md)