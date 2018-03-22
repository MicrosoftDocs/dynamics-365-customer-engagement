---
title: "Define a goal metric (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Define how you want to measure your goals by using goal metrics in Dynamics 365 for Sales."
keywords: "goal, metric"
ms.date: 04/01/2018
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2251e5a0-fb76-48fb-82ec-73fe6263e3bd
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 
topic-status: Drafting
---

# Define a goal metric (Sales & Sales Hub)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Goal metrics let you clearly define how a goal will be measured. For example, a sales team's performance can be measured based on the number of leads they get or te revenue amount. There are two goal metric types: Amount and Count. The Amount metric type can be a money value, an integer, or a decimal number. The Count metric type is an integer. For example, you can use the Amount (money) goal metric to track the revenues from all active opportunities or sales orders. An integer type can be used to track sales calls made by a salesperson. A decimal number can represent a product sold by weight, such as grain or sugar.   

## Create a goal metric (Sales Hub app)

> [!IMPORTANT]

> Currently, you can't create a goal metric in the Sales Hub app. To create a goal metric, use the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] - custom app.

## Create a goal metric query (Sales app)
  
[!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
2.  Go to **Sales** > **Goal Metrics**.   
  
3.  To create a new goal metric, on the command bar, select **New**.  
  
     -OR-  
  
     To edit a goal metric, select **Edit**.  
  
4. Under **Information**, select **General**.

5. Under **Step 1: Define the metric**, fill in the information:

   - **Name**. Required. Enter a name between 1 and 100 characters.

   - **Metric Type**. Required. To track a monetary amount, select **Amount**. To track another type of amount, such as how many new contacts are added, select **Count**.

    > [!NOTE]

    > After you save the goal metric, you will no longer be able to edit this field.

   - **Amount Data Type**. Required. This option is not available if the **Metric Type** you chose is **Count** because [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] automatically sets the data type to integer.

    > [!NOTE]

    > After you save the goal metric, you will no longer be able to edit this field.

   - **Track Stretch Target**. Select this check box if you want this metric to track an additional target beyond the primary goal.

6. Under **Information**, select **Rollup Fields** to create or edit rollup fields as desired. 

   > [!NOTE]

   > You must first save the goal metric before you can create new rollup fields.

7. Select **Save**.

8. Under **Step 2**: Define the rollup fields for this metric to track the target's actual and in-progress values. 

   1. On the **Rollup Fields** tab, in the **Records** group, click **Add New Rollup Field**.

   2. Under **Information**, click **General**. The **Rollup Field** dialog box opens.

   3. Under **Step 1: Specify the rollup field to track against goals**, fill in the information:

      - **Rollup Field**. Select a rollup field where the metric rollup data will be displayed in the goal. You can display an integer or money, depending on the **Metric Type** you chose. You can't select a field you already added to the metric.

   4. Under **Step 2: Specify the details about the source data that rolls up**, fill in the information:

      - **Source Record Type**. Required. Select the record type to use as the source of the rollup data for the metric.

      - **Source Record Type State**. Required. Select the record state you want to use as the source of the rollup data for the metric.

      - **Source Record Type Status**. Required. Select the status of the records you want to use as the source of the rollup data for the metric. State and status may be identical, depending on the record type you selected.


   5. Under **Step 3: Specify the date field that determines the goal period that the records will roll up into**, fill in the information:

      - **Record Type**. Required. Select the entity that contains the date field you want. Typically, you can only choose the same record type you selected as the Source Record Type.

      - **Date Field**. Select a date field. The options available in the list are from the entity you selected in the **Record Type** field.


   6. Select **Save and Close**.


9. Under **Information**, select **Description**, and then enter a description for the goal metric to enable other users to understand what metrics are being tracked. 

10. Select **Save**.

  
  
### See also  
 [Create or edit a goal](../sales-enterprise/create-edit-goal-sales.md)   
 [Progress Against Goals report](../basics/sales-insights-reports.md#BKMK_ProgressGoals)
