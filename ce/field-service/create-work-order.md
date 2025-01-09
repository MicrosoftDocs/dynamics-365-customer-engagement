---
title: Create a work order
description: Create a work order to coordinate and schedule resources and activities for installations, repairs, or preventive maintenance.
ms.date: 02/15/2024
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Create a work order

A work order in Dynamics 365 Field Service has information on what work needs to be done. Work orders are used to coordinate and schedule resources and activities. They can be used for different types of work, such as installations, repairs, or preventive maintenance.  
  
A work order is often created from a case, an [agreement](set-up-customer-agreements.md), or an opportunity. It gets scheduled either manually, with the [schedule assistant](schedule-assistant.md), or the [Resource Scheduling Optimization add-in](rso-overview.md). Once the work is complete, a supervisor reviews and approves it.

## Create a work order from the work order form and record list

1. In Field Service, change to the **Service** area.

1. In the **Scheduling** section, select **Work Orders**.

1. Select **New**.

   :::image type="content" source="media/create-new-work-order-list.png" alt-text="Screenshot of the active work orders list in Field Service.":::

1. At a minimum, enter information in the following required fields.

    - For **Service Account**, select an account from the list or [create a new service account](accounts.md).
    - For **Work Order Type**, select a work order type from the list or [create a new work order type](create-work-order-types.md).
    - For **System Status**, select **Unscheduled**.
    - For **Price List**, select a price list from list or [create a new price list](create-price-list.md).
    - Choose if the work order is **Taxable** or not. If the work order isn't taxable work order products and services aren't considered taxable either, regardless of the taxable setting on the product or service.
  
1. Provide optional information for the work order as applicable. You can also add service tasks, products, services, or knowledge articles later.

   If you don't add a service task or incident type to the work order, the system sets the estimated duration of the work order to the default booking duration. You can change ths value by updating the Booking Setup Metadata for the msdyn_workorder entity. For more information, see [Edit settings for entities enabled for scheduling](/dynamics365/field-service/schedule-new-entity#edit-settings-for-enabled-entities).
  
1. Select **Save** or **Save and close**.

## Create a work order from the Get Started page

1. As a Field Service administrator or system administrator in the **Field Service** app, go to the **Get Started** page.

1. Select **Create** in the **Create your work orders** section.

1. Fill in the basic information about the work order.

1. In the form, add as many tasks, products, and services as needed.

1. If you want to immediately schedule the work order, select **Save & Book**. Select **Save & Close** to only save the work order.

## Next steps

- [Create work order types](create-work-order-types.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
