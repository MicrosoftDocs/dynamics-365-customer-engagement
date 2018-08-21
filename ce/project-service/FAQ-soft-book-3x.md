---

title: How can I soft-book project team members with Project Service 3.x? (Dynamics 365 for Project Service) | MicrosoftDocs
description: This article describes how to soft-book project team members with Project Service.
author: NeilWOrint 
manager: ShellyHa
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

# How can I soft-book project team members with Project Service 3.x?

You can soft-book resources onto a project team as a way of showing you intend a resource to work on a project. Soft bookings don’t consume a resource’s available capacity. Soft-booked team members can be assigned to project tasks. However, since soft booking doesn’t consume a resource’s capacity, they may be hard-booked on other tasks within the same period. Generic resources can’t be soft-booked, nor can a soft-booking fulfill a generic resource request.

Soft-booked project team members show up in the team tab with their soft booked hours indicated in the Soft Booked Hours column in the Named Resources view. They also show up on the Schedule Board. Again, they don’t indicate any consumption of capacity as soft booking doesn’t consume capacity of a resource. Soft-booked time doesn’t show up on the Reconciliation tab nor is it shown in the Extend Bookings field in the Reconciliation tab. 

There are two ways to soft-book a team member onto a project. You can soft-book directly with the Schedule Board, or add team members on the Team tab. 

## Soft-booking with the Schedule Board

To use this method, take the following steps:
1. Open the Schedule Board.
2. Select the Project tab on the bottom Booking Requirements panel of the Schedule Board.
3. Find the project you wish to soft-book a resource on. Click on the Project column header and then use the filter to filter if you have many projects.
4. Click on the project, then drag and drop it on the resource’s time grid.
5. With the Create Resource Booking panel now open on the right, adjust the start and end date. Then set the Booking Status to Soft and set the hours. 
6. Click Book.
7. Back on the project, the resource now shows on the Team tab as a resource. On the Named Team Member view you’ll see the soft-booked hours in the Soft Booked Hours column.

Note that you can now assign the soft booked to tasks on the Schedule tab. On the Reconciliation tab, the resource shows a booking deficit relative to their task assignment as the Reconciliation tab only considers hard bookings. You can use the Extend Bookings feature to hard-book the resource to eliminate the deficit of hard bookings against the resources assignments. You’ll have to manually cancel the soft booking for the resource by using Maintain Bookings.

## Soft-book by adding team members on the Team tab

Add team members directly as a team member on the Team tab, and then change their booking status from Hard to Soft with Maintain Bookings. When you add a team member in this manner, it will always result in a hard booking unless you select the allocation method as None.
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
6. When the Schedule Board opens, expand the resource to show their bookings. You will see the booking shown as Hard.
7. Right-click the booking, under Change Status, select Soft Book and then Soft. The booking status is now Soft.
8. After closing the Schedule Board, you’ll see that the hours for the resource have moved from the Hard Booked Hours column to the Soft Booked Hours on the Team tab grid, when looking at the Named Team Members view.

Note that if you hard-book a resource onto the team and then assign them tasks in the schedule, when you use maintain bookings to change the status of Hard to Soft, it retains the task assignments for that resource. However, on the Reconciliation tab, the resource will have a booking deficiency as only hard bookings are considered when reconciling bookings versus assignments. You can use the Extend Bookings feature on the Reconciliation tab to hard-book the resource to eliminate the deficit of hard bookings against the resources assignments. You’ll have to cancel the soft-booking for the resource by using Maintain Bookings.

When you’re ready to change a soft-booked team member resource to a hard-booked team member, do the following:

1. On the Schedule Board, expand the resource to show their bookings. You’ll see the booking shown as Soft.
2. Right-click the booking, under Change Status, select Hard Book and then Hard. The booking status is now Hard.
3. After closing the Schedule Board and going back to the project and opening the Team tab, you’ll see that the hours for the resource have moved from the Soft Booked Hours column to the Hard Booked Hours column on the Team tab when in the Named Team Members view. If the resource was assigned to tasks they’ll no longer show a booking deficit on the Reconciliation tab as their bookings are now hard.
