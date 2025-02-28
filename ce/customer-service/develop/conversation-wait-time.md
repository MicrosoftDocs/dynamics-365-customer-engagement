---
title: Conversation wait time
description: Learn how conversation wait time is calculated.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 02/19/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
---

# Conversation wait time

_**Applies to**: Omnichannel Historical Bot dashboard, Omnichannel Historical Conversation dashboard_

This metric is a measure of the time, in seconds, before a  service representative responds to a customer's request. In other words, it represents the amount of time that the customer spends waiting for the first response from a service representative. Service representative availability, a high volume of requests, and increased handle time are some factors that can affect customer wait time. A shorter wait time indicates that customers get faster issue resolution and have a better support experience.

If an AI agent or interactive voice response (IVR) handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the AI agent or IVR escalates the conversation to a service representative and the point when the customer disconnects the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the customer creates the request and the point when the customer disconnects the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

# Query

This section describes the query that is used to calculate the total bot conversations in Power BI and Dataverse.


```dax

Avg. wait time (sec)_FactConversation = CALCULATE(AVERAGE(FactConversation[WaitTime]), FactConversation[StatusId] ="4")


```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where 
msdyn_ocliveworkitem.msdyn_isoutbound != 1 and
msdyn_ocliveworkitem.msdyn_channel != '192350000' and
msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL
Case when ClosedOnDateTime is null then null else Timestampdiff( Second,msdyn_ocsession.msdyn_sessioncreatedon, Coalesce(msdyn_ocsession.msdyn_agentacceptedon,
msdyn_ocsession.msdyn_sessionclosedon which is !=null)

```
Filters to be applied before you run the query:

- `msdyn_ocliveworkitem.msdyn_isoutbound != 1` (ignores all outbound conversations as those will not have wait time)
- `msdyn_ocliveworkitem.msdyn_channel != '192350000'` (Entity records are not considered for wait time both in numerator and in denominator)
- `msdyn_ocliveworkitem.msdyn_channelinstanceid` is NULL (used specifically for Customer service)



 | Attribute                     | Definition                                                                                                                                                                                                 |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ConversationId                | The unique identifier of the conversation.                                                                                                                                                                 |
|msdyn_eventreason| Reason for session event. Learn more in [msdyn_eventreason](/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventreason) |
|msdyn_eventtype|Type of session event e.g. accept, reject etc. Learn more in [msdyn_eventtype](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventtype)|
|msdyn_channel|The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channel)|
|msdyn_channelinstanceid|	Unique identifier to identify the app to which this conversation belogs to. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channelinstanceid)|


## Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of served customers.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

For information about metrics that are related to the time that customers wait in individual queues if they're transferred from one service representative to another, see [Session wait time](session-metrics.md#session-wait-time).