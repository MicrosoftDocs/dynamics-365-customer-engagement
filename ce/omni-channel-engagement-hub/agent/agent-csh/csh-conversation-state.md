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
ms.assetid: 6C893ED1-0B3E-4E6C-96DB-796B807E6C6E
ms.custom: 
---

# Understand conversation states in Omni-channel Engagement Hub

The topic explains the various states of the conversation (work item) in Omni-channel Engagement Hub.

Types of conversation states:

 - Open

 - Active
 
 - Waiting
 
 - Wrap

 - Closed

## Open

The conversations (work items) that are in the queue or available for you (agent) to pick are classified under **Open** state. 

- The system changes the state from **Open** to **Active** under the following scenarios:

    - When the you pick the conversation from the **Open work items** stream.

    - When the routing and work distribution feature pushes (assigns) the conversation to you.

    - When the supervisor assigns the conversation to you.

- The system changes the state from **Open** to **Closed** when the customer disconnects or ends the chat before the conversation is assigned to you.

## Active

The conversations that you pick for working are classified under **Active** state.

- The system changes the state from **Active** to **Closed** when you complete working on the conversation and end the conversation and close the session.

- The system changes the state from **Active** to **Open** under the following scenarios:

    - When you disconnect the conversation and doesn't reconnect with in a specified timeout period.

    - When you release the conversation to the queue.

    - When you transfer the conversation to another agent or queue.

- The system changes the state from **Active** to **Waiting** under the following scenarios:

    - When you close the session.
    
    - When the customer disconnects the conversation, and you wrap (close) the session (not ending the conversation by selecting the **End** button).

- The system changes the state from **Active** to **Wrap** state under the following scenarios: 

    - When you select the **End** button on **Communication panel** during the conversation with the customer.

    - When customer ends the conversation by selecting the **End** button on the portal chat widget.

## Waiting

The conversations that you close or customer disconnects are classified under **Waiting** state. These conversations are not just closed and not ended by selecting the **End** button either in Communication panel (for agent) and portal chat widget (for customer).

- The system changes the state from **Waiting** to **Closed** under the following scenarios:

    - When you don't reconnect to the conversation with in a specified timeout period.

    - When the customer selects the **End** button to end the conversation and close the session.

- The system changes the state from **Waiting** to **Active** when you revive the session from your **Today's Conversation** stream on **Omni-channel agent dashbaord**. 

- The system changes the state from **Waiting** to **Open** when the customer revives the conversation within a specified timeout period.

## Wrap

The conversations that are ended either by you or the customer are classified under **Wrap** state. This state is a phase where can finish the wrap-up activities like taking notes and update the customer information before moving the conversation to **Closed** state.

- The system changes the state from **Wrap** to **Closed** under the following scenarios: 

- When you select the **End** button in **Communication panel** to end the conversation.

- When customer selects the **End** button to end the conversation in the portal chat widget.

## Closed

The conversations that are completed by ending, and closing the session are classified under **Closed** state.