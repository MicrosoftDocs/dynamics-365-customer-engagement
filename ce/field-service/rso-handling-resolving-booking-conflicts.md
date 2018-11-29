---
title: "Resolving booking conflicts | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2018
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
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Resolving Resource Scheduling Optimization booking conflicts

In scenarios where a related resource, requirement, or booking are edited by a dispatcher or field technician during optimization, this can cuase a conflict and the RSO solution provides a way to understand the conflicts and resolve them.

First, in such scenarios, the optimization request will have a status of **Completed with Conflicts** (in earlier versions the status showed as **Failed**).

Second, within the Optimization Request Booking view, a user is able to see the exact bookings that were edited during optimization and thus are conflicted. These bookings will have a Booking Status of **Simulation** along with a conflicted icon. The Operation Details column will show additional details such as the specific data that was modified during optimization. 


> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict.png)

Next, a user can select one or more conflicted bookings (with a Simulation status), and choose either:

**Apply with Overwrite** - system will commit the simulation booking i.e. choose optimization results
**Discard** - system will remove simulation booking i.e. choose the manual edits from the dispatcher or field technician 


> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict-override.png)

After selecting **Apply** or **Discard**, the Optimization Status will change to **Completed** 


> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict2.png)