---
title: Data mapping for real-time analytics
description: Learn about data mapping for real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 06/09/2023
ms.custom: bap-template
---

# Data mapping for real-time analytics

This article describes the Data Analysis Expressions (DAX) logic for real-time metrics. More information: [DAX function reference](/dax/dax-function-reference)

For details on real-time metrics, go to [Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)

## FactConversation

- Abandoned conversations

``` 
    SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[IsAbandoned] 
                && FactConversation[StatusCode] == 4 
                && NOT FactConversation[DirectionCode], 
            1, 
            0 
        ) 
    ) 
```
- Abandoned rate

 ```
DIVIDE ( 
    SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[IsAbandoned] 
                && NOT FactConversation[DirectionCode], 
            1, 
            0 
        ) 
    ), 
    SUMX ( 
        FactConversation, 
        IF ( NOT FactConversation[DirectionCode], 1, BLANK () ) 
    ), 
    BLANK () 
) 
```
- Active conversations awaiting agent acceptance

```
SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[statuscode] = 2 
                && FactConversation[StatusReason] == "Agent assigned, awaiting acceptance", 
            1, 
            0 
        ) 
    ) 
``` 
- Active conversations with agent acceptance 

```
SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[statuscode] = 2 
                && FactConversation[StatusReason] == "In conversation", 
            1, 
            0 
        ) 
    ) 
```
- Avg. conversation first wait time (sec)

```
    AVERAGEX(FactConversation, IF(NOT 
FactConversation[DirectionCode], BLANK(),
FactConversation[ConversationFirstWaitTimeInSeconds] 
))

```

- Avg. conversation hold time (sec): `AVERAGE(FactConversation[ConversationHoldTimeInSeconds])`
- Avg. conversation talk time (sec): `AVERAGE(FactConversation[ConversationTalkTimeInSeconds])`
- Avg. conversation time (sec): `AVERAGE ( FactConversation[ConversationTimeInSeconds] )`
- Avg. conversation wrap up time: ` AVERAGE(FactConversation[ConversationWrapUpTimeInSeconds])`
- Avg. handle time (sec): `AVERAGE(FactConversation[ConversationHandleTimeInSeconds])`
- Avg. speed to answer time (sec)
```
AVERAGEX ( 
    FactConversation, 
    IF ( 
        FactConversation[IsAgentAccepted] 
            && NOT FactConversation[DirectionCode], 
        FactConversation[ConversationSpeedToAnswerInSeconds], 
        BLANK () 
    ) 
) 
```
- Closed conversation: `SUMX ( FactConversation, IF ( FactConversation[StatusCode] == 4, 1, 0 ) )`
- Conversation first wait time (sec) 
```
SUMX ( 
    FactConversation, 
    IF ( 
        NOT FactConversation[DirectionCode], 
        FactConversation[ConversationFirstWaitTimeInSeconds], 
        BLANK () 
    ) 
) 
```
- Conversation handle time (sec): `SUM(FactConversation[ConversationHandleTimeInSeconds]`
- Conversations in queue 
```
Conversations in queue =  
    SUMX ( 
        FactConversation, 
        IF ( 
            NOT FactConversation[DirectionCode] 
                && ( FactConversation[StatusCode] == 1 
                || ( FactConversation[StatusCode] == 2 
                && FactConversation[StatusReason] == "Agent assigned, awaiting acceptance" ) ), 
            1, 
            0 
        ) 
    )
```
- Incoming conversation 
```
SUMX ( FactConversation, IF ( NOT 
FactConversation[DirectionCode], 1, 0 ) )
```
- Longest wait time (sec)
```
AXX(FactConversation, IF(NOT 
FactConversation[DirectionCode], 
FactConversation[CurrentWaitTimeInSeconds], BLANK())) 
```
- Ongoing conversations
```
SUMX ( FactConversation, IF (
 FactConversation[IsOngoing], 1, 0 ) ) 
```
- Open conversations 
```
SUMX ( FactConversation, IF (
 FactConversation[statuscode] == 1, 1, 0 ) )
```
- Service level (10 seconds) 
```
DIVIDE ( 
    SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[ConversationFirstWaitTimeInSeconds] <= 10 
                && FactConversation[IsAgentAccepted] 
                && NOT FactConversation[DirectionCode], 
            1, 
            0 
        ) 
    ), 
    SUMX ( 
        FactConversation, 
        IF ( 
            FactConversation[IsAgentAccepted] 
                && NOT FactConversation[DirectionCode], 
            1, 
            0 
        ) 
    ), 
    BLANK () 
) 
```
- Total conversations: `COUNTROWS(FactConversation)`
- Waiting conversations
```
SUMX ( FactConversation, IF ( 
FactConversation[statuscode] == 3, 1, 0 ) )
```
- Wrap-up conversations
```
 SUMX ( FactConversation, IF ( 
FactConversation[statuscode] == 5, 1, 0 ) )
```

## FactSession

- Active sessions: `SUMX(FactSession, IF(FactSession[SessionStateCode] = 192350001, 1, 0))`

- Avg. session handle time (sec): `AVERAGE(FactSession[AgentHandlingTimeInSeconds])`

- Closed sessions: `SUMX(FactSession, IF(FactSession[SessionStateCode] = 192350002, 1, 0))`

- Engaged sessions: `SUMX(FactSession, IF(ISBLANK(FactSession[AgentAcceptedOn]), 0, 1))`

