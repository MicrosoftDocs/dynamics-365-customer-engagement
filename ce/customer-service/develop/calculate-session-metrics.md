---
title: Calculate session metrics
description: 
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 07/08/2025
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

An omnichannel session, or msdyn_ocsession, is a table or entity in Microsoft Dynamics 365 that represents a session with a customer. This table includes various messages that represent operations or events that can be performed on the table, such as assigning, associating, creating, and updating records. Each conversation with the customer is split into multiple sessions. The first session is the first interaction with the customer, and answered by the either the agent or the representative. If the agent is the first session, and the conversation is escalated, the second session is usually with a human agent. 

### DAX query and Dataverse reference

The following Data Analysis Expression (DAX) query and the corresponding Dataverse entities are used in the Power BI semantic model. Learn more in [DAX queries](/dax/dax-queries). 

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Info

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

Indicates the total count of sessions within a conversation declined by the service representative. 

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Sessions rejected = ​CALCULATE(DISTINCTCOUNT(FactSession[SessionId]), FactSession[IsAgentSession], FactSession[Closurereason] = "192350001")

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
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) msdyn_ocsession, systemuser |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid |
|Filters  | - Filter the FactConversations table to include only rows msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is not null​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​. |

---

## Session rejection rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session rejection rate indicates the rate at which service representatives reject work that is assigned to them. It's calculated by dividing the total number of sessions that service representatives rejected by the total number of sessions assigned to them. A rejected session is one where the representative declines the
incoming work item ​by selecting Reject on a notification, as opposed to letting it time out.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Session rejected rate = DIVIDE(IF (​[Sessions rejected] = BLANK (),​ 0, [Sessions rejected]), [Incoming
sessions_FactSession], BLANK()) 

