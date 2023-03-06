---
title: "Overview of Universal Resource Scheduling in Dynamics 365"
description: "Schedule any entity using Universal Resource Scheduling. Make sure you meet the prerequisites, then follow these steps for scheduling an entity."
ms.date: 02/13/2023
ms.reviewer: mhart

ms.subservice: common-scheduler
ms.topic: overview

author: clearab
ms.author: anclear
manager: shellyha
search.app: 
  - D365CE
  - D365PS
  - D365FS
---
# Overview of Universal Resource Scheduling in Dynamics 365

Universal Resource Scheduling is a Dynamics 365 solution that allows organizations to assign resources to jobs and tasks. It helps assign the best resources to jobs and tasks based on availability, skills, promised time, business units, geographies, and more. Admins enable scheduling for entities in Dynamics 365 applications, including custom entities.
  
- Dynamics 365 Field Service: [Schedule and assign work orders to the closest field technicians in the area](../field-service/universal-resource-scheduling-for-field-service.md).

- Dynamics 365 Customer Service: [Book cases to customer service reps in the right department and time zone](/dynamics365/customer-service/basics-service-service-scheduling).

- Dynamics 365 Project Operations: [Staff projects with consultants who have availability and the appropriate skill set](/dynamics365/project-operations/psa/overview).

- Microsoft Cloud for Financial Services: [Set up virtual or in-person appointments with banking advisors, based on skill matching, availability optimization and contextual information](/industry/financial-services/).

## Prerequisites

 Before you can use Universal Resource Scheduling, make sure you have:  
  
- Dynamics 365 Field Service, Project Operations, Customer Service, or Microsoft Cloud for Financial Services.
  
- User credentials with the Universal Resource Scheduling security role, in order to manage the solution once it has been deployed.
  
## Enable scheduling for another entity

You can also enable scheduling for another entity, including custom entities. Once enabled, the system creates a resource requirement record related to the entity. This way, when you create a resource requirement, the system automatically checks which entity the resource requirement is for.

For more information, see [Enable an entity for scheduling in Universal Resource Scheduling](schedule-new-entity.md).
  
## Schedule something

### Step 1: Create a resource requirement  
  
1. In the Dynamics 365 application, select a record of an entity that has scheduling enabled.

1. On the record, open the related **Resource Requirement** list and select **New**.
  
1. Enter the required information and **Save** the record.  
  
A plugin checks the relationships and automatically sets the booking setup metadata.  
  
### Step 2: Schedule the booking requirement
  
1. From the main menu, go to **Resource Scheduling** > **Schedule Board**.  
  
2. From the **Booking Requirement** list, select an unscheduled booking and drag the item to an available resource/time slot on the schedule board.  
  
Or select **Book** on an entity record that has scheduling enabled, then use the schedule assistant to book the requirement.  

## Enable the legacy schedule board

> [!NOTE]
> This functionality is available in the 2023 Wave 1 Early Access (EA) release, and not yet generally available.

[!INCLUDE[enable-legacy-sb.md](../shared/urs/enable-legacy-sb.md)]

## Next steps

- [Configure the schedule board tab settings in Universal Resource Scheduling](schedule-board-tab-settings.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
