---
title: Manage security roles in Service Scheduling (Dynamics 365 for Customer Service) | MicrosoftDocs
description: Know how to manage security roles in service scheduling in Dynamics 365 for Customer Service
keywords: Resources; Service scheduling; Dynamics 365; Customer Service; Universal Resource Scheduling (URS)
author: anjgupta
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: 82eeeb62-3206-46d0-86ea-da16aa5792cc
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Manage security roles in service scheduling

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]


A user in Customer Service is a member of your organization who will use a Service Scheduling license. Security roles help to identify the privileges a user can exercise in the system. Security roles also define which entities a user can view or configure. For example, a user may have permission to see accounts but not to see specific fields for an account.

The predefined roles in service scheduling are:
  
- **Customer Service Manager (CSM)**. The Customer Service Manager role can setup the service scheduling experience. This role has access to all service scheduling entities.
- **Customer Service Representative (CSR)**. The Customer Service Representative can create and schedule service activities. 
- **Customer Service Scheduler**.
- **Customer Service Schedule Administrator**. 

> [!NOTE]
> To ensure that all CSR users are able to schedule using the scheduling experience, they should also be assigned the Customer Service Scheduler role. </br>  </br>
Similarly, to ensure that all CSM users are able to set up the scheduling experience, they should also be assigned the Customer Service Schedule Administrator role.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security roles and privileges](../admin/security-roles-privileges.md)

## Understand roles and their functionalities

Each role in the scheduling experience is expected to perform a set of functionalities. Refer the table below to know more about the privileges of the CSM and CSR role:

|Role  |Functionality  |
|---------|---------|
|Customer Service Manager (CSM)     |     Can create, access, and perform CRUD operations on Services    |
|      |   Can create, access, and perform CRUD operations on Service Activities      |
|     |    Can access Schedule Board     |
|   |   Can create, and access Facilities and Equipment      |
|Customer Service Representative (CSR)     |    Can create, access, and perform CRUD operations on Service Activities      |
|    | Can access Schedule Board         |
|    |   Can create, and access Facilities and Equipment      |




### See also  

[Create or edit a security role to manage access](../admin/create-edit-security-role.md)
