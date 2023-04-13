---
title: FactConversationMessageBlock
description: Learn about FactConversationMessageBlock metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/13/2023
ms.custom: bap-template
---

# Message Level Analytics

## Average first response time
First response time is calculated as the time take for a customer to get a first response from human agents, adjusted for operating hours. It is calculated as time different between the time a conversation was initiated by the customer (or escalation time in case of a bot escalated conversation) and the time a agent who has accepted the conversation responds to the customer.

Average first response time is calculated as sum of first response time across all engaged conversations divided by count of engaged conversations. Can be viewed in two formats - seconds and in hh:mm:ss".
 
## Average agent response time 	
Agent response time is calculated as the time taken for a customer to get a response from  human agents for their message, adjusted for operating hours. Average agent response is calculated by taking the sum of all response times and dividing by the number of exchanges between customers and agents across all engaged conversations.  Can be viewed in two formats - seconds and in hh:mm:ss".

## First response service level (60 seconds)
Percentage of customers conversations with an agent response in less than 60 seconds of customer initiation (or escalation in case of bot escalated conversations).

## Agent response service level (60 seconds)
Percentage of customer message that received an agent response in less than 60 seconds.

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)
