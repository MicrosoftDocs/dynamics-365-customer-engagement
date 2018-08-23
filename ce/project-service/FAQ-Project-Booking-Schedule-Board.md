---

title: How do I create a project booking from the Schedule Board? (Dynamics 365 for Project Service) | MicrosoftDocs
description: This article describes how to create a project booking from the Schedule Board in Dynamics 365 Project Service.
author: NeilWOrint 
manager: ShellyHa
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 8/21/2018
ms.topic: article
ms.prod: Applies to Dynamics 365 Project Service versions 2.x and 3.x 
ms.service: business-applications
ms.technology: 
ms.author: john.burrows
audience: Admin

---

<!--Note from editor: The images should not all have identical captions.-->


# How do I create a project booking from the Schedule Board?

You can book a resource onto a project either directly on the project team tab of the project or by generating a resource requirement from a generic team member assignment and then fulfilling the generated requirement with a project team member.

You can also book a resource onto a project directly from the Schedule Board. There are three options for doing this:

1. From a generated resource requirement. You can generate a resource requirement after creating a generic resource and assigning tasks within a project. On the Schedule Board, these resource requirements show up on the **Open Requirements** tab.

  > [!div class="mx-imgBorder"] 
  > ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-1.png "Screenshot of bookings and assignments table")

2. Using the primary requirements generated when a project is created. These show up on the Schedule Board on the **Project** tab. If you have many projects, you might find it easier to use the column filters to find the specific project you want to book to.

  > [!div class="mx-imgBorder"] 
  > ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-2.png "Screenshot of bookings and assignments table")

3. Creating a resource requirement from scratch and booking from it. You can create a resource requirement from scratch and associate it with a project. On the Schedule Board, the resource requirement shows up on the **Open Requirements** tab.

## Book from a generated resource requirement

You can create a generic resource and assign it a task or multiple tasks within a project. You then generate a resource requirement from the generic team member. On the Schedule Board, this resource will show up on the **Open Requirements** tab. You might need to use column filters on the grid if you have many open requirements. Select the requirement. The **Find Availability** tab appears at the top of the selected row.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-3.png "Screenshot of bookings and assignments table")
 
Selecting the tab launches the Schedule Assistant mode of the Schedule Board and filters the available resources that meet the resource requirement.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-4.png "Screenshot of bookings and assignments table")
 
From there you can book a resource.

You can also drag and drop the selected row from the bottom of the Schedule Board to a resource in the grid above. Select the requirement and drag it to a resource’s cell.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-5.png "")
 
When you drop it, it opens the **Create Resource Booking** panel on the right.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-6.png "")
 
Selecting **Book** books the resource onto the project team.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-7.png "")
 
## Book from the Primary Requirement

Creating a project in Project Service automatically creates a resource requirement called the Primary Requirement. This is an empty requirement that is used to quickly book a resource with the Schedule Board without either generating a requirement or creating one from scratch. Because the requirement is empty, you’ll need to specify dates as well as the allocation method and hours if applicable. 

To book a resource with the Primary Requirement, on the Schedule Board, select the **Project** tab. You might need to use the column filter on the Project column if you have many projects.

Select the requirement that only has the project name as its name and has a duration of 0.
 
> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-8.png "")

Select the **Find Availability** tab that appears on the row. This puts the Schedule Board in the Schedule Assistant mode and shows available resources that can be booked onto the project.

Because a Primary Requirement is an empty requirement with 0 duration, you’ll need to set the duration on the **Create Resource Booking** panel when selecting and booking a resource.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-9.png "")
 
You can also select the Project Primary Requirement at the bottom of the Schedule Board and drag and drop it on a resource to book it.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-10.png "")
 
Since the Primary Requirement is an empty requirement that has 0 duration, you’ll need to set the duration on the **Create Resource Booking** panel when selecting and booking a resource.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-11.png "")
 
When you book a resource through the Primary Requirement on the Schedule Board, you add it to the project team without any assignments.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-12.png "")
 
## Book from a new resource requirement

Go to **Resource Requirements** and select **New** to create a new resource requirement.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-13.png "")
 
Associate the requirement to a project by selecting the **Project** tab of the requirement and selecting a project.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-14.png "")
 
This newly created requirement shows as an Open Requirement on the Schedule Board that you can fulfill.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-15.png "")

Booking the resource adds it to the project team.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-16.png "")
 
Now that the resource is booked, you need to assign tasks manually.

> [!div class="mx-imgBorder"] 
> ![Screenshot of bookings and assignments table](media/FAQ-Project-Booking-Schedule-Board-17.png "")
 
