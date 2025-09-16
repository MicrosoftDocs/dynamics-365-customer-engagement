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
> - The hierarchy visualization feature is currently available out of the box for the **Contact**, **Opportunity**, **Lead**, and **Account** tables. However, to configure hierarchy visualization for custom tables, you need to create the self-referential and cross-referential relationships.  
> - Default self-referential columns: `ParentAccountId` in the **Account** table, `parent_contactid` in the **Contact** table, `masterid` in the **Lead** table.  
> - For the **Opportunity** table, there is no default self-referential column. Create a new **Many-to-One** relationship and select the **Opportunity** table as the related table. Rename the **Lookup column display** name to `Parent_OpportunityID` and leave the **Hierarchical** checkbox unchecked. Then, update the **Opportunity** form by adding the `Parent_OpportunityID` field. This update enables you to select a parent opportunity when they create or edit an opportunity, helping them establish clear relationships between opportunities.


Hierarchies are created using your existing tables, forms, relationships, and views. You can design and publish a hierarchy based on a N:1 self-referential relationship&mdash;one where each row in a table has an optional pointer to its parent row, 1:N many-to-one relationship&mdash;one where each row in a table has a pointer to a row in another table, or both, and N:N many-to-many relationships.

You can design and publish a hierarchy based on the following types:  

- An N:1 self-referential relationship (each row can point to its parent).
- An N:1 relationship to another table (each row points to a row in another table).
- Both relationship types.
- An N:N many-to-many relationship.

Here are some examples of self-referential hierarchies:  

- **Organization chart**: Based on a table of persons such as the Contact table, each person has a relationship that points at their manager.  
- **Account hierarchy**: An account hierarchy might be a global company with subsidiaries in countries, which have regional offices, which have branch offices.
- **Sequential process hierarchy**: You might have a hierarchy of opportunities if your company sells end-to-end services for a product. For example, where opportunity to sell, is followed by product design services, which is followed by product installation, then operational contracts, and possibly maintenance contracts. Each follows its predecessor. Being able to display multiple deals at various phases for a given buyer is a powerful visual advantage to your teams.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you create and publish a hierarchy visualization, ensure the following prerequisites are met:

- You must have administrator privileges.  
- Define the parent-child relationship.  
    - For self-referential hierarchies, specify the column that contains the parent ID. For example, Parent Account ID for the Account table.  
    - For cross-table hierarchies, define the relationships between tables. For example, Account to Contact.  
- For custom tables, ensure that rows can reference a parent row in the same table. If the relationship doesn't exist, [you need to create it](/power-apps/maker/data-platform/create-edit-entity-relationships).  
- Users must have at least read permissions to the data to view the hierarchy.  
- A table view must exist that defines the scope of data to show in the hierarchy. By default, the hierarchy uses the Active *record type* view. You can [create a custom view](customize-views.md) if none of the default views meets your requirements. The following are the default views for the supported tables:  
  - **Account**: Account tile form  
  - **Contact**: Contact tile form  
  - **Lead**: Lead tile form  
  - **Opportunity**: Opportunity tile form  
- Determine what form you would like to show for the **Details** pane when a tile is selected. If none of the default forms meet your needs, you can [Create a form in the Power Apps maker portal](/power-apps/maker/model-driven-apps/create-and-edit-forms) to include only the fields you want. The details pane can show any form, and go full screen, so you can use the same form here that is typically used in Dynamics Sales. For example, for an account hierarchy, you can use the **Account** form, which is the same form used by Dynamics when viewing an account.

## Create a hierarchy visualization

To create the hierarchy visualization, follow these steps:

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
1. Select **New hierarchy** and then enter a name for the hierarchy.  
1. In the hierarchy visualization designer page, select **Add table**.  

    :::image type="content" source="media/hv-add-table.png" alt-text="Screenshot of selecting the Add table option in the hierarchy visualization designer page.":::

