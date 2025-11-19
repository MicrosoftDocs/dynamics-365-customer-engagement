---
title: Calculate session metrics
description: Learn to calculate and interpret session metrics to drive strategic decisions and enhance customer experiences.
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


This article explains how to use session metrics to track agent performance, monitor key performance indicators (KPIs), and improve customer satisfaction in Dynamics 365 Customer Service.

An omnichannel session (msdyn_ocsession) represents a customer interaction and captures events such as assigning, associating, creating, and updating records. A single conversation might include multiple sessions, starting with the initial interaction, typically handled by an agent, and followed by more sessions if the conversation is escalated to another customer service representative (service representative or representative).

The following sections describe session metrics calculations using Power BI reports and Dataverse calculations, helping you gain actionable insights and optimize service operations.


## Sessions rejected

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Sessions rejected indicate the total number of sessions within a conversation that the service representative declines. 

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
|Filters  |- Session is calculated based on msdyn_ocsession.msdyn_sessionid <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'. <br> - IsAgentSession is when systemuser.msdyn_botapplicationid isn't null. <br> - Agent Rejected session is msdyn_ocsession.msdyn_closurereason set to 192350001. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively.|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Sessions rejected = SUMX(FactSessionParticipant,​ 
IF (FactSessionParticipant[LeftOnReason] == 
"AgentReject", 1, 0))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem),  msdyn_ocsession, systemuser |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason ​<br> - systemuser.msdyn_botapplicationid |
|Filters  | - Filter the FactConversations table to include only rows msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. <br> - IsAgentSession occurs when systemuser.msdyn_botapplicationid isn't null​. <br> - Agent Rejected session occurs when the msdyn_ocsession.msdyn_closurereason is set to 192350001​. |

---

