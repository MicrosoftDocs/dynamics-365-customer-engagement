---
title: "Configure the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/27/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Configure the Field Service (Dynamics 365) mobile app

Administrators can edit how the Field Service (Dynamics 365) mobile app looks and functions for technicians.

Let's walk through three common configurations:

1. Editing the entities displayed in the home screen (sitemap).
2. Editing the fields and layout in the work order and booking forms.
3. Editing the entities and records downloaded to the mobile phone in offline mode for use without internet access.

## Edit Sitemap entities on home screen

Sign in to Dynamics 365 as a system administrator.

To see your list of apps, go to:

```https://[YOUR-ENVIRONMENT-NAME].crm.dynamics.com/main.aspx?forceUCI=1&pagetype=apps```

Find the Field Service Mobile app and go to the **App Designer**.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365, showing the list of apps and showing the option to open Field Service Mobile in the App Designer.](./media/mobile-2020-admin-app-designer.png)

Select the edit icon to edit the site map.

> [!div class="mx-imgBorder"]
> ![Screenshot of the App Designer in Power Apps, showing the Field Service Mobile site map option.](./media/mobile-2020-admin-sitemap1.png)

The groups  **My Work**, **Customers**, and **Other** correspond with the home screen of Field Service (Dynamics 365) mobile app and you can rearrange, delete, or edit the display names.

Rearrange the entities displayed within each group with the drag and drop interface, or add new entities by adding new **Subareas**.


> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing the My Work, Customers, and Other groups on the Field Service Mobile App Designer.](./media/mobile-2020-admin-sitemap2.png)

You can even create entirely new groups with more subareas to display different entities.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing Field Service Mobile in the App Designer, and showing a simulated mobile device on the right with the corresponding changes.](./media/mobile-2020-admin-sitemap3.png)

> [!Note]
> For every entity you display in the sitemap, you can choose the views available on mobile in the App Designer.

## Edit the booking and work order form

You can add and delete fields displayed on Field Service (Dynamics 365) mobile app; because the app is built with Power Apps, you can use the Power Apps Control Framework to display different field controls like toggle buttons and sliders.

Administrators who want to customize the booking and work order forms must know they are combined in the mobile app where work order forms are displayed within the booking form. That means when a technician views a booking form, they're also viewing the related work order form. In the following screenshot, the **General** section displays **Bookable Resource Booking** ("Booking") fields and the **Customer**, **Service**, and **Notes** sections display work order fields.


> [!div class="mx-imgBorder"]
> ![Simulated image showing a device with Field Service (Dynamics 365) mobile app, showing a screenshot of a Bookable Resource Booking on the General tab. ](./media/mobile-2020-work-order-form-all-sections.png)

To edit the work order portion of the form, go to **Settings** > **Customizations** > **Customize the System** and find the **Work Order** entity in the Power Apps admin console.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the list of entities.](./media/mobile-2020-admin-work-order-form.png)

In the **Form** section, there are three forms that correspond to the three sections of the combined Booking-Work Order form.

1. Work Order - Customer
2. Work Order - Service
3. Work Order - Notes

Edit each form as needed and publish. The changes will display in Field Service (Dynamics 365) mobile app.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the work order form details.](./media/mobile-2020-admin-work-order-form-tabs.png)

To edit the **Booking** part of the form, go to the **Bookable Resource Booking** entity in the Power Apps admin console.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Bookable Resource Booking in the Power Apps list of entities.](./media/mobile-2020-admin-booking-form.png)

Find the **Booking and Work Order** form, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Bookable Resource Booking in Power Apps, showing the Booking and Work Order form.](./media/mobile-2020-admin-booking-form-combined.png)

Add and delete booking fields as needed.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the form editor for the Bookable Resource Booking.](./media/mobile-2020-admin-booking-form-combined-add-fields.png)

Another way you can add work order information to the booking form is to add a [quick view form](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/create-edit-quick-view-forms) that displays work order fields. Quick view forms are read-only, but you can go to the related work order form from there.

## Configure offline data and sync filters

Administrators can edit the data downloaded to Field Service (Dynamics 365) mobile app in offline mode when no internet access is available. 

> [!Note]
> When internet access is available, users will simply see all data on the server they have access to via their security role.

