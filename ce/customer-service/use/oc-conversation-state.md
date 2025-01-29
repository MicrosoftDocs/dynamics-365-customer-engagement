---
title: Understand conversation states 
description: Use this article to learn about various states and status reasons of conversations or work items in Omnichannel for Customer Service.
ms.date: 01/22/2025
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
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

The conversation (work item) that is in the queue and not assigned to the customer service representative (service representative or representative) is classified under **Open** state.

The conversation (work item) transitions from **Open** to **Active** or **Closed** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | The representative picks the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to the representative. | Channel<br><br>Chat|
| Open          | Closed           | The customer disconnects or ends the chat before the conversation is assigned to the representative. Learn more in [Understand disconnected chats](oc-conv-state-chat-disconnect.md).| Chat |

![Transition from open to active or closed.](../media/oc-conversation-open1.png "Transition from open to active or closed")

## Active

The conversation that the representative picks or is assigned to the representative is classified under **Active**. In **Active**, the representative capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** under the following scenarios.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | The representative selects the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget (only for a chat channel). <br><br> When the customer is disconnected from the conversation (applicable only to Live chat channel).| Channel <br><br> Chat|
| Active        | Open             | The representative disconnects the conversation and doesn't reconnect within a specified timeout period. <br><br> When the representative releases the conversation to the queue. <br><br> When the representative transfers the conversation to another queue. <br><br> When the representative closes the session while the conversation is active (applicable only to Live chat channel). | Channel <br><br> Chat |
| Active        | Waiting          | The representative closes the session by using the close (**X**) button (not ending the conversation by selecting the **End** button) while the conversation is active.|  Channel <br><br> The status change isn't applicable to Live chat. | 
| Active | Closed | The representative resolves the case (or get a record to nonactive state) and closes the session. | Record |
| Active | Closed | The customer disconnects or ends the chat before the conversation is accepted by the representative. Learn more in [Understand disconnected chats](oc-conv-state-chat-disconnect.md). | Chat |

![Transition from active to closed, open, waiting, wrap-up, or in-progress state.](../media/oc-conversation-active.png "Active state")

For call transfers in the voice channel, the system handles the capacity as follows:
- When you use the transfer to external number option for a voice call, the conversation remains in active state with the representative on the external number as the new primary representative.  The capacity of the original representative is immediately released.
- When you transfer the voice call to another internal representative, the conversation remains in active state with the other internal representative as primary, and the original representative's capacity is immediately released.  When you transfer to another queue, the conversation goes into open state while waiting in the new queue, and the original primary representative’s capacity is immediately released.


## Wrap-up

The wrap-up state is an intermediate state after the representative ends the conversation and does post-conversation activities, such as taking notes and updating the customer information, before moving the conversation to the **Closed** state. The representative capacity is blocked according to the duration that's specified for the **Block capacity for wrap up** field in the workstream. 

- **Always block**: The capacity is blocked when the conversation is in the **Wrap-up** state. 
- **Don't block**: The capacity is released when the conversation moves from **Active** to **Wrap-up** state.
- **Custom time**: Capacity is blocked for the selected duration that can range from 1 to 60 minutes. Learn more in [Configure work distribution](../administer/create-workstreams.md#configure-work-distribution).

The conversation (work item) transitions from **Wrap-up** to **Closed** under the following scenario.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | The representative selects the **End** button in communication panel and closes the session. | Channel <br><br> Chat|

![Transition from wrap-up to closed state.](../media/oc-conversation-wrap-up1.png "Wrap-up state")

> [!NOTE]
> When a live chat conversation gets disconnected, Omnichannel for Customer Service automatically moves **Active** conversations to the **Wrap-up** state. Learn more in [Understand disconnected chats](oc-conv-state-chat-disconnect.md).

## Waiting

> [!NOTE]
> The waiting state applies to asynchronous and persistent chats only, and not live chats or voice calls.

A conversation in waiting doesn't consume a representative's capacity.

When the representative closes the session by selecting the close (**X**) button but doesn't end it by selecting the **End** button on the communication panel, the conversation moves into the **Waiting** state. For example, the representative has asked for more information from the customer who is yet to respond back and the representative closes the communication panel without ending the conversation. The conversation is reassigned to the representative after the customer responds.

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | There's no activity on this conversation from either customer or representative, within inactivity timeout period. | Channel  |
| Waiting       | Active           | The representative revives the session from the **My work items** stream on **Omnichannel Agent Dashboard**. | Channel |
| Waiting       | Open             | The customer revives the conversation within a specified timeout period while the session is still active in the browser. | Channel |

![Transition from waiting to closed, active, or open state.](../media/oc-conversation-waiting1.png "Waiting state")

## Closed

The conversations that are completed by ending them or closing the session are classified as **Closed** conversations. Representatives can't reactivate or reopen closed conversations.

## How conversations are handled on close or end

When service representatives close the conversation using the close (**X**) button on the communication panel or end the conversation using the **End** button, the system handles the two behaviors as follows:

   - **End conversation using the End button**: For all the channels, the system moves the conversation to the wrap-up state where the representative's capacity remains occupied based on the **Block capacity for wrap-up** setting of the workstream.
   - **End conversation using the End button and then close session window using the close (X) button**: For all the channels, the system closes the conversation and the representative's capacity is immediately released when the representative uses the **End** button. If the **Block capacity for wrap-up** is **Always block** or **Custom time**, the capacity is blocked based on the specified time for the wrap-up activities. Representative can use the close (**X**) button to end the wrap-up stage early if they completed their work.
   - **Close conversation using the close (X) button and not the End button**: When the representative uses the close (**X**) button instead of the **End** button, the system handles the conversation as follows:
       - **Voice and chat channels**: The conversation goes into open state and the system reassigns the conversation to another available service representative.
       - **Persistent chat and asynchronous channels**: The conversation goes into a waiting state and the representative capacity is immediately released. When the customer comes back, the conversation is resumed again.

Learn about close or end conversation in [Close or end a conversation](oc-conversation-control.md#close-or-end-a-conversation).

### Related information

[View communication panel](oc-conversation-control.md)  
[Configure automatic closure of conversations](../develop/auto-close-conversation.md)  
[Configure automatic closure of conversations using Power Apps](../administer/auto-close-conversation-powerapps.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
