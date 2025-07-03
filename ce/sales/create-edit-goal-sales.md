---
title: Create or edit goals
description: Use goals to track your progress on achieving target revenue or other targets set by your organization. Propagate goals using parent and child goals.
ms.date: 07/02/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-goal
  - D365-Entity-metric
  - D365-Entity-goalrollupquery
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Create or edit goals

Goals help you measure progress toward key targets, such as revenue or other organizational objectives. In Dynamics 365 Sales, you can create and manage goals, set up parent-child goal relationships, and track actual results against targets. This article explains how to create or edit goals to monitor your team’s performance effectively.

## Create a goal

Use goals to keep track of your progress on achieving target revenue.

1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]

1. Select the site map icon :::image type="icon" source="media/site-map-icon.png" border="false":::, and then select **Goals** under **Performance**.

1. On the command bar, select **New**.

1. Fill in your information. Use the handy tooltips as a guide.

   - **Name**: Type a name that describes the goal.
   - **Parent Goal**: (Optional) If this goal is a child goal, select the parent goal. This allows you to roll up the results of this goal to the parent goal. If you select a parent goal, the **Goal Metric** and **Time Period** fields are automatically populated from the parent goal and can't be changed.
   - **Goal Metric**: Choose how the goal will be tracked by selecting a metric for the goal.
   - **Goal Owner**: Select the user or team responsible for meeting the goal.

   :::image type="content" source="media/goal-form.png" alt-text="Screenshot of the Goal form.":::

1. Select **Save**.

1. On the **Time Period** tab, specify whether the goal period is a fiscal period or a custom period.

   - If **Goal Period Type** is **Fiscal Period**, select a fiscal period and fiscal year for which the goal is tracked.
   - If **Goal Period** Type is **Custom Period**, select a date in the From and To fields to define a custom period for which the goal is tracked.

   :::image type="content" source="media/time-period-tab-goal-form.png" alt-text="Screenshot of the Time Period tab on the Goal form.":::

1. On the **Targets** tab, specify a target value against which the results of the goal rollup are measured. The target type depends on the **Amount Data Type** selected for the goal metric that you chose for this goal. You will see one of the following fields:

   - **Target (Decimal)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Decimal**.
   - **Target (Money)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data** Type is **Money**.
   - **Target (Integer)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data** Type is **Integer** or if the goal **Metric Type** is **Count**.

1. If the goal metric you are using has **Track Stretch Target** selected, you will also see one of the following fields:

   - **Stretched Target (Decimal)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Decimal**.
   - **Stretched Target (Money)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Money**.
   - **Stretched Target (Integer)**: Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Integer** or if the goal Metric Type is **Count**.

1. To add an existing goal as a child goal of this goal, on the **Child Goals** tab, select the **Add Existing Goal** button.

1. The **Actuals** tab shows the actual value achieved towards the target as of the last rolled-up date. Select **Recalculate** to update the actuals for the goal based on the latest data. 

   - **Actual (Money)**: If the goal metric uses **Money** as the **Amount Data Type**, this field shows the total amount of money achieved towards the goal as of the last rolled-up date.
   - **In-progress (Money)**: If the goal metric uses **Money** as the **Amount Data Type**, this field shows the amount of money achieved towards the goal since the last time the actuals were calculated.
   - **Percentage Achieved**: If the goal metric is **Decimal** or **Integer**, this field shows the percentage of the goal that is complete as of the last rolled-up date.
   - **Last Rolled Up Date**: This field shows the last date and time that the actuals were recalculated.

1. On the **Goal Criteria** tab, define the criteria that will be used for rolling up the Actuals data against the goal.

   - **Roll Up Only From Child Goals**: If you want to limit the data used for the roll up to only child goals, select **Yes**. To allow other data to be used for the roll ups, select **No**.
   - **Record Set for Rollup**: If you want to limit the records that can be included in the roll up to only those records owned by the goal owner, select **Owned by goal owner**. To allow all records to be included in the roll up data, select **All**.

1. On the **Notes** tab, enter any notes for this goal.

1. Select **Save** or **Save & Close**.

## Example scenario

In this example, let's create goals for your sales team to track their progress toward achieving a target revenue of $100,000 for FY25 Quarter 1. Create the following goals in the **Goals** area:

| Name                    | Goal hierarchy | Goal Owner     | Manager      | Goal Metric              | Time Period                | Target    |
|-------------------------|----------------|----------------|--------------|--------------------------|----------------------------|-----------|
| Sales Team Q1 FY2025    | Parent         | Nancy Warner   | Nancy Warner | Revenue                  | Q1 FY2025                  | $100,000  |
| Sales Q1 FY2025 – David | Child          | David Mallory  | Nancy Warner | Revenue (Same as parent) | Q1 FY2025 (Same as parent) | $50,000   |
| Sales Q1 FY2025 – Alan  | Child          | Alan Steiner   | Nancy Warner | Revenue (Same as parent) | Q1 FY2025 (Same as parent) | $50,000   |

After you create the goals, sellers can track their progress against the targets. The parent goal will roll up the actuals from the child goals, allowing you to see the overall performance of the sales team.

Select **Recalculate** to update the actuals for the goals based on the latest data. The following screenshot shows the actuals for a specific seller goal:

:::image type="content" source="media/goal-actuals.png" alt-text="Screenshot of the Actuals tab for a specific seller goal.":::
 


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Create or edit a goal rollup query](../sales-enterprise/create-edit-goal-rollup-query-sales.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
