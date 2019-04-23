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

# Work Order life cycle and statuses

Work Order System Statuses, Work Order Substatuses, and Booking Statuses all work together to help stakeholders stay up to date with work orders during the life cycle from creation to close. Updating one of these statuses can update the others automatically.

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


1. **Work Order life cycle**. A field service organization wants to understand how the out-of-the-box statuses are designed for the work order process without any customizations based on their specific business needs.

2. **Estimate work order**. A field service organization would like to utilize work orders for estimating potential products, services, and prices for their clients and want to mark such work orders with a custom "Estimate" work order substatus.

3. **Delayed schedules**. Field technicians want to make dispatchers aware if they are running more than 15 minutes behind schedule due to traffic or longer than expected work by changing the status of their bookings to "Delayed".

4. **Follow up work orders**. It is common for a field service organization to schedule a follow up inspection after an initial installation or repair work order. If a follow up is required, field technicians should note this with a custom "Follow Up Required" work order substatus to ensure back office workers create a follow up before closing the work order.

## Prerequisites

- Any version of Field Service
- You must be logged in as a user with **Field Service - Dispatcher**, **Field Service - Administrator**, or **System Administrator** security roles to edit Work Order Substatuses and Booking Statuses

> [!Note]
> Work Order System Statuses should NEVER be edited because system jobs and plug-ins rely on these statuses. Instead, administrators should create custom Work Order Substatuses that relate to Work Order System Statuses.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Work Order life cycle

A field service organization wants to understand how the out-of-the-box statuses are designed for the work order process without any customizations based on their specific business needs.

Field Service ships with standard Work Order System Statuses and Booking Statuses that should be considered during all field service implementations because many processes are triggered based on those statuses that make the field service app more valuable for an organization by **(1)** automatically calculating and populating data and **(2)** automating the next step in the work order process. As one example, when the **booking status** is changed to **in progress** to indicate the field technician has arrived on site, the Actual Arrival Time field is populated accordingly on the bookable resource booking. As another example, when the **work order system status** is changed to **Open-Completed**, applicable Work Order Products are converted to Customer Assets to begin building service history.

Let's walk through the standard work order and booking statuses at each stage of the work order life cycle.

When a work order is created, it has a status of **Open-Unscheduled** by default.

Once the work order is scheduled, i.e. a booking is created for it, the work order system status automatically changes to **Open-Scheduled**.

The Booking that is created when the work order is scheduled has a booking status of S**cheduled** by default.

After the work order is scheduled to a field technician resource, it is viewable on the Field Service Mobile app and the next step is for the field technician to note that he or she is traveling to the work order location by changing the booking status to **Traveling**. 

Each booking status has a color and icon and is displayed on the schedule board.

Changing the booking status to Traveling automatically changes the work order system status to **Open - In Progress**.

> [!Note]
> If there are multiple bookings for a single work order, if at least one booking is traveling or in progress, the related work order will have a status of Open - In Progress.

When the field technician arrives on site and is ready to begin the work order, he or she changes the booking status to **In Progress**.

During work, the field technician may want to record times he or she is on break by changing the booking status to **On Break**.

When the work is complete, the field technician will change the booking status to **Completed** and this will change the related Work Order System Status to **Open-Completed**.

> [!Note]
> If there are multiple bookings for a single work order, once all related booking have statuses of Completed including fi a portion are Canceled, the related work order will have a status of **Open - Completed**. 

Here is a table fo the out of the box relationship between work order system statuses and booking statuses.

| Work Order System Status | Booking Status | Details |
| --- | --- | --- |
| Open-Unscheduled | -- | Not applicable as booking does not exist yet |
| Open-Scheduled | Scheduled | |
| Open-In Progress | Traveling | |
| Open-In Progress | In Progress | |
| Open-In Progress | On Break | |
| Open-Completed | Completed | |
| Closed-Posted | Scheduled | |
| Closed-Canceled | Canceled | If the work order system status is changed to Closed-Canceled all booking with a status of Scheduled will change to Canceled |
| Open-Unscheduled | Canceled | If the booking status is canceled, the work order system status will revert to Open-Unscheduled |

### Status related processes

#### Work order system status

Open – Unscheduled
		o Default status when work order is created
Open – Scheduled
		o Default status when bookings exist but the work has not yet been begun.
				§ Bookings exist in a Booking Status where Field Service Status is “Scheduled.”
Open - In Progress
		o Default status when at least one booking is in a status indicating that work is actively being performed.
				§ Bookings exist in a Booking Status where Field Service Status is “Traveling,” “In Progress,” or “On Break.”
Open – Completed
		o Default status when all bookings are either completed or cancelled with at least one booking in a status indicating that work has been completed.
				§ All bookings on a work order in a Booking Status where Field Service Status is “Completed” or “Canceled” with at least one that is “Completed.”
		o Can also be set to this status manually, assuming no bookings are “Scheduled,” “Traveling,” “In Progress,” or “On Break.”
		o Applicable used work order products and services become customer assets
		o Travel charge item is added to work order products if applicable
Closed – Posted
		o Status to be used when all work on the work order is completed and the work is ready to be posted to the general ledger (Note: Field Service does not have detailed accounting functionality. General ledger refers to the overall business process).
		o Invoice is generated for billing account + Actuals.
Closed – Canceled
		o Default state to use when indicating that all of the work for the work order is cancelled and should not be performed.
		o Cancelling a Booking does not drive the Work Order to this Open – Canceled system status.
		o Can we set into this state manually.


#### Bookable resource booking
		
Scheduled
		o Timestamp created
		o Work order system status becomes open-scheduled
Traveling
		o Timestamp created
		o Work order system status becomes open-completed if sole booking of work order
In Progress
		o actual arrival time field updated
		o actual travel duration field updated
		o Miles Traveled
		o Timestamp created
On Break
		o Timestamp created
Completed
		o End time field updated
		o Total duration in progress updated
		o Total Cost
		o Total Billable Duration
		o Total Duration In Progress
		o Total Break Duration
		o Booking journals
		o Work order system status becomes open-completed if sole booking of work order
		o Timestamp created
Canceled

## Estimate Work Order Sub-status

A field service organization would like to utilize work orders for estimating potential products, services, and prices for their clients and want to mark such work orders with a custom "Estimate" work order substatus.

First, go to **Field Service > Settings > Work Order Substatuses > then select +New**

**Name:** "Estimate

**System Status:** Open-Unscheduled. When the field service organization is building a work order

**Default Substatus:**


## Delayed Booking Status

### Relationship between Work Order System Status and Booking Status

## Follow up Work Order Sub-status

## Configuration considerations
- Booking statuses with RSO
  - new ones
  - simulation -RSO

## Additional Notes
> ### Related processes
> When the Work Order System Statuses becomes:

  > - Open - Unscheduled
  > - Open - Scheduled
  > - Open - In Progress
  > - Open - Completed
  > - Closed - Posted
  > - Closed - Canceled

  > When the Bookable Resource Booking, Booking Statuses becomes: 

  > - Scheduled
  > - Traveling
  > - In Progress
  > - On Break
  > - Completed
  > - Canceled


See also
[Booking Statuses Blog](https://community.dynamics.com/365/b/365teamblog/archive/2017/06/01/manage-the-status-of-your-team-s-bookings-with-universal-resource-scheduling)