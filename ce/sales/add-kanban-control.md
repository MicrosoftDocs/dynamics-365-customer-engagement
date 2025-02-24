---
title: Add Kanban control to entities to opportunities or activities
description: Add the Kanban control to create Kanban views that help sellers to manage their opportunities or activities effectively.
ms.date: 01/31/2025
ms.topic: how-to
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-activitypointer
  - D365-UI-*
  - Dynamics 365
  - Sales
---
# Add the Kanban control to Opportunity or Activity tables

Add the Kanban control to create Kanban views that help sellers to manage their opportunities or activities effectively.

## Add the Kanban controls

Kanban views help salespeople to manage their opportunities and activities effectively. Add the Kanban control to the Opportunity and Activity entity so salespeople can use the Kanban views. Similar to other custom controls, Kanban control is supported on all views.

> [!IMPORTANT]
> - The Kanban control works only on the Opportunity and Activity tables.
> - The Kanban control is supported only on the main grid. It isn't currently supported on subgrids.
> - The Kanban control is not supported in the **Dynamics 365 for Phones** mobile app.

1. In the sales app, go to **Settings** > **Advanced Settings**.

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.

1. Select **Tables** and then search and select the **Opportunity** or **Activity** table.

    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then select the **Opportunity** or **Activity** table.

1. Select **Views** and then select any public view.  
    You can filter public views from the **View type** dropdown list.

1. Select a view and then select **Components**.  

1. In the **Components** pane, select **Add Component**.  

    If you don't see **Kanban** in the list, follow these steps:

    1. Select **Get more components**.  
    1. Select the **Built by Microsoft** tab and search for **Kanban**.  
    1. Select **Kanban** and then select **Add**.

1. Select **Kanban** and then select the surfaces where you want to show the Kanban control by default.

    :::image type="content" source="media/make-kanban-view-default.png" alt-text="Screenshot of the Edit kanban flyer with Web, Mobile, and Tablet selected.":::

1. Save the view.

1. Save and publish the changes.

## What you can't customize?

There are a few customization restrictions that you should be aware of:

- You can't add or remove fields from the cards in the Kanban view swim lanes.
- It isn't possible to have a role-based Kanban view.
- The Activity Kanban view is only available for the Status field. You can't configure the Activity Kanban view for an option set field other than 'Status'.
- For Opportunity Kanban view:
  - While you can customize the out-of-the-box 'Opportunity Sales Process' business process flow, you can't customize the Kanban view to use a business process flow other than the Opportunity Sales Process.
  - The Status-based Opportunity Kanban view is only available for the Status field. You can't configure this Kanban view for an option set field other than 'Status'.
  - In the Opportunity Kanban view, aggregation is supported only for the Estimated Revenue field of the Opportunity entity. You can't configure the Kanban view to have aggregation done on other fields.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[Work with opportunities in the Kanban view](opportunity-kanban-view.md)  
[Work with activities in the Kanban view](activity-kanban-view.md)

