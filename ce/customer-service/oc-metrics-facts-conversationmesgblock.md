---
title: Message level analytics
description: Learn about FactConversationMessageBlock metrics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/17/2023
ms.custom: bap-template
---

# Message level analytics

## Average first response time

First response time is calculated as the time spent by a customer waiting to get the first response from a human agent, adjusted according to operating hours. The calculation is based on the time between a customer initiating a conversation (or escalation time in case of a bot escalated conversation) and the agent accepting and responding to a customer.

Average first response time is calculated as the total of the first response time across all engaged conversations, divided by the count of engaged conversations. The time can be viewed in seconds and in hh:mm:ss format.

## Average agent response time

Agent response time is calculated as the time taken by a customer waiting to get a response from the human agent for their message, adjusted according to operating hours. Average agent response is calculated as the total response time, divided by the number of exchanges between customers and agents across all engaged conversations. The time can be viewed in seconds and in hh:mm:ss format.

## First response service level

Percentage of customer conversations with an agent response time of less than 60 sec (or escalation in case of bot escalated conversations).

## Agent response service level

Percentage of customer messages with an agent response time of less than 60 sec.

## See Also

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display)
