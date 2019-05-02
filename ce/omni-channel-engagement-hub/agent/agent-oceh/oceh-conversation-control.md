---
title: "Omni-channel Engagement Hub communication panel (Conversation control) | MicrosoftDocs"
description: "Conversation control is a communication panel in Omni-channel Engagement Hub where you interact with the customer."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 6172303E-4BB8-4E54-BC23-71AC2514A248
ms.custom: 
---

# View communication panel

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

The communication panel is where you, as an agent, interact with your customer. When you sign in to the application, by default, the communication panel is in hidden mode. You cannot view the communication panel unless you accept a incoming conversation to communicate with the customer.

For a conversation channel:

- You can send quick replies.
- You can search for and share knowledge articles with the customer with whom you are interacting.
- You can transfer the conversation (work item) to another agent or queue.
- You can use the consult option if you need help to resolve the work item.
- You can switch between internal and public mode to send messages to the internal participants (other agents and/or supervisors).

 > [!div class=mx-imgBorder]
 > ![Omni-channel Engagement Hub communication panel chat interface](../../media/oceh-conversation-control-chat-interface.png "Omni-channel Engagement Hub communication panel chat interface")  
## Enhance agent productivity using keyboard commands

The communication panel has options that, as an agent, you can use to perform certain actions such as see quick replies, consult, and transfer list, launch notes control, and much more.

In addition, as an agent, you can use the keyboard commands in the communication panel to perform the actions that are such as see quick replies, consult, and transfer list, launch notes control, and much more.

The keyboard commands helps allows you completing the scenario effectively and efficiently thus increasing your productivity.

In the communication panel, you can see the following options:
 
| Annotation | Option     | Description                                   | command |
|------|------------------|-----------------------------------------------|----------|
|  1   | Public           | Send messages to public | `/p` |
|  2   | Internal         | Send messages to internal users | `/i` |
|  3   | Customer summary | View customer summary |  |
|  4   | Quick replies    | Send templatized messages  | `/q` |
|  5   | Notes            | Take notes specific to conversation | |
|  6   | Knowledge articles | Search for knowledge articles and share | `/kb` |
|  7   | Link to conversation | Link the record to this conversation | |
|  8   | Consult          | View list to consult with other users | `/c` |
|  9   |  Transfer        | View list to transfer the request | `/t` and `/tq` |

## Send messages using Public and Internal mode

The communication panel allows you to send messages in two ways: **Internal** and **Public**.

When you want to send messages only to the internal participants like other agents and/or supervisors, then use the **Internal** option. The internal messages are not shown to the customers.

When you want to send messages to all the participants in the conversation including the customer, then use the **Public** option.

 > [!div class=mx-imgBorder]
 > ![Reply messages by selecting internal or public mode](../../media/oceh-cc-public-internal-modes.png "Reply messages by selecting internal or public mode")

You can use keyboard commands to send internal and public messages:

- **/i** – Type the forward slash (/) key and the letter **i** to send an internal message to other agents and/or a supervisor. 

- **/p** – Type the forward slash (/) key and the letter **p** to send a public message to all the participants in the interaction.

When you type the keyboard command, the mode changes to as per the command. For example, now, you are on Public mode. Type **/i** to change to **Internal** mode.


## Customer summary

The Customer summary page displays details about a customer with whom you interact. When you are conversing with more than one customer simultaneously, and when you switch from one chat conversation to another, the customer session details are fetched according to the context.

Also, you can manually refresh the Customer summary page to get the details of the customer when switching from one customer session to another. Use the Refresh button to refresh the Customer summary page to get relevant details about the customer based on chat conversations with the customer.

 > [!div class=mx-imgBorder]
 > ![Session overview refresh button in the communication panel](../../media/oceh-cc-options-refresh-session-overview-customer360.png "Session overview refresh button in the communication panel")

## Send templatized messages in the chat

The communication panel allows you to send templatized messages to the customer with whom you're interacting. These templatized messages are stored as quick replies. Select the **Quick replies** button to retrieve the messages and send them to the customers.

 > [!div class=mx-imgBorder] 
 > ![Use quick replies option to send faster replies to customers](../../media/oceh-send-quick-replies-chat.png "Use quick replies option to send faster replies to customers")  

You can use a keyboard command to see the list of quick replies. Type the forward slash (/) key and the letter q (**/q**). When you type **/q** the **Quick replies** fly-out is displayed.

### Search for messages

After you type **/q** in the communication panel messaging area, you can continue typing any keywords and if the **Quick replies** library has at least one message associated with the word, it is filtered and displayed to you.

 > [!div class=mx-imgBorder] 
 > ![Type /q and the keyword to filter the replies](../../media/oceh-send-quick-replies-filter.png "Filter replies")  

