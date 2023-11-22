---
title: Customize the Microsoft 365 integration for Field Service
description: Learn how to tailor the Micorosoft 365 integrations for Dynamics 365 Field Service to your business
ms.date: 11/21/2023
ms.topic: how-to
author: matthidinger
ms.author: mahiding
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Customize the Microsoft 365 integration for Field Service

Customize the work order and booking experiences to help frontline managers and workers accomplish their tasks faster by filling in and retrieving the specific pieces of information they need, when they need it. As an admin, customize the work order form with the most important information for your organization. Any fields you add to the form are readily available to your users when creating and updating a work order in Outlook or Teams. In Outlook, Copilot will also attempt to populate those fields if there is relevant information provided in the email. Customize the booking experience with the key details for your organization so workers fill out that information when updating their bookings.

We currently support customization of the **Work Orders** and **Bookable Resource Booking** experiences.

:::image type="content" source="media/fsp-flw-customize-overview.png" alt-text="Example of a customized work order form in Field Service using Outlook":::

<!--- TODO: Documentation image showing Outlook with customized fields, and maybe arrows showing which pieces of content are extracted from the email into the form 
<Screenshot of Teams> --->

## Prerequisites

- Global admin or Exchange admin permissions in the Microsoft 365 Admin Center.
- Environment is in a [supported geography, region, and language.](flw-overview.md#supported-geographies-regions-and-languages)
- One of more of the [Microsoft 365 integrations for Field Service have been deployed.](flw-admin.md)

## Create or edit a custom view

The following steps use work order as an example. You can use these steps to create or edit a custom view for bookable resources by searching for bookings.

1. From your Teams Field Service **Home** page, select **Settings**, then **Customize views**.

1. Select the environment you want to customize.

   :::image type="content" source="media/fsp-customize-views.png" alt-text="Field Service Settings page with Customize views.":::

1. Select **Edit views in Power Apps**. Power Apps automatically opens to the **Tables** page for the specified environment.

1. Select **All** and then search for **work order**.

   :::image type="content" source="media/fsp-power-apps-tables.png" alt-text="Power Apps Tables page with work order search highlighted.":::

1. Open the Work Order table.

1. Under **Data experiences**, select **Views**. A list of all public and customized views displays.

   :::image type="content" source="media/fsp-power-apps-views.png" alt-text="Power Apps Work Order table page with Views highlighted.":::

1. To create a new view, select **New view**. Enter a name and optional description and select **Create**. The **Work Order Number** column automatically displays.

   To edit a view, open the view.

1. To add columns, select **View column**. Make sure you have the following required columns and optionally add other columns. Or select **Table columns** in the left navigation and drag the table columns into your view.

   - **Service Account**
   - **System Status**
   - **Work Order Type**
   - **Work Order Summary**

   :::image type="content" source="media/fsp-power-apps-view-columns-to-add.png" alt-text="Power Apps Work Order Table columns page.":::

1. Continue to customize your view:

   - To change the column filtering select the header of the column where the filter is required, and then in the dropdown list select **Filter by**.
   - To change the column sorting select the header of the column where sorting is needed then select **Sort A-Z**, **Sort Z-A**, **Sort descending**, or **Sort ascending**.
   - Configure column width by selecting and dragging the column to the desired position.
   - Reorder columns by dragging a column to the desired position.

1. Select **Save and publish**.

1. Return to Teams and select **Refresh data**. Select the new view and select **Publish**. Users now can go to Outlook or Teams and see the new view for their work order creation and management. Filtering is now dynamic based on the columns you added to the view.

## Add or edit columns

You can [modify the Field Service columns](field-service-customize-columns-fields.md) that come with Dynamics 365 Field Service.

## Next steps

- [General customization best practices](field-service-customization-best-practices.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]