---
title: Edit the booking and work order form
description: Learn how to edit the booking and work order form for the Dynamics 365 Field Service mobile app.
ms.subservice: field-service-mobile
ms.topic: conceptual
ms.date: 08/28/2024
author: JonBaker007
ms.author: jobaker
---

<!-- Note: the style guide says not to use an acronym for Power Apps component framework. After first use, it's OK to say "framework". -->

# Edit the booking and work order form

You can configure forms for Dynamics 365 Field Service mobile app to meet your business needs. Because the mobile app is a model-driven app built with Power Apps, you can use the [Power Apps component framework](/power-apps/developer/component-framework/overview) to configure the appearance.

In Field Service, booking and work order forms are closely related. When a technician views a booking form, they're also viewing the related work order form.

## Edit a form

For detailed steps, see [Create, edit, or configure forms using the form designer](/powerapps/maker/model-driven-apps/create-and-edit-forms).

Change the following forms from the *Work Order* and *Bookable Resource Booking* tables to update the combined work order and booking form in the mobile app.

- Work Order - Customer
- Work Order - Service
- Work Order - Notes
- Booking and Work Order

Change each form as needed and publish the changes to see them in the Field Service mobile app.

> [!TIP]
> The *Booking* form and *Work Order* form are combined using a framework control called the [Form Component Control](/powerapps/maker/model-driven-apps/form-component-control) that allows you to combine data from different tables on a form. You can use the control to combine data from other tables to improve usability by reducing the need for users to navigate between forms.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
