---
title: Calculate customer service representatives metrics
description: Learn how to calculate key metrics for customer service representatives in Dynamics 365. Track performance, optimize operations, and improve customer satisfaction with detailed analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 10/09/2025
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
  - ai-gen-title
---

# Calculate customer service representatives metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides details on how to calculate customer service representative metrics in Dynamics 365 Customer Service. Use these metrics to evaluate performance and efficiency, optimize operations, and enhance customer satisfaction.


## Average first response time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average first response time is the average time an agent takes to reply to a customer after the customer starts a conversation. 

The system calculates average first response time by dividing the total first response time for all engaged conversations by the number of engaged conversations. The time is adjusted for operating hours. You can view the time in seconds or in hh:mm:ss format.

### DAX query and Dataverse reference

The following Data Analysis Expression (DAX) query and corresponding Dataverse entities are used in the Power BI semantic model. Learn more in [DAX queries](/dax/dax-queries).

### [Historical analytics](#tab/historicalpage)

```dax

Avg. time for first response (min) = ​CALCULATE (AVERAGE (FactConversation[FirstResponseTime] ) / 60.00,FactConversation [IsOutbound] <> "1")

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) |
|Attributes |- msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel |
|Filters  |- Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL or msdyn_channel isn't set to 1923500000. |

### [Real-time analytics](#tab/realtimepage)


```dax

Avg. first response time (sec) = AVERAGE(FactConversation[ReponseTimeInSecondsAdjustedForOperationHour])

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), [msdyn_liveworkstream](/dynamics365/developer/reference/entities/msdyn_liveworkstream)  |
|Attributes  | - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_liveworkstream.msdyn_streamsource <br> - msdyn_ocliveworkitem.msdyn_firstresponsetime​ <br> - msdyn_ocliveworkitem.msdyn_channelinstanceid​ <br> - msdyn_ocliveworkitem.msdyn_channel  |
|Filters  | - Filter the FactConversations table to include only rows where msdyn_channelinstanceid is NULL and​ msdyn_isagentsession set to 1​. <br> - Exclude rows where msdyn_streamsource is'192350000'​ ​|

---


## Average service representative response time

Service representative response time is the average time that customers who send a message wait to get a response from a service representative. It's calculated by dividing total response time by the number of message exchanges in engaged conversations and is adjusted based on operating hours. Longer response times mean customers wait longer between messages, negatively impacting their experience.

The time can be viewed in seconds or *hh:mm:ss* format.

## Service level (10, 20, 30, 40, 50, 60, 120 secs)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Service level in 10 seconds is a performance metric for contact centers or customer service teams. It shows the percentage of customer interactions, like calls or chats, answered within 10 seconds.​ Service levels are measured in intervals of 10, 20, 30, 40, 50, 60, 120 seconds. This metric is calculated as​: ​

Service Level (%) = (Number of interactions answered within 10 seconds / Total number of interactions) × 100​

For example, if 800 out of 1,000 calls are answered within 10 seconds, your service level is 80%.

### DAX query and Dataverse reference

The following Data Analysis Expression (DAX) query and corresponding Dataverse entities are used in the Power BI semantic model. Learn more in [DAX queries](/dax/dax-queries). 

### [Historical analytics](#tab/historicalpage)


```dax

Service level (10 seconds) = ​DIVIDE(​[Conversations in service level (10 seconds)],​ SUMX(​ FactConversation,​ IF(​    FactConversation[IsAgentAccepted] = "1"​ && FactConversation[IsOutbound] <> "1",​ 1,​ 0​ )​),​ BLANK())

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession) |
|Attributes | - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1​ <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1​. |

### [Real-time analytics](#tab/realtimepage)



```dax

