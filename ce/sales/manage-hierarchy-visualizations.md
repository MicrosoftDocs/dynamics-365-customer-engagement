---
title: Manage hierarchy visualization
description: Learn how to manage hierarchy visualizations to keep them relevant and useful for users.
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.collection: 
ms.date: 10/09/2025
ms.custom: bap-template 
---

# Manage hierarchy visualization

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As an administrator, you can manage hierarchy visualizations to ensure they're up-to-date and relevant for users. You can edit, delete, or unpublish hierarchy visualizations as needed.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

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

## Restricting access to a hierarchy visualization

The hierarchy view doesn't change what data a user can view. If the user can view data in a form, the hierarchy view uses those same permissions to display the data hierarchically. If a user doesn't have access to a record, that record won't appear in the hierarchy view.  
To restrict access to a hierarchy visualization, you can change the permissions to a security role on the **Hierarchy Configuration** table in [the Power Apps portal](https://make.powerapps.com/).  
Each hierarchy is defined by a single row in the Hierarchy Configuration table.  
- To create a hierarchy&mdash;provide **CREATE** and **UPDATE** permissions to the table.  
- To edit a hierarchy&mdash;provide the **UPDATE** permission to the row for that hierarchy.  
- To view a hierarchy&mdash;requires the **VIEW** permission to the row for that hierarchy.  

## Related information

[Create and publish a hierarchy visualization](create-activate-hierarchy-visualizations.md)  