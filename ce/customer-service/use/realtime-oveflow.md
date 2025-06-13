---
title: View and understand the Summary report in Omnichannel real-time analytics
description: Concept description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 06/13/2025
ms.custom: bap-template
---


# View and understand the Overflow report in Omnichannel real-time analytics

Enhance the existing analytics data model, to provide insights into calls that meet queue specific overflow conditions and overflow actions. Currently, there’s no analytics available to track direct callback activity, and the out-of-the-box analytics categorize voicemails as abandoned conversations.  

Supervisors lack insight into conversations that go through overflows leading up to voicemail or callbacks. Analytics for voicemails and direct callback actions for overflows will give supervisors insights into these overflow actions via custom reporting and help them plan efficiently. 

You can enable detailed reporting on direct callback actions for high-volume call centers.  You can add specific attributes to the data model to facilitate the creation of detailed reports. These attributes will help track the number of direct callback offers, customer opt-ins, callback initiations, and successful connections. The attributes generate both real-time and historical reports, allowing call centers to monitor and analyze callback performance over different time periods. 

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
| Callback accepted by agent    | Conversation where direct callback was accepted by agent, meaning that the callback request was accepted.   |
| Callback connected to customer   | Conversation where customer was added to direct callback call. This can be a customer answering the call or the call reaching voicemail.   |
| Callback initiated    |  Conversation where direct callback was first in queue and callback was initiated.   |
| Callback not accepted by agent  | Conversation where direct callback notification was not (yet) accepted by an agent.    |
| Callback not connected to customer  | Conversation where customer has not been added to the callback. This can be because call connection is still ongoing or connection was never established.   |
| Callback not initiated  |Conversation where direct callback has not yet been initiated. |
|Callback not offered   | Conversation where direct callback has not been offered to customer because the overflow condition was not met. |
| Callback offered   | Conversations where callback is offered   |
| Callback opted in    | Conversation where direct callback was offered and customer accepted or opted-in. |
| Direct callback  | Conversation where overflow action was direct callback   |
| End call   |  Conversation where overflow action was end call   |
| Inqueue  |  Conversations where overflow condition was met when work item is queued.   |
| Out of operating hours| Conversation where overflow conditions met is out of operating hours. |
| Prequeue |  Conversation where overflow condition was met before workitem is queued.   |
|​ Send to voicemail​ | Conversation where overflow action was voicemail.  |
|Transfer to a different queue | Conversation where overflow action was transfer to a different queue.  |
|Transfer to an external number |  Conversation where overflow action was transfer to an external number.  |

## Related information 

Learn more about [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

Learn more about [Data model mapping for real-time analytics reports in Omnichannel for Customer Service](datamapping-realtime.md#data-model-mapping-for-real-time-analytics-reports-in-omnichannel-for-customer-service).

Learn more about [Calculate conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics).
 