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

**Need info**

```


|Element|Value  |
|---------|---------|
|Dataverse entities | |
|Attributes | |
|Filters  | |

### [Real-time analytics](#tab/realtimepage)

**DAX query**

```dax

**Need info**

```

|Element|Value  |
|---------|---------|
|Dataverse entities |    |
|Attributes  |        |
|Filters  | |
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

## Sessions rejected rate

*Applies to Omnichannel real-time and Omnichannel historical dashboards.*

**Need info**

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
|Dataverse entities |    |
|Attributes  |        |
|Filters  | |
---


## Next steps


