---
title: Create goal hierarchy, goals, and targets (Dynamics 365 Sales)
description: This article discusses how to create a goal hierarchy, set and monitor the targets, specify the time period and who manages and owns a goal.
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
# Create goal hierarchy, goals, and targets

Before you start goal management, specify a metric for a goal (amount or count), create a goal hierarchy, and set the targets. All goals in the hierarchy must be based on the same goal metric. A metric defines the type of the goal, and the rollup fields specify other important settings for the goal. For more information, see [Use Goal Metric and Rollup Fields to Define a Goal](define-goal-metric-rollup-fields.md).  

<a name="BKMK_CreateHierarchy"></a>   
## Create goal hierarchy  
 Typically, the manager’s goal aggregates the goals assigned to the team members. A manager decides on the overall goal for the organization and then divides the goal into individual goals for each person. In a large organization, a goal for the company could be a combination of regional goals. In the simple goal hierarchy shown here, the manager’s goal is composed of two salesperson goals.  
  
 :::image type="content" source="../media/crm-v5s-em-goalshierarchy.png" alt-text="Screenshot of goals hierarchy.":::  
  
 The manager’s goal is the parent goal, and the salesperson goals are the child goals. A goal can have multiple child goals (one-to-many relationship) and be a child goal of another goal. The relationship between a parent goal record and a child goal record is also a referential relationship, in which a child goal references the parent goal. If you delete a parent goal, the child goal isn't deleted. Only the reference to the parent goal is removed. For more information, see [Table relationship behavior](/power-apps/maker/data-platform/create-edit-entity-relationships#table-relationship-behavior).  
  
 The goal rollup happens from the bottom of the hierarchy to the top of the hierarchy. During rollup, the child goal totals roll into the parent goal totals. The ending total for the root goal at the top of hierarchy is a cumulative sum of all goal totals in the hierarchy.  
  
<a name="BKMK_WhoManages"></a>   
## Who manages and owns a goal  
 A goal manager sets or modifies goal targets, adjusts the goal time period, and assigns a goal owner. A goal manager is the goal record owner (`Goal.OwnerID`) with full access rights to the goal. A goal owner (`Goal.GoalOwnerId`) is someone who has to meet the goal targets. A goal owner has Read and AppendTo access to the goal.  
  
 When you create a goal in Dynamics 365, you automatically share it with a goal owner and a parent goal’s manager. A parent goal’s manager is the record owner (`Goal.OwnerId`) of the parent goal, and has Read access to the newly created goal. When you replace a parent goal’s manager or a goal owner, you revoke their access to the goal and grant the access to the new parent goal’s manager or goal owner. If you explicitly shared a goal with a previous parent goal’s manager and goal owner, and gave them specific access rights, these Dynamics 365 users might not lose all access to the goal.  
  
<a name="BKMK_SetTargets"></a>   
## Set and monitor the targets  
 For each goal, specify a target value to measure the results of the goal rollup. You can also specify a stretch target. For example, your target revenue could be $100,000, and the stretch target revenue is $120,000.  
  
 Logically, the target values should increase toward the top of the goal hierarchy to reflect an upward increase of cumulative totals in the hierarchy.  
  
 Depending on the type of rollup data, use one of the following goal table attributes to set the targets: `Goal.TargetInteger`,  `Goal.TargetDecimal`, or `Goal.TargetMoney`. To set the stretch targets, use:   `Goal.StretchTargetInteger`, `Goal.StretchTargetDecimal`, or `Goal.StretchTargetMoney`.  
  
 The following table lists the system-generated values that you can use to measure your progress against the target.  
  
|Goal table column|Description|Formula|  
|---------------------------|-----------------|-------------|  
|`Goal.Percentage`|Percentage achieved against the target goal.|(Actual/Target) * 100|  
|`Goal.ComputedTargetAsOfTodayPercentageAchieved`|Expected value for percentage achieved against the target goal.|100 * (Today’s date – Start date)/(End date – Start date)|  
|`Goal.ComputedTargetAsOfTodayInteger`|Expected amount for Actual (integer) against the target goal.|Target (integer) * (Today’s date – Start date)/(End date – Start date)|  
|`Goal.ComputedTargetAsOfTodayDecimal`|Expected amount for Actual (decimal) against the target goal.|Target (decimal) * (Today’s date – Start date)/(End date – Start date)|  
|`Goal.ComputedTargetAsOfTodayMoney`|Expected amount for Actual (money) against the target goal.|Target (money) * (Today’s date – Start date)/(End date – Start date)|  
  
> [!NOTE]
>  The system-generated values are calculated against the target value. They aren't calculated against the stretch target value.  
  
<a name="BKMK_specifytime"></a>   
## Specify the time period  
 For each goal, specify a particular fiscal period or a custom time period. To select the fiscal period or custom period, use the `Goal.IsFiscalPeriodGoal` column. If you select a fiscal period, specify a fiscal year by using the `Goal.FiscalYear` column. The possible values for this column are defined in the  `goal_fiscalyear` global option set. Specify a fiscal period, such as quarter or semi-annual, in the `Goal.FiscalPeriod` column. The possible values for this column are defined in the `goal_fiscalperiod` global option set.  
  
 The goal’s fiscal year and fiscal period are tied to the organization’s fiscal year settings that are defined in the `Organization` table. You can redefine the fiscal year settings for the organization at any time. If the settings change, you can continue to use the existing goals with the old fiscal settings or you can realign them with the new fiscal settings.  
  
> [!IMPORTANT]
>  To realign, update the hierarchy’s root goal with the new fiscal year and fiscal period values by using the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message.  
  
 The fiscal year and fiscal period values are defined in the `goal_fiscalperiod` global option set. You can only create new goals by using the current fiscal year settings for the organization.  
  
 If you select a custom period for the goal, specify the goal start and end dates by using the `Goal.GoalStartDate` column and the `Goal.GoalEndDate` column.  
  
 If you use a custom period, the `Goal.FiscalYear` and `Goal.FiscalPeriod` values are ignored. If you use a fiscal period, the start and end dates for the custom period are ignored.  
  
 All goals in the goal hierarchy must be based on the same fiscal period or custom period. If you specify a different time period for a child goal, a time period for a parent goal is used.  
  
<a name="BKMK_other"></a>   
## Other important settings  
 Other important goal settings include the following options:  
  
-   Specify a parent goal for the goal by using the `Goal.ParentGoalId` column. If you delete a parent goal, the child goal isn't deleted. The system replaces the parent goal GUID value with a null value.  
  
-   Specify to roll up data only from the child goals by setting `Goal.RollupOnlyFromChildGoals` to `true`. If set to `false`, data is rolled up from the child goals, and from the goal’s participating records specified in the goal’s metric and rollup query. For more information about the goal metric and the rollup query, see [Define Goal Metric and Perform Data Roll Up](define-goal-metric-rollup-fields.md) and [Add Complex Goal Criteria](add-complex-goal-criteria.md).  
  
-   Specify whether you want to roll up data from all available records or only from goal owner’s records by using the `Goal.ConsiderOnlyGoalOwnersRecords` column. For example, you can specify to roll up data only from the closed opportunities owned by the goal’s owner, instead of rolling up data from all closed opportunities.  
  
## Related information  
 [Goal Management Entities](goal-management-entities.md)   
 [Define Goal Metric and Rollup Fields](define-goal-metric-rollup-fields.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
