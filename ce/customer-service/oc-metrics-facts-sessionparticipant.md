---
title: Session participant
description: Learn about FactSessionParticipant metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/17/2023
ms.custom: bap-template
---

# Session participant

A session participant entry is created for every agent who is identified to work on a conversation and gets associated with the latest session. A single session can have multiple participants. Every session has one primary participant, that is the agent with the assigned work item. A session can also have none or many additional participants who monitor the conversation or help with the consult. You can get KPIs and metrics around consults provided by agents and monitored conversations from this entity.

## External participant channel

This metric helps identify the channels through which external agents were engaged. For example, an external agent can help customer requests by calling them directly on their phone number or via Microsoft Teams Public Switched Telephone Network (PSTN) call.  

## External participant channel type
 
This metric represents the details of the external agent like phone number.

## Is handled by external participant

A customer request could be handled by more than one agent, including a combination of internal and external agents. For example, external agents could be engaged by your contact center through transfers to an external phone number or through Microsoft Teams voice call. This metric is used to identify the portion of a customer requests that were handled by agents outside Dynamics 365 Customer Service.

## Session participant count

This is a measure of the total number of agents involved in assisting a customer. This includes the primary agent assigned to working on the session, as well as subject-matter experts who may have been consulted. This metric can be analyzed by the dimension SessionParticipationType to get further statistics.

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)
