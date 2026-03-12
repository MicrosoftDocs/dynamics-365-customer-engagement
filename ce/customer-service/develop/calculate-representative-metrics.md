---
title: Calculate customer service representative metrics
description: Learn how to calculate key metrics for customer service representatives in Dynamics 365. Track performance, optimize operations, and improve customer satisfaction with detailed analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 03/12/2026
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/25/2025
  - ai-gen-title
---

# Calculate customer service representative metrics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

This article provides details on how to calculate customer service representative metrics in Dynamics 365 Customer Service. Use these metrics to evaluate performance and efficiency, optimize operations, and enhance customer satisfaction. You can use these metrics to customize the visual display of your reports. Learn more in [Customize visual display](../use/customize-reports.md#customize-visual-display).


## Average first response time

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Average first response time is the average time an agent takes to reply to a customer after the customer starts a conversation. 

The system calculates average first response time by dividing the total first response time for all engaged conversations by the number of engaged conversations. The time is adjusted for operating hours. You can view the time in seconds or in hh:mm:ss format.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

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

### Related metrics

- **Average service representative response time**

Service representative response time is the average time that customers who send a message wait to get a response from a service representative. It's calculated by dividing total response time by the number of message exchanges in engaged conversations and is adjusted based on operating hours. Longer response times mean customers wait longer between messages, negatively impacting their experience.

The time can be viewed in seconds or hh:mm:ss format.

## Service level (10, 20, 30, 40, 50, 60, 120 secs)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Service level in 10 seconds is a performance metric for contact centers or customer service teams. It shows the percentage of customer interactions, like calls or chats, answered within 10 seconds.​ Service levels are measured in intervals of 10, 20, 30, 40, 50, 60, 120 seconds. This metric is calculated as​: ​

Service Level (%) = (Number of interactions answered within 10 seconds / Total number of interactions) × 100​

For example, if 800 out of 1,000 calls are answered within 10 seconds, your service level is 80%.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)] 

### [Historical analytics](#tab/historicalpage)


```dax

Service level (10 seconds) = ​DIVIDE(​[Conversations in service level (10 seconds)],​ SUMX(​ FactConversation,​ IF(​    FactConversation[IsAgentAccepted] = "1"​ && FactConversation[IsOutbound] <> "1",​ 1,​ 0​ )​),​ BLANK())

```


|Element|Value  |
|---------|---------|
|Dataverse entities |[msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession) |
|Attributes | - msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1.​ <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1​. |

### [Real-time analytics](#tab/realtimepage)



```dax

Service level (10 seconds) = ​DIVIDE (​SUMX (​FactConversation,​IF (​FactConversation[ConversationFirstWaitTimeInSeconds] <= 10​ && FactConversation[IsAgentAccepted]​&& NOT FactConversation[DirectionCode],​ 1,​ 0​)​), ​SUMX (​FactConversation,​ IF (​FactConversation[IsAgentAccepted]​&& NOT FactConversation[DirectionCode],​ 1,​ 0​)

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [msdyn_ocliveworkitem](/dynamics365/customer-service/develop/reference/entities/msdyn_ocliveworkitem), [msdyn_ocsession](/dynamics365/developer/reference/entities/msdyn_ocsession) |
|Attributes  |- msdyn_ocliveworkitem.msdyn_isoutbound​ <br> - msdyn_ocsession.msdyn_agentacceptedon   |
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1. ​<br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1 for Incoming conversation​. |

---


## Service level abandon percentage

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The percentage of eligible conversations accepted within the configured service‑level threshold (first wait time ≤ queue service level threshold), excluding short‑abandoned conversations, divided by total eligible incoming conversations.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)] 

```dax
Service level % =  DIVIDE (SUMX (FactConversation, IF (FactConversation[InServiceLevel] && FactConversation[IsAgentAccepted]
&& NOT FactConversation[DirectionCode], 1, 0 ) ), SUMX ( FactConversation, IF ( FactConversation[IsAgentAccepted]
&& NOT FactConversation[DirectionCode], 1, 0 ) ), BLANK ())

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [queue](/dynamics365/developer/reference/entities/queue)|
|Attributes  |- [msdyn_queueservicelevelthreshold](/dynamics365/developer/reference/entities/queue#BKMK_msdyn_queueservicelevelthreshold)  |

## Service level excluding short abandons percentage

The percentage of eligible incoming conversations accepted within the configured service-level threshold. Conversations abandoned within the short-abandon threshold are excluded. This metric divides accepted within SLA conversations by the total eligible incoming conversations, minus short abandons.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)] 

