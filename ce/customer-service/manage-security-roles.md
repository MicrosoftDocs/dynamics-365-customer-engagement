---
title: Manage security roles in Service Scheduling | MicrosoftDocs
description: This topic provides information on how to manage security roles in service scheduling in Dynamics 365 Customer Service.
ms.date: 05/08/2020
ms.topic: article
author: lalexms
ms.author: laalexan
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# Manage security roles in service scheduling

Security roles help to identify the privileges a user can exercise in the system. Security roles also define which entities a user can view or configure. For example, a user may have permission to see accounts but cannot see specific fields of an account.

The following standard security roles are leveraged in service scheduling:
  
- **Scheduler Manager**. This role can set up the service scheduling experience. This role can access and set up all service scheduling entities in the system:

   - Resources
   - Resource Categories
   - Facilites/Equipment
   - Services
   - Service Activities
   - Schedule Board
   - Organizational Units
   - Business Closure

   However, to ensure that all Scheduler Managers are able to set up the new scheduling experience and access the new scheduling entities, they should also be assigned the **Customer Service Schedule Administrator** and **Schedule Manager** roles.

   To learn more about how to create users and assign roles to them, see [Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles). 

- **Scheduler**. This role can create and schedule service activities. 

  To ensure that all Scheduler users are able to schedule services using the new scheduling experience, they should also be assigned the **Customer Service Scheduler** and **Scheduler** roles. 

 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](/power-platform/admin/security-roles-privileges)

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

[Create or edit a security role to manage access](/power-platform/admin/create-edit-security-role)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
