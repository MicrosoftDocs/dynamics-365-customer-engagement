---
title: "Schedule in sequence with Requirement Dependencies | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/3/2020
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


Requirement dependencies allow customers to schedule requirements in a specific order by relating them through a predecessor and successor dependency relationship. When RSO runs, it ensures the requirements are scheduled in the correct order where the start time of the defined predecessor is after the end time of the predecessor. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency.png)

In the image above you can see RSO scheduled requirements  "Task 2.1", "Task 2.2", and "Task 2.3" in order.


## Prerequisites

> [!Note]
> Early access Feb 3




## Instructions

First create two or more requirments like you would any requirements. This can be manually creating two requirements or utilizing the requirements that are automatically created when a work order is created.

From the requirement that should be completed first go to **Related > Successors**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-nav.png)


Add the first requirement as a predessor and the second requirement as a successor. In the example below we have two requirements, Task 1.1 which should be completed first followed by Task 1.2 which should be completed second. Leave Dependency type as _StartAfterEnd_.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-successor.png)

For as many requirements as there are in the sequence, add a requirement dependency for each one. In our example there is another requirement "Task 1.3" that must be performed after Task 1.2 so we added another requirement dependency record from requirement Task 1.2 as seen in the image below.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-next-link.png)

After creating each requirement and adding the desired requirement dependencies, run RSO. Assuming the requirements are within RSO's scope, RSO will resepct the dependencies. There is no constrain or objective that must be added to the Optimization Goal.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-different-location.png)

In the image above Requirements Task 1.1, Task 1.2, and Task 1.3 were all scheduled in order. You can see there is expected travel time between Task 1.1 and Task 1.2; this indicates a different location and was respected by RSO. 

## Configuration considerations

- Requirement dependencies are only compatible with single requirements and not Requirement Groups.

- Dependencies will only work for single resource scenarios meaning successive requirements will only be scheduled to the same resource as the predecessor was scheduled to.

## Additional Notes

- Requirment dependencies are not considered by the schedule assistant or when manually scheduling via the schedule board. 

- RSO will ensure the start time of the successor is after the end time of the predecessor and if all requirements cannot be completed on the same day RSO will schedule the following day to the same resource assuming the following day is within the time scope of RSO. In the image below requirement "Task 2.3" was scheduled on the day following requirement "Task 2.2".  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-requirement-dependency-day-gap.png)


- If needed RSO will schedule successive requirements around existing bookings in cases where an existing booking is locked and cannot be moved. 