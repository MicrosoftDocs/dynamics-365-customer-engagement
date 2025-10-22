---
title: View and understand hierarchy visualization
description: Learn how to view and understand hierarchy visualizations in Dynamics 365 Sales.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection:
ms.date: 10/09/2025
ms.custom: bap-template 
---

# View and understand hierarchy visualization (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As a seller, you can view the hierarchy visualization to better understand the relationships between records. Administrators must design and publish a hierarchy to display data in a hierarchical manner.  
For example, your administrator might publish a **Account hierarchy** that allows you to visualize customer’s related companies, regional offices, and branch locations. Your administrator may also publish a hierarchy called **Account contacts** that shows a hierarchy of people and their reporting structure and job titles associated with a given account.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Open hierarchy visualization

In form view, open a record such as an account or a lead to see the **Visual hierarchy** option on the command bar.  
In a grid view, select a single record to enable the **Visual hierarchy** option. If you select more than one record, the option is disabled.  
Select the **Visual hierarchy** option to open the hierarchy visualization page, which displays a tree of tiles representing records and their relationships.  

> [!NOTE]
>
> - The **Visual hierarchy** option isn't available if the admin doesn't configure a hierarchy visualization for the table, or the table doesn't have parent record relationships.  
> - If the **Visual hierarchy** option isn't visible on the command bar, select **More commands for *Table*** (⋮) on the command bar to see more options, and check if the **Visual hierarchy** option is available there.  

:::image type="content" source="media/hv-select-visual-hierarchy.png" alt-text="Screenshot of the Visual hierarchy option in the command bar.":::

## Understand hierarchy visualization

Let's look at the key features and functionality of the hierarchy visualization.  

### Navigating the hierarchy

| Number | Feature | Description |
|--------|-------------|-------------|
| 1 | Hierarchy list display | Records in the hierarchy are shown in the left pane and in the main area as tiles, with the parent node at the top and child nodes below. |
| 2 | Record count per node | Each node displays the number of records next to the attribute name or tile. |
| 3 | Expand/collapse nodes| Use the chevron icon to expand or collapse child nodes. Visualization adjusts automatically. |
| 4 | Search and select record | Displays the record tile as main and its child records below. If any parent record exists, an option to go to its parent is displayed on the top of the tile.<br>Select the drop-down list and the **Lookup Records** pane appears. Search and select the record that you want to view. |
| 5 | Highlighting selected tiles| Select the name in the list on the left pane, the corresponding tile is highlighted in the hierarchy visualization. |
| 6 | Switching hierarchy visualizations | If there are multiple hierarchy visualizations available for the same table, on the top right corner of the hierarchy visualization pane, select a different hierarchy visualization from the drop-down list. |

:::image type="content" source="media/hv-hierarchy-navigation.png" alt-text="Screenshot of annotations in the hierarchy visualization.":::

### Interacting with the hierarchy

| Feature | Description |
|---------|-------------|
| Child record display limit | The hierarchy visualization displays five child records at a time. If there are more, select **Show more** to load more records. |
| Tile details | The details shown in tiles depend on the form selected while configuring the hierarchy visualization. If you need to see more or different information, contact your administrator to request changes. |
| Open record details | Select the tile to open more details about the record in the right pane based on the form that is configured in the hierarchy visualization. Your administrator can configure which form to display.<br>For example, your administrator selected the quick create form to display. When you select the tile, the quick create form opens in the right pane. |
| Inline record edits | Edit the record directly from the form displayed in the right pane without leaving the hierarchy visualization. |
| Layout switch | To visualize the hierarchy that suits your convenience, you can switch between the vertical and horizontal layouts (rows or columns).<br>In the left pane, at the bottom left, select the option depending on your preference. |
| Zoom and center view | Zoom in and out of the hierarchy visualization to get a better view of the relationships between records. Also, center the view on a specific record to focus on its details and relationships.<br>Select the required icon at the bottom right corner of the hierarchy visualization pane. |
| Create new records | Create new records directly in the hierarchy visualization. On the tile, select the **More options** icon and then select the option accordingly. The record is added under the selected parent record (tile).<br>For example, a tile in the **Account** table hierarchy visualization displays two options&mdash;**Add new** and **Add existing**. Select an option to create a new record or associate an existing record with the tile. |

:::image type="content" source="media/hv-hierarchy-interactions.png" alt-text="Screenshot of hierarchy visualization with details pane.":::

## Related information

[Create and publish hierarchy visualizations](create-activate-hierarchy-visualizations.md)
