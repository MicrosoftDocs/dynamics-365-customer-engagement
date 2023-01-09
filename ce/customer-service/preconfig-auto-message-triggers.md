---
title: Preconfigured automated message triggers
description: Get a list of preconfigured automated message triggers available in Omnichannel for Customer Service.
ms.date: 01/10/2023
author: lalexms
ms.author: laalexan
ms.reviewer: nenellim
ms.topic: conceptual
ms.service: dynamics-365
ms.custom: bap-template
---

# Preconfigured automated message triggers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service includes a set of preconfigured, out-of-the-box automated message triggers. Here's the list.

| **Message trigger** | **Definition** | **When to trigger** |
|-----------------|------------|-----------------|
| Agent assigned to a conversation | Message displayed to the customer when the agent is assigned to the conversation. | When the agent is assigned to the conversation. |
| Agent couldn’t be assigned to conversation   | Message displayed to the customer when agent assignment fails.  | When work distribution fails (for example, no agents are linked to the queue, or the default queue is not found) or when routing is unable to add the agent to the chat due to system (CBB/IC3) failure. |
| Agent disconnected from conversation | Message displayed to the customer when the agent gets disconnected. | When the agent gets disconnected due to browser tab closure, browser closure, offline agent presence, or network issue.  |
| Agent ended conversation | Message displayed to the customer when the agent ends the conversation. | When the agent clicks the End button. |
| Agent joined conversation | Message displayed to the customer when the agent joins a conversation. | When the agent accepts the notification.  |
| Agent joined customer conversation | Message displayed to the customer when the agent joins a customer conversation. | When the agent joins a customer conversation.  |
| Agent left customer conversation | Message displayed to the customer when the agent leaves a customer conversation. | When the agent leaves a customer conversation.  |
| Average wait time for customers: Hours <br> (applies to live chat and voice channels only) | Message displayed to the customer with the average wait time displayed in hours.   |  When customer is waiting in queue. |
| Average wait time for customers: Hours and minutes <br> (applies to live chat and voice channels only) | Message displayed when the customer is waiting in queue with average wait time being displayed in both minutes and hours. | When customer is waiting in queue. |
| Average wait time for customers: Minutes <br> (applies to live chat and voice channels only)  | Message displayed to the customer with the average wait time displayed in minutes.  | When customer is waiting in queue. |
| Consult accepted  | Message displayed to the customer when another agent is consulted successfully.  | When another agent accepts the consult request.  |
| Consult session ended  | Message displayed to the customer when consulted agent ends the session. | When the consulted agent closes the session. |
| Customer is next in line  |   Message displayed when the customer is next in line in the queue.  |  When customer is next in line in the queue. |
| Customer's position in queue |  Message displayed when the customer is waiting in queue at the second position or beyond. | When customer is waiting in queue at the second position or beyond. |
| Holiday message to customer | Message displayed to the customer on holidays. | When the customer initiates a conversation on holidays set up for the Live Chat, channel, or queue.  |
| Out of operating hour message to customer | Message displayed to the customer outside of the business hours.  | When customer initiates a conversation outside of business hours set up for the Live Chat, channel, or queue. |
| Session ended   | Message displayed to the customer when the agent ends the conversation and closes the session. | When the agent ends the conversation and closes the session. |
| Transfer to agent accepted  | Message displayed to the customer when the conversation is transferred successfully. | When another agent accepts the transfer request. |
|Offer customer callback |The callback message is played for the customer when the wait times are longer than expected.| When the customer calls and wait time is long.|
| Customer callback response | When the customer presses 1 on the call menu, a confirmation message is played to indicate the customer choice.| Customer presses 1 on the call menu. The response to offer customer callback message is played.|


## Next steps

[Configure automated messages](configure-automated-message.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
