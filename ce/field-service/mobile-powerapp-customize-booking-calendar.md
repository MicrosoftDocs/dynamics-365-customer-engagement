---
title: Customize the booking view in the Dynamics 365 Field Service mobile app
description: Learn how to customize the default booking view in the Field Service mobile experience.
ms.date: 12/20/2023
ms.topic: article
author: JonBaker007
ms.author: jobaker
---

# Customize the booking view in the Dynamics 365 Field Service mobile app

## [Unified Interface UX](#tab/vCurrent)

By default, the booking calendar control shows the following details associated with the booking:

- **Account**
- **Incident Type**
- **Address**
- **Booking Status**
- **Start Time and Duration**

You can customize this control to include up to three more fields with optional labels and change the incident type. The new fields can be modified to show data from any column in a view of the **Bookable Resource Booking** table.

If you're using the mobile app offline, be sure the record types from which attributes are included on the calendar are also included in your mobile offline profile.

For a guided walkthrough, check out the following video.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWJJdl]

To customize the control, edit the associated and specify data for the booking calendar control.

To set up your view, go to **Advanced Settings** > **Customization** > **Customize the System** > **Entities** and select **Bookable Resource Booking**.

Select **Views**, then select the view for mobile. By default, it's the **Bookings** view.

Add or remove any column from tables that have a relationship to the *bookable resource booking* table. For example, to show **Work Order Priority**, select **Work Order**, then add the **Priority** column to the view. Note the name of the column, you need it when customizing the field. In our example, the name is *msdyn_priority*.

> [!Note]
> For columns from a different table, you must create a relationship between the bookable resource booking and that table. When referencing the relationship in the control, be sure to reference the full lookup field name as `fieldName.Attribute`.

> [!div class="mx-imgBorder"]
> ![Editing a view to add new attribute in Power Apps](./media/mobile-2020-calendar-control-1.png)

Once the view has desired columns, return to **Customizations**. Select the bookable resource booking, then select **Controls** and **Booking Calendar Control** to configure the control properties.

> [!div class="mx-imgBorder"]
> ![Editing booking calendar control properties in Power Apps.](./media/mobile-2020-calendar-control-2.png)

To configure fields, select the **Edit icon** next to the field. Input the reference to the field as an attribute of bookable resource booking, or as `linkedEntity.attribute`. In this example, we added the work order priority (`msdyn_workorder.msdyn_priority`) as **Custom Field 1**.

You can also configure the optional custom field label associated with the custom field. This label is displayed as entered, with an added colon after the field and before the value. In our example, we entered *Priority*.

Fields without data are hidden.

> [!div class="mx-imgBorder"]
> ![Field Service mobile app with a customized calendar agenda view.](./media/mobile-2020-calendar-control-3.png)

Custom fields are also shown on the calendar's day view when the booking duration is long enough to support the extra text. Custom data is also shown when opening booking details from the map view.

> [!div class="mx-imgBorder"]
> ![Field Service mobile app with customized calendar day view.](./media/mobile-2020-calendar-control-4.png)

> [!div class="mx-imgBorder"]
> ![Field Service mobile app with customized calendar map view.](./media/mobile-2020-calendar-control-5.png)

> [!Note]
> If you have configured multiple views for the mobile app, it is recommended you include the new fields into each view that can be accessed from the mobile app.

## [New mobile UX (preview)](#tab/vNext)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The agenda view is the default view in the [new user experience of the Field Service mobile app](mobile-powerapp-newux-overview.md). It shows the list of bookings in chronological order that are assigned to the user who's signed in to the app. Select **Home** in the bottom navigation to return to the home page. By default, the agenda view shows the following details associated with each booking:

- Account
- Incident type
- Address
- Booking status
- Start time and duration

:::image type="content" source="media/agenda-view.png" alt-text="Device render of a mobile device showing bookings on the home page in the agenda view.":::

The agenda view shows data from the *Bookable Resource Booking* table and related tables. Booking status, start time and duration always show. You can customize which data to show by adding, removing, or changing the order of the data columns. [Consider using a solution to apply your customizations.](/power-apps/maker/data-platform/solutions-overview)

Go to Power Apps and navigate to **Tables** > **Bookable Resource Booking** > **Views** and customize **Bookings – Agenda View**.

:::image type="content" source="media/agenda-view-power-apps.png" alt-text="Agenda view in the list of views in the Power Apps maker experience.":::

All columns in this view can show on a booking card. However, we recommend keeping the number of columns below 10 to maintain readability and performance. To learn how to configure a view, see [Choose and configure columns in model-driven app views in Power Apps](/power-apps/maker/model-driven-apps/choose-and-configure-columns).  

> [!NOTE]
> You can't set other views as default in the new mobile user experience at the moment.

---
