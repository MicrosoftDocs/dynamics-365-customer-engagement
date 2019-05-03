---
title: Reconcile bookings and assignments
description: This topic provides information about actuals in Dynamics 365 for Project Service Automation (PSA). 
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/25/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Reconcile bookings and assignments

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

A project team member's project bookings and project task assignments are loosely coupled. This means that a resource can have an assignment that doesn't correspond to bookings and bookings that don't correspond to task assignments. Ideally, project bookings and assignments are aligned so that resources have committed capacity to perform their task assignments. However, the reality is that bookings may happen based on availability and task timings may change as the project continues through its lifecycle. Because of the loose coupling of bookings and assignments to allow for flexibility, Dynamics 365 for Project Service Automation (PSA) has a tab on the Project entity called **Reconciliation** view. This view assists project managers in reconciling team member bookings and their assignments for their project team. 
 
For each named team member, the Reconciliation view shows bookings and assignments down to the individual task assignment. The view shows hours in cells which can represent time phases from months down to days. 

In the **Timescale** field, you can select **Month**, **Week**, or **Day**. The view automatically selects **Week**, but you can change it by clicking the **Settings** icon. The view will open to the current date, and you can use the calendar control to move forward or backward in time. When a project has a start date that is sometime in the future, the Reconciliation view will open on that date. The calendar control also has move to project start date and move to project end date controls as well.   

You can use the expander controls on each resource to show the details on their bookings as well as expand their assignments to the individual task level. 
 
The view also shows an overall net total for the project at the bottom along with a total column. For each resource, the view takes the difference between a team member’s bookings on the project and rollup of their task assignments. Ideally, this should be zero, with no difference between the resource’s bookings and their task assignments. Any differences are indicated with color/shading to call out two conditions: 

- **Booking shortage**: Booking shortages occur when a resource has more assignments than they have bookings. Since this capacity has not been reserved, a project manager can correct this by extending the resource’s bookings to cover the deficit. 
- **Excess bookings**: Excess bookings occur when a resource has been booked to the project, but has not been assigned to tasks. This may be an acceptable occurrence, for example if the resource has been booked prior to task assignment. However in other cases, the resource may not be planned to assigned and the project manager should consider canceling the resource’s bookings to allow the capacity to be used for another project. 

> [!NOTE]
> The legend for these conditions may be hidden in the **Settings** in order to have more room on the screen for the grid. 

In some cases, when the Time view is used at a higher level than Day, differences may calculate to zero. For example, in a Month view you may see a net zero for a resource (meaning bookings = assignments), but if you looked at the week you would see that in the first week of the month there are assignments of zero hours and bookings of 40 hours and in the second week of the month assignments of 40 hours and bookings of zero hours. In total for the month, the bookings and assignments are equsl, but by week they differ. 

The reconciliation view will show that there are differences at lower time levels when viewing at higher time levels with a cell indicator. For example, the cell indicator for the resource Katelyn Merritt in the month of October, 2018 shows that even though the resources have bookings equal to assignments that are aggregated at the month level, there is a mis-match at the lower level between bookings and assignments. 

![Mismatched bookings and assignments](media/reconcile-assignments-01.JPG)

Double-click on a cell zoom-in to the next level and view the difference. In the example used, double-click the October difference for Katelyn Merritt. This drills down to the Week view, and you can see that she has bookings totaling 16 hours without any assignments in the first two weeks of October, and assignments of 16 hours in the third week of October without any bookings. 

![Mismatched bookings and assignments](media/reconcile-assignments-02.JPG)
 
You can right-click to zoom-out a level or, you can turn off the lower level indicator in the **Settings**. 
You can also use the **Previous** and **Next** difference buttons to navigate through any differences in your project. To do this, you must have a resource selected. Using the **Next** difference control in the grid toolbar will navigate you to the next difference between bookings and assignments for that selected resource. **Previous** will navigate you back. 

When you have a situation where you have task assignments for a resource without bookings, you can select the booking shortage and click **Extend Booking** or right-click and select **Extend bookings** from the context menu.  
 
You can then see the booking needed to address the resource’s shortage along with their bookings on this and other projects. Select **OK** to create the booking for the resource without regards to current availability. 
The project manager or their resource manager can then use Schedule Board to manage any situations that may occur where the result of extending a resource is that they are overbooked beyond their capacity.
