---
title: Calculate session metrics
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 04/23/2025
ms.custom: bap-template 
---


# Calculate session metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides an overview of conversation metrics available in Dynamics 365 Customer Service, that help you analyze key performance indicators (KPIs) to make strategic decisions, track customer service representative (service representative or representative) and AI agent performance, and improve customer satisfaction.

It also provides detailed guidance on calculating key conversation metrics. By using Power BI reports and Dataverse calculations, you can gain valuable insights into customer service efficiency and improve overall customer satisfaction. [Understand the conversation workflow](../use/overview-analytics-data-model.md#understand-the-conversation-workflow) to effectively utilize these metrics and improve customer service operations and decision-making. 

Learn more about [Calculate conversation metrics](calculate-conversation-metrics.md#calculate-conversation-metrics) and [Service representative metrics](../use/service-rep-metrics.md#service-representative-metrics).

## Session

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

An omnichannel session, or msdyn_ocsession, is a table/entity in Microsoft Dynamics 365 that represents a session for interacting with a customer. This table includes various messages that represent operations or events that can be performed on the table, such as assigning, associating, creating, and updating records. Each conversation with the user is split into multiple sessions. The first session is the first interaction with the user, this could be answered by the bot or direct agent. If bot is the first session, then if the conversation is escalated, the second session is the human agent interaction. 

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Need info

```


|Element|Value  |
|---------|---------|
|Dataverse entities |Need info |
|Attributes | Need info|
|Filters  |Need info |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Need info

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  Need info  |
|Attributes  |    Need info    |
|Filters  | Need info|

---

## Sessions rejected

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

**Need info**

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Sessions rejected = ​CALCULATE(DISTINCTCOUNT(FactSession[SessionId]), FactSession[IsAgentSession], FactSession[Closurereason]
= "192350001")

```


|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocsessionparticipantevent, msdyn_ocsession, systemuser|
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventtype​ <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason <br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid  |
|Filters  |- Session is calculated based on msdyn_ocsession.msdyn_sessionid <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is not null. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively.|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Sessions rejected = SUMX(FactSessionParticipant,​

IF (FactSessionParticipant[LeftOnReason] ==
"AgentReject", 1, 0))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem, msdyn_ocsession, systemuser |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid |
|Filters  | - Filter the FactConversations table to include only rows msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is not null​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​. |
---

## Session rejection rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The rate at which service representatives reject work that is assigned to them. It's calculated by dividing the total number of sessions that service representatives rejected by the total number of sessions assigned to them.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Session rejected rate = DIVIDE(IF (​[Sessions rejected] = BLANK (),​ 0, [Sessions rejected]), [Incoming essions_FactSession], BLANK()) ​

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent |
|Attributes | - msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​, <br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser. msdyn_botapplicationid  |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​. <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session rejection rate = ​DIVIDE ( SUMX ( FactSession,​ IF ( FactSession[SessionClosureReasonCode] == 192350001, 1, 0 ) ), SUMX (FactSession, IF (FactSession[SessionStateCode] == 192350002, 1, BLANK () ) ), BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid     |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_state set to 192350002​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​|
---

### Related metrics

- **Rejected sessions**: The total number of times that service representatives rejected work that was assigned to them.
- **Session time to reject**: The average time that service representatives take to reject work that is assigned to them. This metric measures the time from when the customer request is assigned to a service representative to when the service representative rejects the request.

## Session timeout rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The rate at which sessions time out because of service representative's inactivity. This metric is calculated by dividing the total number of requests where the service representative didn't provide any response by the total number of sessions that were assigned to them.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Session timeout rate = ​DIVIDE(IF ([Sessions timed out] = BLANK (),0, [Sessions timed out]), [Incoming sessions_FactSession], BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent |
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​, <br> - msdyn_ocsession.msdyn_sessionid​,  <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid   |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​ <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350002​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session timeout rate = ​ DIVIDE (SUMX (FactSession, IF ( FactSession[SessionClosureReasonCode] == 192350002, 1, 0 ) ), SUMX ( FactSession,IF (FactSession[SessionStateCode] == 192350002, 1, BLANK () ) ),BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | Systemuser, msdyn_sessionparticipant   |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​|

---

### Related metric

- **Timeout sessions**: The total number of times that service representatives didn't respond to the work that was assigned to them.

## Sessions timeout

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Need info

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Sessions timed out = ​CALCULATE(DISTINCTCOUNT(FactSession[SessionId]), FactSession[IsAgentSession], FactSession[Closurereason]
= "192350002")

```


|Element|Value  |
|---------|---------|
|Dataverse entities | |
|Attributes | |
|Filters  | |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

**To be reviewed**

Sessions timedout = SUMX(FactSessionParticipant,​ IF ( FactSessionParticipant[LeftOnReason] == "AgentTimeout",1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  Systemuser, msdyn_sessionparticipant  |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid      |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​.|
---

## Transferred sessions

*Applies to Omnichannel real-time dashboard.*

**Need info**

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Transferred sessions = ​SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) )
```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​ <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |
---

## Transfer rate session

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

**Need info**

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Transfer rate_FactSession = ​CALCULATE (DIVIDE (IF ( [_QueueTransferCount] = BLANK
(), 0, [_QueueTransferCount] ),​ FactSession[Incoming sessions_FactSession], BLANK () ))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent|
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​, <br> - msdyn_ocsession.msdyn_sessionid​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​, <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​. <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​ <br> - Agent Transfer to Queue session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350006 OR 192350010​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

DIVIDE (SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) ),​ SUMX (FactSession, IF ( ISBLANK ( FactSession[AgentAcceptedOn] ), BLANK (), 1 ) ), BLANK ())​

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid,  <br> - msdyn_ocsession.msdyn_agentacceptedon|
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​, <br> - msdyn_ocsession.msdyn_agentacceptedon is not null​ <br> - msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010​. <br>-  All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |
---

## Incoming session

*Applies to Omnichannel historical dashboards.*


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Incoming conversations_FactSession = ​CALCULATE(DISTINCTCOUNTNOBLANK(FactSession[ConversationId_FS]),FactSession[IsAgentSession] = "1",FactSession[IsOutbound] <> "1")

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocliveworkitem, msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent |
|Attributes | - msdyn_ocsessionparticipantevent.msdyn_eventtype​ <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​ ​ <br> - msdyn_ocsession.msdyn_sessionid​ ​ <br> - msdyn_ocsession.msdyn_closurereason ​​ <br> - systemuser.msdyn_botapplicationid  ​​ <br> - msdyn_ocliveworkitem.msdyn_isoutbound​ ​ <br> - msdyn_ocliveworkitem.msdyn_channel​ ​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid |
|Filters  |- Session is calculated based on msdyn_ocsession.msdyn_sessionid which needs to have atleast one AgentSession through systemuser.msdyn_botapplicationid  is not null​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - Incoming session is defined through msdyn_ocliveworkitem.msdyn_isoutbound is not set to 1​. |

## Time to reject (sec)

*Applies to Omnichannel real-time dashboards.*

**Need info**

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Session time to reject (sec) = SUM(FactSession[TimeToRejectInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason , <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - When msdyn_ocsession.msdyn_closurereason is set to 192350001 then use the date difference in secs between msdyn_ocsession.msdyn_agentassignedon, msdyn_ocsession.msdyn_sessionclosedon​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |
---

## Time to accept (sec)

*Applies to Omnichannel real-time dashboards.*

**Need info**

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Need info

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, systemuser  |
|Attributes  | -  msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_ocsession.msdyn_agentacceptedon       |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - Time to accept in secs is defined by difference between msdyn_ocsession.msdyn_agentassignedon and msdyn_ocsession.msdyn_agentacceptedon​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |
---

## Session handle time

*Applies to Omnichannel real-time dashboards.*


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session handle time (sec) = SUM(FactSession[AgentHandlingTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, msdyn_sessionparticipant, systemuser  |
|Attributes  |  - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - 
systemuser.msdyn_botapplicationid ​<br> - msdyn_sessionparticipant_msdyn_activetime |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. ​<br> - Session handle time is defined by ​When msdyn_ocsession.msdyn_agentacceptedon is not null then msdyn_sessionparticipant.msdyn_activetime else null​ ​<br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |
---

## Average session handle time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

This metric is like conversation handle time. However, it's calculated for every service representative who works on the conversation. This metric is relevant to conversations that multiple service representatives handled. If multiple service representatives were assigned to work on a conversation for any reason (for example, transfers or escalations), this metric measures the average time spent by each service representative. Conversation handle time is a measure of the aggregated session handle time for all the associated sessions.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

Avg. session handle time (min)_FactSession = CALCULATE(AVERAGE(FactSession[ActiveTimeInSec
onds]) / 60.00 , FactSession[StatusCode] = "2",FactSession[IsAgentSession] = "1",FactSession[IsAgentAcceptedSession] = "1")

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocsessionparticipantevent, systemuser, msdyn_ocsession, msdyn_sessionparticipant|
|Attributes | - msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason ​<br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid <br> - msdyn_sessionparticipant.msdyn_activetime​ <br> - msdyn_sessionparticipant.msdyn_joinedon  |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ ​<br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ ​<br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ ​<br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​ ​<br> - msdyn_sessionparticipant.msdyn_activetime != null and msdyn_sessionparticipant.msdyn_joinedon is not null​|

### [Real-time analytics](#tab/realtimepage)



```dax

Avg. session handle time (sec) = AVERAGE(FactSession[AgentHandlingTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem, msdyn_ocsession, msdyn_sessionparticipant, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_sessionparticipant_msdyn_activetime       |
|Filters  |  - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​ <br> - Session handle time is defined by ​When msdyn_ocsession.msdyn_agentacceptedon is not null then msdyn_sessionparticipant.msdyn_activetime else null​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |
---

### Related metric

- **Session handle time**: The time that service representatives spend helping customers on assigned customer requests.

## Session participant consult rejection count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Need info

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​

IF
(FactSessionParticipant[LeftOnReason] == "AgentReject" && FactSessionParticipant[ModeId] = "192350003",1,0))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_sessionparticipant |
|Attributes | - msdyn_sessionparticipant.msdyn_leftonreason​ ​<br> - msdyn_sessionparticipant_msdyn_mode|
|Filters  | Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003 |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Consult requests rejected = SUMX (​FactSessionParticipant, IF (FactSessionParticipant[LeftOnReason]
== "AgentReject" && FactSessionParticipant[ModeId] = 192350003, 1,0
))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_sessionparticipant, systemuser  |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​ ​<br> - msdyn_sessionparticipant_msdyn_mode​ ​<br> - systemuser.msdyn_botapplicationid|
|Filters  | - Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid is not null​. |
---

### Related metrics

- **Session participant**: The list of participants within a single session. A session contains at least one session participant; participant can be a service representative, agent, or IVR. Additional participants can be added to the same session in scenarios like Monitor or Consult.
- **Session participant count**: The total number of service representatives who were involved in helping a customer. Includes the primary service representative assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

## Related information

[Calculate conversation metrics](calculate-conversation-metrics.md#calculate-conversation-metrics)


