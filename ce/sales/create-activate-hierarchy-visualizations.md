---
title: Create and publish a hierarchy visualization
description: Learn how to create and publish a hierarchy visualization to better understand your data.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 08/22/2025
ms.custom: bap-template 
---

# Create and publish a hierarchy visualization (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can create and publish a hierarchy that allows your organization to visualize and work with complex hierarchical data. You can even create multiple hierarchy visualizations to show different relationships, or different views of the data such as active records only, or only records from certain countries.  

> [!NOTE]
>
> - The hierarchy visualization feature is currently available out of the box for the **Account** and **Contact** tables. However, for custom tables, you need to create the self-referential relationship and configure the hierarchy visualization.  
> - Default self-referential columns: `ParentAccountId` in the **Account** table and `parent_contactid` in the **Contact** table.  
> - For the **Opportunity** table, there is no default self-referential column. Create a new **Many-to-One** relationship and select the **Opportunity** table as the related table. Rename the **Lookup column display** name to `Parent_OpportunityID` and leave the **Hierarchical** checkbox unchecked. Then, update the **Opportunity** form by adding the `Parent_OpportunityID` field. This update enables you to select a parent opportunity when they create or edit an opportunity, helping them establish clear relationships between opportunities.

Hierarchies are created using your existing tables, forms, relationships, and views. In this initial release, you can design and publish a hierarchy based on a N:1 self-referential relationship&mdash;one where each row in a table has an optional pointer to its parent row. Here are some examples of self-referential hierarchies:  

- **Organization chart**: Based on a table of persons such as the Contact table, each person has a relationship that points at their manager.  
- **Account hierarchy**: An account hierarchy might be a global company with subsidiaries in countries, which have regional offices, which have branch offices.
- **Sequential process hierarchy**: You might have a hierarchy of opportunities if your company sells end-to-end services for a product. For example, where opportunity to sell, is followed by product design services, which is followed by product installation, then operational contracts, and possibly maintenance contracts. Each follows its predecessor. Being able to display multiple deals at various phases for a given buyer is a powerful visual advantage to your teams.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you create and publish a hierarchy visualization, ensure the following prerequisites are met:

- You must have administrator privileges.  
- The table (entity) for which you want to create the hierarchy visualization must have a self-referential (parent-child) relationship column to define the hierarchy. For example, you can use the parent account ID for accounts.  
- For custom tables, ensure that rows can reference a parent row in the same table. If the relationship doesn't exist, [you need to create it](/power-apps/maker/data-platform/create-edit-entity-relationships).  
- Users must have at least read permissions to the data.  
- A table view must exist that defines the scope of data to show in the hierarchy. By default, the hierarchy uses the Active *record type* view. You can [create a custom view](customize-views.md) if none of the default views meets your requirements.  
- Determine what form you would like to show for the Details pane when a tile is selected. If none of the default forms meet your needs, you can [Create a form in the Power Apps maker portal](/power-apps/maker/model-driven-apps/create-and-edit-forms) to include only the fields you want. The details pane can show any form, and go full screen, so you can use the same form here that is typically used in Dynamics Sales. For example, for an account hierarchy, you can use the **Account** form, which is the same form used by Dynamics when viewing an account.

## Create a hierarchy visualization

To create a hierarchy visualization, follow these steps:

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
1. Select **New hierarchy** and then enter a name for the hierarchy.  
1. In the hierarchy visualization designer page, select **Add table**.  

    :::image type="content" source="media/hv-add-table.png" alt-text="Screenshot of selecting the Add table option in the hierarchy visualization designer page.":::

1. Choose the desired table with the self-referential relationship and select **Add**.  

    :::image type="content" source="media/hv-add-table-settings-pane.png" alt-text="Screenshot of the Settings pane in the hierarchy visualization designer page.":::

    The **Settings** pane opens on the right side of the page.

1. In the **General** tab, configure the following settings:

    | Setting | Description |
    |---------|-------------|
    | Select the column with the parent ID | Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows only self-referential columns (columns that reference the same table). Select one to link records for hierarchy visualization. |
    | Which view should be used | The hierarchy shows records from the selected table view. Accept the default or select another existing view. If needed, use the Power Platform maker portal to define your own view. |
    | Which form should be shown as a tile | Select a form to display as a tile. A maximum of seven fields can be displayed. Only fields that display basic data types (strings, dates, and numbers) are supported. Show or hide field labels on the form to show or hide the labels on the tile. |
    | Which form should be shown as details | Select a form to use to display detailed information when a user selects a tile. The details pane shows full forms in the narrow mobile view and can be expanded to show the form full screen. Tabbed forms are also supported. |

    :::image type="content" source="media/hv-settings-general-tab.png" alt-text="Screenshot of the General tab in the Settings pane in the hierarchy visualization designer page.":::

1. In the **Card display option** tab, configure the following settings:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | Tiles can optionally show or hide a circled image for the record. When enabled, if no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** doesn't have an image, her tile would be displayed as **MC**. If initials aren't available, the default icon for the table is shown. |
    | Card size | Select the width and height for the tile in pixels and then choose the color for the tile border. |

    > [!NOTE]
    > - These settings are applied to all the tiles in this hierarchy visualization.
    > - We recommend using consistent tile sizes and layouts for a cohesive look.

    :::image type="content" source="media/hv-settings-tile-tab.png" alt-text="Screenshot of the Card display option tab in the Settings pane in the hierarchy visualization designer page.":::

1. Select **Save**.  
1. (Optional) Select **Preview** to see how the hierarchy visualization would look if published with current settings. Update settings and preview changes until you’re satisfied with the results. In **Preview** mode, you can change the selected data being viewed by clicking the record name at the top of the preview window.  
1. Select **Publish** and then select **OK** on the confirmation message.  
    The hierarchy visualization is active and available to users.  

## Related information

[Manage hierarchy visualization](manage-hierarchy-visualizations.md)
