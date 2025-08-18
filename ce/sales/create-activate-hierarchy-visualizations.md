---
title: Create and activate a hierarchy visualization chart
description: Learn how to create and activate a hierarchy visualization chart to better understand your data.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: how-to
ms.date: 08/14/2025
ms.custom: bap-template 
---

# Create and activate a hierarchy visualization chart (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you create and activate a hierarchy visualization chart to better understand your organization's data. When a chart is created, based on the configurations, sellers can visualize complex relationships and dependencies in a clear and concise manner. You can create multiple hierarchy visualizations to address different requirements depending on your organization's needs.

These charts are based on tables and views, and you can select existing 1:N, N:1, and N:N relationships when adding a table. This flexibility allows for a wide range of hierarchical structures to be visualized, from simple parent-child relationships to more complex multi-table hierarchies.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you create and activate a hierarchy visualization chart, ensure the following prerequisites are met:

- You must have administrator privileges.  
- The table (entity) for which you want to create the hierarchy visualization must have a self-referential (parent-child) relationship column to define the hierarchy. For example, you can use the parent account ID for accounts.  
- For custom tables, ensure the parent-child column is present; for out-of-box tables, verify the required relationship exists.  
- Users must have at least read permissions for the table records to view the hierarchy visualization charts for that table.  
- A default view is created for the hierarchy visualization determines which records are displayed in the hierarchy list. If the default view is not suitable for your organization's needs, [create a custom view](customize-views.md) that meets your requirements.  
- [Create a form in the Power Apps maker portal](/power-apps/maker/model-driven-apps/create-and-edit-forms) to define the layout and content shown in tiles and in the detailed view when users select a tile. This form shows the most relevant data. For example, create an account form that includes the **Account**, **Primary Contact**, **Email Address**, **Status**, and **Revenue** fields. This approach makes the hierarchy visualization comprehensive and easy to understand. Create multiple forms for different hierarchy visualizations if needed.  

## Consideration

Review the following considerations before creating a hierarchy visualization chart:

- Currently, the hierarchy visualization feature supports only one table for each hierarchy visualization chart.  
- The hierarchy visualization is based on the relationships defined in the table schema. Ensure that the necessary relationships are in place before creating the visualization. More information: [Microsoft Dataverse table relationships](/power-platform/admin/dataverse-relationships).
- The hierarchy visualization feature in Dynamics 365 Sales is different from the hierarchy visualization in Power Apps. More information: [Difference between hierarchy visualization in Dynamics 365 Sales and Power Apps](hierarchy-visualization.md#difference-between-hierarchy-visualization-in-dynamics-365-sales-and-power-apps). 

## Create a hierarchy visualization chart

To create a hierarchy visualization chart, follow these steps:

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
1. Select **New hierarchy** and then enter a name for the hierarchy.  
1. In the hierarchy visualization designer page, select **Add table**.  

    :::image type="content" source="media/hv-add-table.png" alt-text="Screenshot of selecting the Add table option in the hierarchy visualization designer page.":::

1. Choose the table based on which you want to create the hierarchy visualization and then select **Add**.  
    The selected table is the root node for the hierarchy visualization. Ensure that the selected table has a self-referential (parent-child) relationship column to define the hierarchy.

    :::image type="content" source="media/hv-add-table-settings-pane.png" alt-text="Screenshot of the Settings pane in the hierarchy visualization designer page.":::

    The **Settings** pane opens on the right side of the page.

1. In the **General** tab, configure the following settings:

    | Setting | Description |
    |---------|-------------|
    | Expand all levels | By default, the option is enabled and can't be disabled. The option allows users to see all levels of the hierarchy at once. |
    | Select the column with the parent ID | Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows only self-referential columns (columns that reference the same table). Select one to link records for hierarchy visualization. |
    | Which view should be used | When users open the hierarchy visualization, they should see the records based on the selected view. Use the default view or the one that is created. For example, Active accounts or All accounts. |
    | Which form should be shown as a tile | Select a suitable form that should be displayed as a tile (card) in the hierarchy visualization. Use a concise tile form that shows key summary fields for each record such as account name, owner, and revenue&mdash;so users can scan the tile layout at a glance. |
    | Which form should be shown as details | Select a form that should be used to display detailed information when a user selects a card in the hierarchy visualization. This form should provide comprehensive information about the record and may include additional fields not shown in the card. |

    :::image type="content" source="media/hv-settings-general-tab.png" alt-text="Screenshot of the General tab in the Settings pane in the hierarchy visualization designer page.":::

1. In the **Card display option** tab, configure the following settings:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | By default, the option is enabled and displays the record's image in the card. If no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** does not have an image, her card would be displayed as **MC**. |
    | Card size | Select the width and height for the card in pixels and then choose the color for the card border. |

    > [!NOTE]
    > - These settings are applied to all the cards in this hierarchy visualization chart.
    > - We recommend using consistent card sizes and layouts for a cohesive look.

1. Select **Save**.
1. (Optional) Select **Preview** to see how the hierarchy visualization looks with the current settings to users. You can update the settings and preview the changes until you're satisfied with the result.  
1. Select **Publish** and then select **OK** on the confirmation message.  
    The hierarchy visualization chart is active and available to users. 

## Related topics

- [Manage hierarchy visualization](manage-hierarchy-visualizations.md)
<!--- [Examples of hierarchy visualization](examples-hierarchy-visualizations.md)-->