---
title: Dimensions
description: Learn about the out-of-box Omnichannel historical and real-time analytics metrics dimensions tables.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.date: 04/17/2023
ms.custom: bap-template
---

# Dimensions

Learn and understand how you can use the dimensions of the out-of-box Omnichannel historical and real-time analytics metrics to suit your needs. For more information, go to: [Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model).

For more information about how you can customize the visual display of your reports using these metrics, go to [Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service).

## Capacity profile name

Name of the capacity profile.

## Has blocking assignment turned on

Indicates whether the capacity profile has the assignment blocking toggle set to on. If the profile's blocking settings are turned on, the value will be TRUE. If the blocking settings are turned off, the value will be FALSE.

## Conversation direction

This applies only to voice conversations and indicates whether the conversation was started by the customer or a contact center agent.

If the conversation was initiated by an agent in the contact center, it is considered as outbound. If the conversation was received by the contact center, it is considered as inbound.

## Conversation status

Represents the current state of a customer interaction. The following is a list of the status values and their meaning:

- Open: Conversation is currently awaiting an agent assignment.
- Active: Conversation has either an agent assigned and is pending acceptance, or has an agent in contact with the customer.
- Waiting: Conversation is currently waiting for either a customer response or an agent response. Applies for asynchronous conversation modes, such as messages.
- Wrap-up: Agent is currently performing post customer interaction activities such as notes, updates to case, after the end of a customer conversation.
- Closed: Conversation is currently closed.

## Queue Id

Reference Id of the queue.

## Queue name

Name of the queue.

## Agent presence

This metric represents the statuses available for agents. The out-of-box options include Online, Away, Busy, Offline, Do Not Disturb. The status options available to you will depend on your organization's configuration and will include any additional custom presence statuses configured for your organization.

## Date hour

Represents hour of the day in a 24 hour format.

## Time range

The following time-based filter options are available on real-time dashboards:
  
- Today: Conversations that started since 12 AM of the time zone selected in any state.
- Last 24 hours: Conversations that started within the last 24 hours in any state.
- Include open conversations beyond 24 hours: Conversations that started within the last 24 hours, in any state and conversations that started earlier than 24 hours but haven't been closed.

## Time zone

Represents the time zone used to calculate and display metrics across the dashboard. Options available are standard timezones.

## Agent Id
		
Reference Id of the Omnichannel agent.

## Agent name

Name of the Omnichannel agent.

## Domain name

Name of the active directory domain.

## Agent participation mode

The following are the agent participation modes:

- Primary: Agent participation mode is primary.
- Consult: Agent participation mode is consult.
- Monitor: Supervisor participation mode is monitor. Applies only to users with Omnichannel supervisor role.

## Workstream Id

Reference Id of the workstream.

## Workstream name

Name of the workstream.

## Channel Id

Reference Id of the channel.

## Channel name

Name of the channel.

## See Also

[Omnichannel for Customer Service dashboards](omnichannel-analytics-insights.md#omnichannel-for-customer-service-dashboards)

[Overview of Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards)
