---
title: "Configure the Field Service (Dynamics 365) mobile app | MicrosoftDocs"
description: Learn how to configure the Field Service (Dynamics 365) mobile app.
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/30/2020
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

The groups  **My Work**, **Customers**, and **Other** correspond with the home screen of the Field Service (Dynamics 365) mobile app and you can rearrange, delete, or edit the display names.

Rearrange the entities displayed within each group with the drag and drop interface, or add new entities by adding new **Subareas**.


> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing the My Work, Customers, and Other groups on the Field Service Mobile App Designer.](./media/mobile-2020-admin-sitemap2.png)

You can even create entirely new groups with more subareas to display different entities.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps, showing Field Service Mobile in the App Designer, and showing a simulated mobile device on the right with the corresponding changes.](./media/mobile-2020-admin-sitemap3.png)

> [!Note]
> For every entity you display in the sitemap, you can choose the views available on mobile in the App Designer.

## Edit the booking and work order form

You can add and delete fields displayed on the Field Service (Dynamics 365) mobile app; because the app is built with Power Apps, you can use the Power Apps Control Framework to display different field controls like toggle buttons and sliders.

Administrators who want to customize the booking and work order forms must know they are combined in the mobile app where work order forms are displayed within the booking form. That means when a technician views a booking form, they're also viewing the related work order form. In the following screenshot, the **General** section displays **Bookable Resource Booking** ("Booking") fields and the **Customer**, **Service**, and **Notes** sections display work order fields.


> [!div class="mx-imgBorder"]
> ![Simulated image showing a device with the Field Service (Dynamics 365) mobile app, showing a screenshot of a Bookable Resource Booking on the General tab. ](./media/mobile-2020-work-order-form-all-sections.png)

To edit the work order portion of the form, go to **Settings** > **Customizations** > **Customize the System** and find the **Work Order** entity in the Power Apps admin console.

> [!div class="mx-imgBorder"]
> ![Screenshot of Power Apps showing the list of entities.](./media/mobile-2020-admin-work-order-form.png)

In the **Form** section, there are three forms that correspond to the three sections of the combined Booking-Work Order form.

1. Work Order - Customer
2. Work Order - Service
3. Work Order - Notes

Edit each form as needed and publish. The changes will display in the Field Service (Dynamics 365) mobile app.

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

For more information, see the article on [customizing entity forms](https://docs.microsoft.com/powerapps/developer/model-driven-apps/customize-entity-forms).

## Customize global search and enable scan to search 

By default, Dynamics 365 Field Service is configured to search against account, contact, user, and activity. You can customize global search to include additional entities, such as customer asset and product, which helps technicians search, find by keyword, and scan to search by barcode, UPC, or QR code.

For more information, see: [How to Setup Global Search](https://community.dynamics.com/crm/b/xrm/posts/how-to-set-up-global-search-in-microsoft-dynamics-365)


## Configure offline data and sync filters

Administrators can control what data is downloaded to the Field Service (Dynamics 365) mobile app in offline mode when no internet access is available. Offline configuration is achieved by:

1. Setting up an offline profile (one exists by default).
2. Adding users to the offline profile.
3. Publishing the offline profile.
4. Adding the offline profile to the Field Service Mobile model driven app. 

> [!div class="mx-imgBorder"]
> ![Device render showing offline status mode in Field Service (Dynamics 365) mobile app.](./media/mobile-2020-offline-complete.png)

> [!Note]
> When the technician has internet connectivity, data on the device will automatically be refreshed at a minimum interval of five minutes.

For more information on offline profiles, see the article on [setting up mobile offline synchronization](https://docs.microsoft.com/dynamics365/mobile-app/preview-setup-mobile-offline). 

Go to the Power Platform admin center at [https://admin.powerplatform.microsoft.com/](https://admin.powerplatform.microsoft.com/), and find and select your environment.


> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center showing environments.](./media/offline-2020-ppac.png)

Select **Settings** at the top.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, on an environment, showing the settings option.](./media/offline-2020-ppac-settings.png)

Go to **Users + permissions section** > **Mobile configuration**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the Mobile configuration option.](./media/offline-2020-ppac-mobile-configuration.png)

Offline entities, relationships, and user assignment is managed through your **Offline Profile**. Field Service provides an out-of-the-box offline profile called **Field Service Mobile - Offline Profile** with recommended default settings for common Field Service entities. This profile can be updated based on unique business needs.

Within your offline profile you can:

- Define entities which are available offline.
- Define filters for each entity. For example, by default we set a filter to only get the bookings entity within a range of seven days before or after current date.
- Setup item association by creating relationships between entities. This will save time where you will not need to set filters for every entity rather you can associate related entities which will follow filters set on the related entity.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing mobile offline profiles.](./media/mobile-2020-offline-profile-ppac.png)

