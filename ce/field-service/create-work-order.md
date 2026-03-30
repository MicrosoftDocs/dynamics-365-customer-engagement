---
title: Create a work order
description: Learn the different ways to create a work order in Dynamics 365 Field Service, including manually, from a case, agreement, opportunity, Power Automate, or API.
ms.date: 03/24/2026
ms.topic: how-to
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneetsingh
ms.custom: bap-template
---

# Create a work order

A work order in Dynamics 365 Field Service has information on what work needs to be done. Work orders are used to coordinate and schedule resources and activities. They can be used for different types of work, such as installations, repairs, or preventive maintenance.

The system determines the work order's location by looking at a manually entered **Service address** first, then the address from the [**Functional location**](functional-locations.md) if set, then the **Service Address** from the account.

Once a work order is created, it gets scheduled either manually, with the [schedule assistant](schedule-assistant.md), or the [Resource Scheduling Optimization add-in](rso-overview.md). After the work is complete, a supervisor reviews and approves it.

## Choose a work order creation method

Use the following table to find the right creation method for your scenario.

| Scenario | Method |
|---|---|
| Ad-hoc request or one-off job | [Create a work order manually from the work order form](#create-a-work-order-manually) |
| Customer called in with an issue | [Create work orders from a case](create-work-order-from-case.md) |
| Recurring scheduled maintenance | [Create work orders from an agreement](create-work-order-from-agreement.md) |
| Sales opportunity converted to service | [Create work orders from an opportunity](create-work-order-from-opportunity.md) |

## Prerequisites

You need to have at least one of the following Field Service security roles:

- Field Service - Dispatcher
- Field Service - Administrator

## Create a work order manually

### From the work order form

1. In Field Service, change to the **Service** area.

1. In the **Scheduling** section, select **Work Orders**.

1. Select **New**.

   :::image type="content" source="media/create-new-work-order-list.png" alt-text="Screenshot of a list of work orders in Field Service.":::

1. At a minimum, enter information in the following required fields.

    - For **Service Account**, select an account from the list or [create a new service account](accounts.md).
    - For **Work Order Type**, select a work order type from the list or [create a new work order type](create-work-order-types.md).
    - For **System Status**, select **Unscheduled**.
    - For **Price List**, select a price list from list or [create a new price list](create-price-list.md).
    - If [taxes are enabled](set-up-tax-codes.md), choose if the work order is **Taxable** or not. If the work order isn't taxable, work order products and services aren't considered taxable either, regardless of the taxable setting on the product or service.

1. Provide optional information for the work order such as service tasks, products, services, or knowledge articles. You can also add this information later.

   If you don't add a service task or incident type to the work order, the system sets the estimated duration of the work order to the default booking duration. You can change this value by updating the Booking Setup Metadata for the [msdyn_workorder table](./developer/reference/entities/msdyn_workorder.md). For more information, go to [Edit settings for entities enabled for scheduling](/dynamics365/field-service/schedule-new-entity#edit-settings-for-enabled-entities).

1. Select **Save** or **Save and close**.

### From the Get Started page

1. As a Field Service administrator or system administrator in the **Field Service** app, go to the **Get Started** page.

1. Select **Create** in the **Create your work orders** section.

1. Fill in the basic information about the work order.

1. In the form, add as many tasks, products, and services as needed.

1. If you want to immediately schedule the work order, select **Save & Book**. Select **Save & Close** to only save the work order.

## Create work orders from a case

To create work orders from a case, learn more in [Create a work order from a case](create-work-order-from-case.md).

## Create work orders from an agreement

To create work orders from an agreement, learn more in [Create work orders from an agreement](create-work-order-from-agreement.md).

## Create work orders from an opportunity

To create work orders from an opportunity, learn more in [Create a work order from an opportunity](create-work-order-from-opportunity.md).


## Next steps

- [Create work order types](create-work-order-types.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
