---
title: Customer agreements overview
description: Learn about customer agreements in Dynamics 365 Field Service.
ms.date: 09/18/2025
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---

# Customer agreements overview

Field Service agreements let organizations automatically generate work orders and invoices with predefined details, frequencies, and date ranges. Organizations commonly use agreements for maintenance schedules, inspections, or other services that require regular jobs. For example, organizations might schedule quarterly elevator maintenance to check system health or weekly pest control services.  

Here are a few different ways agreements can be configured and used. The agreement generates:

- Daily inspection work orders that dispatchers schedule using the schedule board or schedule assistant.
- Monthly maintenance work orders that Resource Scheduling Optimization automatically schedules.
- Weekly work orders where the agreement assigns the same resource each time at a defined start time.
- A single work order each month to inspect multiple customer assets at a customer location.
- Multiple work orders each year to inspect multiple assets at a customer location.
- Quarterly invoices to bill customers for predefined products and services.

An agreement is intended to be executed at a single location represented by the service account. Work at different locations should be configured with multiple agreements.

## Multiple incidents vs multiple recurrences

Multiple incidents refer to multiple agreement booking incidents within a single agreement booking setup. Multiple recurrences refer to multiple agreement booking setups with different recurrences, each with one agreement booking incident.

To decide whether to add multiple incidents or multiple recurrences, ask these questions:

- Who performs the work? A single recurrence creates a single work order, whereas multiple recurrences create multiple work orders. If you envision a single person completing the agreement work, then using a single recurrence might be better. You can use incident types with [requirement group templates](/dynamics365/field-service/multi-resource-scheduling-requirement-groups) to help schedule single work orders to multiple resources.

- How much travel is involved? Multiple recurrences create several work orders, which might lead to more trips and travel than desired.

- How are assets tracked? Some organizations prefer linking each work order to a single customer asset. This approach ensures the time spent on a work order matches the time spent servicing an asset, which helps with reporting. In this case, you might choose multiple recurrences, each creating one work order with a single incident tied to a single asset.

## Resource Scheduling Optimization automatically schedules work orders

[Resource Scheduling Optimization automatically schedules work orders](rso-overview.md) to optimize working hours and travel time, including work orders generated from agreements. To use Resource Scheduling Optimization for scheduling agreement work orders, consider these options:

- Let the agreement generate work orders automatically and ensure the generated work order is part of the Resource Scheduling Optimization scope.

- Let the agreement generate and book work orders automatically, and ensure the preferred resource is enabled for Resource Scheduling Optimization. You can optimize the booking status of the related booking and use schedule lock options to keep the agreement booking assigned to that resource, time slot, or both.

- Create a Resource Scheduling Optimization schedule and scope specifically for work orders generated from agreements. You can define specific cadences and priorities for optimizing agreement work order bookings.

## Invoices and entitlements with agreements

When you decide to use agreement invoices, create a new agreement to generate invoices or add invoices to an existing service agreement. If the agreement invoices relate to scheduled maintenance, include the agreement-generated work orders and invoices in the same agreement.

Even if an agreement generates invoices, agreement work orders create invoices upon completion and **Close-Posted** status. If only the agreement invoices represent what to bill to the customer, create a process to disregard or mitigate the work order invoices. For example, deactivate those invoices or use price lists and entitlements to ensure the work order subtotal and work order invoice is $0.

Entitlements apply to work order pricing based on multiple factors such as service account, incident type, and customer asset categories. Typically, you create specific incident types for specific customers outlining custom work. For example, if a custom agreement incident type is added to a work order that discounts products and services by 100% to make them $0, apply an entitlement.  

Learn more in [Entitlements for work orders in Dynamics 365 Field Service](work-order-entitlements.md).

## Quotes and sales

If you want to use agreements only for invoice generation and not for work order generation, use quotes as part of the Field Service solution.

Agreements work seamlessly with the Dynamics 365 Sales Lead > Opportunity > Quote > Order process. To set up:
  
1. Categorize the lead as a service-maintenance lead.
2. Add opportunity lines with service-based lines.
3. Create quote lines as service-based lines, and add a quote booking setup.

## Next steps

[Set up agreements to automatically generate work orders and invoices](set-up-customer-agreements.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
