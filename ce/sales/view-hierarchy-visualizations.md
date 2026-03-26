---
title: View and understand a hierarchy
description: Learn how to view and understand hierarchies in Dynamics 365 Sales.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection:
ms.date: 12/05/2025
ms.custom: bap-template 
---

# View and understand a hierarchy

As a seller, you can view the hierarchy to better understand the relationships between records. Administrators must design and publish a hierarchy to display data in a hierarchical manner.  
For example, your administrator might publish a **Account hierarchy** that allows you to visualize customer’s related companies, regional offices, and branch locations. Your administrator might also publish a hierarchy called **Account contacts** that shows a hierarchy of people and their reporting structure and job titles associated with a given account.  

## Open a hierarchy

In form view, open a record such as an account or a lead to see the **Visual hierarchy** option on the command bar.  
In a grid view, select a single record to enable the **Visual hierarchy** option. If you select more than one record, the option is disabled.  
Select the **Visual hierarchy** option to open the hierarchy page, which displays a tree of tiles representing records and their relationships.  

> [!NOTE]
>
> - The **Visual hierarchy** option isn't available if the admin doesn't configure a hierarchy for the table, or the table doesn't have parent record relationships.  
> - If the **Visual hierarchy** option isn't visible on the command bar, select **More commands for *Table*** (⋮) on the command bar to see more options, and check if the **Visual hierarchy** option is available there.  

:::image type="content" source="media/hv-select-visual-hierarchy.png" alt-text="Screenshot of the Visual hierarchy option in the command bar.":::

## Understand a hierarchy

Let's look at the key features and functionality of a hierarchy.  

### Navigating a hierarchy

| Number | Feature | Description |
|--------|-------------|-------------|
| 1 | Hierarchy list display | Records in the hierarchy are shown in the left pane and in the main area as tiles, with the parent node at the top and child nodes below. |
| 2 | Record count per node | Each node displays the number of records next to the attribute name or tile. |
| 3 | Expand/collapse nodes| Use the chevron icon to expand or collapse child nodes. Visualization adjusts automatically. |
| 4 | Search and select record | Displays the record tile as main and its child records below. If any parent record exists, an option to go to its parent is displayed on the top of the tile.<br>Select the drop-down list and the **Lookup Records** pane appears. Search and select the record that you want to view. |
| 5 | Highlighting selected tiles| Select the name in the list on the left pane, the corresponding tile is highlighted in the hierarchy. |
| 6 | Switching hierarchies| If there are multiple hierarchies available for the same table, on the top right corner of the hierarchy pane, select a different hierarchy from the drop-down list. |

:::image type="content" source="media/hv-hierarchy-navigation.png" alt-text="Screenshot of annotations in the hierarchy.":::

### Interacting with a hierarchy

| Feature | Description |
|---------|-------------|
| Child record display limit | The hierarchy displays five child records at a time. If there are more, select **Show more** to load more records. |
| Tile details | The details shown in tiles depend on the form selected while configuring the hierarchy. If you need to see more or different information, contact your administrator to request changes. |
| Open record details | Select the tile to open more details about the record in the right pane based on the form that is configured in the hierarchy. Your administrator can configure which form to display.<br>For example, your administrator selected the quick create form to display. When you select the tile, the quick create form opens in the right pane. |
| Inline record edits | Edit the record directly from the form displayed in the right pane without leaving the hierarchy. |
| Layout switch | To visualize the hierarchy that suits your convenience, you can switch between the vertical and horizontal layouts (rows or columns).<br>In the left pane, at the bottom left, select the option depending on your preference. |
| Zoom and center view | Zoom in and out of the hierarchy to get a better view of the relationships between records. Also, center the view on a specific record to focus on its details and relationships.<br>Select the required icon at the bottom right corner of the hierarchy pane. |
| Create new records | Create new records directly in the hierarchy. On the tile, select the **More options** icon and then select the option accordingly. The record is added under the selected parent record (tile).<br>For example, a tile in the **Account** table hierarchy displays two options&mdash;**Add new** and **Add existing**. Select an option to create a new record or associate an existing record with the tile. |

:::image type="content" source="media/hv-hierarchy-interactions.png" alt-text="Screenshot of a hierarchy with details pane.":::

## Related information

[Design and publish hierarchy](create-activate-hierarchy-visualizations.md)
