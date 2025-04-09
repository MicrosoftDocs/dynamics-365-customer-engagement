---
title: Calculate Conversation metrics
description: Learn to use Power BI and Dataverse for calculating essential conversation metrics and improving service efficiency.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 04/04/2025
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

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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

## Direct service representative conversations (Incoming conversations)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).   |
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

- **Outgoing conversations**: The total number of outbound conversations made by representative directly to the user.

## Direct service representative conversations (Outgoing conversations)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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

*Applies to Omnichannel historical dashboards.*

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

*Applies to Omnichannel real-time dashboard.*

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

## Conversation first wait time

*Applies to Omnichannel historical dashboard.*

This metric is a measure of the time, in seconds, before a  service representative responds to a customer's request. In other words, it represents the amount of time that the customer spends waiting for the first response from a service representative. Service representative availability, a high volume of requests, and increased handle time are some factors that can affect customer wait time. A shorter wait time indicates that customers get faster issue resolution and have a better support experience.

If an AI agent or IVR handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the AI agent or IVR escalates the conversation to a service representative and the point when the customer disconnects the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation. If the customer abandons the conversation, the calculation is based on the time between the point when the customer creates the request and the point when the customer disconnects the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### Historical analytics

**DAX query**

```dax

Avg. wait time (sec)_FactConversation = CALCULATE(AVERAGE(FactConversation[WaitTime]), FactConversation[StatusId] ="4")

```


|Element|Value  |
|---------|---------|
|Dataverse entities |- msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). <br> - msdyn_ocsession. Learn more in [msdyn_ocsession](/dynamics365/customer-service/develop/reference/entities/msdyn_ocsession). |
|Attributes |- msdyn_ocsession.msdyn_sessioncreatedon <br> - msdyn_ocsession.msdyn_agentacceptedon <br> - msdyn_ocsession.msdyn_sessionclosedon   |
|Filters  |- msdyn_ocliveworkitem.msdyn_channel != '192350000'. The channel(s) in the conversation. Learn more in [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel). <br> <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL. Unique identifier to identify the app to which this conversation belogs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channelinstanceid). |

### Related metrics

- **Average conversation first wait time**: This metric is calculated by dividing the total wait time for customers who are waiting in the queue by the total number of served customers.
- **Longest wait time**: This metric is a measure of the longest first wait time among incoming conversations that a service representative hasn't yet accepted.
- **Conversations in queue**: This metric is a count of customer requests that are currently awaiting service representative assistance, or conversations where a service representative is assigned but are waiting for the service representative to accept.

Learn more about metrics that are related to the time that customers wait in individual queues when they're transferred from one service representative to another, in [Session wait time](../use/session-metrics.md#session-wait-time).

## Average speed to answer

This metric measures how quickly the customer service team responds to a customer's request. It's calculated by dividing the total time a customer waited in queue (after their issue is escalated from an AI agent to a service representative) by the total number of handled conversations. Average speed to answer reflects the efficiency and availability of the service representatives. A lower average speed to answer indicates that customers can get their issues resolved more quickly and have a better experience with the service.

If an AI agent or IVR handles the customer before it escalates the issue to a service representative, the calculation is based on the time between the point when the AI agent or IVR escalates the incoming conversation to a service representative and the point when the service representative accepts the conversation.

If the customer reaches a service representative queue directly, the calculation is based on the time between the point when the customer creates the request and the point when a service representative accepts the conversation.

This metric is available in two formats: seconds and *hh:mm:ss*.

#### Related metrics

