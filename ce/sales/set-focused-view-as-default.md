---
title: Configure focused view and set it as the default view
description: Configure focused view manually for entities other than contact, account, lead, and opportunity and set it as the default view for any entity in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.topic: how-to 
ms.date: 01/12/2024
ms.custom: bap-template 
---

# Configure focused view and set it as default

In focused view, sellers can view and manage their CRM records and their associated activities on one page. This view makes it easier for sellers to stay focused on their tasks, saving time by eliminating the need to navigate through multiple screens. It also allows sellers to better organize and prioritize their tasks.

> [!NOTE]
>
> Focused view is not available for the **Activities** entity.

Configuring the focused view as default is allowed only for the contact, lead, account, and opportunity entities. Also, if you want to configure focused view as default for custom and other entities, see [Configure focused view for other entities](#configure-focused-view-for-other-entities).

You must have the **System Administrator** or similar security role to perform these configurations. 

## Prerequisites

Before you configure focused view, ensure that the [focused view is enabled for your organization](enable-focused-view.md).

## Configure focused view as default

> [!NOTE]
> To view the **Default view** option, ensure that you have opted in for early access features. More information: [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates)

By default, focused view is enabled for the lead entity. However, to improve the experience and eliminate the need for manual switching to the focused view, you can configure focused view as the default view for contact, account, and opportunity entities for all users. 

To configure focused view as default, follow these steps:

1. Open the contact, lead, account, or opportunity grid.  
1. Change to focused view and in the work item section, select **More options** > **Settings**.
1. On the **Settings** pane, select **Default view**.

    :::image type="content" source="media/fv-settings-set-as-default.png" alt-text="Screenshot of configuring focused view as default.":::

1. Turn on the toggle to enable focused view as default for the required entities.  
1. Save and close the settings pane.

   Focused view is now set as the default view for the selected entities.  

## Configure focused view for other entities

To configure and enable focused view as default for custom and other entities, follow these steps:

1. In the app, select the **Settings** icon, and then select **Advanced Settings**.  
1. On the navigation bar, select **Settings** > **Customization** > **Customizations** > **Customize the System**.  
1. In the solution explorer, under **Components**, expand Entities, and then select an entity. For example, Invoice.  
1. On the **Controls** tab, select **Add Control**.  
1. In the **Add Control** dialog box, select **Focused view**, and then select **Add**.  
1. **Read-only grid** is the default option, so when users select a table from the site map, they see a read-only grid of invoice. To make the focused view the default view instead, select the corresponding Focused view option buttons.  
    :::image type="content" source="media/fv-settings-set-as-default-other-entities.png" alt-text="Screenshot of configuring focused view as default for other entities.":::  
1. Save and publish the configurations.  

Focused view is now set as the default view for the selected entity.

### See also

[View and manage records in focused view](focused-view.md)  
[Focused view FAQs](faq-sales.yml#focused-view)
