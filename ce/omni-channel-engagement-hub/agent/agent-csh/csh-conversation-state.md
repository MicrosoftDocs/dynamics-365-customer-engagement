---
title: "Understand conversation states in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn what the conversation states are in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 04/26/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6C893ED1-0B3E-4E6C-96DB-796B807E6C6E
ms.custom: 
---

# Understand conversation states in Omni-channel Engagement Hub

This topic explains the various states of the conversation (work item) in Omni-channel Engagement Hub.

Types of conversation states:

 - Open

 - Active
 
 - Waiting
 
 - Wrap-up

 - Closed

## Open

The conversations (work items) that are in the queue or available for you (the agent) to pick are classified under the **Open** state. 

- The conversation (work item) transitions from the **Open** to **Active** state under the following scenarios:

    - When you pick the conversation from the **Open work items** stream.

    - When the routing and work distribution feature pushes (assigns) the conversation to you.

    - When the supervisor assigns the conversation to you.

- The conversation (work item) transitions from the **Open** to **Closed** state when the customer disconnects or ends the chat before the conversation is assigned to you.

## Active

The conversations that you pick to work on are classified under the **Active** state. In the **Active** state, your capacity is consumed.

- The conversation (work item) transitions from the **Active** to **Closed** state when you complete work on the conversation and end the conversation and close the session. This is applicable only for the Entity Routing conversations (work items) and not for any other channel conversations (work items).

- The conversation (work item) transitions from the **Active** to **Open** state under the following scenarios:

    - When you disconnect the conversation and don't reconnect within a specified timeout period.

    - When you release the conversation to the queue.

    - When you transfer the conversation to another agent or queue.

- The conversation (work item) transitions from the **Active** to **Waiting** state under the following scenarios:

    - When you close the session (not ending the conversation by selecting the **End** button).
    
    - When the customer disconnects the conversation, and you wrap up (close) the session (not ending the conversation by selecting the **End** button).

- The conversation (work item) transitions from the **Active** to **Wrap-up** state under the following scenarios: 

    - When you select the **End** button on the **Communication panel** during the conversation with the customer.

    - When the customer ends the conversation by selecting the **End** button on the portal chat widget.

## Waiting

The conversations that you close or the customer disconnects are classified under the **Waiting** state. These conversations are not just closed and not ended by selecting the **End** button either in the Communication panel (for the agent) and portal chat widget (for the customer).

- The conversation (work item) transitions from the **Waiting** to **Closed** state under the following scenarios:

    - When you don't reconnect to the conversation within a specified timeout period.

    - When the customer selects the **End** button to end the conversation and close the session.

- The conversation (work item) transitions from the **Waiting** to **Active** state when you revive the session from your **My work items** stream on **My Dashboard**. 

- The conversation (work item) transitions from the **Waiting** to **Open** state when the customer revives the conversation within a specified timeout period.

## Wrap-up

The conversations that are ended either by you or the customer are classified under the **Wrap-up** state. This state is a phase where you can finish the wrap-up activities like taking notes and updating the customer information before moving the conversation to the **Closed** state.

- The conversation (work item) transitions from the **Wrap-up** to **Closed** state when you select the **End** button in **Communication panel** and close the session. 

## Closed

The conversations that are completed by ending and closing the session are classified under the **Closed** state. When you close a conversation, you cannot reactivate or reopen the conversation again.

> [!div class="nextstepaction"]
> [View communication panel](csh-conversation-control.md)

## See also

[Understand conversation state lifecycle](../../administrator/conversation-state-lifecycle.md)