- **Service level (10 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 10 seconds.
- **Service level (20 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 20 seconds.
- **Service level (30 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 30 seconds.
- **Service level (40 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 40 seconds.
- **Service level (60 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 60 seconds.
- **Service level (120 seconds)**: This metric is a measure of the percentage of customer conversations where the speed to answer is less than or equal to 120 seconds.
- **Speed to answer**: This metric is a measure of the time before a customer request is accepted.

For information about metrics that are related to how quickly a service representative accepts a request, go to the [Average speed to answer](#average-speed-to-answer) section.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. speed to answer (sec)_FactConversation = ​

CALCULATE (AVERAGE( FactConversation[SpeedToAnswerTime] ),​

    FactConversation[StatusId] = "4",​

    FactConversation[IsAgentAccepted] = "1")​

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem |
|Attributes | - msdyn_channel ​<br> - msdyn_channelinstanceid ​<br> - statuscode |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL. <br> - msdyn_isagentaccepted is 1 <br> - msdyn_ocliveworkitem.statuscode is set to 4 |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Conversation handle time (sec) = SUM(FactConversation[ConversationHandleTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem|
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br> - msdyn_ocliveworkitem.msdyn_conversationfirstwaittimeinseconds​ <br> - msdyn_isoutbound​|
|Filters  |- Filter the FactConversations table to include only rows where msdyn_isagentsession is equal to 1.​ Ensure that msdyn_channelinstanceid is NULL. <br> - Exclude rows where msdyn_streamsource is'192350000'. <br> - ConversationSpeedToAnswerInSeconds is obtained from msdyn_conversationfirstwaittimeinseconds and msdyn_isagentaccepted is 1.|

---

## Average conversation handle time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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
|Dataverse entities |msdyn_ocliveworkitem |
|Attributes | msdyn_ocliveworkitem.statuscode |
|Filters  |- For Fact Session use following filters:​ <br> - Exclude records from msdyn_ocsessionparticipantevent table where msdyn_eventreason is '192350001' (in-transit records).​ Include records from msdyn_ocsessionparticipantevent table where msdyn_eventtype is '192350001' (hold events).​ Exclude sessions from msdyn_ocsession table where msdyn_sessioncreatedon is empty and msdyn_channel is '192350000' (Entity Records channel).​ Include sessions where msdyn_channelinstanceid is NULL (SMS filter).​ ConversationStatusId is '4'​. ConversationIsAgentAccepted is '1' <br> - For ActiveTimeInSeconds use the following filter: If ActiveTimeInSeconds is empty, set it to '0'. <br> - For IsAgentAccepted in DAX use the following filter: If IsAgentAcceptedSession is empty, set it to '0'. <br> - For IsAgentAcceptedSession in DAX refer to the following DV entities:​
If systemuser.msdyn_botapplicationid is empty or NULL and msdyn_sessionparticipant.msdyn_joinedon is not empty, set IsAgentAcceptedSession to 1.​ Otherwise, set IsAgentAcceptedSession to 0.|


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Conversation handle time (sec) = SUM(FactConversation[ConversationHandleTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem|
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession​ <br> -msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - 
msdyn_liveworkstream.msdyn_streamsource msdyn_ocliveworkitem.msdyn_conversationhandletimeinseconds​    |
|Filters  |Filter the FactConversations table to include only rows where msdyn_isagentsession is equal to 1.​ Ensure that msdyn_channelinstanceid is NULL.​ Exclude rows where msdyn_streamsource is'192350000'. ConversationHandleTimeInSeconds is obtained from msdyn_conversationhandletimeinseconds.|

---

## Average conversation hold time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

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

## Average conversation talk time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

This metric is a measure of the average time, in seconds, that service representatives spent actively conversing with customers on the phone for voice conversations. If multiple service representatives handled the conversation, the conversation talk time is aggregated across all the service representatives. This metric is calculated by dividing the total talk time for all customer requests by the total number of handled conversations.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation talk time (min) = AVERAGE(FactConversation[TalkTime])/60.00

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes |- msdyn_eventstarttime ​<br> - msdyn_eventendtime ​<br> - msdyn_channel <br> - msdyn_channelinstanceid |
|Filters  |Filter the FactConversations table to include only rows where msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL (SMS filter). Talktime is calculated based on the duration between msdyn_eventstarttime and msdyn_eventendtime. ​If HoldTime is NULL, then TalkTime is equal to ActiveTimeInSeconds.​ If HoldTime is not NULL and ActiveTimeInSeconds is not NULL, then TalkTime is equal to ActiveTimeInSeconds minus HoldTime.​ If neither of the above conditions are met, then TalkTime is set to 0.|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax
Avg. conversation talk time (sec) = AVERAGE(FactConversation[ConversationTalkTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). <br> - msdyn_ocliveworkitem, msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. Exclude rows where msdyn_streamsource is'192350000'. ConversationTalkTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_conversationtalktimeinseconds ​|

---
### Related metric

- **Conversation talk time**: This metric is calculated based on the total talk time across all customer requests.

## Average conversation time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

This metric is a measure of the average time, in seconds, that a customer who was seeking help from the contact center spent with a service representative. It includes the time that the customer spent waiting for service representatives to work with them.

### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation time (min) = ​ 
IF (​

    //If filtered by Conversation status and status is not Closed, show blank​

    ISFILTERED (FactConversation[StatusId] ) && SELECTEDVALUE ( FactConversation[StatusId] ) <> "4",BLANK (),CALCULATE (AVERAGE ( FactConversation[_ConversationTime] ),​

FactConversation[IsOffered],FactConversation[StatusId] = "4”))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes |- msdyn_closedon​ <br> - msdyn_createdon​ <br> - msdyn_channel ​<br> - msdyn_channelinstanceid |
|Filters  |Filter the FactConversations table to include only rows where msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.statuscode is set to 4. IsAgentSession is set to true. IsAgentInvolved is used if there is atleast one session with IsAgentSession set to true. ConversationTimeInSeconds is calculated based on the duration between msdyn_closedon and msdyn_createdon. IsAgentAcceptedSession is set as follows:​ 
If systemuser.msdyn_botapplicationid is empty or NULL.  |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation time (sec) = ​AVERAGE (FactConversation[ConversationTimeInSeconds] )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). <br> - msdyn_ocliveworkitem, msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. Exclude rows where msdyn_streamsource is'192350000'. ConversationTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_closedon.​|

---

### Related metric

- **Conversation time**: This metric is calculated as the time between the point when the customer initiated the request and the point when the service representative wrapped up the conversation.

## Average conversation wrap-up time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

This metric is a measure of the average time that a service representative spends completing any necessary tasks after the customer disconnects. These tasks might include documenting the conversation, updating notes, or updating the customer's information. The calculation is based on the time between the beginning of the wrap-up and the point when the service representative closes the conversation. If multiple service representatives handled a conversation, this metric applies only to the time that the last service representative who worked with the customer spent.

This metric can be viewed in two formats: seconds and *hh:mm:ss*. 


### DAX query and Dataverse reference

Refer to the DAX query used in the Power BI semantic model and the corresponding Dataverse entities used to create the semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation wrap-up time (min) = ​

IF (//If filtered by Conversation status and status is not Closed, show blank​

ISFILTERED ( FactConversation[StatusId] )​

&&SELECTEDVALUE(FactConversation[StatusId] ) <> "4",BLANK (), CALCULATE(DIVIDE(IF(SUM (FactConversation[_WrapupTime] ) = BLANK(),0,SUM(FactConversation[_WrapupTime])),COUNTROWS (FactConversation),​

BLANK ()), FactConversation[IsOffered],​

FactConversation[IsAgentAccepted] = "1"))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes |- msdyn_closedon​ <br> - msdyn_createdon​ <br> - msdyn_channel ​<br> - msdyn_channelinstanceid |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channel is not equal to '192350000' and msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.statuscode is not set to 4. IsAgentSession is set to true. IsAgentInvolved is used if there is atleast one session with IsAgentSession set to true. IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL.​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation wrap up time = AVERAGE(FactConversation[ConversationWrapUpTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- msdyn_ocliveworkitem. Learn more in [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem). <br> - msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. Exclude rows where msdyn_streamsource is'192350000'.ConversationWrapUpTimeInSeconds is obtained from msdyn_conversationwrapuptimeinseconds​|

---


