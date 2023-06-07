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

This article describes the DAX logic for the real-time metrics. For details on real-time metrics, go to [Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)

## FactConversation

### Abandoned conversations
```
Abandoned conversations =  

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

|Attribute Name | DAX logic |
|---------------|----------------------------------|
|Abandoned conversations |  |
|Abandoned rate  | |
|Active conversations awaiting agent acceptance | |
| Active conversations with agent acceptance | |
|Avg. conversation first wait time (sec)  | |
|Avg. conversation hold time (sec) | |
|Avg. conversation talk time (sec)  | |
|Avg. conversation time (sec)  | |
|Avg. conversation wrap up time  | |
|Avg. handle time (sec) | |
|Avg. speed to answer time (hh:mm:ss)  | |
|Avg. speed to answer time (sec) | |
|Avg. wait time  | |
|Closed conversation  | |
|Conv. time  | |
|Conversation first wait time (sec)  | |
|Conversation handle time (sec) | |
|Conversation id | |
|Conversations in queue  | |
|ConversationTalkTimeInSeconds | |
|Created on | |
|Incoming conversation  | |
|Longest wait time (sec)  | |
|Ongoing conversations  | |
|Open conversations  | |
|Sentiment | |
|Service level (10 seconds)  | |
|Service level (120 seconds)  | |
|Service level (20 seconds)  | |
|Service level (30 seconds)  | |
|Service level (40 seconds)  | |
|Service level (60 seconds) | |
|Title  | |
|Total conversations | |
|Waiting conversations | |
|Wrap-up conversations  | |

## FactSession






## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
