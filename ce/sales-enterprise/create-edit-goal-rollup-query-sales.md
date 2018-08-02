---
title: "Define a goal rollup query (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Collect data about a given goal, including all its related goals, in one view by using rollup query in Dynamics 365 for Sales."
keywords: "goal, rollup query"
ms.date: 04/01/2018
ms.service: dynamics-365-sales
ms.custom:
  - dyn365-sales
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2c15d62a-5cfa-4229-afe2-8927d45edadc
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Drafting
---

# Define a goal rollup query (Sales & Sales Hub)


[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use the rollup query to gather data about a given goal, including all its related goals, in one view.  

## Create a rollup query (Sales Hub app)

> [!IMPORTANT]
> 
> Currently, you can't create a goal rollup query in the Sales Hub app. To create a goal rollup query, use the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] - custom app.

## Create a rollup query (Sales app)
  
[!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
    #### Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. Go to **Rollup Queries**. [How do I get there?](../basics/navigation-customer-engagement-enterprise.md)  
  
3. To create a new rollup query, in the **Records** group, select **New**.  
  
    -OR-  
  
    To edit a rollup query, select **Edit**.  
  
4. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    - **Name**.  Enter a name between 1 and 50 characters.  
  
    - **Entity Type**. Select the record type.  
  
    - **Owner**. Select the **Lookup** icon, and select the user or team who will own this query.  
  
        > [!NOTE]
        >  If you change this selection after you add your query criteria in the **Query** section, your query criteria will be deleted.  
  
5. In the **Query** section, add the criteria for your query. The criteria you can add depends on the record type.  
  
6. To see the results for the query, select **View Records**.  
  
7. Select **Save**, **Save and Close**, or, to create a new rollup query, **Save and New**.  
  
8. To view the data for a goal, on the nav bar, select **Sales**, and then select **Goals**.  
  
9. Select the goal you want, and then select **More Commands**![More Commands button in Appointment Activity](../sales-enterprise/media/more-commands-button.gif "More Commands button in Appointment Activity"), and then select **Recalculate**.  
  
     The values of the actuals are recalculated. You can see the recalculated values in the **Percentage Achieved**, **Actual**, and **In-Progress** columns. If you open the goal, under **Actuals**, you can see the **Last Rolled Up Date**.  
  
> [!NOTE]
>  The maximum number of records that can be counted  in a goal rollup query is 5000.  
  
### See also  
 [Create or edit a goal](../sales-enterprise/create-edit-goal-sales.md)   
 [Progress Against Goals report](../basics/sales-insights-reports.md#BKMK_ProgressGoals)
