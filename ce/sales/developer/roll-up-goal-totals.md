---
title: Roll up goal totals
description: RecalculateRequest message can be used to roll up data in a goal hierarchy. It recalculates the goal rollup field values, such as Goal.ActualMoney or Goal.ActualInteger, for all goals in the hierarchy.
ms.date: 04/30/2026
ms.topic: how-to
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---

# Roll up goal totals

To roll up data in the goal hierarchy, use the SDK [RecalculateRequest class](xref:Microsoft.Crm.Sdk.Messages.RecalculateRequest) or Web API `Recalculate` action. These options recalculate the goal rollup field values, such as `Goal.ActualMoney` or `Goal.ActualInteger`, for all goals in the hierarchy. The system performs a rollup for each goal in the context of the goal manager. This context means that only the records that a manager of a goal has Read access to participate in the rollup. The system automatically switches the manager's context for each goal during rollup, as every goal might have a different goal manager.  
  
The totals roll up from the child goals to the parent goals, from the bottom of the hierarchy to the top. The ending total for the root goal at the top of the hierarchy is an aggregate sum of all totals in the hierarchy. For example, if the revenue metric is used, the total is an aggregate sum of the money amounts. If a count metric is used, the total is an aggregate count of the actual records in the system, such as telephone calls. Regardless of which particular goal is a target of the recalculate operation, all totals in a given hierarchy are updated.  
  
If you set `Goal.RollupOnlyFromChildGoals` to `true`, only child goal records are used in the rollup. If you set it to `false`, the rollup includes the child records and other goal's participating records. A participating record must satisfy the following conditions:  
  
-   The source date of the record must be between the start date and the end date of the goal time period, or fall on the start date or the end date of the goal period.  
  
-   The state and status of the record must match the values defined in the goal metric.  
  
-   If a rollup query is specified for the goal, all query conditions must be met.  
  
-   The goal manager must have Read access to the record.  
  
> [!NOTE]
>  The goal rollup fields that don't participate in the rollup aren't updated, and their values are **null**.  
  
 To specify the rollup expiration time, use the `Organization.GoalRollupExpiryTime` column. For example, if you set the rollup expiration time to six months, the system doesn't automatically roll up goals older than six months. To specify the frequency of goal rollup, use the `Organization.GoalRollupFrequency` column. Set the frequency on an hourly basis. By default, the goal actual values are recalculated every 24 hours.  
  
## Override calculated values
  
 To override the system calculated actual, in-progress, or custom goal rollup field values, update the goal record. Set the `Goal.IsOverride` column to `true` to notify the system that it can update the rollup field values. To signal the system that the goal's rollup field values were overridden and must not be updated during next recalculate operation, set the `Goal.IsOverridden` column to `true`. If `Goal.IsOverride` is `false`, an exception is thrown during the update operation. If `Goal.IsOverridden` is `false`, the goal rollup field values are overwritten during next recalculate operation with system calculated values.  
  
## Related information

 [Goal Management Tables](goal-management-entities.md)   
 [Sample: Roll Up Goal Data for a Custom Period Against the Target Revenue](sample-rollup-goal-data-custom-period-target-revenue.md)   
 [Sample: Roll Up Goal Data for a Fiscal Period Against the Stretch Target Count](sample-rollup-goal-data-fiscal-period-stretch-target-count.md)   
 [Goal table](../../developer/reference/entities/goal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
