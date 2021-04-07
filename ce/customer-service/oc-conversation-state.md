---
title: "Understand conversation states in Omnichannel | MicrosoftDocs"
description: "Learn about the conversation states in Omnichannel."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 01/19/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Understand conversation states in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This topic explains the various states and status reasons of the conversation (work item) in Omnichannel for Customer Service.

The conversation can be in an open or closed state and can have the following status reasons:

- [Open](#open)
- [Active](#active)
- [Waiting](#waiting)
- [Wrap-up](#wrap-up)
- [Closed](#closed)

> [!NOTE]
> Additionally, the conversation might have the resolved or scheduled status reason, which is for internal use only.

 ![Omnichannel conversation states](media/oc-conversation-state1.png "Conversation states")
 
 *Channel* refers to the chat, SMS, social, and Teams channels supported in Omnichannel for Customer Service.

## Open

The conversation (work item) that is in the queue and not assigned to you (agent) is classified under **Open** state.

The conversation (work item) transitions from **Open** to **Active** or **Closed** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Open          | Active           | When you pick the conversation from the **Open work items** stream.<br><br> When the routing and work distribution feature pushes (assigns) the conversation to you. | Channel and Entity Record |
| Open          | Closed           | When the customer disconnects or ends the chat before the conversation is assigned to you.| Chat |

![Transition from open to active or closed](media/oc-conversation-open1.png "Transition from open to active or closed")

## Active

The conversation that you pick or that is assigned to you is classified under **Active**. In **Active**, your capacity is consumed.

The conversation (work item) transitions from **Active** to **Closed**, **Open**, **Waiting**, or **Wrap-up** under the following scenarios.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Active        | Wrap-up          | When you select the **End** button on communication panel during the conversation with the customer. <br><br> When customer ends the conversation by selecting the **End** button on the portal chat widget (only for a chat channel). | Channel |
| Active        | Open             | When you disconnect the conversation and don't reconnect within a specified timeout period. <br><br> When you release the conversation to the queue. <br><br> When you transfer the conversation to another queue. <br><br> | Channel  |
| Active        | Waiting          | When you close the session (not ending the conversation by selecting the **End** button) while the conversation is active.<br><br> When the customer is disconnected from the conversation, and you're no longer getting reply, you can close the session without ending the conversation (applicable only for SMS and social channels). This will keep conversation in waiting state. |  Channel  |
| Active | Closed | When you resolve the case (or get an entity record to non-active state) and close the session. | Entity Record |

> [!NOTE]
> If you decline a conversation 10 times within a time span of five minutes, then the conversation will be moved to the **Closed** state.

![Transition from active to closed, open, waiting, wrap-up, or in-progress state](media/oc-conversation-active1.png "Active state")

## Wrap-up

This is an intermediate state after you end the conversation, when you can do post-conversation activities, such as, taking notes and update the customer information before moving the conversation to **Closed**. In **Wrap-up**, your (agent) capacity is consumed.

The conversation (work item) transitions from **Wrap-up** to **Closed** under the following scenario.

| From status reason | To status reason | Scenario  | Type  |
|---------------|------------------|---------------------------------------------------------|------------|
| Wrap-up       | Closed           | When you select the **End** button in communication panel and close the session. | Channel |

![Transition from wrap-up to closed state](media/oc-conversation-wrap-up1.png "Wrap-up state")

## Waiting

A conversation in waiting doesn't block your capacity. The conversation gets transitioned to waiting when you (agent) close the session without ending the conversation (without selecting **End** button on communication panel) or the customer closes the browser window without closing the chat widget. For example, you're waiting for some information from customer and don't want to end the conversation or the customer's browser closes unexpectedly.

The conversation (work item) transitions from **Waiting** to **Closed**, **Active**, or **Open** under the following scenarios.

| From status reason | To status reason | Scenario  | Type |
|---------------|------------------|---------------------------------------------------------|------------|
| Waiting       | Closed           | When there's no activity on this conversation from either customer or agent, within inactivity timeout period. <br><br> When the customer selects the **End** button to end the conversation and close the session (only for a chat channel).| Channel  |
| Waiting       | Active           | When you revive the session from your **My work items** stream on **Omnichannel Agent Dashboard**. | Channel |
| Waiting       | Open             | When the customer revives the conversation within a specified timeout period while the session is still active in the browser. | Channel |

![Transition from waiting to closed, active, or open state](media/oc-conversation-waiting1.png "Waiting state")

## Closed

The conversation that are complete by ending, and closing the session is classified under **Closed**. When you close a conversation, you can't reactivate or reopen the conversation again.

## Automatic closure of a conversation

Omnichannel for Customer Service has a default time set for the conversation to close automatically. That is, if a conversation in a certain stage remains in the stage for more than the default time, then the conversation is moved to the closed state. Conversations achieve a closure, and agents can focus on important conversation, which ultimately enhances the productivity.

### Understand working of auto-close of conversations

The Omnichannel for Customer Service application checks the conversations every 24 hours to identify the conversations that do not transition for more than the default configured time. These conversations become eligible for automatic-closure, and next time, when the scheduler runs, these conversations are moved from the existing status reason to the **Closed** state.

> [!IMPORTANT]
> To avoid inaccurate statuses, we recommend that you don't change the conversation state and status reason by manually updating the records in Microsoft Dataverse.

### Default time for automatic closure of conversation

All channels have different default cofigured time after which conversations can be moved to Closed. The administrator can change the default configured time as per the business requirement programmatically. To learn more, see [Set default time using APIs](#set-default-time-using-apis).

The matrix describes the channel, status reason, and default configured time.

 | Channel | Existing status reason | Default configured time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open |  20 min   | For a chat channel, a conversation in the **Open** state for more than 20 minutes is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | Chat | Active | None | For a chat channel, a conversation in the Active won’t be automatically closed. |
 | Chat | Wrap-up | 15 minutes | For a chat channel, a conversation that is in the **Wrap-up** stage for more than 15 minutes is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |
 |  |  |  |  |
 | Entity records (Case) | Open | None | For an entity channel, a conversation in the **Open** won’t be automatically closed. |
 | Entity records (Case) | Active | None | For an entity channel, a conversation that is  **Active** won’t be automatically closed. |
 |  |  |  |  |
 | SMS | Open | 30 days | For an SMS channel, a conversation in the **Open** state for more than 30 days is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | SMS | Active | 30 days | For an SMS channel, a conversation that is **Active** for more than 30 days is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from **Active** to the **Closed** state. |
 | SMS | Wrap-up | 1 day | For an SMS channel, a conversation in **Wrap-up** for more than 1 day is eligible for automatic-closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |

**Example**

The scheduler runs for every 24 hours considering starting at 0000 hours AM.

For the chat channel, a conversation is in open state at 1100 hours of Jan 10, 2020. and remains in this state until midnight 2359 hours. Since the conversation is in open state for more than 20 minutes (default configured time), this conversation is eligible for automatic-closure. At 0000 hours of Jan 11, 2020, the scheduler runs and the conversation in the **Open** state is moved to the **Closed** state.

> [!Note]
> A scheduler runs every 24 hours to close all eligible conversations. However, the exact time at which the scheduler runs is dependent on the Omnichannel for Customer Service deployment time in your region. For more information, contact Microsoft support.

### Conversation in waiting

For chat and SMS channel, a conversation in **Waiting** is moved to the **Closed** state when the conversation is inactive for a specified time. The inactive time can be set in the work stream for the **Auto-close after inactivity** option, based on which the conversation will be moved to the closed state after the criteria is met.

For example, when you set **Auto-close after inactivity** to five minutes, the conversation is moved to the **Closed** state if it has been in **Waiting** for more than five minutes.

To learn more, see [Create a work stream](work-streams-introduction.md#create-a-work-stream).

### Set default time using APIs

Programmatically, you can change the default time and set it as per your organization's requirements using the Web APIs. To learn more, see [Automatic closure of a conversation](auto-close-conversation.md).

### See also

[View communication panel](oc-conversation-control.md)  
[Automatic closure of a conversation](auto-close-conversation.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]