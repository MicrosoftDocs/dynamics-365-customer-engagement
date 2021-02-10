---
title: "Define goal rollup queries (Dynamics 365 Sales) | MicrosoftDocs"
description: "Collect data about a given goal, including all its related goals, in one view by using rollup query in Dynamics 365 Sales."
ms.date: 02/10/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
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

# Define goal rollup queries (Sales Hub)


Use the rollup query to gather data about a given goal, including all its related goals, in one view.  

1.	Make sure that you have the Manager, Vice President, CEO-Business Manager, System Administrator, or System Customizer security role or equivalent permissions.

2.	In the site map, at the bottom, select the Change area icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.  

    > [!div class="mx-imgBorder"]
    > ![Select the Change area icon and then select App Settings](media/change-area-app-settings.png "Select the Change area icon and then select App Settings")

3. Select **Rollup Queries**.

    > [!div class="mx-imgBorder"]
    > ![Goal Metrics in the site map](media/site-map-goal-management.png "Goal Metrics in the site map")
 
4.	To create a new rollup query, on the command bar, select **New**.

5. [!INCLUDE[proc_handy_infotips](../includes/proc-handy-infotips.md)]  
  
    - **Name**.  Enter a name between 1 and 50 characters.  
  
    - **Entity Type**. Select the record type.  
  
    - **Owner**. Select the **Lookup** icon, and select the user or team who will own this query.  

    > [!div class="mx-imgBorder"]
    > ![Rollup query form](media/rollup-query-form.png "Rollup query form")
    
      > [!NOTE]
      >  If you change this selection after you add your query criteria in the **Query** section, your query criteria will be deleted.  
  
6. In the **Query** section, add the criteria for your query. The criteria you can add depends on the record type. 

    > [!div class="mx-imgBorder"]  
    > ![Build a query for rollup](media/rollup-query-builder.png "Build a query for rollup")
  
7. To see the results for the query, select **View Records**.  
  
8. Select **Save**, **Save and Close**, or, to create a new rollup query, **Save and New**.  
  
9. To view the data for a goal, in the site map, select **Goals**.  
  
10. Open the goal you want, and then on the command bar, select **Recalculate**.  
  
     The values of the actuals are recalculated. You can see the recalculated values in the **Percentage Achieved**, **Actual**, and **In-Progress** columns. If you open the goal, under **Actuals**, you can see the **Last Rolled Up Date**.  
  
> [!NOTE]
>  The maximum number of records that can be counted  in a goal rollup query is 5000.  
  
 
### See also  

[Create or edit goals](../sales-enterprise/create-edit-goal-sales.md)   
[Define a goal metric](create-edit-goal-metric.md)