## Session rejection rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session rejection rate is the rate at which service representatives reject work that's assigned to them. 
Session Rejection Rate =​ Number of sessions rejected by agents / Total number of sessions assigned to agents. A session is considered rejected when a representative selects **Reject** on the incoming work item notification, rather than letting it time out.

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
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ <br>- IsAgentSession occurs when systemuser.msdyn_botapplicationid isn't null​ <br> - Agent Rejected session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350001​ ​|

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session rejection rate = ​DIVIDE ( SUMX ( FactSession,​ 
IF ( FactSession[SessionClosureReasonCode] == 192350001, 1, 0 ) ), SUMX (FactSession, IF (FactSession[SessionStateCode] == 192350002, 1, BLANK () ) ), BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_state​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid     |
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​. <br> - Agent Rejected session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350001​ <br> - Agent Rejected session occurs when msdyn_ocsession.msdyn_state is set to 192350002​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. ​|

---

### Related metrics

- [Sessions rejected](#sessions-rejected): Indicates the total count of sessions within a conversation declined by the service representative.
- **Session time to reject (sec)**: The average duration it takes for a service representative to reject an assigned work item. This metric captures the time between when a customer request is assigned and when the representative selects **Reject**.

## Time to reject (sec)

*Applies to Omnichannel real-time dashboards.*

Time to reject (seconds) is the average time a representative takes to reject a session after it's assigned. It tracks the duration between when the session is assigned and when the representative selects **Reject**, helping supervisors understand how quickly agents respond while declining work items.

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
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​. <br> - When msdyn_ocsession.msdyn_closurereason is set to 192350001 then use the date difference in secs between msdyn_ocsession.msdyn_agentassignedon, msdyn_ocsession.msdyn_sessionclosedon​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---


## Sessions timeout

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

A session times out when a representative doesn't accept or reject a customer session within a set time. The system then automatically closes the session.

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
|Attributes |- msdyn_ocsessionparticipantevent.msdyn_eventtype​<br> - msdyn_ocsessionparticipantevent.msdyn_eventreason​<br> - msdyn_ocsession.msdyn_sessionid​ <br> - msdyn_ocsession.msdyn_closurereason​<br> - systemuser.msdyn_botapplicationid   |
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ ​<br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ ​<br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ ​<br> - IsAgentSession occurs when systemuser.msdyn_botapplicationid isn't null​ ​<br> - Agent timeout session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350002​  |

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
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​.|

---



## Session timeout rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session timeout rate represents the rate at which [sessions timeout](#sessions-timeout). Session Timeout Rate (%) = (Number of timed-out sessions/Total assigned sessions) × 100.

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
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001.' <br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  isn't null​ <br> - Agent Timeout session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350002​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Session timeout rate = ​ DIVIDE (SUMX (FactSession, IF ( FactSession[SessionClosureReasonCode] == 192350002, 1, 0 ) ), SUMX ( FactSession,IF (FactSession[SessionStateCode] == 192350002, 1, BLANK () ) ),BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities |systemuser, msdyn_sessionparticipant   |
|Attributes  | - msdyn_sessionparticipant.msdyn_leftonreason​, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​. <br> - msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout"​|

---

### Related metric

- [Sessions timeout](#sessions-timeout): A session times out when a representative doesn't accept or reject a customer session within a set time. The system then automatically closes the session.


## Transferred sessions

*Applies to Omnichannel real-time and historical dashboard.*

Transferred sessions are customer interactions—such as chats, voice calls, or messaging sessions—that are handed off from one representative, agent, or queue to another during the conversation. Transfers can occur in several ways:

- **Representative-to-representative**: A representative manually transfers a session to another representative, often due to skill mismatch or workload balancing.
- **Representative-to-queue**: The session is routed to a different queue for reassignment, typically for escalation or specialized support.
- **Agent-to-representative**: The AI agent escalates the session to a representative, either at the customer’s request or due to business rules such as maximum retries or unsupported intent.
- **External transfers**:  Sessions transferred to external phone numbers or contact centers. For example, through Session Initiation Protocol (SIP) routing.

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
|Filters  |Agent Transferred session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350006 or 192350010|



### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

Transferred sessions = ​SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid |
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​ <br> - Agent Rejected session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350006 or 192350010​ <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Session transfer rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session transfer rate is the percentage of customer sessions that are [transferred](#transferred-sessions). Session transfer rate = Number of transferred sessions / Total number of incoming sessions × 100.

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
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​, <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​. <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - IsAgentSession occurs when systemuser.msdyn_botapplicationid isn't null​ <br> - Agent Transfer to Queue session occurs when msdyn_ocsession.msdyn_closurereason is set to 192350006 OR 192350010​ |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

DIVIDE (SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) ),​ SUMX (FactSession, IF ( ISBLANK ( FactSession[AgentAcceptedOn] ), BLANK (), 1 ) ), BLANK ())​

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​, <br> - msdyn_ocsession.msdyn_closurereason, <br> - systemuser.msdyn_botapplicationid,  <br> - msdyn_ocsession.msdyn_agentacceptedon|
|Filters  | - IsAgentSession occurs when systemuser.msdyn_botapplicationid is null​, <br> - msdyn_ocsession.msdyn_agentacceptedon isn't null​ <br> - msdyn_ocsession.msdyn_closurereason set to 192350006 or 192350010​. <br>-  All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Incoming session

*Applies to Omnichannel historical dashboards.*

An incoming session is a new customer chat, voice call, or SMS interaction that is handles by an AI agent or routed to an available representative.

It represents a work item created when a customer initiates contact through any supported channel (for example, live chat or voice). The session is then queued for assignment based on routing rules, agent availability, and skill matching.


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
|Filters  |- Session is calculated based on msdyn_ocsession.msdyn_sessionid which needs to have atleast one AgentSession through systemuser.msdyn_botapplicationid  isn't null​. <br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ <br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​. <br> - Incoming session occurs when msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1​. |



## Session time to accept (sec)

*Applies to Omnichannel real-time dashboards.*

Time to accept (seconds) is the average duration it takes for a representative to accept a session—such as a chat, voice call, or messaging request—after the session is routed to them. This metric provides supervisors and operations teams insights on:

- Responsiveness of representatives
- Potential delays in customer engagement
- Effectiveness of routing logic and representative availability


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
|Filters  | - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​. <br> - Time to accept in secs is the difference between msdyn_ocsession.msdyn_agentassignedon and msdyn_ocsession.msdyn_agentacceptedon​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​. |

---

## Session handle time

*Applies to Omnichannel real-time dashboards.*

Session handle time is the total time a representative spends working on a customer session, including the live interaction and any follow-up or wrap-up activities. This metric is tracked per session and can be aggregated across conversations or agents for performance analysis. This KPI provides insights on:

- Agent productivity and workload
- Inefficiencies in handling customer interactions
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
|Filters  | - IsAgentSession occurs when from systemuser.msdyn_botapplicationid is null​. ​<br> - Session handle time is when msdyn_ocsession.msdyn_agentacceptedon isn't null then msdyn_sessionparticipant.msdyn_activetime else null​ ​<br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |

---

## Average session handle time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average session handle time is the average duration a representative spends actively managing a single chat, voice call, or messaging session. This metric includes:

- Active session time: The duration when the representative is directly interacting with the customer.
- Hold time: The time the customer is put on hold.
- Wrap-up time: The time spent by the representative completing notes or follow-up tasks after the session ends.

Average Session Handle Time = Total handle time across sessions / Number of sessions handled​. This metric is tracked per agent and per session, and can be aggregated across teams or time periods for reporting.

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
|Filters  | - Session is calculated based on msdyn_ocsession.msdyn_sessionid​ ​<br> - Exclude in-transit record with msdyn_eventreason '192350001' and Hold event with msdyn_eventtype '192350001'​ ​<br> - Exclude sessions from 'Entity Records' channel and SMS filter using msdyn_ocliveworkitem.msdyn_channel != '192350000' and​ msdyn_ocliveworkitem.msdyn_channelinstanceid is NULL respectively​ ​<br> - IsAgentSession is obtained from systemuser.msdyn_botapplicationid  isn't null​ ​<br> - msdyn_sessionparticipant.msdyn_activetime != null and msdyn_sessionparticipant.msdyn_joinedon isn't null​|

### [Real-time analytics](#tab/realtimepage)

```dax

Avg. session handle time (sec) = AVERAGE(FactSession[AgentHandlingTimeInSeconds])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), msdyn_ocsession, msdyn_sessionparticipant, systemuser  |
|Attributes  | - msdyn_ocliveworkitem.statuscode​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - systemuser.msdyn_botapplicationid ​<br> - msdyn_sessionparticipant_msdyn_activetime  |
|Filters  |  - IsAgentSession is obtained from systemuser.msdyn_botapplicationid is null​ <br> - Session handle time is when msdyn_ocsession.msdyn_agentacceptedon isn't null then msdyn_sessionparticipant.msdyn_activetime else null​. <br> - All conversations where msdyn_ocliveworkitem.statuscode is set to any value between 1 to 7​ |


---

### Related metric

- [Session handle time](#session-handle-time): Session handle time is the total time a representative spends on a customer session, including live interaction and follow-up or wrap-up activities.

## Session participant consult rejection count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session participant consult rejection count is the number of consult sessions that a representative rejects after another representative requests a consult during a customer interaction. This metric is tracked at the session participant level and reflects individual representative responses to consult requests, rather than the overall session outcome.


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
|Filters  | - Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - Session participant is FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. |

---

### Related metrics

- **Session participant**: The list of participants within a single session. Each session includes at least one participant, who can be a service representative, AI agent, or IVR agent. More participants may be added in **Monitor** or **Consult** scenarios.
- **Session participant count**: The total number of service representatives involved in assisting a customer, and includes the primary representative assigned to the session and any subject matter experts who were consulted. Use the SessionParticipationType dimension to analyze this metric and obtain more statistics.

## Related information

[Calculate conversation metrics](calculate-conversation-metrics.md#calculate-conversation-metrics)  

[Service representative metrics](../use/service-rep-metrics.md#service-representative-metrics).