- Rejected sessions: ` SUMX(FactSession, IF(FactSession[SessionClosureReasonCode] == 192350001, 1, 0))`

- Session handle time (sec): `SUM(FactSession[AgentHandlingTimeInSeconds])`

- Session rejection rate
```
DIVIDE ( 

    SUMX ( 

        FactSession, 

        IF ( FactSession[SessionClosureReasonCode] == 192350001, 1, 0 ) 

    ), 

    SUMX ( 

        FactSession, 

        IF ( FactSession[SessionStateCode] == 192350002, 1, BLANK () ) 

    ), 

    BLANK () 

) 
```
- Session time to accept (sec): `SUM(FactSession[TimeToAcceptInSeconds])`
- Session time to reject (sec): `SUM(FactSession[TimeToRejectInSeconds])`
- Session timeout rate
```
DIVIDE ( 

    SUMX ( 

        FactSession, 

        IF ( FactSession[SessionClosureReasonCode] == 192350002, 1, 0 ) 

    ), 

    SUMX ( 

        FactSession, 

        IF ( FactSession[SessionStateCode] == 192350002, 1, BLANK () ) 

    ), 

    BLANK () 

) 
```
- Session transfer rate
```
DIVIDE ( 

    SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) ), 

    SUMX ( 

        FactSession, 

        IF ( ISBLANK ( FactSession[AgentAcceptedOn] ), BLANK (), 1 ) 

    ), 

    BLANK () 

) 
```
- Session wait time (sec): `SUM(FactSession[SessionWaitTimeInSeconds])`
- Timeout sessions 
```
SUMX(FactSession, IF(FactSession[SessionStateCode] = 192350002 && FactSession[SessionClosureReasonCode] = 192350002, 1, 0))
```
- Total sessions: `COUNTROWS()`
- Transferred sessions: `
 SUMX ( FactSession, IF ( FactSession[IsTransferredOut], 1, 0 ) )`

## FactSessionParticipant 
- Session participant count: `COUNTROWS(FactSessionParticipant)`

## FactAgentStatusHistory 
- Status duration (mins)
```
CALCULATE ( 

    SUM ( FactAgentStatusHistory[DuringInSeconds] ) / 60.00, 

    USERELATIONSHIP ( FactAgentStatusHistory[PresenceId], DimAgentPresence[PresenceId] ) 

) 
```

## FactAgentCapacityProfile

- Assigned capacity profile count 
```
SUMX ( 

        FactAgentCapacityProfile, 

        IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ) 

    ) 
```
- Available capacity
```
SUMX ( 

        FactAgentCapacityProfile, 

        IF ( 

            NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 

            FactAgentCapacityProfile[AvailableProfileUnits], 

            0 

        ) 

    )
```
- Total capacity: `SUM ( FactAgentCapacityProfile[DefaultMaxProfileUnits] )`
- Total work item capacity in use: `SUM ( FactAgentCapacityProfile[OccupiedProfileUnits] )`

### FactAgentCapacityUnit

- Logged in agents
```
SUMX ( 

        FactAgentCapacityUnit, 

        IF ( NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 1, 0 ) 

    ) 
```
- Total agents: `COUNTROWS ( FactAgentCapacityUnit )`
- Total capacity: `SUM ( FactAgentCapacityUnit[DefaultMaxCapacityUnits] )`
- Units available
```
SUMX ( 

        FactAgentCapacityUnit, 

        IF ( 

            NOT RELATED ( DimAgentPresence[BasePresenceStatusId] ) == 192360004, 

            FactAgentCapacityUnit[AvailableCapacityUntis], 

            0 

        ) 

    )
```
- Units occupied: `SUM ( FactAgentCapacityUnit[OccupiedCapacityUnits] )`

## FactConversationMessageBlock 

- Agent response service level (60 seconds) 

```
DIVIDE ( 

    SUMX ( 

        FactConversationMessageBlock, 

        IF ( 

            FactConversationMessageBlock[ReponseTimeInSecondsAdjustedForOperationHour] <= 60, 

            1, 

            0 

        ) 

    ), 

    COUNTROWS ( FactConversationMessageBlock ), 

    BLANK () 

)
```
- Average agent response time (sec): `AVERAGE( FactConversationMessageBlock[AgentReponseTimeInSecondsAdjustedForOperationHour])`

- Average first response time (sec) 
```
AVERAGEX ( 

    FactConversationMessageBlock, 

    IF ( 

        FactConversationMessageBlock[IsFirstResponseTime], 

        FactConversationMessageBlock[ReponseTimeInSecondsAdjustedForOperationHour], 

        BLANK () 

    ) 

) 
```
- First response time

```
DIVIDE ( 

    SUMX ( 

        FactConversationMessageBlock, 

        IF ( 

            FactConversationMessageBlock[ReponseTimeInSecondsAdjustedForOperationHour] <= 60 

                && FactConversationMessageBlock[IsFirstResponseTime], 

            1, 

            BLANK () 

        ) 

    ), 

    SUMX ( 

        FactConversationMessageBlock, 

        IF ( FactConversationMessageBlock[IsFirstResponseTime], 1, BLANK () ) 

    ), 

    BLANK () 

)
```

## See Also
[Customize visual display](customize-reports.md#customize-visual-display) 
[Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service)  
[Overview of data model customization](datamodel-overview.md#overview-of-data-model-customization)  
[Customize data models of historical and real-time analytics reports](model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)