---
title: Work order architecture
description: Learn about the architecture of the work order process in Dynamics 365 Field Service.
ms.date: 01/24/2023
author: jshotts
ms.author: jasonshotts
ms.topic: conceptual
ms.custom: bap-template
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# Work order architecture

The most important process in Field Service is the work order process. Work orders are:

1. [Created](#a-work-order-is-created)
1. [Scheduled to resources](#the-work-order-is-scheduled-to-resources)
1. [Performed by field technicians](#a-field-technician-performs-the-work-order)
1. [Completed and reviewed](#the-work-order-is-reviewed-and-completed)

The following diagram illustrates the entities, attributes, and relationships that make up the work order process.

:::image type="content" source="media/admin-field-service-architecture.png" alt-text="Diagram of the work order process architecture.":::

## A work order is created

The **Work Order** entity contains the details of the job that needs to be completed, such as work order type, status, duration, and priority.

Work orders are related to an [**Account** entity](accounts.md). Specifying a **Service Account** on the work order adds related account information like territory, address, and service and billing defaults.

[**Service Agreements**](set-up-customer-agreements.md) automatically generate recurring work orders. A service agreement can be associated with one service account. That means that all work orders that are generated as part of a service agreement are associated with that service account location. The type of work to be done and assets involved can vary.

[**Customer Assets**](assets.md) are pieces of equipment at the service account location. Work orders that are related to the maintenance, inspection, and repair of a customer asset should correlate to the asset's service account.

Beyond adding basic details and an account to a work order, you can add **Revenue and Cost** items that better define the specific work to be done. **Work Order Incidents** are a defined package of recommended service tasks, products, services, and characteristics, or skills, that makes creating a work order faster. Instead of manually adding them to a work order, you can add an incident that effectively serves as a template to populate service tasks, products, services, and skills.

Finally, you can define **Time and Resource Preferences**, which specify when a work order should be completed to meet a service agreement.

## The work order is scheduled to resources

All the important details that relate to scheduling a work order are passed to an automatically generated related entity called a **Resource Requirement**. Resource requirements are used to assign the work order to the most appropriate resource, or field technician. The resource requirement framework is partly what allows any entity to be scheduled, such as cases, opportunities, or custom entities.

Field Service keeps the **Work Order** and the primary resource requirement in sync. All the fields that affect scheduling are automatically synchronized. If a customer manually creates multiple requirements against a work order, they aren't automatically synchronized.

Before a work order can be scheduled, a [**Bookable Resource**](set-up-bookable-resources.md) must exist in the system. A bookable resource represents an employee, contractor, equipment, facility, or anything else that needs to be scheduled.

When it's time to schedule a work order, you assign a requirement to a resource. This creates a **Booking**. You can think of a booking as a scheduled time slot for a specific resource. Requirements can be scheduled in several ways:

- [Manually on the schedule board](schedule-work-order.md)
- [With the schedule assistant](schedule-assistant.md)
- [Resource Scheduling Optimization](rso-overview.md)

A requirement can be booked multiple times, creating multiple booking records. This is useful when you want to schedule the same requirement to multiple resources or to the same resource at different times.

## A field technician performs the work order

Field technicians can view their daily, weekly, and monthly bookings on their agenda in the Field Service Mobile app. They can also edit the status of their bookings to show when they're traveling, the work is in progress, they're on break, and the work is completed, along with custom statuses. Each status change is recorded in the system as a **Booking Timestamp** and eventually **Booking Journals**, which are used to calculate the time and labor cost of a booking.

While performing a work order, field technicians may use products and services, indicating that a part or labor was needed. Though these products and services were previously added to the work order, they were originally listed in the **Product Catalog**. Products that represent physical parts and not labor are tracked in **Inventory** and are replenished with the **Purchasing** process that relies on submitting and receiving purchase orders.

## The work order is reviewed and completed

Finally, the work order is reviewed and closed by a service manager, who updates **Inventory Consumption** and **Financial Information**. Inventory consumption is the quantity of a product that's deducted from a warehouse based on the work order activity. In cases where used products and services must be billed, closing a work order triggers the creation of an invoice for payments and actuals, which are a log of transactions.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
