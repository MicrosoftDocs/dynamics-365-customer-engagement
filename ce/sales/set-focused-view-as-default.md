---
title: Configure focused view
description: Configure focused view manually for entities other than contact, account, lead, and opportunity and set it as the default view for any entity and allow a record automatically refresh when updated.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to 
ms.date: 01/03/2025
ms.custom: bap-template 
---

# Configure focused view

In focused view, sellers can view and manage their CRM records and their associated activities on one page. This view makes it easier for sellers to stay focused on their tasks, saving time by eliminating the need to navigate through multiple screens. It also allows sellers to better organize and prioritize their tasks.

> [!NOTE]
>
> - Focused view is now available for the **Activities** entity. However, you must [opt in for early access features](/power-platform/admin/opt-in-early-access-updates).  
> - Focused view is not available for the **Queue** entity.

Configuring the focused view as default is allowed only for the contact, lead, account, and opportunity entities. Also, if you want to configure focused view as default for custom and other entities, see [Configure as default for other entities](#configure-as-default-for-other-entities).

Also, you can configure to automatically refresh a record at specified time intervals when it is updated. For more information, see [Automatically refresh records](#refresh-records-automatically)

## Prerequisites

- You must have the **System Administrator** or similar security role to perform these configurations.  
- Ensure that the [focused view is enabled for your organization](enable-focused-view.md).  

## Configure as default for contact, account, lead, and opportunity entities

> [!NOTE]
> To view the **Default view** option, ensure that you have opted in for [early access features](/power-platform/admin/opt-in-early-access-updates).

By default, focused view is enabled for the lead entity. However, to improve the experience and eliminate the need for manual switching to the focused view, you can configure focused view as the default view for contact, account, and opportunity entities for all users. 

To configure focused view as default, follow these steps:

1. Open the contact, lead, account, or opportunity grid.  
1. Change to focused view and in the work item section, select **More options** > **Settings**.
1. On the **Settings** pane, select **Default view**.

    :::image type="content" source="media/fv-settings-set-as-default.png" alt-text="Screenshot of configuring focused view as default.":::

1. Turn on the toggle to enable focused view as default for the required entities.  
1. Save and close the settings pane.

   Focused view is now set as the default view for the selected entities.  

## Configure as default for other entities

To configure and enable focused view as default for custom and other entities, follow these steps:

1. In the app, select the **Settings** icon, and then select **Advanced Settings**.  
   > [!NOTE]
   > The **Advanced Settings** page is moving from the web client to an Unified Interface app. If your organization has enabled the public preview of the **Advanced settings redirection** feature, you’ll see the settings open in the Power Platform Environment Settings app. Find more information about the app and navigation path in [Advanced settings in the new experience](advanced-settings-new-experience.md).
1. On the navigation bar, select **Settings** > **Customization** > **Customizations** > **Customize the System**.  
1. In the solution explorer, under **Components**, expand Entities, and then select an entity. For example, Invoice.  
1. On the **Controls** tab, select **Add Control**.  
1. In the **Add Control** dialog box, select **Focused view**, and then select **Add**.  
1. **Read-only grid** is the default option, so when users select a table from the site map, they see a read-only grid of invoice. To make the focused view the default view instead, select the corresponding Focused view option buttons.  

    :::image type="content" source="media/fv-settings-set-as-default-other-entities.png" alt-text="Screenshot of configuring focused view as default for other entities.":::  
1. Save and publish the configurations.  

Focused view is now set as the default view for the selected entity.

## Refresh records automatically

Records aren't updated automatically in focused view. However, you can configure focused view to automatically refresh records at specified time intervals. To configure automatic refresh for a record, follow these steps:

1. Open the contact, lead, account, or opportunity grid.  
1. Change to focused view and in the work item section, select **More options** > **Settings**.
1. On the **Settings** pane, select **Auto-refresh**.

    :::image type="content" source="media/fv-settings-enable-auto-refresh.png" alt-text="Screenshot of configuring focused view to auto refresh a record when updated.":::  
1. Turn on the **Auto-refresh** toggle to enable automatic refresh of the grid.
1. Select the time interval for the records in the view to refresh. The time interval can be set to 15, 18, or 20 minutes.
1. Save and close the **Settings** pane.

Records will now automatically refresh at the specified time interval.

## Related information

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-focused-view.md)

