---
title: Overview of Universal Resource Scheduling in Dynamics 365
description: Schedule any entity using Universal Resource Scheduling in Dynamics 365.
ms.date: 07/25/2025
ms.reviewer: v-wendysmith
ms.subservice: common-scheduler
ms.topic: overview
author: mkelleher-msft
ms.author: mkelleher
---
# Overview of Universal Resource Scheduling in Dynamics 365

Universal Resource Scheduling is a Dynamics 365 solution that allows organizations to assign resources to jobs and tasks. It helps assign the best resources to jobs and tasks based on availability, skills, promised time, business units, geographies, and more. Admins enable scheduling for entities in Dynamics 365 applications, including custom entities.
  
- Dynamics 365 Field Service: [Schedule and assign work orders to the closest field technicians in the area](../field-service/universal-resource-scheduling-for-field-service.md).

- Dynamics 365 Customer Service: [Book cases to customer service reps in the right department and time zone](/dynamics365/customer-service/basics-service-service-scheduling).

- Dynamics 365 Project Operations: [Staff projects with consultants who have availability and the appropriate skill set](/dynamics365/project-operations/psa/overview).

> [!CAUTION]
> Administrators of these three apps, which rely on Universal Resource Scheduling, can access all default entities within the Universal Resource Scheduling solution. If a user creates a trial for one of these applications, they get admin permissions and can access all the entities.

## Prerequisites
  
- You have access to the Dynamics 365 Field Service, Project Operations, or Customer Service application.

## Enable scheduling for another entity

You can also enable scheduling for another entity, including custom entities. Once enabled, the system creates a resource requirement record related to the entity. This way, when you create a resource requirement, the system automatically checks which entity the resource requirement is for.

Learn more in [Enable an entity for scheduling in Universal Resource Scheduling](schedule-new-entity.md).
  
## Schedule something

### Step 1: Create a resource requirement  
  
1. In the Dynamics 365 application, select a record of an entity that has scheduling enabled.

1. On the record, open the related **Resource Requirement** list and select **New**.
  
1. Enter the required information and **Save** the record.  
  
A plugin checks the relationships and automatically sets the booking setup metadata.  
  
### Step 2: Schedule the booking requirement
  
1. From the main menu, go to **Resource Scheduling** > **Schedule Board**.  
  
2. From the **Booking Requirement** list, select an unscheduled booking and drag the item to an available resource and time slot on the schedule board.  
  
Or select **Book** on an entity record that has scheduling enabled, then use the schedule assistant to book the requirement.  

## Next step

[Configure the schedule board tab settings in Universal Resource Scheduling](schedule-board-tab-settings.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
