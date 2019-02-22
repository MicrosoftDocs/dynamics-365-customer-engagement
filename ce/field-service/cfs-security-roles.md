---
title: "Security Roles for Connected Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/21/2019
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

# Security Roles for Connected Field Service

Security for connected field service entities should be added to existing field service security roles for field service administrators, dispatchers, and resources/technicians. 

Doing this will give appropriate access to IoT entities including but not limited to IoT Alerts, Assets, Devices and Commands which are included with Field Service v8.3+.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-entities-navbar.png)

In general, the access a field service administrator, dispatcher, and resources/technician should be given to IoT entities mimics the access the existing field service security role gives to the Customer Asset entity.

## Prerequisites

- Field Service 8.3+
- It is highly recommended to make copies of the Field Service security roles and assign the copied security roles to users. this will prevent product updates from overwriting your custom security. 
> [!div class="mx-imgBorder"]
> ![Screenshot of copying a security role](media/admin-security-role-copy.png) 


## Add IoT security to administrator security role

Field Service administrators are typically given a copy of the **Field Service - Administrator** security role. If your organization is utilizing connected field service, these users should also be assigned a copy of the **IoT Administrator** security role.

 field service administrator should also be given full read/write access to the IoT entities according to the picture below. 




> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-administrator.png)

In addition, the field service administrator secuirty role should be given full access to the CFS business process flow.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-administrator-bpf.png)

## Add IoT security to dispatcher role

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-dispatcher.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-dispatcher-bpf.png)

## Add IoT security to resource security role

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-resource.png)


## Additional notes

- Any user who needs to do device registration and device data pulls (IoT Hub operations) should be given the **IoT Administrator** and **IoT Endpoint User** security roles.






