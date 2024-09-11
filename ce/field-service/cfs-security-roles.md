---
title: Security roles for Connected Field Service
description: Learn about security roles in Connected Field Service
ms.date: 09/04/2024
ms.subservice: connected-field-service
ms.topic: conceptual
ms.author: vhorvath
author: vhorvathms
---

# Security roles for Connected Field Service

Security roles for Connected Field Service allow administrators to give appropriate access to Internet of Things (IoT) tables, including alerts, assets, devices, and commands. Add these security roles to existing Field Service security roles for field service administrators, dispatchers, and resources.

In general, access to IoT tables should mimic access to the customer asset table for field service administrators, dispatchers, and resources.

## Prerequisites

- Dynamics 365 system administrator access

- General knowledge of Field Service security roles. For more information, go to [Set up users and security roles](users-licenses-permissions.md).

> [!Note]
> We recommend you make copies of the Field Service security roles and assign the copied security roles to users. This prevents product updates from overwriting your custom security configurations. To copy a security role, go to [Copy a security role](/power-platform/admin/database-security).

## Add IoT security to administrator security role

In the Power Platform admin center, give Field Service administrators full access to all IoT tables. These users need a full view of IoT alerts across all devices and be able to register new IoT devices. They're typically given a copy of the **Field Service - Administrator** security role.

If your organization is using Connected Field Service, these administrators should also be assigned a copy of the **IoT - Administrator** security role.

With fully enabled IoT administrator permissions, Field Service administrators should have access to all IoT tables, allowing them to:

- Create
- Read
- Write
- Delete
- Append
- Append to
- Assign
- Share

See the following screenshot for reference.

> [!div class="mx-imgBorder"]
> ![Screenshot of the IoT tables that Field Service administrators should have access to.](media/cfs-security-role-administrator.png)

The Field Service administrator security role should also be given full access to the **CFS - IoT Alert Process Flow**, which is a business process flow for Connected Field Service.

## Add IoT security to dispatcher role

Field Service dispatchers also need some level of access to IoT tables and records. For example, if a work order is created as a result of an IoT alert, the dispatcher should be aware so that they can communicate with the customer and schedule to the appropriate resources.

In the Power Platform admin center, find the dispatcher security role your organization assigns to dispatchers (typically a copy of the **Field Service - Dispatcher** security role). Assign limited access to IoT tables according to the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of enabled permissions for the dispatcher.](media/cfs-security-role-dispatcher.png)

Next, add access to the **CFS - IoT Alert Process Flow** according to the following screenshot. Dispatchers can use the Connected Field Service business process flow to update and track the stages of work orders resulting from IoT alerts.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Security Role: Field Service - Dispatcher window showing the corresponding IOT tables selected.](media/cfs-security-role-dispatcher-bpf.png)

## Add IoT security to resource security role

Finally, resources also need access to IoT tables and records related to the work they're responsible for.

Find the resource security role your organization assigns to resources or technicians (typically a copy of the **Field Service - Resource** security role), and manually assign limited access to IoT tables according to the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of the field service resource permissions.](media/cfs-security-role-resource.png)

Because business process flows aren't displayed on the Field Service mobile app, resources don't need access to the **CFS - IoT Alert Process Flow.**

Any user who needs to work with device registration and device data pulls (IoT Hub operations) should be given the **IoT Administrator** and **IoT Endpoint User** security roles.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
