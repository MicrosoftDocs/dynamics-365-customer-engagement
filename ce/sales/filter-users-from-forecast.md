---
title: "Filter users from forecast hierarchy - Sales Enterprise | MicrosoftDocs"
description: "Apply filters on your forecast hierarchy to include only those users who meet the specified conditions such as role or territory.."
ms.date: 10/07/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Filter users from forecast hierarchy

You can apply filters on your forecast hierarchy to include only those users who meet the specified conditions. You can filter users from a team, role, territory, and others. For example, Olivia Wilson is the Sales head for APAC and EMEA. She wants to view the forecast data of her org in the APAC territory. As an administrator, you can create an org chart forecast and set the hierarchy filter to include only the APAC forecast data. 

The following screenshot illustrates a sample forecast hierarchy: 

:::image type="content" source="media/forecast-hierarchy.PNG" alt-text="A sample forecast hierarchy with a manager and her team":::

**To filter users from the forecast hierarchy**

1.  Select the **Filter Hierarchy** step of the forecast.
    > [!NOTE]
    > To apply the filter on an existing forecast, clone the forecast configuration, apply the filter, and activate it. You can then deactivate the old forecast.
    
2.  Select the conditions to filter users that you want to include in the forecast. In our example, select **Territory** is equal to APAC. This will include forecast records of sellers from APAC.

     :::image type="content" source="media/hierarchy-filters.png" alt-text="Screenshot of the Filter Hierarchy step":::

    > [!NOTE]
    > If a manager is filtered out of the hierarchy, the rollup value of their team will still show up under the manager’s name. However, the opportunities that were owned by the manager, won’t be displayed in the forecast. Let’s suppose that Henry Ross is a Sales Manager in Olivia’s org and manages five sellers. Henry is in Europe but manages sellers in APAC. When Olivia looks at the forecast for APAC, the opportunities of Henry’s reports will roll up under Henry’s name, but it won’t show any opportunities that Henry owns. 

3.  Select the **General** step to preview the forecast configuration with the filtered hierarchy.

    :::image type="content" source="media/hierarchy-filters-preview.png" alt-text="Screenshot of the forecast hierarchy preview":::

4.  Ensure that the forecast hierarchy looks correct before you activate the forecast. Once the forecast is activated, you can't edit the filter.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Apply additional filter](add-additional-filters.md)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Configure and manage drill-down entities](configure-manage-drill-downs.md)
</td></tr>
</table>