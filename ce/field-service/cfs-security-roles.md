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

Field service administrators should be given full access to IoT entities as these users may need a full view of IoT alerts across all devices and the ability to register new IoT devices.

Field Service administrators are typically given a copy of the **Field Service - Administrator** security role. 

If your organization is utilizing Connected Field Service, these users should also be assigned a copy of the **IoT - Administrator** security role.

Ensure this gives field service administrators full access to IoT entities according to the image below.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-administrator.png)

In addition, the field service administrator security role should be given full access to the "CFS - IoT Alert Process Flow".

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-administrator-bpf.png)

## Add IoT security to dispatcher role

Field service dispatchers also need some level of access to IoT entities and records. As an example, if a work order is created as a result of an IoT alert, the dispatcher should know this information to communicate with the customer and schedule to the appropriate resources/technicians.

Field Service dispatchers are typically given a copy of the **Field Service - Dispatcher** security role. 

Manually assign the dispatcher security role limited access to IoT entities according to the image below.
> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-dispatcher.png)

Do the same for the "CFS - IoT Alert Process Flow" for dispatchers.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-dispatcher-bpf.png)

## Add IoT security to resource security role

Finally, resources/technicians also need access to IoT related entities and records related to the work they are responsible for.

Find the resource security role your organization assigns to resources/technicians (typically a copy of the Field Service - Resource security role) and add access to IoT entities according to the image below.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-resource.png)

Because resources/technicians use the Field Service Mobile app, they do not need access to the "CFS - IoT Alert Process Flow."


## Additional notes

- Any user who needs to do device registration and device data pulls (IoT Hub operations) should be given the **IoT Administrator** and **IoT Endpoint User** security roles.






