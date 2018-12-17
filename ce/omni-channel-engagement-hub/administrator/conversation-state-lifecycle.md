---
title: "Understand conversation state lifecycle"
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

# Understand conversation state lifecycle

When a conversation is allocated to an agent, the agent works on the conversations and drives them to logical closure. Once the conversation is completed and closed, the agent's capacity becomes available and they can start accepting the next set of conversations that are waiting for their attention. Thus, incoming conversation and its distribution amongst agents operates like a clockwork and efficiencies are utilized.

Conversation state plays a key role in this process as it keeps the system going by updating the state of a conversation at various stages. 

During their complete lifecycle, conversations follow a dedicated path during which they are created, assigned to agents, worked upon by agents (attended), suspended (waiting for inputs), and closed by agents (or sometimes abandoned or auto closed by the system). 

During the whole process, omni-channel system gathers a lot of data about agent efficiency and operational bottle necks that can be fixed by the organization for optimum efficiency. For example, the view of conversations in Waiting state, conversations in Closed state, and conversations in Open State, etc. helps to keep a track of operational health of incoming requests.

You can also view other important metrics and analyze them in the supervisor dashboard, like:
- Average Handling Time
- Average Waiting Time for Customers
- Number of conversations resolved by Agents
