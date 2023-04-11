---
title: Dimensions
description: Learn about the out-of-box Omnichannel historical and real-time analytics metrics dimensions tables.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/11/2023
ms.custom: bap-template
---

# Dimensions

Learn about the facts and dimensions of the metrics and understand how you can use the metrics to suit your needs. More information: [Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model). For more information about how you can customize the visual display of your reports, using these metrics, go to [Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service).

THis article describes the various dimensions that are provided for Omnichannel historical and real-time reports.

## CapacityProfileName
Name of capacity profile.

## Has blocking assignment turned on
Indicates whether the capacity profile has the assignment blocking toggle set to on. If the profile's blocking settings are turned on, the value will be "TRUE". If the blocking settings are turned off, the value will be "FALSE".
## ConversationDirection

This applies only to voice conversations and indicates whether the conversation was started by the customer or a contact center agent. 
If the conversation was initiated by an agent in the contact center, it is considered "outbound". If the conversation was received by the contact center, it is considered "inbound".

## ConversationStatus
Represents current state of a customer interaction. Here is the glossary of values and their meaning 
- Open - Conversation is currently awaiting an agent assignment
- Active - Conversation has either an agent assigned and is pending acceptance or has an agent in contact with the customer 
- Waiting -Conversation is currently either waiting for a customer response or an agent response  Applies for aysnchronous conversation modes like SMS etc.
- Wrap-up - Agent is currently performing post contact activities like notes, updates to case etc. after the contact with customer has ended 
- Closed - Conversation is currently closed

## Queue id
Reference id of the queue.

## Queue name
Name of the queue.

## Agent presence	
Presence status options available for agents to set themselves in. Out-of-box options are Online, Away, Busy, Offline, Do Not Disturb. Options avaiable to you will depend on your organization's configuration and will include any additional custom prescence status configured for your organization.

## Date hour
Represents hour of day in 24 hour format.

## Time range
Time based filter options available in real-time dashboards  
- Today - Conversations that started since 12 AM of the time zone selected and in any state
- Last 24 hours - Conversations that started within the last 24 hours and in any state.
- Include open conversations beyond 24 hours - Conversations that started within the last 24 hours and in any state and Conversations that started earlier than 24 hours but not closed.

## Time zone
Represents the time zone used to calculate and display metrics across the dashboard. Options avaialble are standard timezones. List can be found here.

## Agent id		
Reference id of the omnichannel agent.

## Agent name
Name of the omnichannel agent.

## Domain name
Name of the Active Directory domain.

## Agent participation mode
- Primary - Agent participation mode is primary. 
- Consult - Agent participation mode is consult. 
- Monitor - Supervisor participation mode is monitor. Applies only to users with Omnichannel supervisor role.

## Workstream id
Reference id of the workstream.

## WorkStream name
Name of the workstream.

## Channel id
Reference id of the channel.

## Channel name
Name of the channel.

## See Also

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)

[Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards)
