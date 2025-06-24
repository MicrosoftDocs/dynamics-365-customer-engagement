---
title: View and understand the Overflow report in Omnichannel real-time analytics
description: Monitor overflow conditions, direct callbacks, and agent-customer interactions in Omnichannel real-time analytics Overflow report.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 06/24/2025
ms.custom: bap-template
---

# View and understand the Overflow report in Omnichannel real-time analytics

The Overflow report in Omnichannel real-time analytics helps supervisors and call center managers gain visibility into conversations that trigger overflow conditions, such as callbacks and voicemails. By using this report, you can track key metrics related to overflow actions, understand customer and agent interactions during overflow scenarios, and customize data models to generate detailed, actionable insights. 

Enable detailed reporting on direct callback actions for high-volume call centers by adding specific attributes to the data model. These attributes track direct callback offers, customer opt-ins, callback initiations, and successful connections. They support both real-time and historical reports, so call centers can monitor and analyze callback performance over time. This topic explains how to view and interpret the Overflow report, describes the available metrics, and provides guidance on customizing reports to meet your organization’s needs.

## Direct callback and general overflow actions

The new metrics supported via improved data model for overflow actions reporting help in the following ways: 

- List conversations with overflow action of any type. 

- Identify the overflow condition that's triggered, before work items are queued, when work items are queued, or out of operation hours. 

- Identify whether the customer accepted the direct callback option and the time it was accepted. 

- Identify when callback was initiated by the system. 

- Identify if the callback notification was accepted by a service representative. 
 

## Data model customization 

Use the extensibility feature to create a new report that leverages the out-of-the-box data model. You can also extend this report and add new metrics based on the available data within the Dynamics 365 Customer Service dataset. Learn more in [Customize data models of historical and real-time analytics reports](../administer/model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports) and [Use the out-of-the-box data model in your custom reports](use-datamodel.md#use-the-out-of-the-box-data-model-in-your-custom-reports).

## Metrics

| Callback measures | Definitions|
| --------------- | --------------- |
| Assign to queue anyway    |  Conversations where overflow action triggered is assign to queue anyway.   |
|Callback not offered   | Conversation where direct callback hasn't been offered to customer because the overflow condition wasn't met.  |
| Callback offered   | Conversations where callback is offered. |
| Callback opted in    | Conversation where direct callback was offered and customer accepted or opted-in. |
| Direct callback  | Conversation where overflow action was direct callback.   |
| End call   |  Conversation where overflow action was end call. |
| Inqueue  |  Conversations where overflow condition was met when work item is queued.   |
| Out of operating hours| Conversation where overflow conditions met is out of operating hours. |
| Prequeue |  Conversation where overflow condition was met before workitem is queued.   |
|​ Send to voicemail​ | Conversation where overflow action was voicemail.  |
|Transfer to a different queue | Conversation where overflow action was transferred to a different queue.  |
|Transfer to an external number |  Conversation where overflow action was transferred to an external number.  |

## Related information 

Learn more about [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

Learn more about [Data model mapping for real-time analytics reports in Omnichannel for Customer Service](datamapping-realtime.md#data-model-mapping-for-real-time-analytics-reports-in-omnichannel-for-customer-service).

Learn more about [Calculate conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics).
 