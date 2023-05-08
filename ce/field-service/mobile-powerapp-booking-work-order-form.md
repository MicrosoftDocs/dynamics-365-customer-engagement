---
title: "Edit the Booking and Work Order form (Form Component Control) | MicrosoftDocs"
description: Learn how to edit the booking and work order form in Dynamics 365 Field Service.
ms.date: 12/01/2021

ms.topic: article
author: Andrea-Orimoto
ms.author: andreo
---

# Edit the booking and work order form

You can add and delete fields displayed on the Field Service (Dynamics 365) mobile app; because the app is built with Power Apps, you can use the Power Apps Control Framework to display different field controls like toggle buttons and sliders.

Administrators who want to customize the booking and work order forms must know they are combined in the mobile app where work order forms are displayed within the booking form. That means when a technician views a booking form, they're also viewing the related work order form. In the following screenshot, the **General** section displays **Bookable Resource Booking** ("Booking") fields and the **Customer**, **Service**, and **Notes** sections display work order fields.


> [!div class="mx-imgBorder"]
> ![Simulated image showing a device with the Field Service (Dynamics 365) mobile app, showing a screenshot of a Bookable Resource Booking on the General tab.](./media/mobile-2020-work-order-form-all-sections.png)

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

Another way you can add work order information to the booking form is to add a [quick view form](../customerengagement/on-premises/customize/create-edit-quick-view-forms.md) that displays work order fields. Quick view forms are read-only, but you can go to the related work order form from there.

>[!TIP] 
> The combined _Booking and Work Order_ form is made possible by a PCF control called "Form component control." For more information, see the article on
[editing related table records directly from another table’s main form](/powerapps/maker/model-driven-apps/form-component-control) for more details.


>[!NOTE] 
> For Work Order Product, Work Order Service Task, and Work Order Service control to respect field mapping from Work Order when selecting **Create New**, the controls must be encapsulated within the Work Order form.


## Using the Form component control

The Booking form and Work Order form are combined using a PCF control called the [Form Component Control](/powerapps/maker/model-driven-apps/form-component-control) that allows you to add information from other entities (tables) into a form; in this case adding Work Order information into the Booking form.

>[!TIP] 
> It is recommended to use the Form Component Control to add information from multiple entities (tables) into a single form. For example, you may add Account information into the Customer Asset form. Doing so improves performance by reducing form load times and it also improves usability by reducing the need for the frontline worker to navigate to different forms.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
