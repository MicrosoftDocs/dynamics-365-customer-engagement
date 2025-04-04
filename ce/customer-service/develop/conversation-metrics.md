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

## Average conversation hold time

This metric is a measure of the average time, in seconds, that the service representatives who handled a conversation had the customer on hold. If multiple service representatives handled the conversation, the hold time across all the service representatives is aggregated. This metric is calculated by dividing the total hold time for all customer requests by the total number of handled conversations.

There are several reasons why a service representative might put a customer on hold. For example, the service representative might have to gather more information or research an issue, perform tasks that don't require interaction (for example, entering data into a system), or work on an offline task. A long hold time can cause customer frustration and might lead to a poor customer experience.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation hold time (min) = AVERAGE(FactConversation[HoldTime])/60.00

```


|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem |
|Attributes | - msdyn_eventstarttime ​<br> - msdyn_eventendtime ​<br> - msdyn_channel ​<br> - msdyn_channelinstanceid ​ |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL (SMS filter). Holdtime is calculated based on the duration between msdyn_eventstarttime and msdyn_eventendtime  |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation hold time (sec) = AVERAGE(FactConversation[ConversationHoldTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem, msdyn_liveworkstream |
|Attributes | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> -isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. Exclude rows where msdyn_streamsource is'192350000'. ConversationHoldTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_conversationholdtimeinseconds.|

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
|Attributes | - msdyn_ocliveworkitem.msdyn_isoutbound <br> - msdyn_ocliveworkitem.msdyn_channel ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid ​<br> - msdyn_sessionparticipant.systemuser.msdyn_botapplicationid   |
|Filters  | Set IsOutbound to the value of msdyn_ocliveworkitem.msdyn_isoutbound.​ Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ Ensure that msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL.​ Determine if an agent is involved by checking if there is at least one session where IsAgentSession is true.​ IsAgentSession is set to true if msdyn_sessionparticipant.systemuser.msdyn_botapplicationid is not null.​|


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax 

Incoming conversations = ​SUMX ( FactConversation, IF ( NOT FactConversation[DirectionCode], 1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem |
|Attributes | - msdyn_liveworkstream.msdyn_streamsource ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound ​<br> - msdyn_ocliveworkitem.msdyn_isagentsession ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid   |
|Filters  | Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ Ensure that msdyn_streamsource is not equal to '192350000' and msdyn_channelinstanceid is NULL.​ Determine if an agent is involved by checking if there is at least one session where IsAgentSession is true.​ IsOutbound is set to the value of msdyn_ocliveworkitem.msdyn_isoutbound.​|

---

### Related metrics

- - **Outgoing conversations**: The total number of outbound conversations made by representative directly to the user.

## Outgoing conversations

The total number of outbound conversations made by representative directly to the user.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### Historical analytics

**DAX query**

```dax

Outgoing conversations = ​CALCULATE (​DISTINCTCOUNTNOBLANK ( FactConversation[ConversationId] ),​ FactConversation [IsOutbound] = "1")​

```
|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem  |
|Attributes | - msdyn_ocliveworkitem.msdyn_channel <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid <br> - msdyn_conversationtopic_conversation.msdyn_conversationid <br> - msdyn_ocliveworkitem.msdyn_isoutbound   |
|Filters  | Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ Ensure that msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL. onversationid is set to the value of msdyn_conversationtopic_conversation.msdyn_conversationid. IsOutbound is set to the value of msdyn_ocliveworkitem.msdyn_isoutbound.|

### Related metrics

- - **Incoming conversations**: The total number of inbound conversations including both direct to representative and escalation from a voice or digital bot.

## Engaged conversations

An engaged conversation describes an interaction in which both the customer and the agent are actively participating and responsive during the exchange. This engagement is measured from the moment the service representative accepts the conversation when it is presented.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### Historical analytics

**DAX query**

```dax

CALCULATE(TRUE(),FactConversation[IsOffered], FactConversation[IsAgentAccepted] = "1")

```
|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem​, msdyn_ocsession​, msdyn_ocsessionparticipantevent |
|Attributes |- systemuser.msdyn_botapplicationid <br> - msdyn_sessionparticipant.msdyn_joinedon <br> - msdyn_ocliveworkitem.msdyn_channel <br> - msdyn_sessionparticipant.systemuser.msdyn_botapplicationid <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid |
|Filters  | Filter the FactConversations table to​ exclude rows where msdyn_channel is equal to '192350000' and msdyn_channelinstanceid is NULL. IsAgentInvolved is used if there is atleast one session with IsAgentSession set to true. 
IsAgentSession is set to true if msdyn_sessionparticipant.systemuser.msdyn_botapplicationid is not null.​ IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL and msdyn_sessionparticipant.msdyn_joinedon is not empty, then IsAgentAcceptedSession is 1.​ Otherwise, its 0.​ |

## Abandoned conversations

A conversation can be abandoned for multiple reasons. For example, a customer might be disconnected or might cancel the call because of a long waiting period, supervisors might forcibly close requests, or automatic system actions might be configured to respond to handle overflow. Abandoned conversations can lead to customer dissatisfaction because of a lack of assistance from the contact center. A high abandonment rate might require further investigation into operational metrics such as service representative availability and queue distribution.

If an AI agent or IVR handles the customer before it escalates the request to a service representative, this metric is calculated as the number of conversations that were abandoned while customers were waiting for a service representative after the AI agent escalated the request. If a conversation is abandoned before an AI agent can be assigned, the system considers the conversation abandoned.

If the customer reaches a service representative queue directly, this metric is calculated as the number of incoming conversations that were abandoned.

The conversation direction is *Incoming*. The channels that the conversation came in through are *Messaging* and *Voice*.

### Realtime analytics

**DAX query**

```dax

Abandoned conversations = ​SUMX(FactConversation, IF (FactConversation[IsAbandoned] && FactConversation[StatusCode] == 4 && FactConversation[DirectionCode],1,0)) 

```
|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem​, msdyn_ocsession​, msdyn_ocsessionparticipantevent |
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid ​<br> - msdyn_liveworkstream.msdyn_streamsource ​<br> - msdyn_ocliveworkitem.msdyn_isabandoned ​<br> - msdyn_ocliveworkitem.statuscode ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound  |
|Filters  |msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. Filter the FactConversations table to include only rows from msdyn_ocliveworkitem where msdyn_channelinstanceid is NULL. Exclude rows where msdyn_liveworkstream.msdyn_streamsource is not equal to '192350000'​. msdyn_ocliveworkitem.msdyn_isabandoned is 1. msdyn_ocliveworkitem.statuscode is 4​. Isoutbound is based on msdyn_ocliveworkitem.msdyn_isoutbound not equal to 1.|

