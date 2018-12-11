---
title: Book named resources
description: This topic provides information about booking named resources.
author: JohnPBurrows
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 11/29/2018
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: jburrows
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Book named resources

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

You can assign a named resource to a generic resource that has a requirement for a task or a project team.

1. In PSA, on the **Projects** page, click the **Team** tab.
2. Select the generic resource from the list and then click **Book**. Or, open the resource requirement and then click **Book**.


![Booking a generic team member](media/RM-how-to-14.png)


3. On the **Schedule Assistant** page select a named resource to book onto your project team and then click **Book**.

![Booking a generic team member using schedule assistant](media/RM-how-to-15.png)

When the booking is complete and fulfilled by a named resource, the generic resource is replaced with the named resource.

![Named team member replacing a generic team member](media/RM-how-to-16.png)

The assignments on the schedule are updated with the named resource as well.

![Named team member assigned to project tasks](media/RM-how-to-17.png)

## Fulfill a generic resource with multiple named resources

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)] 

Fulfilling a requirement for a generic resource with multiple real resources fis similar to assigned a single named resource to flow as a single resource described above.

For example, here is a task with a duration of 5 days and effort hours of 120hrs. This task cannot be completed by one resource that works a typical 8hr day over a 5 day week.

![A task that needs 120 hours of effort over five days](media/RM-how-to-21.png)

The requirement is for 120hrs of a Robotics engineert over 5 days, which is 24hrs per day.

![Per day requirement](media/RM-how-to-22.png)

Thus, you will need to book multiple resources to fulfill the requirement.

![Booking multiple resources to fulfill the requirement](media/RM-how-to-23.png)

The main difference in this scenario is that the generic resource remains on the team with the assignment to the task and the booked real team members are not assigned as part of the position. The project manager will then be able to assign the work as they see fit to the real resources. The Reconciliation view can assist a project manager in breaking up the bookings across multiple resources to task assignments. The reason this is not done automatically is because in any scenario more complicated than the simple one above, such as where you have a bundle of tasks making up the requirement, the intent of how the project manager wants to assign, needs to be assumed by the system. Since the system cannot understand intent, chances are the assumptions will be different than intended and an incorrect or unpredictable result will happen. 
Then predictable outcome is that the generic remains assigned until the project manager deliberately assigns, with the assistance of the Reconciliation view.


