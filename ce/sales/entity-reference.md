---
title: Table/entity reference for Sales Insights
description: Understand the operations you can perform for specific entities in predictive scoring in Microsoft Dynamics 365 Sales.
ms.date: 08/19/2022
ms.topic: article
author: udaykirang
ms.author: udag
---
# Sales insights table/entity reference 

Understand the operations you can perform for specific entities, each entity's default attributes, and the relationships between entities.

|Entity name|Description|
|------|------|
|[msdyn_PredictiveScore](developer-sp/msdyn_predictivescore.md)|This custom entity contains attributes such as, score, trend, grade, and score reasons. Use it to view information on views and forms, which has a relationship with lead and opportunity entities.|
|[msdyn_PredictiveModelScore](developer-sp/msdyn_predictivemodelscore.md)|This custom entity is used to generate scores for each model. For internal use only.|
|msdyn_PredictiveScoringCommon|The solution contains relationships from lead and opportunity to **msdyn_predictivescore**, and information on **msdyn_PredictiveScore** and **msdyn_PredictiveModelScore** entities. This is a common solution that holds information related to lead and opportunity scoring.|
|[msdyn_wkwcolleaguesforcontact](developer-sp/msdyn_wkwcolleaguesforcontact.md)|This custom entity contains interactions between your organization's users and contacts in Dynamics 365, through emails, calls, and so on. Dynamics 365 Sales uses this data to surface the who knows whom connection.|
|[msdyn_wkwcolleaguesforcompany](developer-sp/msdyn_wkwcolleaguesforcompany.md)|This custom entity contains interactions between your organization's users and accounts in Dynamics 365, through emails, calls, and so on. For example, when a seller receives an email from a domain that's associated with an account, a connection record will be created in this entity.|

### See also

- [Predictive lead scoring](configure-predictive-lead-scoring.md)  
- [Predictive opportunity scoring](configure-predictive-opportunity-scoring.md)
- [WKWDeleteGDPRData custom action](developer/reference/custom-actions/msdyn_WKWDeleteGDPRData.md)
- [msdyn_WKWGDPRDeleteStatus custom action](developer/reference/custom-actions/msdyn_WKWGDPRDeleteStatus.md)
