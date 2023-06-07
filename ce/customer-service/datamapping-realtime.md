---
title: Data mapping for real-time analytics
description: Learn about data mapping for real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 06/07/2023
ms.custom: bap-template
---

# Data mapping for real-time analytics

This article describes the Data Analysis Expressions (DAX) logic for real-time metrics. More information: [Data Analysis Expressions (DAX) Reference](https://learn.microsoft.com/en-us/dax/)

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
- Avg. speed to answer time (sec):
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
- Conversation first wait time (sec): 
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
- Conversation id: Attribute
- Conversations in queue: 
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
- ConversationTalkTimeInSeconds: Attribute 
- Created on: Attribute 
- Incoming conversation: 
```
SUMX ( FactConversation, IF ( NOT 
FactConversation[DirectionCode], 1, 0 ) )
```
- Longest wait time (sec):
```
AXX(FactConversation, IF(NOT 
FactConversation[DirectionCode], 
FactConversation[CurrentWaitTimeInSeconds], BLANK())) 
```
- Ongoing conversations:
```
SUMX ( FactConversation, IF (
 FactConversation[IsOngoing], 1, 0 ) ) 
```
- Open conversations: 
```
SUMX ( FactConversation, IF (
 FactConversation[statuscode] == 1, 1, 0 ) )
```
- Sentiment: Attribute
- Service level (10 seconds): 
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
- Service level (120 seconds): Similar to Service level (10 seconds)  
- Service level (20 seconds): Similar to Service level (10 seconds)  
- Service level (30 seconds): Similar to Service level (10 seconds)  
- Service level (40 seconds): Similar to Service level (10 seconds)  
- Service level (60 seconds): Similar to Service level (10 seconds)  
- Title: Attribute
- Total conversations: `COUNTROWS(FactConversation)`
- Waiting conversations: 
```
SUMX ( FactConversation, IF ( 
FactConversation[statuscode] == 3, 1, 0 ) )
```
- Wrap-up conversations:
```
 SUMX ( FactConversation, IF ( 
FactConversation[statuscode] == 5, 1, 0 ) )
```