```dax

Service level excluding short abandons % =  VAR SuccessfulAnswers =  SUMX ( FactConversation,  IF ( FactConversation[InServiceLevel] = TRUE, 1, 0 )) VAR EligibleConversations = SUMX ( FactConversation, IF ( FactConversation[IsShortAbandoned] = FALSE, 1, BLANK() ) ) RETURN DIVIDE ( SuccessfulAnswers, EligibleConversations )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [queue](/dynamics365/developer/reference/entities/queue) |
|Attributes  |- [msdyn_queueservicelevelthreshold](/dynamics365/developer/reference/entities/queue#BKMK_msdyn_queueservicelevelthreshold) <br> - [msdyn_shortabandonedthreshold](/developer/reference/entities/queue#BKMK_msdyn_shortabandonedthreshold)|

## Service level including abandon percentage

The percentage of eligible incoming conversations whose first wait time is within the configured service‑level threshold, including conversations that are later abandoned (no exclusion for short abandons), calculated as conversations meeting the SLA threshold divided by total eligible incoming conversations.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)] 

```dax

Service level including abandons % = VAR SuccessfulAnswers = SUMX ( FactConversation, IF ( FactConversation[InServiceLevel] = TRUE, 1, 0 ) ) VAR TotalIncoming = [Incoming conversations] RETURN DIVIDE ( SuccessfulAnswers, TotalIncoming )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |  [queue](/dynamics365/developer/reference/entities/queue) |
|Attributes  |- [msdyn_queueservicelevelthreshold](/dynamics365/developer/reference/entities/queue#BKMK_msdyn_queueservicelevelthreshold) |


## Conversations in service level (10, 20, 30, 40, 50, 60, 120 secs)

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Conversations in service level (10 seconds) refers to the customer interactions (usually calls or chats) where the representative answered an incoming conversation ​within 10 seconds. Service levels are measured in intervals of 10, 20, 30, 40, 50, 60, 120 seconds. This metric represents the total count of such conversations.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)] 

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
|Filters  | - msdyn_ocsession.msdyn_agentacceptedon is set to 1​. <br> - msdyn_ocliveworkitem.msdyn_isoutbound isn't set to 1 for incoming conversations.​ <br> - msdyn_conversationfirstwaittimeinseconds is set to less than or equal to 10 or 20 or 30 or 40 or 50 or 60 or 120. ​|

---

## Total capacity units

*Applies to Omnichannel real-time dashboards.*

Total capacity units represent the workload capacity assigned to a representative. These units determine how many concurrent conversations or tasks a representative can handle.

### DAX query and Dataverse reference

```dax

 Total capacity units = SUM(FactAgentCapacityUnit[DefaultMaxCapacityUnits])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - FactAgentCapacityUnit - [msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus) with [systemuser](/dynamics365/developer/reference/entities/systemuser)|
|Attributes  | - [systemuser.msdyn_capacity](/dynamics365/developer/reference/entities/systemuser) |
|Filters  | -  systemuser.msdyn_botapplicationid is NULL to exclude AI agents. ​|


### Related metrics

- **Total available capacity units**: The number of capacity units that are available to handle conversations.
- **Total occupied capacity units**: The number of capacity units that are currently occupied.

## Total representative work item capacity 

*Applies to Omnichannel real-time dashboards.*

The total maximum capacity profile units available across agent‑specific and default profiles, representing the overall capacity ceiling for work distribution.

### DAX query and Dataverse reference

```dax

Total agent work item capacity = SUM(FactAgentCapacityProfile[TotalAgentCapacityProfileUnitsLimit])

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - Consolidate (msdyn_agentcapacityprofileunit.msdyn_defaultmaxunits, msdyn_capacityprofile.msdyn_defaultmaxunits) along with agent-specific limit (msdyn_agentcapacityprofileunit.msdyn_defaultmaxunits) if configured. Otherwise the value falls back to the capacity profile default (msdyn_capacityprofile.msdyn_defaultmaxunits).|
|Attributes  | - msdyn_agentcapacityprofileunit.msdyn_defaultmaxunits |
|Filters  | None ​|

