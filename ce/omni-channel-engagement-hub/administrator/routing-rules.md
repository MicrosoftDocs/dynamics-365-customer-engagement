---
title: "Create and manage routing rules in omni-channel"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: ae408147-bb2c-4016-8ae7-cf06eb12ceb0
ms.custom: 
---
# Create and manage routing rules in omni-channel

Routing rules in Omni-channel Engagement Hub unify conversations from multiple work streams and distribute them to the correct agents, so that customers get help quickly. Routing rules are an entry point into the routing and work distribution ecosystem. When routing rules are invoked, they evaluate the destination of an incoming conversation and route it to the correct queue.

Routing rules are configured for each work stream. A single work stream can have multiple routing rules.

![Routing rules](../media/oc-routing-rules.png)

Routing rules help collect conversations, based on the condition that is applied, and then route them to the correct destination.

> [!NOTE]
> The destination for the conversation can be a queue or an agent. However, in private preview, only queues are supported as destinations.

![Rule destination](../media/oc-rule-destination.png)

Routing rules evaluate conversations based on the context channel, customer attributes, and agent attributes. For example, you can define a routing rule so that chats from preferred customers who have specific queries about investments can be routed to a specific queue. The following illustration shows the rule configuration for this example.

![Configured rule](../media/configured-rule.png)

Routing rule items are run in a specific order, and the conversations are routed according to the destination. Collectively, the conditions form a criterion for a rule item. Therefore, for a conversation, if the criterion in a rule item is evaluated as true, the conversation is routed to the designated destination. Otherwise, the criterion in the next rule item is evaluated. If the criteria in all the rule items are evaluated as false, the conversation goes to a default queue.
