---
title: Understand the analytics data model
description: This article provides an overview of the analytics data model in Dynamics 365, explaining the structure and use of fact and dimension tables to analyze and visualize key performance metrics for customer service operations.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/10/2025
ms.custom: bap-template
---

# Understand the analytics data model

The application provides an out-of-box data model that consists of fact and dimension tables.

- Facts, also known as metrics, represent the observational or event data that you want to analyze. Fact tables logically organize KPIs. For example, the `FactConversation` table has conversation metrics such as average handle time, whereas the `FactAgent` table has service representative metrics.
- Dimensions represent the attributes of the facts. You can use them to break down the data for further analysis.

You can use facts and dimensions to visualize data according to your organizational requirements. For example, if you want to understand how average handle time varies by queue, you can filter the Average handle time fact by the Queue name dimension.

Fact tables are larger than dimension tables because numerous events, such as individual customer requests, occur in them. Dimension tables are typically smaller because you're limited to the number of items that you can filter on and group. For example, the number of queues is a limited set.

## Dimensions

This section describes the different dimensions of the out-of-box omnichannel real-time analytics metrics.

For information about how you can use these metrics to customize the visual display of your reports, go to [Customize visual display](customize-reports.md).

### Skills

Skills assigned to service representatives.

### Proficiency

A service representative's proficiency level for assigned skills.

### Capacity profile name

This dimension represents the name of the capacity profile.

### Conversation direction

This dimension applies only to voice conversations. It indicates whether the customer or a service representative in the contact center initiated the conversation.

If a contact center service representative initiates the conversation (and the customer receives it), the system considers it outbound. If the customer initiates the conversation (and the contact center receives it), the system considers it inbound.

### Conversation status

This dimension represents the current state of a customer interaction. The following status values are available:

- **Open**: The conversation is currently awaiting service representative assignment.
- **Active**: Either the conversation has a service representative assigned and is awaiting acceptance, or a service representative is in contact with the customer.
- **Waiting**: The conversation is currently awaiting either a customer response or a service representative response. This option applies to asynchronous conversation modes, such as messages.
- **Wrap-up**: The service representative is performing post–customer interaction activities such as adding notes or updates to the case after the end of a customer conversation.
- **Closed**: The conversation is currently closed. The following metrics are a measure of the conversations grouped by call closure reason.

    - Ghost Conversation: Conversations that are connected to a service representative but there was no interaction from customer after the conversation was connected. 
    - Ghost Conversations Rate: Percentage of engaged conversations that are connected to a service representative but there was no interaction from the customer. 
    - Conversation disconnect rate: Percentage of conversations that were ended by customer before a service representative ended the conversation.
    - Disconnect reason: Represents the reason behind a customer disconnect. For chats, it represents whether the customer closed the widget, ended the conversation, or there was a system disconnect. For voice, it represents whether the customer ended the call or the call was disconnected due to connection issues.

### Queue name

This dimension represents the name of the queue.

### Service representative presence

This dimension represents the statuses that are available for service representatives. The out-of-box options include *Online*, *Away*, *Busy*, *Offline*, and *Do Not Disturb*. The status options that are available to you depend on your organization's configuration and include any other custom presence statuses configured for your organization.

### Date hour

This dimension represents the hour of the day in a 24-hour format.

### Time range

The following time-based filter options are available on real-time dashboards:

- **Today**: View all conversations that started since 12 AM in the selected time zone, in any state or province.
- **Last 24 hours**: View all conversations that started in the last 24 hours, in any state or province.
- **Include open conversations beyond 24 hours**: View all conversations that started in the last 24 hours, in any state or province. In addition, view all conversations that started in the last three days and are still open.

### Time zone

This dimension represents the time zone that is used to calculate and show metrics across the dashboards. The available options are standard time zones.

### Service representative name

This dimension represents the name of the omnichannel service representative.

### Service representative participation mode

The following service representative participation modes are available:

- **Primary**: Service representative participation mode is *Primary*.
- **Consult**: Service representative participation mode is *Consult*.
- **Monitor**: Supervisor participation mode is *Monitor*. This option applies only to users who have the Omnichannel supervisor role.

### Workstream name

This dimension represents the name of the omnichannel workstream where the conversation originated.

### Channel name

This dimension represents the name of the channel.

## Next steps

[Use report metrics](oc-metrics-dimensions.md#use-report-metrics)