### Related metrics

- [Available capacity](#available-capacity)

## Assigned capacity profile count

*Applies to Omnichannel real-time dashboards.*

Assigned capacity profile count is the number of representatives who have an assigned capacity profile and aren't currently in **Offline** status.

### DAX query and Dataverse reference

```dax

Assigned capacity profile count = SUMX (FactAgentCapacityProfile,IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- DimAgentPresence - [msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence); FactAgentCapacityProfile -[msdyn_agentcapacityprofileunit](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit)|
|Attributes  | - [msdyn_presence.msdyn_basepresencestatus](/dynamics365/developer/reference/entities/msdyn_presence#msdyn_basepresencestatus-choicesoptions) |
|Filters  | - msdyn_presence.msdyn_basepresencestatus isn't set to 192360004 (Status isn't set to Offline). ​|

## Total work item capacity in use

*Applies to Omnichannel real-time dashboards.*

Total work item capacity in use is the representative's capacity occupied by active work items based on their profile settings.

### DAX query and Dataverse reference

```dax

Total work item capacity in use = SUM ( FactAgentCapacityProfile[OccupiedProfileUnits] )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_agentcapacityprofileunit](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit) for representative-specific capacity data along with [msdyn_capacityprofile](/dynamics365/developer/reference/entities/msdyn_capacityprofile) for default capacity values and blocking rules|
|Attributes  | - OccupiedProfileUnits : Difference between [msdyn_capacityprofile.msdyn_defaultmaxunits](/dynamics365/developer/reference/entities/msdyn_capacityprofile) and [msdyn_agentcapacityprofileunit.msdyn_availablecapacityprofileunits](/dynamics365/developer/reference/entities/msdyn_agentcapacityprofileunit?branch=ss-449106-csr#BKMK_msdyn_availablecapacityprofileunits) <br> - msdyn_capacityprofile <br> - msdyn_agentcapacityprofileunit|


### Related metrics

- **Total available work item capacity**: The maximum number of new work items that can be assigned.

## Load percentage in agent capacity profile

*Applies to Omnichannel real-time dashboards.*

A percentage measure that calculates agent capacity utilization. This metric is available only through visual or data model customization.

```dax

Load % : Divide ([Total work item capacity in use] by [Total agent work item capacity]) 

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit) - Stores per-agent capacity profile unit tracking <br> -   [msdyn_capacityprofile](/dynamics365//developer/reference/entities/msdyn_capacityprofile) - Stores capacity profile configuration|
|Attributes  |- [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit).[msdyn_availablecapacityprofileunits](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#BKMK_msdyn_availablecapacityprofileunits): Available capacity units for the agent <br>-  [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit).[msdyn_defaultmaxunits](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#BKMK_msdyn_availablecapacityprofileunits): Agent-specific maximum capacity units (overrides profile default if set) <br>- [msdyn_capacityprofile](/dynamics365//developer/reference/entities/msdyn_capacityprofile).[msdyn_defaultmaxunits](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#BKMK_msdyn_defaultmaxunits): Capacity profile default maximum units <br>- [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit).[msdyn_agentid](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#BKMK_msdyn_agentid): Agent (systemuser) <br>- [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit).[msdyn_capacityprofileid](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#BKMK_msdyn_capacityprofileid)|

### Related metrics

- [Total work item capacity in use](#total-work-item-capacity-in-use)
- [Total representative work item capacity](#total-representative-work-item-capacity)
- **Total available capacity units**: The number of capacity units that are available to handle conversations.

## Available capacity

The total number of unoccupied capacity profile units currently available, indicating the remaining capacity for new work item assignments.

```dax

SUM(FactAgentCapacityProfile[AvailableProfileUnits])

```

Element|Value  |
|---------|---------|
|Dataverse entities |- [msdyn_agentcapacityprofileunit](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit): Stores per agent capacity profile unit tracking <br> - [msdyn_capacityprofile](/dynamics365//developer/reference/entities/msdyn_capacityprofile): Stores capacity profile configuration |
|Attributes| [msdyn_availablecapacityprofileunits](/dynamics365//developer/reference/entities/msdyn_agentcapacityprofileunit#msdyn_availablecapacityprofileunits)|

## Logged in service representatives

*Applies to Omnichannel real-time dashboards.*

Logged in service representatives is the number of representatives who are currently logged in and aren't in **Offline** status.

### DAX query and Dataverse reference

```dax

Logged in agents = SUMX ( FactAgentCapacityUnit,IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities |- DimAgentPresence-[msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence) <br> - FactAgentCapacityUnit-[msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus) along with [systemuser](/dynamics365/developer/reference/entities/systemuser)|
|Attributes  | - [msdyn_presence.msdyn_basepresencestatus](/dynamics365/developer/reference/entities/msdyn_presence#msdyn_basepresencestatus-choicesoptions) <br> - [mdyn_agentstatus.msdyn_availableunitscapacity](/dynamics365/developer/reference/entities/msdyn_agentstatus#BKMK_msdyn_availableunitscapacity)|
|Filters  | - msdyn_presence.msdyn_basepresencestatus isn't set to 192360004 (Status isn't set to **Offline**) ​|


## Total service representatives

*Applies to Omnichannel real-time dashboards.*

The total number of service representatives with capacity data configured for routing and workload management.

### DAX query and Dataverse reference

```dax

Total agents = COUNTROWS(FactAgentCapacityUnit )

```

|Element|Value  |
|---------|---------|
|Dataverse entities |DimAgentPresence-msdyn_presence; FactAgentCapacityUnit - msdyn_agentstatus[msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus), along with [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes  | - [msdyn_agentstatus](/dynamics365/developer/reference/entities/msdyn_agentstatus) along with [systemuser](/dynamics365/developer/reference/entities/systemuser)|
|Filters  | - systemuser.msdyn_botapplicationid is NULL to exclude AI agents.​|

## Status duration

*Applies to Omnichannel real-time dashboards.*

Status duration shows how long representatives remain in a presence status, such as Available, Busy, or Away, during a selected time period. This duration is measured in minutes. For example, a representative in Busy status for 40 minutes shows a duration of 40.

### DAX query and Dataverse reference

```dax

Status duration (mins) = CALCULATE (SUM ( FactAgentStatusHistory[DuringInSeconds] ) / 60.00,USERELATIONSHIP ( FactAgentStatusHistory[PresenceId], DimAgentPresence[PresenceId] ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | - [msdyn_agentstatushistory](/dynamics365/developer/reference/entities/msdyn_agentstatushistory) along with [msdyn_presence](/dynamics365/developer/reference/entities/msdyn_presence)|
|Attributes  | - Calculates the difference between the [msdyn_agentstatushistory.msdyn_starttime](/dynamics365/developer/reference/entities/msdyn_agentstatushistory#BKMK_msdyn_starttime) and [msdyn_agentstatushistory.msdyn_endtime](/dynamics365/developer/reference/entities/msdyn_agentstatushistory#BKMK_msdyn_endtime). The real-time dashboard shows the current UTC time when a service representative is in their current status. The end time appears only after the status changes.|
|Filters  | - msdyn_agentstatushistory.createdon >= DATEADD(MI, -120, GETUTCDATE()). Only include records where the representative status was created within the last 120 minutes (2 hours).​|

## Consult

This metric represents the service representative in the **Consult** mode. The related metrics aren't available by default. Select **Edit report** to find the following metrics in your data model when you search for **Consult**. 

### Related metrics

- **Average consult time**: The average time that service representatives spend helping other service representatives on consult requests. It's calculated by dividing the total time spent by service representatives on these requests by the total number of consult requests accepted. You can display the average consult time in minutes.

- **Consult acceptance rate**: The percentage of sessions accepted by a service representative out of all the consult sessions requested.

- **Consult requests accepted**: The total number of consult sessions requested and accepted by a service representative.

- **Consult requests not accepted**: The total number of consult sessions requested but not accepted by a service representative. This happens when the representative doesn't join the consult.

-  **Consult not acceptance rate**: The percentage of consult sessions that a service representative didn't accept, including timed-out and rejected requests out of all the consult sessions requested. This happens when representative doesn't join the conversation.

- **Consult requests rejected**: The total number of consult sessions requested but rejected by a service representative.

- **Consult rejection rate**: The percentage of consult sessions rejected by a service representative out of all the requested sessions. This happens when representatives reject the consult.

- **Consults requested**: The total number of consult sessions requested.

- **Consult requests timed out**: The total number of consult sessions requested that timed out because the representative didn't respond.

- **Consult timed out rate**: The percentage of consult sessions that timed out because the service representative didn’t respond.

- **Consult time**: The time taken by service representatives to help other service representatives on consult requests. This metric can be viewed in minutes format. This metric is available only for the Omnichannel real-time analytics dashboard.

- **Consult sessions**: The total number of sessions with an ongoing consult. This metric is available only for the Omnichannel historical analytics dashboard.

## Consult acceptance rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of sessions accepted by a service representative out of all the requested consult sessions.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)


```dax

Consult acceptance rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedDateTime] <> BLANK() && FactSessionParticipant[ModeId] = "192350003",​ 1,​ 0​)),SUMX (FactSessionParticipant, 
IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode|
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode is Consult and msdyn_sessionparticipant.msdyn_joinedon isn't blank. |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult acceptance rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedDateTime] <> BLANK() && FactSessionParticipant[ModeId] = "192350003",​ 1,​ 0​)),SUMX (FactSessionParticipant, 
IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [systemuser](/dynamics365/developer/reference/entities/systemuser), [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)  |
|Attributes |- msdyn_sessionparticipant.msdyn_mode​ <br> - msdyn_sessionparticipant.msdyn_joinedon​ <br> - systemuser.msdyn_botapplicationid  |
|Filters  |- All conversations where FactSessionParticipant obtained from systemuser.msdyn_botapplicationid is null.​ <br> - msdyn_sessionparticipant.msdyn_joinedon isn't blank.​ <br> - msdyn_sessionparticipant.msdyn_mode is set to Consult.​|

---


## Consults requested

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Consult requested = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[ModeId] = "192350003", 1, 0  ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_mode
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode is set to Consult. |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requested = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[ModeId] = 192350003,1, 0  ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [systemuser](/dynamics365/developer/reference/entities/systemuser), [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)  |
|Attributes |- msdyn_sessionparticipant.msdyn_mode​ <br> - systemuser.msdyn_botapplicationid   |
|Filters  |- All conversations where FactSessionParticipant obtained from systemuser.msdyn_botapplicationid is null.​ <br> - msdyn_sessionparticipant.msdyn_mode is set to Consult. ​​|

---

## Consult requests accepted

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested and accepted by a service representative.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

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
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode is Consult and msdyn_sessionparticipant.msdyn_joinedon isn't blank. |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests accepted = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[AgentJoinedOn] <> BLANK() &&
FactSessionParticipant[ModeId] = 192350003,1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser)  |
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid |
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_joined isn't null or blank and​ msdyn_sessionparticipant.msdyn_mode is Consult.​ <br> - systemuser.msdyn_botapplicationid isn't null.​ ​​|

