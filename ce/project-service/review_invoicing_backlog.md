---

title: Review invocing backlog on Projects and / or Project Contracts
description: Process description of how to review time, expense, product backlog and mark them as ready for invoicing 
author: Rupa Mantravadi
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 2/25/2018
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 for Customer Engagement for Project Service 2.x and Microsoft Dynamics 365 for Customer Engagement for Project Service 3.x
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Review invoicing backlog

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In the latest version PSA, transactions that need to invoiced should be marked as "Ready to invoice" before invoicing can pick them up and create an invoice.  

Here’s a description of this process for the differnt types of transactions that can be created in Project Service application.  
### Review time and material billing backlog
This method books the resource’s full capacity for the specified from and to dates. For example, if a resource has a calendar set to work 8 hours per day, 5 days a week, setting a start and end date that covers 5 working days books the resource for 40 hours. The booking is done without regard to the resources remaining capacity. If a resource is already booked during that period on other projects, the 40 hours is booked as additional hours, potentially leading to overbookings.
### Review product billing backlog
This method is only available when you book directly to a project using the schedule board. This method books the resource’s available capacity within the specified date range. For example, if a resource has a capacity of 40 hours per week and has already been booked 10 hours in a week, booking using the remaining capacity method for the same week results in a booking for the remaining 30 hours of capacity for that week.
### Review billing milestones on fixed price contracts 
This method books the resource for a percentage of capacity for the specified from and to dates. For example, if a resource's calendar is set to work 8 hours per day, 5 days a week, setting a start and end date that covers 5 working days and at 50% capacity would book the resource for 20 hours. The individual bookings per day are spread equally across the period, for example 4 hours per day in this example. The booking is done without regard to the resource’s remaining capacity. If the resource is already booked during that period on other projects, the 20 hours is booked as additional hours, potentially leading to overbookings.

