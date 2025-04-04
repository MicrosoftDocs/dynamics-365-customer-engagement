---
title: Calculate Conversation metrics
description: Learn to use Power BI and Dataverse for calculating essential conversation metrics and improving service efficiency.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 03/21/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/03/2025
  - ai-gen-title
---


# Calculate Conversation metrics

This article provides detailed guidance on calculating key conversation metrics. By leveraging Power BI and Dataverse, you can gain valuable insights into customer service efficiency and improve overall customer satisfaction.

## Total conversations

The total count of conversations that occurred within the chosen timeframe across all channels (digital and voice), including interactions with both bots and human agents. This encompasses all conversation statuses such as open (unassigned), active (assigned), waiting (awaiting customer's response), wrap-up, and closed conversations across inbound and outbound communications.​

Total conversations = Total bot conversations +  Total direct agent Conversations (inbound and outbound) that can be in any of the conversation states. Learn more in [conversation states](../use/oc-conversation-state.md#understand-conversation-states).

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Total conversations_FactConversation = CALCULATE(COUNTROWS(FactConversation))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes |- msdyn_channel. The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel).   <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid. Unique identifier to identify the app to which this conversation belongs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channelinstanceid). |
|Filters  |Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ Ensure that msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL. |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Total conversations_FactConversation = CALCULATE(COUNTROWS(FactConversation))​

```

|Element|Value  |
|---------|---------|
|Dataverse entities |    msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes  |      - msdyn_channel. The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel).   <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid. Unique identifier to identify the app to which this conversation belongs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channelinstanceid).   |
|Filters  |  Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ Ensure that msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL.​|

---

## Total bot conversations

The total number of conversations that have taken place during the selected period of time with Voice or Interactive Voice Response (IVR), or chat or digital bot, across all statuses (active conversations and closed conversations).

Bot Deflected Conversations + Bot Escalated Conversations = Total Bot Conversations

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax
Bot conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem​, msdyn_ocsession​, and msdyn_ocsessionparticipantevent. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). |
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventreason . <br> - msdyn_ocsessionparticipantevent.msdyn_eventtype ​<br> - msdyn_ocsession.msdyn_sessioncreatedon ​<br> - msdyn_ocsession.msdyn_channel​ <br> - msdyn_ocsession.msdyn_channelinstanceid |
|Filters  |-  Filter the FactSession table to exclude records from msdyn_ocsessionparticipantevent where msdyn_eventreason is '192350001' (in-transit records). Include records from msdyn_ocsessionparticipantevent where msdyn_eventtype is '192350001' (hold events).​ Exclude sessions from msdyn_ocsession where msdyn_sessioncreatedon is empty.​ Exclude sessions from msdyn_ocsession where msdyn_channel is '192350000' (Entity Records channel). Exclude sessions where msdyn_channelinstanceid is NULL (SMS filter)​.

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Total bot conversation = CALCULATE(DISTINCTCOUNTNOBLANK(FactSession[ConversationId]), NOT ISBLANK(FactSession[BotApplicationId]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes |- systemuser.msdyn_BotApplicationId​ <br>- msdyn_liveworkstream.msdyn_streamsource |
|Filters  |Filter the records to include only those where BotApplicationId is not null. msdyn_liveworkstream.msdyn_streamsource is not equal to '192350000'. |

---

### Related metrics

- **Bot deflected conversations**: Total number of conversations where bot was involved and the conversation remained contained within bot without service representative escalation. ​

- **Bot escalated conversations**: Total number of conversations where bot was initially involved and then the issue is escalated to the service representative for support. 

## Average conversation handle time

This metric represents the average duration of a single customer interaction. This metric represents the total handle time divided by the number of conversations handled. Learn more about voice and chat conversations in [Conversation handle time](../use/oc-metrics-dimensions.md#conversation-handle-time).

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation handle time (min)_FactSession = CALCULATE(AVERAGE(FactSession[ConversationActiveTimeInSeconds]) / 60.00 , FILTER(FactSession, FactSession[ConversationStatusId] = "4" && FactSession[ConversationIsAgentAccepted]="1"))

```


|Element|Value  |
|---------|---------|
|Dataverse entities | |
|Attributes |  |
|Filters  | |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Conversation handle time (sec) = SUM(FactConversation[ConversationHandleTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  |
|Attributes |    |
|Filters  | |

---

## Conversation first wait time

This metric is a measure of the time, in seconds, before a  service representative responds to a customer's request. In other words, it represents the amount of time that the customer spends waiting for the first response from a service representative. Service representative availability, a high volume of requests, and increased handle time are some factors that can affect customer wait time. A shorter wait time indicates that customers get faster issue resolution and have a better support experience.

If an AI agent or IVR handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the AI agent or IVR escalates the conversation to a service representative and the point when the customer disconnects the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the customer creates the request and the point when the customer disconnects the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. wait time (sec)_FactConversation = CALCULATE(AVERAGE(FactConversation[WaitTime]), FactConversation[StatusId] ="4")

```


|Element|Value  |
|---------|---------|
|Dataverse entities |- msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). <br> - msdyn_ocsession. Learn more in [msdyn_ocsession](/dynamics365/customer-service/develop/reference/entities/msdyn_ocsession). |
|Attributes |- msdyn_ocsession.msdyn_sessioncreatedon <br> - msdyn_ocsession.msdyn_agentacceptedon <br> - msdyn_ocsession.msdyn_sessionclosedon   |
|Filters  |- msdyn_ocliveworkitem.msdyn_channel != '192350000'. The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel). <br> <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL. Unique identifier to identify the app to which this conversation belogs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channelinstanceid). |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

- Need info

|Element|Value  |
|---------|---------|
|Dataverse entities |  |
|Attributes |    |
|Filters  | |

---

### Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of served customers.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

Learn more about metrics that are related to the time that customers wait in individual queues when they're transferred from one service representative to another, in [Session wait time](../use/session-metrics.md#session-wait-time).

## Incoming conversations

The total number of inbound conversations including both direct to representative and escalation from a voice or digital bot.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Incoming conversations_FactConversation = CALCULATE(DISTINCTCOUNTNOBLANK(FactConversation[ConversationId]), FactConversation[IsAgentInvolved] = "1",FactConversation[IsOutbound] <> "1“

```
|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem  |
|Attributes |  msdyn_ocliveworkitem.msdyn_isoutbound ​

msdyn_ocliveworkitem.msdyn_channel ​

msdyn_ocliveworkitem.msdyn_channelinstanceid ​

msdyn_sessionparticipant.systemuser.msdyn_botapplicationid   |
|Filters  | |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

- Need info

|Element|Value  |
|---------|---------|
|Dataverse entities |  |
|Attributes |    |
|Filters  | |

---

### Related metrics