1. [Configure the root node of the hierarchy](#configure-the-root-node-of-the-hierarchy).
1. [Configure the child node](#configure-the-child-node).
1. Select **Save**.  
1. (Optional) Select **Preview** to see how the hierarchy visualization would look if published with current settings. Update settings and preview changes until you’re satisfied with the results. In **Preview** mode, you can change the selected data being viewed by clicking the record name at the top of the preview window.  
1. Select **Publish** and then select **OK** on the confirmation message.  
    The hierarchy visualization is active and available to users.  

### Configure the root node of the hierarchy

Configure the root node of the hierarchy by selecting the desired table. The table is the starting point for the hierarchy.  

1. In the hierarchy designer page, select **Add** and choose the desired table with the self-referential relationship. Here, we are adding **Account** table.  
    The **Settings** pane opens on the right side of the page.  
1. In the **General** tab, define child-parent relationship, and choose view and forms:  

    | Setting | Description |
    |---------|-------------|
    | Show all children of parent | Enable the option to show all children of the parent node in the hierarchy. When users open the hierarchy, all child records will be displayed under the parent node. For example, if the parent account is **Contoso** and has four child accounts, all the four child accounts under **Contoso** will be shown. |
    | Select the column with the parent ID | Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows self-referential columns (columns that reference the same table) and cross-table relationships. Select one to link records for hierarchy visualization. Here, we are selecting the `parentaccountid` column . This column has cross-table relationships with other tables such as **Lead**. |
    | Which view should be used | The hierarchy shows records from the selected table view. Accept the default or select another existing view. If needed, use the [Power Platform maker portal to define your own view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view). Here we are selecting the **Active Accounts** view to show only active accounts in the hierarchy. |
    | Which form should be shown as a tile | Select a form to display as a tile. A maximum of seven fields can be displayed. Only fields that display basic data types (strings, dates, and numbers) are supported. Show or hide field labels on the form to show or hide the labels on the tile. You can customize the form to fit your needs such as concatenating name fields to display as one row. Here, we're selecting **Account Tile Form**. |
    | Which form should be shown as details | Select a form to use to display detailed information when a user selects a tile. The details pane shows full forms in the narrow mobile view and can be expanded to show the form full screen. Tabbed forms are also supported. Here, we are selecting the **Account** form. |

    :::image type="content" source="media/hv-account-settings-general-tab.png" alt-text="Screenshot of the general tab in the account table settings pane in the hierarchy visualization designer page.":::

1. In the **Tile display option** tab, customize tile appearance:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | Tiles can optionally show or hide a circled image for the record. When enabled, if no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** doesn't have an image, her tile would be displayed as **MC**. If initials aren't available, the default icon for the table is shown. |
    | Tile size | Select the width and height for the tile in pixels and then choose the color for the tile border. |
    | Color | Select the top header color for the tile in Hex format. Here, we are using **#0078D4** for the blue color. |

    > [!NOTE]
    > - These settings are applied only to this tile in this hierarchy visualization.
    > - We recommend using consistent tile sizes and layouts for a cohesive look.

    :::image type="content" source="media/hv-account-settings-tile-tab.png" alt-text="Screenshot of the tile display option tab in the account settings pane in the hierarchy visualization designer page.":::

Now, the root node of the hierarchy is configured you can proceed to [add and configure child nodes](#configure-the-child-node) as required.  
If you are creating a self-referential simple hierarchy, adding child nodes is not required. Go to [create a hierarchy visualization](#create-a-hierarchy-visualization) section to complete the process.  

### Configure the child node
  
1. Under the root node, select the add icon below the tile and enter a name for the child node. Here, we are adding **Contact** table as a child node to the **Account** table.  
1. Select **Add table** and then select the desired table. Here, we are selecting the **Contact** table.  
    The **Settings** pane opens on the right side of the page.  
1. In the **General** tab, configure relationship settings with the root node table, define child-parent relationship, and choose view and forms
  
    | Setting | Description |
    |---------|-------------|
    | Branch display name | Enter a name for the branch display. This name will be shown in the hierarchy visualization. |
    | Select relationship to table: *Table* | Choose a relationship type for the table depending on your business needs. The following options are available:<br>&nbsp;• Contacts with matching {Parent_ID}<br>&nbsp;• Contacts with matching {Parent_Account_team}<br>&nbsp;• {Primary_Contact} for the account<br>&nbsp;• Dataverse connections table<br>&nbsp;• Custom connections table<br>To understand more about the relationship types, see [Relationship selection options for child node](#relationship-selection-options-for-child-node). |
    | Show all children of parent | Enable the option to show all children of the parent node in the hierarchy. When users open the hierarchy, all child records will be displayed under the parent node. For example, if the parent account is **Contoso** and has four child accounts, all the four child accounts under **Contoso** will be shown. |
    | Select the column with the parent ID | Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows self-referential columns (columns that reference the same table) and cross-table relationships. Select one to link records for hierarchy visualization. Here, we are selecting the `parentaccountid` column . This column has cross-table relationships with other tables such as **Lead**. |
    | Which view should be used | The hierarchy shows records from the selected table view. Accept the default or select another existing view. If needed, use the [Power Platform maker portal to define your own view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view). Here we are selecting the **Active Accounts** view to show only active accounts in the hierarchy. |
    | Which form should be shown as a tile | Select a form to display as a tile. A maximum of seven fields can be displayed. Only fields that display basic data types (strings, dates, and numbers) are supported. Show or hide field labels on the form to show or hide the labels on the tile. You can customize the form to fit your needs such as concatenating name fields to display as one row. Here, we're selecting **Account Tile Form**. |
    | Which form should be shown as details | Select a form to use to display detailed information when a user selects a tile. The details pane shows full forms in the narrow mobile view and can be expanded to show the form full screen. Tabbed forms are also supported. Here, we are selecting the **Account** form. |  

    :::image type="content" source="media/hv-contact-settings-general-tab.png" alt-text="Screenshot of the general tab in the contact table settings pane in the hierarchy visualization designer page.":::

1. In the **Tile display option** tab, customize tile appearance:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | Tiles can optionally show or hide a circled image for the record. When enabled, if no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** doesn't have an image, her tile would be displayed as **MC**. If initials aren't available, the default icon for the table is shown. |
    | Tile size | Select the width and height for the tile in pixels and then choose the color for the tile border. |
    | Color | Select the top header color for the tile in Hex format. Here, we are using **#0078D4** for the blue color. |

    > [!NOTE]
    > - These settings are applied only to this tile in this hierarchy visualization.
    > - We recommend using consistent tile sizes and layouts for a cohesive look.

    :::image type="content" source="media/hv-account-settings-tile-tab.png" alt-text="Screenshot of the tile display option tab in the account settings pane in the hierarchy visualization designer page."::: 

1. Repeat steps 2 to 4 to add more child nodes as required.  

    After adding the child nodes, go to [create a hierarchy visualization](#create-a-hierarchy-visualization) section to complete the process.  

#### Relationship selection options for child node

When you add a child node, you must select a relationship type to define how the child table relates to the parent table. The available relationship options depend on the tables you are working with. Here are some common relationship types you might encounter:

- **Contacts with matching {Parent_ID}**: This option uses a direct lookup field such as, `ParentCustomerId` on the child table to link each record to its parent table. It’s the classic parent-child relationship.  
    For example, you want to display all contacts associated with a specific account in a hierarchical view.
    The **Contact** table includes a field `ParentCustomerId`, which establishes a relationship to the **Account** table. When this relationship is selected, the application displays all contacts where&mdash;`Contact.ParentCustomerId` = `Account.AccountId`  
    This creates a parent-child hierarchy between the account and its related contacts.  
- **Contacts with matching {Parent_Account_team}**: This option links child records to parent based on a shared team or group field, not a direct parent-child relationship. It's useful when child records are associated with parent records through a team.  
    For example, you want to display  all contacts who belong to the same team as the account they’re associated with.  
    The **Contact** table includes a field `TeamId`, which indicates the team the contact belongs to. The **Account** table also has a `TeamId` field. When this relationship is selected, the application displays all contacts where&mdash;`Contact.TeamId` = `Account.TeamId`  
    This creates a team-based hierarchy between accounts and contacts.  
- **{Primary_Contact} for the account**: This option uses a specific field on the parent table to show the main contact for each parent record.  
    For example, you want to identify and display the key contact associated with each account.  
    The **Account** table includes a `PrimaryContactId` field and the hierarchy uses this field to locate the contact whose `ContactId` matches the account’s `PrimaryContactId`.  
    This creates a direct link where each account points to its primary contact.  
- **Dataverse connections table**: This option leverages the standard **Dataverse Connections** table, which allows you to model flexible, many-to-many relationships with roles such as Advisor, Family member, and so on.  
    For example, you want to display all contacts connected to an account through various roles defined in the **Connections** table.  
    The **Connections** table defines relationships between records using roles such as Account as Employer and Contact as Employee. The hierarchy pulls in all contacts connected to the account through entries in the **Connections** table.  
    This creates a flexible hierarchy based on the roles defined in the **Connections** table.  
    To know more about the **Connections** table, see [Describe a relationship between tables with connection roles](/power-apps/developer/data-platform/describe-relationship-entities-connection-roles).  
- **Custom connections table**: This option uses a custom table you’ve created to define relationships between parent and child tables, allowing for advanced or organization-specific scenarios.  
    For example, you want to display contacts who serve as mentors for specific accounts, based on custom relationship tracking.  
    The custom **Mentorships** table includes fields such as `AccountId` and `ContactId` to define the mentorship relationship. When this relationship is selected, the application displays all contacts linked to accounts through the **Mentorships** table.  
    This creates a hierarchy based on the custom relationships defined in your table.  

## Related information

[Manage hierarchy visualization](manage-hierarchy-visualizations.md)
