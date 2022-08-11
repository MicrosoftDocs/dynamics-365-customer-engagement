---
title: "Entity reference for Sales Insights | MicrosoftDocs"
description: "Use the entity reference to understand the available operations that can be performed for specific entities in predictive scoring."
ms.date: 08/11/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Entity reference for Sales Insights 

Use this reference to understand the available operations that can be performed for specific entities, the default attributes of each entity and the relationships between entities.

|Entity name|Description|
|------|------|
|[msdyn_PredictiveScore](developer-sp/msdyn_predictivescore.md)|The custom entity contains attributes such as, score, trend, grade, and score reasons. You can use the entity to view information on views and forms, which has a relationship with lead and opportunity entities.|
|[msdyn_PredictiveModelScore](developer-sp/msdyn_predictivemodelscore.md)|The custom entity used to generate scores for each model. For internal use only.|
|msdyn_PredictiveScoringCommon|The solution contains relationships from lead and opportunity to **msdyn_predictivescore**, and information on **msdyn_PredictiveScore** and **msdyn_PredictiveModelScore** entities. This is a common solution that holds information related to lead and opportunity scoring.|
|[msdyn_wkwcolleaguesforcontacts](/developer-sp/msdyn_wkwcolleaguesforcontact.md)|This custom entity contains interactions between your organization's users and contacts in Dynamics 365, through emails, calls, and so on. Dynamics 365 Sales uses this data to surface the who knows whom connection.|
|[msdyn_wkwcolleaguesforcompanies](developer-sp/msdyn_wkwcolleaguesforcompany)|This custom entity contains interactions between your organization's users and accounts in Dynamics 365, through emails, calls, and so on. For example, when a seller receives an email from a domain that's associated with an account, a connection record will be created in this entity.|

### See also

- [Predictive lead scoring](configure-predictive-lead-scoring.md)  
- [Predictive opportunity scoring](configure-predictive-opportunity-scoring.md)
- [WKWDeleteGDPRData custom action](developer/reference/custom-actions/msdyn_WKWDeleteGDPRData.md)
- [msdyn_WKWGDPRDeleteStatus custom action](developer/reference/custom-actions/msdyn_WKWGDPRDeleteStatus.md)