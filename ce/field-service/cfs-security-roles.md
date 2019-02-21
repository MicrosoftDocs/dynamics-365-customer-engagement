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

Goal is to enable existing Field Service users (such as dispatchers, technicians/resources & administrators) to access CFS/IoT entities.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-entities-navbar.png)

In general, mimic the 'Customer Asset' permissions for IoT entities

## Prerequisites

Pre-req: FS 8.3
Best practice on security roles (applies to all of FS and not just CFS)
	- Copy existing out of box roles and customize your own copy.
Product updates will overwrite any changes made to the security roles.

## Add IoT security to administrator security role


For FS Admin users, add IoT Admin role as well.
	- GR: best practice 

Any user who needs to do device registration and device data pulls (IoT Hub operations) need to have one of these roles - Sys Admin/ IoT Admin/ Iot Endpoint user role.
GR: For IoTHub operations, it is recommended to grant these users  IoT Admin or Iot Endpoint user  security roles


> [!div class="mx-imgBorder"]
> ![Screenshot of ](media/cfs-security-role-administrator.png)


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









