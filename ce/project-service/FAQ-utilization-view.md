---

title: View chargeable utilization for resources
description: This topic provides information about the resource utilization view.
author: ruhercul                     
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 9/26/2019
ms.topic: article
ms.prod: Applies to all versions of Project Service
ms.service: business-applications
ms.technology: Applies to all versions of Project Service
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

# View chargeable utilization for resources
 
The **Utilization View** on the **Project Service Resource Utilization** page shows the chargeable utilization for each bookable resource. Because the view is based on the schedule board, you’ll find many of the same functions.

> ![Screenshot of Utilization View](media/FAQ-utilization-1.png)
 

The chargeable utilization calculation works as follows:

   Chargeable utilization = Chargeable actual hours / resource capacity

The cells represent the calculated chargeable utilization for the selected period for the view (days, weeks, or months).
The colors in each cell show the chargeable utilization for a resource as compared to their target chargeable utilization. The colors show the following status:

- Green: billable utilization >= resource target utilization
- Yellow: target utilization – 20 <= billable utilization < target utilization
- Red: billable utilization < target utilization – 20

The target utilization can be set on the resource’s default role or on the individual resource itself. The calculation looks at the individual for the target first,  and then to the resource’s default role.
You can set the target on a resource by selecting **Resources** \> **Resources**. Select a resource to open the record and then, on the **Project Service** tab, you can set the resource’s target utilization.

> ![Screenshot of using the Project Service tab to set target utilization](media/FAQ-utilization-2.png)
 
To set the target utilization on a role, go to **Resources** \> **Resource Roles**. Select a role and open the record. Set the target utilization for the role.


> ![Screenshot of using Resource Roles to set the target utilization](media/FAQ-utilization-3.png)
 
To calculate chargeable utilization for a resource, you will need to complete some prequisites. First, the target utilization must be set on either the individual resource or on resource roles. 
If you are using resource roles for targets, each individual resource must have a default role. To set this, go to **Resources** \> **Resources**. Select a resource, open the record, and then select the **Project Service** tab. In the **Resource Role** grid, make sure there’s one role for the resource and **Is Default** is set to **Yes**.
 
The resource roles must be set to have a billing type of **Chargeable**. Go to **Resources** \> **Resource Roles**. Open the record you want to update, and then set the billing type default to **Chargeable**.
 
The resource must have working hours for the capacity calculation. To set this, go to **Resources** \> **Resources**. Select a resource to open the record, and then select **Show Work Hours**. You can bulk-update the list of resources by applying a **Work Hour Template** from the **Resource List** view.

The chargeable actual hours are sourced from the **Actuals** entity. Actuals with a billing type of **Chargeable** are included in the calculation and for this reason you must have projects where the actuals that are chargeable.

If you are not seeing chargeable utilization, here are some things you can check:

- The resource has working hours defined for capacity.
- The resource has either an individually defined utilization target or has a default role assigned to it. The role has a utilization target defined for it.
- Actuals have a billing type of **Chargeable** for the period you are expecting a utilization calculation for. Check the following if you are seeing actuals with billing types other than chargeable:

  - The role used on the actual has a default billing type of something other than chargeable.
  - The role on the project contract line backing the project has been set to non-chargeable.
  - The project does not have an associated contract line.

