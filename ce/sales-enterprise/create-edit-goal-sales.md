---
title: "Create or edit a goal (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Keep track of your progress on achieving target revenue by using goals."
keywords: "Goal, target"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 161f9a27-3709-42c7-bca0-8538250e5de0
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Create or edit a goal (Sales and Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use goals to keep track of your progress on achieving target revenue.  
  
## Create a goal (Sales Hub app)
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
2. Select the site map icon ![Site map icon](media/site-map-icon.png "Icon for Site map"), and then select **Goals**.   
  
3. On the command bar, select **New**.  

    ![Goal form](media/goal-form.png "Goal form")
  
4. Fill in your information. Use the handy tooltips as a guide.

   - Name. Type a name that describes the goal. 
    
   - Parent Goal. If this goal is a child goal of another goal, select that goal as a parent goal here.  
    
   - Goal Metric. Choose how the goal will be tracked by selecting a metric for the goal.

     > [!NOTE]
     > 
     > If you select a parent goal for this goal, you can't select a goal metric. It is automatically populated from the parent goal.
    
   - Goal Owner. Select the user or team responsible for meeting the goal.
  
5. Select **Save**.

6. On the **Time Period** tab, specify whether the goal period is a fiscal period or a custom period. 

   - If **Goal Period Type** is **Fiscal Period**, select a fiscal period and fiscal year for which the goal is tracked.
    
   - If **Goal Period** Type is **Custom Period**, select a date in the From and To fields to define a custom period for which the goal is tracked.

     ![Time Period tab on the Goal form](media/time-period-tab-goal-form.png "Time Period tab on the Goal form")

   > [!NOTE]
   > 
   > If this goal has a parent goal, you can't specify the time period for the goal. It is automatically populated from the parent goal.     

7. On the **Targets** tab, specify a target value against which the results of the goal rollup are measured. The target type depends on the **Amount Data Type** selected for the goal metric that you chose for this goal. You will see one of the following fields:

   - **Target (Decimal)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Decimal**.
    
   - **Target (Money)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data** Type is **Money**.
    
   - **Target (Integer)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data** Type is **Integer** or if the goal **Metric Type** is **Count**.

8. If the goal metric you are using has **Track Stretch Target** selected, you will also see one of the following fields:
    
   - **Stretched Target (Decimal)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Decimal**.
    
   - **Stretched Target (Money)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Money**. 
    
   - **Stretched Target (Integer)**. Required. This field is available if the goal **Metric Type** is **Amount** and the **Amount Data Type** is **Integer** or if the goal Metric Type is **Count**.

9. To add an existing goal as a child goal of this goal, on the **Child Goals** tab, select the **Add Existing Goal** button.

10.	The **Actuals** tab shows the actual value achieved towards the target as of the last rolled-up date:

    - **Actual (Money)**. If the goal metric uses **Money** as the **Amount Data Type**, this field shows the total amount of money achieved towards the goal as of the last rolled-up date.
    
    - **In-progress (Money)**. If the goal metric uses **Money** as the **Amount Data Type**, this field shows the amount of money achieved towards the goal since the last time the actuals were calculated.
    
    - **Percentage Achieved**. If the goal metric is **Decimal** or **Integer**, this field shows the percentage of the goal that is complete as of the last rolled-up date.
    
    - **Last Rolled Up Date**. This field shows the last date and time that the actuals were recalculated.

11.	On the **Goal Criteria** tab, define the criteria that will be used for rolling up the Actuals data against the goal.

    - **Roll Up Only From Child Goals**. If you want to limit the data used for the roll up to only child goals, select **Yes**. To allow other data to be used for the roll ups, select **No**.
    
    - **Record Set for Rollup**. If you want to limit the records that can be included in the roll up to only those records owned by the goal owner, select **Owned by goal owner**. To allow all records to be included in the roll up data, select **All**.

12.	On the **Notes** tab, enter any notes for this goal.

13.	Select **Save** or **Save & Close**.

## Create a goal (Sales app)
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_goals](../includes/proc-goals.md)]  
  
3. If you are using the Sales app, select **New**.  
  
4. On the **New Goal** form, enter information or observe any noted restrictions or requirements as needed. Use the handy tooltips as a guide.  
  
5. Select or tap **Save** or **Save & Close**.  
  
  
### See also  
 [Create or edit a goal rollup query](../sales-enterprise/create-edit-goal-rollup-query-sales.md)   
