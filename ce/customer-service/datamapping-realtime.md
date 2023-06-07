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