> [!div class="mx-imgBorder"]
> ![Simulated image showing Field Service (Dynamics 365) mobile app on a mobile device, showing the offline status screen.](./media/mobile-2020-offline-list.png)

Go to **Settings** > **Mobile Offline**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Settings menu in Dynamics 365 in a browser.](./media/mobile-2020-admin-mobile-offline.png)

Then select **Mobile Offline Profiles**. Choose the **Field Service Mobile - Offline Profile**, which is the default configuration for offline data that is included with the Field Service app.


> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 settings, showing the All Mobile Offline Profiles screen.](./media/mobile-2020-offline-profile.png)

The profile dictates which entities and how many records of each entity will be downloaded in offline mode.

> [!div class="mx-imgBorder"]
> ![Screenshot of Dynamics 365 Settings, showing the Field Service Mobile offline profile.](./media/mobile-2020-offline-profile-entities.png)

Add the users who need to work offline in the right **USERS** panel. Users must be added here in order to download data offline.

For each entity, you can choose a data download filter:

1. Download related data only
2. All records
3. Other data filter
4. Custom data filter

For example, the **Bookable Resource Booking** (in other words, the booking) entity has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or yesterday.


> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 Settings showing the mobile offline profile for a bookable resource booking, with attention to the "Define Filter Rules" option.](./media/mobile-2020-offline-profile-bookable-resource-booking.png)

For another example, the **Work Order Product** entity has a data download filter set to **Download related data only**, which means that only work order products related to downloaded work orders are available offline. To accomplish this, the work order product mobile offline profile item was listed as an associated profile item of the work order offline profile, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Dynamics 365 Settings showing the mobile offline profile for a bookable resource booking, with attention to the "Define Filter Rules" option.](./media/mobile-2020-offline-profile-bookable-resource-booking.png)

> [!Note]
> By default, work orders related to downloaded bookable resource bookings are available offline. This creates a chain of entities and records that are offline: bookings > work orders > work order products. This means that bookings scheduled to you are downloaded, work orders related to those bookings are downloaded, and work order products related to those work orders are downloaded.

For more information, see the article: [Dynamics 365 offline profiles](https://docs.microsoft.com/dynamics365/mobile-app/setup-mobile-offline-for-admin#step-1-enable-entities-for-mobile-offline-synchronization).

### Create new offline profiles

If you create a new offline profile, you'll need to add it to the Field Service Mobile app in the app designer.

Go to the app designer.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service Mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

## Offline JavaScript

In some cases, an organization may want to run validation on certain field values after a technician updates an entity. For example, let's say you want to make sure the duration of a work order booking is at least two hours once a technician saves a record in the Field Service (Dynamics 365) mobile app.

Validation can be done with the help of some JavaScript and doing so works online and offline.

See the video on![Video symbol](../field-service/media/video-icon.png "Video symbol") [Field Service (Dynamics 365) mobile app: Offline JavaScript](https://youtu.be/tUdL5YZA29A) for more details.

Go to **Settings** > **Customizations**.

Go to the **Bookable Resource Booking** entity.

Go to **Forms**.

Go to the **Booking and Work Order** form.

Go to **Form Properties** in the top.

> [!div class="mx-imgBorder"]
> ![Screenshot of the lookup record dialog in Power Apps.](./media/mobile-2020-offline-javascript.png)

Create and add a new JavaScript web resource to the form.

Enter in the following code snippet:

```javascript

        function TestOnSave(executionContext) {

            var formContext = executionContext.getFormContext(); // get formContext
            var duration = formContext.getAttribute("duration").getValue();

            formContext.ui.clearFormNotification("DurationErrorMessageId");

            if (duration < 120) {
                executionContext.getEventArgs().preventDefault(); // Stop the Save
                formContext.ui.setFormNotification("Duration must be greater than 2 hours", "ERROR", "DurationErrorMessageId");
        }
    }

```

Ensure the web resource triggers on save of the form.
  
Save and publish customizations.

### See also

- [What are model-driven apps in Power Apps?](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview)
- [Enable entities for mobile offline synchronization](https://docs.microsoft.com//dynamics365/mobile-app/setup-mobile-offline-for-admin#step-1-enable-entities-for-mobile-offline-synchronization)