---

title: How do I "soft book" resources? (Dynamics 365 for Customer Engagement for Project Service) | MicrosoftDocs
description: This article describes how to tentatively schedule or "soft book" project team members with Project Service.
author: JohnPBurrows 
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/20/2018
ms.topic: article
ms.prod: Applies to Project Service version 3.x
ms.service: business-applications
ms.technology: 
ms.author: john.burrows
audience: Admin

---

# How do I "soft book" resources? 

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

You can tentatively schedule or "soft book" a resource onto a project team to show that you plan to assign the resource to the project. Soft bookings don’t consume a resource’s available capacity, and you can assign soft-booked team members to project tasks. However, because soft booking doesn’t consume a resource’s capacity, you can still "hard book" the resource for other tasks within the same period. Generic resources can’t be soft-booked, nor can a soft-booking fulfill a generic resource request.

Soft-booked project team members are listed on the Team tab, with their soft-booked hours shown in the Soft Booked Hours column in the Named Resources view. Soft-booked team members are also listed on the schedule board. Because they are soft booked, the schedule board doesn't show any consumption of capacity for these resources. Soft-booked time doesn’t show up on the Reconciliation tab, nor is it shown in the Extend Bookings field in the Reconciliation tab. 

There are two ways to soft book a team member onto a project: directly from the schedule board, or by adding the team member on the Team tab. 

## Soft book from the schedule board

To use this method, take the following steps:
1. Open the schedule board.
2. Select the Project tab on the bottom Booking Requirements panel of the schedule board.
3. Find the project you wish to soft book a resource on. Click on the Project column header and then use the filter to filter if you have many projects.
4. Click on the project, then drag and drop it on the resource’s time grid.
5. With the Create Resource Booking panel now open on the right, adjust the start and end date. Then set the Booking Status to Soft and set the hours. 
6. Click Book.
7. Back on the project, the resource now shows on the Team tab as a resource. On the Named Team Member view you’ll see the soft-booked hours in the Soft Booked Hours column.

Note that you can now assign the soft booked to tasks on the Schedule tab. On the Reconciliation tab, the resource shows a booking deficit relative to their task assignment as the Reconciliation tab only considers hard bookings. You can use the Extend Bookings feature to hard-book the resource to eliminate the deficit of hard bookings against the resources assignments. You’ll have to manually cancel the soft booking for the resource by using Maintain Bookings.

## Soft book on the Team tab

Add team members directly on the Team tab, and then change their booking status from Hard to Soft with Maintain Bookings. When you add a team member in this manner, it will always result in a hard booking unless you select the allocation method as None.
To use this method, take the following steps:

1. From the Team tab, Click New.
2. Select the bookable resource, role, from and to dates.
3. Select an allocation method other than None:
- Full Capacity
- Percentage Capacity
- By Hours Distribute Evenly
- By Hours Front Load
4. Click Save. You’ll see the resource on the grid and their hours in the Hard Booked Hours column.
5. Maintain the resource’s bookings by clicking Maintain Bookings.
6. When the schedule board opens, expand the resource to show their bookings. You will see the booking shown as Hard.
7. Right-click the booking, under Change Status, select Soft Book and then Soft. The booking status is now Soft.
8. After closing the schedule board, you’ll see that the hours for the resource have moved from the Hard Booked Hours column to the Soft Booked Hours on the Team tab grid, when looking at the Named Team Members view.

Note that if you hard-book a resource onto the team and then assign them tasks in the schedule, when you use maintain bookings to change the status of Hard to Soft, it retains the task assignments for that resource. However, on the Reconciliation tab, the resource will have a booking deficiency as only hard bookings are considered when reconciling bookings versus assignments. You can use the Extend Bookings feature on the Reconciliation tab to hard-book the resource to eliminate the deficit of hard bookings against the resources assignments. You’ll have to cancel the soft-booking for the resource by using Maintain Bookings.

When you’re ready to change a soft-booked team member resource to a hard-booked team member, do the following:

1. On the schedule board, expand the resource to show their bookings. You’ll see the booking shown as Soft.
2. Right-click the booking, under Change Status, select Hard Book and then Hard. The booking status is now Hard.
3. After closing the schedule board and going back to the project and opening the Team tab, you’ll see that the hours for the resource have moved from the Soft Booked Hours column to the Hard Booked Hours column on the Team tab when in the Named Team Members view. If the resource was assigned to tasks they’ll no longer show a booking deficit on the Reconciliation tab as their bookings are now hard.
