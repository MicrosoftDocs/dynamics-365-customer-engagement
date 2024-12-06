---
title: Preconfigured automated message triggers for asynchronous channels
description: Learn about the preconfigured automated message triggers that are displayed to agents and customers in asynchronous channels in Omnichannel for Customer Service.
ms.date: 08/14/2024
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
ms.reviewer: mgandham
---
# Preconfigured automated message triggers for asynchronous channels

## Preconfigured automated message triggers for agents

The following table lists the automated messages that are displayed to agents in asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channels | Message or attachment couldn't be sent. Error details include error code, reason for failure, message ID, timestamp, and transaction ID.| Message displayed to agent when the agent's message or attachment couldn't be sent. | Agent's message or attachment couldn't be sent. |
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channel | Customer's file couldn't be attached because it's too large | Message displayed to the agent when the customer sends an attachment that exceeds the allowed limit. | Customer sends an attachment that exceeds the allowed limit.  |
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channel  | Message couldn't be delivered: Unsupported message type| Message displayed to the agent when the customer sends an unsupported message type. | Customer sends an unsupported message type. |
|Custom channel | Customer disconnected| Message displayed to the agent when the customer gets disconnected. |  Customer gets disconnected. |
|Custom channel|  Customer ended conversation | Message displayed to the agent when the customer ends the conversation. | Customer ends the conversation. |

## Preconfigured automated message triggers for customers

The following table lists the automated messages that are displayed to customers in asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channels | Customer's file couldn't be attached because it's too large |Message displayed to the customer when the customer sends an attachment that exceeds the allowed limit.   | Customer sends an attachment that exceeds the allowed limit.  |
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channels | Message couldn't be delivered: Unsupported message type | Message displayed to the customer when the customer sends an unsupported message type. |  Customer sends an unsupported message type. |
|Apple Messages for Business, Facebook, LINE, WeChat, WhatsApp, and custom channels |Greeting Message for async Channels | Message displayed to the customer when the customer sends a message request to chat. | Customer sends a message request to chat. |
|Custom channel| Customer's position in queue | Message displayed to customer when there's a queue of customers waiting. | Customer submits a request and is placed in the queue to chat with an agent because other customers are already waiting. |
|Custom channel| Customer is next in line |  Message displayed to the customer when no other customer is ahead in the queue. |  The number of customers waiting to chat gets updated each time a customer in line is served. When no other customer is ahead in the queue, the customer waiting is notified with the message. |

## Next steps

[Configure custom messaging channel](configure-custom-channel.md)  

### Related information

[Overview of channels](../use/channels.md)  
[Support for live chat and asynchronous channels](../use/channels.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
