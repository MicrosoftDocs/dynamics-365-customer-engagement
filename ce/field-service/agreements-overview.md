---
title: "Customer agreements overview"
description: Learn about customer agreements in Dynamics 365 Field Service
ms.date: 06/17/2024
ms.topic: how-to
author: jasonccohen
ms.author: jacoh
---

# Customer agreements overview

Field Service agreements allow organizations to automatically generate work orders and invoices with predefined details, frequency, and date ranges. Agreements are most commonly used for maintenance schedules where an organization must perform daily, weekly, or monthly inspections on equipment.

Here are a few different ways agreements can be configured and used. The agreement generates:

- Daily inspection work orders that dispatchers schedule through the schedule board or schedule assistant.
- Monthly maintenance work orders that are automatically scheduled by Resource Scheduling Optimization.
- Weekly work orders where the agreement assigns the same resource each time at a defined start time.
- A single work order each month to inspect multiple customer assets at a customer location.
- Multiple work orders each year to inspect multiple assets at a customer location.
- Quarterly invoices to bill customers for predefined products and services.

An agreement is intended to be executed at a single location represented by the service account. Work at multiple locations should be configured with multiple agreements.

## Multiple incidents vs multiple recurrences

As agreement work increases, you'll have to decide whether to add multiple agreement incidents to a single recurrence or to add multiple recurrences, each with one or more incidents. Here are a few things to consider:

- *Who will perform the work order(s)?*: A single recurrence creates a single work order, whereas multiple recurrences create multiple work orders, and work orders are performed by a single person. If you envision the agreement work being completed by a single person, then using a single recurrence might be better. You can use incident types with [requirement group templates](/dynamics365/field-service/multi-resource-scheduling-requirement-groups) to help schedule single work orders to multiple resources.

- *Travel*: Multiple recurrences create multiple work orders which might create more trips and more travel than desired.

- *How are you tracking assets?*: Some organizations prefer each work order to relate to a single customer asset. This way they know the time spent on a work order correlates to time spent servicing an asset, which helps with reporting. If so, you might choose to have multiple recurrences each creating one work order with a single incident related to a single asset.

## Agreement work orders schedule automatically with Resource Scheduling Optimization

Resource scheduling optimization automatically schedules work orders to optimize working hours and travel time. This includes work orders generated from agreements. If you're interested in using Resource Scheduling Optimization to schedule agreement work orders, there are three options:

- Have the agreement auto generate work orders and ensure the generated work order is picked up by the Resource Scheduling Optimization scope.

- Have the agreement auto generate and book work orders and ensure the preferred resource is enabled for Resource Scheduling Optimization. The booking status of the related booking can be optimized. You can use schedule lock options on the booking to ensure the agreement booking remains scheduled to that resource, time slot, or both.

- Create a specific Resource Scheduling Optimization schedule and scope that only considers work orders generated from agreements. This allows you to set specific cadences and priorities for when agreement work order bookings are optimized.

## Invoices and entitlements with agreements

When deciding to use agreement invoices, you can create a new agreement to generate invoices, or add invoices to an existing service agreement. If the agreement invoices relate to scheduled maintenance, then we recommend having the agreement-generated work orders and the agreement-generated invoices as part of the same agreement.

Even if you have an agreement generating invoices, agreement work orders still create invoices upon completion and **Close-Posted** status. If only the agreement invoices represent what should be billed to the customer, you'll need to create a process to disregard or mitigate the work order invoices. This could be as simple as deactivating those invoices or using price lists and entitlements to ensure the work order subtotal and work order invoice is $0.

Entitlements are applied to work order pricing based on multiple factors such as service account, incident type, and customer asset categories. It's common practice to create specific incident types for specific customers outlining custom work; one option is to apply an entitlement when the custom agreement incident type is added to a work order that makes the products and services $0 by discounting them 100%.

For more information, see [Entitlements for work orders in Dynamics 365 Field Service](work-order-entitlements.md).

## Next steps

[Set up agreements to automatically generate work orders and invoices](set-up-customer-agreements.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
