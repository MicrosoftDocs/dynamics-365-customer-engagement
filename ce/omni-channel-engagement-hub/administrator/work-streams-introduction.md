---
title: Understand work streams
description: Understand work streams in the Omni-channel Engagement Hub
keywords: Understand work streams; Omni-channel Engagement Hub
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 01/29/2019
ms.service: 
ms.topic: article
ms.assetid: 0cc05811-6631-4a5c-85b1-c145be7d7a6f
ms.custom: 
---

# Understand work streams in the Omni-channel Engagement Hub

A work stream is a collection of routing & work distribution settings. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue. 

In omni-channel, you can create two types of work streams:

- [Live chat work stream](create-work-streams.md#create-a-new-live-chat-work-stream)
- [CDS Entity work stream](create-work-streams.md#create-a-new-cds-entity-work-stream)

> [!NOTE]
> A work stream can belong to multiple sources of same type, for example multiple live chat widgets. In this case, all the conversations from these widgets inherit routing and work distribution settings of the work stream they belong to.

A work stream comprises of the following properties:

- **Stream source**: Stream source is defined as a medium via which a customer reaches out for support. For example, a customer can chat with an agent through chat. 
   
- **Allowable Presence**: Allowable presence helps in distributing conversations to agents based on their presence status. For example, if you want to allocate a chat conversation from a high priority customer, ensure that you look for only those agents that have their presence status as 'Available'. So, while defining properties for a work stream, select Allowable presence as Available.

    For more information, see [Configure and manage presence status](presence-custom-presence.md).

- **Capacity**: When a conversation from a work stream is assigned to an agent, it consumes some capacity. The units of capacity blocked are defined as capacity in the work stream. For example, a conversation in the live chat work stream has a capacity of 20 units. When this conversation is assigned to an agent, it blocks 20 units of agent's capacity.

- **Work distribution mode**:  Work distribution mode defines the experience of how agents can take up a conversation - via **Push** or **Pick** mode. In **Push** mode, a conversation is dispatched to agents automatically via a screen-pop. In **Pick** mode, a conversation is dispatched to agents when they explicitly pick a conversation from the **Open work items** in agent dashboard.

    For more information, see [View agent dashboard and agent work items](../agent/agent-usd/introduction-agent-dashboard.md).
 

- **Context attributes**: Context attributes enrich conversations with pre-chat data and channel data. For example, for a chat conversation, context attributes include browser information, IP address, answers to pre-chat questions, customer ID (for authenticated chat), time spent on a page and more. These variables can then be used to define routing rules to route conversations into different queues. 
   > [!NOTE]
   > For this preview, context variables are applicable only for live chat.

- **Record Identification Rules**: Record identification rules help agents identify and assist customers better by showing their details on the **Customer summary** page. 

    For more information, see [Understand record identification rule](record-identification-rule.md).

    > [!NOTE]
    > In this preview, the record identification rules are pre-configured in the work streams out-of-the-box.

- **Routing rules**: Routing rules are configured for each work stream, so that conversations can be routed to the correct queues. For more information, see [Create and manage routing rules in omni-channel](routing-rules.md). 


### See also

[Create and manage work streams](create-work-streams.md)