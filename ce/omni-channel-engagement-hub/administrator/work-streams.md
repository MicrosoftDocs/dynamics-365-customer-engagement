---
title: "Create work streams"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e
ms.custom: 
---
# Work streams

Work streams define the settings and properties for a specific source or originating point from where the customer requests or queries can come. For example, if the requests are originating from two chat portals, you can create two different work streams for each of them. If work items are created as case records, you can create a separate work stream for the same.

All work streams are associated with unique engagement channels. Engagement channels can be defined for Chats, Email, SMS, Social Messaging, Entities, etc. A work stream cannot be associated with more than one engagement channel.

Work streams have some properties that are common across all engagement channels and some properties that are specific to a few engagement channels. For example, a work stream for chat engagement channel has a property that defines the look and feel of the customer-facing chat widget.

Omni-channel Engagement Hub has default work streams defined, but as an administrator, you can define new work streams to introduce a new source.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image3](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image3.png)  

While setting up work streams, the following properties are defined:

- **Engagement channel**. Engagement channel in Omni-channel Engagement Hub defines the channel that a customer uses to engage with the agents. For example, chat. As an administrator, you can select the engagement channel the work stream is created for.

**Note**: In private preview, we are supporting work streams to be defined on Chat and Entity channels.

- **Capacity**. When a work item from a work stream is assigned to an agent, it consumes some capacity. Those units of capacity are defined as Capacity in the work stream. For example, a work item in the work stream Chat from Portal carries a capacity of 20 units. When this item is assigned to an agent, it consumes 20 units of agent’s capacity.

<!-- -->

- **Agent association**. Agents are associated with a work stream to receive work items only from that work stream. Agent association also helps in simplifying agent-license relationships. For example, which agent has access to which license or capability (live chat license, license to sophisticated analytical tools).

 **Tip**: Bots can be added as members of the work stream. Bots are modelled as virtual users that are enabled for omni-channel system.

- **Work distribution mode and context attributes**. The context attributes can vary for each work stream. For example, for a chat work item, context attributes include browser, IP address, answers to pre-chat questions, customer ID (for authenticated chat). These variables can then be used to define routing rules to channelize work items into different queues.

**Note**: Work stream is the area where context variables can be declared and defined so that the omni-channel system understands the kind of work item it will receive. Work items are pre-loaded with certain context attributes. Based on the context attributes, the system takes logical decisions and distributes the work items to the correct omni-channel queue or agent.

- **Maximum Concurrency.** Using maximum concurrency, you can set the maximum number of work items that can be assigned to an agent’s work list from a work stream.

![MarkdownConversionFile_Omni channel Engagement Hub Guide image4](media/MarkdownConversionFile_Omni-channel-Engagement-Hub-Guide-image4.png)

