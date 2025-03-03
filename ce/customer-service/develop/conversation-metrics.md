---
title: Calculate Conversation metrics
description: Calculate average customer interaction duration, including talk, hold, and wrap-up times for efficient issue resolution.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 03/03/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/03/2025
  - ai-gen-title
---


# Calculate Conversation metrics

## Average conversation handle time

_**Applies to**: Omnichannel Real-time Voice dashboard, Omnichannel Historical Voice dashboard, Omnichannel Historical Conversation dashboardOmnichannel Historical Conversation topic dashboard_

This metric represents the average duration of a single customer interaction. This includes total time spent on the call or chat, any hold time, and the wrap up time or after-call work required to close the interaction. It helps you understand how efficiently customer inquiries are handled and issue resolution is done.

For information about metrics that are related to the time that individual service representatives spend when multiple service representatives handle conversations, see [Session wait time](../use/session-metrics.md#session-wait-time).

For the Voice report, this metric is a measure of total talk time, total hold time, and total wrap-up time or after-call work, divided by the number of calls handled, where:

- Talk time: The time a service representative spends in actively speaking with the customer.
- Hold time: The time for which a service representative puts the customer on hold during the interaction.
- Wrap-up time or after-call work: The time taken to complete any post-call tasks related to the interaction.
- Total number of calls handled: The total number of customer interactions handled by the service representatives.​

    :::image type="content" source="../media/aht_voice.png" alt-text="Screenshot of how avergae handle time is calculated for voice.":::

For the Chat report, this metric is a measure of the active chat time and active wrap-up time, divided by the number of chats handled, where:

- Active chat time: The time a service representative spends in actively chatting with the customer.
- Active wrap-up time: The time taken to complete any post-chat tasks related to the interaction.
- Total number of chats handled: The total number of customer interactions handled by the service representatives.

    :::image type="content" source="../media/aht_chat.png" alt-text="Screenshot of average handle time for chat":::

### Query

This section describes the query that is used to calculate the average duration of a single customer interaction in Power BI and Dataverse.

### [Historical analytics](#tab/historicalpage)

```dax

Avg. conversation handle time (min)_FactSession = CALCULATE(AVERAGE(FactSession[ConversationActiveTimeInSeconds]) / 60.00 , FILTER(FactSession, FactSession[ConversationStatusId] = "4" && FactSession[ConversationIsAgentAccepted]="1"))

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where:​

msdyn_sessionparticipant.msdyn_joinedon​

msdyn_ocliveworkitem.statuscode = 4​

msdyn_sessionparticipant.msdyn_activetime

```

### [Real-time analytics](#tab/realtimepage)


```dax

Conversation handle time (sec) = SUM(FactConversation[ConversationHandleTimeInSeconds])​

Dax -> Sum of  Conversation Handle time in Seconds from Fact conversation

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where:​

msdyn_ocliveworkitem.msdyn_isagentsession = 1 and​

msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL​

msdyn_liveworkstream.msdyn_streamsource != '192350000'​

msdyn_ocliveworkitem.msdyn_conversationhandletimeinseconds

```
---

| Attribute                     | Definition                                                                                                                                                                                                 |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ConversationId                | The unique identifier of the conversation.                                                                                                                                                                 |
|msdyn_sessionparticipant| Users in a session interacting with the customer. Learn more in [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant) |
|msdyn_ocliveworkitem| Type of session event, for example, accept, reject etc. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|msdyn_liveworkstream.msdyn_streamsource| The channel to which this workstream is attached |

### Related metrics


## Conversation first wait time

_**Applies to**: Omnichannel Historical Bot dashboard, Omnichannel Historical Conversation dashboard_

This metric is a measure of the time, in seconds, before a  service representative responds to a customer's request. Learn more in [Conversation first wait time](../use/oc-metrics-dimensions.md#conversation-first-wait-time).

### Query

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
|msdyn_eventreason| Reason for session event. Learn more in [msdyn_eventreason](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventreason) |
|msdyn_eventtype|Type of session event e.g. accept, reject etc. Learn more in [msdyn_eventtype](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventtype)|
|msdyn_channel|The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channel)|
|msdyn_channelinstanceid|	Unique identifier for entity instances. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_channelinstance#BKMK_msdyn_ChannelInstanceId)|


### Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of served customers.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

Learn more about metrics that are related to the time that customers wait in individual queues when they're transferred from one service representative to another, in [Session wait time](../use/session-metrics.md#session-wait-time).

## Total bot conversations

_**Applies to**: Omnichannel Historical Bot dashboard, Omnichannel Real-time Bot dashboard_

The total number of conversations that have taken place during the selected period of time, across all statuses (active conversations and closed conversations) taking place with Voice/IVR or chat/digital bot. Learn more in [Bot conversations](../use/oc-metrics-dimensions.md#bot-conversations).

### Query

This section describes the query that is used to calculate the total bot conversations in Power BI and Dataverse.

### [Historical analytics](#tab/historicalpage)

```dax

conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))
 
Dax -> Distinct Count of FactSession[ConversationId_FS]

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where ConversationId = msdyn_ocsession.msdyn_liveworkitemid
Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'
Exclude sessions from 'Entity Records' channel and SMS filter

```

### [Real-time analytics](#tab/realtimepage)

Use this query for realtime analytics.

```dax

conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))
 
Dax -> Distinct Count of FactSession[ConversationId_FS]

```

Run this query to retrieve the Bot conversations from your environment. 

```

All Conversations where ConversationId = msdyn_ocsession.msdyn_liveworkitemid
Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'
Exclude sessions from 'Entity Records' channel and SMS filter

```
---

| Attribute                     | Definition                                                                                                                                                                                                 |
|-------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ConversationId                | The unique identifier of the conversation.                                                                                                                                                                 |
|msdyn_eventreason| Reason for session event. Learn more in [msdyn_eventreason](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventreason) |
|msdyn_eventtype|Type of session event e.g. accept, reject etc. Learn more in [msdyn_eventtype](/dynamics365/developer/reference/entities/msdyn_sessionevent#BKMK_msdyn_eventtype)|

### Related metrics

- **Bot deflected conversations**: Total number of conversations where bot was involved and the conversation remained contained within bot without service representative escalation. ​

- **Bot escalated conversations**: Total number of conversations where bot was initially involved and then the issue is escalated to the service representative for support. 