---

title: How do I "soft book" resources in app version 2.x? 
description: This article describes how to soft book project team members with Project Service.
author: JohnPBurrows 
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: Applies to Project Service version 2.x
ms.service: business-applications
ms.technology: 
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

# How do I "soft book" resources in the web app (Project Service app v2.x)?

[!INCLUDE[cc-applies-to-psa-app-1.x-2.x](../includes/cc-applies-to-psa-app-1x-2x.md)]

You can tentatively schedule or "soft book" a resource onto a project team to show you plan to assign the resource to a project. Soft bookings don’t consume a resource’s available capacity. Soft-booked team members can’t be assigned to project tasks. Only resources with the Status Hard Booked and Commit Type Committed can be assigned to tasks (assuming they have enough hard booking hours to cover the assignment effort).

Soft-booked project team members show up in the Team Member grid with their soft-booked hours shown in the Soft Book column. They also show up on the schedule board. Again, they don’t indicate any consumption of capacity as soft-booking doesn’t consume capacity of a resource.

There are three ways to soft-book a team member onto a project with Project Service version 2.x. You can soft-book with the schedule board, use the Maintain Bookings feature, or by creating a generic resource. These methods are described below.

## Soft-book with the schedule board

To soft-book with the schedule board, follow this procedure: 
1. Open the schedule board.
2. Select the Project tab on the bottom Booking Requirements panel of the schedule board.
3. Find the project you wish to soft-book a resource on. If you have many projects, click on the Project column header and then use the filter to find your project.
4. Click on the project, then drag and drop it on the resource’s time grid.
5. This opens the Create Resource Booking panel on the right. Adjust the start and end date, select the Booking Status as Soft and set the hours. 
6. Click Book.
7. Back on the project, the resource will now show as a team member with the soft booked hours in the Soft Book column.

Note that you can’t assign them to tasks on the work breakdown structure (WBS) as resources must be hard booked on the team to be assigned.

## Soft-book using the Maintain Bookings feature

To soft-book with Maintain Bookings follow this procedure:
1. From the team member grid, Click New.
2. Select the bookable resource, role, from/to.
3. Select an allocation method other than None:
- Full Capacity
- Percentage Capacity
- By Hours Distribute Evenly
- By Hours Front Load
4. Click Save. You’ll see the resource on the team grid and their hours indicated as Hard.
5. Maintain the resource’s bookings by clicking Maintain Bookings.
6. When the schedule board opens, expand the resource to show their bookings. You will see the booking indicated as Hard.
7. Right-click the booking, under Change Status, select Soft Book and then Soft. The booking status is now Soft.
8. After closing the schedule board, you’ll see that the hours for the resource have changed from Hard to Soft on the team member grid.
Note that if you hard book a resource onto the team and then assign them tasks in the WBS, when you use maintain bookings to change the status of Hard to Soft, it will remove the assignments from the tasks for that resource, as only hard booked resources can be assigned to tasks.

## Soft-book by creating a generic resource

You can create a soft-booking by generating a generic resource team member, fulfilling with schedule board or Resource Request and changing the type during the booking.
To do this, use the following procedure:

1. On the project WBS, assign roles to the tasks you wish to generate generic team members for.
2. Click Generate Project Team.
3. On the project team member grid, select the generic resource and click Book.
4. On the schedule board, select the resource that you wish to book.
5. On the schedule board’s Create Resource Booking panel, change the Booking Status to Soft.
6. Click Book or Book and Exit.

After closing the schedule board, you’ll see the selected resource added to the team with Soft booked hours as well as assigned hours. You’ll also see that the generic resource remains on the team as an indicator that the tasks are assigned to a soft-booked team member.

When you’re ready to change a soft-booked team member resource to a hard-booked team member so that you can assign them to tasks, do the following:

1. Select that resource and click Maintain Bookings.
2. When the schedule board opens, expand the resource to show their bookings. You’ll see the booking marked as Soft.
3. Right-click the booking, under Change Status, select Hard Book and then Hard. The booking status is now Hard.
4. After closing the schedule board, you’ll see that the hours for the resource have changed from Soft to Hard on the team member grid. You may now assign the resource to tasks (provided there is alignment between the hard-booked hours and the effort hours of the task for assignment). Note that if you followed the generic resource fulfilment steps in item #3 above, when you change the status of the soft-booked bookable resource to hard, the generic team member is removed from the team.
