---
title: View and understand hierarchy visualization
description: Learn how to view and understand hierarchy visualizations in Dynamics 365 Sales.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection:
ms.date: 08/22/2025
ms.custom: bap-template 
---

# View and understand hierarchy visualization (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As a seller, you can view the hierarchy visualization to better understand the relationships between records. Administrators must configure the hierarchy visualization for tables that you want to view. For example, if you want to see the hierarchy of accounts region-wise, the admin must configure this hierarchy visualization for the Account table with the appropriate configurations.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Open hierarchy visualization

To view the hierarchy visualization, follow these steps:  

1. Open the workspace such as Accounts or Leads. In the **view selector**, select the view that is specific for hierarchy visualization.  
    For example, select the **Hierarchy Visualization** view that is created for the **Account** table in which specific data is displayed in a structured format with customizations to show specific columns, apply filters, and sort data.  
1. Open a record.  
1. On the tool bar, select **Visual hierarchy**.  

    > [!NOTE]
    > The **Visual hierarchy** option is only available when the administrator configured a hierarchy visualization for the table.  

    The hierarchy visualization page opens with a tree of tiles representing records and their relationships.

<!--    :::image type="content" source="media/" alt-text="Screenshot of the hierarchy visualization."::: -->

## Understand hierarchy visualization

Let's look at the key features and functionality of the hierarchy visualization.  

### Navigating the hierarchy

| Feature | Description |
|---------|-------------|
| Hierarchy list display | Records in the hierarchy are shown in the left pane and in the main area as tiles, with the parent node at the top and child nodes below. |
| Record count per node | Each node displays the number of records next to the attribute name or tile. |
| Expand/collapse nodes| Use the chevron icon to expand or collapse child nodes. Visualization adjusts automatically. |
| Highlighting selected tiles| Select the name in the list on the left pane, the corresponding tile is highlighted in the hierarchy visualization. |
| Switching hierarchy visualizations | If there are multiple hierarchy visualizations available for the same table, on the top right corner of the hierarchy visualization pane, select a different hierarchy visualization from the drop-down list. |

### Interacting with the hierarchy

| Feature | Description |
|---------|-------------|
| Child record display limit | The hierarchy visualization displays five child records at a time. If there are more, select **Show more** to load more records. |
| Tile details | The details shown in tiles depend on the form selected while configuring the hierarchy visualization. If you need to see more or different information, contact your administrator to request changes. |
| Open record details | Select the tile to open more details about the record in the right pane based on the form that is configured in the hierarchy visualization. Your administrator can configure which form to display. For example, your administrator selected the quick create form to display. When you select the tile, the quick create form opens in the right pane. |
| Inline record edits | Edit the record directly from the form displayed in the right pane without leaving the hierarchy visualization. |
| Layout switch | To visualize the hierarchy that suits your convenience, you can switch between the vertical and horizontal layouts (rows or columns). On the left pane, at the bottom left, select the option depending on your preference. |
| Zoom and center view | Zoom in and out of the hierarchy visualization to get a better view of the relationships between records. Also, center the view on a specific record to focus on its details and relationships. Select the required icon at the bottom right corner of the hierarchy visualization pane. |
| Create new records | Create new records directly in the hierarchy visualization. On the tile, select the **More options** icon and then select the option accordingly. The record is added under the selected parent record (tile). For example, a tile in the **Account** table hierarchy visualization displays two options&mdash;**Add new** and **Add existing**. Select an option to create a new record or associate an existing record with the tile. |

## Related information

[Create and publish hierarchy visualizations](create-activate-hierarchy-visualizations.md)