Service level (10 seconds) = ​DIVIDE (​SUMX (​FactConversation,​IF (​FactConversation[ConversationFirstWaitTimeInSeconds] <= 10​ && FactConversation[IsAgentAccepted]​&& NOT FactConversation[DirectionCode],​ 1,​ 0​)​), ​SUMX (​FactConversation,​ IF (​FactConversation[IsAgentAccepted]​&& NOT FactConversation[DirectionCode],​ 1,​ 0​)

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession) |
|Attributes  |- msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon   |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1 ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1 for Incoming conversation​. |

---

## Conversations in service level (10, 20, 30, 40, 50, 60, 120 secs)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Conversation in service level (10 seconds) refers to the customer interactions (usually calls or chats) that are answered ​within 10 seconds. Service levels are measured in intervals of 10, 20, 30, 40, 50, 60, 120 seconds.

### DAX query and Dataverse reference

The following Data Analysis Expression (DAX) query and corresponding Dataverse entities are used in the Power BI semantic model. Learn more in [DAX queries](/dax/dax-queries). 

### [Historical analytics](#tab/historicalpage)



```dax

Conversations in service level (10 seconds) = ​SUMX(​ FactConversation,​ IF(​ FactConversation[FirstWaitTime] <= 10​ && FactConversation[IsAgentAccepted] = "1"​ && FactConversation[IsOutbound] <> "1",​  1,​ 0​))

```


|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) <br> - [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession)  |
|Attributes | - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - msdyn_conversationfirstwaittimeinseconds  |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1​. <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1​. <br> - msdyn_conversationfirstwaittimeinseconds is set to less than or equal to 10 or 20 or 30 or 40 or 50 or 60 or 120. |

### [Real-time analytics](#tab/realtimepage)



```dax

Conversations in service level (10 seconds) = ​SUMX (​FactConversation,​ IF (​ FactConversation ConversationFirstWaitTimeInSeconds] <= 10​ && FactConversation[IsAgentAccepted]​ && NOT FactConversation[DirectionCode],​ 1,​ 0​ )​)

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem) <br> - [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession)  |
|Attributes  | - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon ​<br> - msdyn_conversationfirstwaittimeinseconds   |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1​. <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1 for incoming conversations​ <br> - msdyn_conversationfirstwaittimeinseconds is set to less than or equal to 10 or 20 or 30 or 40 or 50 or 60 or 120. ​|

---

## Total capacity units

*Applies to Omnichannel real-time dashboards.*

Total capacity units represent the workload capacity assigned to a representative. These units determine how many concurrent conversations or tasks a representative can handle.



```dax

 Total capacity units = SUM(FactAgentCapacityUnit[DefaultMaxCapacityUnits])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - [msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus) <br> - [systemuser](/dynamics365/developer/reference/entities/systemuser)|
|Attributes  | - [systemuser.msdyn_capacity](/dynamics365/developer/reference/entities/systemuser) |
|Filters  | -  systemuser.msdyn_botapplicationid IS NULL to exclude AI agents. ​|


### Related metrics

- **Total available capacity units**: The number of capacity units that are available to handle conversations.
- **Total occupied capacity units**: Total occupied capacity units are a measure of the capacity units that are currently occupied.

## Total representative work item capacity 

*Applies to Omnichannel real-time dashboards.*

The total default maximum capacity units assigned to representatives based on their capacity profile.



```dax

Total agent work item capacity =SUM( FactAgentCapacityProfile[AgentDefaultMaxProfileUnits])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - [msdyn_agentcapacityprofileunit](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit) along with <br> - [msdyn_capacityprofile](/dynamics365/developer/reference/entities/msdyn_capacityprofile)|
|Attributes  | - msdyn_agentcapacityprofileunit.msdyn_defaultmaxunits |
|Filters  | None ​|

## Assigned capacity profile count

*Applies to Omnichannel real-time dashboards.*

Assigned capacity profile count refers to the count of representatives who have an assigned capacity profile and aren't currently in **Offline** status.



```dax