---

## Consult requests not accepted

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested but not accepted by a service representative.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests not accepted = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[AgentJoinedDateTime] ==
BLANK() && FactSessionParticipant[ModeId] = "192350003",1, 0 ) )

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where msdyn_sessionparticipant.msdyn_mode is Consult and msdyn_sessionparticipant.msdyn_joinedon is equal to blank.  |

### [Real-time analytics](#tab/realtimepage)


```dax

Consult requests not accepted = SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[AgentJoinedOn] == BLANK() &&
FactSessionParticipant[ModeId] = 192350003,​ 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_joinedon​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_joinedon is null or blank and​ msdyn_sessionparticipant.msdyn_mode is Consult​. <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Session participant consult rejection count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

Session participant consult rejection count is the total number of rejected consult sessions where the agent rejected the consult.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] == "AgentReject"
&& FactSessionParticipant[ModeId] = "192350003", 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentReject and​ msdyn_sessionparticipant.msdyn_mode is Consult. |

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests rejected = SUMX (​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] == "AgentReject"
&& FactSessionParticipant[ModeId] = "192350003", 1, 0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentReject and​ msdyn_sessionparticipant.msdyn_mode is Consult.​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Session participant consult rejection rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions rejected by a service representative out of all requested sessions.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

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
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentReject and​ msdyn_sessionparticipant.msdyn_mode is Consult. |

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
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentReject, msdyn_sessionparticipant.msdyn_mode is Consult​.  <br> - systemuser.msdyn_botapplicationid isn't null.​ ​​|

---


## Session participant consult timed out count

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of consult sessions requested that timed out because the representative didn't respond.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Consult requests timed out = SUMX(​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentTimeout" && FactSessionParticipant[ModeId] = "192350003", 1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout and​ msdyn_sessionparticipant.msdyn_mode is Consult.|

### [Real-time analytics](#tab/realtimepage)



```dax

