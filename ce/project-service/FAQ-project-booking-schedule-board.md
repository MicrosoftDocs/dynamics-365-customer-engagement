---

title: Create a project booking from the Schedule board
description: This topic provides information about how to create a project booking from the schedule board.
author: ruhercul 
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 9/26/2019
ms.topic: article
ms.prod: Applies to Dynamics 365 for Customer Engagement Project Service versions 2.x and 3.x 
ms.service: business-applications
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

# Create a project booking from the Schedule board

You can book a resource onto a project directly from the **Team** tab of the project or by generating a resource requirement from a generic team member assignment and then fulfilling the generated requirement with a project team member.

You can also book a resource onto a project directly from the Schedule board. There are three ways to do this:

- From a generated resource requirement: You can generate a resource requirement after you create a generic resource and assign tasks within a project. On the Schedule board, these resource requirements show up on the **Open Requirements** tab.

  > ![Open Requirements tab on the Schedule board](media/FAQ-Project-Booking-Schedule-Board-1.png "Screenshot of bookings and assignments table")

- Using the primary requirements generated when a project is created: The primary requirements show up on the schedule board on the **Project** tab. If you have multiple projects, you might find it easier to use the column filters to find the specific project you want to book to.

  > ![Column filters on the Schedule board](media/FAQ-Project-Booking-Schedule-Board-2.png "Screenshot of bookings and assignments table")

- Creating and booking a resource requirement from scratch: You can create a resource requirement from scratch and associate it with a project. On the Schedule board, the resource requirement shows up on the **Open Requirements** tab.

## Book from a generated resource requirement

You can create a generic resource and assign it one or more tasks within a project. Then, you can generate a resource requirement from the generic team member. On the schedule board, this resource will show up on the **Open Requirements** tab. You might need to use column filters on the grid if you have many open requirements. When you select the requirement, the **Find Availability** tab will appear at the top of the selected row.
 
When you select the tab, the Schedule Assistant mode of the schedule board opens and then filters the available resources that meet the resource requirement. After that, you can book a resource.

You can also drag and drop the selected row from the bottom of the schedule board to a resource cell in the grid above.
 
When you drop it, it opens the **Create Resource Booking** panel on the right.

> ![Create Resource Booking panel](media/FAQ-Project-Booking-Schedule-Board-6.png "")
 
Selecting **Book** books the resource onto the project team.

## Book from the Primary Requirement

Creating a project in Project Service automatically creates a resource requirement called the Primary Requirement. This is an empty requirement that is used to quickly book a resource with the schedule board without either generating a requirement or creating one from scratch. Because the requirement is empty, you’ll need to specify dates as well as the allocation method and hours if applicable. 

1. To book a resource with the Primary Requirement, on the schedule board, select the **Project** tab. You might need to use the column filter on the Project column if you have many projects.
2. Select the requirement that only has the project name as its name and has a duration of zero (0).
3. Select the **Find Availability** tab that appears on the row. This puts the schedule board in Schedule Assistant mode and shows the available resources that can be booked onto the project.
4. Because a **Primary Requirement** is an empty requirement with zero (0) duration, you’ll need to set the duration on the **Create Resource Booking** panel when selecting and booking a resource.
5. You can also select the **Project Primary Requirement** at the bottom of the schedule board and drag and drop it on a resource to book it.
 
Because the **Primary Requirement** is an empty requirement that has zero (0) duration, you’ll need to set the duration on the **Create Resource Booking** panel when you select and book a resource.
 
When you book a resource through the **Primary Requirement** on the schedule board, you add it to the project team without any assignments.
 
## Book from a new resource requirement
Complete the following steps to book from a new resource requirement. 

1. Go to **Resource Requirements**, and then select **New** to create a new resource requirement.
2. On the **Project** tab, select a project to associate the requirement to the project.
 
    On the Schedule board, this new requirement shows as an **Open Requirement** that you can fulfill.

3. Book the resource to add it to the project team.
4. Now that the resource is booked, you must assign tasks manually.