```

|Element|Value  |
|---------|---------|
|Dataverse entities | msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent |
|Attributes | - msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​, <br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser. msdyn_botapplicationid  |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ <br>- IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​ <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​ ​|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session rejection rate = ​DIVIDE ( SUMX ( FactSession,​ 
IF ( FactSession[SessionClosureReasonCode] == 192350001, 1, 0 ) ), SUMX (FactSession, IF (FactSession[SessionStateCode] == 192350002, 1, BLANK () ) ), BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid     |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350001​ <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_state set to 192350002​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. ​|

---

### Related metrics

- **Rejected sessions**: The total number of sessions that the service representative declined.
- **Session time to reject**: The average time that service representatives take to reject work that is assigned to them. This metric measures the time from when a customer request is assigned to a service representative until the service representative rejects the request.

## Session timeout rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session timeout rate is the percentage of sessions that expire due to agent inactivity, which means that the representative neither ​accepted nor rejected the session request.​ It's calculated as the number of timed-out sessions divided by the total assigned sessions mulitplied by 100.

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
|Dataverse entities |systemuser, msdyn_sessionparticipant   |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​|

---

### Related metric

- **Timeout sessions**: The total number of times that service representatives didn't respond to the work that was assigned to them.

## Sessions timeout

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Sessions timeout in refers to the customer sessions that aren't accepted or rejected by a representative within a defined time window, causing the system to automatically expire or close the session.

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
|Dataverse entities | msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent|
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventtype​, <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​, <br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason ​<br> - 
systemuser.msdyn_botapplicationid   |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ ​<br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ ​<br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ ​<br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  is not null​ ​<br> - Agent timeout session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350002​  |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

The following data is yet to be reviewed

Sessions timedout = SUMX(FactSessionParticipant,​ IF ( FactSessionParticipant[LeftOnReason] == "AgentTimeout",1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  systemuser, msdyn_sessionparticipant  |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid      |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​.|

---

## Average session wait time 

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Need definition

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Avg. wait time (sec)_FactSession = CALCULATE(AVERAGE(FactSession[WaitTime]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | 
|Attributes | |
|Filters  | All Conversations where, Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ <br> - Exclude sessions from 'Entity Records' channel and SMS filter​ <br> - Case when ClosedOnDateTime is null then null else Timestampdiff(Second,msdyn_ocsession.msdyn_sessioncreatedon, Coalesce(msdyn_ocsession.msdyn_agentacceptedon,​ msdyn_ocsession.msdyn_sessionclosedon which is !=null)​

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

The following data is yet to be reviewed

Session wait time (sec) = SUM(FactSession[SessionWaitTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  systemuser, msdyn_sessionparticipant  |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid      |
|Filters  | - All Conversations where​ systemuser.msdyn_botapplicationid IS NULL AND msdyn_ocliveworkitem.statuscode IN
(1,2,3,4,5,6,7)​ Date difference in second (msdyn_ocsession.msdyn_sessioncreatedon, Coalesce(msdyn_ocsession.msdyn_agent
acceptedon or msdyn_ocsession.msdyn_sessionclosedon which is !=null)|

---




## Transferred sessions

*Applies to Omnichannel real-time and historical dashboard.*

Transferred sessions refer to customer interactions such as chats, voice calls, or messaging sessions that are​ handed off from one representative, agent, or queue to another during the course of the engagement.​ A session transfer can occur in several ways:​

- Representative-to-representative transfer: A representative manually transfers a session to another representative, often due to skill mismatch or for workload balancing.​

- Representative-to-Queue transfer: The session is routed to a different queue for reassignment, typically when escalation or specialized support is needed.​

- Agent-to-representative transfer: An agent escalates the session to a representative, either because the user requested it or due to a business rule (for example, maximum retries or unsupported intent).​

- External transfers: In some configurations, sessions can be transferred to external phone numbers or contact centers (for example, via SIP routing). However, this depends on the system setup​.
​
### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Transfer count = ​CALCULATE (​ DISTINCTCOUNT ( 'FactSession'[SessionId] ),​ KEEPFILTERS (OR ( 'FactSession'[Closurereason]
= "192350006", 'FactSession'[Closurereason] = "192350010") ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |msdyn_ocsession |
|Attributes | msdyn_ocsession.msdyn_closurereason|
|Filters  |Agent Transferred session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010|



### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Transferred sessions = ​SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​ <br> - Agent Rejected session is obtained by msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Session transfer rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session transfer rate refers to the percentage of customer sessions that are ​transferred from one representative or queue to another during the course of handling an interaction​. It's calculated as the number of transferred sessions divided by the total number of incoming sessions, mulitplied by 100. A transferred session can occur when:​

- A representative manually transfers a session to another representative or queue.​

- An agent escalates the session to a representative.​

- The system reroutes the session due to skill mismatch or availability constraints.


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
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid,  <br> - msdyn_ocsession.msdyn_agentacceptedon|
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​, <br> - msdyn_ocsession.msdyn_agentacceptedon is not null​ <br> - msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010​. <br>-  All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Incoming session

*Applies to Omnichannel historical dashboards.*

An incoming session refers to a new customer interaction, such as a chat, voice call, SMS that comes to the system and is routed to an available representative or agent for handling.​

It's essentially a work item that represents a customer's request for support. It's created when a customer initiates contact through any supported channel (for example, live chat, voice, etc.) and is queued for assignment based on routing rules, agent availability, and skill matching.


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Incoming conversations_FactSession = ​CALCULATE(DISTINCTCOUNTNOBLANK(FactSession[ConversationId_FS]),FactSession[IsAgentSession] = "1",FactSession[IsOutbound] <> "1")

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser, msdyn_ocsessionparticipantevent |
|Attributes | - msdyn_ocsessionparticipantevent.msdyn_eventtype​ <br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​ ​ <br> - msdyn_ocsession.msdyn_sessionid​ ​ <br> - msdyn_ocsession.msdyn_closurereason ​​ <br> - systemuser.msdyn_botapplicationid  ​​ <br> - msdyn_ocliveworkitem.msdyn_isoutbound​ ​ <br> - msdyn_ocliveworkitem.msdyn_channel​ ​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid |
|Filters  |- Session is calculated based on msdyn_ocsession.msdyn_sessionid which needs to have atleast one AgentSession through systemuser.msdyn_botapplicationid  is not null​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - Incoming session is defined through msdyn_ocliveworkitem.msdyn_isoutbound is not set to 1​. |

## Time to reject (sec)

*Applies to Omnichannel real-time dashboards.*

Time to reject (seconds) refers to the average duration a representative takes to reject a session after it has been
assigned to them. It's the time interval between when a session is assigned to a representative and when the representative
explicitly selects Reject. This metric is part of the broader session lifecycle analytics, helping supervisors understand how quickly agents respond to incoming work items, especially when they choose not to handle them.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Session time to reject (sec) = SUM(FactSession[TimeToRejectInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason , <br> - systemuser.msdyn_botapplicationid, <br> -msdyn_ocsession.msdyn_agentassignedon |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - When msdyn_ocsession.msdyn_closurereason is set to 192350001 then use the date difference in secs between msdyn_ocsession.msdyn_agentassignedon, msdyn_ocsession.msdyn_sessionclosedon​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Session time to accept (sec)

*Applies to Omnichannel real-time dashboards.*

Time to Accept (seconds) refers to the average time it takes for a representative to​ accept a session, such as a chat, voice call, or a messaging request after it has been routed to them.​ Tracking time to accept helps supervisors and operations teams:​ 

- Evaluate representative responsiveness​

- Identify potential delays in customer engagement​

- Optimize routing logic and representative availability


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Session time to accept (sec) =
SUM(FactSession[TimeToAcceptInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | -  msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_ocsession.msdyn_agentacceptedon <br> -msdyn_ocsession.msdyn_agentassignedon |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - Time to accept in secs is defined by difference between msdyn_ocsession.msdyn_agentassignedon and msdyn_ocsession.msdyn_agentacceptedon​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Session handle time

*Applies to Omnichannel real-time dashboards.*

Session handle time refers to the total duration a representative actively ​engages with a customer session, including the time spent during the live ​interaction and any follow-up or wrap-up activities.​ This metric is tracked per session and can be aggregated across conversations or representative for performance analysis. This metric is a KPI used to:​

- Measure agent productivity and workload​

- Identify inefficiencies in handling customer interactions​

- Benchmark service levels across channels (chat, voice, messaging)


### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

**DAX query**

```dax

