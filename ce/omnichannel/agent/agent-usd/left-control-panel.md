---
title: "Communication panel (conversation control) | MicrosoftDocs"
description: "The left control panel is a communication panel or conversation control. The communication panel hosts the messages that you exchange with the customers. The communication panel provides various options like quick replies, consult, transfer, internal and public message modes."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: b3ae342f-fabd-424e-8086-8f51500575bf
ms.custom: 
---
# View communication panel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

The communication or conversation panel shows the exchange of messages between you and the customer. The communication panel can hosts different channels.

For a conversation channel:

- You can send quick replies.
- You can search for and share knowledge articles with the customer with whom you are interacting.
- You can transfer the conversation (work item) to another agent or queue.
- You can use the consult option if you need help to resolve the work item.
- You can switch between internal and public mode to send messages to the internal participants (other agents and/or supervisors).

## Enhance agent productivity using keyboard commands

The communication panel has options that, as an agent, you can use to perform certain actions such as see quick replies, consult, and transfer list, launch notes control, and much more.

In addition, as an agent, you can use the keyboard commands in the communication panel to perform the actions that are such as see quick replies, consult, and transfer list, launch notes control, and much more.

The keyboard commands helps allows you completing the scenario effectively and efficiently thus increasing your productivity.

In the communication panel, you can see the following options:

In the conversation channel, you can see the following options:
 
 | Option           | Description                                   |  Command |
 |------------------|-----------------------------------------------|-----------|
 | Public           | Send messages to public | `/p` |
 | Internal         | Send messages to internal users | `/i` |
 | Quick replies    | Send templatized messages  | `/q` |
 | Knowledge articles | Search for knowledge articles and share | `/kb` |
 | Consult          | View list to consult with other users | `/c` |
 | Transfer         | View list to transfer the request | `/t` and `/tq` |

> [!div class=mx-imgBorder]
> ![omnichannel chat panel](../../media/oc-usd-chat-control-left-panel.png "Omnichannel chat panel")   

## Internal and public messages

The communication panel allows you to send messages in two ways - **Internal** and **Public**. 

When you want to send messages only to the internal participants like other agents and/or supervisors, then use the **Internal** option. The internal messages are not shown to the customers.

> [!div class=mx-imgBorder]
> ![Send messages to Send messages to internal participants](../../media/oc-usd-cc-internal-message.png "Send messages to internal participants")

When you want to send messages to all the participants in the conversation including the customer, then use the **Public** option.

> [!div class=mx-imgBorder]
> ![Send messages to public](../../media/oc-usd-cc-public-message.png "Send messages to public")

You can use keyboard commands to send internal and public messages:

- **/i** – Press the Slash (/) key and the letter i to send an internal message to other agents and/or a supervisor.

- **/p** – Press the Slash (/) key and the letter p to send a public message to all the participants in the interaction.

When you type the keyboard command, the mode changes to as per the command. For example, now, you are on Public mode. Type **/i** to change to **Internal** mode.

## Send quick replies in the chat

The communication panel provides you with the capability to send templatized messages to the customer with whom you're interacting. These templatized messages are stored as quick replies. Select the **Quick replies** button to retrieve the messages and send it to the customers.

> [!div class=mx-imgBorder]
>![Omnichannel quick response](../../media/oc-usd-cc-quick-replies.png "Omnichannel quick response")

You can use a keyboard command to see the list of quick replies. Type the forward slash (/) key and the letter q (**/q**). When you type **/q** the Quick replies fly-out is displayed.

### Search for messages

After you type **/q** in the communication panel messaging area, you can continue typing any keywords and if the **Quick replies** library has at least one message associated with the word, it is filtered and displayed to you.

 > [!div class=mx-imgBorder] 
 > ![Type /q and the keyword to filter the replies](../../media/oc-usd-send-quick-replies-filter.png "Filter replies") 

## Search for and share knowledge articles

From the communication panel, you can launch the knowledge article search control using the knowledge article option. After launching the knowledge article search control, you can search for relevant knowledge articles, based on the context of the session, and then share the articles with the customers.

You can use a keyboard command to launch the knowledge article search control in the right panel. Press the Slash (/) key and the letters K and B (**/kb**). You can search for and share articles with customers through the communication panel. Select the **Send link** button to share the link of a knowledge article with the customer. More information: [Search for knowledge articles](right-control-panel.md#search-for-knowledge-articles)

## Consult with agent or supervisor

The communication panel lets you to consult with other agents and/or supervisor using the consult option. You can invite the agent or supervisor by selecting the **Consult** button in the communication panel.

> [!div class=mx-imgBorder]
>![Omnichannel consult](../../media/oc-usd-cc-consult.png "Omnichannel consult")  

You can use a keyboard command to see the list of agents and/or the supervisor who is available for consultation. Press the Slash (/) key and the letter c (**/c**).

> [!Note]
> We recommend inviting a maximum of five consulting agents when conversing with the customer.

### Search for consulting participants

After you type **/c** in the communication panel messaging area, you can continue typing the name of the participant and if it is present, the names are filtered and displayed to you.

## Transfer the conversation

The communication panel allows you to transfer a conversation request. You can transfer the conversation (work item) either to an agent or a queue.

> [!div class=mx-imgBorder]
>![Omnichannel transfer](../../media/oc-usd-cc-transfer.png "Omnichannel transfer")

You can transfer a request only to agents who are configured in the same work stream and queue. If the request belongs to another queue and when you transfer the request, routing rules assign the conversation (work item) to the appropriate agent in the queue.

Use a keyboard command to see the list of agents and/or the supervisor who is available for transfer. Press the Slash (/) key and the letters t (**/t**).

Use a keyboard command to see the list of queues to transfer the conversation request. Press the Slash (/) key and the letters T and Q (**/tq**).

When skill-based routing is enabled, then during transfer, the **Transfer** flyout shows users sorted in order of matching skills.

### Search for agents or queues

After you type **/t** or **/tq** in the communication panel messaging area, you can continue typing the name of the participant and if it is present, the agent or queues names are filtered and displayed to you.

![Filter transfer queue list](../../media/oc-usd-cc-transfer-queue-filter.png "Filter transfer queue list")

> [!div class="nextstepaction"]
> [Next topic: View call scripts, take notes, and search knowledge articles](right-control-panel.md)

## See also

- [Introduction to the agent interface in Omnichannel for Customer Service](introduction-agent-interface.md)
- [View customer summary and know everything about customers](customer-summary.md)
- [View customer summary for an incoming conversation request](view-customer-summary-incoming-conversation-request.md)
- [Create a record](create-record.md)
- [Search for records](search-record.md)
- [Link and unlink a record](link-unlink-record.md)
