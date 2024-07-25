---
title: Customize the Microsoft 365 integrations for Field Service
description: Learn how to tailor the Microsoft 365 integrations for Dynamics 365 Field Service to your business.
ms.date: 04/18/2024
ms.topic: how-to
author: matthidinger
ms.author: mahiding
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Customize the Microsoft 365 integrations for Field Service

Customize the work order and booking experiences to help frontline managers and workers accomplish their tasks faster by filling in and retrieving the specific pieces of information they need, when they need it.

As an admin, you can customize the views of work orders and bookings. You can also customize the labels for work orders.

Customize the work order form with the most important information for your organization. Any fields you add to the form are readily available to your users when creating and updating a work order in Outlook or Teams. In Outlook, Copilot also attempts to populate those fields if there's relevant information provided in the email. Customize the booking experience with the key details for your organization so workers fill out that information when updating their bookings.

The Microsoft 365 integrations for Field Service use views in Power Apps to customize the forms for users creating and editing work orders and bookings. Any fields added to the view show on the forms, in the order specified in the view. Required field indicators show which fields are required in the table definition. We currently support customized views of the **Work Orders** and **Bookable resource booking** experiences.

Use views to:
1. Reorder and remove fields
1. Toggle required fields
1. Add custom fields

:::image type="content" source="media/fsp-flw-customize-overview.png" alt-text="Example of a customized work order form in Field Service Outlook and Teams":::

The Microsoft 365 integrations for Field Service use table properties in Power Apps to customize work order labels. For example, if you prefer to call work orders jobs, you can customize these labels. We currently support customized labels for work orders.

## Prerequisites

- Exchange admin permissions in the Microsoft 365 Admin Center.
- Environment is in a [supported geography, region, and language.](flw-overview.md#supported-geographies-regions-and-languages)
- One of more of the [Microsoft 365 integrations for Field Service is deployed.](flw-admin.md)
- Field Service solution is version 8.8.98.36 or above. To update the solution, see [Update Field Service](update-field-service.md#dynamics-365-field-service).

## Create or edit a custom view

The following steps use work order as an example. You can use these steps to create or edit a custom view for bookings by searching for bookable resource booking. To select from existing views, see [Select a public or custom view.](#select-a-public-or-custom-view)

1. From your Teams Field Service **Home** page, select **Settings**, then **Customize views**.

1. Select the environment you want to customize.

   :::image type="content" source="media/fsp-customize-views.png" alt-text="Field Service Settings page with Customize views with environment and Edit views in Power Apps highlighted.":::

1. Select **Edit views in Power Apps**. Power Apps automatically opens to the **Tables** page for the specified environment.

   > [!TIP]
   > You can also access [Power Apps](https://make.powerapps.com/), select your environment, and then select **Tables**.

1. Select **All** and then search for **work order**. For bookings, search for **bookable resource booking**.

   :::image type="content" source="media/fsp-power-apps-tables.png" alt-text="Power Apps Tables page with work order search highlighted.":::

1. Open the Work Order table. For bookings, open the Bookable Resource Booking table.

1. Under **Data experiences**, select **Views**. A list of all public and customized views displays.

1. To edit a view, open the view.

   To create a new view, select **New view**. Enter a name and optional description and select **Create**. The **Work Order Number** column automatically displays.

1. To add columns, select **View column**. Or select **Table columns** in the left navigation and drag the table columns into your view.

   :::image type="content" source="media/fsp-power-apps-view-columns-to-add.png" alt-text="First four columns displayed on a work order in the work order list.":::

1. Make sure you have the following required columns and optionally add other columns. All columns added to the view can be used to filter the list of work orders. For Bookable resource booking, the **Crew** column isn't supported and shouldn't be used.

   | Work order        | Bookable resource booking |
   | ----------------- | ------------------------- |
   | Work Order Number | Name                      |
   | Service Account   | Work Order                |
   | System Status     | Resource                  |
   | Work Order Type   | Booking Status            |
   | Work Order Summary| Start Time                |
   |                   | End Time                  |
   |                   | Duration                  |
   |                   | Actual Arrival Time       |

   > [!NOTE]
   > The first four columns you select are the key fields shown in the list of work orders.
   > :::image type="content" source="media/fsp-first-four.png" alt-text="Power Apps Work Order Table columns page.":::

1. Continue to customize your view:

   - To change the column filtering, select the header of the column where the filter is required, and then in the dropdown list, select **Filter by**.
   - To change the column sorting, select the header of the column where sorting is needed, and then select **Sort A-Z**, **Sort Z-A**, **Sort descending**, or **Sort ascending**.
   - Configure column width by selecting and dragging the column to the desired position.
   - Reorder columns by dragging a column to the desired position.

1. Select **Save and publish**.

1. Return to Teams and select **Refresh data**. Select the new view under **Work orders** or **Bookings** and select **Publish**. Users now can go to Outlook or Teams and see the new view for their work order creation and management. Filtering is now dynamic based on the columns you added to the view.

## Select a public or custom view

Choose the view you want to appear for your frontline managers and workers. You can select a **Work orders** view and a **Booking** view. If you don't find a view you want, [create a custom view](#create-or-edit-a-custom-view).

1. From your Teams Field Service **Home** page, select **Settings**, then **Customize views**.

1. Select the environment you want to customize.

   :::image type="content" source="media/fsp-customize-views-select.png" alt-text="Field Service Settings page with Customize views and environment highlighted.":::

1. To choose a work order view, select from the drop-down list under **Work orders**.

1. To choose a booking view, select from the drop-down list under **Bookings**.

1. Select **Publish**. Users now can go to Outlook or Teams and see the new view for their work order creation and management.

## Add or edit columns

You can [modify the Field Service columns](field-service-customize-columns-fields.md) that come with Dynamics 365 Field Service. Related table columns are read-only and can't be filtered in the work order list. *File* type isn't supported and multi-select lookup fields aren't supported.

If a column is required but has a default that will be provided after the table is created, you might not want to include the field in the view. For example, if **Price List** is based on the selected **Service Account**, don't include **Price List** in the view.

## Create custom labels

You can customize the labels used for work orders to better match your organization's terminology.

1. From your Teams Field Service **Home** page, select **Settings**, then **Customize views**.

1. Select the environment you want to customize.

   :::image type="content" source="media/fsp-customize-views.png" alt-text="Field Service Settings page with Customize views with environment and Edit views in Power Apps highlighted.":::

1. Select **Edit views in Power Apps**. Power Apps automatically opens to the **Tables** page for the specified environment.

   > [!TIP]
   > You can also access [Power Apps](https://make.powerapps.com/), select your environment, and then select **Tables**.

1. Select **All** and then search for **work order**.

   :::image type="content" source="media/fsp-power-apps-table-properties.png" alt-text="Power Apps Tables page with Properties highlighted.":::

1. Select to the left of the Work Order table and select **Properties**. The **Edit table** pane displays.

1. Enter the **Display name** and **Plural name** of your choice.

1. Select **Save and publish**.

## Next steps

- [General customization best practices](field-service-customization-best-practices.md)
- [Create and edit views in Power Apps](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