## Take notes specific to conversation

Use the notes option to capture information specific to the conversation when you interact with customers. Use the option in the communication panel to launch the notes.

 > [!div class=mx-imgBorder]
 > ![Launch notes panel for taking notes](../../media/oceh-cc-option-notes.png "Launch notes panel for taking notes")

To learn more, see [Take notes specific to conversation](oceh-take-notes.md).

## Search for and share knowledge articles

From the communication panel, you can search for relevant knowledge articles based on the context of the session and share it with the customers through the communication panel. Use the command to launch knowledge articles search.

 > [!div class=mx-imgBorder]
 > ![Use the knowledge articles option in the communication panel to launch the knowledge search page](../../media/oceh-cc-options-knowledge-articles.png "Use the knowledge articles option in the communication panel to launch the knowledge search page")  

**/kb** (forward slash, letter K, and letter B) is the keyboard command to launch the knowledge articles search control. You can search and share the article with the customer through the communication panel. Use the **Send link** button to share the knowledge article link with the customer.

To learn more, see [Search for and share knowledge articles](oceh-search-knowledge-articles.md).

## Link to conversation

When you have a conversation with a customer, you can link the conversation to the record (case or account/contact).

> [!div class=mx-imgBorder]
> ![Use the link to conversation option to launch the link the conversation to a record](../../media/oceh-cc-options-ellipsis-link.png "Use the link to conversation option to launch the link the conversation to a record")

To learn more, see [Search, link, and unlink a record to the conversation](oceh-search-link-unlink-record.md).

## Consult with agent or supervisor

The communication panel allows you to consult with other agents and/or supervisors using the consult option. You can invite the agent or supervisor by selecting the **Consult** button in the communication panel.

 > [!div class=mx-imgBorder]
 > ![Use the consult option to launch the consulting list](../../media/oceh-cc-options-ellipsis-consult.png "Use the consult option to launch the consulting list")  

You can use a keyboard command to see the list of agents and/or the supervisor who are available for consultation. Type the forward slash (/) key and the letter c (**/c**).

> [!Note]
> We recommend inviting a maximum of five consulting agents when conversing with the customer.

### Search for consulting participants

After you type **/c** in the communication panel messaging area, you can continue typing the name of the participant and if it is present, the names are filtered and displayed to you.

## Transfer the conversation

The communication panel allows you to transfer a conversation request. You can transfer the conversation (work item) either to an agent or a queue.

 > [!div class=mx-imgBorder]
 > ![Use the transfer option to launch the transfer list](../../media/oceh-cc-options-ellipsis-tansfer.png "Use the transfer option to launch the transfer list")

You can transfer a request only to agents who are configured in the same work stream and queue. If the request belongs to another queue and you transfer the request, routing rules assign the conversation (work item) to the appropriate agent in the queue.

Use the keyboard command to see the list of agents and/or the supervisor who is available for transfer. Type the forward slash (/) key and the letter t (**/t**).

Use the keyboard command to see the list of queues to transfer the conversation request. Press the forward slash (/) key and the letters T and Q (**/tq**).

**/t** (forward slash, letter t) launches the **Agent** and **Queue** tabs. Select either tab and then select the agent or the queue from the list to transfer the conversation. The **/t** command keeps the focus on the Agent tab whereas the **/tq** command keeps the focus on the Queue tab.

![Transfer agent list](../../media/oceh-cc-transfer-agent-list.png "transfer agent list") ![Transfer queue list](../../media/oceh-cc-transfer-queue-list.png "Transfer queue list")

### Search agents or queues for the transfer of a conversation request

After you type **/t** or **/tq** in the communication panel messaging area, you can continue typing the name of the participant and if it is present, the agent or queues names are filtered and displayed to you.

![Filter transfer queue list](../../media/oceh-cc-transfer-queue-filter.png "Filter transfer queue list")

> [!div class="nextstepaction"]
> [Next topic: Manage presence status](oceh-set-user-presence-status.md)

## See also

- [Introduction to the agent interface](oceh-introduction-agent-interface-omni-channel-engagement-hub.md)
- [Manage sessions](oceh-manage-sessions.md)
- [Manage applications](oceh-manage-applications.md)
- [View customer summary and know everything about customers](oceh-customer-360-overview-of-the-existing-challenges.md)
- [Search for and share knowledge articles](oceh-search-knowledge-articles.md)
- [Take notes specific to conversation](oceh-take-notes.md)
- [View customer summary for an incoming conversation request](oceh-view-customer-360-incoming-conversation-request.md)
