---

title: Which booking allocation method should I use to avoid overbooking? (Dynamics 365 for Project Service) | MicrosoftDocs
description: An overview of the different ways you can book allocations in Dynamics 365 Project Service.
author: NeilWOrint 
manager: ShellyHa
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 for Project Service 2.x and Microsoft Dynamics 365 for Project Service 3.x
ms.author: john.burrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Which booking allocation method should I use to avoid overbooking?

[!INCLUDEcc-applies-to-psa-app-3.x]

Whether you add a team member directly to a project on the Team tab, or book a resource to a project or requirement from the schedule board, there are a few different booking allocation methods you can use. This article explains how each method works, and which methods could lead to overbooking resources.

*Choosing the allocation method when adding a team member to a project*
> [!div class="mx-imgBorder"] 
> ![Choosing the allocation method when adding a team member to a project](media/FAQ-Allocation-Methods-1.png)


*Choosing the allocation method from the schedule board*
> [!div class="mx-imgBorder"] 
> ![Choosing the allocation method from the schedule board](media/FAQ-Allocation-Methods-2.png)
 

Here’s a description of the booking allocation methods:
### Full Capacity 
This method books the resource’s full capacity for the specified from and to dates. For example, if a resource has a calendar set to work 8 hours per day, 5 days a week, setting a start and end date that covers 5 working days books the resource for 40 hours. The booking is done without regard to the resources remaining capacity. If a resource is already booked during that period on other projects, the 40 hours is booked as additional hours, potentially leading to overbookings.
### Remaining Capacity
This method is only available when you book directly to a project using the schedule board. This method books the resource’s available capacity within the specified date range. For example, if a resource has a capacity of 40 hours per week and has already been booked 10 hours in a week, booking using the remaining capacity method for the same week results in a booking for the remaining 30 hours of capacity for that week.
### Percentage Capacity
This method books the resource for a percentage of capacity for the specified from and to dates. For example, if a resource's calendar is set to work 8 hours per day, 5 days a week, setting a start and end date that covers 5 working days and at 50% capacity would book the resource for 20 hours. The individual bookings per day are spread equally across the period, for example 4 hours per day in this example. The booking is done without regard to the resource’s remaining capacity. If the resource is already booked during that period on other projects, the 20 hours is booked as additional hours, potentially leading to overbookings.
### Evenly Distribute Hours
This method books the resource for a specified number of hours, distributing the time evenly per day over the specified from and to dates. For example, if you book a resource for 20 hours over a 5-day period, this method distributes the 20 hours evenly at 4 hours per day. The booking is done without regard to the resource's remaining capacity. If the resource is already booked during that period on other projects, the 20 hours is booked as additional hours, potentially leading to overbookings.
### Front Load Hours
This method books the resource for a specified number of hours, front-loading the per-day hours over the specified from and to dates. Front-loading consumes the resource's available capacity in a “first-in-first-consumed” order. For example, if a resource’s work schedule is 8 hours per day, 5 days per week, and they have no current bookings, booking the resource for 20 hours over a 5 working day period results in the following daily booking pattern: 

|                           |    Day 1    |    Day 2    |    Day 3    |    Day 4    |    Day 5    |    Total    |
|---------------------------|-------------|-------------|-------------|-------------|-------------|-------------|
|    Existing   bookings    |    0        |    0        |    0        |    0        |    0        |    0        |
|    New   booking          |    8        |    8        |    4        |    0        |    0        |    20       |

The front load method takes into consideration existing bookings and available capacity. For example, if the same resource already has 20 hours of bookings in the work week, the new bookings consume the remaining capacity as follows:

|                     | Day 1 | Day 2 | Day 3 | Day 4 | Day 5 | Total |
|---------------------|-------|-------|-------|-------|-------|-------|
| Existing   bookings | 8     | 8     | 4     | 0     | 0     | 20    |
| New   booking       | 0     | 0     | 4     | 8     | 8     | 20    |

Because available capacity is considered, you may get an error message if the resource has no remaining capacity that can be absorbed by the booking. With this method, you can’t overbook.
### None
This method is only available when you book from the Team tab within a project. This method adds the resource as a team member on the project, but doesn’t create any bookings that absorb the resource's capacity. This method is used when the default project manager team member is added when a project is created. The project manager user who created the project is added by default to the project, so that the project entity record has an owner and there is one approver on the project. Because this user doesn't have any bookings, if you do want to book the resource you can either delete and then re-add them using a different allocation method, or add the resource to tasks and then use Extend Bookings on the Reconciliation tab to create bookings for the assignments.
## Allocation methods that lead to overbooking
To summarize, the following allocation methods lead to overbooking if the resource is already committed in other projects (or for other work orders or schedulable entities):
- Full Capacity
- Percentage Capacity
- Evenly Distribute Hours

When using one of these three allocation methods, you won’t be notified that the resource is overbooked. To correct the overbooking, you’ll need to use the schedule board.

