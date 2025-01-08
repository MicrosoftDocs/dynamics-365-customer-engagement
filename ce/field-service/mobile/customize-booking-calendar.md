---
title: Customize the booking view
description: Learn how to customize the default booking view in the Field Service mobile experience.
ms.date: 08/28/2024
ms.topic: article
author: JonBaker007
ms.author: jobaker
---

# Customize the booking view

## [Unified Interface UX](#tab/vCurrent)

By default, the booking calendar control shows a predefined set of details associated with bookings.

You can customize this control to include up to three more columns with optional labels or change the incident type column.

If you're using the mobile app offline, be sure the record types from which attributes are included on the calendar are also included in your mobile offline profile.

For a guided walkthrough using the classic designer, check out the following video.
>
> [!VIDEO https://learn-video.azurefd.net/vod/player?id=af1f694e-21ad-4805-b8ef-426da1f92df7]

### Add the columns to the Bookings view

The new fields can be modified to show data from any column in the *Booking* view of the *Bookable Resource Booking* table.

[Add columns to model-driven app views](/power-apps/maker/model-driven-apps/choose-and-configure-columns#adding-columns) that have a relationship to the *bookable resource booking* table. For example, to show *Work Order Priority*, select the *Work Order* table, then add the *Priority* column to the view. Note the name of the column—you'll need it when customizing the field. In our example, the name is *msdyn_priority*.

> [!NOTE]
> For columns from a different table, you must create a relationship between the bookable resource booking and that table. When referencing the relationship in the control, be sure to reference the full lookup field name as `fieldName.Attribute`.

### Configure the Booking Calendar Control to show the columns

Once the view has the desired columns, open Advanced Settings and go to **Customizations**. Select the bookable resource booking entity, and then select **Controls** and **Booking Calendar Control** to configure the control properties.

:::image type="content" source="../media/mobile-2020-calendar-control-2.png" alt-text="Editing booking calendar control properties in Power Apps.":::

To configure fields, select the **Edit icon** next to the field. Input the reference to the field as an attribute of bookable resource booking, or as `linkedEntity.attribute`. In this example, we added the work order priority (`msdyn_workorder.msdyn_priority`) as **Custom Field 1**.

You can also configure the optional custom field label associated with the custom field. This label is displayed as entered, with an added colon after the field and before the value. In our example, we entered *Priority*.

Fields without data are hidden.

:::image type="content" source="../media/mobile-2020-calendar-control-3.png" alt-text="Field Service mobile app with a customized calendar agenda view.":::

Custom fields are also shown on the calendar's day view when the booking duration is long enough to support the extra text. Custom data is also shown when opening booking details from the map view.

> [!NOTE]
> If you have configured multiple views for the mobile app, we recommend that you include the new fields into each view that can be accessed from the mobile app.

## [New mobile UX](#tab/vNext)

The agenda view is the default view in the [new user experience of the Field Service mobile app](set-up-field-service-mobile.md). It shows the list of bookings in chronological order that are assigned to the user who's signed in to the app. Select **Home** in the bottom navigation to return to the home page. By default, the agenda view shows the following details associated with each booking:

- Account
- Incident type
- Address
- Booking status
- Start time and duration

:::image type="content" source="../media/agenda-view.png" alt-text="Device render of a mobile device showing bookings on the home page in the agenda view.":::

The agenda view shows data from the *Bookable Resource Booking* table and related tables. Booking status, start time, and duration always show. You can customize which data to show by adding, removing, or changing the order of the data columns. As a best practice, [consider using a solution to apply your customizations](/power-apps/maker/data-platform/solutions-overview).

Go to Power Apps and navigate to **Tables** > **Bookable Resource Booking** > **Views** and customize **Bookings – Agenda View**.

:::image type="content" source="../media/agenda-view-power-apps.png" alt-text="Agenda view in the list of views in the Power Apps maker experience.":::

Columns in this view show on a booking card within the agenda. We recommend keeping the number of columns below 10 to maintain readability and performance. Don't add more than 25 columns to the view. To learn how to configure a view, see [Choose and configure columns in model-driven app views in Power Apps](/power-apps/maker/model-driven-apps/choose-and-configure-columns).  

> [!NOTE]
> You can't set other views as default booking view in the new mobile user experience. However, you can still change the default view for other tables.

---

[!INCLUDE [footer-banner](../../includes/footer-banner.md)]
