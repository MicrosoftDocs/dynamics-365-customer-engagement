---
title: Understand conversation states 
description: Use this article to learn about various states and status reasons of conversations or work items in Omnichannel for Customer Service.
ms.date: 06/12/2023
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Understand conversation states

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article explains the various states and status reasons of the conversation (work item) in Omnichannel for Customer Service.

The conversation can be in an open or closed state, and can have the following status reasons:

- [Open](#open)
- [Active](#active)
- [Waiting](#waiting)
- [Wrap-up](#wrap-up)
- [Closed](#closed)

 ![Omnichannel conversation states.](media/oc-conversation-state.png "Conversation states")

 *Channel* refers to SMS, voice, social, and Microsoft Teams channels supported in Omnichannel for Customer Service.

> [!NOTE]
> Additionally, the conversation might have the resolved or scheduled status reason, which is for internal use only.

## Open

The conversation (work item) that is in the queue and not assigned to you (agent) is classified under **Open** state.

The conversation (work item) transitions from **Open** to **Active** or **Closed** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. | Channel<br><br>Chat|
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you. More information: [Understand disconnected chats](oc-conv-state-chat-disconnect.md)| Chat |

![Transition from open to active or closed.](media/oc-conversation-open1.png "Transition from open to active or closed")

## Active

The conversation that you pick or that is assigned to you is classified under **Active**. In **Active**, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** under the following scenarios.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget (only for a chat channel). <br><br> When the customer is disconnected from the conversation (applicable only to Live chat channel).| Channel <br><br> Chat|
| Active        | Open             | When you disconnect the conversation and don't reconnect within a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another queue. <br><br> When you close the session while the conversation is active (applicable only to Live chat channel). | Channel <br><br> Chat |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button) while the conversation is active.|  Channel <br><br> The status change isn't applicable to Live chat. | 
| Active | Closed | When you resolve the case (or get a record to non-active state) and close the session. | Record |

![Transition from active to closed, open, waiting, wrap-up, or in-progress state.](media/oc-conversation-active.png "Active state")

## Wrap-up

This is an intermediate state after you end the conversation, when you can do post-conversation activities such as taking notes and update the customer information, before moving the conversation to the **Closed** state. In the **Wrap-up** state, your (agent) capacity is blocked according to the duration that your administrator has selected in the **Block capacity for wrap up** field in the workstream. If your administrator has selected **Always block**, your capacity is blocked as long as the conversation is in the **Wrap-up** state. If the **Don't block** setting is selected, your capacity is released as soon as conversation moves from **Active** to **Wrap-up** state. Your administrator might also select a duration ranging from 1 to 60 minutes. More information: [Configure work distribution](create-workstreams.md#configure-work-distribution)

The conversation (work item) transitions from **Wrap-up** to **Closed** under the following scenario.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Channel <br><br> Chat|

![Transition from wrap-up to closed state.](media/oc-conversation-wrap-up1.png "Wrap-up state")

> [!NOTE]
> When a live chat conversation gets disconnected, Omnichannel for Customer Service will automatically move **Active** conversations to the **Wrap-up** state. More information: [Understand disconnected chats](oc-conv-state-chat-disconnect.md)

## Waiting

> [!NOTE]
> Waiting state applies only to asynchronous and persistent chats, and not live chats.

A conversation in waiting doesn't block your capacity. The conversation gets transitioned to waiting when you (agent) close the session without ending the conversation (that is, without selecting the **End** button on the communication panel) or when the customer closes the browser window without closing the chat widget. For example, you're waiting for some information from customer and don't want to end the conversation or the customer's browser closes unexpectedly.

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When there's no activity on this conversation from either customer or agent, within inactivity timeout period. | Channel  |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **Omnichannel Agent Dashboard**. | Channel |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period while the session is still active in the browser. | Channel |

![Transition from waiting to closed, active, or open state.](media/oc-conversation-waiting1.png "Waiting state")

## Closed

The conversations that are completed by ending them or closing the session are classified as **Closed** conversations. You can't reactivate or reopen closed conversations.

## Automatically close conversations

Omnichannel for Customer Service has a default time set for the conversation to close automatically. That is, if a conversation in a certain stage remains in the stage for more than the default time, then the conversation is moved to the closed state. Conversations achieve a closure, and agents can focus on important conversation, which ultimately enhances the productivity.

The Omnichannel for Customer Service scheduler checks conversations every 5 minutes to identify those conversations that don't transition for more than the default configured time. Such conversations become eligible for automatic closure, so the next time the scheduler runs, the conversations are moved from the existing state to the **Closed** state.

> [!IMPORTANT]
> - To avoid inaccurate statuses, we recommend that you don't change the conversation state and status reason by manually updating the records in Microsoft Dataverse.
> - For any actions performed on the conversations such as monitor, consult, or transfer, the scheduler will automatically recalculate the time to close the conversation.

### Default time for automatic closure of conversations

All channels have different default configured time after which conversations can be moved to the **Closed** state. However, the exact time at which the scheduler runs is dependent on the Omnichannel for Customer Service deployment time in your region. For more information, contact Microsoft support.

The following table describes the channel, status reason, and default configured time.

 | Channel | Existing status reason | Default configured time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open |  20 min   | For a chat channel, a conversation in the **Open** state for more than 20 minutes is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | Chat | Active | None | For a chat channel, a conversation in the Active won’t be automatically closed. |
 | Chat | Wrap-up | 15 minutes | For a chat channel, a conversation that is in the **Wrap-up** stage for more than 15 minutes is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |
 |  |  |  |  |
 | Records (Case) | Open | None | For a records (case) channel, a conversation that's **Open** will be closed if the corresponding record is deleted. |
 | Records (Case) | Active | None | For a records (case) channel, a conversation that's  **Active** will be closed if the corresponding record is deleted. |
 |  |  |  |  |
| Voice | Open |  30 days   | The conversation is eligible for automatic closure after the default time, 30 days, elapses. The conversation is moved from the **Open** to **Closed** state when the scheduler runs after the elapsed time.|
 | Voice | Active | 30 days | The conversation is eligible for automatic closure after the default time, 30 days, elapses. The conversation is moved from the **Active** to **Closed** state when the scheduler runs after the elapsed time. |
 | Voice | Wrap-up | 1 day | The conversation is eligible for automatic closure after the default time, 1 day, elapses. The conversation is moved from the **Wrap-up** to **Closed** state when the scheduler runs after the elapsed time. |
 |  |  |  |  |
 | SMS, Teams, persistent chat, and social | Open | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, persistent chat, or a social channel&mdash;a conversation that has been in the **Open** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | SMS, Teams, and social | Active | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, or a social channel&mdash;a conversation that has been in the **Active** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Active** to the **Closed** state. |
 | SMS, Teams, persistent chat, and social | Wrap-up | One day | In an asynchronous channel&mdash;such as SMS, Teams, persistent chat, or a social channel&mdash;a conversation that has been in the **Wrap-up** state for more than one day is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |

### Conversation in waiting

A conversation in **Waiting** is moved to the **Closed** state when the conversation is inactive for a specified time. The inactive time can be set in the workstream for the **Auto-close after inactivity** option, based on which the conversation will be moved to the closed state after the criteria is met.

> [!NOTE]
> The **Auto-close after inactivity**  option is available for persistent chat, SMS, social, and Microsoft Teams channels only.

For example, when you set **Auto-close after inactivity** to 5 minutes, the conversation is moved to the **Closed** state if it has been in **Waiting** for more than 5 minutes.

To learn more, see [Create a workstream](../customer-service/create-workstreams.md).

### Set default time using APIs

Programmatically, you can change the default time and set it as per your organization's requirements using the Web APIs. To learn more, see [Configure automatic closure of conversations](../customer-service/auto-close-conversation.md).

### See also

[View communication panel](oc-conversation-control.md)  
[Configure automatic closure of conversations](auto-close-conversation.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
