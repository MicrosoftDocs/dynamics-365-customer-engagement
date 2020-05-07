---
title: Manage security roles in Service Scheduling (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to manage security roles in service scheduling in Dynamics 365 Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/20/2018
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Manage security roles in service scheduling

Security roles help to identify the privileges a user can exercise in the system. Security roles also define which entities a user can view or configure. For example, a user may have permission to see accounts but cannot see specific fields of an account.

The following standard security roles are leveraged in service scheduling:
  
- **Customer Service Manager (CSM)**. The Customer Service Manager role can set up the service scheduling experience. This role can access and set up all service scheduling entities in the system:

   - Resources
   - Resource Categories
   - Facilites/Equipment
   - Services
   - Service Activities
   - Schedule Board
   - Organizational Units
   - Business Closure

   However, to ensure that all schedule managers are able to set up the new scheduling experience and access the new scheduling entities, they should also be assigned the **Customer Service Schedule Administrator** and the **Schedule Manager** role.

   To learn more about how to create users and assign roles to them, see [Create users and assign security roles](../admin/create-users-assign-online-security-roles.md). 

- **Scheduler**. The Customer Service Representative can create and schedule service activities. 

  To ensure that all Scheduler users are able to schedule services using the new scheduling experience, they should also be assigned the **Customer Service Scheduler** and **Customer Service App Access** role. 

  ![csr-role](media/csr-role.png)


[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](../admin/security-roles-privileges.md)

## Understand roles and their privileges

Each role in the scheduling experience is expected to perform a set of actions. Refer the table below to learn more about the privileges of the Schedule Manager and Scheduler role:

|Role  |Privileges  |
|---------|---------|
|Schedule Manager    |     Can create, access, and perform CRUD operations on Services    |
|      |   Can create, access, and perform CRUD operations on Service Activities      |
|     |    Can access Schedule Board     |
|   |   Can create and access Facilities and Equipment      |
|Scheduler     |    Can create, access, and perform CRUD operations on Service Activities      |
|    | Can access Schedule Board         |
|    |   Can create and access Facilities and Equipment      |




### See also  

[Create or edit a security role to manage access](../admin/create-edit-security-role.md)
