---
title: "Schedule in sequence with Requirement Dependencies | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
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
search.app: 
  - D365CE
  - D365FS
---

# Schedule in sequence with Requirement Dependencies

Ensure Resource Scheduling Optimization (RSO) auto schedules requirements in sequence by adding requirement dependencies.

This is helpful for many scenarios including but not limited to:

1) a technician needs to travel to one location to pick up a unique part from the warehouse before performing at the customer's site.
2) a work order must be completed and approved before another work order can begin. For example, a physical installation must occur before an electrical connection.


Requirement dependencies allow customers to schedule requirements in a specific order by relating them through a predecessor and successor dependency relationship. When RSO 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency.png)


## Prerequisites

Early access Feb 3

> [!Note]
>



## Instructions

Create a requirement and add predecessor and successor requirements
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-nav.png)


As an example
> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-successor.png)


Run RSO, there is no constraint or objective, RSO will always respect dependencies

## Configuration considerations

Applies to single requirements

Also these dependencies will work only for single-resource, single-day scenarios.


## Additional Notes

Will ensure the start time of the successor is after the end time of the predecessor. RSO may schedule the successive requirements on the following day or days but to the same resource. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-day-gap.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-different-location.png)

Does not apply to requirement groups
Does not apply to manual scheduling or schedule assistant

Chain is scheduled to same resource 

Will schedule around other bookings 