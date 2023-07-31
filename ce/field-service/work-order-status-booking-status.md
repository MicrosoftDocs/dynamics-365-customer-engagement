---
title: Work order lifecycle and system statuses
description: Track the status of a work order in its lifecycle with system statuses, substatuses, and booking statuses.
ms.date: 06/09/2023
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Work order lifecycle and system statuses

Work orders use system statuses, work order substatuses, and booking statuses to track the status of a work order in the lifecycle. Updating one of the statuses can update the others automatically.

**Work Order System Statuses** are noted on the work order entity, indicating the current point of a work order in its life cycle. Work order system statuses are:

- Unscheduled
- Scheduled
- In Progress
- Completed
- Posted
- Canceled

> [!NOTE]
> Don't add, remove, or edit the option set *values* for **Work Order System Status**. Instead, administrators can edit the option set *labels* to change how statuses show in the user interface.

**Work Order Substatuses** are noted on the work order entity and relate to and provide more detail for work order system statuses. Work order substatuses are created custom for each organization.

**Booking Statuses** are noted on the bookable resource booking entity and are updated by field technicians on the Field Service Mobile app to track their progress for a specific work order requirement. Additionally, booking statuses are visualized on the schedule board with a distinct color and icon, and a few booking statuses are part of the product by default, though more custom ones can be added. Out of the box, the booking statuses are:

- Scheduled
- Traveling
- In Progress
- On Break
- Completed
- Canceled

## Work order lifecycle  
  
- **Work order creation**: A work order is created, usually from a case or opportunity.  
  
- **Schedule**: The work order is scheduled.  
  
- **Dispatch**: The work order is dispatched.  
  
- **Service**: The work order is performed and details are updated.  
  
- **Review/Approval**: A supervisor reviews and approves the work order.  
  
- **Invoice and inventory adjustment**: Inventory adjustments are made, and an invoice is generated for the corresponding account.  

:::image type="content" source="./media/work-order-lifecycle.png" alt-text="Work order lifecycle in Dynamics 365 Field Service.":::  
  
|  | Create | Schedule | Dispatch | Service | Review | Invoice |  
|-|-|-|-|-|-|-|  
|**What happens**|New work order is created.<br /><br /> Assigned incident, product, services, skills, territory, etc.| Work order schedule is created.<br /><br /> Resources assigned to the work order.<br /><br /> Date and time specified.|Field agent notified of work order.<br /><br /> Field agent may review and accept/decline the work order.| Work order is carried out.<br /><br /> Information about what is performed in the field is entered through the mobile app.|Supervisor verifies that all the work was done properly, and that all information regarding the work order is correct.|Invoice is created based on products and services used.<br /><br /> Inventory adjustments are made.<br /><br /> Products converted into equipment (if applicable)|  
|**Who performs the task**|Agreement is automatically generated on a recurring basis.<br /><br /> Case: By customer support.<br /><br /> Opportunity: By sales/scheduling.<br /><br /> Unplanned: By field agent or centralized scheduling.|Dispatcher<br /><br /> Field Agent<br /><br /> Dispatcher with help of scheduling assistant<br /><br /> Routing engine|Notification, if set up, sent by system automatically to field agent, customer, and other parties. |Field agent|Field supervisor/manager,<br /><br /> back-office accounting|Automatically sent by system|  
|**Work order status**|Open - unscheduled|Open - scheduled|Open - scheduled|Open - scheduled, then open-completed|Open - completed then closed-posted|Closed-posted|  
|**Work order schedule status**|N/A|Scheduled|Scheduled|Scheduled<br /><br /> Accepted/Declined<br /><br /> Custom Status|Completed|Completed|  

## Statuses in the work order lifecycle

Field Service uses standard work order system statuses and booking statuses that map to a default work order lifecycle without any customizations. Many processes are triggered based on those statuses. A status change can automatically fill in data on the work order and trigger the next step in the work order process.

For example, when the *Booking Status* is changed to *In Progress* to indicate, the technician indicates that they have arrived at the work site. The arrival time field automatically populates on the bookable resource booking.

The default work order and booking statuses map to the following stages of the work order lifecycle.

1. When a work order is created, it has a status of *Unscheduled* by default.

1. Once the work order is scheduled, the system creates a booking with a booking status of *Scheduled*. The creation of a booking automatically changes the work order system status to *Scheduled*.

1. Technicians can see scheduled work orders it on the Field Service Mobile app. When they're on the way to the work site, they change the booking status to *Traveling*. Changing the booking status to *Traveling* automatically changes the work order system status to *In Progress*.

    > [!NOTE]
    > If there are multiple bookings for a single work order and one booking is in progress, the related work order status gets updated.

1. When the technician arrives on site and starts the work, they change the booking status to *In Progress*. The work order status remains *In Progress*.

1. Technicians indicate break time by changing the booking status to *On Break* to ensure accurate billing.

1. When the work is complete, the technician changes the booking status to *Completed*. The duration is updated to the actual duration of the booking, and the end time is updated to reflect the time the status was changed to completed. The related work order system status changes to *Completed* when all related bookings are completed or canceled. If another user updates the booking status to *Completed* on behalf of a technician, the booking’s end time preserves the previous end time value.

1. Finally, a back-office worker reviews the completed work order and starts the billing process. They change the work order system status to *Posted*.

## Status-related processes

Beyond work order system statuses updating booking statuses and vice versa, status changes can also trigger processes and data updates.

### Work order system status processes

#### Completed (work order)

- Convert [work order products](create-product-or-service.md) to new customer assets if you enabled the conversion the product record.
- Add [travel charge item](travel-charges.md) as work order product.

#### Posted

- Generates invoice for used work order products and services for the billing account of the work order.
- Creates *Actuals* records for time and costs related to work orders and bookings. Creates sales actuals for billed products and services after confirming the generated invoice.
- Updates **Closed By**  and **Closed On** fields.

### Booking status processes

Every booking status change creates a booking timestamp to keep track of the updates.

#### Scheduled

- Updates **Miles Traveled**, calculated as the driving distance from the previous location to the booking location.

#### Traveling

- When updates from Field Service Mobile, changing to Traveling updates **Start time** of bookable resource booking to current time.

#### In Progress

- Updates **Actual Arrival Time** with the date and time when a technician changes booking status on the mobile app.
- Updates **First Arrived On (Work Order)** field on the related work order with the **Actual Arrival Time** of the booking. Editing **Actual Arrival Time** also updates the **First Arrived On** value.
- Updates **Actual Travel Duration**, calculated as the total time during which the booking status is **Traveling**.

#### Completed (booking)

- Updates **End Time**.
- Creates **Booking Journals** with booking timestamps to calculate the working duration, travel time, and break time.
- Calculates **Total Duration in Progress** based on time the booking status is *In progress*.
- Calculates **Total Break Duration** based on time the booking status is *On Break*.
- Updates **Total Cost**, calculated as the sum total of actual travel duration, total duration in progress, and the total break duration, multiplied by the resource's hourly rate.
- Updates **Total Billable Duration**, calculated as the sum total of total duration in progress and total break duration.
- Updates **Completed On (Work Order)** field on the related work order with the end time of the booking. Editing the booking end time updates the **Completed On** value.

## Next steps

- [Create a work order](create-work-order.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
