---
title: Design and publish hierarchies
description: Learn how to design and publish hierarchies to better understand your data.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 12/05/2025
ms.custom: bap-template 
---

# Design and publish hierarchies

As an administrator, you can design and publish a hierarchy that allows your organization to visualize and work with hierarchical data. You can design multiple hierarchies to show different relationships,or provide alternative views of the data, such as showing only active records or filtering by specific countries/regions.  
Depending on your business requirements, you can create the following types of hierarchies:  

- [Single table (self-referential)](hierarchy-visualization.md#single-table)  
- [Multi-table](hierarchy-visualization.md#multi-table)  
- [Hybrid hierarchies](hierarchy-visualization.md#hybrid), which combine both single and multi-table relationships.  

## Prerequisites

Before you design and publish a hierarchy, ensure the following prerequisites are met:

- You must have administrator privileges.  
- Make sure the tables you used to design the hierarchy have the required relationships to establish parent-child relationships.  
    - For a single-table hierarchy, the table must include an N:1 self-referential relationship, where each row points to its parent row.  
    - For multi-table hierarchies, ensure the tables have N:1, 1:N, and N:N relationships defined between them.  
- For custom tables, ensure that rows can reference a parent row in the same table. If the relationship doesn't exist, [you need to create it](/power-apps/maker/data-platform/create-edit-entity-relationships).  

## Design and publish

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
1. Select **New hierarchy** and then enter a name for the hierarchy.  
1. [Configure the root node of the hierarchy](#configure-the-root-node-of-the-hierarchy).  
    > [!NOTE]
    > If you're creating a single table hierarchy, adding child nodes isn't required. After configuring the root node, proceed to step 6 to complete the process.  
1. [Configure the child node](#configure-the-child-node).  
1. Select **Save**.  
1. Select **Preview** to do the following tasks before publishing the hierarchy:  
    - Interact with the hierarchy as a user would, such as expanding and collapsing nodes, viewing details, and performing quick actions.  
    - Change settings and preview changes until you’re satisfied with the results.  
    - Change data you view by selecting the record name at the top of the preview window.  
    - [Troubleshoot the hierarchy design](#troubleshoot-a-hierarchy) before publishing it in the organization.  
1. (Optional) [Grant access to the hierarchy](#grant-access-to-hierarchies).  
    After you grant access to users, you don't need to repeat this step unless you want to change access permissions.  
1. Select **Publish** and then select **OK** on the confirmation message.  
    The hierarchy is active and available to users to view and interact with.  

## Configure the root node of the hierarchy

Configure the root node of the hierarchy by selecting the desired table. The table is the starting point for the hierarchy.  

1. In the hierarchy designer page, select **Add** and choose the desired table with the self-referential relationship. Here, we're adding **Account** table.  

    :::image type="content" source="media/hv-add-table.png" alt-text="Screenshot of selecting the Add table option in the hierarchy designer page.":::

    The **Settings** pane opens on the right side of the page.  
1. In the **General** tab, define child-parent relationship, and choose view and forms:  

    | Setting | Description |
    |---------|-------------|
    | Expand all levels | Enable the option to show all child records under the parent node in the hierarchy. When users open the hierarchy, it shows all child records under the parent node. For example, if the parent account is **Contoso** and has four child accounts, the four child accounts under **Contoso** appear.<br>If the option isn't enabled, one tile represents the parent account, and the hierarchy links all child records to it regardless of their actual parent-child relationship. For example, if the parent account **Contoso** has child accounts in different regions such as North America, Europe, and Asia, the **Contoso** tile shows all child accounts regardless of region. |
    | Select the column with the parent ID | This option is available only when you enable the **Expand all levels** option. Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows self-referential columns (columns that reference the same table) and cross-table relationships. Select one to link records for hierarchy. Here, we're selecting the `parentaccountid` column. This column has cross-table relationships with other tables such as **Lead**. |
    | Which view should be used | The hierarchy shows records from the selected table view. Accept the default or select another existing view. If needed, use the [Power Platform maker portal to define your own view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view). Here we're selecting the **Active Accounts** view to show only active accounts in the hierarchy. |
    | Which form should be shown as a tile | Select a form to display as a tile. To use a custom form, [create a quick view form](/power-apps/maker/model-driven-apps/create-edit-quick-view-forms#create-a-quick-view-form) in Power Apps and name it ***table*_Hierarchy_Tile** for easy identification. A maximum of seven fields can be displayed. Only fields that show basic data types (strings, dates, and numbers) are supported. Show or hide field labels on the form to control the labels on the tile. Customize the form to fit your needs, such as concatenating fields to display as one row.<br>For example, add the name and mobile number in the same row by using the formula: `Concatenate('Account Name' & " " & 'Main Phone')`. To learn more about adding formula columns, see [Work with formula columns](/power-apps/maker/data-platform/formula-columns). |
    | Which form should be shown as details | Select which form you want to show for the **Details** pane when a tile is selected. If none of the default forms meet your needs, you can [Create a form in the Power Apps maker portal](/power-apps/maker/model-driven-apps/create-and-edit-forms) to include only the fields you want. The details pane can show any form, and go full screen, so you can use the same form here that is typically used in Dynamics 365 Sales.<br>For example, for an account hierarchy, you can use the **Account** form, which is the same form used by application when viewing an account. |

    :::image type="content" source="media/hv-account-settings-general-tab.png" alt-text="Screenshot of the general tab in the account table settings pane in the hierarchy  designer page.":::

1. In the **Tile display option** tab, customize tile appearance:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | Tiles can optionally show or hide a circled image for the record. When enabled, if no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** doesn't have an image, her tile would be displayed as **MC**. If initials aren't available, the default icon for the table is shown. |
    | Show quick actions for this table | Enable this option to show quick actions (**...**) on the tile for the child table. Quick actions allow users to perform common tasks directly from the tile such as show in form and Add new record.<br>**Note**: The quick actions are displayed only when you publish or preview the hierarchy. |
    | Tile size | Select the width and height for the tile in pixels and then choose the color for the tile border. |
    | Color | Select the top header color for the tile in Hex format. Here, we're using **#0078D4** for the blue color. |

    > [!NOTE]
    > - These settings are applied only to this tile in this hierarchy.
    > - We recommend using consistent tile sizes and layouts for a cohesive look.

    :::image type="content" source="media/hv-account-settings-tile-tab.png" alt-text="Screenshot of the tile display option tab in the account settings pane in the hierarchy designer page.":::

1. If you're configuring a multi-table or hybrid hierarchy, [add child nodes](#configure-the-child-node). For single table hierarchies, you can skip this step.  
1. Save the hierarchy, and [continue from step 7 in the design and publish procedure](#design-and-publish).  

## Configure the child node

Child nodes are added for cross-table or hybrid hierarchies to show related records from other tables. You can add multiple child nodes to design complex hierarchies that represent your business data accurately. After you configure the root node, follow these steps to add child nodes:
  
1. Under the root node, select the add icon below the tile and enter a name for the child node. Here, we're adding **Contact** table as a child node to the **Account** table.  
1. Select a table and then select **Add**. Here, we're selecting the **Contact** table.  
    The **Settings** pane opens on the right side of the page.  
1. In the **General** tab, configure relationship settings with the root node table, define child-parent relationship, and choose view and forms
  
    | Setting | Description |
    |---------|-------------|
    | Branch display name | By default, the name is added based on the table name. If you want to, enter a different name for the branch display and this is shown in the hierarchy to identify the branch through the name. |
    | Choose parent-child relationship | Choose a relationship type for the child table with the parent table depending on your business needs. The following options are available:<br>&nbsp;• Contacts with matching {Parent_ID}<br>&nbsp;• Contacts with matching {Parent_Account_team}<br>&nbsp;• {Primary_Contact} for the account<br>&nbsp;• Dataverse connections table<br>&nbsp;• Custom connections table<br>To understand more about the relationship types, see [Relationship selection options for child node](#relationship-selection-options-for-child-node). |
    | Expand all levels  | Enable the option to show all child records under the parent node in the hierarchy. When users open the hierarchy, it shows all child records under the parent node. For example, if the parent account is **Contoso** and has four child accounts, the four child accounts under **Contoso** appear.<br>If the option isn't enabled, one tile represents the parent account, and the hierarchy links all child records to it regardless of their actual parent-child relationship. For example, if the parent account **Contoso** has child accounts in different regions such as North America, Europe, and Asia, the **Contoso** tile shows all child accounts regardless of region. |
    | Select the column with the parent ID | This option is available only when the **Expand all levels** option is enabled. Select the column that contains the parent ID for the hierarchy. For example, the `parent account ID` column in the **Account** table defines the parent-child relationship. The list shows self-referential columns (columns that reference the same table) and cross-table relationships. Select one to link records for hierarchy. Here, we're selecting the `parentaccountid` column. This column has cross-table relationships with other tables such as **Lead**. |
    | Which view should be used | The hierarchy shows records from the selected table view. Accept the default or select another existing view. If needed, use the [Power Platform maker portal to define your own view](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view). Here we're selecting the **Active Accounts** view to show only active accounts in the hierarchy. |
    | Which form should be shown as a tile | Select a form to display as a tile. To use a custom form, [create a quick view form](/power-apps/maker/model-driven-apps/create-edit-quick-view-forms#create-a-quick-view-form) in Power Apps and name it ***table*_Hierarchy_Tile** for easy identification. A maximum of seven fields can be displayed. Only fields that show basic data types (strings, dates, and numbers) are supported. Show or hide field labels on the form to control the labels on the tile. Customize the form to fit your needs, such as concatenating fields to display as one row.<br>For example, add the name and mobile number in the same row by using the formula: `Concatenate('Account Name' & " " & 'Main Phone')`. To learn more about adding formula columns, see [Work with formula columns](/power-apps/maker/data-platform/formula-columns). |
    | Which form should be shown as details | Select which form you want to show for the **Details** pane when a tile is selected. If none of the default forms meet your needs, you can [Create a form in the Power Apps maker portal](/power-apps/maker/model-driven-apps/create-and-edit-forms) to include only the fields you want. The details pane can show any form, and go full screen, so you can use the same form here that is typically used in Dynamics 365 Sales.<br>For example, for an account hierarchy, you can use the **Account** form, which is the same form used by application when viewing an account. |  

    :::image type="content" source="media/hv-contact-settings-general-tab.png" alt-text="Screenshot of the general tab in the contact table settings pane in the hierarchy designer page.":::

1. In the **Tile display option** tab, customize tile appearance:  

    | Setting | Description |
    |---------|-------------|
    | Show picture | Tiles can optionally show or hide a circled image for the record. When enabled, if no image is available, the initials of the record will be shown instead. For example, if **Maria Campbell** doesn't have an image, her tile would be displayed as **MC**. If initials aren't available, the default icon for the table is shown. |
    | Show quick actions for this table | Enable this option to show quick actions (**...**) on the tile for the child table. Quick actions allow users to perform common tasks directly from the tile such as show in form and Add new record.<br>**Note**: The quick actions are displayed only when you publish or preview the hierarchy. |
    | Tile size | Select the width and height for the tile in pixels and then choose the color for the tile border. |
    | Color | Select the top header color for the tile in Hex format. Here, we're using **#0078D4** for the blue color. |

    > [!NOTE]
    > - These settings are applied only to this tile in this hierarchy.
    > - We recommend using consistent tile sizes and layouts for a cohesive look.

    :::image type="content" source="media/hv-account-settings-tile-tab.png" alt-text="Screenshot of the tile display option tab in the account settings pane in the hierarchy designer page.":::  

1. Repeat steps 2 to 4 to add more child nodes as required.  
1. After adding all child nodes, save the hierarchy, and [continue from step 7 in the design and publish procedure](#design-and-publish).

## Troubleshoot a hierarchy  

Troubleshooting mode helps you understand why certain results appear or don’t appear in your design. Use this mode when the output doesn't match your expectations. If necessary, you can share the details with your technical support team or Microsoft customer support to resolve any issues.  

**Open the troubleshooting mode**:

In the hierarchy designer, select **Preview** to switch to preview mode, the bug icon appears on the hierarchy designer toolbar. Select the bug icon to open troubleshooting mode.  

:::image type="content" source="media/hierarchy-visualization-troubleshooting-icon.png" alt-text="Screenshot of the hierarchy troubleshooting icon.":::

**Use the troubleshooting mode**:

When troubleshooting mode is open, a bug icon appears on each connection (node) in the hierarchy. It provides a clear description of what is shown and why.  

:::image type="content" source="media/hierarchy-visualization-troubleshooting-mode.png" alt-text="Screenshot of the hierarchy troubleshooting mode.":::

Select the icon and the **Troubleshooting info** dialog box appears with detailed information about that node.  

:::image type="content" source="media/hierarchy-visualization-troubleshooting-dialog.png" alt-text="Screenshot of the hierarchy visualization troubleshooting dialog.":::  

The dialog box includes the following sections:

| Section | Description |
|---------|-------------|
| Explanation | Why records are included or excluded based on the current configuration of the hierarchy. |
| Result summary | Shows the number of records included and excluded at that node. |
| Results list | Displays a table version of the same query shown in the hierarchy for easier review. The table includes all records that are active and inactive. By default, the **Use view filters** checkbox is selected to view only active records. Clear the checkbox to view inactive records as well. |
| Query | Displays the internal query used to generate the results at that node. |
| Details | Contains additional information such as the entity type, view used for the node, relationship type with the parent node, and columns queried for that node. |

Select **Copy** to copy the troubleshooting information to the clipboard. Share it with your technical support team handling the issue or with Microsoft customer support to resolve the issue.

>[!NOTE]
>To exit the troubleshooting mode, select the troubleshooting icon again on the hierarchy designer toolbar.  

## Grant access to hierarchies  

To allow users in your organization to view hierarchies, or admins in your organization to design hierarchies, you must first grant the appropriate security roles access to the **Hierarchy configuration** table. Follow these steps:  
  
1. In [the Power Platform Admin center](https://admin.powerplatform.microsoft.com/), select the environment.  
1. In the **Access** section, under **Security roles**, select **See all**.  
1. Open the desired security role. Change the filter to **Show all tables** and search the **Hierarchy Configuration** table.  
1. Select **More Actions** (**...**), and then select **Permission Settings**.  
    Grant the following permissions based on the level of access you want to provide:  
    - **Reference** permission to allow the security role to **view hierarchies**.  
    - **Full Control** permission to allow the security role to **design and publish hierarchies** to the organization.

## Relationship selection options for child node

When you add a child node, you must select a relationship type to define how the child table relates to the parent table. The available relationship options depend on the tables you're working with. Here are some common relationship types you might encounter:

| Relationship type | Description | Example |
|-------------------|-------------|---------|
| Contacts with matching *Parent_ID* | This option uses a direct lookup field such as `ParentCustomerId` on the child table to link each record to its parent table. It’s the classic parent-child relationship. | You want to display all contacts associated with a specific account in a hierarchical view.<br>The **Contact** table includes a field `ParentCustomerId`, which establishes a relationship to the **Account** table. When this relationship is selected, the application displays all contacts where&mdash;`Contact.ParentCustomerId` = `Account.AccountId`.<br>This creates a parent-child hierarchy between the account and its related contacts.  |
| Contacts with matching *Parent_Account_team* | This option links child records to parent based on a shared team or group field, not a direct parent-child relationship. It's useful when child records are associated with parent records through a team. | You want to display  all contacts who belong to the same team as the account they’re associated with.<br>The **Contact** table includes a field `TeamId`, which indicates the team the contact belongs to. The **Account** table also has a `TeamId` field. When this relationship is selected, the application displays all contacts where&mdash;`Contact.TeamId` = `Account.TeamId`.<br>This creates a team-based hierarchy between accounts and contacts. |
| *Primary_Contact* for the account | This option uses a specific field on the parent table to show the main contact for each parent record. | You want to identify and display the key contact associated with each account.<br>The **Account** table includes a `PrimaryContactId` field and the hierarchy uses this field to locate the contact whose `ContactId` matches the account’s `PrimaryContactId`.<br>This creates a direct link where each account points to its primary contact.|
| Dataverse connections table | This option uses the standard **Dataverse Connections** table, which allows you to model flexible, many-to-many relationships with roles such as Advisor, Family member, and so on. | You want to display all contacts connected to an account through various roles defined in the **Connections** table.<br>The **Connections** table defines relationships between records using roles such as Account as Employer and Contact as Employee. The hierarchy pulls in all contacts connected to the account through entries in the **Connections** table.<br>This creates a flexible hierarchy based on the roles defined in the **Connections** table.<br>To know more about the **Connections** table, see [Describe a relationship between tables with connection roles](/power-apps/developer/data-platform/describe-relationship-entities-connection-roles). |
| Custom connections table | This option uses a custom table that is created to define relationships between parent and child tables, allowing for advanced or organization-specific scenarios. | You want to display contacts who serve as mentors for specific accounts, based on custom relationship tracking.<br>The custom **Mentorships** table includes fields such as `AccountId` and `ContactId` to define the mentorship relationship. When this relationship is selected, the application displays all contacts linked to accounts through the **Mentorships** table.<br>This creates a hierarchy based on the custom relationships defined in your table. |

## Related information

[Manage hierarchies](manage-hierarchy-visualizations.md)
