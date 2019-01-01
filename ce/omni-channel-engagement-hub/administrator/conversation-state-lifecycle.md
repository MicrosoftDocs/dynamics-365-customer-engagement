---
title: "Understand the conversation state lifecycle"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 1a4ef45e-efb3-4a9c-9665-20bb1eed9998
ms.custom: 
---

# Understand the conversation state lifecycle

When a conversation is allocated to an agent, that agent works on the conversation and drives it to logical closure. After the conversation is completed and closed, the agent's capacity becomes available. The agent can then start to accept the next set of conversations that are waiting for attention. Therefore, the distribution of incoming conversations among agents works like clockwork, and efficiencies are utilized.

Conversation state plays an important role in this process by updating the state of a conversation at various stages.

During their complete lifecycle, conversations follow a dedicated path. They are created, assigned to agents, worked on by agents (attended to), suspended (while they are awaiting input), and closed by agents (or sometimes either abandoned or automatically closed by the system).

During the whole process, the omni-channel system gathers lots of data about agent efficiency, and also about operational bottlenecks that the organization can fix to achieve optimum efficiency. For example, the view of conversations in the **Waiting** state, conversations in the **Closed** state, conversations in the **Open** state, and so on, helps organizations track the operational health of incoming requests.

You can also view other important metrics and analyze them on the supervisor dashboard. Here are some examples:

- Average handling time
- Average waiting time for customers
- The number of conversations that have been resolved by agents
