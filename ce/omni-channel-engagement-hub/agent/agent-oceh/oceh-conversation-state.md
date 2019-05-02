---
title: "Understand conversation states in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn what the conversation states are in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6C893ED1-0B3E-4E6C-96DB-796B807E6C6E
ms.custom: 
---

# Understand conversation states in Omni-channel Engagement Hub

The topic explains the various states of the conversation (work item) in Omni-channel Engagement Hub.

Types of conversation states:

 - [Open](#open)

 - [Active](#active)
 
 - [Waiting](#waiting)

 - [In-progress](#in-progress)
 
 - [Wrap-up](#wrap-up)

 - [Closed](#closed) 

 ![Omni-channel conversation states](../../media/oc-conversation-state.png "Conversation states")

## Open

The conversations (work items) that are in the queue or available for you (agent) to pick are classified under **Open** state. 

The conversation (work item) transitions from **Open** to **Active** or **Closed** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When the you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. <br><br> When the supervisor assigns the conversation to you. | SMS, Chat, Conversation, and Entity Routing |
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you.| Chat |

![Transition from open to active or closed state](../../media/oc-conversation-open.png "Open state")

## Active

The conversations that you pick for working are classified under **Active** state. In the **Active** state, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, **Wrap-up**, or **In-progress** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Closed           | When you complete working on the conversation and end the conversation and close the session.| Entity Routing |
| Active        | Open             | When you disconnect the conversation and doesn't reconnect with in a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another agent or queue. <br><br> | Conversation |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button).<br><br> When the customer disconnects the conversation, and you wrap-up (close) the session (not ending the conversation by selecting the **End** button). <br><br> When you select the **Waiting** button in communication panel. |   Conversation |
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget.| Conversation |
| Active        | In-progress      | When you close the session with conversation in active state.  | SMS  |

![Transition from active to closed, open, waiting, wrap-up, or in-progress state](../../media/oc-conversation-active.png "Active state")

## Waiting

The conversations that you close or customer disconnects are classified under **Waiting** state. These conversations are not just closed and not ended by selecting the **End** button either in communication panel (for agent) and portal chat widget (for customer).

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** state under the following scenarios.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When you don't reconnect to the conversation with in a specified timeout period.<br><br> When the customer selects the **End** button to end the conversation and close the session.| Conversation. |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **Omni-channel Agent Dashboard**. | Conversation |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period. | Conversation |

![Transition from waiting to closed, active, or open state](../../media/oc-conversation-waiting.png "Waiting state")

## In-progress

The session that you close while conversation is still in active state are classified under **In-progress** state.

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| In-progress   | Closed           | When you don't perform any action, then then conversation auto-closes after the inactivity timeout. | SMS |

![Transition from in-progress to closed state](../../media/oc-conversation-in-progress.png "In-progress state")

## Wrap-up

The conversations that are ended either by you or the customer are classified under **Wrap-up** state. This state is a phase where can finish the Wrap-up activities like taking notes and update the customer information before moving the conversation to **Closed** state.

The conversation (work item) transitions from **Wrap-up** to **Closed** state under the following scenario. 

| From state | To state | Scenario  | Type (SMS, Chat, Entity Routing, Conversation Channels) |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Conversation |

![Transition from wrap-up to closed state](../../media/oc-conversation-wrap-up.png "Wrap-up state")

## Closed

The conversations that are completed by ending, and closing the session are classified under **Closed** state. When you close a conversation, you cannot reactivate or reopen the conversation again.

> [!div class="nextstepaction"]
> [View communication panel](oceh-conversation-control.md)

## See also

[Understand conversation state lifecycle](../../administrator/conversation-state-lifecycle.md)
