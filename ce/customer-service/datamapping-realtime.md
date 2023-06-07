---
title: Data mapping for real-time analytics
description: Learn about data mapping for real-time analytics.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 06/06/2023
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
Avg. speed to answer time (sec) =  
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
- 
