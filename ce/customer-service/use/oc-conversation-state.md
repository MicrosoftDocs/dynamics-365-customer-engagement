---
title: Understand conversation states 
description: Use this article to learn about various states and status reasons of conversations or work items in Omnichannel for Customer Service.
ms.date: 04/03/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer:
ms.custom: bap-template
---

# Understand conversation states

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


This article explains the various states and status reasons of the conversation (work item) in Omnichannel for Customer Service.

The conversation can be in an open or closed state, and can have the following status reasons:

- [Open](#open)
- [Active](#active)
- [Waiting](#waiting)
- [Wrap-up](#wrap-up)
- [Closed](#closed)

 ![Omnichannel conversation states.](../media/oc-conversation-state.png "Conversation states")

 *Channel* refers to SMS, voice, social, and Microsoft Teams channels supported in Omnichannel for Customer Service.

> [!NOTE]
> Additionally, the conversation might have the resolved or scheduled status reason, which is for internal use only.

## Open

The conversation (work item) that is in the queue and not assigned to the agent is classified under **Open** state.

The conversation (work item) transitions from **Open** to **Active** or **Closed** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | An agent picks the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to the agent. | Channel<br><br>Chat|
| Open          | Closed           | The customer disconnects or ends the chat before the conversation is assigned to the agent. More information: [Understand disconnected chats](oc-conv-state-chat-disconnect.md)| Chat |

![Transition from open to active or closed.](../media/oc-conversation-open1.png "Transition from open to active or closed")

## Active

The conversation that an agent picks or is assigned to the agent is classified under **Active**. In **Active**, the agent capacity is consumed.

> [!NOTE]
> - When you use the transfer to external number option for a voice call, the conversation remains in active state with the agent on the external number as the new primary agent.  The capacity of the original agent is immediately released.
> - When you transfer the voice call to another internal agent, the conversation remains in active state with the other internal agent as primary, and the original agent’s capacity is immediately released.  When you transfer to another queue, the conversation goes into open state while waiting in the new queue, and the original primary agent’s capacity is immediately released.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** under the following scenarios.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | An agent selects the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget (only for a chat channel). <br><br> When the customer is disconnected from the conversation (applicable only to Live chat channel).| Channel <br><br> Chat|
| Active        | Open             | An agent disconnects the conversation and doesn't reconnect within a specified timeout period. <br><br> When an agent releases the conversation to the queue. <br><br> When an agent transfers the conversation to another queue. <br><br> When an agent closes the session while the conversation is active (applicable only to Live chat channel). | Channel <br><br> Chat |
| Active        | Waiting          | An agent closes the session (not ending the conversation by selecting the **End** button) while the conversation is active.|  Channel <br><br> The status change isn't applicable to Live chat. | 
| Active | Closed | An agent resolves the case (or get a record to nonactive state) and closes the session. | Record |
| Active | Closed | The customer disconnects or ends the chat before the conversation is accepted by the agent. More information: [Understand disconnected chats](oc-conv-state-chat-disconnect.md) | Chat |

![Transition from active to closed, open, waiting, wrap-up, or in-progress state.](../media/oc-conversation-active.png "Active state")

## Wrap-up

The wrap-up state is an intermediate state after the agent ends the conversation and does post-conversation activities, such as taking notes and updating the customer information, before moving the conversation to the **Closed** state. In the **Wrap-up** state, the agent capacity is blocked according to the duration that the agent selects in the **Block capacity for wrap up** field in the workstream. If the agent selects **Always block**, their capacity is blocked as long as the conversation is in the **Wrap-up** state. If the **Don't block** setting is selected, the agent capacity is released as soon as conversation moves from **Active** to **Wrap-up** state. The agent might also select a duration that ranges from 1 to 60 minutes. More information: [Configure work distribution](../administer/create-workstreams.md#configure-work-distribution)

The conversation (work item) transitions from **Wrap-up** to **Closed** under the following scenario.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | The agent selects the **End** button in communication panel and closes the session. | Channel <br><br> Chat|

![Transition from wrap-up to closed state.](../media/oc-conversation-wrap-up1.png "Wrap-up state")

> [!NOTE]
> When a live chat conversation gets disconnected, Omnichannel for Customer Service will automatically move **Active** conversations to the **Wrap-up** state. More information: [Understand disconnected chats](oc-conv-state-chat-disconnect.md)

## Waiting

> [!NOTE]
> Waiting state applies to asynchronous and persistent chats only, and not live chats.

A conversation in waiting doesn't consume agent capacity.When an agent closes the session by selecting the close icon but doesn't end it by selecting the **End** button on the communication panel, the conversation moves into the **Waiting** state. For example, the agent has asked for more information from the customer who is yet to respond back and the agent closes the communication panel without ending the conversation. The conversation is
reassigned to an agent after the customer responds.

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | There's no activity on this conversation from either customer or agent, within inactivity timeout period. | Channel  |
| Waiting       | Active           | An agent revives the session from the **My work items** stream on **Omnichannel Agent Dashboard**. | Channel |
| Waiting       | Open             | The customer revives the conversation within a specified timeout period while the session is still active in the browser. | Channel |

![Transition from waiting to closed, active, or open state.](../media/oc-conversation-waiting1.png "Waiting state")

## Closed

The conversations that are completed by ending them or closing the session are classified as **Closed** conversations. Agents can't reactivate or reopen closed conversations.

### Related information

[View communication panel](oc-conversation-control.md)  
[Configure automatic closure of conversations](../develop/auto-close-conversation.md)  
[Configure automatic closure of conversations using Power Apps](../administer/auto-close-conversation-powerapps.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
