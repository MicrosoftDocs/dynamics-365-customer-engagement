---
title: "Define goal rollup queries (Dynamics 365 Sales) | MicrosoftDocs"
description: "Collect data about a given goal, including all its related goals, in one view by using rollup query in Dynamics 365 Sales."
ms.date: 01/03/2025
ms.topic: article
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
# Define goal rollup queries (Sales Hub) 

Use rollup queries to specify additional criteria that you want to apply on existing goal metrics. For example, you could create a goal metric that measures all invoices closed within a specific period. A rollup query could then show you invoices owned by one person, or for customers in one territory.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Create a rollup query

1.	Make sure that you have the Manager, Vice President, CEO-Business Manager, System Administrator, or System Customizer security role or equivalent permissions.

2.	In the site map, select the Change area icon ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.  

3. Under **Performance management**, select **Rollup Queries**.
 
4.	On the command bar, select **New**.

5. In the **Entity Type** field, select the entity for the rollup query. For example, if you want the invoices for customers in a territory, select the Invoice entity.  
      > [!NOTE]
      >  If you change the entity type after you add your query criteria in the Query builder, the query criteria will be deleted.  
  
6. In the Query builder, add the criteria for your query.  

    :::image type="Build a query for rollup" source="media/rollup-query-builder.png" alt-text="Build a query for rollup":::
  
7. To see the results for the query, select **View records**.  
  
8. Save the query.  
    Now that the rollup query is created, you can apply it to the goals of individuals or teams who need to meet this specific criteria.

## Apply rollup query to a goal

Rollup queries define additional criteria for a goal. Applying the rollup query to individual or team goal ensures that the goal metrics are calculated based on the additional criteria.  

**Follow these steps:**

1. In the Sales Hub app, navigate to  **Performance** > **Goals** in the left pane.  

2. Open the goal to which you want to apply the rollup query.  

3. (Optional) Select the **Actuals** tab and note down the values before applying the rollup query.  
    This step helps in comparing the values after applying the rollup query.  
4. Select the **Goal Criteria** tab.  
5. Select the rollup query in the **Rollup Query - Actual** and **Rollup Query - In-Progress** fields.  
6. Select **Recalculate** on the command bar and wait for the calculations. Calculation time depends on the complexity of the query and the volume of data.  
    :::image type="Image of the Goal Criteria tab with the rollup query fields, also highlighting the Recalculate option" source="media/rollup-query.PNG" alt-text="Image of the Goal Criteria tab with the rollup query fields, also highlighting the Recalculate option":::

    > [!NOTE]
    > The goals are automatically rolled up depending on the rollup frequency set by your administrator. For more information, see [Define system settings from the Goals tab](/power-platform/admin/system-settings-dialog-box-goals-tab).

7. Select the **Actuals** tab of the goal and verify the **Last Rolled Up Date** to ensure that the recalculated data is the latest.  
    The **Percentage Achieved**, **Actual**, and **In-Progress** fields display the values after applying the additional criteria in the rollup query. For example, values for a specific customer.  


> [!NOTE]
> The maximum number of records that can be counted  in a goal rollup query is 5000.  
  
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information  

[Create or edit goals](../sales-enterprise/create-edit-goal-sales.md)   
[Define a goal metric](create-edit-goal-metric.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
