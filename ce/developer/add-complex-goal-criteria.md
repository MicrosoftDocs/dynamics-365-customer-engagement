---
title: "Add complex goal criteria (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "A rollup query (GoalRollupQuery) entity can be used to add complex rollup criteria for a goal"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "adding complex goal criteria"
  - "goal management entities, preventing double counting and other rollup query errors"
  - "goal management entities, complex goal criteria"
  - "rollup queries for adding complex goal criteria"
  - "goal management entities, adding complex goal criteria"
  - "goal management entities, rollup queries for adding complex goal criteria"
  - "rollup queries for adding complex goal criteria, attributes and guidelines for setting; including propagation"
ms.assetid: 2498859c-ca85-4893-ba08-b02ceb75278b
caps.latest.revision: 20
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Add complex goal criteria

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

If you want to add complex rollup criteria for a goal, you can use a rollup query (`GoalRollupQuery`) entity. For example, you can specify revenue for a particular product line or revenue generated in a specific territory.  
  
 A rollup query can be used by different goals. However, a rollup query associated with a particular goal, applies only to that goal. A rollup query specified for a parent goal does not propagate to the child goal. A child goal can use the same query or a different query. A rollup query should use the same entity types that are specified in the rollup field records associated with the goal. If the goal tracks the sales order revenues, but the associated query uses the opportunity entity, an exception is thrown when you create or update the goal record.  
  
> [!NOTE]
>  The maximum number of records that can be returned in a goal rollup query is 5000.  
  
 To specify query criteria, use the `GoalRollupQuery.FetchXml` attribute. To specify the entity type for the query, use the `GoalRollupQuery.QueryEntityType` attribute.  
  
> [!NOTE]
>  The entities that can be specified in the `GoalRollupQuery.QueryEntityType` attribute must have the following `EntityMetadata` attributes set to `true`: `IsValidForAdvancedFind`, `IsUserOwned`, `IsCustomizable` and `CanCreateAttributes`. The following entities cannot be specified in this attribute: `SharePointDocumentLocation`, `SharePointSite` and `MailMergeTemplate`.  
  
 Depending on the goal metric type, you can use the queries to filter actual, in-progress, and custom amount or count data. The following table shows the goal metric types and the goal entity attributes that you can use to specify the queries for each type.  
  
|Goal metric type|Rollup query attributes|  
|----------------------|-----------------------------|  
|Amount (money)|`Goal.RollUpQueryActualMoneyId`<br /><br /> `Goal.RollUpQueryCustomMoneyId`<br /><br /> `Goal.RollUpQueryInprogressMoneyId`|  
|Amount (integer) or Count|`Goal.RollupQueryActualIntegerId`<br /><br /> `Goal.RollUpQueryCustomIntegerId`<br /><br /> `Goal.RollUpQueryInprogressIntegerId`|  
|Amount (decimal)|`Goal.RollUpQueryActualDecimalId`<br /><br /> `Goal.RollUpQueryCustomDecimalId`<br /><br /> `Goal.RollUpQueryInprogressDecimalId`|  
  
 The query for the goal's participating records for a given rollup attribute should include the following clauses:  
  
-   A `Goal.ConsiderOnlyGoalOwnersRecords` value.  
  
-   A FetchXML expression specified in `GoalRollupQuery.FetchXml`.  
  
-   Date range (`RollupField.DateAttribute`), state and status specified in the respective rollup field for the referenced goal metric.  
  
## Preventing Double Counting and Other Erroneous Results  
 Queries are very effective in filtering the results of a rollup. However, if not used carefully, they can introduce the “double counting” or other erroneous results. The following examples demonstrate how queries may contribute in unwanted results:  
  
- You are tracking the sales orders for a particular salesperson. However, the rollup did not return any sales orders. This can happen if the query that you used filtered out the territories where the salesperson has customers.  
  
- You set two goals for a salesperson. One goal tracks the opportunities for a particular product and another goal tracks the opportunities in a particular territory. If the opportunity includes selling the specified product in the specified territory, the revenue from this opportunity is included in both goals. If the goals have the same parent goal, their totals are added to the parent goal, resulting in double counting.  
  
  You can prevent double counting and other incorrect results by following these guidelines:  
  
- Set the `Goal.ConsiderOnlyGoalOwnersRecords` attribute to `true` to use only the records owned by the goal owner.  
  
- Do not assign multiple goals to a sales person for the same time period.  
  
- Do not use a query if you are not sure it will provide the results that you expect.  
  
### See also  
 [Goal Management Entities](goal-management-entities.md)   
 [Sample: Use Rollup Queries to Track Goals](sample-use-rollup-queries-track-goals.md)   
 [Roll Up Goal Totals](roll-up-goal-totals.md)