Consult requests timed out = SUMX(​FactSessionParticipant,​ IF (FactSessionParticipant[LeftOnReason] ==
"AgentTimeout" && FactSessionParticipant[ModeId] = "192350003", 1,0 ))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout. <br> - msdyn_sessionparticipant.msdyn_mode is Consult.​ <br> - Session participant is defined by FactSessionParticipant where systemuser.msdyn_botapplicationid isn't null​. ​​|

---


## Session participant consult timed out rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

The total number of requested consult sessions that timed out because the representative didn't respond.

### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Consult timed out rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[LeftOnReason] == "AgentTimeout" &&
FactSessionParticipant[ModeId] = "192350003",​ 1, 0​)​),SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​ ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout and​ msdyn_sessionparticipant.msdyn_mode is Consult.|

### [Real-time analytics](#tab/realtimepage)



```dax

Consult timed out rate = DIVIDE(SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[LeftOnReason] == "AgentTimeout" &&
FactSessionParticipant[ModeId] = "192350003",​ 1, 0​)​),SUMX (​FactSessionParticipant,​ IF (​FactSessionParticipant[ModeId] = "192350003",​ 1,​ BLANK()​)​ ), BLANK())

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser)  |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout. <br> - msdyn_sessionparticipant.msdyn_mode is Consult.​ <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---


## Average consult time (min)​

The average time that service representatives spend helping other service representatives on consult requests. It's calculated by dividing the total time spent by service representatives on these requests by the total number of consult requests accepted. You can display the average consult time in minutes.


### DAX query and Dataverse reference

[!INCLUDE[dax-queries-for-metrics](../../includes/dax-queries-for-metrics.md)]

### [Historical analytics](#tab/historicalpage)



```dax

