---
title: Calculate conversation metrics
description: Learn how to calculate conversation metrics in Dynamics 365 Customer Service. Discover key performance indicators to improve contact center or call center interactions.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection:
ms.date: 10/13/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/03/2025
  - ai-gen-title
---


# Calculate conversation metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article explains how to calculate conversation metrics in Dynamics 365 Customer Service. These metrics help you analyze key performance indicators (KPIs), make strategic decisions, track customer service representative (service representative or representative) and AI agent performance, and improve customer satisfaction.

This article also provides detailed guidance about calculating key conversation metrics. By using Power BI reports and Dataverse calculations, you can gain valuable insights into customer service efficiency. [Understand the conversation workflow](../use/overview-analytics-data-model.md#understand-the-conversation-workflow) to effectively utilize these metrics and improve customer service operations and decision-making. 

Learn more about [Session metrics](../use/session-metrics.md#session-metrics) and [Service representative metrics](../use/service-rep-metrics.md#service-representative-metrics).

## Total conversations

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Total conversations include all interactions initiated by customers or representatives and engaged by agents, including ones that might be escalated to service representatives. It's a comprehensive metric that's used to evaluate the performance and effectiveness of agent interactions.

Learn more in [conversation states](../use/oc-conversation-state.md#understand-conversation-states).

### DAX query and Dataverse reference

The following Data Analysis Expression (DAX) query and corresponding Dataverse entities are used in the Power BI semantic model. Learn more in [DAX queries](/dax/dax-queries). 

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Total conversations_FactConversation = CALCULATE(COUNTROWS(FactConversation))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes |- msdyn_channel. The [channels](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel) in the conversation. <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid. Unique identifier to identify the app to which this conversation belongs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channelinstanceid). |
|Filters  |- Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ <br> - Ensure that msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL. |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Total conversations_FactConversation = CALCULATE(COUNTROWS(FactConversation))​

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem).  |
|Attributes  |      - [msdyn_channel](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem?branch=main#BKMK_msdyn_channel). The channels in the conversation. <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid. Unique identifier to identify the app to which this conversation belongs to. Learn more in [msdyn_channelinstanceid](/dynamics365/developer/reference/entities/msdyn_ocliveworkitem#BKMK_msdyn_channelinstanceid).   |
|Filters  | - Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ <br> - Ensure that msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL.​|

---

## Total bot conversations

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Total number of conversations during the selected period involving Voice, IVR, chat, or digital agents, across all statuses (active and closed conversations).

Total Bot Conversations = Bot Deflected Conversations + Bot Escalated Conversations

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax
Bot conversations_FactSession=CALCULATE(DISTINCTCOUNT(FactSession[ConversationId_FS]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession​, and msdyn_ocsessionparticipantevent.|
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventreason . <br> - msdyn_ocsessionparticipantevent.msdyn_eventtype ​<br> - msdyn_ocsession.msdyn_sessioncreatedon ​<br> - msdyn_ocsession.msdyn_channel​ <br> - msdyn_ocsession.msdyn_channelinstanceid |
|Filters  |-  Filter the FactSession table to exclude records from msdyn_ocsessionparticipantevent where msdyn_eventreason is '192350001' (in-transit records). <br> - Include records from msdyn_ocsessionparticipantevent where msdyn_eventtype is '192350001' (hold events).​ <br> - Exclude sessions from msdyn_ocsession where msdyn_sessioncreatedon is empty.​ <br> - Exclude sessions from msdyn_ocsession where msdyn_channel is '192350000' (Entity Records channel). <br> - Exclude sessions where msdyn_channelinstanceid is NULL (SMS filter)​.

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Total bot conversation = CALCULATE(DISTINCTCOUNTNOBLANK(FactSession[ConversationId]), NOT ISBLANK(FactSession[BotApplicationId]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)  |
|Attributes |- systemuser.msdyn_BotApplicationId​ <br>- msdyn_liveworkstream.msdyn_streamsource |
|Filters  |- Filter the records to include only the records where BotApplicationId isn't null. <br> - msdyn_liveworkstream.msdyn_streamsource isn't equal to '192350000.' |

---

### Related metrics

- **Bot deflected conversations**: Total number of bot conversations resolved by the bot without escalating to a service representative. ​

- **Bot escalated conversations**: Total number of bot conversations that were escalated to the service representative.

## Incoming conversations

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of inbound conversations that a service representative received directly or an AI agent escalated.

In the Summary tab of Omnichannel real-time dashboard, incoming conversations are **Total conversations offered**.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Incoming conversations_FactConversation = CALCULATE(DISTINCTCOUNTNOBLANK(FactConversation[ConversationId]), FactConversation[IsAgentInvolved] = "1",FactConversation[IsOutbound] <> "1“

```
|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes | - msdyn_ocliveworkitem.msdyn_isoutbound <br> - msdyn_ocliveworkitem.msdyn_channel ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid ​<br> - systemuser.msdyn_botapplicationid   |
|Filters  | - Set IsOutbound to the value of msdyn_ocliveworkitem.msdyn_isoutbound. <br> -​ Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ <br> - Ensure that msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL.​ <br> - Determine if an agent is involved by checking if there is at least one session where IsAgentSession is true.​ <br> - IsAgentSession is set to true if systemuser.msdyn_botapplicationid isn't null.​|


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax 

Incoming conversations = ​SUMX ( FactConversation, IF ( NOT FactConversation[DirectionCode], 1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes | - msdyn_liveworkstream.msdyn_streamsource ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound ​<br> - msdyn_ocliveworkitem.msdyn_isagentsession ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid   |
|Filters  | - Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ <br> - Ensure that msdyn_streamsource isn't equal to '192350000' and msdyn_channelinstanceid is NULL.​ <br>- Determine if an agent is involved by checking if there is at least one session where IsAgentSession is true.​ <br> - IsOutbound is set to the value of msdyn_ocliveworkitem.msdyn_isoutbound.​|

---

### Related metric

- [Outgoing conversations](#outgoing-conversations): The total outbound conversations a representative initiated with a customer.
- **Direct service representative**: Total number of conversations through any channel (voice or digital) that includes both open, active, and closed conversations for both, inbound and outbound traffic, directly from the representative without involving voice or agent.

## Outgoing conversations

*Applies to Omnichannel historical dashboards.*

The total outbound conversations a representative initiated with a customer.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Outgoing conversations = ​CALCULATE (​DISTINCTCOUNTNOBLANK ( FactConversation[ConversationId] ),​ FactConversation [IsOutbound] = "1")​

```
|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes | - msdyn_ocliveworkitem.msdyn_channel <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid <br> - msdyn_conversationtopic_conversation.msdyn_conversationid <br> - msdyn_ocliveworkitem.msdyn_isoutbound   |
|Filters  | - Filter the FactConversations table to include only rows from msdyn_ocliveworkitem.​ <br> - Ensure that msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL. Conversationid is set to the value of msdyn_conversationtopic_conversation.msdyn_conversationid. <br> - IsOutbound is set to the value of msdyn_ocliveworkitem.msdyn_isoutbound.|

### Related metric

- **Incoming conversations**: The number of incoming conversations directed to service representatives.
- **Direct service representative**: Total number of conversations through any channel (voice or digital) that includes both open, active, and closed conversations for both, inbound and outbound traffic, directly from the representative without involving voice or agent.

## Total handled conversations

*Applies to Omnichannel historical dashboards.*

An engaged conversation is an interaction where both the customer and representative actively participate. Engagement is measured from the moment the representative accepts the conversation.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

IsEngaged = CALCULATE(TRUE(),FactConversation[IsOffered], FactConversation[IsAgentAccepted] = "1")

```
|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)​ <br> - Systemuser​ <br>- msdyn_sessionparticipantevent |
|Attributes |- systemuser.msdyn_botapplicationid <br> - msdyn_sessionparticipant.msdyn_joinedon <br> - msdyn_ocliveworkitem.msdyn_channel<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid |
|Filters  | - Filter the FactConversations table to​ exclude rows where msdyn_channel is equal to '192350000' and msdyn_channelinstanceid is NULL. <br>-  IsAgentInvolved is used if there's atleast one session with IsAgentSession set to true. <br>- IsAgentSession is set to true if systemuser.msdyn_botapplicationid isn't null.​ <br> - IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL and msdyn_sessionparticipant.msdyn_joinedon isn't empty, then IsAgentAcceptedSession is 1.​ Otherwise, it's 0.​ |

## Abandoned conversations

*Applies to Omnichannel real-time dashboards.*

A conversation can be abandoned for multiple reasons. For example, a customer might be disconnected or might cancel the call because of a long waiting period, supervisors might forcibly close requests, or automatic system actions might be configured to handle overflow. Abandoned conversations can lead to customer dissatisfaction. A high abandonment rate requires further investigation into operational metrics such as service representative availability and queue distribution.

If an AI agent or IVR handles the customer before escalating the request to a service representative, this metric counts the number of conversations abandoned while customers wait for a service representative after escalation. If a conversation is abandoned before an AI agent can be assigned, the system considers the conversation abandoned.

If a conversation is assigned to service representative's queue directly, this metric is calculated as the number of incoming conversations that were abandoned. The conversation direction is *Incoming*. The channels that the conversation came in through are *Messaging* and *Voice*.

### DAX query and Dataverse reference

**DAX query**

```dax

Abandoned conversations = ​SUMX(FactConversation, IF (FactConversation[IsAbandoned] && FactConversation[StatusCode] == 4 && FactConversation[DirectionCode],1,0)) 

```
|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)​, msdyn_liveworkstream |
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession ​<br> - msdyn_ocliveworkitem.msdyn_channelinstanceid ​<br> - msdyn_liveworkstream.msdyn_streamsource ​<br> - msdyn_ocliveworkitem.msdyn_isabandoned ​<br> - msdyn_ocliveworkitem.statuscode ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound  |
|Filters  |- msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. <br> - Filter the FactConversations table to include only rows from msdyn_ocliveworkitem where msdyn_channelinstanceid is NULL. <br>-  Exclude rows where msdyn_liveworkstream.msdyn_streamsource isn't equal to '192350000'​. <br> - msdyn_ocliveworkitem.msdyn_isabandoned is 1. <br> - msdyn_ocliveworkitem.statuscode is 4​. <br>- Isoutbound is based on msdyn_ocliveworkitem.msdyn_isoutbound not equal to 1.|

## Conversation first wait time

*Applies to Omnichannel real-time dashboard.*

Conversation first wait time is how long (in seconds) a customer waits for a service representative to accept the conversation after escalation from an AI agent or direct queue entry, or until disconnection, if the user abandons the conversation before the representative accepts the conversation.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Conversation first wait time (sec) =​

SUMX (FactConversation, IF (NOT FactConversation[DirectionCode], FactConversation[ConversationFirstWaitTimeInSeconds],BLANK ()))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes |- msdyn_firstwaitstartedon​ <br> - msdyn_isagentaccepted ​<br> - msdyn_isoutbound|
|Filters  |- msdyn_ocliveworkitem. isagentaccepted is 1. <br> - msdyn_ocliveworkitem.msdyn_isoutbound != 1 |

### Related metrics

- [Average conversation first wait time](#average-conversation-first-wait-time): Average conversation first wait time is the average duration (in seconds) a customer waits for a service representative to accept the conversation after escalation from an agent or direct queue entry, or until disconnection, if abandoned.
- **Longest wait time**: Longest wait time is a measure of the longest first wait time among unaccepted incoming conversations.
- **Conversations in queue**: The number of conversations waiting for a service representative to be assigned or accept the conversation.

You can use [Session wait time](../use/session-metrics.md#session-wait-time) metrics to calculate the time spent by customers waiting in individual queues when they're transferred from one service representative to another.

## Average conversation first wait time

*Applies to Omnichannel historical dashboard.*

Average conversation first wait time is the average duration (in seconds) a customer waits for a service representative to accept the conversation after escalation from an agent or direct queue entry, or until disconnection, if abandoned.

### DAX query and Dataverse reference

**DAX query**

```dax

Avg. conversation first wait time (sec) =​

    AVERAGEX(FactConversation, IF(NOT FactConversation[DirectionCode],  FactConversation[ConversationFirstWaitTimeInSeconds],BLANK() ))

```


|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes |- msdyn_firstwaitstartedon​ <br> - msdyn_isagentaccepted ​<br> - msdyn_isoutbound|
|Filters  |- msdyn_ocliveworkitem.isagentaccepted is 1. <br> - msdyn_ocliveworkitem.msdyn_isoutbound != 1 |


## Average speed to answer

*Applies to Omnichannel real-time and historical dashboards.*

Average speed to answer is the average time (in seconds) for a service representative to accept a conversation after and AI agent escalates it or it enters a direct queue.

#### Related metrics

- **Service level (10 seconds)**: The percentage of customer conversations where the speed to answer is less than or equal to 10 seconds. The calculation is similar for 20, 30, 40, 60, and 120 seconds.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. speed to answer (sec)_FactConversation = 
CALCULATE (
    AVERAGE ( FactConversation[SpeedToAnswerTime] ),
    FactConversation[StatusId] = "4",
    FactConversation[IsAgentAccepted] = "1",
    FactConversation[IsOutbound] <> "1"
    )

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes | - msdyn_channel ​<br> - msdyn_channelinstanceid ​<br> - statuscode |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL. <br> - msdyn_isagentaccepted is 1 <br> - msdyn_ocliveworkitem.statuscode is set to 4 |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. speed to answer time (sec) = ​

AVERAGEX (FactConversation,IF (FactConversation[IsAgentAccepted] && NOT FactConversation[DirectionCode],        FactConversation[ConversationSpeedToAnswerInSeconds],BLANK ()))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br> - msdyn_ocliveworkitem.msdyn_conversationfirstwaittimeinseconds​ <br> - msdyn_isoutbound​|
|Filters  |- Filter the FactConversations table to include only rows where msdyn_isagentsession is equal to 1.​ Ensure that msdyn_channelinstanceid is NULL. <br> - Exclude rows where msdyn_streamsource is'192350000'. <br> - ConversationSpeedToAnswerInSeconds is obtained from msdyn_conversationfirstwaittimeinseconds and msdyn_isagentaccepted is 1.|

---
## Conversation handle time

*Applies to Omnichannel real-time dashboards.*

Conversation handle time is the time that service representatives spend actively helping customers and resolving their issues. The system aggregates the time that multiple service representatives spend when they handle a conversation transferred to them. This metric also includes time that service representatives spend wrapping up the conversation after the customer disconnects, and the time spent in updating notes or contact details. The time that subject matter experts or other service representatives spend consulting on the conversation isn't considered.

For chat and digital messaging, a service representative is actively working on a conversation if it's open in the Copilot Service workspace or Contact Service workspace app. When handling multiple conversations, only the time spent on the open tab is factored in the handle time calculation.

For the **Voice** report, this metric is the sum of total talk time, total hold time, and total active wrap-up time or after-call work, divided by the number of calls handled, where:

:::image type="content" source="../media/aht-voice.png" alt-text="Screenshot of average conversation handle time for voice in Dynamics 365 Customer Service.":::

For the **Chat** report, this metric is the sum of the active chat time and active wrap-up time, divided by the number of chats handled, where:

:::image type="content" source="../media/aht-chat.png" alt-text="Screenshot of average handle time for digital messaging and chat.":::

This metric can be viewed in two formats: seconds and hh:mm:ss.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Conversation handle time (sec) = SUM(FactConversation[ConversationHandleTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_conversationhandletimeinseconds<br> - For **Voice**: msdyn_sessionparticipant.msdyn_talktime +  msdyn_sessionparticipant.msdyn_holdtime  +  msdyn_sessionparticipant.msdyn_activewrapuptime <br> - For **Chat**: msdyn_sessionparticipant.msdyn_activetime + msdyn_sessionparticipant.msdyn_activewrapuptime |
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession​<br>- msdyn_ocliveworkitem.msdyn_channelinstanceid​<br>- msdyn_liveworkstream.msdyn_streamsource<br>- msdyn_ocliveworkitem.msdyn_conversationhandletimeinseconds.  |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_isagentsession is equal to 1.​ <br> - Ensure that msdyn_channelinstanceid is NULL. <br> - Exclude rows where msdyn_streamsource is'192350000'.<br> - ConversationHandleTimeInSeconds is obtained from msdyn_conversationhandletimeinseconds.|

### Related metric:

- [Average conversation handle time](#average-conversation-handle-time)

- [Average session handle time](../use/session-metrics.md#average-session-handle-time)

## Average conversation handle time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The average duration of a single customer interaction. This metric represents the total handle time divided by the number of conversations handled. Learn more about voice and chat conversations in [Conversation handle time](#conversation-handle-time).

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. handle time (min) = CALCULATE(AVERAGE(FactConversation[HandleTime]) / 60.00, FactConversation[StatusId] = "4", FactConversation[IsAgentAccepted]="1")

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_conversationhandletimeinseconds <br> - For **Voice**: msdyn_sessionparticipant.msdyn_talktime +  msdyn_sessionparticipant.msdyn_holdtime  +  msdyn_sessionparticipant.msdyn_activewrapuptime <br> - For **Chat**: msdyn_sessionparticipant.msdyn_activetime     + msdyn_sessionparticipant.msdyn_activewrapuptime  |
|Attributes | - msdyn_ocliveworkitem.statuscode|
|Filters  |- For Fact Session use following filters:​ <br> - Exclude records from msdyn_ocsessionparticipantevent table where msdyn_eventreason is '192350001' (in-transit records).​ Include records from msdyn_ocsessionparticipantevent table where msdyn_eventtype is '192350001' (hold events).​ Exclude sessions from msdyn_ocsession table where msdyn_sessioncreatedon is empty and msdyn_channel is '192350000' (Entity Records channel).​ Include sessions where msdyn_channelinstanceid is NULL (SMS filter).​ ConversationStatusId is '4'​. ConversationIsAgentAccepted is '1' <br> - For ActiveTimeInSeconds use the following filter: If ActiveTimeInSeconds is empty, set it to '0'. <br> - For IsAgentAccepted in DAX use the following filter: If IsAgentAcceptedSession is empty, set it to '0'. <br> - For IsAgentAcceptedSession in DAX refer to the following DV entities:​ If systemuser.msdyn_botapplicationid is empty or NULL and msdyn_sessionparticipant.msdyn_joinedon isn't empty, set IsAgentAcceptedSession to 1.​ Otherwise, set IsAgentAcceptedSession to 0.|


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. handle time (sec) = AVERAGE(FactConversation[ConversationHandleTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes |- msdyn_ocliveworkitem.msdyn_isagentsession​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br>-msdyn_ocliveworkitem.msdyn_conversationhandletimeinseconds​    |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_isagentsession is equal to 1.​ <br> - Ensure that msdyn_channelinstanceid is NULL.​ Exclude rows where msdyn_streamsource is'192350000'. <br> - ConversationHandleTimeInSeconds is obtained from msdyn_conversationhandletimeinseconds.|

---

## Average conversation hold time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The average hold time per conversation in seconds. If multiple service representatives handled the conversation, the hold time across all the service representatives is aggregated. This metric is calculated by dividing the total hold time for all conversations by the total number of handled conversations.

There are several reasons why a service representative might put a customer on hold. For example, the service representative might have to gather more information or research an issue, perform tasks that don't require interaction (for example, entering data into a system), or work on an offline task. A long hold time can cause customer frustration and might lead to a poor customer experience.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation hold time (min) = AVERAGE(FactConversation[HoldTime])/60.00

```


|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes | - msdyn_eventstarttime ​<br> - msdyn_eventendtime ​<br> - msdyn_channel ​<br> - msdyn_channelinstanceid ​ |
|Filters  | Filter the FactConversations table to include only rows where msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL (SMS filter). Holdtime is calculated based on the duration between msdyn_eventstarttime and msdyn_eventendtime  |


### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation hold time (sec) = AVERAGE(FactConversation[ConversationHoldTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_liveworkstream |
|Attributes | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. <br> -  msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. <br> - Exclude rows where msdyn_streamsource is'192350000'. ConversationHoldTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_conversationholdtimeinseconds.|

---

## Average conversation talk time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The average time, in seconds, that service representatives spent actively conversing with customers on the phone for voice conversations. If multiple service representatives handled the conversation, the conversation talk time is aggregated across all the service representatives. This metric is calculated by dividing the total talk time for all customer requests by the total number of handled conversations.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. conversation talk time (min) = AVERAGE(FactConversation[TalkTime])/60.00

```


|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes |- msdyn_eventstarttime ​<br> - msdyn_eventendtime ​<br> - msdyn_channel <br> - msdyn_channelinstanceid |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL (SMS filter). <br> - Talktime is calculated based on the duration between msdyn_eventstarttime and msdyn_eventendtime. ​If HoldTime is NULL, then TalkTime is equal to ActiveTimeInSeconds.​ If HoldTime isn't NULL and ActiveTimeInSeconds isn't NULL, then TalkTime is equal to ActiveTimeInSeconds minus HoldTime.​ If neither of the above conditions are met, then TalkTime is set to 0.|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax
Avg. conversation talk time (sec) = AVERAGE(FactConversation[ConversationTalkTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem),  msdyn_ocliveworkitem, msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. <br> - msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. <br> - Exclude rows where msdyn_streamsource is'192350000'. ConversationTalkTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_conversationtalktimeinseconds ​|

---
### Related metric

- **Conversation talk time**: Conversation talk time is calculated based on the total talk time across all conversations.

## Average conversation time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The average time, in seconds, a customer spends with a service representative, including wait time.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

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
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)  |
|Attributes |- msdyn_closedon​ <br> - msdyn_createdon​ <br> - msdyn_channel ​<br> - msdyn_channelinstanceid |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL. <br> - msdyn_ocliveworkitem.statuscode is set to 4. <br> - IsAgentSession is set to true. IsAgentInvolved is used if there's atleast one session with IsAgentSession set to true. <br> - ConversationTimeInSeconds is calculated based on the duration between msdyn_closedon and msdyn_createdon. <br> - IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL.  |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation time (sec) = ​AVERAGE (FactConversation[ConversationTimeInSeconds] )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem),msdyn_ocliveworkitem, msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. <br> - msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. <br> - Exclude rows where msdyn_streamsource is'192350000'. ConversationTimeInSeconds is obtained from msdyn_ocliveworkitem.msdyn_closedon.​|

---

### Related metric

- **Conversation time**: Conversation time is the duration from when a customer starts a request until a service representative completes the conversation.

## Average conversation wrap-up time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average conversation wrap-up time is a measure of the average time that a service representative spends completing any necessary tasks after the customer disconnects. These tasks might include documenting the conversation, updating notes, or updating the customer's information. This metric measures the time from the start of wrap-up to when the service representative closes the conversation. If multiple representatives handled the conversation, only the last representative's wrap-up time is counted.

This metric can be viewed in two formats: seconds and hh:mm:ss. 


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

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
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes |- msdyn_closedon​ <br> - msdyn_createdon​ <br> - msdyn_channel ​<br> - msdyn_channelinstanceid |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channel isn't equal to '192350000' and msdyn_channelinstanceid is NULL. <br> - msdyn_ocliveworkitem.statuscode isn't set to 4. <br> - IsAgentSession is set to true. IsAgentInvolved is used if there's atleast one session with IsAgentSession set to true. <br> - IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL.​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. conversation wrap up time = AVERAGE(FactConversation[ConversationWrapUpTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem),  msdyn_liveworkstream |
|Attributes  | - msdyn_channelinstanceid​ <br> - msdyn_streamsource ​<br> - isagentsession ​<br> - msdyn_conversationholdtimeinseconds   |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL. <br>- msdyn_ocliveworkitem.msdyn_isagentsession is set to 1. <br> - Exclude rows where msdyn_streamsource is'192350000'.ConversationWrapUpTimeInSeconds is obtained from msdyn_conversationwrapuptimeinseconds​|

---

## Active conversations awaiting service representative acceptance

*Applies to Omnichannel real-time dashboards.*

The number of conversations with service representatives assigned and customers waiting for the service representative to accept and join the conversation. The conversations revert to **Open** state if the service representative rejects the request.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax
Active conversations awaiting agent acceptance =​

SUMX (FactConversation,​

        IF (FactConversation[statuscode] = 2​

&& (FactConversation[StatusChangeReason]== 192350002 || FactConversation[StateReason] == "Agent assigned, awaiting acceptance"),1,0 ))

```

|Element |Value |
|---------|---------|
|Dataverse entities    | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)      |
|Attributes     | - msdyn_ocliveworkitem.msdyn_statuschangereason​ <br> - msdyn_ocliveworkitem.msdyn_statereason​ <br> - msdyn_ocliveworkitem.statuscode |
|Filters     | - msdyn_ocliveworkitem.msdyn_statuschangereason = 192350002 (AwaitingAgentAcceptance) or msdyn_ocliveworkitem.msdyn_statereason = Agent assigned, awaiting acceptance <br> -msdyn_ocliveworkitem.statuscode is set to 2.|

## Active conversations with service representative acceptance

*Applies to Omnichannel real-time dashboards.*

The total number of active service representative conversations. Includes conversations that were assigned to a service representative, accepted, and actively engaged by the representative. Includes all inbound and outbound conversations across all channels (digital, voice, and cases).

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Active conversations with agent acceptance =​

    SUMX (FactConversation,​

        IF (FactConversation[statuscode] = 2&& (FactConversation[StatusChangeReason] == 192350003 ||FactConversation[StateReason] == "In conversation"), 1, 0 ))​

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes  | - msdyn_ocliveworkitem.msdyn_statuschangereason​ <br> - msdyn_ocliveworkitem.msdyn_statereason​ <br> - msdyn_ocliveworkitem.statuscode  |
|Filters  | - msdyn_ocliveworkitem.msdyn_statuschangereason = 192350003 (InConversation) or msdyn_ocliveworkitem.msdyn_statereason = "In conversation"​. <br> - msdyn_ocliveworkitem.statuscode is set to 2​.​|

## Waiting conversations

*Applies to Omnichannel real-time dashboards.*

The number of conversations that are currently in a [Waiting state](../use/oc-conversation-state.md#waiting).

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Waiting conversations =​

    SUMX ( FactConversation, IF ( FactConversation[statuscode] == 3, 1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes  | msdyn_ocliveworkitem.statuscode |
|Filters  | msdyn_ocliveworkitem.statuscode is set to 3.​|

## Wrap-up conversations

*Applies to Omnichannel real-time dashboards.*

Wrap-up conversations is a count of conversations that are currently in the [Wrap-up state](../use/oc-conversation-state.md#wrap-up).

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Wrap-up conversations = SUMX ( FactConversation, IF ( FactConversation[statuscode] == 5, 1, 0 ) ) 

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes  | msdyn_ocliveworkitem.statuscode |
|Filters  | msdyn_ocliveworkitem.statuscode is set to 3.​|

### Related metric

- **Agents in wrap-up conversations**: Number of representatives handling conversations that are in wrap-up state.

## Abandoned rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The abandoned rate refers to the percentage of incoming conversation requests that are terminated before a representative engages with the customer. This rate can happen in both representative and AI agent scenarios. There are two primary types:​
- Abandoned before assignment: The customer leaves before being assigned to a representative.​
- Abandoned after assignment: The customer is assigned to a representative but disconnects before the representative accepts the conversation.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Abandon rate_FactConversation = ​

var abandoned = CALCULATE(FactConversation[Incoming conversations_FactConversation], FactConversation[IsOffered], NOT FactConversation[IsAgentAccepted])​

var source = FactConversation[Incoming conversations_FactConversation]​

var rate = DIVIDE(abandoned, source, 0)​

return​

IF(ISBLANK(rate), 0, rate)​

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), systemuser |
|Attributes | - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel​ <br> - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> -  systemuser.msdyn_botapplicationid  |
|Filters  | - Filter the FactConversations table to include only rows where, msdyn_channelinstanceid is NULL.​ <br>- Exclude rows where msdyn_channel is'192350000, which have atleast one [systemuser.msdyn_botapplicationid  != null ]​ <br> - Direction is defined by msdyn_isoutbound and not to set 1​.​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Conversations abandoned rate = ​

DIVIDE(SUMX(FactConversation,IF(FactConversation[IsAbandoned] && NOT FactConversation[DirectionCode],1,0)),SUMX (FactConversation, IF ( NOT FactConversation[DirectionCode], 1, BLANK () )),BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem),  systemuser |
|Attributes  | - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br> - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocliveworkitem.isagentsession​ <br> - msdyn_ocliveworkitem.msdyn_isabandoned​ <br> -  systemuser.msdyn_botapplicationid    |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL,​ msdyn_isabandoned is set to 1 and​  msdyn_isagentsession set to 1​. <br> - Direction is defined by msdyn_isoutbound and not set to 1​. <br> - Exclude rows where msdyn_streamsource is '192350000'​.​|

---

## Average time to abandon (sec)

*Applies to Omnichannel real-time dashboards.*

Average time to abandon is the average time (in seconds) that customers wait before leaving a conversation when no service representative joins. This average time includes conversations escalated from an AI agent or conversations that enter a direct queue but are abandoned before any AI agent interaction occurs.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Avg. time to abandon (sec) = ​AVERAGEX (FactConversation, IF (FactConversation[IsAbandoned] && FactConversation[StatusCode] == 4 && NOT FactConversation[DirectionCode], DATEDIFF(FactConversation[FirstWaitStartedOn], FactConversation[ClosedOn], SECOND),BLANK ()))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_liveworkstream |
|Attributes  |-  msdyn_ocliveworkitem.msdyn_statuscode​ <br> - msdyn_liveworkstream.msdyn_isabandoned <br> - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocliveworkitem.msdyn_firstwaitstartedon msdyn_ocliveworkitem.msdyn_closedon |
|Filters  | - Filter the FactConversations table to include only rows where statuscode is 4,​ msdyn_isabandoned is set to 1​. <br> - Direction is defined by msdyn_isoutbound and not set to 1​. Avg. time to abandon (sec) is defined by date difference between msdyn_ocliveworkitem.msdyn_firstwaitstartedon and msdyn_ocliveworkitem.msdyn_closedon ​|



## Average active time

*Applies to Omnichannel historical dashboards.*

Active time shows how long an agent actively handles a chat across all session participants. Active time is calculated at each session participant level in a conversation. If a conversation has multiple session participants, each session participant has its own active time. The conversation handle time is the sum of all active time calculated across session participants of the chat conversation.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Avg. conversation active time (min) = CALCULATE(AVERAGE(FactConversation[ActiveTimeInSeconds]) / 60.00, FactConversation[StatusId] = "4", FactConversation[IsAgentAccepted]="1")

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_sessionparticipant |
|Attributes  |-  msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel​ <br> - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_sessionparticipant.msdyn_joinedon |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL.​ <br> - Exclude rows where msdyn_channel is'192350000’ . <br> - Include msdyn_ocliveworkitem.statuscode set to 4​. <br> - ActiveTimeInMinutes is calculated by msdyn_sessionparticipant.msdyn_joinedon set 1​. ​|



## Average conversation inactive time (min)

*Applies to Omnichannel historical dashboards.*

The metric refers to the average amount of time during a conversation when an agent isn't actively engaged with the customer. This metric is especially relevant in chat and digital messaging channels, where agents often handle multiple sessions concurrently.​ Inactive time is the duration when a conversation is open but the agent isn't focused on it—either because they’ve switched to another session or aren't interacting with the customer. 

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Avg. conversation inactive time (min) = CALCULATE(AVERAGE(FactConversation[InActiveTimeInSeconds]) / 60.00, FactConversation[StatusId] = "4", FactConversation[IsAgentAccepted]="1")

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_sessionparticipant |
|Attributes  |-  msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel​ <br> - msdyn_ocliveworkitem.msdyn_statuscode​ <br> - msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant.msdyn_inactivetime|
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL.​ <br> - Exclude rows where msdyn_channel is'192350000’ . <br> -  Include msdyn_ocliveworkitem.statuscode set to 4​. <br> - InactiveTimeInSeconds is calculated by​ msdyn_sessionparticipant.msdyn_inactivetime and​ isAgentAccepted set to 1 or msdyn_sessionparticipant.msdyn_joinedon​. ​|



## Average first response time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average first response time measures how quickly agents acknowledge or begin engaging with customers. It's measured in seconds or minutes and is used to assess the efficiency of initial engagement.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. time for first response (min) = ​CALCULATE (AVERAGE (FactConversation[FirstResponseTime] ) / 60.00,FactConversation[IsOutbound] <> "1")

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes |- msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL.​ <br> - Exclude rows where msdyn_channel is'192350000’​. <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1​.|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Avg. first response time (sec) = AVERAGE(FactConversation[ReponseTimeInSecondsAdjustedForOperationHour])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_liveworkstream |
|Attributes  | - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br> - msdyn_ocliveworkitem.msdyn_firstresponsetime​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel  |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL and​  msdyn_isagentsession set to 1​. Avg. first response time (sec) is defined by msdyn_ocliveworkitem.msdyn_firstresponsetimeinms​. <br> - Exclude rows where msdyn_streamsource is'192350000'​. ​|

---


## Transfer rate

*Applies to Omnichannel historical dashboards.*

Transfer rate refers to the percentage of customer conversations​ that are transferred from one representative to another​, an agent to a live representative, or one department or queue to another​. This metric is expressed as a percentage of total conversations.​

​Transfer Rate (%) = (Number of Transferred Conversations / Total Conversations) × 100​

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Transfer rate_FactConversation = var rate = CALCULATE(FactConversation[_TransferedConversationCount]
/ FactConversation[Totalconversations_FactConversation], FactConversation[StatusId] = "4", FactConversation[IsAgentAccepted] = "1") return
IF(ISBLANk(rate) && NOT(ISBLANK([Total
conversations_FactConversation])), 0, rate)

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_sessionparticipant, systemuser |
|Attributes  |-  msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel​ <br>- msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocliveworkitem.msdyn_transfercount <br> - msdyn_sessionparticipant.msdyn_joinedon ​<br> -  systemuser.msdyn_botapplicationid|
|Filters  | - Filter the FactConversations table to include only rows where Ensure that msdyn_channelinstanceid is NULL.​ <br> - Exclude rows where msdyn_channel is'192350000’. <br> - Include msdyn_ocliveworkitem.statuscode set to 4​. <br> - Ensure that systemuser.msdyn_botapplicationid and msdyn_sessionparticipant.msdyn_joinedon isn't null​. <br> - IsAgentAcceptedSession is set as follows:​ If systemuser.msdyn_botapplicationid is empty or NULL and msdyn_sessionparticipant.msdyn_joinedon isn't empty, then IsAgentAcceptedSession is 1.​ Otherwise, it's 0.​ <br> -Transfer rate is defined by msdyn_ocliveworkitem.msdyn_transfercount > 0​.​|


## Transfer conversation count

*Applies to Omnichannel historical dashboards.*

Transfer conversation count is the number of conversations that one representative hands off to another representative​, a representative to a queue​, a representative to a PSTN number or Teams user​.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

TransferedConversationCount = CALCULATE(COUNTROWS(FactConversation), FactConversation[TransferCount] >0)

```

|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem)|
|Attributes  |- msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel​ <br> - msdyn_ocliveworkitem.msdyn_transfercount 
|Filters  | - Filter the FactConversations table to include only rows where Ensure that msdyn_channelinstanceid is NULL.​  <br>- Exclude rows where msdyn_channel is'192350000’. <br> - Transfer count is defined by msdyn_ocliveworkitem.msdyn_transfercount > 0. ​|

---
