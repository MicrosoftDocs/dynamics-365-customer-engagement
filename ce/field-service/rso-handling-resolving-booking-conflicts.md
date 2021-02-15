---
title: "Resolving booking conflicts in resource scheduling optimization for Dynamics 365 | MicrosoftDocs"
description: Learn how to resolve booking conflicts in resource scheduling optimization for Dynamics 365
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/05/2018
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Resolving booking conflicts in resource scheduling optimization

Conflicts will arise when a related resource, requirement, or booking is edited by a dispatcher or field technician during optimization; the resource scheduling optimization solution provides a way to understand these conflicts and resolve them.

In conflict scenarios, the optimization request will have the status **Completed with Conflicts** (in earlier versions, the status showed as **Failed**).

Within the optimization request booking view, you can see the conflicted bookings that were edited during optimization. These bookings will have a booking status of **Simulation**, along with a conflicted icon. 

The **Operation Details** column shows additional details, like the specific data modified during optimization. 

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict.png)

To resolve the issue, select one or more conflicted bookings (with a Simulation status), and choose either:

- **Apply with Overwrite**: commit the simulation booking, favoring optimization results
- **Discard**: remove simulation booking, favoring the manual booking edits from the dispatcher or field technician


> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict-override.png)

After selecting **Apply with Overwrite** or **Discard**, the optimization status changes to **Completed**, and the conflict is resolved. 

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements](./media/scheduling-rso-3-0-booking-conflict2.png)


[!INCLUDE[footer-include](../includes/footer-banner.md)]