Avg. consult time (min) = ​CALCULATE (​DIVIDE (​IF (​SUM (FactSessionParticipant[TotalParticipantTimeMin] ) = BLANK (), 0, SUM ( FactSessionParticipant[TotalParticipantTimeMin] )​), [Consult requests accepted]))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant)|
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode
|Filters  |-  All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout and​ msdyn_sessionparticipant.msdyn_mode is Consult.|

### [Real-time analytics](#tab/realtimepage)



```dax

Avg. consult time (sec) = 
AVERAGEX(FactSessionParticipant, IF(FactSessionParticipant[AgentJoinedOn] <> BLANK() && FactSessionParticipant[ModeId] = 192350003, FactSessionParticipant[ParticipationTimeInSeconds], BLANK()))

```

|Element|Value  |
|---------|---------|
|Dataverse entities | [msdyn_sessionparticipant](/dynamics365/developer/reference/entities/msdyn_sessionparticipant), [systemuser](/dynamics365/developer/reference/entities/systemuser) |
|Attributes |- msdyn_sessionparticipant.msdyn_leftonreason​ <br> - msdyn_sessionparticipant_msdyn_mode​ <br> - systemuser.msdyn_botapplicationid|
|Filters  |- All conversations where ​msdyn_sessionparticipant.msdyn_leftonreason is AgentTimeout. <br> - msdyn_sessionparticipant.msdyn_mode is Consult.​ <br> - systemuser.msdyn_botapplicationid isn't null​. ​​|

---

## Related information

[Customize visual display](../use/customize-reports.md#customize-visual-display)  
[Calculate conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics)  
[Calculate session metrics](calculate-session-metrics.md#calculate-session-metrics)
