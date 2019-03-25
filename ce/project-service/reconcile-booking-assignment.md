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

For project team members, their bookings to the project and project task assignments are loosely coupled. This means that resources can have assignments without corresponding bookings and bookings without task assignments. Ideally, a project manager would like bookings and assignments to be aligned so that resources have committed capacity to perform their task assignments. However, the reality is that bookings may happen based on availability and task timings may change as the project continues on in its lifecycle. Because of this loose coupling of bookings and assignments to allow for flexibility, PSA has a tab on the project entity called the Reconciliation View to assist project managers to be able to reconcile team member bookings and their assignments for their project team. 

You can get to the Reconciliation View for a project by clicking the Reconciliation tab on the project entity. 
 
GRAPHIC 
 
The reconciliation view shows for each named team member their bookings and assignments down to the individual task assignment. The view shows hours in cells which can represent time phases from months down to days. 

You can use the timescale control to choose the timescale of Month, Week or Day.  The view uses week as the default, but you can change the default under settings.  The view will open set to the current date, and you can use the calendar control to move forward or backwards in time.  In the case where a project has a start date that is sometime in the future, the reconciliation view will open on that date.  The calendar control also has move to project start date and move to project end date controls as well.   

You can use the expander controls on each resource to show the details on their bookings as well as expand their assignments to the individual task level. 

GRAPHIC 
 
The view also shows an overall net total for the project at the bottom along with a total column. 

For each resource, the view takes the difference between a team member’s bookings on the project and rollup of their task assignments. Ideally, this should be zero i.e. there is no difference between the resource’s bookings and their task assignments. Any differences are indicated with color/shading to call out two conditions: 

- Booking shortage. Booking shortages occur when a resource has more assignments than they have bookings. Since this capacity has not been reserved, a project manager may wish to correct this by extending the resource’s bookings to cover the deficit. 
- Excess bookings. An excess of bookings occurs where a resource has been booked to the project, but has not been assigned to tasks. This may be an acceptable occurrence, for example the resource has been booked prior to task assignment. However, in other cases the resource may not be planned to assigned and the PM should consider cancelling the resource’s bookings to allow the capacity to be used for another project. 

The legend for these conditions may be hidden via Settings in order to have more room on the screen for the grid. 

In some cases when using the time view at a higher level than day, differences may net to zero. For example, in a month view you may see a net 0 for a resource (meaning bookings = assignments), but if you looked at the week you would see that in the first week of the month there are assignments of 0hrs and bookings of 40 and in the second week of the month assignments of 40 and bookings of 0. In total for the month the bookings and assignments net, but by week they have a difference. The reconciliation view will show that there are differences at lower levels when viewing at higher time levels with a cell indicator.  

For example, the cell indicator for the resource Katelyn Merritt in the month of October, 2018 shows that even though the resources have bookings equal to assignments aggregated at the month level, at a lower level there is a mis-match between bookings and assignments. 

GRAPHIC

By double-clicking on such a cell, you can zoom-in to the next level to reveal the difference. In the example, double clicking on October difference for Katelyn Merritt, drills down to the week view, and you can see that she has bookings totaling 16 hours without any assignments in the first two weeks of October and assignments of 16 hours in the third week of October without any bookings. 

GRAPHIC?
 
You can then right-click to zoom-out a level. You can also turn off the lower level indicator under Settings. 
You can also use the previous and next difference buttons to navigate through any differences in your project.  The difference buttons work when you have a resource selected.  With a resource selected, Using the next difference control in the grid toolbar will navigate you to the next difference between bookings and assignments for that selected resource. Previous will navigate you back. 

When you have a situation where you have task assignments for a resource without bookings, you can select the booking shortage and click the Extend Booking button (or right-click and select Extend bookings from the context menu).  
 
This will bring up a surface where you can see the booking needed to address the resource’s shortage along with their bookings on this and other projects. Clicking OK will create the booking for the resource without regards to their current availability. 
The PM or their resource manager can then use Schedule Board to manage any situations that may occur where the result of extending a resource is that they are overbooked beyond their capacityl.
