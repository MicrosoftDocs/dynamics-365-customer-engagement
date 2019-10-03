---

title: Soft book a resource
description: This topic provides information about how to tentatively schedule or soft book project team members.
author: ruhercul        
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 9/25/2019
ms.topic: article
ms.prod: Applies to Project Service version 3.x
ms.service: business-applications
ms.technology: 
ms.author: ruhercul
audience: Admin

---

# Soft book a resource

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

You can tentatively schedule or "soft book" a resource onto a project team to show that you plan to assign the resource to the project. Soft bookings don’t consume a resource’s available capacity, and you can assign soft-booked team members to project tasks. However, because soft booking doesn’t consume a resource’s capacity, you can still "hard book" the resource for other tasks within the same period. Generic resources can’t be soft booked, nor can a soft booking fulfill a request for a generic resource.

Soft-booked project team members are listed on the **Team** tab of the **Project** page, with their soft-booked hours shown in the **Soft Booked Hours** column in the **Named Team Members** view. Soft-booked team members are also listed on the Schedule board. Because they are soft booked, the Schedule board doesn't show any consumption of capacity for these resources. Soft-booked time doesn’t show up on the **Reconciliation** tab, nor is it shown in the **Extend Bookings** field in the **Reconciliation** tab of the Schedule board. 

There are two ways to soft book a team member onto a project: directly from the Schedule board, or by adding the team member on the **Team** tab. 

## Soft book from the Schedule board
Complete the following steps to soft book a resource from the Schedule board. 

1. Open the Schedule board, and then in the **Booking Requirements** panel, select the **Project** tab.
2. Find the project for which you want to soft book a resource. If there are a large number of projects in the list, select the **Project** column header, and then use the filter to search for one or more projects.
3. Select the project, and then drag-and-drop it on the resource’s time grid.
5. In the **Create Resource Booking** panel, adjust the start and end date, set the **Booking Status** to **Soft**, and then set the hours. 
6. Click **Book**. The resource now shows on the **Team** tab as a resource for the project. On the **Named Team Member** view you’ll see the soft-booked hours in the **Soft Booked Hours** column.

> [!NOTE]
> You can now assign the soft booked to tasks on the **Schedule** tab. On the **Reconciliation** tab, the resource shows a booking deficit relative to the task assignment as the **Reconciliation** tab only considers hard-bookings. You can use the **Extend Bookings** feature to hard-book the resource to eliminate the deficit of hard-bookings against the resources assignments. You’ll have to manually cancel the soft booking for the resource by using **Maintain Bookings**.

## Soft book on the Team tab

You can add team members directly on the **Team** tab, and then change their booking status from **Hard** to **Soft** with **Maintain Bookings**. When you add a team member this way, it will always result in a hard-booking unless you select the allocation method as **None**.

To use this method, complete the following steps.

1. On the **Project** page, on the **Team** tab, click **New**.
2. Select the bookable resource, the role, and the from and to dates.
3. Select an allocation method other than **None**.
4. Select **Save**. You’ll see the resource on the grid and their hours in the **Hard Booked Hours** column.
5. Maintain the resource’s bookings by selecting **Maintain Bookings**.
6. When the Schedule board opens, expand the resource to show their bookings. You will see the booking shown as **Hard**.
7. Right-click the booking, and under **Change Status**, select **Soft Book** \> **Soft**. The booking status is now **Soft**.
8. After you close the Schedule board, you’ll see that the hours for the resource have moved from the **Hard Booked Hours** column to the **Soft Booked Hours** on the **Team** tab grid, when looking at the **Named Team Members** view.

> [!NOTE]
> When you use **Maintain Bookings** to change the status from **Hard** to **Soft**, if you hard-book a resource onto the team and then assign tasks to the resource, the task assignments for the resource are retained. However, on the **Reconciliation** tab, the resource will have a booking deficiency because only hard-bookings are considered when reconciling bookings versus assignments. You can use the **Extend Bookings** feature on the **Reconciliation** tab to hard-book the resource to eliminate the deficit of hard bookings against the resources assignments. You’ll have to cancel the soft booking for the resource by using **Maintain Bookings**.

When you’re ready to change a soft-booked team member resource to a hard-booked team member, do the following:

1. On the Schedule board, expand the resource to show their bookings. You’ll see the booking shown as **Soft**.
2. Right-click the booking, and under **Change Status**, select **Hard Book** \> **Hard**. The booking status is now **Hard**.
3. After you close the Schedule board, return to the project, and open the **Team** tab, you’ll see that the hours for the resource have moved from the **Soft Booked Hours** column to the **Hard Booked Hours** column on the **Team** tab when in the **Named Team Members** view. If the resource was assigned to tasks, they’ll no longer show a booking deficit on the **Reconciliation** tab as their bookings are now hard.

