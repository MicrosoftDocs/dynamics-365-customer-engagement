---
title: "Work Order and Booking Statuses | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/15/2019
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Work Order and Booking Statuses

Work Order System Statuses, Work Order Substatuses, and Booking Statuses all work together to help stakeholders stay up to date with work orders. Updating one of these statuses can update the others automatically.

**Work Order System Statuses** are noted on the Work Order entity, mark the current point of a work order in its life cycle, are part of the product by default and **should not** be edited, and are:

- Open - Unscheduled
- Open - Scheduled
- Open - In Progress
- Open - Completed
- Closed - Posted
- Closed - Canceled

**Work Order Substatuses** are noted on the Work Order entity, relate to and provide more detail to Work Order System Statuses, and are created custom for each organization.

**Booking Statuses** are noted on the Bookable Resource Booking entity, are updated by field technicians on the Field Service Mobile app to track their progress for a specific work order requirement, are visualized on the schedule board with a distinct color and icon, and a few booking statuses are part of the product by default and more custom ones can be added, but out of the box include:

- Scheduled
- Traveling
- In Progress
- On Break
- Completed
- Canceled


### Use cases

Lets explore work order and booking statuses with the following scenarios:


1. **Estimate work order**. A field service organization would like to utilize work orders for estimating potential products, services, and prices for their clients and want to mark such work orders with a custom "Estimate" work order substatus.
2. **Delayed schedules**. Field technicians want to make dispatchers aware if they are running more than 15 minutes behind schedule due to traffic or longer than expected work by changing the status of their booking to "Delayed"
3. Follow up Work Order Sub-status

## Prerequisites

- understand that work orders and booking have difference statuses
- Work Order statuses should never be edited and instead work order sub statuses should be

> [!Note]
> Work Order System Statuses should NEVER be edited because system jobs and plug-ins rely on these statuses. Instead, administrators should create custom Work Order Substatuses that relate to Work Order System Statuses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Estimate Work Order Sub-status
## Delayed Booking Status

### Relationship between Work Order System Status and Booking Status

## Follow up Work Order Sub-status

## Configuration considerations
- Booking statuses with RSO
  - new ones
  - simulation -RSO
## Additional Notes
