---
title: "Entity reference for Sales Insights | MicrosoftDocs"
description: "Reference documentation for the Sales Insights entities"
ms.date: 11/10/2020
ms.service: crm-online
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Entity reference for Sales Insights

Use this reference to understand the available operations that can be performed for specific entities, the default attributes of each entity and the relationships between entities.

|Entity name|Description|
|------|------|
|[msdyn_PredictiveScore](developer/msdyn_predictivescore.md)|The custom entity contains attributes such as, score, trend, grade, and score reasons. You can use the entity to view information on views and forms, which has a relationship with lead and opportunity entities.|
|[msdyn_PredictiveModelScore](developer/msdyn_predictivemodelscore.md)|The custom entity used to generate scores for each model. For internal use only.|
|msdyn_PredictiveScoringCommon|The solution contains relationships from lead and opportunity to **msdyn_predictivescore**, and information on **msdyn_PredictiveScore** and **msdyn_PredictiveModelScore** entities. This is a common solution that holds information related to lead and opportunity scoring.|

### See also

[Predictive lead scoring](configure-predictive-lead-scoring.md)  
[Predictive opportunity scoring](configure-predictive-opportunity-scoring.md)