Assigned capacity profile count = SUMX (FactAgentCapacityProfile,IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence) <br> - [msdyn_agentcapacityprofileunit](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit) |
|Attributes  | - [msdyn_presence.msdyn_basepresencestatus](/dynamics365/developer/reference/entities/msdyn_presence#msdyn_basepresencestatus-choicesoptions) |
|Filters  | - msdyn_presence.msdyn_basepresencestatus != 192360004 (Status isn't set to Offline) ​|

## Total work item capacity in use

*Applies to Omnichannel real-time dashboards.*

Total work item capacity in use is the representative's capacity occupied by active work items, based on their profile settings.



```dax

Total work item capacity in use = SUM ( FactAgentCapacityProfile[OccupiedProfileUnits] )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_agentcapacityprofileunit](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit): Main source of agent-specific capacity data  <br> - [msdyn_capacityprofile](/dynamics365/developer/reference/entities/msdyn_capacityprofile): Provides default capacity values and blocking rules|
|Attributes  | - OccupiedProfileUnits : Difference between [msdyn_capacityprofile.msdyn_defaultmaxunits](/dynamics365/developer/reference/entities/msdyn_capacityprofile?branch=ss-449106-csr#BKMK_msdyn_defaultmaxunits) and [msdyn_agentcapacityprofileunit.msdyn_availablecapacityprofileunits](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit?branch=ss-449106-csr#BKMK_msdyn_availablecapacityprofileunits) <br> - msdyn_capacityprofile <br> - msdyn_agentcapacityprofileunit|


### Related metrics

- **Total available work item capacity**: This metric is a measure of the maximum number of more work items that can be assigned.
- **Total work item capacity in use**: This metric is a measure of the work items that currently handled by representatives.

## Logged in service representatives

*Applies to Omnichannel real-time dashboards.*

Logged in service representatives refers to count of representatives who are currently logged in and aren't in Offline status.

**DAX query**

```dax

Logged in agents = SUMX ( FactAgentCapacityUnit,IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence) <br> - [msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus) along with [systemuser](/dynamics365/developer/reference/entities/systemuser)|
|Attributes  | - [msdyn_presence.msdyn_basepresencestatus](/dynamics365/developer/reference/entities/msdyn_presence#msdyn_basepresencestatus-choicesoptions) <br> - [mdyn_agentstatus.msdyn_availableunitscapacity](/dynamics365/developer/reference/entities/msdyn_agentstatus#BKMK_msdyn_availableunitscapacity)|
|Filters  | - msdyn_presence.msdyn_basepresencestatus != 192360004 (Status isn't set to Offline) ​|


## Total service representatives

*Applies to Omnichannel real-time dashboards.*

Total number of service representatives who have capacity data configured for routing and workload management.

**DAX query**

```dax

Total agents = COUNTROWS(FactAgentCapacityUnit )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus), along with [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes  | - [msdyn_agentstatus.msdyn_agentid](/dynamics365/developer/reference/entities/msdyn_agentstatus#BKMK_msdyn_agentid)|
|Filters  | - systemuser.msdyn_botapplicationid is NULL - Filters out representatives associated with a bot application. ​|

## Status duration

*Applies to Omnichannel real-time dashboards.*

Status duration shows how long representatives remain in a presence status, such as Available, Busy, or Away, during a selected time period. This duration is measured in minutes. For example, a representative in Busy status for 40 minutes shows a duration of 40.

**DAX query**

```dax

Status duration (mins) = CALCULATE (SUM ( FactAgentStatusHistory[DuringInSeconds] ) / 60.00,USERELATIONSHIP ( FactAgentStatusHistory[PresenceId], DimAgentPresence[PresenceId] ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - [msdyn_agentstatushistory](/dynamics365/developer/reference/entities/msdyn_agentstatushistory)  along with <br> - [msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence)|
|Attributes  | - Calculates the difference between the [msdyn_agentstatushistory.msdyn_starttime](/dynamics365/developer/reference/entities/msdyn_agentstatushistory#BKMK_msdyn_starttime) and [msdyn_agentstatushistory.msdyn_endtime](/dynamics365/developer/reference/entities/msdyn_agentstatushistory#BKMK_msdyn_endtime). The real-time dashboard shows the current UTC time while a service representative is in their current status. The end time appears only after the status changes.|
|Filters  | - msdyn_agentstatushistory.createdon >= DATEADD(MI, -120, GETUTCDATE()) Only include records where the agent status was created within the last 120 minutes (2 hours).​|

## Consult

This metric represents the service representative participation **Consult** mode. You can use these metrics to customize the visual display of your reports. Learn more in [Customize visual display](../use/customize-reports.md#customize-visual-display).

The related metrics aren't available by default. Select **Edit report** to find the following metrics in your data model when you search for **Consult**. 

### Related metrics

- **Average consult time**: The average time that service representatives spend helping other service representatives on consult requests. It's calculated by dividing the total time spent by service representatives on these requests by the total number of consult requests accepted. You can display the average consult time in seconds or in the hh:mm:ss format.

- **Consult acceptance rate**: The total number of sessions accepted by a service representative out of all the requested to consult sessions.

- **Consult not acceptance rate**: The total number of consult sessions that a service representative didn't accept, including timed-out and rejected requests.

- **Consult rejection rate**: The total number of consult sessions rejected by a service representative out of all requested sessions.

- **Consults requested**: The total number of consult sessions requested.

- **Consult requests accepted**:
The total number of consult sessions requested and accepted by a service representative.

- **Consult requests not accepted**: The total number of consult sessions requested but not accepted by a service representative.

- **Consult requests rejected**: The total number of consult sessions requested but rejected by a service representative.

- **Consult requests timed out**: The total number of consult sessions requested that timed out because the representative didn't respond.

- **Consult time**: The time taken by service representatives to help other service representatives on consult requests. This metric can be viewed in seconds and in *hh:mm:ss* formats. Available only for the omnichannel real-time out-of-the-box dashboard.

- **Consult sessions**: The total number of sessions that are under consult. Available only for the omnichannel historical out-of-the-box dashboard.

- **Consult timed out rate**: The total number of consult sessions requested that timed out.

## Consult acceptance rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of sessions accepted by a service representative out of all the requested to consult sessions.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)


```dax

Consult acceptance rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedDateTime] <> BLANK() && FactSessionParticipant[ModeId] = "192350003",​ 1,​ 0​)),SUMX (FactSessionParticipant, 
IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode|
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode = 192350003 AND AgentJoinedDateTime is msdyn_sessionparticipant.msdyn_joinedon not equal to blank. |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult acceptance rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedDateTime] <> BLANK() && FactSessionParticipant[ModeId] = "192350003",​ 1,​ 0​)),SUMX (FactSessionParticipant, 
IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [systemuser](/dynamics365/developer/reference/entities/systemuser), [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)  |
|Attributes |- msdyn_sessionparticipant.msdyn_mode​ <br> - msdyn_sessionparticipant.msdyn_joinedon​ <br> - systemuser.msdyn_botapplicationid  |
|Filters  |- All conversations where FactSessionParticipant is obtained from systemuser.msdyn_botapplicationid is null​ <br> - msdyn_sessionparticipant.msdyn_joinedon is not blank​ <br> - msdyn_sessionparticipant.msdyn_mode set to 192350003 ​|

---


## Consults requested

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult requested = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[ModeId] = "192350003", 1, 0  ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_mode
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode set to 192350003 |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requested = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[ModeId] = 192350003,1, 0  ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [systemuser](/dynamics365/developer/reference/entities/systemuser), [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)  |
|Attributes |- msdyn_sessionparticipant.msdyn_mode​ <br> - systemuser.msdyn_botapplicationid   |
|Filters  |- All conversations where FactSessionParticipant is obtained from systemuser.msdyn_botapplicationid is null​ <br> - msdyn_sessionparticipant.msdyn_mode set to 192350003 ​​|

---

## Consult requests accepted

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested and accepted by a service representative.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests accepted = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[AgentJoinedDateTime] <>
BLANK() && FactSessionParticipant[ModeId] =
"192350003",​ 1, 0) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode = 192350003 AND AgentJoinedDateTime is  msdyn_sessionparticipant.msdyn_joinedon not equal to blank |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests accepted = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[AgentJoinedOn] <> BLANK() &&
FactSessionParticipant[ModeId] = 192350003,1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser)  |
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid |
|Filters  |- All Conversations where ​msdyn_sessionparticipant.msdyn_joined isn't null or blank and​ msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - systemuser.msdyn_botapplicationid isn't null​ ​​|

---

## Consult requests not accepted

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested but not accepted by a service representative.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests not accepted = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[AgentJoinedDateTime] ==
BLANK() && FactSessionParticipant[ModeId] = "192350003",1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode = 192350003 AND AgentJoinedDateTime is msdyn_sessionparticipant.msdyn_joinedon equal to blank  |

### [Real-time analytics](#tab/realtimepage)


```dax

Consult requests not accepted = SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedOn] == BLANK() &&
FactSessionParticipant[ModeId] = 192350003,​ 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_joinedon is null or blank and​ msdyn_sessionparticipant.msdyn_mode = 192350003​. <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Session participant consult rejection count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

(Need info)

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] == "AgentReject"
&& FactSessionParticipant[ModeId] = "192350003", 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003 |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] == "AgentReject"
&& FactSessionParticipant[ModeId] = "192350003", 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject” and​ msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Session participant consult rejection rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions rejected by a service representative out of all requested sessions.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult rejection rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentReject" && FactSessionParticipant[ModeId] = "192350003", 1, 0)),SUMX (FactSessionParticipant,IF
(FactSessionParticipant[ModeId] = "192350003",​ 1, BLANK() ) ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject" and​ msdyn_sessionparticipant.msdyn_mode = 192350003 |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult rejection rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentReject" && FactSessionParticipant[ModeId] = "192350003", 1, 0)),SUMX (FactSessionParticipant,IF
(FactSessionParticipant[ModeId] = "192350003",​ 1, BLANK() ) ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentReject, 
msdyn_sessionparticipant.msdyn_mode = 192350003​.  <br> - systemuser.msdyn_botapplicationid isn't null.​ ​​|

---


## Session participant consult timed out count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested that timed out because the representative didn't respond.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests timed out = SUMX(​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentTimeout" && FactSessionParticipant[ModeId] = "192350003", 1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" and​ msdyn_sessionparticipant.msdyn_mode = 192350003|

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests timed out = SUMX(​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentTimeout" && FactSessionParticipant[ModeId] = "192350003", 1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" <br> - msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. ​​|

---


## Session participant consult timed out rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of requested consult sessions that timed out because the representative didn't respond.

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Consult timed out rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[LeftOnReason] == "AgentTimeout" &&
FactSessionParticipant[ModeId] = "192350003",​ 1, 0​)​),SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​ ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" and​ msdyn_sessionparticipant.msdyn_mode = 192350003|

### [Real-time analytics](#tab/realtimepage)



```dax

Consult timed out rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[LeftOnReason] == "AgentTimeout" &&
FactSessionParticipant[ModeId] = "192350003",​ 1, 0​)​),SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​ ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser)  |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" <br> - msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---


## Average consult time (min)​

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

(Need info)

### DAX query and Dataverse reference

The following DAX query and the corresponding Dataverse entities are used in the Power BI semantic model.

### [Historical analytics](#tab/historicalpage)



```dax

Avg. consult time (min) = ​CALCULATE (​DIVIDE (​IF (​SUM (FactSessionParticipant[TotalParticipantTimeMin] ) = BLANK (), 0, SUM ( FactSessionParticipant[TotalParticipantTimeMin] )​), [Consult requests accepted]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" and​ msdyn_sessionparticipant.msdyn_mode = 192350003|

### [Real-time analytics](#tab/realtimepage)



```dax

Avg. consult time (sec) = 
AVERAGEX(FactSessionParticipant, IF(FactSessionParticipant[AgentJoinedOn] <> BLANK() && FactSessionParticipant[ModeId] = 192350003, FactSessionParticipant[ParticipationTimeInSeconds], BLANK()))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All Conversations where ​msdyn_sessionparticipant.msdyn_leftonreason = "AgentTimeout" <br> - msdyn_sessionparticipant.msdyn_mode = 192350003​ <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Related information

[Customize visual display](../use/customize-reports.md#customize-visual-display) 
[Calculate conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics)  
[Calculate session metrics](calculate-session-metrics.md#calculate-session-metrics)