Session handle time (sec) = SUM(FactSession[AgentHandlingTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, msdyn_sessionparticipant, systemuser  |
|Attributes  |  - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_sessionparticipant_msdyn_activetime |
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. ​<br> - Session handle time is defined by ​When msdyn_ocsession.msdyn_agentacceptedon is not null then msdyn_sessionparticipant.msdyn_activetime else null​ ​<br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |

---

## Average session handle time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average session handle time refers to the average amount of time a representative spends actively handling a single
session, such as a chat, voice call, or messaging interaction with a customer. Average session handle time includes:​

- Active session time: The duration when the representative is directly engaged with the customer (for example, chat or voice).​

- Hold time: The duration when the customer is placed on hold.​

- Wrap-up time: The duration spent completing notes or follow-up tasks after the session ends.​

It is calculated as the total handle time across sessions divided by the number of sessions handled​. This metric is tracked per agent and per session, and can be aggregated across teams or time periods for reporting.



### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

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
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, msdyn_sessionparticipant, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_sessionparticipant_msdyn_activetime  |
|Filters  |  - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​ <br> - Session handle time is defined by ​When msdyn_ocsession.msdyn_agentacceptedon is not null then msdyn_sessionparticipant.msdyn_activetime else null​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |


---

### Related metric

- **Session handle time**: The time that service representatives spend helping customers on assigned customer requests.

## Session participant consult rejection count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session participant consult rejection count refers to the number of consult​ sessions explicitly rejected by representatives after being requested by another representative during a customer interaction. This metric is tracked at the session participant level, and reflects individual representative responses to consult requests, and not the overall session outcome.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)

**DAX query**

```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​ IF
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
|Filters  | - Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. |

---

### Related metrics

- **Session participant**: The list of participants within a single session. A session contains at least one session participant; participant can be a service representative, agent, or IVR. Additional participants can be added to the same session in scenarios like Monitor or Consult.
- **Session participant count**: The total number of service representatives who were involved in helping a customer. Includes the primary service representative assigned to work on the session and any subject matter experts who were consulted. You can use the SessionParticipationType dimension to analyze this metric and get further statistics.

## Related information

[Calculate conversation metrics](calculate-conversation-metrics.md#calculate-conversation-metrics)


