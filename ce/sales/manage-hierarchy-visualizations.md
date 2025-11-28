---
title: Manage hierarchy visualization
description: Learn how to manage hierarchy visualizations to keep them relevant and useful for users.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 11/21/2025
ms.custom: bap-template 
---

# Manage hierarchy visualization

As an administrator, you can manage hierarchy visualizations to ensure they're up-to-date and relevant for users. You can edit, delete, or unpublish hierarchy visualizations as needed.

## Edit a hierarchy visualization

To edit a hierarchy visualization, follow these steps:

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
    A list of existing hierarchy visualizations is displayed.  
1. Select the hierarchy visualization you want to edit.
1. Make the necessary changes to the settings. To know the settings you can change, see [Configure the root node of the hierarchy](create-activate-hierarchy-visualizations.md#configure-the-root-node-of-the-hierarchy) and [Configure the child node](create-activate-hierarchy-visualizations.md#configure-the-child-node).  
1. Select **Save** to apply your changes.  
    The updated hierarchy visualization is now available for users.  

## Delete or unpublish a hierarchy visualization

If a hierarchy visualization is no longer needed, you can delete or unpublish it.

Follow these steps:

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **App Settings**.  
1. Under **General Settings**, select **Visual hierarchy**.  
    A list of existing hierarchy visualizations is displayed.  
1. Select the hierarchy visualization you want to delete or unpublish.
1. To delete the hierarchy, select **Delete** and on the confirmation message, select **Delete**.
    The hierarchy visualization is permanently deleted from your organization.  
1. To unpublish the hierarchy, select **Unpublish** and on the confirmation message, select **OK**.
    The hierarchy visualization is unpublished and no longer available to users. You can republish it later if needed by selecting **Publish**.  

## Troubleshoot a hierarchy 

Troubleshooting mode helps you understand why certain results appear or don’t appear in your design. Use this mode when the output doesn't match your expectations. If necessary, you can share the details with your technical support team or Microsoft customer support to resolve any issues.  

**Open the troubleshooting mode**:

Open a hierarchy visualization in the hierarchy designer and then select **Preview**. The designer switches to preview mode and the troubleshooting icon is displayed on the hierarchy designer toolbar.  
Select the troubleshooting icon to open troubleshooting mode.  

:::image type="content" source="media/hierarchy-visualization-troubleshooting-icon.png" alt-text="Screenshot of the hierarchy visualization troubleshooting icon.":::

**Use the troubleshooting mode**:

When the troubleshooting mode is open, an icon is displayed to each connection (node) in the hierarchy providing a clear description of what is being shown and why it's being shown.

:::image type="content" source="media/hierarchy-visualization-troubleshooting-mode.png" alt-text="Screenshot of the hierarchy visualization troubleshooting mode.":::

Selecting the icon opens a dialog box with troubleshooting information about that node. The information includes:  

- **Explanation** of why records are included or excluded based on the current configuration of the hierarchy.  
- **Result summary** that shows the number of records included and excluded at that node.  
- **Results list** displays a table version of the same query shown in the hierarchy for easier review. The table includes all records that are active and inactive. By default, the **Use view filters** checkbox is selected to view only active records. Clear the checkbox to view inactive records as well.  
- **Query** includes the internal query used to generate the results at that node.  
- **Details** contains additional information such as the entity type, view used for the node, relationship type with the parent node, and columns queried for that node.  

Select **Copy** to copy the troubleshooting information to the clipboard. Share it with your technical support team handling the issue or with Microsoft customer support to resolve the issue.

:::image type="content" source="media/hierarchy-visualization-troubleshooting-dialog.png" alt-text="Screenshot of the hierarchy visualization troubleshooting dialog.":::

>[!NOTE]
>To exit the troubleshooting mode, select the troubleshooting icon again on the hierarchy designer toolbar.

## Related information

[Create and publish a hierarchy visualization](create-activate-hierarchy-visualizations.md)  