Choose the **Field Service Mobile - Offline Profile**, which is the default configuration for offline data that is included with the Field Service app.

Add the users who need to work offline in the right **People with offline access** panel. Users must be added here in order to download data offline.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the section where to add users to the offline profile.](./media/mobile-2020-offline-profile-add-user.png)

For each entity, you can choose a data download filter:

1. Download related data only.
2. All records.
3. Other data filter.
4. Custom data filter.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the edit bookable resource booking entity options.](./media/mobile-2020-offline-ppac-options.png)

For example, the **Bookable Resource Booking** (in other words, the booking) entity has a data download filter set to **custom data filter** that downloads resource bookings that start or end in the next seven days or today.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Power Platform admin center, showing the set filter logic.](./media/mobile-2020-offline-ppac-brb-custom-filter.png)

**Save and Publish** the offline profile.

### Add the offline profile to the app

Go to your Dynamics 365 apps by going to ```yourenvironment.crm.dynamics.com/apps```, then go to the app designer for Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer.](./media/mobile-2020-open-app-designer.png)

Go to **Properties** and add the offline profile you just published if it is not already there.

> [!div class="mx-imgBorder"]
> ![Screenshot of the app designer, on the Field Service Mobile properties tab.](./media/mobile-2020-add-offline-profiles.png)

> [!Note]
> Field Service customers can create additional Offline Profiles to enable scenarios where different user roles have different sync settings or entities available to them. For example, a Field Service manager may require seeing a broader scope of work orders which may not be assigned to the current operator of the mobile application. If you create a new offline profile, you'll need to add it to the Field Service Mobile app in the app designer as well.

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
- [Enable entities for mobile offline synchronization](https://docs.microsoft.com/dynamics365/mobile-app/setup-mobile-offline-for-admin#step-1-enable-entities-for-mobile-offline-synchronization)

## More features

Because the Dynamics 365 Field Service mobile app is built on Microsoft's Power Platform, administrators and developers can use the same tools that are available for configuring Dynamics 365 and Power Apps. See the following table for some examples.

| Area	| Power Platform reference doc |
| --- | --- |
| Views | 	- [Create and edit public or system model-driven app views](https://docs.microsoft.com/powerapps/maker/model-driven-apps/create-edit-views-app-designer)</br> - [Customize entity views](https://docs.microsoft.com/powerapps/developer/model-driven-apps/customize-entity-views)
| Custom iframe integration | 	[Use IFRAME and web resource controls on a form](https://docs.microsoft.com/powerapps/developer/model-driven-apps/use-iframe-and-web-resource-controls-on-a-form) | 
| Custom HTML pages | 	[Webpage (HTML) web resources](https://docs.microsoft.com/powerapps/developer/model-driven-apps/webpage-html-web-resources) 
| Commands on forms and views	 |  - [Command bar or ribbon presentation](https://docs.microsoft.com/powerapps/developer/model-driven-apps/command-bar-ribbon-presentation)</br> - [Define ribbon actions](https://docs.microsoft.com/powerapps/developer/model-driven-apps/define-ribbon-actions)
| Event Handling (On Save, On Load, etc.) | 	[Events in forms and grids in model-driven apps](https://docs.microsoft.com/powerapps/developer/model-driven-apps/clientapi/events-forms-grids) | 
| Business Logic / JavaScript	 | [Apply business logic using client scripting in model-driven apps using JavaScript](https://docs.microsoft.com/powerapps/developer/model-driven-apps/client-scripting) | 
| Client Scripting | 	[Apply business logic using client scripting in model-driven apps using JavaScript](https://docs.microsoft.com/powerapps/developer/model-driven-apps/client-scripting) | 

## Configuration considerations

### Offline sync filters

- **Offline profiles get updated**. The default offline profile may receive updates over time, but updates will come in an unpublished state. This allows organizations to review the updates and decide if they want to take the update or continue with previous version. If entities in the default offline profile are modified, those entities will be considered unmanaged and won't receive future updates while unmodified entities are still eligible for update.

- **Sync conflicts.**  Sync conflicts can happen if there is a missmatch between data on the device and data on the server. A conflict is raised at the entity level and not per-field.  Conflict errors can be resolved based on the settings set by the admin. If your admin has set the conflict resolution to "No", then the data value on your client device wins and there will be no sync errors. This is the default value for Field Service Mobile. If your admin has set the conflict resolution to "Yes", then the data value on the server wins. In this case, while syncing changes to the server, you might see some errors that are automatically resolved. Client changes are overwritten by server values.




### Known limitations

- Offline sync filters: If a record is created from the device while in offline mode, and that record does not meet filter conditions, then the record does not get re-synchronized from the service until conditions are met.
- Offline sync filters: If commands or capabilities are setup to work with internet connectivity but not in offline mode, those capabilities should be reviewed to confirm they are calling correct APIs: ```xml.webapi.online```.
