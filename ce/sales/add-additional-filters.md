---
title: Add additional filters to a forecast
description: Add filters to refine the opportunities and hierarchies that participate in calculating the forecast values.
ms.date: 09/01/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Apply additional filters

Add filters to refine the opportunities and hierarchies that participate in calculating the forecast values.

## Filter hierarchy records in the forecast

You can filter your forecast to include only those hierarchies that meet the specified conditions. For example, Kenny Smith, the Sales head for APAC and EMEA wants to view the forecast data of the org in the APAC territory. As an administrator, you can create an org chart forecast and set the hierarchy filter to include only the APAC forecast data. 

The following screenshot illustrates a sample forecast hierarchy: 

:::image type="content" source="media/forecast-hierarchy.PNG" alt-text="A sample forecast hierarchy with a manager and her team.":::

**To filter hierarchy records in a forecast**

1.  In the **General** step of the forecast configuration, select the **Funnel** icon next to **Hierarchy entity** field.

    > [!NOTE]
    > To apply the filter on an existing forecast, clone the forecast configuration, apply the filter, and activate it. You can then deactivate the old forecast configuration.
    
2.  Select the conditions to filter the hierarchy that you want to include in the forecast. For our example, let's select **Territory** is equal to APAC. This will include forecast records of sellers from APAC.

     :::image type="content" source="media/hierarchy-filters.png" alt-text="Screenshot of the filter hierarchy page.":::

    > [!NOTE]
    > If a parent record is filtered out of the hierarchy, the rollup value of the child records will show up under the parent record. However, the opportunities that were directly owned by the parent record won't be displayed in the forecast. Let's suppose that Dustin Ochs is a Sales Manager in Kenny's org who manages two sellers. Henry is in Europe, but manages sellers in APAC. When Kenny looks at the forecast for APAC, the opportunities of Dustin's reports will roll up under Henry's name, but the forecast won't show the opportunities owned by Henry. 

3. Select a value that will be at the top of this forecast hierarchy in the **Top of Hierarchy** drop-down. 
    You'll see a preview of the hierarchy after applying the filter conditions.  

    :::image type="content" source="media/hierarchy-filter-preview.svg" alt-text="Screenshot of the forecast hierarchy preview.":::

    If a parent record is suffixed with **(group)** in the preview, it means that the parent record is filtered out of the hierarchy but its child records are included in the hierarchy. As an example, see Dustin's record in the above screenshot.  

4.  Ensure that the forecast hierarchy looks correct before you activate the forecast. After the forecast is activated, you can't edit the filter.


## Add additional filters on opportunities to calculate forecast values

Using the rollup filters, you can filter opportunities that participate in calculating the forecast values. To filter opportunities, create filter conditions based on the opportunity and its related entity attributes.

For example, you know that opportunities related to **ADatum Corporation** and the revenue of more than **$10,000** can't be closed for the current quarter. To filter out such opportunities from the forecast, follow these steps:

1.	In the **General** step of the forecast configuration, select the **Funnel** icon next to **Rollup entity** field.
 
2.	Select **Add** > **Add row**. 
 
3.	In the selection boxes, select the attribute as **Potential Customer**, the condition as **Does Not Equals**, and the account name as **ADatum Corporation**.

    With this condition, the opportunities related to **Adatum Corporation** will be removed from the forecast. In the next step, you'll add a condition to filter revenue that's more than or equal to **$10,000**.

4.	Select **Add** > **Add row**.

5.	In the selection boxes, select the attribute as **Est. Revenue**, the condition as **Is greater than**, and revenue to be considered as **10000**.

    > [!div class="mx-imgBorder"]
    > ![Enter the second condition.](media/forecast-add-filter-configure-condition-2.png "Enter the second condition")
5. Select **Apply** to save the filter conditions.
   
When the forecast is activated, the query will be executed to filter the forecast for the added conditions.



[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]


## Related information

[Configure forecasts in your organization](configure-forecast.md)<br>
[View a forecast](view-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
