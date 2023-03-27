---
title: Preconfigured automated message triggers for asynchronous channels
description: Learn about the preconfigured automated message triggers that are displayed to agents and customers in asynchronous channels in Omnichannel for Customer Service.
ms.date: 01/12/2023
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
ms.reviewer: nenellim
---
# Preconfigured automated message triggers for asynchronous channels

## Preconfigured automated message triggers for agents

The following table lists the automated messages that are displayed to agents in asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channel | Message or attachment couldn't be sent. Error details include error code, reason for failure, message ID, timestamp, and transaction ID.| Message that's displayed to agent when the agent's message or attachment couldn't be sent | When agent's message or attachment couldn't be sent |
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channel | Customer's file couldn't be attached because it's too large| Message that's displayed to the agent when the customer sends an attachment that exceeds the allowed limit   | When customer sends an attachment that exceeds the allowed limit  |
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channel  | Message couldn't be delivered: Unsupported message type| Message that's displayed to the agent when  the customer sends an unsupported message type| When customer sends an unsupported message type |
|Custom channel | Customer disconnected| Message that's displayed to the agent when the customer gets disconnected|  When the customer gets disconnected |
|Custom channel|  Customer ended conversation| Message that's displayed to the agent when the customer ends the conversation| When customer ends the conversation|

## Preconfigured automated message triggers for customers

The following table lists the automated messages that are displayed to customers in asynchronous channels.

|**Channel** | **Message triggered** | **Definition** | **Triggering event** |  
|-----------------|----------------|------------|-----------------|
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channels| Customer's file couldn't be attached because it's too large |Message that's displayed to the customer when the customer sends an attachment that exceeds the allowed limit   | When customer sends an attachment that exceeds the allowed limit  |
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channels |Message couldn't be delivered: Unsupported message type | Message that's displayed to the customer when the customer sends an unsupported message type |  When customer sends an unsupported message type |
|Apple Messages for Business, Facebook, Google's Business Messages, LINE, Twitter, WeChat, WhatsApp, and custom channels |Greeting Message for async Channels | Message that's displayed to the customer when the customer sends a message request to chat  | When customer sends a message request to chat |
|Custom channel| Customer's position in queue | Message that's displayed to customer when there's a queue of customers waiting| When customer submits a request and is placed in the queue to chat with an agent because other customers are already waiting. |
|Custom channel| Customer is next in line|  Message that's displayed to the customer when no other customer is ahead in the queue |  The number of customers waiting to chat gets updated each time a customer in line is served. When no other customer is ahead in the queue, the customer waiting is notified with the message. |

## Next steps

[Configure custom messaging channel](configure-custom-channel.md)  

### See also

[Overview of channels](channels.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
